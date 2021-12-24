using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.IO;

namespace Common.DATA
{
    public class DataProvider
    {
        public SqlConnection cnn = new SqlConnection();
        public DataProvider(string stringConnection)
        {
            cnn = new SqlConnection(stringConnection);
        }

        public DataProvider()
        {

        }

        void openConnection()
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
            }
            catch
            {

            }
        }
       public void closeConnection()
        {
            cnn.Close();
        }
         

        public string ConvertToJson(DataTable dt)
        {
            return JsonConvert.SerializeObject(dt, Formatting.Indented);
        }

        public List<T> ConvertToList<T>(string json)
        {
            return JsonConvert.DeserializeObject<List<T>>(json);
        }

        //public List<T> ConvertToList<T>(DataTable dt)
        //{
        //    var columnNames = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName.ToLower()).ToList();
        //    var properties = typeof(T).GetProperties();
        //    return dt.AsEnumerable().Select(row => {
        //        var objT = Activator.CreateInstance<T>();
        //        foreach (var pro in properties)
        //        {
        //            if (columnNames.Contains(pro.Name.ToLower()))
        //            {
        //                try
        //                {
        //                    pro.SetValue(objT, row[pro.Name]);
        //                }
        //                catch { }
        //            }
        //        }
        //        return objT;
        //    }).ToList();
        //}

        public List<T> ConvertToList<T>(DataTable dt)
        {
            return JsonConvert.DeserializeObject<List<T>>(JsonConvert.SerializeObject(dt, Formatting.Indented));
        }


        public DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }


        public void PushDataToDB<T>(List<T> data, string TableName)
        {
            DataTable dt = new DataTable();

            dt = ToDataTable<T>(data);

            var bulkCopy = new SqlBulkCopy(cnn.ConnectionString, SqlBulkCopyOptions.KeepIdentity);

            foreach (DataColumn col in dt.Columns)
            {
                bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
            }

            bulkCopy.BulkCopyTimeout = 600;
            bulkCopy.DestinationTableName = TableName;
            bulkCopy.WriteToServer(dt);

        }

        public void PushDataToDB(DataTable dt, string TableName)
        {

            var bulkCopy = new SqlBulkCopy(cnn.ConnectionString, SqlBulkCopyOptions.KeepIdentity);

            foreach (DataColumn col in dt.Columns)
            {
                bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
            }

            bulkCopy.BulkCopyTimeout = 600;
            bulkCopy.DestinationTableName = TableName;
            bulkCopy.WriteToServer(dt);

        }

        public DataTable getDatatable(string query)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getDatatable(SqlCommand cmd, int CommandTimeOut)
        {
            openConnection();
            cmd.Connection = cnn;
            cmd.CommandTimeout = CommandTimeOut;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public string getdata(SqlCommand cmd)
        {
            openConnection();
            cmd.Connection = cnn;
      //      cmd.CommandTimeout = CommandTimeOut;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows[0][2].ToString().Trim();
        }

        public SqlDataAdapter getDatatable(string query, ref DataTable dt)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return da;
        }
        
        public bool SaveDatatable(SqlDataAdapter da, DataTable dt)
        {
            openConnection();
            new SqlCommandBuilder(da);
            da.Update(dt);
            return true;
        }

        public List<T> getList<T>(string query)
        {
            return ConvertToList<T>(getDatatable(query));
        }

        public int ExecuteScalar(string query)
        {
            openConnection();

            SqlCommand cmd = new SqlCommand(query, cnn);
            return (int)cmd.ExecuteScalar();
        }

        public string ExecuteScalar_string(string query)
        {
            openConnection();

            SqlCommand cmd = new SqlCommand(query, cnn);
            return cmd.ExecuteScalar().ToString();
        }
        public int ExecuteNonQuery(string query)
        {
            openConnection();

            SqlCommand cmd = new SqlCommand(query, cnn);
            return cmd.ExecuteNonQuery();
        }
        
        public async Task<int> ExecuteNonQueryAsync(string query)
        {
            openConnection();

            SqlCommand cmd = new SqlCommand(query, cnn);
            return await cmd.ExecuteNonQueryAsync();
        }


        public int ExecuteNonQuery(SqlCommand cmd)
        {
            openConnection();

            cmd.Connection = cnn;
            return cmd.ExecuteNonQuery();
        }
        ~DataProvider()
        {
            
        }
       
    }
}