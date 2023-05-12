using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;

namespace FMS.Data.Extensions
{
    public static class DbContextExtensions
    {
        public static List<Type> GetAllEntityTypes(this DbContext context)
        {
            return context.Model.GetEntityTypes().Select(t => t.ClrType).ToList();
        }
    }
}
