﻿namespace LoanManagement
{
    public class ResponseMessagesDto
    {
        public long Id { get; set; }
        public string SuccessMessage { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public bool Error { get; set; }
    }
}
