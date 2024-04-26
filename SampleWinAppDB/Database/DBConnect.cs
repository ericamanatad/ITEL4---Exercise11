using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Ocsp;
using SampleWinAppDB.Model;

namespace SampleWinAppDB.Database
{
    public class DBConnect
    {
        private MySqlConnection conn;
        private string connectionString;
        private int id;
        private int chosenCollegeID;

        public MySqlConnection Conn { get => conn; set => conn = value; }
    
        public DBConnect()
        {
            conn = null;
        }

        public DBConnect(string dbServer, int portNo, string userID, string password, string db)
        {
            //setup connection string
            //server=localhost;port=3306;userid=root;password=xxxx;database=yyyyy
            connectionString = "server=" + dbServer + ";port=" + portNo + ";userid=" + userID + ";password=" + password + ";database=" + db;
        }

        public bool Connect()
        {
            //create MySQL connection
            conn = new MySqlConnection(connectionString);
            try
            {
                //open MySQL connection
                conn.Open();
                return (conn != null);
            }
            catch(MySqlException ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
            catch(Exception ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
        }

        public List<College> GetCollegeRecords()
        {
            //create college list
            List<College> collegeRecords = new List<College>();
            try
            {
                //establish DB server connection
                if (Connect())
                {
                    string query = "SELECT * FROM College WHERE IsActive=1";
                    //create MySQL command with the corresponding query string and connection
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    //create MySQL data reader
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //check if there any records
                    if (reader.HasRows)
                    {
                        //get the records
                        while (reader.Read())
                        {
                            //get CollegeID
                            int collegeID = reader.GetInt32(0);
                            //get CollegeName
                            string collegeName = reader.GetString(1);
                            //get CollegeCode
                            string collegeCode = reader.GetString(2);
                            //get IsActive
                            bool isActive = reader.GetBoolean(3);
                            //create College Model
                            College college = new College(collegeID, collegeName, collegeCode, isActive);
                            collegeRecords.Add(college);
                        }
                    }

                    //close DB objects
                    reader.Close();
                    cmd.Dispose();
                    conn.Close();
                }

                return collegeRecords;
            }
            catch (MySqlException ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
        }

        //college parameter contains the record to add
        public bool AddCollegeRecord(College college)
        {
            bool status = false;
            try
            {
                //establish DB server connection
                if (Connect())
                {
                    //INSERT INTO College(CollegeName,CollegeCode) VALUES('School of Education','SOE');
                    string query = "INSERT INTO College(CollegeName,CollegeCode) VALUES('"+college.CollegeName+"','"+college.CollegeCode+"');";
                    //create MySQL command with the corresponding query string and connection
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    //create MySQL data reader
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //check if a new record has been added
                    if (reader.RecordsAffected > 0)
                        status = true;
                    //close DB objects
                    reader.Close();
                    cmd.Dispose();
                    conn.Close();
                }

                return status;
            }
            catch (MySqlException ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
        }

        //college parameter contains the record to update
        public bool UpdateCollegeRecord(College college)
        {
            bool status = false;
            try
            {
                //establish DB server connection
                if (Connect())
                {
                    //UPDATE College SET CollegeName='School of Nursing and Healtcare',CollegeCode='SONH' WHERE CollegeID=4;
                    string query = "UPDATE College SET CollegeName='" + college.CollegeName + "',CollegeCode='" + college.CollegeCode + "' WHERE CollegeID=" + college.CollegeID + ";";
                    //create MySQL command with the corresponding query string and connection
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    //create MySQL data reader
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //check if a new record has been updated
                    if (reader.RecordsAffected > 0)
                        status = true;
                    //close DB objects
                    reader.Close();
                    cmd.Dispose();
                    conn.Close();
                }

                return status;
            }
            catch (MySqlException ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
        }

        //collegeID parameter contains the record to deactivate
        public bool DeactivateCollegeRecord(int collegeID)
        {
            bool status = false;
            try
            {
                //establish DB server connection
                if (Connect())
                {
                    //UPDATE College SET IsActive=0 WHERE CollegeID=4;
                    string query = "UPDATE College SET IsActive=0 WHERE CollegeID=" + collegeID + ";";
                    //create MySQL command with the corresponding query string and connection
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    //create MySQL data reader
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //check if a new record has been updated
                    if (reader.RecordsAffected > 0)
                        status = true;
                    //close DB objects
                    reader.Close();
                    cmd.Dispose();
                    conn.Close();
                }

                return status;
            }
            catch (MySqlException ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
        }
        //department

        public List<Department> GetDepartmentRecords(int collegeID)
        {
            //create college list
            List<Department> departmentRecords = new List<Department>();
            try
            {
                //establish DB server connection
                if (Connect())
                {
                   // depID, depName, depCode, CollegeID
                    string query = "SELECT * FROM `department` WHERE IsActive = 1 AND CollegeID = " + collegeID +  ";";
                    //create MySQL command with the corresponding query string and connection
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    //create MySQL data reader
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //check if there any records
                    if (reader.HasRows)
                    {
                        //get the records
                        while (reader.Read())
                        {

                            int departmentID = reader.GetInt32(0);

                            string departmentName = reader.GetString(1);

                            string departmnentCode = reader.GetString(2);

                            bool isActive = reader.GetBoolean(3);


                            Department department = new Department(departmentID, departmentName, departmnentCode, isActive, collegeID);
                            departmentRecords.Add(department);


                        }
                    }


                    reader.Close();
                    cmd.Dispose();
                    conn.Close();
                }

                return departmentRecords;
            }
            catch (MySqlException ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
        }
        /*
         
         */


        public bool AddDepartmentRecords(Department department, College college)
        {
            DBConnect chosenCollegeID = new DBConnect();
            bool status = false;
            try
            {
                //establish DB server connection
                if (Connect())
                {
                    string query = "INSERT INTO department(depName, depCode, collegeID) VALUES("+ department.depName + ", " + department.depName + ", (SELECT CollegeID FROM college WHERE collegeName ="+ college.CollegeName + "))";
                    MessageBox.Show("QUERY : " +query);

                   /* string query = "INSERT INTO department(depName,depCode, IsActive, CollegeID) VALUES('"
                                   + department.depName
                                   + "','"
                                   + department.depCode
                                   + ","
                                   + department.IsActive
                                   + ","
                                   + college.CollegeID
                                   + "');";*/
                    MessageBox.Show(query);
                    //create MySQL command with the corresponding query string and connection
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    //create MySQL data reader
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //check if a new record has been added
                    if (reader.RecordsAffected > 0)
                        status = true;
                    //close DB objects
                    reader.Close();
                    cmd.Dispose();
                    conn.Close();
                }

                return status;
            }
            catch (MySqlException ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
        }

        //college parameter contains the record to update
        public bool UpdateDepartmentRecords(Department department)
        {
            bool status = false;
            try
            {
                //establish DB server connection
                if (Connect())
                {

                    string query = "UPDATE department SET depName='" + department.depName + "',depCode='" + department.depCode + "' WHERE depID=" + department.depID + ";";
                    //create MySQL command with the corresponding query string and connection
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    //create MySQL data reader
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //check if a new record has been updated
                    if (reader.RecordsAffected > 0)
                        status = true;
                    //close DB objects
                    reader.Close();
                    cmd.Dispose();
                    conn.Close();
                }

                return status;
            }
            catch (MySqlException ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
        }


        public bool DeleteDepartmentRecords(int departmentID)
        {
            bool status = false;
            try
            {
                //establish DB server connection
                if (Connect())
                {

                    string query = "UPDATE department SET IsActive=0 WHERE depID=" + departmentID + ";";
                    //create MySQL command with the corresponding query string and connection
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    //create MySQL data reader
                    MySqlDataReader reader = cmd.ExecuteReader();
                    //check if a new record has been updated
                    if (reader.RecordsAffected > 0)
                        status = true;
                    //close DB objects
                    reader.Close();
                    cmd.Dispose();
                    conn.Close();
                }

                return status;
            }
            catch (MySqlException ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                //throw the exception
                throw new Exception(ex.Message);
            }
        }
    }
}
