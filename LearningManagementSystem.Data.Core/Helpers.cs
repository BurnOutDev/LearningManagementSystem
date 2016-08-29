using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Credentials.UI;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace LearningManagementSystem.Data.Core
{
    public static class Helpers
    {
        // 100% - 28-Jun  7-Jul

        static void get()
        {
            var start = new DateTime(2016, 06, 28);
            var end = new DateTime(2016, 07, 07);

            var between = DateTime.Compare(start, end);
        }
    }
}
