using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FMS.Data.Migrations
{
    public partial class AddPhotoTypesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var photoTypesData = new List<string> {
                "Client Visits|false",
                "Corporate Event|false",
                "Events and Festivals|false",
                "Location Floor Wing|true",
                "Meeting Rooms and Halls|true",
                "News and announcements|false",
                "Party|false",
                "Trainings|false",
                "Workshops|false",
                "Dashboard Carousel|false"
             };

            foreach (var photoType in photoTypesData)
            {
                var photoTypeDetails = photoType.Split('|');
                migrationBuilder.InsertData(table: "PhotoType",
                columns: new[] { "Name", "Description", "IsLocationRequired", "AuditState", "CreatedDate" },
                values: new object[]
                {
                    photoTypeDetails[0] , photoTypeDetails[0] , bool.Parse(photoTypeDetails[1]), "0", DateTime.Now.Date
                });
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
