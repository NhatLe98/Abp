using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.Configuration
{
    /// <summary>
    /// The context that is used in setting providers.
    /// </summary>
    public class SettingDefinitionProviderContext
    {
        public ISettingDefinitionManager Manager { get; }

        public SettingDefinitionProviderContext(ISettingDefinitionManager manager)
        {
            Manager = manager;
        }
    }
}
