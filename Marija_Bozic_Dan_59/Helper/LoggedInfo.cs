using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marija_Bozic_Dan_59.Helper
{
    public static class LoggedInfo
    {
        public static void LoggAction(long secunds)
        {
            FileInfo txt = new FileInfo(@"..\..\IgraPamcenja.txt");
            StreamWriter sw = txt.AppendText();            
            sw.WriteLine("[{0}][{1}]", DateTime.Now, secunds);
            sw.Close();
        }
    }
}
