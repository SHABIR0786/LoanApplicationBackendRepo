﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Features.Application.MilitaryService
{
    public class UpdateMilitaryServiceRequest: AddMilitaryServiceRequest
    {
        public int Id { get; set; }
    }
}
