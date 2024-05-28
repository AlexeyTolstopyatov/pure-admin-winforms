using admp.config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace admp.adapters
{
    public class QueryManager
    {
        /// <summary>
        /// Выполняет запрос
        /// </summary>
        /// <param name="text">запрос</param>
        /// <returns>Таблица в виде (DataTable) по указанному запросу</returns>
        public static async Task<DataTable> ExecuteMapAsync(string text)
        { 

            DataTable table = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.Default.ConnectingString))
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

        /// <summary>
        /// Выполняет запрос
        /// </summary>
        /// <param name="text">запрос</param>
        /// <returns>Одномерный массив строчек одного столбца</returns>
        public static async Task<object[]> ExecuteVectorAsync(string text)
        {
            List<object> vec = new List<object>();
            try
            {

                using (SqlConnection connection = new SqlConnection(Connection.Default.ConnectingString))
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

        /// <summary>
        /// Выполняет запрос
        /// </summary>
        /// <param name="text">запрос</param>
        /// <returns>Первый столбец первой строки</returns>
        public static async Task<object> ExecuteCellAsync(string text)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.Default.ConnectingString))
                using (SqlCommand command = new SqlCommand(text, connection))
                {
                    await connection.OpenAsync();

                    return await command.ExecuteScalarAsync();
                }
            }
            catch (Exception E)
            {
                await ErrorManager.ReportAsync(E.Message);
            }

            return new object();
        }
    }
}
