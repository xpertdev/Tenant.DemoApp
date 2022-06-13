using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenant.DemoApp.Queries.Handlers
{
    /// <summary>
    /// Handle queries
    /// </summary>
    /// <typeparam name="TQuery"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IQueryHandler<TQuery,TResult>
    {
        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        Task<TResult> HandleAsync(TQuery query);
    }

    /// <summary>
    /// Handle queries
    /// </summary>
    /// <typeparam name="TQuery"></typeparam>
    public interface IQueryHandler<TQuery>
    {
        /// <summary>
        /// Handle 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        Task HandleAsync(TQuery query);
    }
}
