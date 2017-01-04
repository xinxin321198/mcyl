using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace DAL.Common
{
    class sqlHelper
    {
        
        private static string connectionString = Model.Common.AppConfigHelper.GetConnectionStringsConfig("sqlServerConnection");//从配置文件中读取数据库连接字符串
        
        /// <summary>
        /// 表示数据库中的null值；
        /// 
        /// 插入时使用object类型插入
        /// object Name = DBNull.Vlue;
        /// insert into t_tablename values(@f_name);
        /// parameters.add(Name);
        /// 
        /// 查询数据时判断
        /// int? age;
        /// if(row["age"] ==DBNull.Value)
        /// {
        ///     age = null;
        /// }
        /// 
        /// </summary>
        public static DBNull dbNull = DBNull.Value;


        /// <summary>
        /// 执行一个非查询sql命令，返回影响的行数
        /// </summary>
        /// <param Name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql,params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 执行查询，返回结果集中的第一行第一列数据
        /// </summary>
        /// <param Name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql,params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }


        /// <summary>
        /// 返回一个结果集
        /// </summary>
        /// <param Name="sql"></param>
        /// <param Name="prarameters"></param>
        /// <returns></returns>
        public static DataSet getDataSet(string sql,params SqlParameter[] prarameters)
        {


            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    //foreach (SqlParameter param in prarameters)//遍历参数，防sql注入
                    //{
                    //    cmd.Parameters.Add(param);
                    //}
                    cmd.Parameters.AddRange(prarameters);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);
                }
            }
            return ds;
        }

        /// <summary>
        /// 批量插入大量数据
        /// </summary>
        /// <param Name="tableName"></param>
        /// <param Name="dt"></param>
        /// <param Name="columnMappings"></param>
        /// <returns></returns>
        public static double bulkInsert(string tableName,DataTable dt,params SqlBulkCopyColumnMapping[] columnMappings)
        {
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connectionString))
            {
                DateTime startTime = DateTime.Now;
                foreach (SqlBulkCopyColumnMapping columnMapping in columnMappings)
                {
                    bulkCopy.ColumnMappings.Add(columnMapping);
                }
                bulkCopy.DestinationTableName = tableName;
                bulkCopy.BatchSize = 5000;
                bulkCopy.WriteToServer(dt);

                TimeSpan ts =  DateTime.Now - startTime;
                double sumSeconds =  ts.TotalSeconds;//代表总秒数
                return sumSeconds;
            }
            
        }

        /// <summary>
        /// 检查是否存在
        /// </summary>
        /// <param Name="strSql">Sql语句</param>
        /// <param Name="cmdParms">参数</param>
        /// <returns>bool结果</returns>
        public static bool Exists(string sql, params SqlParameter[] cmdParms)
        {
            int cmdresult = Convert.ToInt32(sqlHelper.ExecuteScalar(sql));
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
