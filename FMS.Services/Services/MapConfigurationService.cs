using AutoMapper;
using FMS.Contracts;
using FMS.Core.Services;
using FMS.Data.UnitOfWork;
using FMS.Entities.DTOs;
using FMS.Entities.Models;
using FMS.Entities.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Services.Services
{

    public class MapConfigurationService : BaseAuditableService, IMapConfigurationService
    {
        private readonly IMapper _mapper;

        public MapConfigurationService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper) : base(unitOfWorkFactory)
        {
            _mapper = mapper;
        }

        public async Task<List<MapConfigurationWithDeskDataDTO>> GetMapConfigurationWithDeskDataAsync(string request, CancellationToken cancellationToken)
        {
            List<MapConfigurationWithDeskDataDTO> mapConfigurationWithDeskData = new List<MapConfigurationWithDeskDataDTO>();

            try
            {
                if (request == null)
                    return null;

                string[] parameters = request.Split("-");

                using var unitOfWork = UnitOfWorkFactory.GetInstance();
                var mapConfigurationRepository = unitOfWork.CreateRepository<MapConfiguration>();
                var mapConfigurationData = await mapConfigurationRepository.Query().Where(a => a.MapId == request).ToListAsync(cancellationToken);
                var deskDetailRepository = unitOfWork.CreateRepository<DeskDetail>();
                var bookingDetailRepository = unitOfWork.CreateRepository<BookingDetail>();
                var statusRepository = unitOfWork.CreateRepository<StatusType>();

                List<DeskDetailDTO> allFloorDesks = new List<DeskDetailDTO>();

                var status = _mapper.Map<List<StatusTypeDTO>>(await statusRepository.Query().ToListAsync(cancellationToken));
                var retVal = _mapper.Map<List<DeskDetailDTO>>(
                    await deskDetailRepository.Query().Include(a => a.FloorDetail).Include(a => a.LocationDetail).Include(a => a.WingDetail).Include(a => a.BuildingDetail)
                    .Where(a => a.LocationDetailId == Convert.ToInt32(parameters[0])).ToListAsync(cancellationToken));

                if (Convert.ToInt32(parameters[2]) > 0)
                {
                    retVal = retVal.Where(a => a.FloorDetailId == Convert.ToInt32(parameters[2])).ToList();
                }

                foreach (var desk in retVal.OrderBy(a => a.Id))
                {
                    var bookingDetail = await bookingDetailRepository.Query().Include(a => a.Desk).Where(a => a.BookingFromDate.HasValue && a.BookingFromDate.Value.Date.CompareTo(DateTime.Today.Date) == 0
                && a.Desk.SeatNumber == desk.SeatNumber).ToListAsync(cancellationToken);

                    desk.StatusTypeId = status.Where(a => a.Name == "Maintenance").FirstOrDefault().Id;
                    desk.StatusType = status.Where(a => a.Name == "Maintenance").FirstOrDefault();

                    desk.StatusType = bookingDetail.Count > 0 ? status.Where(a => a.Name == "Booked").FirstOrDefault() : status.Where(a => a.Name == "Free").FirstOrDefault();
                    desk.StatusTypeId = bookingDetail.Count > 0 ? status.Where(a => a.Name == "Booked").FirstOrDefault().Id : status.Where(a => a.Name == "Free").FirstOrDefault().Id;

                    allFloorDesks.Add(desk);
                }

                foreach (MapConfiguration item in mapConfigurationData)
                {
                    mapConfigurationWithDeskData.Add(new MapConfigurationWithDeskDataDTO()
                    {
                        MapId = item.MapId,
                        JsonMapData = item.JsonMapData
                    });
                }
                if (mapConfigurationWithDeskData.Count == 0)
                    return await Task.FromResult(mapConfigurationWithDeskData);

                var jsonData = Newtonsoft.Json.JsonConvert.DeserializeObject<MapConfDataParserDTO>(mapConfigurationWithDeskData[0].JsonMapData);
                //List<Unit> units = new List<Unit>();

                //foreach (PropertyInfo prop in jsonData.sections.GetType().GetProperties())
                //{
                //    var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                //    dynamic data = prop.GetValue(jsonData.sections, null);

                //    foreach (var item in data.units)
                //    {
                //        var desk = allFloorDesks.Where(d => d.SeatNumber == item.tag).FirstOrDefault();
                //        item.active = "false"; // desk.StatusTypeId == Convert.ToInt32(DeskStatusType.Free);
                //        units.Add(item);
                //    }
                //}

                var jsonstring = Newtonsoft.Json.JsonConvert.SerializeObject(jsonData);
            }
            catch (Exception e)
            {

            }

            return await Task.FromResult(mapConfigurationWithDeskData);
        }
    }
}
