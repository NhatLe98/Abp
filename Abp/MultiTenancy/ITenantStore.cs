using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.MultiTenancy
{
    public interface ITenantStore
    {
        [CanBeNull]
        TenantInfo Find(int tenantId);

        [CanBeNull]
        TenantInfo Find([NotNull] string tenancyName);
    }
}
