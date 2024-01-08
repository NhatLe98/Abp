using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.Runtime.Caching
{
    /// <summary>
    /// Defines a cache that uses <see cref="string"/> as key, <see cref="object"/> as value.
    /// </summary>
    public interface ICache : IDisposable, ICacheOptions, IAbpCache<string, object>
    {
    }
}
