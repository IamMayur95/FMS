namespace FMS.Core.Common.Contracts.Api
{
    public static class ApiConstants
    {
        /// <summary>
        /// API Route prefix
        /// </summary>
        public const string ApiRoutePrefix = "api";

        /// <summary>
        /// 200 MB size limit. Value is in bytes
        /// </summary>
        public const int RequestBodySizeLimit = 200 * 1024 * 1024;

        /// <summary>
        /// 1 MB size limit. Value is in bytes
        /// </summary>
        public const int BCPTaskTestingRequestBodySizeLimit = 1 * 1024 * 1024;

        /// <summary>
        /// 10 MB size limit. Value is in bytes
        /// </summary>
        public const int BCPTestingRequestBodySizeLimit = 10 * 1024 * 1024;

        /// <summary>
        /// Admin user permission group name
        /// </summary>
        public const string AdminUserPermissionGroupName = "IT GRC";

        public const string ProjectStatusLive = "Live";

        public const string ProjectStatusInTransition = "In Transition";
    }
}
