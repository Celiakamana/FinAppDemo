﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialApp
{
    public static class DatabaseConfig
    {
        // Centralized connection string
        public static string ConnectionString { get; } =
            "Server=tcp:cik.database.windows.net,1433;Initial Catalog=UsersDB;Persist Security Info=False;User ID=PublicUser;Password=Password123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    }
}
