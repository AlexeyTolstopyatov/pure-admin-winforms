using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using admp.adapters;
using admp.config;

namespace admp.security
{
    public class AuthenticationManager
    {
        /// <summary>
        /// Пытается проверить личность (доверенное лицо) для входа в Систему Управления. Поддерживает ожидание.
        /// </summary>
        /// <returns>Состояние операции (true - личность подтверждена)</returns>
        public static async Task<bool> InitializePersonalAsync()
        {
            try
            {
                SqlConnection connection = new SqlConnection(Connection.Default.ConnectingString);
                await connection.OpenAsync();

                connection.Close();
                return true;
            }
            catch (Exception E)
            {
                await ErrorManager.ReportAsync(E.Message);
                return false;
            }
        }


        /// <summary>
        /// Пытается проверить личность (доверенное лицо) для входа в Систему Управления
        /// </summary>
        /// <returns>Состояние операции (true - личность подтверждена)</returns>
        public static bool InitializePersonal() 
        {
            try
            {
                SqlConnection connection = 
                    new SqlConnection(Connection.Default.ConnectingString);
                
                connection.Open();

                connection.Close();
                return true;
            }
            catch (Exception E)
            {
                // асинхронный вызов всетаки будет.
                _ = ErrorManager.ReportAsync(E.Message);
                return false;
            }
        }
    }
}
