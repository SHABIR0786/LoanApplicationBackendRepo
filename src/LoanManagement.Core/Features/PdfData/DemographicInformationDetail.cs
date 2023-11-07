﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagement.Features.PdfData
{
    public class DemographicInformationDetail
    {
        public int? ApplicationPersonalInformationId { get; set; }
        public string Ethnicity81 { get; set; }
        public string Gender82 { get; set; }
        public string Race83 { get; set; }
        public ulong? IsEthnicityByObservation84 { get; set; }
        public ulong? IsGenderByObservation85 { get; set; }
        public ulong? IsRaceByObservation86 { get; set; }
        public string DemographicInfoSource87 { get; set; }
    }
}
