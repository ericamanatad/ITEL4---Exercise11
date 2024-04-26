using SampleWinAppDB.Database;
using SampleWinAppDB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinAppDB
{
    public partial class AddEditDepartmentForm : Form
    {

        private DBConnect dbconnect;
        private Department toUpdate;
        private int chosenCollegeID;

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

        public void Clear (){
            txtDepName.Text = txtDepCode.Text = string.Empty;
        }

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            try
            {
                bool status = false;
                //get the inputs from the form
                Department department = new Department();
                College college = new College();

                department.depName = txtDepName.Text.Trim();
                department.depCode = txtDepCode.Text.Trim();
                //validate inputs
                if (!string.IsNullOrEmpty(department.depName) && !string.IsNullOrEmpty(department.depCode))
                {
                    if (toUpdate == null)
                    {
                        //add college record
                        status = dbconnect.AddDepartmentRecords(department, college);
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
                        //update college record
                        department.depID = toUpdate.depID;
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
                else
                    MessageBox.Show("Please complete the form!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
