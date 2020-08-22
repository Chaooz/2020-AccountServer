using System;
using System.Collections.Generic;

namespace AccountServer.Model
{
    public class InternalAccountData
    {
        public uint id { get; set; }
        public string nickname { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public InternalAccountData()
        {
        }
    }
}
