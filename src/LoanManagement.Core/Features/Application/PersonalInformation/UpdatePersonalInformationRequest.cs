﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Features.Application.PersonalInformation
{
    public class UpdatePersonalInformationRequest: AddPersonalInformationRequest
    {
        public int Id { get; set; }
    }
}
