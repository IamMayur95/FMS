using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using FMS.Data.Contexts;
using Utils.Common.Extensions;
using Utils.Data.Interfaces;
using FMS.Entities.Models;
using FMS.Core.Common.Contracts.Api;
using System.Collections.Generic;
using FMS.Data.Contexts;
using System.IO;
using FMS.Entities.Models.Enums;

namespace FMS.Data.Seed
{
    public class DbInitializer : IDbInitializer
    {
        private readonly FMSContext _dbContext;
        private readonly IWebHostEnvironment _environment;
        private readonly ILogger<IDbInitializer> _logger;

        public DbInitializer(
            FMSContext dbContext,
            ILogger<IDbInitializer> logger,
            IWebHostEnvironment environment
        )
        {
            _dbContext = dbContext;
            _logger = logger;
            _environment = environment;
        }

        public async Task MigrateAndSeedIfNeededAsync()
        {
            var pendingMigrations = _dbContext.Database?.GetPendingMigrations()?.ToList();
            if (pendingMigrations?.Count > 0)
            {
                _dbContext.Database.Migrate();

                // System data seeding is only applied on new/empty DB (aka: localDB or brand new test environments)
                var allMigrations = _dbContext.Database.GetMigrations().ToList();
                if (!_environment.IsProduction() && !allMigrations.Except(pendingMigrations).Any())
                {
                    SeedSystemData(_dbContext);
                }
            }

            await Task.CompletedTask;
        }

        #region Seeders

        private void SeedSystemData(FMSContext context)
        {
            _logger.LogInformation("=== Seeding SystemData... ===");

            SeedStatusTypes(context);
            SeedLocationDetails(context);
            SeedBuildingDetails(context);
            SeedFloorDetails(context);
            SeedBangaloreBayDetails(context);
            SeedPuneFloorDetails(context);
            SeedDeskDetails(context);
            SeedPermissionGroups(context);
            SeedUserPermissionGroups(context);
        }

        private void SeedStatusTypes(FMSContext context)
        {
            _logger.LogInformation("Seeding Status type...");

            if (context.StatusTypes.Any())
            {
                return;
            }

            context.StatusTypes.Add(new StatusType { Name = "Free", Type = FMSBookingType.Desk });
            context.StatusTypes.Add(new StatusType { Name = "Booked", Type = FMSBookingType.Desk });
            context.StatusTypes.Add(new StatusType { Name = "Cancelled", Type = FMSBookingType.Desk });
            context.StatusTypes.Add(new StatusType { Name = "Maintenance", Type = FMSBookingType.Desk });

            context.SaveChanges();

        }

        private void SeedLocationDetails(FMSContext context)
        {
            _logger.LogInformation("Seeding locations...");

            if (context.LocationDetails.Any())
            {
                return;
            }

            context.LocationDetails.Add(new LocationDetail { Name = "Bangalore", Order = 1 });
            context.LocationDetails.Add(new LocationDetail { Name = "Pune", Order = 2 });

            context.SaveChanges();

        }

        private void SeedBuildingDetails(FMSContext context)
        {
            _logger.LogInformation("Seeding building details...");

            if (context.BuildingDetails.Any())
            {
                return;
            }


            var puneLocationDetails = context.LocationDetails.Where(a => a.Name == "Pune").FirstOrDefault();
            var bangaloreLocationDetails = context.LocationDetails.Where(a => a.Name == "Bangalore").FirstOrDefault();
            if (bangaloreLocationDetails is not null)
            {
                context.BuildingDetails.Add(new BuildingDetail { Name = "Building 1", LocationDetailId = bangaloreLocationDetails.Id, Order = 1 });
                context.BuildingDetails.Add(new BuildingDetail { Name = "Building 2", LocationDetailId = bangaloreLocationDetails.Id, Order = 2 });
            }
            if (puneLocationDetails is not null)
            {
                context.BuildingDetails.Add(new BuildingDetail { Name = "Building 1", LocationDetailId = puneLocationDetails.Id, Order = 1 });
            }

            context.SaveChanges();
        }

        private void SeedFloorDetails(FMSContext context)
        {
            _logger.LogInformation("Seeding floor details...");

            if (context.FloorDetails.Any())
            {
                return;
            }

            var bangaloreDetails = context.BuildingDetails.Where(a => a.Name == "Building 1" && a.LocationDetail.Name == "Bangalore").FirstOrDefault();
            var puneDetails = context.BuildingDetails.Where(a => a.Name == "Building 1" && a.LocationDetail.Name == "Pune").FirstOrDefault();
            if (bangaloreDetails is not null)
            {
                context.FloorDetails.Add(new FloorDetail { Name = "1st Floor", BuildingDetailId = bangaloreDetails.Id, Order = 1, IsActive = false });
                context.FloorDetails.Add(new FloorDetail { Name = "2nd Floor", BuildingDetailId = bangaloreDetails.Id, Order = 2, IsActive = false });
                context.FloorDetails.Add(new FloorDetail { Name = "3rd Floor", BuildingDetailId = bangaloreDetails.Id, Order = 3, IsActive = false });
                context.FloorDetails.Add(new FloorDetail { Name = "4th Floor", BuildingDetailId = bangaloreDetails.Id, Order = 4, IsActive = true });
            }

            if (puneDetails is not null)
            {
                context.FloorDetails.Add(new FloorDetail { Name = "4th Floor", BuildingDetailId = puneDetails.Id, Order = 5, IsActive = true });
                context.FloorDetails.Add(new FloorDetail { Name = "5th Floor", BuildingDetailId = puneDetails.Id, Order = 6, IsActive = true });
                context.FloorDetails.Add(new FloorDetail { Name = "6th Floor", BuildingDetailId = puneDetails.Id, Order = 7, IsActive = true });
                context.FloorDetails.Add(new FloorDetail { Name = "7th Floor", BuildingDetailId = puneDetails.Id, Order = 8, IsActive = true });
                context.FloorDetails.Add(new FloorDetail { Name = "8th Floor", BuildingDetailId = puneDetails.Id, Order = 9, IsActive = true });
            }

            context.SaveChanges();
        }

        private void SeedBangaloreBayDetails(FMSContext context)
        {
            _logger.LogInformation("Seeding wing details...");

            if (context.WingDetails.Any())
            {
                return;
            }

            var floorDetails = context.FloorDetails.Include(a => a.BuildingDetail.LocationDetail).Where(a => a.Name == "4th Floor" && a.BuildingDetail.LocationDetail.Name == "Bangalore").FirstOrDefault();
            if (floorDetails is not null)
            {
                context.WingDetails.Add(new WingDetail { Name = "Bay 1", FloorDetailId = floorDetails.Id, Order = 1 });

                context.SaveChanges();
            }
        }

        private void SeedPuneFloorDetails(FMSContext context)
        {
            _logger.LogInformation("Seeding pune floor details...");

            var floorDetails = context.FloorDetails.Include(a => a.BuildingDetail.LocationDetail).Where(a => a.Name == "4th Floor" && a.BuildingDetail.LocationDetail.Name == "Pune").FirstOrDefault();
            if (floorDetails is not null)
            {
                context.WingDetails.Add(new WingDetail { Name = "South West", FloorDetailId = floorDetails.Id, Order = 1 });
                context.WingDetails.Add(new WingDetail { Name = "North West", FloorDetailId = floorDetails.Id, Order = 2 });
                context.WingDetails.Add(new WingDetail { Name = "South East", FloorDetailId = floorDetails.Id, Order = 3 });
                context.WingDetails.Add(new WingDetail { Name = "North East", FloorDetailId = floorDetails.Id, Order = 4 });
            }

            floorDetails = context.FloorDetails.Include(a => a.BuildingDetail.LocationDetail).Where(a => a.Name == "5th Floor" && a.BuildingDetail.LocationDetail.Name == "Pune").FirstOrDefault();
            if (floorDetails is not null)
            {
                context.WingDetails.Add(new WingDetail { Name = "South West", FloorDetailId = floorDetails.Id, Order = 1 });
                context.WingDetails.Add(new WingDetail { Name = "North West", FloorDetailId = floorDetails.Id, Order = 2 });
                context.WingDetails.Add(new WingDetail { Name = "South East", FloorDetailId = floorDetails.Id, Order = 3 });
                context.WingDetails.Add(new WingDetail { Name = "North East", FloorDetailId = floorDetails.Id, Order = 4 });
            }


            floorDetails = context.FloorDetails.Include(a => a.BuildingDetail.LocationDetail).Where(a => a.Name == "6th Floor" && a.BuildingDetail.LocationDetail.Name == "Pune").FirstOrDefault();
            if (floorDetails is not null)
            {
                context.WingDetails.Add(new WingDetail { Name = "South West", FloorDetailId = floorDetails.Id, Order = 1 });
                context.WingDetails.Add(new WingDetail { Name = "North West", FloorDetailId = floorDetails.Id, Order = 2 });
                context.WingDetails.Add(new WingDetail { Name = "South East", FloorDetailId = floorDetails.Id, Order = 3 });
                context.WingDetails.Add(new WingDetail { Name = "North East", FloorDetailId = floorDetails.Id, Order = 4 });
            }
            floorDetails = context.FloorDetails.Include(a => a.BuildingDetail.LocationDetail).Where(a => a.Name == "7th Floor" && a.BuildingDetail.LocationDetail.Name == "Pune").FirstOrDefault();
            if (floorDetails is not null)
            {
                context.WingDetails.Add(new WingDetail { Name = "South West", FloorDetailId = floorDetails.Id, Order = 1 });
                context.WingDetails.Add(new WingDetail { Name = "North West", FloorDetailId = floorDetails.Id, Order = 2 });
                context.WingDetails.Add(new WingDetail { Name = "South East", FloorDetailId = floorDetails.Id, Order = 3 });
                context.WingDetails.Add(new WingDetail { Name = "North East", FloorDetailId = floorDetails.Id, Order = 4 });
            }

            floorDetails = context.FloorDetails.Include(a => a.BuildingDetail.LocationDetail).Where(a => a.Name == "8th Floor" && a.BuildingDetail.LocationDetail.Name == "Pune").FirstOrDefault();
            if (floorDetails is not null)
            {
                context.WingDetails.Add(new WingDetail { Name = "South West", FloorDetailId = floorDetails.Id, Order = 1 });
                context.WingDetails.Add(new WingDetail { Name = "North West", FloorDetailId = floorDetails.Id, Order = 2 });
                context.WingDetails.Add(new WingDetail { Name = "South East", FloorDetailId = floorDetails.Id, Order = 3 });
                context.WingDetails.Add(new WingDetail { Name = "North East", FloorDetailId = floorDetails.Id, Order = 4 });
            }

            context.SaveChanges();
        }

        private void SeedPermissionGroups(FMSContext context)
        {
            _logger.LogInformation("Seeding Permission Groups...");

            if (context.PermissionGroup.Any())
            {
                return;
            }

            context.PermissionGroup.Add(new Entities.Models.PermissionGroup { Name = PermissionGroupType.Admin.ToString() });

            context.SaveChanges();
        }

        private void SeedUserPermissionGroups(FMSContext context)
        {
            _logger.LogInformation("Seeding User Permission Groups...");

            if (context.UserPermissionGroup.Any())
            {
                return;
            }

            var adminGroup = context.PermissionGroup.FirstOrDefault(item => item.Name == PermissionGroupType.Admin.ToString());

            if (adminGroup is not null)
            {
                AddUserToGroup(context, "pratiksha.patil@t-systems.com", adminGroup.Id);
                AddUserToGroup(context, "dipak.jain@t-systems.com", adminGroup.Id);
                AddUserToGroup(context, "mayur.selokar@t-systems.com", adminGroup.Id);
                AddUserToGroup(context, "ritu.mehla@t-systems.com", adminGroup.Id);
                AddUserToGroup(context, "pallavi.mankar@t-systems.com", adminGroup.Id);
                AddUserToGroup(context, "sanjeev.walde@t-systems.com", adminGroup.Id);
                AddUserToGroup(context, "h.more@t-systems.com", adminGroup.Id);
            }

            context.SaveChanges();
        }

        private void AddUserToGroup(FMSContext context, string email, int groupId)
        {
            var adminUser = context.Users.FirstOrDefault(item => item.CompanyEmailId == email);

            if (adminUser is not null)
            {
                context.UserPermissionGroup.Add(new UserPermissionGroup
                {
                    UserId = adminUser.Id,
                    PermissionGroupId = groupId
                });
            }
        }

        private void SeedDeskDetails(FMSContext context)
        {
            _logger.LogInformation("Seeding desk details...");

            if (context.DeskDetails.Any())
            {
                return;
            }

            SeedBangalore4thFloorBay1DeskDetails(context);

            SeedPune4thFloorDeskDetails(context);

            SeedPune5thFloorDeskDetails(context);

            SeedPune6thFloorDeskDetails(context);

            SeedPune7thFloorDeskDetails(context);

            SeedPune8thFloorDeskDetails(context);

            context.SaveChanges();
        }

        private static void SeedBangalore4thFloorBay1DeskDetails(FMSContext context)
        {
            var bay1Details = context.WingDetails.Where(a => a.Name == "Bay 1").Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();

            if (bay1Details is not null)
            {
                for (var i = 01; i <= 386; i++)
                {
                    context.DeskDetails.Add(new DeskDetail { SeatNumber = "4.B1.WS." + i.ToString("000"), LocationDetailId = bay1Details.FloorDetail.BuildingDetail.LocationDetailId, BuildingDetailId = bay1Details.FloorDetail.BuildingDetailId, WingDetailId = bay1Details.Id, FloorDetailId = bay1Details.FloorDetailId });
                }
                for (var i = 393; i <= 396; i++)
                {
                    context.DeskDetails.Add(new DeskDetail { SeatNumber = "4.B1.WS." + i.ToString("000"), LocationDetailId = bay1Details.FloorDetail.BuildingDetail.LocationDetailId, BuildingDetailId = bay1Details.FloorDetail.BuildingDetailId, WingDetailId = bay1Details.Id, FloorDetailId = bay1Details.FloorDetailId });
                }
            }
        }
        private static void SeedPune4thFloorDeskDetails(FMSContext context)
        {
            var fourthFloorDetails = context.FloorDetails.Include(a => a.BuildingDetail.LocationDetail).Where(a => a.Name == "4th Floor" && a.BuildingDetail.LocationDetail.Name == "Pune").FirstOrDefault();
            var pune4thFloorSWDetails = context.WingDetails.Where(a => a.Name == "South West" && a.FloorDetailId == fourthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune4thFloorSWDetails is not null)
            {
                for (var i = 01; i <= 152; i++)
                {
                    context.DeskDetails.Add(new DeskDetail { SeatNumber = "4.W.WS." + i.ToString("000"), LocationDetailId = pune4thFloorSWDetails.FloorDetail.BuildingDetail.LocationDetailId, BuildingDetailId = pune4thFloorSWDetails.FloorDetail.BuildingDetailId, WingDetailId = pune4thFloorSWDetails.Id, FloorDetailId = pune4thFloorSWDetails.FloorDetailId });
                }

                for (var i = 01; i <= 26; i++)
                {
                    context.DeskDetails.Add(new DeskDetail { SeatNumber = "4.S.WS." + i.ToString("000"), LocationDetailId = pune4thFloorSWDetails.FloorDetail.BuildingDetail.LocationDetailId, BuildingDetailId = pune4thFloorSWDetails.FloorDetail.BuildingDetailId, WingDetailId = pune4thFloorSWDetails.Id, FloorDetailId = pune4thFloorSWDetails.FloorDetailId });
                }
            }

            var pune4thFloorNWDetails = context.WingDetails.Where(a => a.Name == "North West" && a.FloorDetailId == fourthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune4thFloorNWDetails is not null)
            {
                for (var i = 152; i <= 227; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "4.W.WS." + i.ToString("000"),
                        LocationDetailId = pune4thFloorNWDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune4thFloorNWDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune4thFloorNWDetails.Id,
                        FloorDetailId = pune4thFloorNWDetails.FloorDetailId
                    });
                }

            }

            var pune4thFloorNEDetails = context.WingDetails.Where(a => a.Name == "North East" && a.FloorDetailId == fourthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune4thFloorNEDetails is not null)
            {
                for (var i = 156; i <= 237; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "4.E.WS." + i.ToString("000"),
                        LocationDetailId = pune4thFloorNEDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune4thFloorNEDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune4thFloorNEDetails.Id,
                        FloorDetailId = pune4thFloorNEDetails.FloorDetailId
                    });
                }

            }
            var pune4thFloorSEDetails = context.WingDetails.Where(a => a.Name == "South East" && a.FloorDetailId == fourthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune4thFloorSEDetails is not null)
            {
                for (var i = 001; i <= 155; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "4.E.WS." + i.ToString("000"),
                        LocationDetailId = pune4thFloorSEDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune4thFloorSEDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune4thFloorSEDetails.Id,
                        FloorDetailId = pune4thFloorSEDetails.FloorDetailId
                    });
                }
            }
        }

        private static void SeedPune5thFloorDeskDetails(FMSContext context)
        {
            var fifthFloorDetails = context.FloorDetails.Include(a => a.BuildingDetail.LocationDetail).Where(a => a.Name == "5th Floor" && a.BuildingDetail.LocationDetail.Name == "Pune").FirstOrDefault();
            var pune5thFloorSWDetails = context.WingDetails.Where(a => a.Name == "South West" && a.FloorDetailId == fifthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune5thFloorSWDetails is not null)
            {
                for (var i = 001; i <= 097; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "5.W.WS." + i.ToString("000"),
                        LocationDetailId = pune5thFloorSWDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune5thFloorSWDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune5thFloorSWDetails.Id,
                        FloorDetailId = pune5thFloorSWDetails.FloorDetailId
                    });
                }

            }

            var pune5thFloorNWDetails = context.WingDetails.Where(a => a.Name == "North West" && a.FloorDetailId == fifthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune5thFloorNWDetails is not null)
            {
                for (var i = 098; i <= 165; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "5.W.WS." + i.ToString("000"),
                        LocationDetailId = pune5thFloorNWDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune5thFloorNWDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune5thFloorNWDetails.Id,
                        FloorDetailId = pune5thFloorNWDetails.FloorDetailId
                    });
                }

            }

            var pune5thFloorNEDetails = context.WingDetails.Where(a => a.Name == "North East" && a.FloorDetailId == fifthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune5thFloorNEDetails is not null)
            {
                for (var i = 085; i <= 182; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "5.E.WS." + i.ToString("000"),
                        LocationDetailId = pune5thFloorNEDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune5thFloorNEDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune5thFloorNEDetails.Id,
                        FloorDetailId = pune5thFloorNEDetails.FloorDetailId
                    });
                }

            }
            var pune5thFloorSEDetails = context.WingDetails.Where(a => a.Name == "South East" && a.FloorDetailId == fifthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune5thFloorSEDetails is not null)
            {
                for (var i = 001; i <= 084; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "5.E.WS." + i.ToString("000"),
                        LocationDetailId = pune5thFloorSEDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune5thFloorSEDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune5thFloorSEDetails.Id,
                        FloorDetailId = pune5thFloorSEDetails.FloorDetailId
                    });
                }
            }
        }

        private static void SeedPune6thFloorDeskDetails(FMSContext context)
        {
            var sixthFloorDetails = context.FloorDetails.Include(a => a.BuildingDetail.LocationDetail).Where(a => a.Name == "6th Floor" && a.BuildingDetail.LocationDetail.Name == "Pune").FirstOrDefault();
            var pune6thFloorSWDetails = context.WingDetails.Where(a => a.Name == "South West" && a.FloorDetailId == sixthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune6thFloorSWDetails is not null)
            {
                for (var i = 001; i <= 073; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "6.W.WS." + i.ToString("000"),
                        LocationDetailId = pune6thFloorSWDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune6thFloorSWDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune6thFloorSWDetails.Id,
                        FloorDetailId = pune6thFloorSWDetails.FloorDetailId
                    });
                }

                for (var i = 001; i <= 031; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "6.S.WS." + i.ToString("000"),
                        LocationDetailId = pune6thFloorSWDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune6thFloorSWDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune6thFloorSWDetails.Id,
                        FloorDetailId = pune6thFloorSWDetails.FloorDetailId
                    });
                }

            }

            var pune6thFloorNWDetails = context.WingDetails.Where(a => a.Name == "North West" && a.FloorDetailId == sixthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune6thFloorNWDetails is not null)
            {
                for (var i = 074; i <= 135; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "6.W.WS." + i.ToString("000"),
                        LocationDetailId = pune6thFloorNWDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune6thFloorNWDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune6thFloorNWDetails.Id,
                        FloorDetailId = pune6thFloorNWDetails.FloorDetailId
                    });
                }

            }

            var pune6thFloorNEDetails = context.WingDetails.Where(a => a.Name == "North East" && a.FloorDetailId == sixthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune6thFloorNEDetails is not null)
            {
                for (var i = 088; i <= 182; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "6.E.WS." + i.ToString("000"),
                        LocationDetailId = pune6thFloorNEDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune6thFloorNEDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune6thFloorNEDetails.Id,
                        FloorDetailId = pune6thFloorNEDetails.FloorDetailId
                    });
                }

            }
            var pune6thFloorSEDetails = context.WingDetails.Where(a => a.Name == "South East" && a.FloorDetailId == sixthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune6thFloorSEDetails is not null)
            {
                for (var i = 001; i <= 088; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "6.E.WS." + i.ToString("000"),
                        LocationDetailId = pune6thFloorSEDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune6thFloorSEDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune6thFloorSEDetails.Id,
                        FloorDetailId = pune6thFloorSEDetails.FloorDetailId
                    });
                }
            }
        }

        private static void SeedPune7thFloorDeskDetails(FMSContext context)
        {
            var seventhFloorDetails = context.FloorDetails.Include(a => a.BuildingDetail.LocationDetail).Where(a => a.Name == "7th Floor" && a.BuildingDetail.LocationDetail.Name == "Pune").FirstOrDefault();
            var pune7thFloorSWDetails = context.WingDetails.Where(a => a.Name == "South West" && a.FloorDetailId == seventhFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune7thFloorSWDetails is not null)
            {
                for (var i = 001; i <= 031; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "7.W.WS." + i.ToString("000"),
                        LocationDetailId = pune7thFloorSWDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune7thFloorSWDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune7thFloorSWDetails.Id,
                        FloorDetailId = pune7thFloorSWDetails.FloorDetailId
                    });
                }

                for (var i = 001; i <= 022; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "7.S.WS." + i.ToString("000"),
                        LocationDetailId = pune7thFloorSWDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune7thFloorSWDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune7thFloorSWDetails.Id,
                        FloorDetailId = pune7thFloorSWDetails.FloorDetailId
                    });
                }

            }

            //var pune7thFloorNWDetails = context.WingDetails.Where(a => a.Name == "North West" && a.FloorDetailId == seventhFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            //if (pune7thFloorNWDetails is not null)
            //{
            //    for (var i = 074; i <= 131; i++)
            //    {
            //        context.DeskDetails.Add(new DeskDetail
            //        {
            //            SeatNumber = "6-W-WS-" + i.ToString("000"),
            //            LocationDetailId = pune7thFloorNWDetails.FloorDetail.BuildingDetail.LocationDetailId,
            //            BuildingDetailId = pune7thFloorNWDetails.FloorDetail.BuildingDetailId,
            //            WingDetailId = pune7thFloorNWDetails.Id,
            //            FloorDetailId = pune7thFloorNWDetails.FloorDetailId
            //        });
            //    }

            //}

            var pune7thFloorNEDetails = context.WingDetails.Where(a => a.Name == "North East" && a.FloorDetailId == seventhFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune7thFloorNEDetails is not null)
            {
                for (var i = 100; i <= 0142; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "7.E.WS." + i.ToString("000"),
                        LocationDetailId = pune7thFloorNEDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune7thFloorNEDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune7thFloorNEDetails.Id,
                        FloorDetailId = pune7thFloorNEDetails.FloorDetailId
                    });
                }

            }
            var pune7thFloorSEDetails = context.WingDetails.Where(a => a.Name == "South East" && a.FloorDetailId == seventhFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune7thFloorSEDetails is not null)
            {
                for (var i = 001; i <= 099; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "7.E.WS." + i.ToString("000"),
                        LocationDetailId = pune7thFloorSEDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune7thFloorSEDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune7thFloorSEDetails.Id,
                        FloorDetailId = pune7thFloorSEDetails.FloorDetailId
                    });
                }
            }
        }

        private static void SeedPune8thFloorDeskDetails(FMSContext context)
        {
            var eigthFloorDetails = context.FloorDetails.Include(a => a.BuildingDetail.LocationDetail).Where(a => a.Name == "8th Floor" && a.BuildingDetail.LocationDetail.Name == "Pune").FirstOrDefault();
            var pune8thFloorSWDetails = context.WingDetails.Where(a => a.Name == "South West" && a.FloorDetailId == eigthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune8thFloorSWDetails is not null)
            {
                for (var i = 001; i <= 144; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "8.W.WS." + i.ToString("000"),
                        LocationDetailId = pune8thFloorSWDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune8thFloorSWDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune8thFloorSWDetails.Id,
                        FloorDetailId = pune8thFloorSWDetails.FloorDetailId
                    });
                }

                for (var i = 001; i <= 037; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "8.S.WS." + i.ToString("000"),
                        LocationDetailId = pune8thFloorSWDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune8thFloorSWDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune8thFloorSWDetails.Id,
                        FloorDetailId = pune8thFloorSWDetails.FloorDetailId
                    });
                }

            }

            var pune8thFloorNWDetails = context.WingDetails.Where(a => a.Name == "North West" && a.FloorDetailId == eigthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune8thFloorNWDetails is not null)
            {
                for (var i = 145; i <= 211; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "8.W.WS." + i.ToString("000"),
                        LocationDetailId = pune8thFloorNWDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune8thFloorNWDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune8thFloorNWDetails.Id,
                        FloorDetailId = pune8thFloorNWDetails.FloorDetailId
                    });
                }

            }

            var pune8thFloorNEDetails = context.WingDetails.Where(a => a.Name == "North East" && a.FloorDetailId == eigthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune8thFloorNEDetails is not null)
            {
                for (var i = 135; i <= 229; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "8.E.WS." + i.ToString("000"),
                        LocationDetailId = pune8thFloorNEDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune8thFloorNEDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune8thFloorNEDetails.Id,
                        FloorDetailId = pune8thFloorNEDetails.FloorDetailId
                    });
                }

            }
            var pune8thFloorSEDetails = context.WingDetails.Where(a => a.Name == "South East" && a.FloorDetailId == eigthFloorDetails.Id).Include(a => a.FloorDetail).Include(a => a.FloorDetail.BuildingDetail).Include(a => a.FloorDetail.BuildingDetail.LocationDetail).FirstOrDefault();
            if (pune8thFloorSEDetails is not null)
            {
                for (var i = 001; i <= 134; i++)
                {
                    context.DeskDetails.Add(new DeskDetail
                    {
                        SeatNumber = "8.E.WS." + i.ToString("000"),
                        LocationDetailId = pune8thFloorSEDetails.FloorDetail.BuildingDetail.LocationDetailId,
                        BuildingDetailId = pune8thFloorSEDetails.FloorDetail.BuildingDetailId,
                        WingDetailId = pune8thFloorSEDetails.Id,
                        FloorDetailId = pune8thFloorSEDetails.FloorDetailId
                    });
                }
            }
        }

        #endregion
    }
}