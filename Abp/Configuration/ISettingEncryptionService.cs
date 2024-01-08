using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.Configuration
{
    public interface ISettingEncryptionService
    {
        [CanBeNull]
        string Encrypt([NotNull] SettingDefinition settingDefinition, [CanBeNull] string plainValue);

        [CanBeNull]
        string Decrypt([NotNull] SettingDefinition settingDefinition, [CanBeNull] string encryptedValue);
    }
}
