using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Student.DTO;
using System.Windows;

namespace Student.DAL
{ 
    class SqlHelper
    {

          public SqlConnection con = null;
          static string constr = @"Data Source=AVANTIKA-PC\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";
          public static string ConnectionString{ get; set; } 
          SqlCommand com;
          public List<SqlParameter> parameters = new List<SqlParameter>();
           
          public SqlHelper()
          {
           ConnectionString = constr;
           con = new SqlConnection(ConnectionString);
           
          }

        public void InsertTable(AdminDetails admindetails,string query , bool isStoreProcedure )
        {
            try
            {

                con.Open();
                com = new SqlCommand(query, con);
                com.Parameters.Add("@adminname", SqlDbType.NVarChar).Value = admindetails.AdminName;
                com.Parameters.Add("@password", SqlDbType.NVarChar).Value = admindetails.AdminPassword;
                com.Parameters.Add("@schoolid", SqlDbType.Int).Value = admindetails.SchoolId;


                if (isStoreProcedure)
                {
                    com.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    com.CommandType = CommandType.Text;
                }
                com.ExecuteNonQuery();
                
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error inside SqlHelper class in NonQuery as {0}",ex.Message);
            }
            finally
            {
                con.Close();
                //com.Parameters.Clear();
                // parameters.Clear();
            }
          
        }

        public void InsertData(StudentForm studentform, string query, bool isStoreProcedure, string studentname, int schoolid)
        {
            try
            {

                con.Open();
                com = new SqlCommand(query, con);
                com.Parameters.Add("@schoolid", SqlDbType.Int).Value = schoolid;
                com.Parameters.Add("@password", SqlDbType.NVarChar).Value = studentform.StudentPassword;
                com.Parameters.Add("@address", SqlDbType.NVarChar).Value = studentform.StudentAddress;
                com.Parameters.Add("@phone", SqlDbType.NVarChar).Value = studentform.StudentPhone;
                com.Parameters.Add("@gender", SqlDbType.NVarChar).Value = studentform.StudentGender;

                com.Parameters.Add("@studentname", SqlDbType.NVarChar).Value = studentname;

                if (isStoreProcedure)
                {
                    com.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    com.CommandType = CommandType.Text;
                }
                com.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error inside SqlHelper class in NonQuery as {0}", ex.Message);
            }
            finally
            {
                con.Close();
                //com.Parameters.Clear();
                // parameters.Clear();
            }

        }

        public void UpdateData(StudentForm studentform, string query, bool isStoreProcedure, string studentname, int schoolid)
        {
            try
            {
                con.Open();
                com = new SqlCommand(query, con);
           //     com.Parameters.Add("@schoolid", SqlDbType.Int).Value = schoolid;
                com.Parameters.Add("@password", SqlDbType.NVarChar).Value = studentform.StudentPassword;
                com.Parameters.Add("@address", SqlDbType.NVarChar).Value = studentform.StudentAddress;
                com.Parameters.Add("@phone", SqlDbType.NVarChar).Value = studentform.StudentPhone;
                com.Parameters.Add("@gender", SqlDbType.NVarChar).Value = studentform.StudentGender;
                com.Parameters.Add("@studentname", SqlDbType.NVarChar).Value = studentname;
                if (isStoreProcedure)
                {
                    com.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    com.CommandType = CommandType.Text;
                }
                com.ExecuteNonQuery();
             
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error inside SqlHelper class in NonQuery as {0}", ex.Message);
            }
            finally
            {
                con.Close();
                //com.Parameters.Clear();
                // parameters.Clear();
            }
        }

        public void DeleteTable(string query, bool isStoreProcedure)
        {
            com = new SqlCommand(query, con);

            if (parameters.Count > 0)
            {
                com.Parameters.AddRange(parameters.ToArray());
            }

            if (isStoreProcedure)
            {
                com.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                com.CommandType = CommandType.Text;
            }
            com.ExecuteNonQuery();
            com.Parameters.Clear();
           // parameters.Clear();
        }



        public void BuildParmeters(string paramName, SqlDbType dbtype, String paramDirection, object value)
        {
           
            try
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = paramName;
                param.Value = value;
                param.SqlDbType = dbtype;
      
                switch (paramDirection)
                {
                    case "in":
                        param.Direction = ParameterDirection.Input;
                        break;
                    case "out":
                        param.Direction = ParameterDirection.Output;
                        break;
                    case "inout":
                        param.Direction = ParameterDirection.InputOutput;
                        break;
                    default:
                        param.Direction = ParameterDirection.Input;
                        break;
                }
                // Add Sql Parameters in Sql Parameters list
                parameters.Add(param);
            }
            catch (Exception e1)
            {
                System.Diagnostics.Debug.WriteLine("Error inside SqlHelper class in BuildParameter as {0}", e1.Message);
            }
        }


      
        public DataTable show(string query,string studentname)
        {
            
            com = new SqlCommand(query,con);
            com.Parameters.Add("@studentname", SqlDbType.NVarChar).Value = studentname;
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable db = new DataTable();
            sda.Fill(db);
            com.Parameters.Clear();
            return db;
        }


        public DataTable showUserReport(string query, int schoolid)
        {

            com = new SqlCommand(query, con);
            com.Parameters.Add("@schoolid", SqlDbType.Int).Value = schoolid;
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable db = new DataTable();
            sda.Fill(db);

            com.Parameters.Clear();
            return db;
        }
       public int GetId(LoginDetails login,string query)
        {
             com = new SqlCommand(query, con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@username", SqlDbType.NVarChar).Value = login.name;
            com.Parameters.Add("@password", SqlDbType.NVarChar).Value = login.password;
            com.Parameters.Add("@schoolid", SqlDbType.Int).Value = login.schoolid;
            con.Open();
            int q = (int)com.ExecuteScalar();
            con.Close();
          
            return q;
           
        }

         public int ValidateUserType(LoginDetails login,string query)
         {
            
             
            com = new SqlCommand(query, con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@username", SqlDbType.NVarChar).Value = login.name;
            com.Parameters.Add("@password", SqlDbType.NVarChar).Value = login.password;
            com.Parameters.Add("@schoolid", SqlDbType.Int).Value = login.schoolid;
            con.Open();
            int count = (int)com.ExecuteScalar();

            con.Close();
            if (count > 0)
                return 1;
            else
                return 0;
        }


        public void UpdateAdminPasssword(AdminInformation admin,string name,int schoolid,string query, bool isStoreProcedure)
         {
               try
            {
                con.Open();
                com = new SqlCommand(query, con);
                com.Parameters.Add("@schoolid", SqlDbType.Int).Value = schoolid;
                com.Parameters.Add("@password", SqlDbType.NVarChar).Value = admin.AdminPassword;
              
                com.Parameters.Add("@sname", SqlDbType.NVarChar).Value = name;
                
                if (isStoreProcedure)
                {
                    com.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    com.CommandType = CommandType.Text;
                }
                com.ExecuteNonQuery();
             
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error inside SqlHelper class in NonQuery as {0}", ex.Message);
            }
            finally
            {
                con.Close();
                //com.Parameters.Clear();
                // parameters.Clear();
            }
         }

        public void AddStudent(AdminInformation admin,int schoolid,string query,bool isStoreProcedure)
        {
            try{
               con.Open();
                com = new SqlCommand(query, con);
                com.Parameters.Add("@schoolid", SqlDbType.NVarChar).Value = schoolid;
                com.Parameters.Add("@password", SqlDbType.NVarChar).Value = admin.StudentPassword;
              
                com.Parameters.Add("@studentname", SqlDbType.NVarChar).Value = admin.StudenName;

                if (isStoreProcedure)
                {
                    com.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    com.CommandType = CommandType.Text;
                }
                com.ExecuteNonQuery();
            
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error inside SqlHelper class in NonQuery as {0}", ex.Message);
            }
            finally
            {
                con.Close();
                //com.Parameters.Clear();
                // parameters.Clear();
            }

        }

    }
}

