using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.MultiTenancy;
using Abp.Runtime.Caching;
using Abp.Runtime.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.Configuration
{
    /// <summary>
    /// This class implements <see cref="ISettingManager"/> to manage setting values in the database.
    /// </summary>
    public class SettingManager : ISettingManager, ISingletonDependency
    {
        public const string ApplicationSettingsCacheKey = "ApplicationSettings";

        protected ISettingEncryptionService SettingEncryptionService { get; }

        /// <summary>
        /// Reference to the current Session.
        /// </summary>
        public IAbpSession AbpSession { get; set; }


        /// <summary>
        /// Reference to the setting store.
        /// </summary>
        public ISettingStore SettingStore { get; set; }

        private readonly ISettingDefinitionManager _settingDefinitionManager;
        private readonly IMultiTenancyConfig _multiTenancyConfig;
        private readonly ITypedCache<string, Dictionary<string, SettingInfo>> _applicationSettingCache;
        private readonly ITypedCache<int, Dictionary<string, SettingInfo>> _tenantSettingCache;
        private readonly ITypedCache<string, Dictionary<string, SettingInfo>> _userSettingCache;
        private readonly ITenantStore _tenantStore;
        private readonly IUnitOfWorkManager _unitOfWorkManager;


    }
}
