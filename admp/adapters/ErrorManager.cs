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

        /// <summary>
        /// Обрабатывает ошибку, записывает сообщение в список
        /// </summary>
        /// <param name="message">сообщение</param>
        /// <returns></returns>
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

        /// <summary>
        /// Производит поиск в журнале событий
        /// </summary>
        /// <returns>Последнее сообщение в журнале</returns>
        public static Task<string> LastReportAsync() => 
            Task.FromResult(_errors.Last());

        /// <summary>
        /// Производит копию отчета в виде фиксированного списка
        /// </summary>
        /// <returns>Массив всех сообщений из журнала</returns>
        public static Task<string[]> GetReportsAsync() =>
            Task.FromResult(_errors.ToArray());
        
    }
}
