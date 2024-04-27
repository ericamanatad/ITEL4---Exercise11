using CollegeDepartmentWinApp.Database;
using CollegeDepartmentWinApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeDepartmentWinApp
{
    public partial class AddEditDepartmentForm : Form
    {

        private DBConnect dbconnect;
        private Department toUpdate;
        private int chosenCollegeID;
        DepartmentDetails departmentDetails;

        public int selectedCollegeID { get; set; }

        public AddEditDepartmentForm() { 
        }
        public AddEditDepartmentForm(DBConnect dbconnect, Department toUpdate)
        {
            InitializeComponent();
            this.dbconnect = dbconnect;
            this.toUpdate = toUpdate;
            //update button label
            if (this.toUpdate != null)
                BtnAddEdit.Text = "Update";
            else
                BtnAddEdit.Text = "Save";
        }

        public AddEditDepartmentForm(DBConnect dbconnect, Department toUpdate, int selectedCollegeID) : this(dbconnect, toUpdate)
        {
            this.selectedCollegeID = selectedCollegeID;
        }

        public void Clear (){
            txtDepName.Text = txtDepCode.Text = string.Empty;
        }

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            try
            {
               
                bool status = false;
                Department department = new Department();
                College college = new College();
                //get the inputs from the form
                department.depName = txtDepName.Text.Trim();
                department.depCode = txtDepCode.Text.Trim();
                int GetChosenCollegeID(int collegeID)
                {
                    chosenCollegeID = selectedCollegeID;
                    return chosenCollegeID;
                }
                //chosenCollegeID = college.CollegeID;
                //MessageBox.Show("chosenCollegeID = college.CollegeID  in  BtnAddEdit_Click of AddEditDepartmentForm: " + chosenCollegeID);

                //validate inputs
                if (!string.IsNullOrEmpty(department.depName) && !string.IsNullOrEmpty(department.depCode))
                {
                    if (toUpdate == null)
                    {
                        //add college record
                        departmentDetails = new DepartmentDetails();
                        status = dbconnect.AddDepartmentRecords(department, college, GetChosenCollegeID(chosenCollegeID));
                        if (status)
                        {
                            MessageBox.Show("Record added successfully!", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                            MessageBox.Show("Could not add record!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //update college record
                        department.depID = toUpdate.depID;
                        status = dbconnect.UpdateDepartmentRecords(department);
                        if (status)
                        {
                            MessageBox.Show("Record updated successfully!", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //close current form
                            Close();

                        }
                        else
                            MessageBox.Show("Could not update record!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Please complete the form!", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEditDepartmentForm_Load(object sender, EventArgs e)
        {
            //load form with college record during update
            if (toUpdate != null)
            {
                txtDepName.Text = toUpdate.depName;
                txtDepCode.Text = toUpdate.depCode;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
