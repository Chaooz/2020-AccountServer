using System;
using System.Collections.Generic;

namespace AccountClientModule.Model
{
    public class ResetPasswordDataCode
    {
        public string code { get; set; }
        public string emailAddress { get; set; }
        public ResetPasswordDataCode()
        {
        }
    }
}