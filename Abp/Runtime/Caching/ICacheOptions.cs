using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.Runtime.Caching
{
    public interface ICacheOptions
    {
        /// <summary>
        /// Default sliding expire time of cache items.
        /// Default value: 60 minutes (1 hour).
        /// Can be changed by configuration.
        /// </summary>
        TimeSpan DefaultSlidingExpireTime { get; set; }

        /// <summary>
        /// Default absolute expire time of cache items.
        /// Default value: null (not used).
        /// </summary>
        DateTimeOffset? DefaultAbsoluteExpireTime { get; set; }
    }
}
