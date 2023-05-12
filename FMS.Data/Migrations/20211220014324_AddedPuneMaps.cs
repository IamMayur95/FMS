using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FMS.Data.Migrations
{
    public partial class AddedPune5thFloorMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // ------------------------
            // Pune 4th Floor Map
            // ------------------------

            string pune4thFloorMap = @"{
	""assets"": {
		""pic"": {
			""name"": ""Pune 4th Floor Plan"",
			""ref"": ""./assets/1-1-5-12.png""
		},
		""svg"": {
			""name"": ""Pune 4th Floor Assets"",
			""ref"": ""./assets/1-1-5-12.svg""
		}
	},
	""models"": {
		""Mod-1"": {
			""name"": ""PTableL"",
			""template"": ""t2""
		},
		""Mod-2"": {
			""name"": ""PTable120"",
			""template"": ""t2""
		},
		""Mod-3"": {
			""name"": ""PTabelS"",
			""template"": ""t2""
		}
	},
	""areas"": {
		""Area-1"": {
			""tag"": ""Ladies Washroom""
		},
		""Area-2"": {
			""tag"": ""Gents Washroom""
		},
		""Area-3"": {
			""tag"": ""Handicap Washroom""
		},
		""Area-4"": {
			""tag"": ""Lift Lobby""
		},
		""Area-5"": {
			""tag"": ""Lift Lobby""
		},
		""Area-6"": {
			""tag"": ""Ladies Washroom""
		},
		""Area-7"": {
			""tag"": ""Gents Washroom""
		},
		""Area-8"": {
			""tag"": ""Shower Room""
		},
		""Area-9"": {
			""tag"": ""Janitor""
		},
		""Area-10"": {
			""tag"": ""Builder’s Pantry""
		},
		""Area-11"": {
			""tag"": ""Wet Pantry""
		},
		""Area-12"": {
			""tag"": ""Staircase""
		},
		""Area-13"": {
			""tag"": ""Hub Room""
		},
		""Area-14"": {
			""tag"": ""Electrical Room""
		},
		""Area-15"": {
			""tag"": ""Collaboration Area""
		},
		""Area-16"": {
			""tag"": ""Managers Cabin 4.1""
		},
		""Area-17"": {
			""tag"": ""Collaboration Area""
		},
		""Area-18"": {
			""tag"": ""Meeting Room""
		},
		""Area-19"": {
			""tag"": ""Meeting Room""
		},
		""Area-20"": {
			""tag"": ""Meeting Room""
		},
		""Area-21"": {
			""tag"": ""Amphitheatre""
		},
		""Area-22"": {
			""tag"": ""Dry Pantry""
		},
		""Area-23"": {
			""tag"": ""Managers Cabin 4.4""
		},
		""Area-24"": {
			""tag"": ""Collaboration Area""
		},
		""Area-25"": {
			""tag"": ""Phoon Booth""
		},
		""Area-26"": {
			""tag"": ""Meeting Room""
		},
		""Area-27"": {
			""tag"": ""Meeting Room""
		},
		""Area-28"": {
			""tag"": ""Phoon Booth""
		},
		""Area-29"": {
			""tag"": ""Meeting Room""
		},
		""Area-30"": {
			""tag"": ""Hub Room""
		},
		""Area-31"": {
			""tag"": ""Staircase""
		},
		""Area-32"": {
			""tag"": ""Builder’s Pantry""
		},
		""Area-33"": {
			""tag"": ""Media Scape""
		},
		""Area-34"": {
			""tag"": ""Managers Cabin 4.3""
		},
		""Area-35"": {
			""tag"": ""Managers Cabin 4.2""
		},
		""Area-36"": {
			""tag"": ""Open Meeting""
		},
		""Area-37"": {
			""tag"": ""Collaboration Area""
		},
		""Area-38"": {
			""tag"": ""Meeting Room""
		},
		""Area-39"": {
			""tag"": ""Collaboration Area""
		},
		""Area-40"": {
			""tag"": ""Meeting Room""
		},
		""Area-41"": {
			""tag"": ""IT Store""
		}
	},
	""sections"": {
		""Section-1"": {
			""tag"": ""Section-1"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.W.WS.001"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 133.7854 12.8871""
				},
				{
					""tag"": ""4.W.WS.002"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 133.7854 91.8095""
				},
				{
					""tag"": ""4.W.WS.003"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 133.7854 90.8092""
				},
				{
					""tag"": ""4.W.WS.004"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 133.7854 169.7315""
				},
				{
					""tag"": ""4.W.WS.005"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 219.201 12.8871""
				},
				{
					""tag"": ""4.W.WS.006"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 219.201 91.8095""
				},
				{
					""tag"": ""4.W.WS.007"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 219.201 90.8092""
				},
				{
					""tag"": ""4.W.WS.008"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 219.201 169.7315""
				},
				{
					""tag"": ""4.W.WS.012"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 218.2007 12.8871""
				},
				{
					""tag"": ""4.W.WS.011"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 218.2007 91.8095""
				},
				{
					""tag"": ""4.W.WS.010"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 218.2007 90.8092""
				},
				{
					""tag"": ""4.W.WS.009"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 218.2007 169.7315""
				},
				{
					""tag"": ""4.W.WS.015"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 303.915 12.8871""
				},
				{
					""tag"": ""4.W.WS.016"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 303.915 91.8095""
				},
				{
					""tag"": ""4.W.WS.017"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 303.915 90.8092""
				},
				{
					""tag"": ""4.W.WS.018"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 303.915 169.7315""
				},
				{
					""tag"": ""4.W.WS.014"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 304.9153 90.8092""
				},
				{
					""tag"": ""4.W.WS.013"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 304.9153 169.7315""
				},
				{
					""tag"": ""4.W.WS.019"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 369.4382 141.9548""
				},
				{
					""tag"": ""4.W.WS.020"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 416.6759 114.6841""
				},
				{
					""tag"": ""4.W.WS.021"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 463.9137 141.9587""
				},
				{
					""tag"": ""4.W.WS.022"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 463.9137 141.9587""
				},
				{
					""tag"": ""4.W.WS.023"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 463.9137 141.9587""
				},
				{
					""tag"": ""4.W.WS.024"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 416.6759 114.6841""
				},
				{
					""tag"": ""4.W.WS.025"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 416.6759 60.1409""
				},
				{
					""tag"": ""4.W.WS.026"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 463.9137 32.8678""
				},
				{
					""tag"": ""4.W.WS.027"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 416.6759 60.1409""
				},
				{
					""tag"": ""4.W.WS.028"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 416.6759 60.1409""
				},
				{
					""tag"": ""4.W.WS.029"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 416.6759 114.6841""
				},
				{
					""tag"": ""4.W.WS.046"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 560.3281 141.9548""
				},
				{
					""tag"": ""4.W.WS.045"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 607.5659 114.6841""
				},
				{
					""tag"": ""4.W.WS.044"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 654.8036 141.9587""
				},
				{
					""tag"": ""4.W.WS.043"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 654.8036 141.9587""
				},
				{
					""tag"": ""4.W.WS.040"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 654.8036 141.9587""
				},
				{
					""tag"": ""4.W.WS.030"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 560.3283 141.9587""
				},
				{
					""tag"": ""4.W.WS.031"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 560.3283 141.9587""
				},
				{
					""tag"": ""4.W.WS.039"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 607.5659 114.6841""
				},
				{
					""tag"": ""4.W.WS.038"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 607.5659 60.1409""
				},
				{
					""tag"": ""4.W.WS.037"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 654.8036 32.8678""
				},
				{
					""tag"": ""4.W.WS.034"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 560.3281 32.8678""
				},
				{
					""tag"": ""4.W.WS.035"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 607.5659 60.1409""
				},
				{
					""tag"": ""4.W.WS.033"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 607.5659 60.1409""
				},
				{
					""tag"": ""4.W.WS.042"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 702.04 114.6841""
				},
				{
					""tag"": ""4.W.WS.041"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 749.2778 141.9587""
				},
				{
					""tag"": ""4.W.WS.036"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 702.04 60.1409""
				},
				{
					""tag"": ""4.W.WS.032"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 607.5659 114.6841""
				}
			]
		},
		""Section-2"": {
			""tag"": ""Section-2"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.W.WS.047"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 50.663 207.7053""
				},
				{
					""tag"": ""4.W.WS.048"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 50.663 364.5497""
				},
				{
					""tag"": ""4.W.WS.056"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 137.3831 207.7053""
				},
				{
					""tag"": ""4.W.WS.055"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 137.3831 286.6277""
				},
				{
					""tag"": ""4.W.WS.054"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 137.3831 285.6274""
				},
				{
					""tag"": ""4.W.WS.053"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 137.3831 364.5497""
				},
				{
					""tag"": ""4.W.WS.057"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 136.3828 207.7053""
				},
				{
					""tag"": ""4.W.WS.058"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 136.3828 286.6277""
				},
				{
					""tag"": ""4.W.WS.059"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 136.3828 285.6274""
				},
				{
					""tag"": ""4.W.WS.060"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 136.3828 364.5497""
				},
				{
					""tag"": ""4.W.WS.066"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 223.0974 285.6274""
				},
				{
					""tag"": ""4.W.WS.065"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 223.0974 364.5497""
				},
				{
					""tag"": ""4.W.WS.049"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 50.663 363.5625""
				},
				{
					""tag"": ""4.W.WS.050"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 50.663 442.4848""
				},
				{
					""tag"": ""4.W.WS.052"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 137.3831 363.5625""
				},
				{
					""tag"": ""4.W.WS.051"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 137.3831 442.4848""
				},
				{
					""tag"": ""4.W.WS.061"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 136.3828 363.5625""
				},
				{
					""tag"": ""4.W.WS.062"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 136.3828 442.4848""
				},
				{
					""tag"": ""4.W.WS.064"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 223.0974 363.5625""
				},
				{
					""tag"": ""4.W.WS.063"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 223.0974 442.4848""
				},
				{
					""tag"": ""4.W.WS.068"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 223.0974 207.6923""
				},
				{
					""tag"": ""4.W.WS.067"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 223.0974 286.6147""
				}
			]
		},
		""Section-3"": {
			""tag"": ""Section-3"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.W.WS.072"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 264.9743 207.7053""
				},
				{
					""tag"": ""4.W.WS.071"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 264.9743 364.5497""
				},
				{
					""tag"": ""4.W.WS.073"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 350.3732 207.7053""
				},
				{
					""tag"": ""4.W.WS.074"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 350.3732 286.6277""
				},
				{
					""tag"": ""4.W.WS.075"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 350.3732 285.6274""
				},
				{
					""tag"": ""4.W.WS.076"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 350.3732 364.5497""
				},
				{
					""tag"": ""4.W.WS.084"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 349.3729 207.7053""
				},
				{
					""tag"": ""4.W.WS.083"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 349.3729 286.6277""
				},
				{
					""tag"": ""4.W.WS.082"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 349.3729 285.6274""
				},
				{
					""tag"": ""4.W.WS.081"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 349.3729 364.5497""
				},
				{
					""tag"": ""4.W.WS.070"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 264.9743 363.5625""
				},
				{
					""tag"": ""4.W.WS.069"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 264.9743 442.4848""
				},
				{
					""tag"": ""4.W.WS.077"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 350.3732 363.5625""
				},
				{
					""tag"": ""4.W.WS.078"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 350.3732 442.4848""
				},
				{
					""tag"": ""4.W.WS.080"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 349.3729 363.5625""
				},
				{
					""tag"": ""4.W.WS.079"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 349.3729 442.4848""
				},
				{
					""tag"": ""4.W.WS.085"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 434.7885 207.7053""
				},
				{
					""tag"": ""4.W.WS.086"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 434.7885 286.6277""
				},
				{
					""tag"": ""4.W.WS.087"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 434.7885 285.6274""
				},
				{
					""tag"": ""4.W.WS.088"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 434.7885 364.5497""
				},
				{
					""tag"": ""4.W.WS.096"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 433.7882 207.7053""
				},
				{
					""tag"": ""4.W.WS.095"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 433.7882 286.6277""
				},
				{
					""tag"": ""4.W.WS.094"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 433.7882 285.6274""
				},
				{
					""tag"": ""4.W.WS.093"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 433.7882 364.5497""
				},
				{
					""tag"": ""4.W.WS.089"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 434.7885 363.5625""
				},
				{
					""tag"": ""4.W.WS.090"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 434.7885 442.4848""
				},
				{
					""tag"": ""4.W.WS.092"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 433.7882 363.5625""
				},
				{
					""tag"": ""4.W.WS.091"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 433.7882 442.4848""
				},
				{
					""tag"": ""4.W.WS.097"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 521.4742 207.7053""
				},
				{
					""tag"": ""4.W.WS.098"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 521.4742 364.5497""
				},
				{
					""tag"": ""4.W.WS.106"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 520.4739 207.7053""
				},
				{
					""tag"": ""4.W.WS.105"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 520.4739 286.6277""
				},
				{
					""tag"": ""4.W.WS.104"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 520.4739 285.6274""
				},
				{
					""tag"": ""4.W.WS.103"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 520.4739 364.5497""
				},
				{
					""tag"": ""4.W.WS.099"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 521.4742 363.5625""
				},
				{
					""tag"": ""4.W.WS.100"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 521.4742 442.4848""
				},
				{
					""tag"": ""4.W.WS.102"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 520.4739 363.5625""
				},
				{
					""tag"": ""4.W.WS.101"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 520.4739 442.4848""
				},
				{
					""tag"": ""4.W.WS.107"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 608.16 207.7053""
				},
				{
					""tag"": ""4.W.WS.108"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 608.16 286.6277""
				},
				{
					""tag"": ""4.W.WS.109"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 608.16 285.6274""
				},
				{
					""tag"": ""4.W.WS.110"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 608.16 364.5497""
				},
				{
					""tag"": ""4.W.WS.118"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 607.1597 207.7053""
				},
				{
					""tag"": ""4.W.WS.117"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 607.1597 286.6277""
				},
				{
					""tag"": ""4.W.WS.116"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 607.1597 285.6274""
				},
				{
					""tag"": ""4.W.WS.115"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 607.1597 364.5497""
				},
				{
					""tag"": ""4.W.WS.111"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 608.16 363.5625""
				},
				{
					""tag"": ""4.W.WS.112"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 608.16 442.4848""
				},
				{
					""tag"": ""4.W.WS.114"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 607.1597 363.5625""
				},
				{
					""tag"": ""4.W.WS.113"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 607.1597 442.4848""
				},
				{
					""tag"": ""4.W.WS.119"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 694.8457 207.7053""
				},
				{
					""tag"": ""4.W.WS.120"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 694.8457 286.6277""
				},
				{
					""tag"": ""4.W.WS.121"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 694.8457 285.6274""
				},
				{
					""tag"": ""4.W.WS.122"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 694.8457 364.5497""
				},
				{
					""tag"": ""4.W.WS.125"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 693.8454 207.7053""
				},
				{
					""tag"": ""4.W.WS.126"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 693.8454 364.5497""
				},
				{
					""tag"": ""4.W.WS.123"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 694.8457 363.5625""
				},
				{
					""tag"": ""4.W.WS.124"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 694.8457 442.4848""
				},
				{
					""tag"": ""4.W.WS.127"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 693.8454 363.5625""
				},
				{
					""tag"": ""4.W.WS.128"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 693.8454 442.4848""
				},
				{
					""tag"": ""4.W.WS.134"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 781.5314 207.7053""
				},
				{
					""tag"": ""4.W.WS.133"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 781.5314 286.6277""
				},
				{
					""tag"": ""4.W.WS.132"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 781.5314 285.6274""
				},
				{
					""tag"": ""4.W.WS.131"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 781.5314 364.5497""
				},
				{
					""tag"": ""4.W.WS.135"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 780.5311 207.7053""
				},
				{
					""tag"": ""4.W.WS.136"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 780.5311 286.6277""
				},
				{
					""tag"": ""4.W.WS.137"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 780.5311 285.6274""
				},
				{
					""tag"": ""4.W.WS.138"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 780.5311 364.5497""
				},
				{
					""tag"": ""4.W.WS.130"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 781.5314 363.5625""
				},
				{
					""tag"": ""4.W.WS.129"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 781.5314 442.4848""
				},
				{
					""tag"": ""4.W.WS.139"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 780.5311 363.5625""
				},
				{
					""tag"": ""4.W.WS.140"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 780.5311 442.4848""
				},
				{
					""tag"": ""4.W.WS.146"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 865.9503 207.7053""
				},
				{
					""tag"": ""4.W.WS.145"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 865.9503 286.6277""
				},
				{
					""tag"": ""4.W.WS.144"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 865.9503 285.6274""
				},
				{
					""tag"": ""4.W.WS.143"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 865.9503 364.5497""
				},
				{
					""tag"": ""4.W.WS.147"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 864.95 207.7053""
				},
				{
					""tag"": ""4.W.WS.148"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 864.95 286.6277""
				},
				{
					""tag"": ""4.W.WS.149"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 864.95 285.6274""
				},
				{
					""tag"": ""4.W.WS.150"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 864.95 364.5497""
				},
				{
					""tag"": ""4.W.WS.142"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 865.9503 363.5625""
				},
				{
					""tag"": ""4.W.WS.141"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 865.9503 442.4848""
				},
				{
					""tag"": ""4.W.WS.152"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 950.3704 207.7053""
				},
				{
					""tag"": ""4.W.WS.151"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 950.3704 364.5497""
				}
			]
		},
		""Section-4"": {
			""tag"": ""Section-4"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.S.WS.018"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 80.8838 581.0376""
				},
				{
					""tag"": ""4.S.WS.019"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 128.1215 553.7668""
				},
				{
					""tag"": ""4.S.WS.020"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 175.3592 581.0415""
				},
				{
					""tag"": ""4.S.WS.021"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 175.3592 581.0415""
				},
				{
					""tag"": ""4.S.WS.024"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 175.3592 581.0415""
				},
				{
					""tag"": ""4.S.WS.025"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 128.1215 553.7668""
				},
				{
					""tag"": ""4.S.WS.004"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 33.646 553.7668""
				},
				{
					""tag"": ""4.S.WS.026"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 128.1215 499.2237""
				},
				{
					""tag"": ""4.S.WS.001"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 128.1215 499.2237""
				},
				{
					""tag"": ""4.S.WS.002"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 128.1215 553.7668""
				},
				{
					""tag"": ""4.S.WS.022"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 222.5954 499.2237""
				},
				{
					""tag"": ""4.S.WS.023"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 222.5954 553.7668""
				},
				{
					""tag"": ""4.S.WS.011"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 128.1215 717.4032""
				},
				{
					""tag"": ""4.S.WS.010"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 128.1215 717.4032""
				},
				{
					""tag"": ""4.S.WS.015"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 222.5954 717.4032""
				},
				{
					""tag"": ""4.S.WS.007"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 33.646 662.8539""
				},
				{
					""tag"": ""4.S.WS.008"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 80.8838 635.5831""
				},
				{
					""tag"": ""4.S.WS.009"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 128.1215 662.8578""
				},
				{
					""tag"": ""4.S.WS.012"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 128.1215 662.8578""
				},
				{
					""tag"": ""4.S.WS.016"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 128.1215 662.8578""
				},
				{
					""tag"": ""4.S.WS.017"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 80.8838 635.5831""
				},
				{
					""tag"": ""4.S.WS.003"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 80.8838 581.04""
				},
				{
					""tag"": ""4.S.WS.005"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 80.8838 581.04""
				},
				{
					""tag"": ""4.S.WS.013"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 175.358 635.5831""
				},
				{
					""tag"": ""4.S.WS.014"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 222.5957 662.8578""
				},
				{
					""tag"": ""4.S.WS.006"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 80.8838 635.5831""
				}
			]
		},
		""Section-5"": {
			""tag"": ""Section-5"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.E.WS.001"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 50.6688 774.1516""
				},
				{
					""tag"": ""4.E.WS.002"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 50.6688 853.0739""
				},
				{
					""tag"": ""4.E.WS.003"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 50.6688 852.0736""
				},
				{
					""tag"": ""4.E.WS.010"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 137.3888 774.1516""
				},
				{
					""tag"": ""4.E.WS.009"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 137.3888 853.0739""
				},
				{
					""tag"": ""4.E.WS.008"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 137.3888 852.0736""
				},
				{
					""tag"": ""4.E.WS.007"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 137.3888 930.996""
				},
				{
					""tag"": ""4.E.WS.011"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 136.3885 774.1516""
				},
				{
					""tag"": ""4.E.WS.012"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 136.3885 853.0739""
				},
				{
					""tag"": ""4.E.WS.013"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 136.3885 852.0736""
				},
				{
					""tag"": ""4.E.WS.014"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 136.3885 930.996""
				},
				{
					""tag"": ""4.E.WS.020"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 223.1031 852.0736""
				},
				{
					""tag"": ""4.E.WS.019"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 223.1031 930.996""
				},
				{
					""tag"": ""4.E.WS.004"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 50.6688 1008.9311""
				},
				{
					""tag"": ""4.E.WS.006"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 137.3888 930.0087""
				},
				{
					""tag"": ""4.E.WS.005"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 137.3888 1008.9311""
				},
				{
					""tag"": ""4.E.WS.015"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 136.3885 930.0087""
				},
				{
					""tag"": ""4.E.WS.016"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 136.3885 1008.9311""
				},
				{
					""tag"": ""4.E.WS.018"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 223.1031 930.0087""
				},
				{
					""tag"": ""4.E.WS.017"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 223.1031 1008.9311""
				},
				{
					""tag"": ""4.E.WS.022"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 223.1031 774.1385""
				},
				{
					""tag"": ""4.E.WS.021"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 223.1031 853.0609""
				}
			]
		},
		""Section-6"": {
			""tag"": ""Section-6"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.E.WS.023"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 264.9545 774.1516""
				},
				{
					""tag"": ""4.E.WS.024"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 264.9545 853.0739""
				},
				{
					""tag"": ""4.E.WS.025"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 264.9545 852.0736""
				},
				{
					""tag"": ""4.E.WS.032"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 350.3534 774.1516""
				},
				{
					""tag"": ""4.E.WS.031"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 350.3534 853.0739""
				},
				{
					""tag"": ""4.E.WS.030"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 350.3534 852.0736""
				},
				{
					""tag"": ""4.E.WS.029"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 350.3534 930.996""
				},
				{
					""tag"": ""4.E.WS.033"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 349.3531 774.1516""
				},
				{
					""tag"": ""4.E.WS.034"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 349.3531 853.0739""
				},
				{
					""tag"": ""4.E.WS.035"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 349.3531 852.0736""
				},
				{
					""tag"": ""4.E.WS.036"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 349.3531 930.996""
				},
				{
					""tag"": ""4.E.WS.026"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 264.9545 1008.9311""
				},
				{
					""tag"": ""4.E.WS.028"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 350.3534 930.0087""
				},
				{
					""tag"": ""4.E.WS.027"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 350.3534 1008.9311""
				},
				{
					""tag"": ""4.E.WS.037"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 349.3531 930.0087""
				},
				{
					""tag"": ""4.E.WS.038"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 349.3531 1008.9311""
				},
				{
					""tag"": ""4.E.WS.044"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 434.7687 774.1516""
				},
				{
					""tag"": ""4.E.WS.043"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 434.7687 853.0739""
				},
				{
					""tag"": ""4.E.WS.042"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 434.7687 852.0736""
				},
				{
					""tag"": ""4.E.WS.041"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 434.7687 930.996""
				},
				{
					""tag"": ""4.E.WS.045"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 433.7685 774.1516""
				},
				{
					""tag"": ""4.E.WS.046"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 433.7685 853.0739""
				},
				{
					""tag"": ""4.E.WS.047"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 433.7685 852.0736""
				},
				{
					""tag"": ""4.E.WS.048"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 433.7685 930.996""
				},
				{
					""tag"": ""4.E.WS.040"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 434.7687 930.0087""
				},
				{
					""tag"": ""4.E.WS.039"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 434.7687 1008.9311""
				},
				{
					""tag"": ""4.E.WS.049"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 433.7685 930.0087""
				},
				{
					""tag"": ""4.E.WS.050"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 433.7685 1008.9311""
				},
				{
					""tag"": ""4.E.WS.054"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 522.147 774.1516""
				},
				{
					""tag"": ""4.E.WS.053"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 522.147 853.0739""
				},
				{
					""tag"": ""4.E.WS.052"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 522.147 852.0736""
				},
				{
					""tag"": ""4.E.WS.055"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 521.1467 774.1516""
				},
				{
					""tag"": ""4.E.WS.056"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 521.1467 853.0739""
				},
				{
					""tag"": ""4.E.WS.057"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 521.1467 852.0736""
				},
				{
					""tag"": ""4.E.WS.058"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 521.1467 930.996""
				},
				{
					""tag"": ""4.E.WS.051"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 522.147 1008.9311""
				},
				{
					""tag"": ""4.E.WS.059"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 521.1467 930.0087""
				},
				{
					""tag"": ""4.E.WS.060"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 521.1467 1008.9311""
				},
				{
					""tag"": ""4.E.WS.066"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 609.4976 774.1516""
				},
				{
					""tag"": ""4.E.WS.065"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 609.4976 853.0739""
				},
				{
					""tag"": ""4.E.WS.064"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 609.4976 852.0736""
				},
				{
					""tag"": ""4.E.WS.063"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 609.4976 930.996""
				},
				{
					""tag"": ""4.E.WS.067"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 608.4973 774.1516""
				},
				{
					""tag"": ""4.E.WS.068"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 608.4973 853.0739""
				},
				{
					""tag"": ""4.E.WS.069"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 608.4973 852.0736""
				},
				{
					""tag"": ""4.E.WS.070"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 608.4973 930.996""
				},
				{
					""tag"": ""4.E.WS.062"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 609.4976 930.0087""
				},
				{
					""tag"": ""4.E.WS.061"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 609.4976 1008.9311""
				},
				{
					""tag"": ""4.E.WS.071"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 608.4973 930.0087""
				},
				{
					""tag"": ""4.E.WS.072"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 608.4973 1008.9311""
				},
				{
					""tag"": ""4.E.WS.076"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 696.8483 774.1516""
				},
				{
					""tag"": ""4.E.WS.075"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 696.8483 853.0739""
				},
				{
					""tag"": ""4.E.WS.077"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 695.848 774.1516""
				},
				{
					""tag"": ""4.E.WS.078"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 695.848 853.0739""
				},
				{
					""tag"": ""4.E.WS.074"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 696.8483 930.0087""
				},
				{
					""tag"": ""4.E.WS.073"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 696.8483 1008.9311""
				},
				{
					""tag"": ""4.E.WS.079"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 695.848 1008.9311""
				},
				{
					""tag"": ""4.E.WS.085"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 784.1962 774.1516""
				},
				{
					""tag"": ""4.E.WS.084"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 784.1962 853.0739""
				},
				{
					""tag"": ""4.E.WS.083"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 784.1962 852.0736""
				},
				{
					""tag"": ""4.E.WS.082"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 784.1962 930.996""
				},
				{
					""tag"": ""4.E.WS.086"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 783.196 774.1516""
				},
				{
					""tag"": ""4.E.WS.087"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 783.196 853.0739""
				},
				{
					""tag"": ""4.E.WS.088"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 783.196 852.0736""
				},
				{
					""tag"": ""4.E.WS.089"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 783.196 930.996""
				},
				{
					""tag"": ""4.E.WS.081"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 784.1962 930.0087""
				},
				{
					""tag"": ""4.E.WS.080"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 784.1962 1008.9311""
				},
				{
					""tag"": ""4.E.WS.090"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 783.196 930.0087""
				},
				{
					""tag"": ""4.E.WS.091"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 783.196 1008.9311""
				},
				{
					""tag"": ""4.E.WS.097"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 868.6145 774.1516""
				},
				{
					""tag"": ""4.E.WS.096"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 868.6145 853.0739""
				},
				{
					""tag"": ""4.E.WS.095"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 868.6145 852.0736""
				},
				{
					""tag"": ""4.E.WS.094"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 868.6145 930.996""
				},
				{
					""tag"": ""4.E.WS.098"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 867.6142 774.1516""
				},
				{
					""tag"": ""4.E.WS.099"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 867.6142 853.0739""
				},
				{
					""tag"": ""4.E.WS.100"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 867.6142 852.0736""
				},
				{
					""tag"": ""4.E.WS.101"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 867.6142 930.996""
				},
				{
					""tag"": ""4.E.WS.093"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 868.6145 930.0087""
				},
				{
					""tag"": ""4.E.WS.092"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 868.6145 1008.9311""
				},
				{
					""tag"": ""4.E.WS.102"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 867.6142 930.0087""
				},
				{
					""tag"": ""4.E.WS.103"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 867.6142 1008.9311""
				},
				{
					""tag"": ""4.E.WS.107"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 953.0301 774.1516""
				},
				{
					""tag"": ""4.E.WS.106"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 953.0301 853.0739""
				},
				{
					""tag"": ""4.E.WS.105"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 953.0301 852.0736""
				},
				{
					""tag"": ""4.E.WS.104"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 953.0301 1008.9311""
				}
			]
		},
		""Section-7"": {
			""tag"": ""Section-7"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.E.WS.126"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 404.9876 1097.1398""
				},
				{
					""tag"": ""4.E.WS.127"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 452.2253 1069.869""
				},
				{
					""tag"": ""4.E.WS.119"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 357.7498 1069.869""
				},
				{
					""tag"": ""4.E.WS.128"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 452.2253 1069.869""
				},
				{
					""tag"": ""4.E.WS.131"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 357.7498 1069.869""
				},
				{
					""tag"": ""4.E.WS.129"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 452.2253 1069.869""
				},
				{
					""tag"": ""4.E.WS.118"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 357.7502 1069.869""
				},
				{
					""tag"": ""4.E.WS.123"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 404.9876 1151.6853""
				},
				{
					""tag"": ""4.E.WS.124"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 452.2253 1178.96""
				},
				{
					""tag"": ""4.E.WS.122"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 357.7498 1178.96""
				},
				{
					""tag"": ""4.E.WS.125"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 404.9876 1151.6853""
				},
				{
					""tag"": ""4.E.WS.130"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 404.9876 1097.1422""
				},
				{
					""tag"": ""4.E.WS.120"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 404.9876 1097.1422""
				},
				{
					""tag"": ""4.E.WS.121"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 404.9876 1151.6853""
				},
				{
					""tag"": ""4.E.WS.138"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 598.8964 1097.1398""
				},
				{
					""tag"": ""4.E.WS.137"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 646.1342 1069.869""
				},
				{
					""tag"": ""4.E.WS.145"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 551.6586 1069.869""
				},
				{
					""tag"": ""4.E.WS.136"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 646.1342 1069.869""
				},
				{
					""tag"": ""4.E.WS.133"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 551.6586 1069.869""
				},
				{
					""tag"": ""4.E.WS.135"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 646.1342 1069.869""
				},
				{
					""tag"": ""4.E.WS.132"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 551.659 1069.869""
				},
				{
					""tag"": ""4.E.WS.141"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 598.8964 1151.6853""
				},
				{
					""tag"": ""4.E.WS.140"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 646.1342 1178.96""
				},
				{
					""tag"": ""4.E.WS.142"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 551.6586 1178.96""
				},
				{
					""tag"": ""4.E.WS.139"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 598.8964 1151.6853""
				},
				{
					""tag"": ""4.E.WS.134"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 598.8964 1097.1422""
				},
				{
					""tag"": ""4.E.WS.144"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 598.8964 1097.1422""
				},
				{
					""tag"": ""4.E.WS.143"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 598.8964 1151.6853""
				},
				{
					""tag"": ""4.E.WS.108"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 183.1064 1042.0862""
				},
				{
					""tag"": ""4.E.WS.109"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 183.1064 1121.0084""
				},
				{
					""tag"": ""4.E.WS.110"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 183.1064 1120.0212""
				},
				{
					""tag"": ""4.E.WS.111"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 183.1064 1198.9436""
				},
				{
					""tag"": ""4.E.WS.115"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 268.522 1042.0862""
				},
				{
					""tag"": ""4.E.WS.114"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 268.522 1121.0084""
				},
				{
					""tag"": ""4.E.WS.116"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 267.5217 1042.0862""
				},
				{
					""tag"": ""4.E.WS.117"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 267.5217 1121.0084""
				},
				{
					""tag"": ""4.E.WS.113"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 268.522 1120.0212""
				},
				{
					""tag"": ""4.E.WS.112"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 268.522 1198.9436""
				},
				{
					""tag"": ""4.E.WS.147"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 735.7599 1042.0991""
				},
				{
					""tag"": ""4.E.WS.146"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 735.7599 1121.0215""
				},
				{
					""tag"": ""4.E.WS.148"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 734.7596 1042.0991""
				},
				{
					""tag"": ""4.E.WS.149"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 734.7596 1121.0189""
				},
				{
					""tag"": ""4.E.WS.150"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 734.7596 1120.0342""
				},
				{
					""tag"": ""4.E.WS.151"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 734.7596 1198.9565""
				},
				{
					""tag"": ""4.E.WS.155"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 821.4742 1042.0967""
				},
				{
					""tag"": ""4.E.WS.154"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 821.4742 1121.024""
				},
				{
					""tag"": ""4.E.WS.153"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 821.4872 1120.0212""
				},
				{
					""tag"": ""4.E.WS.152"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 821.4872 1198.9436""
				}
			]
		},
		""Section-8"": {
			""tag"": ""Section-8"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.E.WS.156"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1400.519 916.1581""
				},
				{
					""tag"": ""4.E.WS.157"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1439.4795 916.1581""
				},
				{
					""tag"": ""4.E.WS.158"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1478.4399 916.1581""
				},
				{
					""tag"": ""4.E.WS.159"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1517.4003 916.1581""
				},
				{
					""tag"": ""4.E.WS.160"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1517.4003 964.4698""
				},
				{
					""tag"": ""4.E.WS.161"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1478.4399 964.4698""
				},
				{
					""tag"": ""4.E.WS.162"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1439.4795 964.4698""
				},
				{
					""tag"": ""4.E.WS.163"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1400.519 964.4698""
				},
				{
					""tag"": ""4.E.WS.164"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1361.5587 964.4698""
				},
				{
					""tag"": ""4.E.WS.165"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1361.5587 1012.8034""
				},
				{
					""tag"": ""4.E.WS.166"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1400.519 1012.8034""
				},
				{
					""tag"": ""4.E.WS.167"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1439.4795 1012.8034""
				},
				{
					""tag"": ""4.E.WS.168"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1478.4399 1012.8034""
				},
				{
					""tag"": ""4.E.WS.169"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1517.4003 1012.8034""
				},
				{
					""tag"": ""4.E.WS.170"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1517.4003 1061.1151""
				},
				{
					""tag"": ""4.E.WS.171"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1478.4399 1061.1151""
				},
				{
					""tag"": ""4.E.WS.172"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1439.4795 1061.1151""
				},
				{
					""tag"": ""4.E.WS.173"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1400.519 1061.1151""
				},
				{
					""tag"": ""4.E.WS.174"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1361.5587 1061.1151""
				},
				{
					""tag"": ""4.E.WS.175"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1400.519 1109.4268""
				},
				{
					""tag"": ""4.E.WS.176"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1439.4795 1109.4268""
				},
				{
					""tag"": ""4.E.WS.177"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1478.4399 1109.4268""
				},
				{
					""tag"": ""4.E.WS.178"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1517.4003 1109.4268""
				},
				{
					""tag"": ""4.E.WS.179"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1517.4003 1161.6345""
				},
				{
					""tag"": ""4.E.WS.180"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1478.4399 1161.6345""
				},
				{
					""tag"": ""4.E.WS.181"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1439.4795 1161.6345""
				},
				{
					""tag"": ""4.E.WS.182"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1400.519 1161.6345""
				},
				{
					""tag"": ""4.E.WS.200"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1642.0939 916.1581""
				},
				{
					""tag"": ""4.E.WS.199"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1681.0542 916.1581""
				},
				{
					""tag"": ""4.E.WS.198"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1720.0146 916.1581""
				},
				{
					""tag"": ""4.E.WS.195"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1642.0939 964.4698""
				},
				{
					""tag"": ""4.E.WS.196"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1681.0542 964.4698""
				},
				{
					""tag"": ""4.E.WS.197"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1720.0146 964.4698""
				},
				{
					""tag"": ""4.E.WS.194"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1642.0939 1012.8034""
				},
				{
					""tag"": ""4.E.WS.193"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1681.0542 1012.8034""
				},
				{
					""tag"": ""4.E.WS.192"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1720.0146 1012.8034""
				},
				{
					""tag"": ""4.E.WS.189"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1642.0939 1061.1151""
				},
				{
					""tag"": ""4.E.WS.190"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1681.0542 1061.1151""
				},
				{
					""tag"": ""4.E.WS.191"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1720.0146 1061.1151""
				},
				{
					""tag"": ""4.E.WS.188"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1642.0939 1109.4268""
				},
				{
					""tag"": ""4.E.WS.187"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1681.0542 1109.4268""
				},
				{
					""tag"": ""4.E.WS.186"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1720.0146 1109.4268""
				},
				{
					""tag"": ""4.E.WS.183"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1642.0939 1161.6345""
				},
				{
					""tag"": ""4.E.WS.184"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1681.0542 1161.6345""
				},
				{
					""tag"": ""4.E.WS.185"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 1720.0146 1161.6345""
				}
			]
		},
		""Section-9"": {
			""tag"": ""Section-9"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.E.WS.231"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1874.0454 1107.2715""
				},
				{
					""tag"": ""4.E.WS.230"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1952.9678 1107.2715""
				},
				{
					""tag"": ""4.E.WS.226"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1874.0454 1108.2717""
				},
				{
					""tag"": ""4.E.WS.227"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1952.9678 1108.2717""
				},
				{
					""tag"": ""4.E.WS.221"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1874.0454 1023.5052""
				},
				{
					""tag"": ""4.E.WS.220"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1952.9678 1023.5052""
				},
				{
					""tag"": ""4.E.WS.216"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1874.0454 1024.5055""
				},
				{
					""tag"": ""4.E.WS.217"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1952.9678 1024.5055""
				},
				{
					""tag"": ""4.E.WS.211"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1874.0454 939.739""
				},
				{
					""tag"": ""4.E.WS.212"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1952.9678 939.739""
				},
				{
					""tag"": ""4.E.WS.207"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1874.0454 940.7393""
				},
				{
					""tag"": ""4.E.WS.208"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1952.9678 940.7393""
				},
				{
					""tag"": ""4.E.WS.203"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1874.0454 855.9727""
				},
				{
					""tag"": ""4.E.WS.204"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1952.9678 855.9727""
				},
				{
					""tag"": ""4.E.WS.232"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1875.0486 1107.2715""
				},
				{
					""tag"": ""4.E.WS.224"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1796.1262 1108.2717""
				},
				{
					""tag"": ""4.E.WS.225"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1875.0486 1108.2717""
				},
				{
					""tag"": ""4.E.WS.223"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1796.1262 1023.5052""
				},
				{
					""tag"": ""4.E.WS.222"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1875.0486 1023.5052""
				},
				{
					""tag"": ""4.E.WS.214"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1796.1262 1024.5055""
				},
				{
					""tag"": ""4.E.WS.215"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1875.0486 1024.5055""
				},
				{
					""tag"": ""4.E.WS.210"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1875.0486 939.739""
				},
				{
					""tag"": ""4.E.WS.206"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1875.0486 940.7393""
				},
				{
					""tag"": ""4.E.WS.201"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1796.1262 855.9727""
				},
				{
					""tag"": ""4.E.WS.202"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1875.0486 855.9727""
				},
				{
					""tag"": ""4.E.WS.229"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1951.9675 1107.2715""
				},
				{
					""tag"": ""4.E.WS.228"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1951.9675 1108.2717""
				},
				{
					""tag"": ""4.E.WS.219"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1951.9675 1023.5052""
				},
				{
					""tag"": ""4.E.WS.218"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1951.9675 1024.5055""
				},
				{
					""tag"": ""4.E.WS.213"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1951.9675 939.739""
				},
				{
					""tag"": ""4.E.WS.209"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1951.9675 940.7393""
				},
				{
					""tag"": ""4.E.WS.205"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1951.9675 855.9727""
				}
			]
		},
		""Section-10"": {
			""tag"": ""Section-10"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.W.WS.165"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1357.1163 207.7053""
				},
				{
					""tag"": ""4.W.WS.171"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1442.5153 207.7053""
				},
				{
					""tag"": ""4.W.WS.170"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1442.5153 286.6277""
				},
				{
					""tag"": ""4.W.WS.172"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1441.515 207.7053""
				},
				{
					""tag"": ""4.W.WS.173"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1441.515 286.6277""
				},
				{
					""tag"": ""4.W.WS.174"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1441.515 285.6274""
				},
				{
					""tag"": ""4.W.WS.175"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1441.515 364.5497""
				},
				{
					""tag"": ""4.W.WS.166"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1357.1163 363.5625""
				},
				{
					""tag"": ""4.W.WS.167"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1357.1163 442.4848""
				},
				{
					""tag"": ""4.W.WS.169"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1442.5153 363.5625""
				},
				{
					""tag"": ""4.W.WS.168"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1442.5153 442.4848""
				},
				{
					""tag"": ""4.W.WS.176"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1441.515 363.5625""
				},
				{
					""tag"": ""4.W.WS.177"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1441.515 442.4848""
				},
				{
					""tag"": ""4.W.WS.183"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1526.9305 207.7053""
				},
				{
					""tag"": ""4.W.WS.182"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1526.9305 286.6277""
				},
				{
					""tag"": ""4.W.WS.181"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1526.9305 285.6274""
				},
				{
					""tag"": ""4.W.WS.180"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1526.9305 364.5497""
				},
				{
					""tag"": ""4.W.WS.184"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1525.9303 207.7053""
				},
				{
					""tag"": ""4.W.WS.185"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1525.9303 286.6277""
				},
				{
					""tag"": ""4.W.WS.186"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1525.9303 285.6274""
				},
				{
					""tag"": ""4.W.WS.187"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1525.9303 364.5497""
				},
				{
					""tag"": ""4.W.WS.179"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1526.9305 363.5625""
				},
				{
					""tag"": ""4.W.WS.178"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1526.9305 442.4848""
				},
				{
					""tag"": ""4.W.WS.188"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1525.9303 363.5625""
				},
				{
					""tag"": ""4.W.WS.189"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1525.9303 442.4848""
				},
				{
					""tag"": ""4.W.WS.193"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1613.295 207.7053""
				},
				{
					""tag"": ""4.W.WS.192"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1613.295 364.5497""
				},
				{
					""tag"": ""4.W.WS.194"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1612.2947 207.7053""
				},
				{
					""tag"": ""4.W.WS.195"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1612.2947 286.6277""
				},
				{
					""tag"": ""4.W.WS.196"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1612.2947 285.6274""
				},
				{
					""tag"": ""4.W.WS.197"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1612.2947 364.5497""
				},
				{
					""tag"": ""4.W.WS.191"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1613.295 363.5625""
				},
				{
					""tag"": ""4.W.WS.190"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1613.295 442.4848""
				},
				{
					""tag"": ""4.W.WS.198"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1612.2947 363.5625""
				},
				{
					""tag"": ""4.W.WS.199"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1612.2947 442.4848""
				},
				{
					""tag"": ""4.W.WS.205"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1699.6553 207.7053""
				},
				{
					""tag"": ""4.W.WS.204"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1699.6553 286.6277""
				},
				{
					""tag"": ""4.W.WS.203"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1699.6553 285.6274""
				},
				{
					""tag"": ""4.W.WS.202"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1699.6553 364.5497""
				},
				{
					""tag"": ""4.W.WS.206"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1698.655 207.7053""
				},
				{
					""tag"": ""4.W.WS.207"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1698.655 286.6277""
				},
				{
					""tag"": ""4.W.WS.208"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1698.655 285.6274""
				},
				{
					""tag"": ""4.W.WS.209"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1698.655 364.5497""
				},
				{
					""tag"": ""4.W.WS.201"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1699.6553 363.5625""
				},
				{
					""tag"": ""4.W.WS.200"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1699.6553 442.4848""
				},
				{
					""tag"": ""4.W.WS.210"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1698.655 363.5625""
				},
				{
					""tag"": ""4.W.WS.211"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1698.655 442.4848""
				},
				{
					""tag"": ""4.W.WS.217"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1786.0277 207.7053""
				},
				{
					""tag"": ""4.W.WS.216"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1786.0277 286.6277""
				},
				{
					""tag"": ""4.W.WS.215"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1786.0277 285.6274""
				},
				{
					""tag"": ""4.W.WS.214"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1786.0277 364.5497""
				},
				{
					""tag"": ""4.W.WS.218"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1785.0275 207.7053""
				},
				{
					""tag"": ""4.W.WS.219"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1785.0275 364.5497""
				},
				{
					""tag"": ""4.W.WS.213"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1786.0277 363.5625""
				},
				{
					""tag"": ""4.W.WS.212"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1786.0277 442.4848""
				},
				{
					""tag"": ""4.W.WS.220"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1785.0275 363.5625""
				},
				{
					""tag"": ""4.W.WS.221"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1785.0275 442.4848""
				},
				{
					""tag"": ""4.W.WS.227"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1872.38 207.7053""
				},
				{
					""tag"": ""4.W.WS.226"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1872.38 286.6277""
				},
				{
					""tag"": ""4.W.WS.225"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1872.38 285.6274""
				},
				{
					""tag"": ""4.W.WS.224"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1872.38 364.5497""
				},
				{
					""tag"": ""4.W.WS.223"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1872.38 363.5625""
				},
				{
					""tag"": ""4.W.WS.222"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1872.38 442.4848""
				}
			]
		},
		""Section-11"": {
			""tag"": ""Section-11"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""4.W.WS.158"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1390.6707 143.1678""
				},
				{
					""tag"": ""4.W.WS.157"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 1437.9084 115.8971""
				},
				{
					""tag"": ""4.W.WS.156"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1437.9084 115.8971""
				},
				{
					""tag"": ""4.W.WS.155"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1437.9084 115.8971""
				},
				{
					""tag"": ""4.W.WS.154"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1390.6708 143.1702""
				},
				{
					""tag"": ""4.W.WS.153"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1390.6708 143.1702""
				},
				{
					""tag"": ""4.W.WS.164"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1567.4489 143.1678""
				},
				{
					""tag"": ""4.W.WS.160"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 1520.2112 115.8975""
				},
				{
					""tag"": ""4.W.WS.162"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1520.2112 115.8975""
				},
				{
					""tag"": ""4.W.WS.161"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1520.2112 115.8975""
				},
				{
					""tag"": ""4.W.WS.163"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1567.4489 143.1702""
				},
				{
					""tag"": ""4.W.WS.159"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1567.4489 143.1702""
				}
			]
		}
	}
}";
            migrationBuilder.InsertData(table: "MapConfiguration",
            columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
            values: new object[]
            {
                "1-1-5-12",
                pune4thFloorMap,
                "V1",
                "1",
                DateTime.Now
            });

            migrationBuilder.InsertData(table: "MapConfiguration",
            columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
            values: new object[]
            {
                "1-1-5-13",
                pune4thFloorMap,
                "V1",
                "1",
                DateTime.Now
            });

            migrationBuilder.InsertData(table: "MapConfiguration",
            columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
            values: new object[]
            {
                "1-1-5-14",
                pune4thFloorMap,
                "V1",
                "1",
                DateTime.Now
            });

            migrationBuilder.InsertData(table: "MapConfiguration",
            columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
            values: new object[]
            {
                "1-1-5-15",
                pune4thFloorMap,
                "V1",
                "1",
                DateTime.Now
            });

            // ------------------------
            // Pune 5th Floor Map
            // ------------------------

            string pune5thFloorMap = @"{
	""assets"":{
		""pic"":{
			""name"":""Pune 5th Floor Plan"",
			""ref"":""./assets/1-1-6-16.jpg""
		},
		""svg"":{
			""name"":""Pune 5th Floor Assets"",
			""ref"":""./assets/1-1-6-16.svg""
		}
	},
	""models"":{
		""Mod-1"":{
			""name"":""PTableL"",
			""template"":""t2""
		},
		""Mod-2"":{
			""name"":""PTable120"",
			""template"":""t2""
		},
		""Mod-3"":{
			""name"":""PTabelS"",
			""template"":""t2""
		}
	},
	""areas"":{
		""Area-1"":{ 
			""tag"":""MDF Room 1""			
		},
		""Area-2"":{
			""tag"":""Battery Room""	
		},
		""Area-3"":{
			""tag"":""Wet Pantry""	
		},
		""Area-4"":{
			""tag"":""Staircase""	
		},
		""Area-5"":{
			""tag"":""Handicap Washroom""	
		},
		""Area-6"":{
			""tag"":""Ladies Washroom""	
		},
		""Area-7"":{
			""tag"":""Gents Washroom""	
		},
		""Area-8"":{
			""tag"":""Phone Booth""	
		},
		""Area-9"":{
			""tag"":""Phone Booth""	
		},
		""Area-10"":{
			""tag"":""Meeting Room""	
		},
		""Area-11"":{
			""tag"":""Security Marshall""	
		},
		""Area-12"":{
			""tag"":""Meeting Room""	
		},
		""Area-13"":{
			""tag"":""Amphitheatre""	
		},
		""Area-14"":{
			""tag"":""Phone Booth""	
		},
		""Area-15"":{
			""tag"":""Phone Booth""	
		},
		""Area-16"":{
			""tag"":""Dry Pantry""	
		},
		""Area-17"":{
			""tag"":""Builder’s Pantry""	
		},
		""Area-18"":{
			""tag"":""Hub Room""	
		},
		""Area-19"":{
			""tag"":""Phone Booth""	
		},
		""Area-20"":{
			""tag"":""Mediascape""	
		},
		""Area-21"":{
			""tag"":""Collaboration Area""	
		},
		""Area-22"":{
			""tag"":""Meeting Room""	
		},
		""Area-23"":{
			""tag"":""Breakout""	
		},
		""Area-24"":{
			""tag"":""Collaboration Area""	
		},
		""Area-25"":{
			""tag"":""Managers Cabin 5.2""	
		},
		""Area-26"":{
			""tag"":""Collaboration Area""	
		},
		""Area-27"":{
			""tag"":""Staircase""	
		},
		""Area-28"":{
			""tag"":""Ladies Washroom""	
		},
		""Area-29"":{
			""tag"":""Gents Washroom""	
		},
		""Area-30"":{
			""tag"":""Shower Room""	
		},
		""Area-31"":{
			""tag"":""Phone Booth""	
		},
		""Area-32"":{
			""tag"":""Phone Booth""	
		},
		""Area-33"":{
			""tag"":""Meeting Room""	
		},
		""Area-34"":{
			""tag"":""Collaboration Area""	
		},
		""Area-35"":{
			""tag"":""Meeting Room""	
		},
		""Area-36"":{
			""tag"":""Meeting Room""	
		},
		""Area-37"":{
			""tag"":""Meeting Room""	
		},
		""Area-38"":{
			""tag"":""Hub Room""	
		},
		""Area-39"":{
			""tag"":""Collaboration Area""	
		},
		""Area-40"":{
			""tag"":""Managers Cabin 5.1""	
		},
		""Area-41"":{
			""tag"":""Collaboration Area""	
		},
		""Area-42"":{
			""tag"":""Breakout""	
		},
		""Area-43"":{
			""tag"":""Breakout""	
		},
		""Area-44"":{
			""tag"":""Managers Cabin 5.4""	
		},
		""Area-45"":{
			""tag"":""Collaboration Area""	
		},
		""Area-46"":{
			""tag"":""Lift Lobby""	
		},
		""Area-47"":{
			""tag"":""Lift Lobby""	
		}
	},
	""sections"":{
		""Section-1"":{
			""tag"":""Section-1"",
			""active"":""true"", 
				""units"":[					
					{""tag"":""5.W.WS.024"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 425.6628 260.5739""},
					{""tag"":""5.W.WS.023"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 425.6628 181.6516""},
					{""tag"":""5.W.WS.021"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 338.9286 260.5649""},
					{""tag"":""5.W.WS.022"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 338.9286 181.6426""},
					{""tag"":""5.W.WS.032"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 512.9556 260.5739""},
					{""tag"":""5.W.WS.031"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 512.9556 181.6516""},
					{""tag"":""5.W.WS.029"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 426.2214 260.5649""},
					{""tag"":""5.W.WS.030"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 426.2214 181.6426""},
					{""tag"":""5.W.WS.039"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 600.2484 260.5739""},
					{""tag"":""5.W.WS.038"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 600.2484 181.6516""},
					{""tag"":""5.W.WS.036"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 513.5142 260.5649""},
					{""tag"":""5.W.WS.037"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 513.5142 181.6426""},
					{""tag"":""5.W.WS.026"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 425.6628 340.0772""},
					{""tag"":""5.W.WS.025"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 425.6628 261.1548""},
					{""tag"":""5.W.WS.019"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 338.9286 340.0682""},
					{""tag"":""5.W.WS.020"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 338.9286 261.1459""},
					{""tag"":""5.W.WS.033"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 512.9556 340.0772""},
					{""tag"":""5.W.WS.027"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 426.2214 340.0682""},
					{""tag"":""5.W.WS.028"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 426.2214 261.1459""},
					{""tag"":""5.W.WS.041"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 600.2484 340.0772""},
					{""tag"":""5.W.WS.040"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 600.2484 261.1548""},
					{""tag"":""5.W.WS.034"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 513.5142 340.0682""},
					{""tag"":""5.W.WS.035"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 513.5142 261.1459""}	
			]
		},
		""Section-2"":{
			""tag"":""Section-2"",
			""active"":""true"", 
				""units"":[	
					{""tag"":""5.W.WS.018"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 523.6831 460.1168""},
					{""tag"":""5.W.WS.017"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 523.6831 381.1944""},
					{""tag"":""5.W.WS.015"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 435.4207 460.1078""},
					{""tag"":""5.W.WS.016"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 435.4207 381.1855""},
					{""tag"":""5.W.WS.013"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 434.855 460.1168""},
					{""tag"":""5.W.WS.012"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 434.855 381.1944""},
					{""tag"":""5.W.WS.010"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 346.5927 460.1078""},
					{""tag"":""5.W.WS.011"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 346.5927 381.1855""},
					{""tag"":""5.W.WS.014"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 434.855 460.6977""},
					{""tag"":""5.W.WS.009"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 346.5927 460.6888""},
					{""tag"":""5.W.WS.008"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 308.8828 460.1168""},
					{""tag"":""5.W.WS.007"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 308.8828 381.1944""},
					{""tag"":""5.W.WS.005"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 222.1521 460.1078""},
					{""tag"":""5.W.WS.006"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 222.1521 381.1855""},
					{""tag"":""5.W.WS.004"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 222.1521 460.6888""},
					{""tag"":""5.W.WS.002"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 221.5863 460.1168""},
					{""tag"":""5.W.WS.001"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 221.5863 381.1944""},
					{""tag"":""5.W.WS.003"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 221.5863 460.6977""}				
			]
		},
		""Section-3"":{
			""tag"":""Section-3"",
			""active"":""true"", 
				""units"":[						
					{""tag"":""5.W.WS.164"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1729.1914 165.8171""},
					{""tag"":""5.W.WS.165"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1650.269 165.8171""},
					{""tag"":""5.W.WS.157"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1729.1914 252.5514""},
					{""tag"":""5.W.WS.156"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1650.269 252.5514""},
					{""tag"":""5.W.WS.154"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1729.1914 253.1171""},
					{""tag"":""5.W.WS.155"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1650.269 253.1171""},
					{""tag"":""5.W.WS.148"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1729.1914 339.8406""},
					{""tag"":""5.W.WS.147"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1650.269 339.8406""},
					{""tag"":""5.W.WS.162"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1808.6992 165.8171""},
					{""tag"":""5.W.WS.163"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1729.7769 165.8171""},
					{""tag"":""5.W.WS.159"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1808.6992 252.5514""},
					{""tag"":""5.W.WS.158"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1729.7769 252.5514""},
					{""tag"":""5.W.WS.153"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1729.7769 253.1171""},
					{""tag"":""5.W.WS.150"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1808.6992 339.8406""},
					{""tag"":""5.W.WS.149"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1729.7769 339.8406""},
					{""tag"":""5.W.WS.161"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1809.2845 165.8171""},
					{""tag"":""5.W.WS.160"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1809.2845 252.5514""},
					{""tag"":""5.W.WS.152"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1809.2845 253.1171""},
					{""tag"":""5.W.WS.151"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1809.2845 339.8406""},
					{""tag"":""5.W.WS.113"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1264.6691 167.1155""},
					{""tag"":""5.W.WS.114"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1185.7467 167.1155""},
					{""tag"":""5.W.WS.111"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1344.1768 167.1155""},
					{""tag"":""5.W.WS.112"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1265.2544 167.1155""},
					{""tag"":""5.W.WS.109"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1423.6846 167.1155""},
					{""tag"":""5.W.WS.110"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1344.7622 167.1155""},
					{""tag"":""5.W.WS.104"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1264.6691 252.5472""},
					{""tag"":""5.W.WS.103"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1185.7467 252.5472""},
					{""tag"":""5.W.WS.074"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 785.3416 81.367""},
					{""tag"":""5.W.WS.075"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 706.4193 81.367""},
					{""tag"":""5.W.WS.065"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 785.3416 166.7987""},
					{""tag"":""5.W.WS.064"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 706.4193 166.7987""},
					{""tag"":""5.W.WS.072"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 864.8458 81.367""},
					{""tag"":""5.W.WS.073"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 785.9234 81.367""},
					{""tag"":""5.W.WS.067"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 864.8458 166.7987""},
					{""tag"":""5.W.WS.066"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 785.9234 166.7987""},
					{""tag"":""5.W.WS.070"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 944.35 81.367""},
					{""tag"":""5.W.WS.071"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 865.4276 81.367""},
					{""tag"":""5.W.WS.069"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 944.35 166.7987""},
					{""tag"":""5.W.WS.068"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 865.4276 166.7987""},
					{""tag"":""5.W.WS.062"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 785.3416 167.4322""},
					{""tag"":""5.W.WS.063"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 706.4193 167.4322""},
					{""tag"":""5.W.WS.053"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 785.3416 252.8639""},
					{""tag"":""5.W.WS.052"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 706.4193 252.8639""},
					{""tag"":""5.W.WS.060"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 864.8458 167.4322""},
					{""tag"":""5.W.WS.061"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 785.9234 167.4322""},
					{""tag"":""5.W.WS.055"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 864.8458 252.8639""},
					{""tag"":""5.W.WS.054"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 785.9234 252.8639""},
					{""tag"":""5.W.WS.058"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 944.35 167.4322""},
					{""tag"":""5.W.WS.059"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 865.4276 167.4322""},
					{""tag"":""5.W.WS.057"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 944.35 252.8639""},
					{""tag"":""5.W.WS.056"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 865.4276 252.8639""},
					{""tag"":""5.W.WS.051"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 785.3416 253.4975""},
					{""tag"":""5.W.WS.043"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 785.3416 340.0745""},
					{""tag"":""5.W.WS.042"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 706.4193 340.0745""},
					{""tag"":""5.W.WS.049"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 864.8458 253.4975""},
					{""tag"":""5.W.WS.050"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 785.9234 253.4975""},
					{""tag"":""5.W.WS.045"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 864.8458 340.0745""},
					{""tag"":""5.W.WS.044"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 785.9234 340.0745""},
					{""tag"":""5.W.WS.048"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 865.4276 253.4975""},
					{""tag"":""5.W.WS.047"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 944.35 340.0745""},
					{""tag"":""5.W.WS.046"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 865.4276 340.0745""},
					{""tag"":""5.W.WS.106"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1344.1768 252.5472""},
					{""tag"":""5.W.WS.105"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1265.2544 252.5472""},
					{""tag"":""5.W.WS.108"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1423.6846 252.5472""},
					{""tag"":""5.W.WS.107"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1344.7622 252.5472""},
					{""tag"":""5.W.WS.101"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1344.1768 253.1093""},
					{""tag"":""5.W.WS.102"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1265.2544 253.1093""},
					{""tag"":""5.W.WS.100"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1423.6846 253.1093""},
					{""tag"":""5.W.WS.099"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1344.1768 339.882""},
					{""tag"":""5.W.WS.098"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1265.2544 339.882""},
					{""tag"":""5.W.WS.116"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1264.6691 166.5534""},
					{""tag"":""5.W.WS.115"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1185.7467 166.5534""},
					{""tag"":""5.W.WS.118"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1344.1768 166.5534""},
					{""tag"":""5.W.WS.117"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1265.2544 166.5534""},
					{""tag"":""5.W.WS.120"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1423.6846 166.5534""},
					{""tag"":""5.W.WS.119"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1344.7622 166.5534""},
					{""tag"":""5.W.WS.083"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 0.5 0.5 -0.866 1009.5726 126.6388""},
					{""tag"":""5.W.WS.082"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""6.732051e-07 1 -1 6.732051e-07 1056.814 99.363""},
					{""tag"":""5.W.WS.081"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 0.5 0.5 0.866 1104.0626 126.6493""},
					{""tag"":""5.W.WS.080"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 0.5 0.5 -0.866 1105.6215 126.6483""},
					{""tag"":""5.W.WS.079"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""6.732051e-07 -1 -1 -6.732051e-07 1104.8322 125.2826""},
					{""tag"":""5.W.WS.076"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""6.732051e-07 -1 -1 -6.732051e-07 1008.7947 125.2826""},
					{""tag"":""5.W.WS.078"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 -0.5 0.5 0.866 1057.5944 98.008""},
					{""tag"":""5.W.WS.077"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 -0.5 0.5 -0.866 1056.0323 98.008""},
					{""tag"":""5.W.WS.088"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 -0.5 0.5 -0.866 1104.0547 202.0022""},
					{""tag"":""5.W.WS.087"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-6.732051e-07 -1 1 -6.732051e-07 1056.8132 229.2781""},
					{""tag"":""5.W.WS.086"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 -0.5 0.5 0.866 1009.5646 201.9918""},
					{""tag"":""5.W.WS.097"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-6.732051e-07 1 1 6.732051e-07 1008.7951 203.3585""},
					{""tag"":""5.W.WS.089"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 -0.5 0.5 0.866 1105.6215 202.0013""},
					{""tag"":""5.W.WS.090"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-6.732051e-07 1 1 6.732051e-07 1104.8325 203.3585""},
					{""tag"":""5.W.WS.096"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 0.5 0.5 0.866 1056.0328 230.6331""},
					{""tag"":""5.W.WS.084"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 0.5 0.5 0.866 1008.0065 126.6161""},
					{""tag"":""5.W.WS.095"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 -0.5 0.5 -0.866 1056.0328 285.1762""},
					{""tag"":""5.W.WS.085"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 -0.5 0.5 -0.866 1008.0065 201.9672""},
					{""tag"":""5.W.WS.094"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-6.732051e-07 -1 1 -6.732051e-07 1008.7951 312.4494""},
					{""tag"":""5.W.WS.093"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-6.732051e-07 -1 1 -6.732051e-07 1104.8326 312.4494""},
					{""tag"":""5.W.WS.092"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 -0.5 0.5 0.866 1057.595 285.1762""},
					{""tag"":""5.W.WS.091"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 0.5 0.5 -0.866 1057.595 230.6331""},
					{""tag"":""5.W.WS.129"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 0.5 0.5 -0.866 1488.8947 126.6388""},
					{""tag"":""5.W.WS.128"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""6.732051e-07 1 -1 6.732051e-07 1536.1361 99.363""},
					{""tag"":""5.W.WS.127"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 0.5 0.5 0.866 1583.3846 126.6493""},
					{""tag"":""5.W.WS.126"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 0.5 0.5 -0.866 1584.9436 126.6483""},
					{""tag"":""5.W.WS.125"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""6.732051e-07 -1 -1 -6.732051e-07 1584.1542 125.2826""},
					{""tag"":""5.W.WS.122"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""6.732051e-07 -1 -1 -6.732051e-07 1488.1168 125.2826""},
					{""tag"":""5.W.WS.124"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 -0.5 0.5 0.866 1536.9165 98.008""},
					{""tag"":""5.W.WS.123"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 -0.5 0.5 -0.866 1535.3544 98.008""},
					{""tag"":""5.W.WS.132"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 -0.5 0.5 -0.866 1583.3767 201.8074""},
					{""tag"":""5.W.WS.131"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-6.732051e-07 -1 1 -6.732051e-07 1536.1354 229.0832""},
					{""tag"":""5.W.WS.130"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 -0.5 0.5 0.866 1488.8867 201.7969""},
					{""tag"":""5.W.WS.145"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-6.732051e-07 1 1 6.732051e-07 1488.1172 203.1636""},
					{""tag"":""5.W.WS.133"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 -0.5 0.5 0.866 1584.9436 201.8064""},
					{""tag"":""5.W.WS.134"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-6.732051e-07 1 1 6.732051e-07 1584.1545 203.1636""},
					{""tag"":""5.W.WS.144"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 0.5 0.5 0.866 1535.355 230.4383""},
					{""tag"":""5.W.WS.121"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 0.5 0.5 0.866 1487.3286 126.6161""},
					{""tag"":""5.W.WS.140"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 0.5 0.5 -0.866 1488.8947 313.6293""},
					{""tag"":""5.W.WS.139"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""6.732051e-07 1 -1 6.732051e-07 1536.1361 286.3535""},
					{""tag"":""5.W.WS.138"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 0.5 0.5 0.866 1583.3846 313.6398""},
					{""tag"":""5.W.WS.137"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 0.5 0.5 -0.866 1584.9436 313.6387""},
					{""tag"":""5.W.WS.141"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 0.5 0.5 0.866 1487.3286 313.6066""},
					{""tag"":""5.W.WS.143"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 -0.5 0.5 -0.866 1535.355 284.9814""},
					{""tag"":""5.W.WS.146"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 -0.5 0.5 -0.866 1487.3286 201.7723""},
					{""tag"":""5.W.WS.142"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-6.732051e-07 -1 1 -6.732051e-07 1488.1172 312.2545""},
					{""tag"":""5.W.WS.136"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 -0.5 0.5 0.866 1536.917 284.9814""},
					{""tag"":""5.W.WS.135"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 0.5 0.5 -0.866 1536.917 230.4383""}
			]
		},
		""Section-4"":{
			""tag"":""Section-4"",
			""active"":""true"", 
				""units"":[
					{""tag"":""5.E.WS.158"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1944.3726 879.5052""},
					{""tag"":""5.E.WS.159"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1944.3726 966.2471""},
					{""tag"":""5.E.WS.167"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1944.3726 966.798""},
					{""tag"":""5.E.WS.168"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1944.3582 1053.5322""},
					{""tag"":""5.E.WS.177"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1944.3582 1054.0908""},
					{""tag"":""5.E.WS.178"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1944.3726 1140.8251""},
					{""tag"":""5.E.WS.157"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1943.7979 879.5052""},
					{""tag"":""5.E.WS.156"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1864.8755 879.5052""},
					{""tag"":""5.E.WS.160"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1943.7979 966.2471""},
					{""tag"":""5.E.WS.161"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1864.8755 966.2471""},
					{""tag"":""5.E.WS.166"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1943.7979 966.798""},
					{""tag"":""5.E.WS.165"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1864.8755 966.798""},
					{""tag"":""5.E.WS.169"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1943.7979 1053.536""},
					{""tag"":""5.E.WS.170"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1864.8612 1053.5322""},
					{""tag"":""5.E.WS.175"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1864.8612 1054.0908""},
					{""tag"":""5.E.WS.179"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1943.7979 1140.8251""},
					{""tag"":""5.E.WS.180"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1864.8755 1140.8251""},
					{""tag"":""5.E.WS.155"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1864.3009 879.5052""},
					{""tag"":""5.E.WS.154"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1785.3785 879.5052""},
					{""tag"":""5.E.WS.162"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1864.3009 966.2471""},
					{""tag"":""5.E.WS.164"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1864.3009 966.798""},
					{""tag"":""5.E.WS.176"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1943.7979 1054.0944""},
					{""tag"":""5.E.WS.174"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1864.3009 1054.0944""},
					{""tag"":""5.E.WS.163"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1785.3785 966.798""},
					{""tag"":""5.E.WS.171"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1864.3009 1053.536""},
					{""tag"":""5.E.WS.172"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1785.3641 1053.5322""},
					{""tag"":""5.E.WS.173"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1785.3641 1054.0908""},
					{""tag"":""5.E.WS.181"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1864.3009 1140.8251""},
					{""tag"":""5.E.WS.182"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1785.3785 1140.8251""}
			]
		},
		""Section-5"":{
			""tag"":""Section-5"",
			""active"":""true"", 
				""units"":[
					{""tag"":""5.E.WS.113"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1664.7717 879.5052""},
					{""tag"":""5.E.WS.112"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1585.8494 879.5052""},
					{""tag"":""5.E.WS.118"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1664.7717 966.2471""},
					{""tag"":""5.E.WS.127"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1664.7717 966.798""},
					{""tag"":""5.E.WS.126"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1585.8494 966.798""},
					{""tag"":""5.E.WS.132"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1664.7717 1053.536""},
					{""tag"":""5.E.WS.133"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1585.8351 1053.5322""},
					{""tag"":""5.E.WS.142"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1585.8351 1054.0908""},
					{""tag"":""5.E.WS.148"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1664.7717 1140.8251""},
					{""tag"":""5.E.WS.149"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1585.8494 1140.8251""},
					{""tag"":""5.E.WS.115"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1744.2769 879.5052""},
					{""tag"":""5.E.WS.114"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1665.3545 879.5052""},
					{""tag"":""5.E.WS.116"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1744.2769 966.2471""},
					{""tag"":""5.E.WS.117"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1665.3545 966.2471""},
					{""tag"":""5.E.WS.129"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1744.2769 966.798""},
					{""tag"":""5.E.WS.128"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1665.3545 966.798""},
					{""tag"":""5.E.WS.130"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1744.2769 1053.536""},
					{""tag"":""5.E.WS.131"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1665.3402 1053.5322""},
					{""tag"":""5.E.WS.144"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1665.3402 1054.0908""},
					{""tag"":""5.E.WS.146"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1744.2769 1140.8251""},
					{""tag"":""5.E.WS.147"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1665.3545 1140.8251""},
					{""tag"":""5.E.WS.111"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1585.2748 879.5052""},
					{""tag"":""5.E.WS.110"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1506.3524 879.5052""},
					{""tag"":""5.E.WS.119"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1506.3524 966.2471""},
					{""tag"":""5.E.WS.125"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1585.2748 966.798""},
					{""tag"":""5.E.WS.124"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1506.3524 966.798""},
					{""tag"":""5.E.WS.134"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1585.2748 1053.536""},
					{""tag"":""5.E.WS.135"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1506.3381 1053.5322""},
					{""tag"":""5.E.WS.140"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1506.3381 1054.0908""},
					{""tag"":""5.E.WS.150"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1585.2748 1140.8251""},
					{""tag"":""5.E.WS.151"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1506.3524 1140.8251""},
					{""tag"":""5.E.WS.109"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1505.7777 879.5052""},
					{""tag"":""5.E.WS.108"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1426.8553 879.5052""},
					{""tag"":""5.E.WS.120"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1505.7777 966.2471""},
					{""tag"":""5.E.WS.121"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1426.8553 966.2471""},
					{""tag"":""5.E.WS.123"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1505.7777 966.798""},
					{""tag"":""5.E.WS.139"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1505.7777 1054.0944""},
					{""tag"":""5.E.WS.141"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1585.2748 1054.0944""},
					{""tag"":""5.E.WS.143"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1664.7717 1054.0944""},
					{""tag"":""5.E.WS.145"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1744.2688 1054.0944""},
					{""tag"":""5.E.WS.122"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1426.8553 966.798""},
					{""tag"":""5.E.WS.136"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1505.7777 1053.536""},
					{""tag"":""5.E.WS.137"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1426.8411 1053.5322""},
					{""tag"":""5.E.WS.138"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1426.8411 1054.0908""},
					{""tag"":""5.E.WS.152"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1505.7777 1140.8251""},
					{""tag"":""5.E.WS.153"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1426.8553 1140.8251""}
			]
		},
		""Section-6"":{
			""tag"":""Section-6"",
			""active"":""true"", 
				""units"":[
					{""tag"":""5.E.WS.089"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1385.7501 879.5052""},
					{""tag"":""5.E.WS.088"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1306.8278 879.5052""},
					{""tag"":""5.E.WS.090"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1306.8278 979.3265""},
					{""tag"":""5.E.WS.087"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1306.2532 879.5052""},
					{""tag"":""5.E.WS.086"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1227.3308 879.5052""},
					{""tag"":""5.E.WS.091"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1306.2532 979.3265""},
					{""tag"":""5.E.WS.092"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1227.3308 979.3265""},
					{""tag"":""5.E.WS.085"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1226.7561 879.5052""},
					{""tag"":""5.E.WS.098"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1385.7501 979.9208""},
					{""tag"":""5.E.WS.097"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1306.8278 979.9208""},
					{""tag"":""5.E.WS.096"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1306.2532 979.9208""},
					{""tag"":""5.E.WS.095"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 1227.3308 979.9208""},
					{""tag"":""5.E.WS.094"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 1226.7561 979.9208""},
					{""tag"":""5.E.WS.093"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1226.7561 979.3265""},
					{""tag"":""5.E.WS.099"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1385.7501 1066.6493""},
					{""tag"":""5.E.WS.100"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1306.8278 1066.6493""},
					{""tag"":""5.E.WS.101"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1306.2532 1066.6493""},
					{""tag"":""5.E.WS.102"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 1227.3308 1066.6493""},
					{""tag"":""5.E.WS.103"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 1226.7561 1066.6493""}
			]
		},
		""Section-7"":{
			""tag"":""Section-7"",
			""active"":""true"", 
				""units"":[
					{""tag"":""5.E.WS.106"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 1385.7501 1202.3977""},
					{""tag"":""5.E.WS.107"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 1385.7501 1099.9583""},
					{""tag"":""5.E.WS.105"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 1294.1548 1202.3887""},
					{""tag"":""5.E.WS.104"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 1294.1548 1099.9493""}
			]
		},
		""Section-8"":{
			""tag"":""Section-8"",
			""active"":""true"", 
				""units"":[					
					{""tag"":""5.E.WS.031"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 944.35 877.1844""},
					{""tag"":""5.E.WS.030"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 865.4276 877.1844""},
					{""tag"":""5.E.WS.032"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 865.4276 963.9264""},
					{""tag"":""5.E.WS.040"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 944.35 964.4773""},
					{""tag"":""5.E.WS.039"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 865.4276 964.4773""},
					{""tag"":""5.E.WS.041"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 944.35 1051.2152""},
					{""tag"":""5.E.WS.042"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 865.4133 1051.2115""},
					{""tag"":""5.E.WS.051"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 865.4133 1051.77""},
					{""tag"":""5.E.WS.053"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 944.35 1138.5044""},
					{""tag"":""5.E.WS.054"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 865.4276 1138.5044""},
					{""tag"":""5.E.WS.029"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 864.853 877.1844""},
					{""tag"":""5.E.WS.028"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 785.9306 877.1844""},
					{""tag"":""5.E.WS.033"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 864.853 963.9264""},
					{""tag"":""5.E.WS.034"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 785.9306 963.9264""},
					{""tag"":""5.E.WS.038"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 864.853 964.4773""},
					{""tag"":""5.E.WS.050"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 864.853 1051.77""},
					{""tag"":""5.E.WS.052"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 944.35 1051.77""},
					{""tag"":""5.E.WS.037"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 785.9306 964.4773""},
					{""tag"":""5.E.WS.043"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 864.853 1051.2152""},
					{""tag"":""5.E.WS.044"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 785.9163 1051.2115""},
					{""tag"":""5.E.WS.049"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 785.9163 1051.77""},
					{""tag"":""5.E.WS.055"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 864.853 1138.5044""},
					{""tag"":""5.E.WS.056"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 785.9306 1138.5044""},
					{""tag"":""5.E.WS.036"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 785.356 964.4773""},
					{""tag"":""5.E.WS.048"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 1 0 785.356 1051.77""},
					{""tag"":""5.E.WS.035"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 706.4336 964.4773""},
					{""tag"":""5.E.WS.045"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 785.356 1051.2152""},
					{""tag"":""5.E.WS.046"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 706.4193 1051.2115""},
					{""tag"":""5.E.WS.047"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 1 -1 0 706.4193 1051.77""},
					{""tag"":""5.E.WS.057"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 1 0 785.356 1138.5044""},
					{""tag"":""5.E.WS.058"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""0 -1 -1 0 706.4336 1138.5044""},					
					{""tag"":""5.E.WS.068"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 0.5 0.5 -0.866 1009.5726 1014.9404""},
					{""tag"":""5.E.WS.067"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""6.732051e-07 1 -1 6.732051e-07 1056.814 987.6646""},
					{""tag"":""5.E.WS.066"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 0.5 0.5 0.866 1104.0626 1014.9509""},
					{""tag"":""5.E.WS.065"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 0.5 0.5 -0.866 1105.6215 1014.9498""},
					{""tag"":""5.E.WS.064"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""6.732051e-07 -1 -1 -6.732051e-07 1104.8322 1013.5841""},
					{""tag"":""5.E.WS.069"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 0.5 0.5 0.866 1008.0058 1014.9413""},
					{""tag"":""5.E.WS.070"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""6.732051e-07 -1 -1 -6.732051e-07 1008.7947 1013.5841""},
					{""tag"":""5.E.WS.063"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 -0.5 0.5 0.866 1057.5944 986.3095""},
					{""tag"":""5.E.WS.061"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 0.5 0.5 -0.866 1057.5944 931.7664""},
					{""tag"":""5.E.WS.062"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""6.732051e-07 1 -1 6.732051e-07 1104.8322 904.4932""},
					{""tag"":""5.E.WS.059"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""6.732051e-07 1 -1 6.732051e-07 1008.7946 904.4932""},
					{""tag"":""5.E.WS.060"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 0.5 0.5 0.866 1056.0323 931.7664""},
					{""tag"":""5.E.WS.071"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 -0.5 0.5 -0.866 1056.0323 986.3095""},
					{""tag"":""5.E.WS.075"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 -0.5 0.5 -0.866 1104.0547 1090.3037""},
					{""tag"":""5.E.WS.074"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-6.732051e-07 -1 1 -6.732051e-07 1056.8132 1117.5796""},
					{""tag"":""5.E.WS.073"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 -0.5 0.5 0.866 1009.5646 1090.2933""},
					{""tag"":""5.E.WS.072"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 -0.5 0.5 -0.866 1008.0058 1090.2943""},
					{""tag"":""5.E.WS.084"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-6.732051e-07 1 1 6.732051e-07 1008.7951 1091.66""},
					{""tag"":""5.E.WS.076"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 -0.5 0.5 0.866 1105.6215 1090.3029""},
					{""tag"":""5.E.WS.077"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-6.732051e-07 1 1 6.732051e-07 1104.8325 1091.66""},
					{""tag"":""5.E.WS.083"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 0.5 0.5 0.866 1056.0328 1118.9347""},
					{""tag"":""5.E.WS.082"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-0.866 -0.5 0.5 -0.866 1056.0328 1173.4778""},
					{""tag"":""5.E.WS.081"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-6.732051e-07 -1 1 -6.732051e-07 1008.7951 1200.751""},
					{""tag"":""5.E.WS.080"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""-6.732051e-07 -1 1 -6.732051e-07 1104.8326 1200.751""},
					{""tag"":""5.E.WS.079"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 -0.5 0.5 0.866 1057.595 1173.4778""},
					{""tag"":""5.E.WS.078"", ""active"":""true"", ""ref"":""Mod-3"", ""transform"":""0.866 0.5 0.5 -0.866 1057.595 1118.9347""}
			]
		},
		""Section-9"":{
			""tag"":""Section-9"",
			""active"":""true"", 
				""units"":[					
					{""tag"":""5.E.WS.010"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 421.3046 955.8124""},
					{""tag"":""5.E.WS.009"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 421.3046 876.8901""},
					{""tag"":""5.E.WS.007"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 334.5703 955.8035""},
					{""tag"":""5.E.WS.008"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 334.5703 876.8811""},
					{""tag"":""5.E.WS.017"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 508.5974 876.8901""},
					{""tag"":""5.E.WS.015"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 421.8631 955.8035""},
					{""tag"":""5.E.WS.016"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 421.8631 876.8811""},
					{""tag"":""5.E.WS.025"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 595.8901 955.8124""},
					{""tag"":""5.E.WS.024"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 595.8901 876.8901""},
					{""tag"":""5.E.WS.022"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 509.1559 955.8035""},
					{""tag"":""5.E.WS.023"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 509.1559 876.8811""},
					{""tag"":""5.E.WS.012"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 421.3046 1035.3068""},
					{""tag"":""5.E.WS.011"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 421.3046 956.3934""},
					{""tag"":""5.E.WS.002"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 334.0082 955.8124""},
					{""tag"":""5.E.WS.001"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 334.0082 876.8901""},
					{""tag"":""5.E.WS.004"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 334.0082 1035.3068""},
					{""tag"":""5.E.WS.003"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 334.0082 956.3934""},
					{""tag"":""5.E.WS.005"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 334.5703 1035.3068""},
					{""tag"":""5.E.WS.006"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 334.5703 956.3844""},
					{""tag"":""5.E.WS.019"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 508.5974 1035.3068""},
					{""tag"":""5.E.WS.018"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 508.5974 956.3934""},
					{""tag"":""5.E.WS.013"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 421.8631 1035.3068""},
					{""tag"":""5.E.WS.014"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 421.8631 956.3844""},
					{""tag"":""5.E.WS.027"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 1 595.8901 1035.3068""},
					{""tag"":""5.E.WS.026"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""-1 0 0 -1 595.8901 956.3934""},
					{""tag"":""5.E.WS.020"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 1 509.1559 1035.3068""},
					{""tag"":""5.E.WS.021"", ""active"":""true"", ""ref"":""Mod-1"", ""transform"":""1 0 0 -1 509.1559 956.3844""}
			]
		}
	}
}";
            migrationBuilder.InsertData(table: "MapConfiguration",
            columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
            values: new object[]
            {
                "1-1-6-16",
                pune5thFloorMap,
                "V1",
                "1",
                DateTime.Now
            });

            migrationBuilder.InsertData(table: "MapConfiguration",
            columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
            values: new object[]
            {
                "1-1-6-17",
                pune5thFloorMap,
                "V1",
                "1",
                DateTime.Now
            });

            migrationBuilder.InsertData(table: "MapConfiguration",
            columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
            values: new object[]
            {
                "1-1-6-18",
                pune5thFloorMap,
                "V1",
                "1",
                DateTime.Now
            });

            migrationBuilder.InsertData(table: "MapConfiguration",
            columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
            values: new object[]
            {
                "1-1-6-19",
                pune5thFloorMap,
                "V1",
                "1",
                DateTime.Now
            });

            // ------------------------
            // Pune 6th Floor Map :: Last Updated - 20122021
            // ------------------------

            string pune6thFloorMap = @"{
	""assets"": {
		""pic"": {
			""name"": ""Pune 6th Floor Plan"",
			""ref"": ""./assets/1-1-7-2.jpg""
		},
		""svg"": {
			""name"": ""Pune 6th Floor Assets"",
			""ref"": ""./assets/1-1-7-2.svg""
		}
	},
	""models"": {
		""Mod-1"": {
			""name"": ""PTableL"",
			""template"": ""t2""
		},
		""Mod-2"": {
			""name"": ""PTable120"",
			""template"": ""t2""
		},
		""Mod-3"": {
			""name"": ""PTabelS"",
			""template"": ""t2""
		}
	},
	""areas"": {
		""Area-1"": {
			""tag"": ""Collaboration Area""
		},
		""Area-2"": {
			""tag"": ""Managers Cabin 6.1""
		},
		""Area-3"": {
			""tag"": ""Collaboration Area""
		},
		""Area-4"": {
			""tag"": ""Phone Booth""
		},
		""Area-5"": {
			""tag"": ""Phone Booth""
		},
		""Area-6"": {
			""tag"": ""Meeting Room""
		},
		""Area-7"": {
			""tag"": ""Meeting Room""
		},
		""Area-8"": {
			""tag"": ""Meeting Room""
		},
		""Area-9"": {
			""tag"": ""Meeting Room""
		},
		""Area-10"": {
			""tag"": ""Hub Room""
		},
		""Area-11"": {
			""tag"": ""Dry Pantry""
		},
		""Area-12"": {
			""tag"": ""Builder’s Pantry""
		},
		""Area-13"": {
			""tag"": ""Staircase""
		},
		""Area-14"": {
			""tag"": ""Breakout""
		},
		""Area-15"": {
			""tag"": ""Phone Booth""
		},
		""Area-16"": {
			""tag"": ""Phone Booth""
		},
		""Area-17"": {
			""tag"": ""Meeting Room""
		},
		""Area-18"": {
			""tag"": ""Collaboration Area""
		},
		""Area-19"": {
			""tag"": ""Meeting Room""
		},
		""Area-20"": {
			""tag"": ""Meeting Room""
		},
		""Area-21"": {
			""tag"": ""Meeting Room""
		},
		""Area-22"": {
			""tag"": ""Meeting Room""
		},
		""Area-23"": {
			""tag"": ""Hub Room""
		},
		""Area-24"": {
			""tag"": ""Collaboration Area""
		},
		""Area-25"": {
			""tag"": ""Managers Cabin 6.4""
		},
		""Area-26"": {
			""tag"": ""Collaboration Area""
		},
		""Area-27"": {
			""tag"": ""Battery Room""
		},
		""Area-28"": {
			""tag"": ""UPS Room""
		},
		""Area-29"": {
			""tag"": ""IT Store""
		},
		""Area-30"": {
			""tag"": ""Wet Pantry""
		},
		""Area-31"": {
			""tag"": ""Electrical Room""
		},
		""Area-32"": {
			""tag"": ""Staircase""
		},
		""Area-33"": {
			""tag"": ""Gents Washroom""
		},
		""Area-34"": {
			""tag"": ""Ladies Washroom""
		},
		""Area-35"": {
			""tag"": ""Handicap Washroom""
		},
		""Area-36"": {
			""tag"": ""Lift Lobby""
		},
		""Area-37"": {
			""tag"": ""Lift Lobby""
		},
		""Area-38"": {
			""tag"": ""Security Marshall""
		},
		""Area-39"": {
			""tag"": ""Meeting Room""
		},
		""Area-40"": {
			""tag"": ""Amphitheatre""
		},
		""Area-41"": {
			""tag"": ""Phone Booth""
		},
		""Area-42"": {
			""tag"": ""Phone Booth""
		},
		""Area-43"": {
			""tag"": ""Ladies Washroom""
		},
		""Area-44"": {
			""tag"": ""Gents Washroom""
		},
		""Area-45"": {
			""tag"": ""Shower Room""
		},
		""Area-46"": {
			""tag"": ""Mediascape""
		},
		""Area-47"": {
			""tag"": ""Managers Cabin 6.3""
		},
		""Area-48"": {
			""tag"": ""Managers Cabin 6.2""
		},
		""Area-49"": {
			""tag"": ""Collaboration Area""
		},
		""Area-50"": {
			""tag"": ""Meeting Room""
		},
		""Area-51"": {
			""tag"": ""Phone Booth""
		},
		""Area-52"": {
			""tag"": ""Phone Booth""
		}
	},
	""sections"": {
		""Section-1"": {
			""tag"": ""Section-1"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""6.W.WS.007"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 269.7789 259.9831""
				},
				{
					""tag"": ""6.W.WS.008"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 269.7789 181.0608""
				},
				{
					""tag"": ""6.W.WS.002"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 183.0446 259.9742""
				},
				{
					""tag"": ""6.W.WS.001"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 183.0446 181.0518""
				},
				{
					""tag"": ""6.W.WS.014"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 357.0717 259.9831""
				},
				{
					""tag"": ""6.W.WS.015"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 357.0717 181.0608""
				},
				{
					""tag"": ""6.W.WS.010"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 270.3374 259.9742""
				},
				{
					""tag"": ""6.W.WS.009"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 270.3374 181.0518""
				},
				{
					""tag"": ""6.W.WS.022"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 444.3645 259.9831""
				},
				{
					""tag"": ""6.W.WS.023"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 444.3645 181.0608""
				},
				{
					""tag"": ""6.W.WS.017"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 357.6302 259.9742""
				},
				{
					""tag"": ""6.W.WS.016"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 357.6302 181.0518""
				},
				{
					""tag"": ""6.W.WS.005"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 269.7789 339.4864""
				},
				{
					""tag"": ""6.W.WS.006"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 269.7789 260.5641""
				},
				{
					""tag"": ""6.W.WS.004"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 183.0446 339.4774""
				},
				{
					""tag"": ""6.W.WS.003"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 183.0446 260.5551""
				},
				{
					""tag"": ""6.W.WS.013"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 357.0717 339.4864""
				},
				{
					""tag"": ""6.W.WS.012"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 270.3374 339.4774""
				},
				{
					""tag"": ""6.W.WS.011"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 270.3374 260.5551""
				},
				{
					""tag"": ""6.W.WS.020"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 444.3645 339.4864""
				},
				{
					""tag"": ""6.W.WS.021"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 444.3645 260.5641""
				},
				{
					""tag"": ""6.W.WS.019"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 357.6302 339.4774""
				},
				{
					""tag"": ""6.W.WS.018"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 357.6302 260.5551""
				}
			]
		},
		""Section-2"": {
			""tag"": ""Section-2"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""6.W.WS.047"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 629.4544 164.9166""
				},
				{
					""tag"": ""6.W.WS.046"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 550.532 164.9166""
				},
				{
					""tag"": ""6.W.WS.049"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 708.9586 164.9166""
				},
				{
					""tag"": ""6.W.WS.048"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 630.0363 164.9166""
				},
				{
					""tag"": ""6.W.WS.051"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 788.4628 164.9166""
				},
				{
					""tag"": ""6.W.WS.050"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 709.5404 164.9166""
				},
				{
					""tag"": ""6.W.WS.044"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 629.4544 165.5502""
				},
				{
					""tag"": ""6.W.WS.045"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 550.532 165.5502""
				},
				{
					""tag"": ""6.W.WS.035"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 629.4544 250.9819""
				},
				{
					""tag"": ""6.W.WS.034"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 550.532 250.9819""
				},
				{
					""tag"": ""6.W.WS.042"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 708.9586 165.5502""
				},
				{
					""tag"": ""6.W.WS.043"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 630.0363 165.5502""
				},
				{
					""tag"": ""6.W.WS.037"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 708.9586 250.9819""
				},
				{
					""tag"": ""6.W.WS.036"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 630.0363 250.9819""
				},
				{
					""tag"": ""6.W.WS.040"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 788.4628 165.5502""
				},
				{
					""tag"": ""6.W.WS.041"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 709.5404 165.5502""
				},
				{
					""tag"": ""6.W.WS.039"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 788.4628 250.9819""
				},
				{
					""tag"": ""6.W.WS.038"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 709.5404 250.9819""
				},
				{
					""tag"": ""6.W.WS.033"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 629.4544 251.6154""
				},
				{
					""tag"": ""6.W.WS.025"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 629.4544 338.1924""
				},
				{
					""tag"": ""6.W.WS.024"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 550.532 338.1924""
				},
				{
					""tag"": ""6.W.WS.031"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 708.9586 251.6154""
				},
				{
					""tag"": ""6.W.WS.032"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 630.0363 251.6154""
				},
				{
					""tag"": ""6.W.WS.027"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 708.9586 338.1924""
				},
				{
					""tag"": ""6.W.WS.026"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 630.0363 338.1924""
				},
				{
					""tag"": ""6.W.WS.030"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 709.5404 251.6154""
				},
				{
					""tag"": ""6.W.WS.029"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 788.4628 338.1924""
				},
				{
					""tag"": ""6.W.WS.028"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 709.5404 338.1924""
				}
			]
		},
		""Section-3"": {
			""tag"": ""Section-3"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""6.W.WS.060"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 853.6854 126.1131""
				},
				{
					""tag"": ""6.W.WS.059"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 900.9268 98.8372""
				},
				{
					""tag"": ""6.W.WS.058"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 948.1754 126.1235""
				},
				{
					""tag"": ""6.W.WS.057"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 949.7343 126.1225""
				},
				{
					""tag"": ""6.W.WS.056"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 948.9449 124.7568""
				},
				{
					""tag"": ""6.W.WS.053"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 852.9076 124.7568""
				},
				{
					""tag"": ""6.W.WS.055"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 901.7072 97.4822""
				},
				{
					""tag"": ""6.W.WS.054"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 900.1451 97.4822""
				},
				{
					""tag"": ""6.W.WS.063"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 948.1674 201.4764""
				},
				{
					""tag"": ""6.W.WS.062"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 900.9261 228.7523""
				},
				{
					""tag"": ""6.W.WS.061"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 853.6774 201.466""
				},
				{
					""tag"": ""6.W.WS.072"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 852.9079 202.8327""
				},
				{
					""tag"": ""6.W.WS.064"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 949.7343 201.4755""
				},
				{
					""tag"": ""6.W.WS.065"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 948.9453 202.8327""
				},
				{
					""tag"": ""6.W.WS.071"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 900.1457 230.1073""
				},
				{
					""tag"": ""6.W.WS.052"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 852.1193 126.0903""
				},
				{
					""tag"": ""6.W.WS.070"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 900.1457 284.6505""
				},
				{
					""tag"": ""6.W.WS.073"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 852.1193 201.4414""
				},
				{
					""tag"": ""6.W.WS.069"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 852.9079 311.9236""
				},
				{
					""tag"": ""6.W.WS.068"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 948.9455 311.9236""
				},
				{
					""tag"": ""6.W.WS.067"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 901.7077 284.6505""
				},
				{
					""tag"": ""6.W.WS.066"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 901.7077 230.1073""
				}
			]
		},
		""Section-4"": {
			""tag"": ""Section-4"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""6.W.WS.075"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1108.7819 165.2335""
				},
				{
					""tag"": ""6.W.WS.074"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1029.8595 165.2335""
				},
				{
					""tag"": ""6.W.WS.077"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1188.2896 165.2335""
				},
				{
					""tag"": ""6.W.WS.076"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1109.3672 165.2335""
				},
				{
					""tag"": ""6.W.WS.079"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1267.7974 165.2335""
				},
				{
					""tag"": ""6.W.WS.078"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1188.875 165.2335""
				},
				{
					""tag"": ""6.W.WS.084"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1108.7819 250.6652""
				},
				{
					""tag"": ""6.W.WS.085"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1029.8595 250.6652""
				},
				{
					""tag"": ""6.W.WS.082"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1188.2896 250.6652""
				},
				{
					""tag"": ""6.W.WS.083"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1109.3672 250.6652""
				},
				{
					""tag"": ""6.W.WS.080"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1267.7974 250.6652""
				},
				{
					""tag"": ""6.W.WS.081"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1188.875 250.6652""
				},
				{
					""tag"": ""6.W.WS.087"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1188.2896 251.2273""
				},
				{
					""tag"": ""6.W.WS.086"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1109.3672 251.2273""
				},
				{
					""tag"": ""6.W.WS.088"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1267.7974 251.2273""
				},
				{
					""tag"": ""6.W.WS.090"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1188.2896 337.9999""
				},
				{
					""tag"": ""6.W.WS.089"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1109.3672 337.9999""
				}
			]
		},
		""Section-5"": {
			""tag"": ""Section-5"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""6.W.WS.116"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1333.0074 126.1093""
				},
				{
					""tag"": ""6.W.WS.115"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 1380.2489 98.8335""
				},
				{
					""tag"": ""6.W.WS.114"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1427.4976 126.1198""
				},
				{
					""tag"": ""6.W.WS.113"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1429.0564 126.1188""
				},
				{
					""tag"": ""6.W.WS.112"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1428.267 124.7531""
				},
				{
					""tag"": ""6.W.WS.109"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1332.2296 124.7531""
				},
				{
					""tag"": ""6.W.WS.111"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1381.0293 97.4784""
				},
				{
					""tag"": ""6.W.WS.110"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1379.4672 97.4784""
				},
				{
					""tag"": ""6.W.WS.099"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1427.4895 201.2779""
				},
				{
					""tag"": ""6.W.WS.098"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1380.2482 228.5537""
				},
				{
					""tag"": ""6.W.WS.097"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1332.9995 201.2674""
				},
				{
					""tag"": ""6.W.WS.095"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1332.23 202.6341""
				},
				{
					""tag"": ""6.W.WS.100"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1429.0564 201.2769""
				},
				{
					""tag"": ""6.W.WS.101"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1428.2673 202.6341""
				},
				{
					""tag"": ""6.W.WS.094"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1379.4678 229.9088""
				},
				{
					""tag"": ""6.W.WS.108"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1331.4414 126.0866""
				},
				{
					""tag"": ""6.W.WS.107"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1333.0074 313.0998""
				},
				{
					""tag"": ""6.W.WS.106"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 1380.2489 285.8239""
				},
				{
					""tag"": ""6.W.WS.105"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1427.4976 313.1103""
				},
				{
					""tag"": ""6.W.WS.104"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1429.0564 313.1092""
				},
				{
					""tag"": ""6.W.WS.091"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1331.4414 313.0771""
				},
				{
					""tag"": ""6.W.WS.093"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1379.4678 284.4519""
				},
				{
					""tag"": ""6.W.WS.096"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1331.4414 201.2428""
				},
				{
					""tag"": ""6.W.WS.092"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1332.23 311.725""
				},
				{
					""tag"": ""6.W.WS.103"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1381.0298 284.4519""
				},
				{
					""tag"": ""6.W.WS.102"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1381.0298 229.9088""
				}
			]
		},
		""Section-6"": {
			""tag"": ""Section-6"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""6.W.WS.118"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1573.3042 163.935""
				},
				{
					""tag"": ""6.W.WS.117"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1494.3818 163.935""
				},
				{
					""tag"": ""6.W.WS.125"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1573.3042 250.6693""
				},
				{
					""tag"": ""6.W.WS.126"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1494.3818 250.6693""
				},
				{
					""tag"": ""6.W.WS.128"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1573.3042 251.235""
				},
				{
					""tag"": ""6.W.WS.127"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1494.3818 251.235""
				},
				{
					""tag"": ""6.W.WS.134"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1573.3042 337.9585""
				},
				{
					""tag"": ""6.W.WS.135"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1494.3818 337.9585""
				},
				{
					""tag"": ""6.W.WS.120"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1652.812 163.935""
				},
				{
					""tag"": ""6.W.WS.119"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1573.8896 163.935""
				},
				{
					""tag"": ""6.W.WS.123"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1652.812 250.6693""
				},
				{
					""tag"": ""6.W.WS.124"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1573.8896 250.6693""
				},
				{
					""tag"": ""6.W.WS.129"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1573.8896 251.235""
				},
				{
					""tag"": ""6.W.WS.132"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1652.812 337.9585""
				},
				{
					""tag"": ""6.W.WS.133"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1573.8896 337.9585""
				},
				{
					""tag"": ""6.W.WS.121"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1653.3975 163.935""
				},
				{
					""tag"": ""6.W.WS.122"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1653.3975 250.6693""
				},
				{
					""tag"": ""6.W.WS.130"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1653.3975 251.235""
				},
				{
					""tag"": ""6.W.WS.131"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1653.3975 337.9585""
				}
			]
		},
		""Section-7"": {
			""tag"": ""Section-7"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""6.E.WS.180"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1741.5363 876.6049""
				},
				{
					""tag"": ""6.E.WS.179"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1662.6139 876.6049""
				},
				{
					""tag"": ""6.E.WS.170"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1741.5363 963.3468""
				},
				{
					""tag"": ""6.E.WS.165"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1741.5363 963.8977""
				},
				{
					""tag"": ""6.E.WS.164"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1662.6139 963.8977""
				},
				{
					""tag"": ""6.E.WS.154"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1741.5363 1050.6357""
				},
				{
					""tag"": ""6.E.WS.155"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1662.5996 1050.632""
				},
				{
					""tag"": ""6.E.WS.171"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1662.5996 963.3468""
				},
				{
					""tag"": ""6.E.WS.148"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1662.5996 1051.1906""
				},
				{
					""tag"": ""6.E.WS.182"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1821.0414 876.6049""
				},
				{
					""tag"": ""6.E.WS.181"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1742.119 876.6049""
				},
				{
					""tag"": ""6.E.WS.168"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1821.0414 963.3468""
				},
				{
					""tag"": ""6.E.WS.169"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1742.119 963.3468""
				},
				{
					""tag"": ""6.E.WS.167"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1821.0414 963.8977""
				},
				{
					""tag"": ""6.E.WS.166"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1742.119 963.8977""
				},
				{
					""tag"": ""6.E.WS.152"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1821.0414 1050.6357""
				},
				{
					""tag"": ""6.E.WS.153"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1742.1046 1050.632""
				},
				{
					""tag"": ""6.E.WS.150"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1742.1046 1051.1906""
				},
				{
					""tag"": ""6.E.WS.178"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1662.0393 876.6049""
				},
				{
					""tag"": ""6.E.WS.177"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1583.1169 876.6049""
				},
				{
					""tag"": ""6.E.WS.172"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1583.1169 963.3468""
				},
				{
					""tag"": ""6.E.WS.163"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1662.0393 963.8977""
				},
				{
					""tag"": ""6.E.WS.162"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1583.1169 963.8977""
				},
				{
					""tag"": ""6.E.WS.156"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1662.0393 1050.6357""
				},
				{
					""tag"": ""6.E.WS.157"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1583.1025 1050.632""
				},
				{
					""tag"": ""6.E.WS.176"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1582.5422 876.6049""
				},
				{
					""tag"": ""6.E.WS.175"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1503.6199 876.6049""
				},
				{
					""tag"": ""6.E.WS.173"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1582.5422 963.3468""
				},
				{
					""tag"": ""6.E.WS.174"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1503.6199 963.3468""
				},
				{
					""tag"": ""6.E.WS.161"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1582.5422 963.8977""
				},
				{
					""tag"": ""6.E.WS.147"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1662.0393 1051.1941""
				},
				{
					""tag"": ""6.E.WS.149"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1741.5363 1051.1941""
				},
				{
					""tag"": ""6.E.WS.151"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1821.0333 1051.1941""
				},
				{
					""tag"": ""6.E.WS.160"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1503.6199 963.8977""
				},
				{
					""tag"": ""6.E.WS.158"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1582.5422 1050.6357""
				},
				{
					""tag"": ""6.E.WS.159"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1503.6056 1050.632""
				}
			]
		},
		""Section-8"": {
			""tag"": ""Section-8"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""6.E.WS.146"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1343.9036 1014.6292""
				},
				{
					""tag"": ""6.E.WS.145"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 1391.145 987.3533""
				},
				{
					""tag"": ""6.E.WS.144"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1438.3936 1014.6396""
				},
				{
					""tag"": ""6.E.WS.143"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1439.9525 1014.6385""
				},
				{
					""tag"": ""6.E.WS.142"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1439.1631 1013.2729""
				},
				{
					""tag"": ""6.E.WS.131"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1342.3368 1014.6301""
				},
				{
					""tag"": ""6.E.WS.132"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1343.1257 1013.2729""
				},
				{
					""tag"": ""6.E.WS.141"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1391.9254 985.9982""
				},
				{
					""tag"": ""6.E.WS.135"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 1343.1256 904.1819""
				},
				{
					""tag"": ""6.E.WS.134"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1390.3633 931.4551""
				},
				{
					""tag"": ""6.E.WS.133"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1390.3633 985.9982""
				},
				{
					""tag"": ""6.E.WS.126"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1438.3856 1089.9926""
				},
				{
					""tag"": ""6.E.WS.125"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1391.1443 1117.2683""
				},
				{
					""tag"": ""6.E.WS.124"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1343.8956 1089.9821""
				},
				{
					""tag"": ""6.E.WS.123"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1342.3368 1089.9832""
				},
				{
					""tag"": ""6.E.WS.122"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1343.1261 1091.3488""
				},
				{
					""tag"": ""6.E.WS.127"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1439.9525 1089.9916""
				},
				{
					""tag"": ""6.E.WS.139"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1438.3856 902.8288""
				},
				{
					""tag"": ""6.E.WS.138"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1391.1443 930.1047""
				},
				{
					""tag"": ""6.E.WS.137"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1343.8956 902.8184""
				},
				{
					""tag"": ""6.E.WS.136"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1342.3368 902.8194""
				},
				{
					""tag"": ""6.E.WS.140"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1439.9525 902.8279""
				},
				{
					""tag"": ""6.E.WS.128"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1439.1635 1091.3488""
				},
				{
					""tag"": ""6.E.WS.121"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1390.3639 1118.6234""
				},
				{
					""tag"": ""6.E.WS.120"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1390.3639 1173.1665""
				},
				{
					""tag"": ""6.E.WS.119"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1343.1261 1200.4397""
				},
				{
					""tag"": ""6.E.WS.130"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1439.1637 1200.4397""
				},
				{
					""tag"": ""6.E.WS.129"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1391.9259 1118.6234""
				}
			]
		},
		""Section-9"": {
			""tag"": ""Section-9"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""6.E.WS.091"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1278.6809 876.8732""
				},
				{
					""tag"": ""6.E.WS.090"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1199.7587 876.8732""
				},
				{
					""tag"": ""6.E.WS.100"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1278.6809 964.166""
				},
				{
					""tag"": ""6.E.WS.099"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1199.7587 964.166""
				},
				{
					""tag"": ""6.E.WS.101"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1278.6809 1050.9041""
				},
				{
					""tag"": ""6.E.WS.092"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1278.6809 963.6152""
				},
				{
					""tag"": ""6.E.WS.102"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1199.7443 1050.9003""
				},
				{
					""tag"": ""6.E.WS.111"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1199.7443 1051.4589""
				},
				{
					""tag"": ""6.E.WS.113"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1278.6809 1138.1931""
				},
				{
					""tag"": ""6.E.WS.114"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1199.7587 1138.1931""
				},
				{
					""tag"": ""6.E.WS.089"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1199.184 876.8732""
				},
				{
					""tag"": ""6.E.WS.087"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1120.2616 876.8732""
				},
				{
					""tag"": ""6.E.WS.093"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1199.184 963.6152""
				},
				{
					""tag"": ""6.E.WS.094"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1120.2616 963.6152""
				},
				{
					""tag"": ""6.E.WS.098"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1199.184 964.166""
				},
				{
					""tag"": ""6.E.WS.110"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1199.184 1051.4589""
				},
				{
					""tag"": ""6.E.WS.112"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1278.6809 1051.4589""
				},
				{
					""tag"": ""6.E.WS.097"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1120.2616 964.166""
				},
				{
					""tag"": ""6.E.WS.103"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1199.184 1050.9041""
				},
				{
					""tag"": ""6.E.WS.104"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1120.2473 1050.9003""
				},
				{
					""tag"": ""6.E.WS.109"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1120.2473 1051.4589""
				},
				{
					""tag"": ""6.E.WS.115"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1199.184 1138.1931""
				},
				{
					""tag"": ""6.E.WS.116"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1120.2616 1138.1931""
				},
				{
					""tag"": ""6.E.WS.096"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1119.687 964.166""
				},
				{
					""tag"": ""6.E.WS.108"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1119.687 1051.4589""
				},
				{
					""tag"": ""6.E.WS.095"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1040.7646 964.166""
				},
				{
					""tag"": ""6.E.WS.105"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1119.687 1050.9041""
				},
				{
					""tag"": ""6.E.WS.106"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1040.7502 1050.9003""
				},
				{
					""tag"": ""6.E.WS.107"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1040.7502 1051.4589""
				},
				{
					""tag"": ""6.E.WS.117"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1119.687 1138.1931""
				},
				{
					""tag"": ""6.E.WS.118"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1040.7646 1138.1931""
				}
			]
		},
		""Section-10"": {
			""tag"": ""Section-10"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""6.E.WS.088"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 869.2781 1014.6292""
				},
				{
					""tag"": ""6.E.WS.086"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 916.5195 987.3533""
				},
				{
					""tag"": ""6.E.WS.085"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 963.7681 1014.6396""
				},
				{
					""tag"": ""6.E.WS.084"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 965.327 1014.6385""
				},
				{
					""tag"": ""6.E.WS.083"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 964.5377 1013.2729""
				},
				{
					""tag"": ""6.E.WS.075"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 867.7114 1014.6301""
				},
				{
					""tag"": ""6.E.WS.076"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 868.5003 1013.2729""
				},
				{
					""tag"": ""6.E.WS.082"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 917.2999 985.9982""
				},
				{
					""tag"": ""6.E.WS.081"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 917.2999 931.4551""
				},
				{
					""tag"": ""6.E.WS.080"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 964.5377 904.1819""
				},
				{
					""tag"": ""6.E.WS.079"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 868.5001 904.1819""
				},
				{
					""tag"": ""6.E.WS.078"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 915.7379 931.4551""
				},
				{
					""tag"": ""6.E.WS.077"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 915.7379 985.9982""
				},
				{
					""tag"": ""6.E.WS.069"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 963.7602 1089.9926""
				},
				{
					""tag"": ""6.E.WS.068"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 916.5188 1117.2683""
				},
				{
					""tag"": ""6.E.WS.067"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 869.2702 1089.9821""
				},
				{
					""tag"": ""6.E.WS.066"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 867.7114 1089.9832""
				},
				{
					""tag"": ""6.E.WS.065"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 868.5007 1091.3488""
				},
				{
					""tag"": ""6.E.WS.070"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 965.327 1089.9916""
				},
				{
					""tag"": ""6.E.WS.071"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 964.538 1091.3488""
				},
				{
					""tag"": ""6.E.WS.064"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 915.7384 1118.6234""
				},
				{
					""tag"": ""6.E.WS.063"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 915.7384 1173.1665""
				},
				{
					""tag"": ""6.E.WS.062"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 868.5007 1200.4397""
				},
				{
					""tag"": ""6.E.WS.074"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 964.5383 1200.4397""
				},
				{
					""tag"": ""6.E.WS.073"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 917.3005 1173.1665""
				},
				{
					""tag"": ""6.E.WS.072"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 917.3005 1118.6234""
				}
			]
		},
		""Section-10"": {
			""tag"": ""Section-10"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""6.E.WS.088"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 869.2781 1014.6292""
				},
				{
					""tag"": ""6.E.WS.086"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 916.5195 987.3533""
				},
				{
					""tag"": ""6.E.WS.085"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 963.7681 1014.6396""
				},
				{
					""tag"": ""6.E.WS.084"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 965.327 1014.6385""
				},
				{
					""tag"": ""6.E.WS.083"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 964.5377 1013.2729""
				},
				{
					""tag"": ""6.E.WS.075"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 867.7114 1014.6301""
				},
				{
					""tag"": ""6.E.WS.076"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 868.5003 1013.2729""
				},
				{
					""tag"": ""6.E.WS.082"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 917.2999 985.9982""
				},
				{
					""tag"": ""6.E.WS.081"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 917.2999 931.4551""
				},
				{
					""tag"": ""6.E.WS.080"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 964.5377 904.1819""
				},
				{
					""tag"": ""6.E.WS.079"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 868.5001 904.1819""
				},
				{
					""tag"": ""6.E.WS.078"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 915.7379 931.4551""
				},
				{
					""tag"": ""6.E.WS.077"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 915.7379 985.9982""
				},
				{
					""tag"": ""6.E.WS.069"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 963.7602 1089.9926""
				},
				{
					""tag"": ""6.E.WS.068"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 916.5188 1117.2683""
				},
				{
					""tag"": ""6.E.WS.067"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 869.2702 1089.9821""
				},
				{
					""tag"": ""6.E.WS.066"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 867.7114 1089.9832""
				},
				{
					""tag"": ""6.E.WS.065"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 868.5007 1091.3488""
				},
				{
					""tag"": ""6.E.WS.070"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 965.327 1089.9916""
				},
				{
					""tag"": ""6.E.WS.071"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 964.538 1091.3488""
				},
				{
					""tag"": ""6.E.WS.064"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 915.7384 1118.6234""
				},
				{
					""tag"": ""6.E.WS.063"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 915.7384 1173.1665""
				},
				{
					""tag"": ""6.E.WS.062"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 868.5007 1200.4397""
				},
				{
					""tag"": ""6.E.WS.074"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 964.5383 1200.4397""
				},
				{
					""tag"": ""6.E.WS.073"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 917.3005 1173.1665""
				},
				{
					""tag"": ""6.E.WS.072"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 917.3005 1118.6234""
				}
			]
		},
		""Section-11"": {
			""tag"": ""Section-11"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""6.E.WS.032"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 804.0555 876.8732""
				},
				{
					""tag"": ""6.E.WS.031"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 725.1332 876.8732""
				},
				{
					""tag"": ""6.E.WS.033"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 725.1332 963.6152""
				},
				{
					""tag"": ""6.E.WS.043"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 804.0555 964.166""
				},
				{
					""tag"": ""6.E.WS.042"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 725.1332 964.166""
				},
				{
					""tag"": ""6.E.WS.044"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 804.0555 1050.9041""
				},
				{
					""tag"": ""6.E.WS.045"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 725.1188 1050.9003""
				},
				{
					""tag"": ""6.E.WS.054"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 725.1188 1051.4589""
				},
				{
					""tag"": ""6.E.WS.056"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 804.0555 1138.1931""
				},
				{
					""tag"": ""6.E.WS.057"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 725.1332 1138.1931""
				},
				{
					""tag"": ""6.E.WS.030"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 724.5585 876.8732""
				},
				{
					""tag"": ""6.E.WS.029"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 645.6362 876.8732""
				},
				{
					""tag"": ""6.E.WS.034"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 724.5585 963.6152""
				},
				{
					""tag"": ""6.E.WS.035"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 645.6362 963.6152""
				},
				{
					""tag"": ""6.E.WS.028"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 645.0615 876.8732""
				},
				{
					""tag"": ""6.E.WS.027"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 566.1392 876.8732""
				},
				{
					""tag"": ""6.E.WS.036"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 645.0615 963.6152""
				},
				{
					""tag"": ""6.E.WS.037"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 566.1392 963.6152""
				},
				{
					""tag"": ""6.E.WS.041"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 724.5585 964.166""
				},
				{
					""tag"": ""6.E.WS.053"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 724.5585 1051.4589""
				},
				{
					""tag"": ""6.E.WS.055"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 804.0555 1051.4589""
				},
				{
					""tag"": ""6.E.WS.040"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 645.6362 964.166""
				},
				{
					""tag"": ""6.E.WS.046"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 724.5585 1050.9041""
				},
				{
					""tag"": ""6.E.WS.047"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 645.6218 1050.9003""
				},
				{
					""tag"": ""6.E.WS.052"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 645.6218 1051.4589""
				},
				{
					""tag"": ""6.E.WS.058"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 724.5585 1138.1931""
				},
				{
					""tag"": ""6.E.WS.059"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 645.6362 1138.1931""
				},
				{
					""tag"": ""6.E.WS.039"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 645.0615 964.166""
				},
				{
					""tag"": ""6.E.WS.051"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 645.0615 1051.4589""
				},
				{
					""tag"": ""6.E.WS.038"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 566.1392 964.166""
				},
				{
					""tag"": ""6.E.WS.048"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 645.0615 1050.9041""
				},
				{
					""tag"": ""6.E.WS.049"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 566.1248 1050.9003""
				},
				{
					""tag"": ""6.E.WS.050"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 566.1248 1051.4589""
				},
				{
					""tag"": ""6.E.WS.060"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 645.0615 1138.1931""
				},
				{
					""tag"": ""6.E.WS.061"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 566.1392 1138.1931""
				}
			]
		},
		""Section-12"": {
			""tag"": ""Section-12"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""6.E.WS.009"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 269.7079 955.2169""
				},
				{
					""tag"": ""6.E.WS.008"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 269.7079 876.2946""
				},
				{
					""tag"": ""6.E.WS.006"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 182.9737 955.208""
				},
				{
					""tag"": ""6.E.WS.007"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 182.9737 876.2856""
				},
				{
					""tag"": ""6.E.WS.016"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 357.0007 876.2946""
				},
				{
					""tag"": ""6.E.WS.014"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 270.2665 955.208""
				},
				{
					""tag"": ""6.E.WS.015"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 270.2665 876.2856""
				},
				{
					""tag"": ""6.E.WS.024"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 444.2935 955.2169""
				},
				{
					""tag"": ""6.E.WS.023"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 444.2935 876.2946""
				},
				{
					""tag"": ""6.E.WS.021"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 357.5593 955.208""
				},
				{
					""tag"": ""6.E.WS.022"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 357.5593 876.2856""
				},
				{
					""tag"": ""6.E.WS.011"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 269.7079 1034.7113""
				},
				{
					""tag"": ""6.E.WS.010"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 269.7079 955.7979""
				},
				{
					""tag"": ""6.E.WS.001"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 182.4115 955.2169""
				},
				{
					""tag"": ""6.E.WS.003"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 182.4115 1034.7113""
				},
				{
					""tag"": ""6.E.WS.002"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 182.4115 955.7979""
				},
				{
					""tag"": ""6.E.WS.004"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 182.9737 1034.7113""
				},
				{
					""tag"": ""6.E.WS.005"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 182.9737 955.7889""
				},
				{
					""tag"": ""6.E.WS.018"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 357.0007 1034.7113""
				},
				{
					""tag"": ""6.E.WS.017"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 357.0007 955.7979""
				},
				{
					""tag"": ""6.E.WS.012"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 270.2665 1034.7113""
				},
				{
					""tag"": ""6.E.WS.013"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 270.2665 955.7889""
				},
				{
					""tag"": ""6.E.WS.026"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 444.2935 1034.7113""
				},
				{
					""tag"": ""6.E.WS.025"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 444.2935 955.7979""
				},
				{
					""tag"": ""6.E.WS.019"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 357.5593 1034.7113""
				},
				{
					""tag"": ""6.E.WS.020"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 357.5593 955.7889""
				}
			]
		},
		""Section-13"": {
			""tag"": ""Section-13"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""6.S.WS.003"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 130.6716 380.697""
				},
				{
					""tag"": ""6.S.WS.002"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 51.7493 380.697""
				},
				{
					""tag"": ""6.S.WS.004"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 130.6716 467.439""
				},
				{
					""tag"": ""6.S.WS.005"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 51.7493 467.439""
				},
				{
					""tag"": ""6.S.WS.001"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 51.1746 380.697""
				},
				{
					""tag"": ""6.S.WS.006"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 51.1746 467.439""
				},
				{
					""tag"": ""6.S.WS.014"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 130.6716 555.2827""
				},
				{
					""tag"": ""6.S.WS.008"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 51.7493 467.9898""
				},
				{
					""tag"": ""6.S.WS.009"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 130.6716 554.7278""
				},
				{
					""tag"": ""6.S.WS.010"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 51.7349 554.7241""
				},
				{
					""tag"": ""6.S.WS.013"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 51.7349 555.2827""
				},
				{
					""tag"": ""6.S.WS.015"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 130.6716 642.0169""
				},
				{
					""tag"": ""6.S.WS.016"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 51.7493 642.0169""
				},
				{
					""tag"": ""6.S.WS.007"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 51.1746 467.9898""
				},
				{
					""tag"": ""6.S.WS.012"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 51.1746 555.2827""
				},
				{
					""tag"": ""6.S.WS.011"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 51.1746 554.7278""
				},
				{
					""tag"": ""6.S.WS.017"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 51.1746 642.0169""
				},
				{
					""tag"": ""6.S.WS.020"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 130.6716 642.5657""
				},
				{
					""tag"": ""6.S.WS.025"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 130.6716 729.8585""
				},
				{
					""tag"": ""6.S.WS.019"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 51.7493 642.5657""
				},
				{
					""tag"": ""6.S.WS.021"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 51.7349 729.3""
				},
				{
					""tag"": ""6.S.WS.024"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 51.7349 729.8585""
				},
				{
					""tag"": ""6.S.WS.026"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 130.6716 816.5928""
				},
				{
					""tag"": ""6.S.WS.027"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 51.7493 816.5928""
				},
				{
					""tag"": ""6.S.WS.018"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 51.1746 642.5657""
				},
				{
					""tag"": ""6.S.WS.023"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 51.1746 729.8585""
				},
				{
					""tag"": ""6.S.WS.022"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 51.1746 729.3037""
				},
				{
					""tag"": ""6.S.WS.028"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 51.1746 816.5928""
				},
				{
					""tag"": ""6.S.WS.031"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 130.6716 869.7793""
				},
				{
					""tag"": ""6.S.WS.030"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 51.7493 869.7793""
				},
				{
					""tag"": ""6.S.WS.029"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 51.1746 869.7793""
				}
			]
		}
	}
}";
            migrationBuilder.InsertData(table: "MapConfiguration",
            columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
            values: new object[]
            {
                "1-1-7-2",
                pune6thFloorMap,
                "V1",
                "1",
                DateTime.Now
            });

            migrationBuilder.InsertData(table: "MapConfiguration",
            columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
            values: new object[]
            {
                "1-1-7-11",
                pune6thFloorMap,
                "V1",
                "1",
                DateTime.Now
            });

            migrationBuilder.InsertData(table: "MapConfiguration",
            columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
            values: new object[]
            {
                "1-1-7-9",
                pune6thFloorMap,
                "V1",
                "1",
                DateTime.Now
            });

            migrationBuilder.InsertData(table: "MapConfiguration",
            columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
            values: new object[]
            {
                "1-1-7-10",
                pune6thFloorMap,
                "V1",
                "1",
                DateTime.Now
            });

			// ------------------------
			// Pune 7th Floor Map :: Last Updated - 29122021
			// ------------------------

			string pune7thFloorMap = @"{
	""assets"": {
		""pic"": {
			""name"": ""Pune 6th Floor Plan"",
			""ref"": ""./assets/1-1-8-8.jpg""
		},
		""svg"": {
			""name"": ""Pune 6th Floor Assets"",
			""ref"": ""./assets/1-1-8-8.svg""
		}
	},
	""models"": {
		""Mod-1"": {
			""name"": ""PTableL"",
			""template"": ""t2""
		},
		""Mod-2"": {
			""name"": ""PTabelS"",
			""template"": ""t2""
		},
		""Mod-3"": {
			""name"": ""PTable120"",
			""template"": ""t2""
		},
		""Mod-4"": {
			""name"": ""PTabelSs"",
			""template"": ""t2""
		}
	},
	""areas"": {
		""Area-1"": {
			""tag"": ""MD Cabin 7.W.C.1""
		},
		""Area-2"": {
			""tag"": ""Dry Pantry""
		},
		""Area-3"": {
			""tag"": ""Board Room""
		},
		""Area-4"": {
			""tag"": ""Biophilia""
		},
		""Area-5"": {
			""tag"": ""Managers Cabin 7.W.C.2""
		},
		""Area-6"": {
			""tag"": ""Managers Cabin 7.W.C.3""
		},
		""Area-7"": {
			""tag"": ""Wating Area""
		},
		""Area-8"": {
			""tag"": ""Wating Area""
		},
		""Area-9"": {
			""tag"": ""Reception Area""
		},
		""Area-10"": {
			""tag"": ""Digital Lab""
		},
		""Area-11"": {
			""tag"": ""Training Room""
		},
		""Area-12"": {
			""tag"": ""Biophilia""
		},
		""Area-13"": {
			""tag"": ""Admin Store""
		},
		""Area-14"": {
			""tag"": ""Battery Room""
		},
		""Area-15"": {
			""tag"": ""UPS Room""
		},
		""Area-16"": {
			""tag"": ""IT Store""
		},
		""Area-17"": {
			""tag"": ""Hub Room""
		},
		""Area-18"": {
			""tag"": ""Builder’s Pantry""
		},
		""Area-19"": {
			""tag"": ""Collaboration Area""
		},
		""Area-20"": {
			""tag"": ""Meeting Room""
		},
		""Area-21"": {
			""tag"": ""Managers Cabin 7.E.C.7""
		},
		""Area-22"": {
			""tag"": ""Managers Cabin 7.E.C.6""
		},
		""Area-23"": {
			""tag"": ""Managers Cabin 7.E.C.5""
		},
		""Area-24"": {
			""tag"": ""Managers Cabin 7.E.C.4""
		},
		""Area-25"": {
			""tag"": ""Meeting Room""
		},
		""Area-26"": {
			""tag"": ""Meeting Room""
		},
		""Area-27"": {
			""tag"": ""Meeting Room""
		},
		""Area-28"": {
			""tag"": ""Managers Cabin 7.E.C.3""
		},
		""Area-29"": {
			""tag"": ""Managers Cabin 7.E.C.2""
		},
		""Area-30"": {
			""tag"": ""Managers Cabin 7.E.C.1""
		},
		""Area-31"": {
			""tag"": ""Collaboration Area""
		},
		""Area-32"": {
			""tag"": ""Directors Cabin""
		},
		""Area-33"": {
			""tag"": ""Directors Cabin""
		},
		""Area-34"": {
			""tag"": ""Directors Cabin""
		},
		""Area-35"": {
			""tag"": ""Wating Area""
		},
		""Area-36"": {
			""tag"": ""Meeting Room""
		},
		""Area-37"": {
			""tag"": ""Meeting Room""
		},
		""Area-38"": {
			""tag"": ""Hub Room""
		},
		""Area-39"": {
			""tag"": ""Dry Pantry""
		},
		""Area-40"": {
			""tag"": ""Builder’s Pantry""
		},
		""Area-41"": {
			""tag"": ""Staircase""
		},
		""Area-42"": {
			""tag"": ""Gents Washroom""
		},
		""Area-43"": {
			""tag"": ""Ladies Washroom""
		},
		""Area-44"": {
			""tag"": ""Handicap Washroom""
		},
		""Area-45"": {
			""tag"": ""Lift Lobby""
		},
		""Area-46"": {
			""tag"": ""Lift Lobby""
		},
		""Area-47"": {
			""tag"": ""Ladies Washroom""
		},
		""Area-48"": {
			""tag"": ""Gents Washroom""
		},
		""Area-49"": {
			""tag"": ""Shower Room""
		},
		""Area-50"": {
			""tag"": ""Staircase""
		},
		""Area-51"": {
			""tag"": ""Phone Booth""
		},
		""Area-52"": {
			""tag"": ""Phone Booth""
		},
		""Area-53"": {
			""tag"": ""Meeting Room""
		},
		""Area-54"": {
			""tag"": ""Collaboration Area""
		},
		""Area-55"": {
			""tag"": ""Meeting Room""
		},
		""Area-56"": {
			""tag"": ""Amphitheatre""
		},
		""Area-57"": {
			""tag"": ""Phone Booth""
		},
		""Area-58"": {
			""tag"": ""Phone Booth""
		},
		""Area-59"": {
			""tag"": ""Meeting Room""
		},
		""Area-60"": {
			""tag"": ""Meeting Room""
		},
		""Area-61"": {
			""tag"": ""Breakout""
		},
		""Area-62"": {
			""tag"": ""Breakout""
		}
	},
	""sections"": {
		""Section-1"": {
			""tag"": ""Section-1"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""7.W.WS.001"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 36.6193 207.6126""
				},
				{
					""tag"": ""7.W.WS.002"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 83.2354 207.6063""
				},
				{
					""tag"": ""7.W.WS.003"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 83.2354 229.1497""
				},
				{
					""tag"": ""7.W.WS.004"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 36.6193 229.1497""
				}
			]
		},
		""Section-2"": {
			""tag"": ""Section-2"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""7.W.WS.009"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 511.9851 215.7468""
				},
				{
					""tag"": ""7.W.WS.006"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 425.2508 294.6602""
				},
				{
					""tag"": ""7.W.WS.005"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 425.2508 215.7378""
				},
				{
					""tag"": ""7.W.WS.014"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 599.2779 294.6691""
				},
				{
					""tag"": ""7.W.WS.015"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 599.2779 215.7468""
				},
				{
					""tag"": ""7.W.WS.011"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 512.5436 294.6602""
				},
				{
					""tag"": ""7.W.WS.010"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 512.5436 215.7378""
				},
				{
					""tag"": ""7.W.WS.017"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 599.8364 294.6602""
				},
				{
					""tag"": ""7.W.WS.016"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 599.8364 215.7378""
				},
				{
					""tag"": ""7.W.WS.008"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 511.9851 335.2024""
				},
				{
					""tag"": ""7.W.WS.007"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 425.2508 335.2024""
				},
				{
					""tag"": ""7.W.WS.013"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 599.2779 335.2024""
				},
				{
					""tag"": ""7.W.WS.012"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 512.5436 335.2024""
				},
				{
					""tag"": ""7.W.WS.018"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 599.8364 335.2024""
				},
				{
					""tag"": ""7.W.WS.020"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 718.5577 215.7468""
				},
				{
					""tag"": ""7.W.WS.024"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 805.8505 294.6691""
				},
				{
					""tag"": ""7.W.WS.025"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 805.8505 215.7468""
				},
				{
					""tag"": ""7.W.WS.021"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 719.1162 215.7378""
				},
				{
					""tag"": ""7.W.WS.030"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 895.7774 294.6691""
				},
				{
					""tag"": ""7.W.WS.031"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 895.7774 215.7468""
				},
				{
					""tag"": ""7.W.WS.027"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 806.409 294.6602""
				},
				{
					""tag"": ""7.W.WS.026"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 806.409 215.7378""
				},
				{
					""tag"": ""7.W.WS.019"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 718.5577 335.2024""
				},
				{
					""tag"": ""7.W.WS.023"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 805.8505 335.2024""
				},
				{
					""tag"": ""7.W.WS.022"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 719.1162 335.2024""
				},
				{
					""tag"": ""7.W.WS.029"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 895.7774 335.2024""
				},
				{
					""tag"": ""7.W.WS.028"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 806.409 335.2024""
				}
			]
		},
		""Section-3"": {
			""tag"": ""Section-3"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""7.E.WS.138"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1897.8424 1095.9866""
				},
				{
					""tag"": ""7.E.WS.139"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1818.9058 1095.9866""
				},
				{
					""tag"": ""7.E.WS.140"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1780.9081 1095.9866""
				},
				{
					""tag"": ""7.E.WS.141"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1701.9714 1095.9866""
				},
				{
					""tag"": ""7.E.WS.142"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1701.9858 1174.7987""
				}
			]
		},
		""Section-4"": {
			""tag"": ""Section-4"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""7.E.WS.105"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1495.6001 966.5282""
				},
				{
					""tag"": ""7.E.WS.104"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1495.6001 887.6058""
				},
				{
					""tag"": ""7.E.WS.102"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1408.8658 966.5192""
				},
				{
					""tag"": ""7.E.WS.103"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1408.8658 887.5969""
				},
				{
					""tag"": ""7.E.WS.113"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1582.8929 966.5282""
				},
				{
					""tag"": ""7.E.WS.112"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1582.8929 887.6058""
				},
				{
					""tag"": ""7.E.WS.110"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1496.1586 966.5192""
				},
				{
					""tag"": ""7.E.WS.111"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1496.1586 887.5969""
				},
				{
					""tag"": ""7.E.WS.118"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1583.4514 887.5969""
				},
				{
					""tag"": ""7.E.WS.120"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1670.5167 966.5282""
				},
				{
					""tag"": ""7.E.WS.119"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1670.5167 887.6058""
				},
				{
					""tag"": ""7.E.WS.128"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1757.8096 966.5282""
				},
				{
					""tag"": ""7.E.WS.127"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1757.8096 887.6058""
				},
				{
					""tag"": ""7.E.WS.125"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1671.0752 966.5192""
				},
				{
					""tag"": ""7.E.WS.126"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1671.0752 887.5969""
				},
				{
					""tag"": ""7.E.WS.135"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1845.1158 887.6058""
				},
				{
					""tag"": ""7.E.WS.133"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1758.368 966.5192""
				},
				{
					""tag"": ""7.E.WS.134"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1758.368 887.5969""
				},
				{
					""tag"": ""7.E.WS.107"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1495.6001 1046.0295""
				},
				{
					""tag"": ""7.E.WS.106"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1495.6001 967.1072""
				},
				{
					""tag"": ""7.E.WS.100"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1408.8658 1046.0206""
				},
				{
					""tag"": ""7.E.WS.101"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1408.8658 967.0983""
				},
				{
					""tag"": ""7.E.WS.115"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1582.8929 1046.0295""
				},
				{
					""tag"": ""7.E.WS.114"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1582.8929 967.1072""
				},
				{
					""tag"": ""7.E.WS.108"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1496.1586 1046.0206""
				},
				{
					""tag"": ""7.E.WS.109"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1496.1586 967.0983""
				},
				{
					""tag"": ""7.E.WS.116"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1583.4514 1046.0206""
				},
				{
					""tag"": ""7.E.WS.117"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1583.4514 967.0983""
				},
				{
					""tag"": ""7.E.WS.122"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1670.5167 1046.0295""
				},
				{
					""tag"": ""7.E.WS.121"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1670.5167 967.1072""
				},
				{
					""tag"": ""7.E.WS.130"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1757.8096 1046.0295""
				},
				{
					""tag"": ""7.E.WS.129"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1757.8096 967.1072""
				},
				{
					""tag"": ""7.E.WS.123"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1671.0752 1046.0206""
				},
				{
					""tag"": ""7.E.WS.124"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1671.0752 967.0983""
				},
				{
					""tag"": ""7.E.WS.137"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 1845.1158 1046.0295""
				},
				{
					""tag"": ""7.E.WS.136"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 1845.1158 967.1072""
				},
				{
					""tag"": ""7.E.WS.131"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 1758.368 1046.0206""
				},
				{
					""tag"": ""7.E.WS.132"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 1758.368 967.0983""
				}
			]
		},
		""Section-5"": {
			""tag"": ""Section-5"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""7.E.WS.097"",
					""active"": ""true"",
					""ref"": ""Mod-4"",
					""transform"": ""1 0 0 -1 1071.7437 943.2264""
				},
				{
					""tag"": ""7.E.WS.098"",
					""active"": ""true"",
					""ref"": ""Mod-4"",
					""transform"": ""1 0 0 -1 1101.0979 943.2264""
				},
				{
					""tag"": ""7.E.WS.099"",
					""active"": ""true"",
					""ref"": ""Mod-4"",
					""transform"": ""1 0 0 -1 1130.452 943.2264""
				}
			]
		},
		""Section-6"": {
			""tag"": ""Section-6"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""7.E.WS.095"",
					""active"": ""true"",
					""ref"": ""Mod-4"",
					""transform"": ""1 0 0 -1 1011.4376 912.0151""
				},
				{
					""tag"": ""7.E.WS.096"",
					""active"": ""true"",
					""ref"": ""Mod-4"",
					""transform"": ""1 0 0 -1 1040.7885 912.0151""
				},
				{
					""tag"": ""7.E.WS.094"",
					""active"": ""true"",
					""ref"": ""Mod-4"",
					""transform"": ""1 0 0 -1 1011.4376 951.0185""
				},
				{
					""tag"": ""7.E.WS.093"",
					""active"": ""true"",
					""ref"": ""Mod-4"",
					""transform"": ""1 0 0 -1 1040.7885 951.0185""
				},
				{
					""tag"": ""7.E.WS.091"",
					""active"": ""true"",
					""ref"": ""Mod-4"",
					""transform"": ""1 0 0 -1 1011.4376 989.9462""
				},
				{
					""tag"": ""7.E.WS.092"",
					""active"": ""true"",
					""ref"": ""Mod-4"",
					""transform"": ""1 0 0 -1 1040.7885 989.9462""
				}
			]
		},
		""Section-7"": {
			""tag"": ""Section-7"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""7.E.WS.086"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 852.6782 1172.3254""
				},
				{
					""tag"": ""7.E.WS.085"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 852.6782 1093.4031""
				},
				{
					""tag"": ""7.E.WS.087"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 765.944 1172.3164""
				},
				{
					""tag"": ""7.E.WS.088"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 765.944 1093.394""
				},
				{
					""tag"": ""7.E.WS.083"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 853.2368 1172.3164""
				},
				{
					""tag"": ""7.E.WS.084"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 853.2368 1093.394""
				},
				{
					""tag"": ""7.E.WS.090"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 765.3854 1172.3254""
				},
				{
					""tag"": ""7.E.WS.089"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 765.3854 1093.4031""
				},
				{
					""tag"": ""7.E.WS.082"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 944.0985 1093.4031""
				}
			]
		},
		""Section-8"": {
			""tag"": ""Section-8"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""7.E.WS.077"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 853.2368 966.517""
				},
				{
					""tag"": ""7.E.WS.078"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 853.2368 887.5946""
				},
				{
					""tag"": ""7.E.WS.079"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 944.0985 887.6036""
				},
				{
					""tag"": ""7.E.WS.070"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 706.936 1046.0183""
				},
				{
					""tag"": ""7.E.WS.069"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 706.936 967.0959""
				},
				{
					""tag"": ""7.E.WS.074"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 852.6782 1046.0272""
				},
				{
					""tag"": ""7.E.WS.073"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 852.6782 967.1049""
				},
				{
					""tag"": ""7.E.WS.071"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 765.944 1046.0183""
				},
				{
					""tag"": ""7.E.WS.072"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 765.944 967.0959""
				},
				{
					""tag"": ""7.E.WS.075"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 853.2368 1046.0183""
				},
				{
					""tag"": ""7.E.WS.076"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 853.2368 967.0959""
				},
				{
					""tag"": ""7.E.WS.081"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 944.0985 1046.0272""
				},
				{
					""tag"": ""7.E.WS.080"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 944.0985 967.1049""
				}
			]
		},
		""Section-9"": {
			""tag"": ""Section-9"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""7.E.WS.064"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 302.7563 1093.407""
				},
				{
					""tag"": ""7.E.WS.063"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 216.022 1172.3203""
				},
				{
					""tag"": ""7.E.WS.062"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 216.022 1093.3979""
				},
				{
					""tag"": ""7.E.WS.067"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 390.0491 1172.3293""
				},
				{
					""tag"": ""7.E.WS.068"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 390.0491 1093.407""
				},
				{
					""tag"": ""7.E.WS.066"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 303.3148 1172.3203""
				},
				{
					""tag"": ""7.E.WS.065"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 303.3148 1093.3979""
				}
			]
		},
		""Section-10"": {
			""tag"": ""Section-10"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""7.E.WS.028"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 302.7563 887.6058""
				},
				{
					""tag"": ""7.E.WS.026"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 216.022 966.5192""
				},
				{
					""tag"": ""7.E.WS.027"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 216.022 887.5969""
				},
				{
					""tag"": ""7.E.WS.036"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 390.0491 966.5282""
				},
				{
					""tag"": ""7.E.WS.035"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 390.0491 887.6058""
				},
				{
					""tag"": ""7.E.WS.033"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 303.3148 966.5192""
				},
				{
					""tag"": ""7.E.WS.034"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 303.3148 887.5969""
				},
				{
					""tag"": ""7.E.WS.041"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 390.6076 966.5192""
				},
				{
					""tag"": ""7.E.WS.042"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 390.6076 887.5969""
				},
				{
					""tag"": ""7.E.WS.044"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 477.6729 966.5282""
				},
				{
					""tag"": ""7.E.WS.043"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 477.6729 887.6058""
				},
				{
					""tag"": ""7.E.WS.051"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 564.9657 966.5282""
				},
				{
					""tag"": ""7.E.WS.050"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 564.9657 887.6058""
				},
				{
					""tag"": ""7.E.WS.049"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 478.2314 887.5969""
				},
				{
					""tag"": ""7.E.WS.059"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 652.272 966.5282""
				},
				{
					""tag"": ""7.E.WS.058"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 652.272 887.6058""
				},
				{
					""tag"": ""7.E.WS.056"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 565.5242 966.5192""
				},
				{
					""tag"": ""7.E.WS.057"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 565.5242 887.5969""
				},
				{
					""tag"": ""7.E.WS.030"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 302.7563 1046.0295""
				},
				{
					""tag"": ""7.E.WS.029"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 302.7563 967.1072""
				},
				{
					""tag"": ""7.E.WS.024"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 216.022 1046.0206""
				},
				{
					""tag"": ""7.E.WS.025"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 216.022 967.0983""
				},
				{
					""tag"": ""7.E.WS.038"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 390.0491 1046.0295""
				},
				{
					""tag"": ""7.E.WS.037"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 390.0491 967.1072""
				},
				{
					""tag"": ""7.E.WS.031"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 303.3148 1046.0206""
				},
				{
					""tag"": ""7.E.WS.032"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 303.3148 967.0983""
				},
				{
					""tag"": ""7.E.WS.039"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 390.6076 1046.0206""
				},
				{
					""tag"": ""7.E.WS.040"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 390.6076 967.0983""
				},
				{
					""tag"": ""7.E.WS.046"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 477.6729 1046.0295""
				},
				{
					""tag"": ""7.E.WS.045"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 477.6729 967.1072""
				},
				{
					""tag"": ""7.E.WS.053"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 564.9657 1046.0295""
				},
				{
					""tag"": ""7.E.WS.052"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 564.9657 967.1072""
				},
				{
					""tag"": ""7.E.WS.047"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 478.2314 1046.0206""
				},
				{
					""tag"": ""7.E.WS.048"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 478.2314 967.0983""
				},
				{
					""tag"": ""7.E.WS.061"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 652.272 1046.0295""
				},
				{
					""tag"": ""7.E.WS.060"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 652.272 967.1072""
				},
				{
					""tag"": ""7.E.WS.054"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 565.5242 1046.0206""
				},
				{
					""tag"": ""7.E.WS.055"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 565.5242 967.0983""
				}
			]
		},
		""Section-11"": {
			""tag"": ""Section-11"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""7.E.WS.005"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 174.0447 782.6158""
				},
				{
					""tag"": ""7.E.WS.004"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 174.0447 782.061""
				},
				{
					""tag"": ""7.E.WS.003"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 95.1081 782.0573""
				},
				{
					""tag"": ""7.E.WS.006"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 95.1081 782.6158""
				},
				{
					""tag"": ""7.E.WS.012"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 174.0447 869.35""
				},
				{
					""tag"": ""7.E.WS.011"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 95.1224 869.35""
				},
				{
					""tag"": ""7.E.WS.013"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 174.0447 869.8989""
				},
				{
					""tag"": ""7.E.WS.014"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 95.1224 869.8989""
				},
				{
					""tag"": ""7.E.WS.007"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 94.5477 782.6158""
				},
				{
					""tag"": ""7.E.WS.002"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 94.5477 782.061""
				},
				{
					""tag"": ""7.E.WS.001"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 15.611 782.0573""
				},
				{
					""tag"": ""7.E.WS.008"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 15.611 782.6158""
				},
				{
					""tag"": ""7.E.WS.010"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 94.5477 869.35""
				},
				{
					""tag"": ""7.E.WS.009"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 15.6254 869.35""
				},
				{
					""tag"": ""7.E.WS.015"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 94.5477 869.8989""
				},
				{
					""tag"": ""7.E.WS.016"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 15.6254 869.8989""
				},
				{
					""tag"": ""7.E.WS.020"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 174.0447 962.6572""
				},
				{
					""tag"": ""7.E.WS.019"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 174.0447 962.1024""
				},
				{
					""tag"": ""7.E.WS.018"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 95.1081 962.0986""
				},
				{
					""tag"": ""7.E.WS.021"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 95.1081 962.6572""
				},
				{
					""tag"": ""7.E.WS.023"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 174.0447 1049.3915""
				},
				{
					""tag"": ""7.E.WS.022"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 95.1224 1049.3915""
				},
				{
					""tag"": ""7.E.WS.017"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 15.611 962.0986""
				}
			]
		},
		""Section-12"": {
			""tag"": ""Section-12"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""7.S.WS.001"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 36.6193 535.4402""
				},
				{
					""tag"": ""7.S.WS.002"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 83.2354 535.4338""
				},
				{
					""tag"": ""7.S.WS.003"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 83.2354 556.9773""
				},
				{
					""tag"": ""7.S.WS.004"",
					""active"": ""true"",
					""ref"": ""Mod-2"",
					""transform"": ""1 0 0 -1 36.6193 556.9773""
				}
			]
		},
		""Section-13"": {
			""tag"": ""Section-13"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""7.S.WS.010"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""1 0 0 -1 258.1387 655.7887""
				},
				{
					""tag"": ""7.S.WS.011"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 0.866 -0.866 0.5 285.4124 608.5527""
				},
				{
					""tag"": ""7.S.WS.020"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 -0.866 -0.866 0.5 339.9588 608.5543""
				},
				{
					""tag"": ""7.S.WS.013"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-1 0 0 -1 367.2315 655.7921""
				},
				{
					""tag"": ""7.S.WS.012"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 0.866 0.866 0.5 339.9588 608.5543""
				},
				{
					""tag"": ""7.S.WS.008"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 -0.866 -0.866 0.5 258.1399 655.7908""
				},
				{
					""tag"": ""7.S.WS.009"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 0.866 0.866 0.5 258.1399 655.7908""
				},
				{
					""tag"": ""7.S.WS.007"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-1 0 0 -1 285.4136 608.5547""
				},
				{
					""tag"": ""7.S.WS.006"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 0.866 0.866 0.5 258.1408 561.3169""
				},
				{
					""tag"": ""7.S.WS.005"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 -0.866 -0.866 0.5 258.1408 561.3169""
				},
				{
					""tag"": ""7.S.WS.021"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 -0.866 0.866 0.5 285.4136 608.5547""
				},
				{
					""tag"": ""7.S.WS.022"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""1 0 0 -1 258.1408 561.3169""
				},
				{
					""tag"": ""7.S.WS.014"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 0.866 -0.866 0.5 367.2285 655.7894""
				},
				{
					""tag"": ""7.S.WS.015"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 -0.866 0.866 0.5 367.2306 655.7925""
				},
				{
					""tag"": ""7.S.WS.016"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""1 0 0 -1 339.9555 608.5517""
				},
				{
					""tag"": ""7.S.WS.017"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 0.866 -0.866 0.5 367.2292 561.3157""
				},
				{
					""tag"": ""7.S.WS.018"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 -0.866 0.866 0.5 367.2292 561.3157""
				},
				{
					""tag"": ""7.S.WS.019"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-1 0 0 -1 367.2292 561.3157""
				}
			]
		}
	}
}";
			migrationBuilder.InsertData(table: "MapConfiguration",
			columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
			values: new object[]
			{
				"1-1-8-8",
				pune7thFloorMap,
				"V1",
				"1",
				DateTime.Now
			});

			migrationBuilder.InsertData(table: "MapConfiguration",
			columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
			values: new object[]
			{
				"1-1-8-7",
				pune7thFloorMap,
				"V1",
				"1",
				DateTime.Now
			});

			migrationBuilder.InsertData(table: "MapConfiguration",
			columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
			values: new object[]
			{
				"1-1-8-6",
				pune7thFloorMap,
				"V1",
				"1",
				DateTime.Now
			});

			migrationBuilder.InsertData(table: "MapConfiguration",
			columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
			values: new object[]
			{
				"1-1-8-5",
				pune7thFloorMap,
				"V1",
				"1",
				DateTime.Now
			});

			// ------------------------
			// Pune 8th Floor Map :: Last Updated - 29122021
			// ------------------------

			string pune8thFloorMap = @"{
	""assets"": {
		""pic"": {
			""name"": ""Pune 8th Floor Plan"",
			""ref"": ""./assets/1-1-9-4.jpg""
		},
		""svg"": {
			""name"": ""Pune 8th Floor Assets"",
			""ref"": ""./assets/1-1-9-4.svg""
		}
	},
	""models"": {
		""Mod-1"": {
			""name"": ""PTableL"",
			""template"": ""t2""
		},
		""Mod-2"": {
			""name"": ""PTabelS"",
			""template"": ""t2""
		},
		""Mod-3"": {
			""name"": ""PTable120"",
			""template"": ""t2""
		},
		""Mod-4"": {
			""name"": ""PTabelSs"",
			""template"": ""t2""
		}
	},
	""areas"": {
		""Area-1"": {
			""tag"": ""Collaboration Area""
		},
		""Area-2"": {
			""tag"": ""Managers Cabin 8.3""
		},
		""Area-3"": {
			""tag"": ""Managers Cabin 8.4""
		},
		""Area-4"": {
			""tag"": ""Collaboration Area""
		},
		""Area-5"": {
			""tag"": ""Collaboration Area""
		},
		""Area-6"": {
			""tag"": ""Managers Cabin 8.1""
		},
		""Area-7"": {
			""tag"": ""UPS Room""
		},
		""Area-8"": {
			""tag"": ""IT Store""
		},
		""Area-9"": {
			""tag"": ""Wet Pantry""
		},
		""Area-10"": {
			""tag"": ""Collaboration Area""
		},
		""Area-11"": {
			""tag"": ""Managers Cabin 8.2""
		},
		""Area-12"": {
			""tag"": ""Collaboration Area""
		},
		""Area-13"": {
			""tag"": ""Collaboration Area""
		},
		""Area-14"": {
			""tag"": ""Mediascape""
		},
		""Area-15"": {
			""tag"": ""Phone Booth""
		},
		""Area-16"": {
			""tag"": ""Phone Booth""
		},
		""Area-17"": {
			""tag"": ""Hub Room""
		},
		""Area-18"": {
			""tag"": ""Dry Pantry""
		},
		""Area-19"": {
			""tag"": ""Phone Booth""
		},
		""Area-20"": {
			""tag"": ""Phone Booth""
		},
		""Area-21"": {
			""tag"": ""Amphitheatre""
		},
		""Area-22"": {
			""tag"": ""Meeting Room""
		},
		""Area-23"": {
			""tag"": ""Security Marshall""
		},
		""Area-24"": {
			""tag"": ""Meeting Room""
		},
		""Area-25"": {
			""tag"": ""Phone Booth""
		},
		""Area-26"": {
			""tag"": ""Phone Booth""
		},
		""Area-27"": {
			""tag"": ""Ladies Washroom""
		},
		""Area-28"": {
			""tag"": ""Handicap Washroom""
		},
		""Area-29"": {
			""tag"": ""Gents Washroom""
		},
		""Area-30"": {
			""tag"": ""Meeting Room""
		},
		""Area-31"": {
			""tag"": ""Meeting Room""
		},
		""Area-32"": {
			""tag"": ""Meeting Room""
		},
		""Area-33"": {
			""tag"": ""Lift Lobby""
		},
		""Area-34"": {
			""tag"": ""Lift Lobby""
		},
		""Area-35"": {
			""tag"": ""Meeting Room""
		},
		""Area-36"": {
			""tag"": ""Phone Booth""
		},
		""Area-37"": {
			""tag"": ""Phone Booth""
		},
		""Area-38"": {
			""tag"": ""Gents Washroom""
		},
		""Area-39"": {
			""tag"": ""Ladies Washroom""
		},
		""Area-40"": {
			""tag"": ""Shower Room""
		},
		""Area-41"": {
			""tag"": ""Builder’s Pantry""
		},
		""Area-42"": {
			""tag"": ""Staircase""
		},
		""Area-43"": {
			""tag"": ""Meeting Room""
		},
		""Area-44"": {
			""tag"": ""Meeting Room""
		},
		""Area-45"": {
			""tag"": ""Meeting Room""
		},
		""Area-46"": {
			""tag"": ""UPS Room""
		},
		""Area-47"": {
			""tag"": ""Server Room""
		},
		""Area-48"": {
			""tag"": ""Hub Room""
		},
		""Area-49"": {
			""tag"": ""Meeting Room""
		},
		""Area-50"": {
			""tag"": ""Electrical Room""
		},
		""Area-51"": {
			""tag"": ""Staircase""
		},
		""Area-52"": {
			""tag"": ""Collaboration Area""
		},
		""Area-53"": {
			""tag"": ""Collaboration Area""
		}
	},
	""sections"": {
		""Section-1"": {
			""tag"": ""Section-1"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.W.WS.003"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 1 223.9023 98.2512""
				},
				{
					""tag"": ""8.W.WS.004"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""-1 0 0 -1 223.9023 19.3289""
				},
				{
					""tag"": ""8.W.WS.002"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 137.1681 98.2423""
				},
				{
					""tag"": ""8.W.WS.001"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 137.1681 19.3199""
				},
				{
					""tag"": ""8.W.WS.006"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 1 224.4609 98.2423""
				},
				{
					""tag"": ""8.W.WS.005"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""1 0 0 -1 224.4609 19.3199""
				}
			]
		},
		""Section-2"": {
			""tag"": ""Section-2"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.W.WS.010"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 222.5937 129.3352""
				},
				{
					""tag"": ""8.W.WS.009"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 143.657 129.3352""
				},
				{
					""tag"": ""8.W.WS.008"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 143.0967 129.3352""
				},
				{
					""tag"": ""8.W.WS.007"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 64.16 129.3352""
				},
				{
					""tag"": ""8.W.WS.011"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 222.5793 214.7804""
				},
				{
					""tag"": ""8.W.WS.012"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 143.657 214.7804""
				},
				{
					""tag"": ""8.W.WS.013"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 143.0823 214.7804""
				},
				{
					""tag"": ""8.W.WS.014"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 64.16 214.7804""
				},
				{
					""tag"": ""8.W.WS.018"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 222.5937 215.4677""
				},
				{
					""tag"": ""8.W.WS.017"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 143.657 215.4677""
				},
				{
					""tag"": ""8.W.WS.016"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 143.0967 215.4677""
				},
				{
					""tag"": ""8.W.WS.015"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 64.16 215.4677""
				},
				{
					""tag"": ""8.W.WS.019"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 222.5793 300.9129""
				},
				{
					""tag"": ""8.W.WS.020"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 143.657 300.9129""
				},
				{
					""tag"": ""8.W.WS.021"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 143.0823 300.9129""
				},
				{
					""tag"": ""8.W.WS.025"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 222.5937 301.6002""
				},
				{
					""tag"": ""8.W.WS.024"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 143.657 301.6002""
				},
				{
					""tag"": ""8.W.WS.023"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 143.0967 301.6002""
				},
				{
					""tag"": ""8.W.WS.022"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 64.16 301.6002""
				},
				{
					""tag"": ""8.W.WS.026"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 222.5793 387.0454""
				},
				{
					""tag"": ""8.W.WS.027"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 143.657 387.0454""
				},
				{
					""tag"": ""8.W.WS.028"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 143.0823 387.0454""
				},
				{
					""tag"": ""8.W.WS.029"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 64.16 387.0454""
				},
				{
					""tag"": ""8.W.WS.033"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 222.5937 387.7327""
				},
				{
					""tag"": ""8.W.WS.032"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 143.657 387.7327""
				},
				{
					""tag"": ""8.W.WS.031"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 143.0967 387.7327""
				},
				{
					""tag"": ""8.W.WS.030"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 64.16 387.7327""
				},
				{
					""tag"": ""8.W.WS.034"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 222.5793 473.1779""
				},
				{
					""tag"": ""8.W.WS.035"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 143.657 473.1779""
				},
				{
					""tag"": ""8.W.WS.036"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 143.0823 473.1779""
				},
				{
					""tag"": ""8.W.WS.037"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 64.16 473.1779""
				}
			]
		},
		""Section-3"": {
			""tag"": ""Section-3"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.S.WS.013"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""1 0 0 -1 85.9256 622.1803""
				},
				{
					""tag"": ""8.S.WS.012"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 0.866 -0.866 0.5 113.1993 574.9443""
				},
				{
					""tag"": ""8.S.WS.003"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 -0.866 -0.866 0.5 167.7457 574.9459""
				},
				{
					""tag"": ""8.S.WS.010"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-1 0 0 -1 195.0184 622.1837""
				},
				{
					""tag"": ""8.S.WS.011"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 0.866 0.866 0.5 167.7457 574.9459""
				},
				{
					""tag"": ""8.S.WS.015"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 -0.866 -0.866 0.5 85.9268 622.1824""
				},
				{
					""tag"": ""8.S.WS.014"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 0.866 0.866 0.5 85.9268 622.1824""
				},
				{
					""tag"": ""8.S.WS.016"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-1 0 0 -1 113.2005 574.9463""
				},
				{
					""tag"": ""8.S.WS.017"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.5 0.866 0.866 0.5 85.9277 527.7086""
				},
				{
					""tag"": ""8.S.WS.002"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 -0.866 0.866 0.5 113.2005 574.9463""
				},
				{
					""tag"": ""8.S.WS.001"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""1 0 0 -1 85.9277 527.7086""
				},
				{
					""tag"": ""8.S.WS.009"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 0.866 -0.866 0.5 195.0154 622.181""
				},
				{
					""tag"": ""8.S.WS.008"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 -0.866 0.866 0.5 195.0175 622.1842""
				},
				{
					""tag"": ""8.S.WS.007"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""1 0 0 -1 167.7424 574.9434""
				},
				{
					""tag"": ""8.S.WS.006"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 0.866 -0.866 0.5 195.0161 527.7073""
				},
				{
					""tag"": ""8.S.WS.005"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.5 -0.866 0.866 0.5 195.0161 527.7073""
				},
				{
					""tag"": ""8.S.WS.004"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-1 0 0 -1 195.0161 527.7073""
				}
			]
		},
		""Section-4"": {
			""tag"": ""Section-4"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.S.WS.021"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 222.5937 676.9929""
				},
				{
					""tag"": ""8.S.WS.020"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 143.657 676.9929""
				},
				{
					""tag"": ""8.S.WS.019"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 143.0967 676.9929""
				},
				{
					""tag"": ""8.S.WS.018"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 64.16 676.9929""
				},
				{
					""tag"": ""8.S.WS.022"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 222.5793 762.438""
				},
				{
					""tag"": ""8.S.WS.023"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 143.657 762.438""
				},
				{
					""tag"": ""8.S.WS.024"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 143.0823 762.438""
				},
				{
					""tag"": ""8.S.WS.025"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 64.16 762.438""
				},
				{
					""tag"": ""8.S.WS.029"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 222.5937 763.1253""
				},
				{
					""tag"": ""8.S.WS.028"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 143.657 763.1253""
				},
				{
					""tag"": ""8.S.WS.027"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 143.0967 763.1253""
				},
				{
					""tag"": ""8.S.WS.026"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 64.16 763.1253""
				},
				{
					""tag"": ""8.S.WS.030"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 222.5793 848.5706""
				},
				{
					""tag"": ""8.S.WS.031"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 143.657 848.5706""
				},
				{
					""tag"": ""8.S.WS.032"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 143.0823 848.5706""
				},
				{
					""tag"": ""8.S.WS.033"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 64.16 848.5706""
				},
				{
					""tag"": ""8.S.WS.037"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 222.5937 849.2578""
				},
				{
					""tag"": ""8.S.WS.036"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 143.657 849.2578""
				},
				{
					""tag"": ""8.S.WS.035"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 143.0967 849.2578""
				},
				{
					""tag"": ""8.S.WS.034"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 64.16 849.2578""
				},
				{
					""tag"": ""8.E.WS.003"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 222.5793 934.7031""
				},
				{
					""tag"": ""8.E.WS.002"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 143.657 934.7031""
				},
				{
					""tag"": ""8.E.WS.001"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 143.0823 934.7031""
				},
				{
					""tag"": ""8.E.WS.004"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 222.5937 935.3903""
				},
				{
					""tag"": ""8.E.WS.005"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 143.657 935.3903""
				},
				{
					""tag"": ""8.E.WS.006"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 143.0967 935.3903""
				},
				{
					""tag"": ""8.E.WS.010"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 222.5793 1020.8356""
				},
				{
					""tag"": ""8.E.WS.009"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 143.657 1020.8356""
				},
				{
					""tag"": ""8.E.WS.008"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 143.0823 1020.8356""
				},
				{
					""tag"": ""8.E.WS.007"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 64.16 1020.8356""
				}
			]
		},
		""Section-5"": {
			""tag"": ""Section-5"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.W.WS.045"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 389.7158 201.9439""
				},
				{
					""tag"": ""8.W.WS.044"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 342.4744 229.2197""
				},
				{
					""tag"": ""8.W.WS.043"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 -0.5 0.866 295.2258 201.9334""
				},
				{
					""tag"": ""8.W.WS.041"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 294.4563 203.3001""
				},
				{
					""tag"": ""8.W.WS.046"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 -0.5 0.866 391.2826 201.9429""
				},
				{
					""tag"": ""8.W.WS.047"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 390.4937 203.3001""
				},
				{
					""tag"": ""8.W.WS.040"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 341.694 230.5748""
				},
				{
					""tag"": ""8.W.WS.054"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 295.2338 313.7658""
				},
				{
					""tag"": ""8.W.WS.053"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 342.4752 286.49""
				},
				{
					""tag"": ""8.W.WS.052"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 389.7238 313.7763""
				},
				{
					""tag"": ""8.W.WS.051"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 391.2826 313.7752""
				},
				{
					""tag"": ""8.W.WS.050"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 390.4933 312.4095""
				},
				{
					""tag"": ""8.W.WS.038"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 293.6677 313.7431""
				},
				{
					""tag"": ""8.W.WS.039"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 341.694 285.1179""
				},
				{
					""tag"": ""8.W.WS.042"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 293.6677 201.9088""
				},
				{
					""tag"": ""8.W.WS.049"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 -0.5 0.866 343.2561 285.1179""
				},
				{
					""tag"": ""8.W.WS.048"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 343.2561 230.5748""
				},
				{
					""tag"": ""8.W.WS.061"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 581.828 201.9506""
				},
				{
					""tag"": ""8.W.WS.060"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 534.5867 229.2265""
				},
				{
					""tag"": ""8.W.WS.059"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 -0.5 0.866 487.338 201.9402""
				},
				{
					""tag"": ""8.W.WS.057"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 486.5685 203.3069""
				},
				{
					""tag"": ""8.W.WS.062"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 -0.5 0.866 583.3948 201.9497""
				},
				{
					""tag"": ""8.W.WS.063"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 582.6058 203.3069""
				},
				{
					""tag"": ""8.W.WS.056"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 533.8063 230.5815""
				},
				{
					""tag"": ""8.W.WS.070"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 487.346 313.7726""
				},
				{
					""tag"": ""8.W.WS.069"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 534.5873 286.4967""
				},
				{
					""tag"": ""8.W.WS.068"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 581.836 313.783""
				},
				{
					""tag"": ""8.W.WS.067"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 583.3948 313.782""
				},
				{
					""tag"": ""8.W.WS.066"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 582.6055 312.4163""
				},
				{
					""tag"": ""8.W.WS.055"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 485.7799 313.7498""
				},
				{
					""tag"": ""8.W.WS.058"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 485.7799 201.9156""
				},
				{
					""tag"": ""8.W.WS.065"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 -0.5 0.866 535.3683 285.1247""
				},
				{
					""tag"": ""8.W.WS.064"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 535.3683 230.5815""
				}
			]
		},
		""Section-6"": {
			""tag"": ""Section-6"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.W.WS.075"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 574.1561 23.876""
				},
				{
					""tag"": ""8.W.WS.076"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 495.2194 23.876""
				},
				{
					""tag"": ""8.W.WS.072"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 574.1561 110.6103""
				},
				{
					""tag"": ""8.W.WS.071"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 495.2337 110.6103""
				},
				{
					""tag"": ""8.W.WS.074"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 614.6777 23.876""
				},
				{
					""tag"": ""8.W.WS.073"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 614.6777 110.6103""
				}
			]
		},
		""Section-7"": {
			""tag"": ""Section-7"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.W.WS.080"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 805.4425 78.6718""
				},
				{
					""tag"": ""8.W.WS.079"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 726.5059 78.6718""
				},
				{
					""tag"": ""8.W.WS.078"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 725.9455 78.6718""
				},
				{
					""tag"": ""8.W.WS.077"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 647.0089 78.6718""
				},
				{
					""tag"": ""8.W.WS.089"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 805.4282 165.4037""
				},
				{
					""tag"": ""8.W.WS.090"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 726.5059 165.4037""
				},
				{
					""tag"": ""8.W.WS.091"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 725.9312 165.4037""
				},
				{
					""tag"": ""8.W.WS.092"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 647.0089 165.4037""
				},
				{
					""tag"": ""8.W.WS.096"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 805.4425 165.9668""
				},
				{
					""tag"": ""8.W.WS.095"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 726.5059 165.9668""
				},
				{
					""tag"": ""8.W.WS.094"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 725.9455 165.9668""
				},
				{
					""tag"": ""8.W.WS.093"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 647.0089 165.9668""
				},
				{
					""tag"": ""8.W.WS.105"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 805.4282 252.7135""
				},
				{
					""tag"": ""8.W.WS.106"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 726.5059 252.7135""
				},
				{
					""tag"": ""8.W.WS.107"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 725.9312 252.7135""
				},
				{
					""tag"": ""8.W.WS.108"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 647.0089 252.7135""
				},
				{
					""tag"": ""8.W.WS.111"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 805.4425 253.2489""
				},
				{
					""tag"": ""8.W.WS.110"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 726.5059 253.2489""
				},
				{
					""tag"": ""8.W.WS.109"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 647.0089 253.2489""
				},
				{
					""tag"": ""8.W.WS.119"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 805.4282 339.9876""
				},
				{
					""tag"": ""8.W.WS.120"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 726.5059 339.9876""
				},
				{
					""tag"": ""8.W.WS.121"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 725.9312 339.9876""
				},
				{
					""tag"": ""8.W.WS.122"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 647.0089 339.9876""
				},
				{
					""tag"": ""8.W.WS.084"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 964.4431 78.6718""
				},
				{
					""tag"": ""8.W.WS.083"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 885.5065 78.6718""
				},
				{
					""tag"": ""8.W.WS.082"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 884.9461 78.6718""
				},
				{
					""tag"": ""8.W.WS.081"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 806.0095 78.6718""
				},
				{
					""tag"": ""8.W.WS.085"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 964.4288 165.4037""
				},
				{
					""tag"": ""8.W.WS.086"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 885.5065 165.4037""
				},
				{
					""tag"": ""8.W.WS.087"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 884.9318 165.4037""
				},
				{
					""tag"": ""8.W.WS.088"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 806.0095 165.4037""
				},
				{
					""tag"": ""8.W.WS.100"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 964.4431 165.9668""
				},
				{
					""tag"": ""8.W.WS.099"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 885.5065 165.9668""
				},
				{
					""tag"": ""8.W.WS.098"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 884.9461 165.9668""
				},
				{
					""tag"": ""8.W.WS.097"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 806.0095 165.9668""
				},
				{
					""tag"": ""8.W.WS.101"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 964.4288 252.7135""
				},
				{
					""tag"": ""8.W.WS.102"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 885.5065 252.7135""
				},
				{
					""tag"": ""8.W.WS.103"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 884.9318 252.7135""
				},
				{
					""tag"": ""8.W.WS.104"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 806.0095 252.7135""
				},
				{
					""tag"": ""8.W.WS.114"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 885.5065 253.2489""
				},
				{
					""tag"": ""8.W.WS.113"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 884.9461 253.2489""
				},
				{
					""tag"": ""8.W.WS.112"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 806.0095 253.2489""
				},
				{
					""tag"": ""8.W.WS.115"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 964.4288 339.9876""
				},
				{
					""tag"": ""8.W.WS.116"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 885.5065 339.9876""
				},
				{
					""tag"": ""8.W.WS.117"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 884.9318 339.9876""
				},
				{
					""tag"": ""8.W.WS.118"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 806.0095 339.9876""
				}
			]
		},
		""Section-8"": {
			""tag"": ""Section-8"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.W.WS.144"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1031.6871 126.8453""
				},
				{
					""tag"": ""8.W.WS.143"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 1078.9285 99.5695""
				},
				{
					""tag"": ""8.W.WS.142"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1126.1771 126.8558""
				},
				{
					""tag"": ""8.W.WS.141"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1127.736 126.8547""
				},
				{
					""tag"": ""8.W.WS.140"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1126.9467 125.489""
				},
				{
					""tag"": ""8.W.WS.137"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1030.9093 125.489""
				},
				{
					""tag"": ""8.W.WS.139"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1079.7089 98.2144""
				},
				{
					""tag"": ""8.W.WS.138"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1078.1469 98.2144""
				},
				{
					""tag"": ""8.W.WS.130"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1126.1692 202.0138""
				},
				{
					""tag"": ""8.W.WS.129"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1078.9279 229.2897""
				},
				{
					""tag"": ""8.W.WS.128"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1031.6792 202.0034""
				},
				{
					""tag"": ""8.W.WS.126"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1030.9097 203.3701""
				},
				{
					""tag"": ""8.W.WS.131"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1127.736 202.0129""
				},
				{
					""tag"": ""8.W.WS.132"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1126.947 203.3701""
				},
				{
					""tag"": ""8.W.WS.125"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1078.1473 230.6447""
				},
				{
					""tag"": ""8.W.WS.136"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1030.1211 126.8226""
				},
				{
					""tag"": ""8.W.WS.135"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1126.9467 312.4795""
				},
				{
					""tag"": ""8.W.WS.124"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1078.1473 285.1879""
				},
				{
					""tag"": ""8.W.WS.127"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1030.1211 201.9788""
				},
				{
					""tag"": ""8.W.WS.123"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1030.9097 312.461""
				},
				{
					""tag"": ""8.W.WS.134"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 -0.5 0.866 1079.7095 285.1879""
				},
				{
					""tag"": ""8.W.WS.133"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1079.7095 230.6447""
				}
			]
		},
		""Section-9"": {
			""tag"": ""Section-9"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.W.WS.148"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1359.334 165.4037""
				},
				{
					""tag"": ""8.W.WS.147"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1280.4116 165.4037""
				},
				{
					""tag"": ""8.W.WS.146"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1279.837 165.4037""
				},
				{
					""tag"": ""8.W.WS.145"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1200.9147 165.4037""
				},
				{
					""tag"": ""8.W.WS.153"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1359.3484 165.9668""
				},
				{
					""tag"": ""8.W.WS.154"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1280.4116 165.9668""
				},
				{
					""tag"": ""8.W.WS.155"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1279.8513 165.9668""
				},
				{
					""tag"": ""8.W.WS.156"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1200.9147 165.9668""
				},
				{
					""tag"": ""8.W.WS.160"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1359.334 252.7135""
				},
				{
					""tag"": ""8.W.WS.159"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1280.4116 252.7135""
				},
				{
					""tag"": ""8.W.WS.158"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1279.837 252.7135""
				},
				{
					""tag"": ""8.W.WS.157"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1200.9147 252.7135""
				},
				{
					""tag"": ""8.W.WS.164"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1359.3484 253.2489""
				},
				{
					""tag"": ""8.W.WS.165"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1280.4116 253.2489""
				},
				{
					""tag"": ""8.W.WS.167"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1359.334 339.9876""
				},
				{
					""tag"": ""8.W.WS.166"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1280.4116 339.9876""
				},
				{
					""tag"": ""8.W.WS.150"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1438.8376 165.4037""
				},
				{
					""tag"": ""8.W.WS.149"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1359.9153 165.4037""
				},
				{
					""tag"": ""8.W.WS.151"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1438.8519 165.9668""
				},
				{
					""tag"": ""8.W.WS.152"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1359.9153 165.9668""
				},
				{
					""tag"": ""8.W.WS.162"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1438.8376 252.7135""
				},
				{
					""tag"": ""8.W.WS.161"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1359.9153 252.7135""
				},
				{
					""tag"": ""8.W.WS.163"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1438.8519 253.2489""
				}
			]
		},
		""Section-10"": {
			""tag"": ""Section-10"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.W.WS.192"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1508.0975 126.7753""
				},
				{
					""tag"": ""8.W.WS.191"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 1555.339 99.4995""
				},
				{
					""tag"": ""8.W.WS.190"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1602.5876 126.7858""
				},
				{
					""tag"": ""8.W.WS.189"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1604.1465 126.7848""
				},
				{
					""tag"": ""8.W.WS.188"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1603.3571 125.4191""
				},
				{
					""tag"": ""8.W.WS.185"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1507.3197 125.4191""
				},
				{
					""tag"": ""8.W.WS.187"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1556.1194 98.1444""
				},
				{
					""tag"": ""8.W.WS.186"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1554.5573 98.1444""
				},
				{
					""tag"": ""8.W.WS.176"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1602.5796 201.9439""
				},
				{
					""tag"": ""8.W.WS.175"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1555.3383 229.2197""
				},
				{
					""tag"": ""8.W.WS.174"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1508.0896 201.9334""
				},
				{
					""tag"": ""8.W.WS.172"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1507.3201 203.3001""
				},
				{
					""tag"": ""8.W.WS.177"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1604.1465 201.9429""
				},
				{
					""tag"": ""8.W.WS.178"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1603.3574 203.3001""
				},
				{
					""tag"": ""8.W.WS.171"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1554.5579 230.5748""
				},
				{
					""tag"": ""8.W.WS.184"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1506.5315 126.7526""
				},
				{
					""tag"": ""8.W.WS.183"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1508.0975 313.7658""
				},
				{
					""tag"": ""8.W.WS.182"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 1555.339 286.49""
				},
				{
					""tag"": ""8.W.WS.181"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1602.5876 313.7763""
				},
				{
					""tag"": ""8.W.WS.180"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1604.1465 313.7752""
				},
				{
					""tag"": ""8.W.WS.168"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1506.5315 313.7431""
				},
				{
					""tag"": ""8.W.WS.170"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1554.5579 285.1179""
				},
				{
					""tag"": ""8.W.WS.173"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1506.5315 201.9088""
				},
				{
					""tag"": ""8.W.WS.169"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1507.3201 312.3911""
				},
				{
					""tag"": ""8.W.WS.179"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1556.1199 230.5748""
				}
			]
		},
		""Section-11"": {
			""tag"": ""Section-11"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.W.WS.196"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1826.2371 165.9611""
				},
				{
					""tag"": ""8.W.WS.195"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1747.3003 165.9611""
				},
				{
					""tag"": ""8.W.WS.194"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1746.74 165.9611""
				},
				{
					""tag"": ""8.W.WS.193"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1667.8033 165.9611""
				},
				{
					""tag"": ""8.W.WS.199"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1826.2227 252.6929""
				},
				{
					""tag"": ""8.W.WS.200"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1747.3003 252.6929""
				},
				{
					""tag"": ""8.W.WS.201"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1746.7257 252.6929""
				},
				{
					""tag"": ""8.W.WS.202"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1667.8033 252.6929""
				},
				{
					""tag"": ""8.W.WS.205"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1747.3003 253.2561""
				},
				{
					""tag"": ""8.W.WS.204"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1746.74 253.2561""
				},
				{
					""tag"": ""8.W.WS.203"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1667.8033 253.2561""
				},
				{
					""tag"": ""8.W.WS.208"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1826.2227 340.0028""
				},
				{
					""tag"": ""8.W.WS.209"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1747.3003 340.0028""
				},
				{
					""tag"": ""8.W.WS.210"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1746.7257 340.0028""
				},
				{
					""tag"": ""8.W.WS.211"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1667.8033 340.0028""
				},
				{
					""tag"": ""8.W.WS.197"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1826.804 165.9611""
				},
				{
					""tag"": ""8.W.WS.198"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1826.804 252.6929""
				},
				{
					""tag"": ""8.W.WS.206"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1826.804 253.2561""
				},
				{
					""tag"": ""8.W.WS.207"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1826.804 340.0028""
				}
			]
		},
		""Section-12"": {
			""tag"": ""Section-12"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.E.WS.225"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1826.2377 877.3259""
				},
				{
					""tag"": ""8.E.WS.224"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1747.301 877.3259""
				},
				{
					""tag"": ""8.E.WS.223"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1746.7407 877.3259""
				},
				{
					""tag"": ""8.E.WS.222"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1667.804 877.3259""
				},
				{
					""tag"": ""8.E.WS.219"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1747.301 964.3696""
				},
				{
					""tag"": ""8.E.WS.220"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1746.7263 964.3696""
				},
				{
					""tag"": ""8.E.WS.221"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1667.804 964.3696""
				},
				{
					""tag"": ""8.E.WS.210"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1826.2377 964.9236""
				},
				{
					""tag"": ""8.E.WS.209"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1747.301 964.9236""
				},
				{
					""tag"": ""8.E.WS.208"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1746.7407 964.9236""
				},
				{
					""tag"": ""8.E.WS.207"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1667.804 964.9236""
				},
				{
					""tag"": ""8.E.WS.203"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1826.2234 1053.2598""
				},
				{
					""tag"": ""8.E.WS.204"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1747.301 1053.2598""
				},
				{
					""tag"": ""8.E.WS.206"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1667.804 1053.2598""
				},
				{
					""tag"": ""8.E.WS.205"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1746.7263 1053.2598""
				},
				{
					""tag"": ""8.E.WS.194"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1826.2377 1053.8125""
				},
				{
					""tag"": ""8.E.WS.229"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1985.2484 877.3259""
				},
				{
					""tag"": ""8.E.WS.228"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1906.3118 877.3259""
				},
				{
					""tag"": ""8.E.WS.227"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1905.7515 877.3259""
				},
				{
					""tag"": ""8.E.WS.226"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1826.8148 877.3259""
				},
				{
					""tag"": ""8.E.WS.215"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1985.2341 964.3696""
				},
				{
					""tag"": ""8.E.WS.216"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1906.3118 964.3696""
				},
				{
					""tag"": ""8.E.WS.217"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1905.7372 964.3696""
				},
				{
					""tag"": ""8.E.WS.218"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1826.8148 964.3696""
				},
				{
					""tag"": ""8.E.WS.214"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1985.2484 964.9236""
				},
				{
					""tag"": ""8.E.WS.213"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1906.3118 964.9236""
				},
				{
					""tag"": ""8.E.WS.212"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1905.7515 964.9236""
				},
				{
					""tag"": ""8.E.WS.211"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1826.8148 964.9236""
				},
				{
					""tag"": ""8.E.WS.199"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1985.2341 1053.2598""
				},
				{
					""tag"": ""8.E.WS.200"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1906.3118 1053.2598""
				},
				{
					""tag"": ""8.E.WS.202"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1826.8148 1053.2598""
				},
				{
					""tag"": ""8.E.WS.201"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1905.7372 1053.2598""
				},
				{
					""tag"": ""8.E.WS.198"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1985.2484 1053.8125""
				},
				{
					""tag"": ""8.E.WS.197"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1906.3118 1053.8125""
				},
				{
					""tag"": ""8.E.WS.196"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1905.7515 1053.8125""
				},
				{
					""tag"": ""8.E.WS.195"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1826.8148 1053.8125""
				}
			]
		},
		""Section-13"": {
			""tag"": ""Section-13"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.E.WS.191"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1602.5845 1090.4736""
				},
				{
					""tag"": ""8.E.WS.192"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1555.3431 1117.7494""
				},
				{
					""tag"": ""8.E.WS.193"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1508.0945 1090.4631""
				},
				{
					""tag"": ""8.E.WS.183"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1507.325 1091.8298""
				},
				{
					""tag"": ""8.E.WS.190"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1604.1514 1090.4727""
				},
				{
					""tag"": ""8.E.WS.189"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1603.3623 1091.8298""
				},
				{
					""tag"": ""8.E.WS.184"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1554.5627 1119.1045""
				},
				{
					""tag"": ""8.E.WS.187"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1603.3619 1200.9392""
				},
				{
					""tag"": ""8.E.WS.185"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1554.5627 1173.6476""
				},
				{
					""tag"": ""8.E.WS.182"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1506.5364 1090.4386""
				},
				{
					""tag"": ""8.E.WS.186"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1507.325 1200.9208""
				},
				{
					""tag"": ""8.E.WS.188"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1556.1248 1119.1045""
				},
				{
					""tag"": ""8.E.WS.179"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1602.5845 903.4641""
				},
				{
					""tag"": ""8.E.WS.180"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1555.3431 930.7399""
				},
				{
					""tag"": ""8.E.WS.181"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1508.0945 903.4536""
				},
				{
					""tag"": ""8.E.WS.167"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1507.325 904.8203""
				},
				{
					""tag"": ""8.E.WS.178"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1604.1514 903.4631""
				},
				{
					""tag"": ""8.E.WS.168"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1554.5627 932.095""
				},
				{
					""tag"": ""8.E.WS.172"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1508.1024 1015.286""
				},
				{
					""tag"": ""8.E.WS.173"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 1555.3439 988.0101""
				},
				{
					""tag"": ""8.E.WS.174"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1602.5925 1015.2964""
				},
				{
					""tag"": ""8.E.WS.175"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1604.1514 1015.2954""
				},
				{
					""tag"": ""8.E.WS.176"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1603.3619 1013.9297""
				},
				{
					""tag"": ""8.E.WS.171"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1506.5364 1015.2632""
				},
				{
					""tag"": ""8.E.WS.169"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1554.5627 986.6381""
				},
				{
					""tag"": ""8.E.WS.166"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1506.5364 903.429""
				},
				{
					""tag"": ""8.E.WS.170"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1507.325 1013.9113""
				},
				{
					""tag"": ""8.E.WS.177"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1556.1248 986.6381""
				}
			]
		},
		""Section-14"": {
			""tag"": ""Section-14"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.E.WS.164"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1363.3969 877.3259""
				},
				{
					""tag"": ""8.E.WS.165"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1284.4602 877.3259""
				},
				{
					""tag"": ""8.E.WS.160"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1363.3826 964.3696""
				},
				{
					""tag"": ""8.E.WS.159"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1284.4602 964.3696""
				},
				{
					""tag"": ""8.E.WS.155"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1363.3969 964.9236""
				},
				{
					""tag"": ""8.E.WS.156"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1284.4602 964.9236""
				},
				{
					""tag"": ""8.E.WS.157"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1283.8999 964.9236""
				},
				{
					""tag"": ""8.E.WS.158"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1204.9633 964.9236""
				},
				{
					""tag"": ""8.E.WS.150"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1363.3826 1053.2598""
				},
				{
					""tag"": ""8.E.WS.149"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1284.4602 1053.2598""
				},
				{
					""tag"": ""8.E.WS.147"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1204.9633 1053.2598""
				},
				{
					""tag"": ""8.E.WS.148"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1283.8855 1053.2598""
				},
				{
					""tag"": ""8.E.WS.143"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1363.3969 1053.8125""
				},
				{
					""tag"": ""8.E.WS.144"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1284.4602 1053.8125""
				},
				{
					""tag"": ""8.E.WS.145"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1283.8999 1053.8125""
				},
				{
					""tag"": ""8.E.WS.146"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1204.9633 1053.8125""
				},
				{
					""tag"": ""8.E.WS.138"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1363.3826 1141.2338""
				},
				{
					""tag"": ""8.E.WS.137"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1284.4602 1141.2338""
				},
				{
					""tag"": ""8.E.WS.136"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1283.8855 1141.2338""
				},
				{
					""tag"": ""8.E.WS.135"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1204.9633 1141.2338""
				},
				{
					""tag"": ""8.E.WS.162"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1442.8964 877.3259""
				},
				{
					""tag"": ""8.E.WS.163"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1363.974 877.3259""
				},
				{
					""tag"": ""8.E.WS.161"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1442.8964 964.3696""
				},
				{
					""tag"": ""8.E.WS.153"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1442.9106 964.9236""
				},
				{
					""tag"": ""8.E.WS.154"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1363.974 964.9236""
				},
				{
					""tag"": ""8.E.WS.151"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1363.974 1053.2598""
				},
				{
					""tag"": ""8.E.WS.152"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1442.8964 1053.2598""
				},
				{
					""tag"": ""8.E.WS.141"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 1442.9106 1053.8125""
				},
				{
					""tag"": ""8.E.WS.142"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 1363.974 1053.8125""
				},
				{
					""tag"": ""8.E.WS.140"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 1442.8964 1141.2338""
				},
				{
					""tag"": ""8.E.WS.139"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 1363.974 1141.2338""
				}
			]
		},
		""Section-15"": {
			""tag"": ""Section-15"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.E.WS.132"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1127.4116 1090.5631""
				},
				{
					""tag"": ""8.E.WS.133"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1080.1703 1117.839""
				},
				{
					""tag"": ""8.E.WS.134"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1032.9216 1090.5527""
				},
				{
					""tag"": ""8.E.WS.123"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1032.1521 1091.9194""
				},
				{
					""tag"": ""8.E.WS.131"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1128.9785 1090.5623""
				},
				{
					""tag"": ""8.E.WS.130"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1128.1895 1091.9194""
				},
				{
					""tag"": ""8.E.WS.124"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1079.3899 1119.1941""
				},
				{
					""tag"": ""8.E.WS.127"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1128.1891 1201.0288""
				},
				{
					""tag"": ""8.E.WS.125"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1079.3899 1173.7372""
				},
				{
					""tag"": ""8.E.WS.122"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1031.3635 1090.5281""
				},
				{
					""tag"": ""8.E.WS.126"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1032.1521 1201.0104""
				},
				{
					""tag"": ""8.E.WS.128"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1080.9519 1173.7372""
				},
				{
					""tag"": ""8.E.WS.129"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1080.9519 1119.1941""
				},
				{
					""tag"": ""8.E.WS.109"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1032.1521 904.9099""
				},
				{
					""tag"": ""8.E.WS.121"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 1128.1895 904.9099""
				},
				{
					""tag"": ""8.E.WS.110"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1079.3899 932.1845""
				},
				{
					""tag"": ""8.E.WS.114"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1032.9296 1015.3756""
				},
				{
					""tag"": ""8.E.WS.115"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 1080.171 988.0997""
				},
				{
					""tag"": ""8.E.WS.116"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1127.4196 1015.386""
				},
				{
					""tag"": ""8.E.WS.117"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1128.9785 1015.385""
				},
				{
					""tag"": ""8.E.WS.118"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 1128.1891 1014.0193""
				},
				{
					""tag"": ""8.E.WS.113"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 1031.3635 1015.3528""
				},
				{
					""tag"": ""8.E.WS.111"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 1079.3899 986.7277""
				},
				{
					""tag"": ""8.E.WS.112"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 1032.1521 1014.0008""
				},
				{
					""tag"": ""8.E.WS.119"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 1080.9519 986.7277""
				},
				{
					""tag"": ""8.E.WS.120"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 1080.9519 932.1845""
				}
			]
		},
		""Section-16"": {
			""tag"": ""Section-16"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.E.WS.105"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 934.5072 1139.2321""
				},
				{
					""tag"": ""8.E.WS.106"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 887.2658 1166.5079""
				},
				{
					""tag"": ""8.E.WS.107"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 840.0172 1139.2216""
				},
				{
					""tag"": ""8.E.WS.099"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 839.2477 1140.5883""
				},
				{
					""tag"": ""8.E.WS.102"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 936.074 1139.2311""
				},
				{
					""tag"": ""8.E.WS.100"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 886.4854 1167.8629""
				},
				{
					""tag"": ""8.E.WS.098"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 838.459 1139.197""
				},
				{
					""tag"": ""8.E.WS.101"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 888.0475 1167.8629""
				},
				{
					""tag"": ""8.E.WS.094"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 934.5072 903.553""
				},
				{
					""tag"": ""8.E.WS.095"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 887.2658 930.8289""
				},
				{
					""tag"": ""8.E.WS.096"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 840.0172 903.5426""
				},
				{
					""tag"": ""8.E.WS.082"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 1 1 6.732051e-07 839.2477 904.9093""
				},
				{
					""tag"": ""8.E.WS.083"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 886.4854 932.184""
				},
				{
					""tag"": ""8.E.WS.087"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 840.0251 1015.375""
				},
				{
					""tag"": ""8.E.WS.088"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 1 -1 6.732051e-07 887.2665 988.0991""
				},
				{
					""tag"": ""8.E.WS.089"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 934.5151 1015.3854""
				},
				{
					""tag"": ""8.E.WS.090"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 936.074 1015.3844""
				},
				{
					""tag"": ""8.E.WS.091"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""6.732051e-07 -1 -1 -6.732051e-07 935.2847 1014.0187""
				},
				{
					""tag"": ""8.E.WS.086"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 838.459 1015.3522""
				},
				{
					""tag"": ""8.E.WS.108"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 840.0251 1084.6777""
				},
				{
					""tag"": ""8.E.WS.104"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 934.5151 1084.6882""
				},
				{
					""tag"": ""8.E.WS.103"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 0.5 0.5 -0.866 936.074 1084.6873""
				},
				{
					""tag"": ""8.E.WS.097"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 0.5 0.5 0.866 838.459 1084.655""
				},
				{
					""tag"": ""8.E.WS.084"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 886.4854 986.7271""
				},
				{
					""tag"": ""8.E.WS.081"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-0.866 -0.5 0.5 -0.866 838.459 903.518""
				},
				{
					""tag"": ""8.E.WS.085"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""-6.732051e-07 -1 1 -6.732051e-07 839.2477 1014.0002""
				},
				{
					""tag"": ""8.E.WS.092"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 888.0475 986.7271""
				},
				{
					""tag"": ""8.E.WS.093"",
					""active"": ""true"",
					""ref"": ""Mod-3"",
					""transform"": ""0.866 -0.5 0.5 0.866 936.084 903.5229""
				}
			]
		},
		""Section-17"": {
			""tag"": ""Section-17"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.E.WS.077"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 613.8434 877.3259""
				},
				{
					""tag"": ""8.E.WS.078"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 534.9067 877.3259""
				},
				{
					""tag"": ""8.E.WS.079"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 534.3464 877.3259""
				},
				{
					""tag"": ""8.E.WS.080"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 455.4097 877.3259""
				},
				{
					""tag"": ""8.E.WS.071"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 613.8291 964.3696""
				},
				{
					""tag"": ""8.E.WS.070"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 534.9067 964.3696""
				},
				{
					""tag"": ""8.E.WS.066"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 613.8434 964.9236""
				},
				{
					""tag"": ""8.E.WS.067"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 534.9067 964.9236""
				},
				{
					""tag"": ""8.E.WS.068"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 534.3464 964.9236""
				},
				{
					""tag"": ""8.E.WS.069"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 455.4097 964.9236""
				},
				{
					""tag"": ""8.E.WS.057"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 613.8291 1053.2598""
				},
				{
					""tag"": ""8.E.WS.056"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 534.9067 1053.2598""
				},
				{
					""tag"": ""8.E.WS.054"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 455.4097 1053.2598""
				},
				{
					""tag"": ""8.E.WS.055"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 534.3321 1053.2598""
				},
				{
					""tag"": ""8.E.WS.050"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 613.8434 1053.8125""
				},
				{
					""tag"": ""8.E.WS.051"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 534.9067 1053.8125""
				},
				{
					""tag"": ""8.E.WS.052"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 534.3464 1053.8125""
				},
				{
					""tag"": ""8.E.WS.053"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 455.4097 1053.8125""
				},
				{
					""tag"": ""8.E.WS.041"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 613.8291 1141.2338""
				},
				{
					""tag"": ""8.E.WS.040"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 534.9067 1141.2338""
				},
				{
					""tag"": ""8.E.WS.039"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 534.3321 1141.2338""
				},
				{
					""tag"": ""8.E.WS.038"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 455.4097 1141.2338""
				},
				{
					""tag"": ""8.E.WS.075"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 772.8542 877.3259""
				},
				{
					""tag"": ""8.E.WS.076"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 614.4205 877.3259""
				},
				{
					""tag"": ""8.E.WS.074"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 772.8398 964.3696""
				},
				{
					""tag"": ""8.E.WS.073"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 693.3428 964.3696""
				},
				{
					""tag"": ""8.E.WS.072"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 614.4205 964.3696""
				},
				{
					""tag"": ""8.E.WS.062"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 772.8542 964.9236""
				},
				{
					""tag"": ""8.E.WS.063"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 693.9175 964.9236""
				},
				{
					""tag"": ""8.E.WS.064"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 693.3572 964.9236""
				},
				{
					""tag"": ""8.E.WS.065"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 614.4205 964.9236""
				},
				{
					""tag"": ""8.E.WS.061"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 772.8398 1053.2598""
				},
				{
					""tag"": ""8.E.WS.060"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 693.9175 1053.2598""
				},
				{
					""tag"": ""8.E.WS.058"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 614.4205 1053.2598""
				},
				{
					""tag"": ""8.E.WS.059"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 693.3428 1053.2598""
				},
				{
					""tag"": ""8.E.WS.046"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 772.8542 1053.8125""
				},
				{
					""tag"": ""8.E.WS.047"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 693.9175 1053.8125""
				},
				{
					""tag"": ""8.E.WS.048"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 693.3572 1053.8125""
				},
				{
					""tag"": ""8.E.WS.049"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 614.4205 1053.8125""
				},
				{
					""tag"": ""8.E.WS.045"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 772.8398 1141.2338""
				},
				{
					""tag"": ""8.E.WS.044"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 693.9175 1141.2338""
				},
				{
					""tag"": ""8.E.WS.043"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 693.3428 1141.2338""
				},
				{
					""tag"": ""8.E.WS.042"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 614.4205 1141.2338""
				}
			]
		},
		""Section-18"": {
			""tag"": ""Section-18"",
			""active"": ""true"",
			""units"": [
				{
					""tag"": ""8.E.WS.014"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 422.123 877.3259""
				},
				{
					""tag"": ""8.E.WS.013"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 343.1863 877.3259""
				},
				{
					""tag"": ""8.E.WS.012"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 342.626 877.3259""
				},
				{
					""tag"": ""8.E.WS.011"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 263.6893 877.3259""
				},
				{
					""tag"": ""8.E.WS.015"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 422.1087 964.3696""
				},
				{
					""tag"": ""8.E.WS.016"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 343.1863 964.3696""
				},
				{
					""tag"": ""8.E.WS.017"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 342.6117 964.3696""
				},
				{
					""tag"": ""8.E.WS.021"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 422.123 964.9236""
				},
				{
					""tag"": ""8.E.WS.020"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 343.1863 964.9236""
				},
				{
					""tag"": ""8.E.WS.019"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 342.626 964.9236""
				},
				{
					""tag"": ""8.E.WS.018"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 263.6893 964.9236""
				},
				{
					""tag"": ""8.E.WS.022"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 422.1087 1053.2598""
				},
				{
					""tag"": ""8.E.WS.023"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 343.1863 1053.2598""
				},
				{
					""tag"": ""8.E.WS.025"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 263.6893 1053.2598""
				},
				{
					""tag"": ""8.E.WS.024"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 342.6117 1053.2598""
				},
				{
					""tag"": ""8.E.WS.029"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 422.123 1053.8125""
				},
				{
					""tag"": ""8.E.WS.028"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 343.1863 1053.8125""
				},
				{
					""tag"": ""8.E.WS.027"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 1 0 342.626 1053.8125""
				},
				{
					""tag"": ""8.E.WS.026"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 1 -1 0 263.6893 1053.8125""
				},
				{
					""tag"": ""8.E.WS.030"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 422.1087 1142.7963""
				},
				{
					""tag"": ""8.E.WS.031"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 343.1863 1142.7963""
				},
				{
					""tag"": ""8.E.WS.032"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 342.6117 1142.7963""
				},
				{
					""tag"": ""8.E.WS.033"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 263.6893 1142.7963""
				},
				{
					""tag"": ""8.E.WS.037"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 422.1087 1202.5425""
				},
				{
					""tag"": ""8.E.WS.036"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 343.1863 1202.5425""
				},
				{
					""tag"": ""8.E.WS.035"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 1 0 342.6117 1202.5425""
				},
				{
					""tag"": ""8.E.WS.034"",
					""active"": ""true"",
					""ref"": ""Mod-1"",
					""transform"": ""0 -1 -1 0 263.6893 1202.5425""
				}
			]
		}
	}
}";
			migrationBuilder.InsertData(table: "MapConfiguration",
			columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
			values: new object[]
			{
				"1-1-9-4",
				pune8thFloorMap,
				"V1",
				"1",
				DateTime.Now
			});

			migrationBuilder.InsertData(table: "MapConfiguration",
			columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
			values: new object[]
			{
				"1-1-9-3",
				pune8thFloorMap,
				"V1",
				"1",
				DateTime.Now
			});

			migrationBuilder.InsertData(table: "MapConfiguration",
			columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
			values: new object[]
			{
				"1-1-9-20",
				pune8thFloorMap,
				"V1",
				"1",
				DateTime.Now
			});

			migrationBuilder.InsertData(table: "MapConfiguration",
			columns: new[] { "MapId", "JsonMapData", "Version", "AuditState", "CreatedDate" },
			values: new object[]
			{
				"1-1-9-21",
				pune8thFloorMap,
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
