using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;
using System;

namespace FMS.Data.Migrations
{
    public partial class AddedBangloreBay1UpdatedDeskDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            // Delete old Bangalore 4th Floor Bay-1 Map
            migrationBuilder.DeleteData(
            table: "DeskDetails",
            keyColumn: "LocationDetailId",
            keyValue: "2");

            // Add Bangalore 4th Floor Bay-1 updated Desk Details
            var newDeskData = new List<string> { "4.B1.WS.001", "4.B1.WS.002", "4.B1.WS.003", "4.B1.WS.004", "4.B1.WS.005", "4.B1.WS.006", "4.B1.WS.007", "4.B1.WS.008", "4.B1.WS.009", "4.B1.WS.010", "4.B1.WS.011", "4.B1.WS.012", "4.B1.WS.013", "4.B1.WS.014", "4.B1.WS.015", "4.B1.WS.016", "4.B1.WS.017", "4.B1.WS.018", "4.B1.WS.019", "4.B1.WS.020", "4.B1.WS.021", "4.B1.WS.022", "4.B1.WS.023", "4.B1.WS.024", "4.B1.WS.025", "4.B1.WS.026", "4.B1.WS.027", "4.B1.WS.028", "4.B1.WS.029", "4.B1.WS.030", "4.B1.WS.031", "4.B1.WS.032", "4.B1.WS.033", "4.B1.WS.034", "4.B1.WS.035", "4.B1.WS.036", "4.B1.WS.037", "4.B1.WS.038", "4.B1.WS.039", "4.B1.WS.040", "4.B1.WS.041", "4.B1.WS.042", "4.B1.WS.043", "4.B1.WS.044", "4.B1.WS.045", "4.B1.WS.046", "4.B1.WS.047", "4.B1.WS.048", "4.B1.WS.049", "4.B1.WS.050", "4.B1.WS.051", "4.B1.WS.052", "4.B1.WS.053", "4.B1.WS.054", "4.B1.WS.055", "4.B1.WS.056", "4.B1.WS.057", "4.B1.WS.058", "4.B1.WS.059", "4.B1.WS.060", "4.B1.WS.061", "4.B1.WS.063", "4.B1.WS.064", "4.B1.WS.064", "4.B1.WS.065", "4.B1.WS.066", "4.B1.WS.067", "4.B1.WS.068", "4.B1.WS.069", "4.B1.WS.070", "4.B1.WS.071", "4.B1.WS.072", "4.B1.WS.073", "4.B1.WS.074", "4.B1.WS.075", "4.B1.WS.076", "4.B1.WS.077", "4.B1.WS.078", "4.B1.WS.079", "4.B1.WS.080", "4.B1.WS.081", "4.B1.WS.082", "4.B1.WS.083", "4.B1.WS.084", "4.B1.WS.085", "4.B1.WS.086", "4.B1.WS.087", "4.B1.WS.089", "4.B1.WS.090", "4.B1.WS.094", "4.B1.WS.095", "4.B1.WS.096", "4.B1.WS.097", "4.B1.WS.098", "4.B1.WS.099", "4.B1.WS.100", "4.B1.WS.101", "4.B1.WS.102", "4.B1.WS.103", "4.B1.WS.104", "4.B1.WS.105", "4.B1.WS.106", "4.B1.WS.107", "4.B1.WS.108", "4.B1.WS.109", "4.B1.WS.110", "4.B1.WS.111", "4.B1.WS.112", "4.B1.WS.113", "4.B1.WS.114", "4.B1.WS.115", "4.B1.WS.116", "4.B1.WS.117", "4.B1.WS.118", "4.B1.WS.119", "4.B1.WS.120", "4.B1.WS.121", "4.B1.WS.122", "4.B1.WS.123", "4.B1.WS.124", "4.B1.WS.125", "4.B1.WS.126", "4.B1.WS.127", "4.B1.WS.128", "4.B1.WS.129", "4.B1.WS.130", "4.B1.WS.131", "4.B1.WS.132", "4.B1.WS.133", "4.B1.WS.134", "4.B1.WS.135", "4.B1.WS.136", "4.B1.WS.137", "4.B1.WS.138", "4.B1.WS.139", "4.B1.WS.140", "4.B1.WS.141", "4.B1.WS.142", "4.B1.WS.143", "4.B1.WS.144", "4.B1.WS.145", "4.B1.WS.156", "4.B1.WS.157", "4.B1.WS.158", "4.B1.WS.159", "4.B1.WS.160", "4.B1.WS.161", "4.B1.WS.162", "4.B1.WS.163", "4.B1.WS.164", "4.B1.WS.165", "4.B1.WS.166", "4.B1.WS.167", "4.B1.WS.168", "4.B1.WS.169", "4.B1.WS.170", "4.B1.WS.171", "4.B1.WS.172", "4.B1.WS.173", "4.B1.WS.174", "4.B1.WS.175", "4.B1.WS.176", "4.B1.WS.177", "4.B1.WS.178", "4.B1.WS.179", "4.B1.WS.180", "4.B1.WS.181", "4.B1.WS.182", "4.B1.WS.183", "4.B1.WS.184", "4.B1.WS.185", "4.B1.WS.186", "4.B1.WS.187", "4.B1.WS.188", "4.B1.WS.189", "4.B1.WS.190", "4.B1.WS.191", "4.B1.WS.192", "4.B1.WS.193", "4.B1.WS.194", "4.B1.WS.195", "4.B1.WS.196", "4.B1.WS.197", "4.B1.WS.198", "4.B1.WS.199", "4.B1.WS.200", "4.B1.WS.201", "4.B1.WS.202", "4.B1.WS.203", "4.B1.WS.204", "4.B1.WS.205", "4.B1.WS.206", "4.B1.WS.207", "4.B1.WS.208", "4.B1.WS.209", "4.B1.WS.210", "4.B1.WS.211", "4.B1.WS.212", "4.B1.WS.213", "4.B1.WS.214", "4.B1.WS.215", "4.B1.WS.216", "4.B1.WS.217", "4.B1.WS.218", "4.B1.WS.219", "4.B1.WS.220", "4.B1.WS.221", "4.B1.WS.222", "4.B1.WS.223", "4.B1.WS.224", "4.B1.WS.225", "4.B1.WS.226", "4.B1.WS.227", "4.B1.WS.228", "4.B1.WS.229", "4.B1.WS.230", "4.B1.WS.231", "4.B1.WS.232", "4.B1.WS.233", "4.B1.WS.234", "4.B1.WS.235", "4.B1.WS.236", "4.B1.WS.237", "4.B1.WS.238", "4.B1.WS.239", "4.B1.WS.240", "4.B1.WS.241", "4.B1.WS.242", "4.B1.WS.243", "4.B1.WS.244", "4.B1.WS.245", "4.B1.WS.246", "4.B1.WS.247", "4.B1.WS.248", "4.B1.WS.249", "4.B1.WS.250", "4.B1.WS.251", "4.B1.WS.252", "4.B1.WS.253", "4.B1.WS.254", "4.B1.WS.255", "4.B1.WS.256", "4.B1.WS.257", "4.B1.WS.258", "4.B1.WS.259", "4.B1.WS.260", "4.B1.WS.261", "4.B1.WS.262", "4.B1.WS.262", "4.B1.WS.263", "4.B1.WS.264", "4.B1.WS.265", "4.B1.WS.266", "4.B1.WS.268", "4.B1.WS.269", "4.B1.WS.270", "4.B1.WS.271", "4.B1.WS.272", "4.B1.WS.273", "4.B1.WS.274", "4.B1.WS.275", "4.B1.WS.276", "4.B1.WS.291", "4.B1.WS.292", "4.B1.WS.293", "4.B1.WS.294", "4.B1.WS.295", "4.B1.WS.296", "4.B1.WS.297", "4.B1.WS.298", "4.B1.WS.299", "4.B1.WS.300", "4.B1.WS.301", "4.B1.WS.302", "4.B1.WS.303", "4.B1.WS.304", "4.B1.WS.305", "4.B1.WS.393", "4.B1.WS.394", "4.B1.WS.395", "4.B1.WS.396" };

            foreach (var desk in newDeskData)
            {
                migrationBuilder.InsertData(table: "DeskDetails",
                columns: new[] { "Section", "SeatNumber", "LocationDetailId", "BuildingDetailId", "WingDetailId", "FloorDetailId", "StatusTypeId", "AuditState", "CreatedDate", "UpdatedDate", "CreatedBy", "UpdatedBy", "Comments", "IsBlockedSeat" },
                values: new object[]
                {
                    null,
                    desk,
                    2,3,1,1,null,0,
                    DateTime.Now, null,null,null,null,false
                });
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
