using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace FMS.Data.Migrations.RawSql
{
    public partial class MigrationRawSql
    {
        private readonly MigrationBuilder _migrationBuilder;

        public MigrationRawSql(MigrationBuilder builder)
        {
            _migrationBuilder = builder;
        }

        public void UpUserListInitial()
        {
            var usersListEMEA1 = File.ReadAllText(Path.Combine(Path.GetDirectoryName(GetType().Assembly.Location), @"SeedData\EMEA1_UsersList_Script.sql"));

            _migrationBuilder.Sql(usersListEMEA1);

            var usersListEMEA2 = File.ReadAllText(Path.Combine(Path.GetDirectoryName(GetType().Assembly.Location), @"SeedData\EMEA2_UsersList_Script.sql"));

            _migrationBuilder.Sql(usersListEMEA2);
        }

        public void UpCountryListInitial()
        {
            var usersList = File.ReadAllText(Path.Combine(Path.GetDirectoryName(GetType().Assembly.Location), @"SeedData\CountryList_Script.sql"));

            _migrationBuilder.Sql(usersList);
        }
    }
}
