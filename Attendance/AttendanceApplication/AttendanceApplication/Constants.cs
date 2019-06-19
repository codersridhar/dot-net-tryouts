using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AttendanceApplication
{
    static class Constants
    {
        public static string baseDirectory = @"C:\Users\surya.sridhar\Downloads\";
        public static string empAllFile = Path.Combine(baseDirectory, "sgzemps.txt");
        public static string empLoginFile = Path.Combine(baseDirectory, "sgzemps_login.txt");
        public static string empLogoutFile = Path.Combine(baseDirectory, "sgzemps_logout.txt");
        public static string adminInfoFile = Path.Combine(baseDirectory, "admin.txt");
        public static string cryptoKey = "92AE31A79FEEB2A3"; //"sblw-3hn8-sqoy19";
    }
}
