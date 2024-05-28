using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admp.adapters
{
    public class ErrorManager
    {
        private static List<string> _errors = new List<string>(); 

        public static Task ReportAsync(string message)
        { 
            _errors.Add(message);

            MessageBox.Show(
                message, 
                "Приложение остановлено", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error
            );

            return Task.CompletedTask;  
        }

        public static Task<string> LastReportAsync() => 
            Task.FromResult(_errors.Last());

        public static Task<string[]> GetReportsAsync() =>
            Task.FromResult(_errors.ToArray());
        
    }
}
