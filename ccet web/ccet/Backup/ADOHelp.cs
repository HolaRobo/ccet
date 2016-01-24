using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace LabManage
{

    /// <summary>
    /// 数据访问抽象基础类
    /// Copyright (C) 2004-2011 By 
    /// </summary>
    public abstract class ADOHelp
    {
        //数据库连接字符串
        public static string connectionString = ConfigurationManager.ConnectionStrings["strConnectionString"].ConnectionString;
      
        public ADOHelp()
        {
        }

        #region  执行简单SQL语句

     


        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>		
        public static int ExecuteSqlTran(List<string> SQLStringList)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlTransaction tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    int count = 0;
                    for (int n = 0; n < SQLStringList.Count; n++)
                    {
                        string strsql = SQLStringList[n];
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                    return count;
                }
                catch
                {
                    tx.Rollback();
                    return 0;
                }
            }
        }

        /// <summary>
        /// 向数据库里插入图像格式的字段(和上面情况类似的另一种实例)
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="fs">图像字节,数据库的字段类型为image的情况</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSqlInsertImg(string strSQL, byte[] fs)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(strSQL, connection);
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@fs", SqlDbType.Image);
                myParameter.Value = fs;
                cmd.Parameters.Add(myParameter);
                try
                {
                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    System.Web.HttpContext.Current.Response.Write("发生错误,错误信息：" + e.Message);
                    throw e;
                   
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// 执行查询语句,返回结果集的第一行的第一列（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public static object GetSingle(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = cmd.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return 0;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行查询语句，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string strSQL)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(strSQL, connection);
                try
                {
                    connection.Open();
                    SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    return myReader;
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    throw e;
                   
                }
            }

        }
        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet QueryDataSet(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                    command.Fill(ds);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }
        /// <summary>
        /// 执行查询语句，返回DataTable
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataTable</returns>
        public static DataTable QueryDataTable(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                    command.Fill(dt);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);

                }
                return dt;
            }
        }

        /// <summary>
        /// 执行查询语句，返回DataTable
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataTable</returns>
        public static DataTable QueryDataSource(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();

                try
                {

                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                    command.Fill(dt);

                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);

                }
                return dt;
            }
        }

        #endregion
        #region 存储过程操作
        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql_ReturnRow(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (Exception ex)
                    {
                        System.Web.HttpContext.Current.Response.Write("发生错误,错误信息：" + ex.Message);
                        string s = ex.Message;
                       return -1;
                    }
                    finally
                    {
                         connection.Close();
                    }
                }
            }
        }

        #endregion




        #region
       /// <summary>
       /// 教师或管理员修改密码
       /// </summary>
       /// <param name="TeacherName"></param>
       /// <param name="OldPwd"></param>
       /// <param name="NewPwd"></param>
       /// <param name="Identity"></param>
        public static void ExecUpdateTeacherPwd(string TeacherName, string OldPwd, string NewPwd,string Identity, out int ReturnValue)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        connection.Open();
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "proc_UpdateTeacherAdminPwd";

                        cmd.Parameters.Add("@TeacherName", SqlDbType.NVarChar, 20);
                        cmd.Parameters["@TeacherName"].Value = TeacherName;

                        cmd.Parameters.Add("@OldPwd", SqlDbType.NVarChar, 20);
                        cmd.Parameters["@OldPwd"].Value = OldPwd;

                        cmd.Parameters.Add("@NewPwd", SqlDbType.NVarChar, 20);
                        cmd.Parameters["@NewPwd"].Value = NewPwd;

                        cmd.Parameters.Add("@Identity", SqlDbType.VarChar, 10);
                        cmd.Parameters["@Identity"].Value = Identity;
                        
                        cmd.Parameters.Add("@ReturnValue", SqlDbType.Int);
                        cmd.Parameters["@ReturnValue"].Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        ReturnValue = Convert.ToInt32(cmd.Parameters["@ReturnValue"].Value);
 
                    }
                    catch (Exception ex)
                    {
                        ReturnValue = 0;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        #endregion
       

    }
}
