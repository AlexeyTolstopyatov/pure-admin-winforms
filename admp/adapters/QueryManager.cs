using admp.config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace admp.adapters
{
    public class QueryManager
    {
        public static async Task<DataTable> ExecuteMapAsync(string text)
        { 

            DataTable table = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.Default.WindowsAuthentication))
                using (SqlCommand command = new SqlCommand(text, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    await connection.OpenAsync();

                    adapter.Fill(table);
                }
            }
            catch (Exception ex) 
            {
                await ErrorManager.ReportAsync(ex.Message);
            }
            return table;
        }

        public static async Task<object[]> ExecuteVectorAsync(string text)
        {
            List<object> vec = new List<object>();
            try
            {

                using (SqlConnection connection = new SqlConnection(Connection.Default.WindowsAuthentication))
                using (SqlCommand command = new SqlCommand(text, connection))
                {
                    await connection.OpenAsync();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            vec.Add(reader.GetValue(0));
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                await ErrorManager.ReportAsync(ex.Message);
            }
            return vec.ToArray();
        }
    }
}
