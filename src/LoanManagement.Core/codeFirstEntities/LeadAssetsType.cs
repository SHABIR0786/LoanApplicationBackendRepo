﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;

namespace LoanManagement.codeFirstEntities
{
    public partial class LeadAssetsType: FullAuditedEntity<int>
    {
       
        public string AssetsType { get; set; }
    }
}
