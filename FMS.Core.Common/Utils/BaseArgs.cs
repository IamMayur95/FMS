using System;
using System.Collections.Generic;
using System.Threading;

namespace FMS.Core.Common.Utils
{
    public struct BaseArgs
    {
        public CancellationToken CancellationToken { get; set; }
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        //public bool IsSuperAdmin { get; set; }
    }
}
