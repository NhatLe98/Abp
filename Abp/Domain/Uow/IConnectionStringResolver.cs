﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.Domain.Uow
{
    /// <summary>
    /// Used to get connection string when a database connection is needed.
    /// </summary>
    public interface IConnectionStringResolver
    {
        /// <summary>
        /// Gets a connection string name (in config file) or a valid connection string.
        /// </summary>
        /// <param name="args">Arguments that can be used while resolving connection string.</param>
        string GetNameOrConnectionString(ConnectionStringResolveArgs args);

        /// <summary>
        /// Gets a connection string name (in config file) or a valid connection string.
        /// </summary>
        /// <param name="args">Arguments that can be used while resolving connection string.</param>
        Task<string> GetNameOrConnectionStringAsync(ConnectionStringResolveArgs args);
    }
}
