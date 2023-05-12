using Microsoft.EntityFrameworkCore.Migrations;
using FMS.Entities.Models;
using System;

namespace FMS.Data.Migrations
{
    public partial class AddedBangloreBay2Map : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Bangalore 4th Floor Bay-1 Map
            string bangalore4thFloorBay1Map = @"{
	""assets"": {
		""pic"": {
			""name"": ""Bangalore, 4th Floor, Bay 1, Floor Plan"",
			""ref"": ""./assets/2-3-1-1.jpg""
		},
		""svg"": {
			""name"": ""Bangalore, 4th Floor, Bay 1, Floor Assets"",
			""ref"": ""./assets/2-3-1-1.svg""
		}
	},
	""models"": {
		""Mod-1"": {
			""name"": ""BTabelL1"",
			""template"": ""t1""
		},
		""Mod-2"": {
			""name"": ""BTabelS1"",
			""template"": ""t1""
		},
		""Mod-3"": {
			""name"": ""BTabelC1"",
			""template"": ""t1""
		}
	},
	""areas"": {
		""Area-1"": {
			""tag"": ""Cafeteria""
		},
		""Area-2"": {
			""tag"": ""Manager Cabins 1""
		},
		""Area-3"": {
			""tag"": ""UPS Room""
		},
		""Area-4"": {
			""tag"": ""Manager Cabins 2""
		},
		""Area-5"": {
			""tag"": ""Reception""
		},
		""Area-6"": {
			""tag"": ""Admin Store""
		},
		""Area-7"": {
			""tag"": ""IT Store""
		},
		""Area-8"": {
			""tag"": ""AOC Control Room""
		},
		""Area-9"": {
			""tag"": ""AOC Meeting room 2""
		},
		""Area-10"": {
			""tag"": ""AOC Meeting room 1""
		},
		""Area-11"": {
			""tag"": ""Ladies Washroom""
		},
		""Area-12"": {
			""tag"": ""Gents Washroom""
		},
		""Area-13"": {
			""tag"": ""Lift Lobby""
		},
		""Area-14"": {
			""tag"": ""Ladies Washroom""
		},
		""Area-15"": {
			""tag"": ""Gents Washroom""
		},
		""Area-16"": {
			""tag"": ""Handicap Washroom""
		},
		""Area-17"": {
			""tag"": ""Staircase""
		},
		""Area-18"": {
			""tag"": ""Lift Lobby""
		}
	},
	""sections"": {
		""Section-1"": {
			""tag"": ""Section-1"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.B1.WS.001"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 271.6938 1275.6332""
				},
				{
					""tag"": ""4.B1.WS.002"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 354.8846 1276.6323""
				},
				{
					""tag"": ""4.B1.WS.003"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 356.2017 1276.6332""
				},
				{
					""tag"": ""4.B1.WS.004"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 439.3001 1276.6323""
				},
				{
					""tag"": ""4.B1.WS.005"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 439.3011 1236.377""
				},
				{
					""tag"": ""4.B1.WS.006"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 356.2017 1236.3774""
				},
				{
					""tag"": ""4.B1.WS.011"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 356.2012 1158.4742""
				},
				{
					""tag"": ""4.B1.WS.012"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 439.3006 1158.4742""
				},
				{
					""tag"": ""4.B1.WS.008"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 271.6938 1236.3783""
				},
				{
					""tag"": ""4.B1.WS.007"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 354.8846 1236.3774""
				},
				{
					""tag"": ""4.B1.WS.009"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 271.6932 1158.4711""
				},
				{
					""tag"": ""4.B1.WS.010"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 354.8848 1158.4711""
				},
				{
					""tag"": ""4.B1.WS.014"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 356.2017 1157.165""
				},
				{
					""tag"": ""4.B1.WS.013"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 439.3011 1157.1646""
				},
				{
					""tag"": ""4.B1.WS.016"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 356.2012 1079.2618""
				},
				{
					""tag"": ""4.B1.WS.017"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 439.3006 1079.2618""
				},
				{
					""tag"": ""4.B1.WS.015"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 271.6938 1157.1659""
				},
				{
					""tag"": ""4.B1.WS.030"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 271.6932 1079.2587""
				},
				{
					""tag"": ""4.B1.WS.019"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 356.2017 1037.6971""
				},
				{
					""tag"": ""4.B1.WS.018"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 439.3011 1037.6965""
				},
				{
					""tag"": ""4.B1.WS.024"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 356.2012 959.7967""
				},
				{
					""tag"": ""4.B1.WS.025"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 439.3006 959.7967""
				},
				{
					""tag"": ""4.B1.WS.022"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 271.6938 1037.698""
				},
				{
					""tag"": ""4.B1.WS.020"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 354.8846 1037.6971""
				},
				{
					""tag"": ""4.B1.WS.021"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 271.6932 959.7936""
				},
				{
					""tag"": ""4.B1.WS.023"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 354.8848 959.7936""
				},
				{
					""tag"": ""4.B1.WS.029"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 271.6938 958.5027""
				},
				{
					""tag"": ""4.B1.WS.028"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 354.8846 958.5019""
				},
				{
					""tag"": ""4.B1.WS.031"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 271.6932 880.5984""
				},
				{
					""tag"": ""4.B1.WS.032"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 354.8848 880.5984""
				},
				{
					""tag"": ""4.B1.WS.027"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 356.2017 958.5019""
				},
				{
					""tag"": ""4.B1.WS.026"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 439.3011 958.5013""
				},
				{
					""tag"": ""4.B1.WS.033"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 356.2012 880.6015""
				},
				{
					""tag"": ""4.B1.WS.034"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 439.3006 880.6015""
				},
				{
					""tag"": ""4.B1.WS.035"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 439.3061 813.2084""
				},
				{
					""tag"": ""4.B1.WS.036"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 361.401 813.2089""
				},
				{
					""tag"": ""4.B1.WS.037"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 360.0958 813.2084""
				},
				{
					""tag"": ""4.B1.WS.038"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 282.1923 813.2089""
				},
				{
					""tag"": ""4.B1.WS.040"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 360.0953 731.4072""
				},
				{
					""tag"": ""4.B1.WS.039"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 282.1922 731.4074""
				},
				{
					""tag"": ""4.B1.WS.042"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 439.3087 731.4097""
				},
				{
					""tag"": ""4.B1.WS.041"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 361.4088 731.4102""
				},
				{
					""tag"": ""4.B1.WS.043"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 439.3061 730.0912""
				},
				{
					""tag"": ""4.B1.WS.044"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 361.401 730.0917""
				},
				{
					""tag"": ""4.B1.WS.045"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 360.0958 730.0912""
				},
				{
					""tag"": ""4.B1.WS.046"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 282.1923 730.0917""
				},
				{
					""tag"": ""4.B1.WS.048"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 360.0953 644.3894""
				},
				{
					""tag"": ""4.B1.WS.047"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 282.1922 644.3896""
				},
				{
					""tag"": ""4.B1.WS.050"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 439.3087 644.3919""
				},
				{
					""tag"": ""4.B1.WS.049"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 361.4088 644.3924""
				},
				{
					""tag"": ""4.B1.WS.051"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 439.3061 643.078""
				},
				{
					""tag"": ""4.B1.WS.052"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 361.401 643.0786""
				},
				{
					""tag"": ""4.B1.WS.053"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 360.0958 643.078""
				},
				{
					""tag"": ""4.B1.WS.054"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 282.1923 643.0786""
				},
				{
					""tag"": ""4.B1.WS.056"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 360.0953 558.7098""
				},
				{
					""tag"": ""4.B1.WS.055"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 282.1922 558.71""
				},
				{
					""tag"": ""4.B1.WS.058"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 439.3087 558.7123""
				},
				{
					""tag"": ""4.B1.WS.057"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 361.4088 558.7127""
				}
			]
		},
		""Section-2"": {
			""tag"": ""Section-2"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.B1.WS.094"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 353.23 101.02""
				},
				{
					""tag"": ""4.B1.WS.095"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 438.9308 101.02""
				},
				{
					""tag"": ""4.B1.WS.087"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 353.595 141.2738""
				},
				{
					""tag"": ""4.B1.WS.086"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 439.3092 141.2738""
				},
				{
					""tag"": ""4.B1.WS.084"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 353.595 219.1848""
				},
				{
					""tag"": ""4.B1.WS.085"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 439.3092 219.1848""
				},
				{
					""tag"": ""4.B1.WS.079"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 353.595 220.4835""
				},
				{
					""tag"": ""4.B1.WS.078"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 439.3092 220.4835""
				},
				{
					""tag"": ""4.B1.WS.076"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 353.595 298.3945""
				},
				{
					""tag"": ""4.B1.WS.081"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 266.5864 220.4835""
				},
				{
					""tag"": ""4.B1.WS.089"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 266.5864 298.3945""
				},
				{
					""tag"": ""4.B1.WS.077"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 439.3092 298.3945""
				},
				{
					""tag"": ""4.B1.WS.096"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 485.3982 101.02""
				},
				{
					""tag"": ""4.B1.WS.097"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 571.0989 101.02""
				},
				{
					""tag"": ""4.B1.WS.107"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 485.7631 141.2738""
				},
				{
					""tag"": ""4.B1.WS.106"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 571.4774 141.2738""
				},
				{
					""tag"": ""4.B1.WS.108"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 485.7631 219.1848""
				},
				{
					""tag"": ""4.B1.WS.109"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 571.4774 219.1848""
				},
				{
					""tag"": ""4.B1.WS.117"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 485.7631 220.4835""
				},
				{
					""tag"": ""4.B1.WS.116"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 571.4774 220.4835""
				},
				{
					""tag"": ""4.B1.WS.118"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 485.7631 298.3945""
				},
				{
					""tag"": ""4.B1.WS.119"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 571.4774 298.3945""
				},
				{
					""tag"": ""4.B1.WS.098"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 572.4099 101.02""
				},
				{
					""tag"": ""4.B1.WS.099"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 658.1107 101.02""
				},
				{
					""tag"": ""4.B1.WS.105"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 572.7748 141.2738""
				},
				{
					""tag"": ""4.B1.WS.104"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 658.4891 141.2738""
				},
				{
					""tag"": ""4.B1.WS.110"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 572.7748 219.1848""
				},
				{
					""tag"": ""4.B1.WS.111"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 658.4891 219.1848""
				},
				{
					""tag"": ""4.B1.WS.100"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 659.4232 101.02""
				},
				{
					""tag"": ""4.B1.WS.101"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 745.124 101.02""
				},
				{
					""tag"": ""4.B1.WS.103"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 659.7882 141.2738""
				},
				{
					""tag"": ""4.B1.WS.102"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 745.5025 141.2738""
				},
				{
					""tag"": ""4.B1.WS.112"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 659.7882 219.1848""
				},
				{
					""tag"": ""4.B1.WS.113"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 745.5025 219.1848""
				},
				{
					""tag"": ""4.B1.WS.115"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 659.7882 220.4835""
				},
				{
					""tag"": ""4.B1.WS.114"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 745.5025 220.4835""
				},
				{
					""tag"": ""4.B1.WS.120"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 659.7882 298.3945""
				},
				{
					""tag"": ""4.B1.WS.121"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 745.5025 298.3945""
				},
				{
					""tag"": ""4.B1.WS.127"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 485.7631 337.9216""
				},
				{
					""tag"": ""4.B1.WS.126"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 571.4774 337.9216""
				},
				{
					""tag"": ""4.B1.WS.128"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 485.7631 415.8327""
				},
				{
					""tag"": ""4.B1.WS.129"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 571.4774 415.8327""
				},
				{
					""tag"": ""4.B1.WS.139"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 485.7631 417.1313""
				},
				{
					""tag"": ""4.B1.WS.138"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 571.4774 417.1313""
				},
				{
					""tag"": ""4.B1.WS.140"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 485.7631 495.0424""
				},
				{
					""tag"": ""4.B1.WS.141"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 571.4774 495.0424""
				},
				{
					""tag"": ""4.B1.WS.125"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 572.7748 337.9216""
				},
				{
					""tag"": ""4.B1.WS.124"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 658.4891 337.9216""
				},
				{
					""tag"": ""4.B1.WS.130"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 572.7748 415.8327""
				},
				{
					""tag"": ""4.B1.WS.131"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 658.4891 415.8327""
				},
				{
					""tag"": ""4.B1.WS.137"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 572.7748 417.1313""
				},
				{
					""tag"": ""4.B1.WS.136"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 658.4891 417.1313""
				},
				{
					""tag"": ""4.B1.WS.142"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 572.7748 495.0424""
				},
				{
					""tag"": ""4.B1.WS.143"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 658.4891 495.0424""
				},
				{
					""tag"": ""4.B1.WS.123"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 659.7882 337.9216""
				},
				{
					""tag"": ""4.B1.WS.122"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 745.5025 337.9216""
				},
				{
					""tag"": ""4.B1.WS.132"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 659.7882 415.8327""
				},
				{
					""tag"": ""4.B1.WS.133"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 745.5025 415.8327""
				},
				{
					""tag"": ""4.B1.WS.074"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 265.2841 337.9216""
				},
				{
					""tag"": ""4.B1.WS.066"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 265.2841 415.8327""
				},
				{
					""tag"": ""4.B1.WS.073"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 266.5816 337.9216""
				},
				{
					""tag"": ""4.B1.WS.072"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 352.2959 337.9216""
				},
				{
					""tag"": ""4.B1.WS.065"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 266.5816 415.8327""
				},
				{
					""tag"": ""4.B1.WS.067"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 352.2959 415.8327""
				},
				{
					""tag"": ""4.B1.WS.071"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 353.5949 337.9216""
				},
				{
					""tag"": ""4.B1.WS.070"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 439.3092 337.9216""
				},
				{
					""tag"": ""4.B1.WS.068"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 353.5949 415.8327""
				},
				{
					""tag"": ""4.B1.WS.069"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 439.3092 415.8327""
				},
				{
					""tag"": ""4.B1.WS.135"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 659.7882 417.1313""
				},
				{
					""tag"": ""4.B1.WS.134"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 745.5025 417.1313""
				},
				{
					""tag"": ""4.B1.WS.144"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 659.7882 495.0424""
				},
				{
					""tag"": ""4.B1.WS.145"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 745.5025 495.0424""
				},
				{
					""tag"": ""4.B1.WS.090"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 265.2788 220.4835""
				},
				{
					""tag"": ""4.B1.WS.080"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 266.5864 180.227""
				},
				{
					""tag"": ""4.B1.WS.075"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 265.2788 180.227""
				},
				{
					""tag"": ""4.B1.WS.083"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 352.3078 180.227""
				},
				{
					""tag"": ""4.B1.WS.082"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 265.2788 298.3945""
				},
				{
					""tag"": ""4.B1.WS.060"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""1 0 0 -1 407.14 465.435""
				},
				{
					""tag"": ""4.B1.WS.064"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 -0.866 -0.866 0.5 404.9078 464.0818""
				},
				{
					""tag"": ""4.B1.WS.063"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 -0.866 0.866 0.5 349.1983 464.018""
				},
				{
					""tag"": ""4.B1.WS.059"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 0.866 -0.866 -0.5 404.9078 466.6841""
				},
				{
					""tag"": ""4.B1.WS.061"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 0.866 0.866 -0.5 349.1983 466.6204""
				},
				{
					""tag"": ""4.B1.WS.062"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-1 0 0 -1 347 465.313""
				}
			]
		},
		""Section-3"": {
			""tag"": ""Section-3"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.B1.WS.158"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""1 0 0 -1 573.6631 910.6124""
				},
				{
					""tag"": ""4.B1.WS.156"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 -0.866 -0.866 0.5 571.4308 909.2592""
				},
				{
					""tag"": ""4.B1.WS.157"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 -0.866 0.866 0.5 515.7289 909.074""
				},
				{
					""tag"": ""4.B1.WS.160"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 0.866 -0.866 -0.5 571.4308 911.8615""
				},
				{
					""tag"": ""4.B1.WS.159"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 0.866 0.866 -0.5 515.7289 911.6763""
				},
				{
					""tag"": ""4.B1.WS.161"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-1 0 0 -1 513.5307 910.369""
				},
				{
					""tag"": ""4.B1.WS.184"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 565.4731 1037.702""
				},
				{
					""tag"": ""4.B1.WS.187"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 648.6819 1037.7029""
				},
				{
					""tag"": ""4.B1.WS.186"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 480.9652 1037.7029""
				},
				{
					""tag"": ""4.B1.WS.185"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 564.1739 1037.702""
				},
				{
					""tag"": ""4.B1.WS.181"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 734.4885 1037.702""
				},
				{
					""tag"": ""4.B1.WS.180"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 817.6982 1037.7029""
				},
				{
					""tag"": ""4.B1.WS.178"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 734.4885 959.7919""
				},
				{
					""tag"": ""4.B1.WS.179"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 817.6978 959.7874""
				},
				{
					""tag"": ""4.B1.WS.183"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 649.9587 1037.7029""
				},
				{
					""tag"": ""4.B1.WS.182"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 733.1898 1037.702""
				},
				{
					""tag"": ""4.B1.WS.176"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 649.9806 959.7919""
				},
				{
					""tag"": ""4.B1.WS.177"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 733.1898 959.7919""
				},
				{
					""tag"": ""4.B1.WS.162"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 648.6814 880.5822""
				},
				{
					""tag"": ""4.B1.WS.163"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 649.9806 880.5822""
				},
				{
					""tag"": ""4.B1.WS.164"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 733.1898 880.5777""
				},
				{
					""tag"": ""4.B1.WS.165"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 734.4885 880.5777""
				},
				{
					""tag"": ""4.B1.WS.166"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 817.6978 880.5822""
				},
				{
					""tag"": ""4.B1.WS.169"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 733.1898 958.4977""
				},
				{
					""tag"": ""4.B1.WS.167"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 817.6982 958.4932""
				},
				{
					""tag"": ""4.B1.WS.168"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 734.4885 958.4932""
				},
				{
					""tag"": ""4.B1.WS.258"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 851.464 1037.702""
				},
				{
					""tag"": ""4.B1.WS.257"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 937.1783 1037.7029""
				},
				{
					""tag"": ""4.B1.WS.259"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 851.464 959.7919""
				},
				{
					""tag"": ""4.B1.WS.260"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 937.1779 959.7874""
				},
				{
					""tag"": ""4.B1.WS.271"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 851.464 880.5777""
				},
				{
					""tag"": ""4.B1.WS.272"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 937.1779 880.5822""
				},
				{
					""tag"": ""4.B1.WS.269"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 937.1783 958.4932""
				},
				{
					""tag"": ""4.B1.WS.270"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 851.464 958.4932""
				},
				{
					""tag"": ""4.B1.WS.256"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 938.477 1037.702""
				},
				{
					""tag"": ""4.B1.WS.255"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1024.1913 1037.7029""
				},
				{
					""tag"": ""4.B1.WS.261"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 938.477 959.7919""
				},
				{
					""tag"": ""4.B1.WS.262"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1024.1908 959.7874""
				},
				{
					""tag"": ""4.B1.WS.273"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 938.477 880.5777""
				},
				{
					""tag"": ""4.B1.WS.274"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1024.1908 880.5822""
				},
				{
					""tag"": ""4.B1.WS.267"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1024.1913 958.4932""
				},
				{
					""tag"": ""4.B1.WS.268"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 938.477 958.4932""
				},
				{
					""tag"": ""4.B1.WS.254"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1025.49 1037.702""
				},
				{
					""tag"": ""4.B1.WS.253"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1111.2042 1037.7029""
				},
				{
					""tag"": ""4.B1.WS.263"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1025.49 959.7919""
				},
				{
					""tag"": ""4.B1.WS.264"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1111.2039 959.7874""
				},
				{
					""tag"": ""4.B1.WS.275"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1025.49 880.5777""
				},
				{
					""tag"": ""4.B1.WS.276"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1111.2039 880.5822""
				},
				{
					""tag"": ""4.B1.WS.265"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1111.2042 958.4932""
				},
				{
					""tag"": ""4.B1.WS.266"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1025.49 958.4932""
				},
				{
					""tag"": ""4.B1.WS.170"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 649.9806 958.4932""
				},
				{
					""tag"": ""4.B1.WS.171"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 648.6819 958.4932""
				},
				{
					""tag"": ""4.B1.WS.172"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 648.6814 959.7874""
				},
				{
					""tag"": ""4.B1.WS.173"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 480.9647 959.7919""
				},
				{
					""tag"": ""4.B1.WS.174"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 564.1739 959.7874""
				},
				{
					""tag"": ""4.B1.WS.175"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 565.4726 959.7874""
				},
				{
					""tag"": ""4.B1.WS.198"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 565.4731 1157.1715""
				},
				{
					""tag"": ""4.B1.WS.200"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 480.9652 1157.1724""
				},
				{
					""tag"": ""4.B1.WS.199"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 564.1739 1157.1715""
				},
				{
					""tag"": ""4.B1.WS.195"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 734.4885 1157.1715""
				},
				{
					""tag"": ""4.B1.WS.194"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 817.6982 1157.1724""
				},
				{
					""tag"": ""4.B1.WS.192"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 734.4885 1079.2614""
				},
				{
					""tag"": ""4.B1.WS.193"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 817.6978 1079.2568""
				},
				{
					""tag"": ""4.B1.WS.197"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 649.9587 1157.1724""
				},
				{
					""tag"": ""4.B1.WS.196"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 733.1898 1157.1715""
				},
				{
					""tag"": ""4.B1.WS.190"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 649.9806 1079.2614""
				},
				{
					""tag"": ""4.B1.WS.191"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 733.1898 1079.2614""
				},
				{
					""tag"": ""4.B1.WS.248"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 851.464 1157.1715""
				},
				{
					""tag"": ""4.B1.WS.247"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 937.1783 1157.1724""
				},
				{
					""tag"": ""4.B1.WS.246"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 938.477 1157.1715""
				},
				{
					""tag"": ""4.B1.WS.245"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1024.1913 1157.1724""
				},
				{
					""tag"": ""4.B1.WS.249"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 938.477 1079.2614""
				},
				{
					""tag"": ""4.B1.WS.250"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1024.1908 1079.2568""
				},
				{
					""tag"": ""4.B1.WS.244"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1025.49 1157.1715""
				},
				{
					""tag"": ""4.B1.WS.243"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1111.2042 1157.1724""
				},
				{
					""tag"": ""4.B1.WS.251"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1025.49 1079.2614""
				},
				{
					""tag"": ""4.B1.WS.252"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1111.2039 1079.2568""
				},
				{
					""tag"": ""4.B1.WS.188"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 480.9647 1079.2614""
				},
				{
					""tag"": ""4.B1.WS.189"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 564.1739 1079.2568""
				},
				{
					""tag"": ""4.B1.WS.214"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 565.4731 1236.3812""
				},
				{
					""tag"": ""4.B1.WS.213"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 648.6819 1236.3821""
				},
				{
					""tag"": ""4.B1.WS.216"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 480.9652 1236.3821""
				},
				{
					""tag"": ""4.B1.WS.215"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 564.1739 1236.3812""
				},
				{
					""tag"": ""4.B1.WS.210"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 734.4885 1236.3812""
				},
				{
					""tag"": ""4.B1.WS.209"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 817.6982 1236.3821""
				},
				{
					""tag"": ""4.B1.WS.207"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 734.4885 1158.4711""
				},
				{
					""tag"": ""4.B1.WS.208"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 817.6978 1158.4666""
				},
				{
					""tag"": ""4.B1.WS.212"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 649.9587 1236.3821""
				},
				{
					""tag"": ""4.B1.WS.211"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 733.1898 1236.3812""
				},
				{
					""tag"": ""4.B1.WS.205"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 649.9806 1158.4711""
				},
				{
					""tag"": ""4.B1.WS.206"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 733.1898 1158.4711""
				},
				{
					""tag"": ""4.B1.WS.236"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 851.464 1236.3812""
				},
				{
					""tag"": ""4.B1.WS.235"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 937.1783 1236.3821""
				},
				{
					""tag"": ""4.B1.WS.237"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 851.464 1158.4711""
				},
				{
					""tag"": ""4.B1.WS.238"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 937.1779 1158.4666""
				},
				{
					""tag"": ""4.B1.WS.234"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 938.477 1236.3812""
				},
				{
					""tag"": ""4.B1.WS.233"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1024.1913 1236.3821""
				},
				{
					""tag"": ""4.B1.WS.239"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 938.477 1158.4711""
				},
				{
					""tag"": ""4.B1.WS.240"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1024.1908 1158.4666""
				},
				{
					""tag"": ""4.B1.WS.232"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1025.49 1236.3812""
				},
				{
					""tag"": ""4.B1.WS.231"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1111.2042 1236.3821""
				},
				{
					""tag"": ""4.B1.WS.218"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 565.4731 1276.6338""
				},
				{
					""tag"": ""4.B1.WS.220"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 648.6819 1276.6346""
				},
				{
					""tag"": ""4.B1.WS.217"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 480.9652 1276.6346""
				},
				{
					""tag"": ""4.B1.WS.219"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 564.1739 1276.6338""
				},
				{
					""tag"": ""4.B1.WS.223"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 734.4885 1276.6338""
				},
				{
					""tag"": ""4.B1.WS.224"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 817.6982 1276.6346""
				},
				{
					""tag"": ""4.B1.WS.221"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 649.9587 1276.6346""
				},
				{
					""tag"": ""4.B1.WS.222"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 733.1898 1276.6338""
				},
				{
					""tag"": ""4.B1.WS.225"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 851.464 1276.6338""
				},
				{
					""tag"": ""4.B1.WS.226"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 937.1783 1276.6346""
				},
				{
					""tag"": ""4.B1.WS.227"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 938.477 1276.6338""
				},
				{
					""tag"": ""4.B1.WS.228"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1024.1913 1276.6346""
				},
				{
					""tag"": ""4.B1.WS.229"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1025.49 1276.6338""
				},
				{
					""tag"": ""4.B1.WS.230"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1111.2042 1276.6346""
				},
				{
					""tag"": ""4.B1.WS.241"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1025.49 1158.4711""
				},
				{
					""tag"": ""4.B1.WS.242"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1111.2039 1158.4666""
				},
				{
					""tag"": ""4.B1.WS.204"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 648.6814 1158.4666""
				},
				{
					""tag"": ""4.B1.WS.201"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 480.9647 1158.4711""
				},
				{
					""tag"": ""4.B1.WS.202"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 564.1739 1158.4667""
				},
				{
					""tag"": ""4.B1.WS.203"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 565.4726 1158.4667""
				}
			]
		},
		""Section-4"": {
			""tag"": ""Section-4"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.B1.WS.309"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1207.079 385.3404""
				},
				{
					""tag"": ""4.B1.WS.310"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1168.1179 385.3404""
				},
				{
					""tag"": ""4.B1.WS.311"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1129.1569 385.3404""
				},
				{
					""tag"": ""4.B1.WS.312"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1090.1958 385.3404""
				},
				{
					""tag"": ""4.B1.WS.313"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1051.1025 385.3404""
				},
				{
					""tag"": ""4.B1.WS.314"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1207.079 345.7875""
				},
				{
					""tag"": ""4.B1.WS.315"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1168.1179 345.7875""
				},
				{
					""tag"": ""4.B1.WS.316"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1129.1569 345.7875""
				},
				{
					""tag"": ""4.B1.WS.317"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1090.1958 345.7875""
				},
				{
					""tag"": ""4.B1.WS.318"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1051.1025 345.7875""
				},
				{
					""tag"": ""4.B1.WS.319"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1207.079 302.9304""
				},
				{
					""tag"": ""4.B1.WS.320"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1168.1179 302.9304""
				},
				{
					""tag"": ""4.B1.WS.321"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1129.1569 302.9304""
				},
				{
					""tag"": ""4.B1.WS.322"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1090.1958 302.9304""
				},
				{
					""tag"": ""4.B1.WS.323"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1051.1025 302.9304""
				},
				{
					""tag"": ""4.B1.WS.326"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1207.079 260.0732""
				},
				{
					""tag"": ""4.B1.WS.325"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1090.1958 260.0732""
				},
				{
					""tag"": ""4.B1.WS.324"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1051.1025 260.0732""
				},
				{
					""tag"": ""4.B1.WS.327"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1207.079 217.2161""
				},
				{
					""tag"": ""4.B1.WS.328"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1168.1179 217.2161""
				},
				{
					""tag"": ""4.B1.WS.329"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1129.1569 217.2161""
				},
				{
					""tag"": ""4.B1.WS.330"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1090.1958 217.2161""
				},
				{
					""tag"": ""4.B1.WS.331"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1051.1025 217.2161""
				},
				{
					""tag"": ""4.B1.WS.336"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1207.079 174.3589""
				},
				{
					""tag"": ""4.B1.WS.335"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1168.1179 174.3589""
				},
				{
					""tag"": ""4.B1.WS.334"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1129.1569 174.3589""
				},
				{
					""tag"": ""4.B1.WS.333"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1090.1958 174.3589""
				},
				{
					""tag"": ""4.B1.WS.332"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1051.1025 174.3589""
				},
				{
					""tag"": ""4.B1.WS.338"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1129.1569 131.5018""
				},
				{
					""tag"": ""4.B1.WS.339"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1090.1958 131.5018""
				},
				{
					""tag"": ""4.B1.WS.340"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1051.1025 131.5018""
				},
				{
					""tag"": ""4.B1.WS.341"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1090.1958 88.6447""
				},
				{
					""tag"": ""4.B1.WS.342"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1051.1025 88.6447""
				},
				{
					""tag"": ""4.B1.WS.381"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 980.9727 385.3404""
				},
				{
					""tag"": ""4.B1.WS.382"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 942.0116 385.3404""
				},
				{
					""tag"": ""4.B1.WS.383"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 903.0505 385.3404""
				},
				{
					""tag"": ""4.B1.WS.384"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 864.0895 385.3404""
				},
				{
					""tag"": ""4.B1.WS.385"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 825.1285 385.3404""
				},
				{
					""tag"": ""4.B1.WS.386"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 786.1674 385.3404""
				},
				{
					""tag"": ""4.B1.WS.380"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 980.9727 345.7875""
				},
				{
					""tag"": ""4.B1.WS.379"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 942.0116 345.7875""
				},
				{
					""tag"": ""4.B1.WS.378"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 903.0505 345.7875""
				},
				{
					""tag"": ""4.B1.WS.377"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 864.0895 345.7875""
				},
				{
					""tag"": ""4.B1.WS.376"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 825.1285 345.7875""
				},
				{
					""tag"": ""4.B1.WS.375"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 786.1674 345.7875""
				},
				{
					""tag"": ""4.B1.WS.369"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 980.9727 302.9304""
				},
				{
					""tag"": ""4.B1.WS.370"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 942.0116 302.9304""
				},
				{
					""tag"": ""4.B1.WS.371"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 903.0505 302.9304""
				},
				{
					""tag"": ""4.B1.WS.372"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 864.0895 302.9304""
				},
				{
					""tag"": ""4.B1.WS.373"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 825.1285 302.9304""
				},
				{
					""tag"": ""4.B1.WS.374"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 786.1674 302.9304""
				},
				{
					""tag"": ""4.B1.WS.368"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 980.9727 260.0732""
				},
				{
					""tag"": ""4.B1.WS.367"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 942.0116 260.0732""
				},
				{
					""tag"": ""4.B1.WS.366"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 903.0505 260.0732""
				},
				{
					""tag"": ""4.B1.WS.365"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 825.1285 260.0732""
				},
				{
					""tag"": ""4.B1.WS.364"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 786.1674 260.0732""
				},
				{
					""tag"": ""4.B1.WS.358"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 980.9727 217.2161""
				},
				{
					""tag"": ""4.B1.WS.359"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 942.0116 217.2161""
				},
				{
					""tag"": ""4.B1.WS.360"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 903.0505 217.2161""
				},
				{
					""tag"": ""4.B1.WS.361"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 864.0895 217.2161""
				},
				{
					""tag"": ""4.B1.WS.362"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 825.1285 217.2161""
				},
				{
					""tag"": ""4.B1.WS.363"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 786.1674 217.2161""
				},
				{
					""tag"": ""4.B1.WS.357"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 980.9727 174.3589""
				},
				{
					""tag"": ""4.B1.WS.356"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 942.0116 174.3589""
				},
				{
					""tag"": ""4.B1.WS.355"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 903.0505 174.3589""
				},
				{
					""tag"": ""4.B1.WS.354"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 864.0895 174.3589""
				},
				{
					""tag"": ""4.B1.WS.353"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 825.1285 174.3589""
				},
				{
					""tag"": ""4.B1.WS.352"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 786.1674 174.3589""
				},
				{
					""tag"": ""4.B1.WS.346"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 980.9727 131.5018""
				},
				{
					""tag"": ""4.B1.WS.347"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 942.0116 131.5018""
				},
				{
					""tag"": ""4.B1.WS.348"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 903.0505 131.5018""
				},
				{
					""tag"": ""4.B1.WS.349"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 864.0895 131.5018""
				},
				{
					""tag"": ""4.B1.WS.343"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 980.9727 88.6447""
				},
				{
					""tag"": ""4.B1.WS.344"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 942.0116 88.6447""
				},
				{
					""tag"": ""4.B1.WS.345"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 903.0505 88.6447""
				}
			]
		},
		""Section-5"": {
			""tag"": ""Section-5"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.B1.WS.294"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1157.6971 1156.7472""
				},
				{
					""tag"": ""4.B1.WS.295"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1243.4115 1156.748""
				},
				{
					""tag"": ""4.B1.WS.293"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1243.411 1078.8325""
				},
				{
					""tag"": ""4.B1.WS.296"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1244.7102 1156.7472""
				},
				{
					""tag"": ""4.B1.WS.297"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1330.4244 1156.748""
				},
				{
					""tag"": ""4.B1.WS.292"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1244.7102 1078.837""
				},
				{
					""tag"": ""4.B1.WS.291"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1330.424 1078.8325""
				},
				{
					""tag"": ""4.B1.WS.298"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1331.7231 1156.7472""
				},
				{
					""tag"": ""4.B1.WS.305"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1331.7231 1078.837""
				},
				{
					""tag"": ""4.B1.WS.301"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1158.2439 1198.7228""
				},
				{
					""tag"": ""4.B1.WS.300"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1243.9581 1198.7238""
				},
				{
					""tag"": ""4.B1.WS.299"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1246.5555 1198.7228""
				},
				{
					""tag"": ""4.B1.WS.302"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1158.2439 1276.6338""
				},
				{
					""tag"": ""4.B1.WS.303"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1243.9581 1276.6346""
				},
				{
					""tag"": ""4.B1.WS.304"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1246.5555 1276.6338""
				}
			]
		},
		""Section-6"": {
			""tag"": ""Section-6"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.B1.WS.396"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1303.1517 1319.9756""
				},
				{
					""tag"": ""4.B1.WS.393"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1388.866 1319.9764""
				},
				{
					""tag"": ""4.B1.WS.394"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1303.1517 1242.0654""
				},
				{
					""tag"": ""4.B1.WS.395"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1388.8656 1242.0609""
				}
			]
		}
	}
}";

            migrationBuilder.InsertData(table: "MapConfiguration",
            columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
            values: new object[]
            {
                "2-3-1-1",
                bangalore4thFloorBay1Map,
                "V1",
                "1",
                DateTime.Now
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
