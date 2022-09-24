using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Data.Common;

namespace AspNetCoreUseEFCore
{
    public class EfIInterceptor : DbCommandInterceptor
    {
        public override InterceptionResult<DbCommand> CommandCreating(CommandCorrelatedEventData eventData, InterceptionResult<DbCommand> result)
        {
            return base.CommandCreating(eventData, result);
        }
    }
}
