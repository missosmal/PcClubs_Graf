﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PcClubs_Graf.Classes.Common
{
    public class Config
    {
        public static string ConnectionConfig = "server=10.0.201.4;uid=root;pwd=;database=PcClub";
        public static MySqlServerVersion Version = new MySqlServerVersion(new System.Version(8, 0, 11));
    }
}
