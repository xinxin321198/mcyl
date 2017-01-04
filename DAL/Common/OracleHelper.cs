using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using System.Configuration;
using System.Transactions;
namespace DAL.Common
{
    public class OracleHelper
    {
        private static string connectionString = Model.Common.AppConfigHelper.GetConnectionStringsConfig("oracleConnection");//从配置文件中读取数据库连接字符串

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

        public static OracleConnection getConnection()
        {
            return new OracleConnection(connectionString);
        }

        /// <summary>
        /// 执行一个非查询sql命令，返回影响的行数(淘汰)
        /// </summary>
        /// <param Name="sql"></param>
        /// <returns></returns>
        //public static int ExecuteNonQuery(string sql, params OracleParameter[] parameters)
        //{
        //    using (OracleConnection con = new OracleConnection(connectionString))
        //    {
        //        if (con.State != ConnectionState.Open)
        //        {
        //            con.Open();
        //        }
        //        using (OracleCommand cmd = con.CreateCommand())
        //        {
        //            cmd.CommandText = sql;
        //            cmd.Parameters.AddRange(parameters);
        //            int result = cmd.ExecuteNonQuery();
        //            return result;
        //        }
        //    }
        //}

        /// <summary>
        /// 执行一个非查询命令，返回影响行数（供事务使用时请传入OracleConnection对象；如果不传入，方法自动创建OracleConnection对象）
        /// 如果使用事务，请使用同一个OracleConnection对象
        /// </summary>
        /// <param Name="sql"></param>
        /// <param Name="con">连接对象</param>
        /// <param Name="parameters"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql,OracleConnection con, params OracleParameter[] parameters)
        {
            if (null == con)//如果连接对象为空，就新建一个连接对象
            {
                using (con = OracleHelper.getConnection())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.Parameters.AddRange(parameters);
                        int result = cmd.ExecuteNonQuery();
                        return result;
                    }
                }
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                using (OracleCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    int result = cmd.ExecuteNonQuery();
                    return result;
                }
            }
                
            
          }


        /// <summary>
        /// 执行一个批量的非查询命令，返回影响行数（供事务使用时请传入OracleConnection对象；如果不传入，方法自动创建OracleConnection对象并且自动使用事务）
        /// 如果使用事务，请使用同一个OracleConnection对象
        /// </summary>
        /// <param Name="sql"></param>
        /// <param Name="con">连接对象</param>
        /// <param Name="parameters"></param>
        /// <returns></returns>
        public static int ExecuteBatch(string sql, OracleConnection con, int bingCount, params OracleParameter[] parameters)
        {
            if (null == con)//如果连接对象为空，就新建一个连接对象，并且使用事务
            {
                using (TransactionScope ts = new TransactionScope())//创建一个事务对象
                {
                    using (con = OracleHelper.getConnection())
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        using (OracleCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandText = sql;
                            cmd.ArrayBindCount = bingCount;
                            cmd.BindByName = true;
                            cmd.CommandTimeout = 600;//10分钟
                            cmd.Parameters.AddRange(parameters);
                            int result = cmd.ExecuteNonQuery();
                            if (bingCount == result)
                            {
                                ts.Complete();
                            }
                            return result;
                        }
                    }
                }
            }
            else//如果不为空，就执行操作
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                using (OracleCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.ArrayBindCount = bingCount;
                    cmd.BindByName = true;
                    cmd.CommandTimeout = 600;//10分钟
                    cmd.Parameters.AddRange(parameters);
                    int result  = cmd.ExecuteNonQuery();
                    return result;
                }
            }
  
            
        }


        /// <summary>
        /// 执行查询，返回结果集中的第一行第一列数据
        /// </summary>
        /// <param Name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params OracleParameter[] parameters)
        {
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                using (OracleCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    object result = cmd.ExecuteScalar();
                    return result;
                }
            }
        }


        /// <summary>
        /// 返回一个结果集
        /// </summary>
        /// <param Name="sql"></param>
        /// <param Name="prarameters"></param>
        /// <returns></returns>
        public static DataSet getDataSet(string sql, params OracleParameter[] prarameters)
        {


            DataSet ds = new DataSet();
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                using (OracleCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    //foreach (OracleParameter param in prarameters)//遍历参数，防sql注入
                    //{
                    //    cmd.Parameters.Add(param);
                    //}
                    cmd.Parameters.AddRange(prarameters);
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    adapter.Fill(ds);
                }
            }
            return ds;
            
        }



        /// <summary>
        /// 检查是否存在
        /// </summary>
        /// <param Name="strSql">Sql语句</param>
        /// <param Name="cmdParms">参数</param>
        /// <returns>bool结果</returns>
        public static bool Exists(string sql, params OracleParameter[] cmdParms)
        {
            int cmdresult = Convert.ToInt32(OracleHelper.ExecuteScalar(sql));
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
