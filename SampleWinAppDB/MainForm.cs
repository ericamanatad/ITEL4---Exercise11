using SampleWinAppDB.Database;
using SampleWinAppDB.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SampleWinAppDB
{
    public partial class MainForm : Form
    {
        private DBConnect dbconnect;
        DepartmentDetails departmentDetails;
        MainForm mainForm;
        College c;

        public MainForm()
        {
            InitializeComponent();
            //create an instance of DB context
            dbconnect = new DBConnect("localhost", 3306, "root", "", "college_departmentdb");
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //attempt to establish DB server connectivity
                if (dbconnect.Connect())
                    MessageBox.Show("Connected to DB server successfully!", "Test App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cound not connect to DB server!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayRecords();
            if (CtxMenuStripCollegeList.Name == "CtxMenuStripCollegeList")
            {
                CtxMenuStripCollegeList.Items[1].Enabled = false;        //disable Update menu item
                CtxMenuStripCollegeList.Items[2].Enabled = false;        //disable Delete menu item
            }
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (BtnAdd.Text == "Add College") {
                //load/show Add/Edit Form
                AddEditCollegeForm collegeForm = new AddEditCollegeForm(dbconnect, null);
                //update form label
                collegeForm.Text = "Add College Record";
                collegeForm.ShowDialog();
            }
        }

        private void DisplayRecords()
        {
                List<College> collegeRecords = new List<College>();
                try
                {
                    //get college records
                    collegeRecords = dbconnect.GetCollegeRecords();

                // Clear the ListView only if it already contains items
                if (LsvCollege.Items.Count > 0)
                {
                    LsvCollege.Items.Clear();
                }
                //populate records to the listview
                for (int i = 0; i < collegeRecords.Count; i++)
                    {
                        c = collegeRecords[i];
                        //display college record to the listview
                        LsvCollege.Items.Add(c.CollegeID.ToString());
                        LsvCollege.Items[i].SubItems.Add(c.CollegeName);
                        LsvCollege.Items[i].SubItems.Add(c.CollegeCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void RefreshRecords_Click(object sender, EventArgs e)
        {
            //clear ListView
            //LsvCollege.Items.Clear();
            DisplayRecords();
        }

        private void UpdateRecord_Click(object sender, EventArgs e)
        {
            //check if there is a record selected from the listview
            if (LsvCollege.SelectedItems.Count > 0)
            {
                    // Updating college record
                    string collegeID = LsvCollege.SelectedItems[0].Text;
                    string collegeName = LsvCollege.SelectedItems[0].SubItems[1].Text;
                    string collegeCode = LsvCollege.SelectedItems[0].SubItems[2].Text;
                    int id = Convert.ToInt32(collegeID);
                    College collegeToUpdate = new College(id, collegeName, collegeCode, true);
                    AddEditCollegeForm collegeForm = new AddEditCollegeForm(dbconnect, collegeToUpdate);
                    collegeForm.Text = "Update Record";
                    collegeForm.ShowDialog();
            }
            LsvCollege.Items.Clear();
            DisplayRecords();
        }

        private void LsvCollege_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (LsvCollege.SelectedItems.Count > 0)
            {
                CtxMenuStripCollegeList.Items[1].Enabled = true;        //enable Update menu item
                CtxMenuStripCollegeList.Items[2].Enabled = true;        //enable Delete menu item
            }
            else
            {
                CtxMenuStripCollegeList.Items[1].Enabled = false;        //disable Update menu item
                CtxMenuStripCollegeList.Items[2].Enabled = false;        //disable Delete menu item
            }
        }

        private void DeactivateRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //check if there is a record selected from the listview
                if (LsvCollege.SelectedItems.Count > 0)
                {
                    //get the current selected college record
                    string collegeID = LsvCollege.SelectedItems[0].Text;
                    string collegeName = LsvCollege.SelectedItems[0].SubItems[1].Text;
                    //MessageBox.Show("ID: " + collegeID + " Name: " + collegeName);
                    int id = Convert.ToInt32(collegeID);
                    DialogResult confirmResult = MessageBox.Show("Are you sure to delete " + collegeName + "?", "Deactivate Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        bool status = dbconnect.DeactivateCollegeRecord(id);
                        if (status)
                            MessageBox.Show("Record deactivated successfully!", "Test App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Could not deactivate record!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LsvCollege.Items.Clear();
                DisplayRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ViewDepartments_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VIEW DEPARTMENT RECORDS RECORDS");
            if (LsvCollege.SelectedItems.Count > 0)
            {
                //get the current selected college record
                string collegeID = LsvCollege.SelectedItems[0].Text;
                //string collegeName = LsvCollege.SelectedItems[0].SubItems[1].Text;
               // string collegeCode = LsvCollege.SelectedItems[0].SubItems[2].Text;

                //MessageBox.Show("ID: " + collegeID + " Name: " + collegeName);
                int id = Convert.ToInt32(collegeID);
                MessageBox.Show("collegeID : " + collegeID); 

               if (dbconnect != null)
                {
                    mainForm = new MainForm();
                    mainForm.Hide();
                    DepartmentDetails departmentDetails = new DepartmentDetails(dbconnect, id);
                    departmentDetails.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Database connection is not established. Cannot open DepartmentDetails Form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                /*
                this.Name = "Department Details";
                this.Text = "Department Details";
                LsvCollege.Name = "LsvDepartment";
                LsvCollege.ContextMenuStrip.Name = "CtxMenuStripDepartmentList";
                columnHeader1.Text = "Department ID";
                columnHeader2.Text = "Department Name";
                columnHeader3.Text = "Department Code";
                title.Text = "DEPARTMENT DETAILS";
                LsvCollege.Items.Clear();
                BtnBack.Visible = true;

                //changing text buttons
                BtnAdd.Text = "Add Department";

                */


            }


        }

        private void BtnViewDepartments_Click(object sender, EventArgs e)
        {
            DepartmentDetails departmentDetails = new DepartmentDetails();
            departmentDetails.ShowDialog();
        }
        /*
private void BtnBack_Click(object sender, EventArgs e)
{
   LsvCollege.Name = "LsvCollege";
   this.Name = "College Details";
   this.Text = "College Details";
   LsvCollege.Name = "LsvCollege";
   LsvCollege.ContextMenuStrip.Name = "CtxMenuStripCollegetList";
   columnHeader1.Text = "College ID";
   columnHeader2.Text = "College Name";
   columnHeader3.Text = "College Code";
   title.Text = "COLLEGE DETAILS";
   LsvCollege.Items.Clear();
   DisplayRecords();
   BtnAdd.Text = "Add College";
}
*/
    }
}