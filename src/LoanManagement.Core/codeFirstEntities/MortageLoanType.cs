﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;

namespace LoanManagement.codeFirstEntities
{
    public partial class MortageLoanType: FullAuditedEntity<int>
    {
        public string MortageLoanTypesId { get; set; }
    }
}
