﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.Domain.Uow
{
    public class AuditFieldConfiguration
    {
        public string FieldName { get; set; }

        public bool IsSavingEnabled { get; }

        public AuditFieldConfiguration(string fieldName, bool isSavingEnabled)
        {
            FieldName = fieldName;
            IsSavingEnabled = isSavingEnabled;
        }
    }
}
