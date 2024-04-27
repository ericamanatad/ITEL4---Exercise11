using CollegeDepartmentWinApp.Database;
using CollegeDepartmentWinApp.Model;
using System;
using System.Windows.Forms;

namespace CollegeDepartmentWinApp
{
    public partial class AddEditCollegeForm : Form
    {
        private DBConnect dbconnect;
        private College toUpdate;
        private Department toBeUpdated;

        public AddEditCollegeForm(DBConnect dbconnect)
        {
            InitializeComponent();
        }

        public AddEditCollegeForm(DBConnect dbConnect, College toUpdate)
        {
            InitializeComponent();
            dbconnect = dbConnect;
            this.toUpdate = toUpdate;
            //update button label
            if(this.toUpdate != null)
                BtnAddEdit.Text = "Update";
            else
                BtnAddEdit.Text = "Add";
        }

        public AddEditCollegeForm(DBConnect dBconnect, Department toBeUpdated, int x )
        {
            InitializeComponent();
            labelCollegeName.Text = "Department Name :";
            labelCollegeCode.Text = "Department Code :";
            this.toBeUpdated = toBeUpdated;
            //update button label
            if (this.toBeUpdated != null)
                BtnAddEdit.Text = "Update Dep";
            else
                BtnAddEdit.Text = "Add Dep";
        }

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bool status = false;
                //get the inputs from the form
                College college = new College();
                college.CollegeName = TxtCollegeName.Text.Trim();
                college.CollegeCode = TxtCollegeCode.Text.Trim();

                //validate inputs

                //COLLEGE
                if (!string.IsNullOrEmpty(college.CollegeName) && !string.IsNullOrEmpty(college.CollegeCode))
                {
                    if (toUpdate == null)
                    {
                        //add college record
                        status = dbconnect.AddCollegeRecord(college);
                        if (status)
                        {
                            MessageBox.Show("Record added successfully!", "ADDITION STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                            MessageBox.Show("Could not add record!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {


                        //update college record
                        college.CollegeID = toUpdate.CollegeID;
                        status = dbconnect.UpdateCollegeRecord(college);
                        if (status)
                        {
                            MessageBox.Show("Record updated successfully!", "UPDATE STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //close current form
                            Close();
                        }
                        else
                            MessageBox.Show("Could not update record!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            /*          //DEPARTMENT

                      if (labelCollegeName.Text == "Department Name :" && labelCollegeCode.Text == "Department Code :")
                      {
                          Department department = new Department();
                          department.depName = TxtCollegeName.Text.Trim();
                          department.depCode = TxtCollegeCode.Text.Trim();

                          if (!string.IsNullOrEmpty(department.depName) && !string.IsNullOrEmpty(department.depCode))
                          {
                              if (toBeUpdated == null)
                              {
                                  //add department record
                                  status = dbconnect.AddDepartmentRecords(department);
                                  if (status)
                                  {
                                      MessageBox.Show("Record added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                      Close();
                                  }
                                  else
                                      MessageBox.Show("Could not add record!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              }
                              else
                              {
          //update department record
                                  department.depID = toBeUpdated.depID;
                                  status = dbconnect.UpdateDepartmentRecords(department);
                                  if (status)
                                  {
                                      MessageBox.Show("Record updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                      //close current form
                                      Close();

                                  }
                                  else
                                      MessageBox.Show("Could not update record!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              }
                          }
                      }
                      else
                          MessageBox.Show("Please complete the form!", "Test App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
            */
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCollegeName.Clear();
            TxtCollegeCode.Clear();
        }

        private void AddEditCollegeForm_Load(object sender, EventArgs e)
        {
            //load form with college record during update
            if (toUpdate != null)
            {
                TxtCollegeName.Text = toUpdate.CollegeName;
                TxtCollegeCode.Text = toUpdate.CollegeCode;
            }
        }

        
    }
}