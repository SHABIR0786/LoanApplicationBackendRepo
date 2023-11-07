﻿using System;
using System.Collections.Generic;

namespace LoanManagement.codeFirstEntities
{
    public partial class MilitaryService
    {
        public int Id { get; set; }
        public int? ApplicationPersonalInformationId { get; set; }
        public ulong? ServedInForces7a1 { get; set; }
        public ulong? CurrentlyServing7a2 { get; set; }
        public DateTime? DateOfServiceExpiration7a3 { get; set; }
        public ulong? Retired7a2 { get; set; }
        public ulong? NonActivatedMember7a2 { get; set; }
        public ulong? SurvivingSpouse7a21 { get; set; }
    }
}
