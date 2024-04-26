
namespace SampleWinAppDB
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LsvCollege = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CtxMenuStripCollegeList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.DeactivateRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewDepartments = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.CtxMenuStripDepartmentList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshDepartmentRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateDepartmentRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.DeactivateCollegeRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxMenuStripCollegeList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CtxMenuStripDepartmentList.SuspendLayout();
            this.SuspendLayout();
            // 
            // LsvCollege
            // 
            this.LsvCollege.BackColor = System.Drawing.Color.Azure;
            this.LsvCollege.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LsvCollege.ContextMenuStrip = this.CtxMenuStripCollegeList;
            this.LsvCollege.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvCollege.FullRowSelect = true;
            this.LsvCollege.HideSelection = false;
            this.LsvCollege.Location = new System.Drawing.Point(46, 93);
            this.LsvCollege.Margin = new System.Windows.Forms.Padding(2);
            this.LsvCollege.MultiSelect = false;
            this.LsvCollege.Name = "LsvCollege";
            this.LsvCollege.Size = new System.Drawing.Size(682, 175);
            this.LsvCollege.TabIndex = 0;
            this.LsvCollege.UseCompatibleStateImageBehavior = false;
            this.LsvCollege.View = System.Windows.Forms.View.Details;
            this.LsvCollege.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvCollege_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "College ID";
            this.columnHeader1.Width = 161;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "College Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 303;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "College Code";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 259;
            // 
            // CtxMenuStripCollegeList
            // 
            this.CtxMenuStripCollegeList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CtxMenuStripCollegeList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshRecords,
            this.UpdateRecord,
            this.DeactivateRecord,
            this.ViewDepartments});
            this.CtxMenuStripCollegeList.Name = "contextMenuStrip1";
            this.CtxMenuStripCollegeList.Size = new System.Drawing.Size(171, 92);
            // 
            // RefreshRecords
            // 
            this.RefreshRecords.Name = "RefreshRecords";
            this.RefreshRecords.Size = new System.Drawing.Size(170, 22);
            this.RefreshRecords.Text = "Refresh";
            this.RefreshRecords.Click += new System.EventHandler(this.RefreshRecords_Click);
            // 
            // UpdateRecord
            // 
            this.UpdateRecord.Name = "UpdateRecord";
            this.UpdateRecord.Size = new System.Drawing.Size(170, 22);
            this.UpdateRecord.Text = "Update";
            this.UpdateRecord.Click += new System.EventHandler(this.UpdateRecord_Click);
            // 
            // DeactivateRecord
            // 
            this.DeactivateRecord.Name = "DeactivateRecord";
            this.DeactivateRecord.Size = new System.Drawing.Size(170, 22);
            this.DeactivateRecord.Text = "Delete";
            this.DeactivateRecord.Click += new System.EventHandler(this.DeactivateRecord_Click);
            // 
            // ViewDepartments
            // 
            this.ViewDepartments.Name = "ViewDepartments";
            this.ViewDepartments.Size = new System.Drawing.Size(170, 22);
            this.ViewDepartments.Text = "View Departments";
            this.ViewDepartments.Click += new System.EventHandler(this.ViewDepartments_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAdd.Location = new System.Drawing.Point(606, 284);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(122, 44);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add College";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(319, 369);
            this.BtnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(145, 24);
            this.BtnConnect.TabIndex = 2;
            this.BtnConnect.Text = "Test DB Connection";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 53);
            this.panel1.TabIndex = 3;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe Fluent Icons", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(263, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(249, 32);
            this.title.TabIndex = 0;
            this.title.Text = "COLLEGE DETAILS";
            // 
            // CtxMenuStripDepartmentList
            // 
            this.CtxMenuStripDepartmentList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshDepartmentRecords,
            this.UpdateDepartmentRecord,
            this.DeactivateCollegeRecord});
            this.CtxMenuStripDepartmentList.Name = "CtxMenuStripDepartmentList";
            this.CtxMenuStripDepartmentList.Size = new System.Drawing.Size(114, 70);
            this.CtxMenuStripDepartmentList.Text = "COLLEGE";
            // 
            // RefreshDepartmentRecords
            // 
            this.RefreshDepartmentRecords.Name = "RefreshDepartmentRecords";
            this.RefreshDepartmentRecords.Size = new System.Drawing.Size(113, 22);
            this.RefreshDepartmentRecords.Text = "Refresh";
            // 
            // UpdateDepartmentRecord
            // 
            this.UpdateDepartmentRecord.Name = "UpdateDepartmentRecord";
            this.UpdateDepartmentRecord.Size = new System.Drawing.Size(113, 22);
            this.UpdateDepartmentRecord.Text = "Update";
            // 
            // DeactivateCollegeRecord
            // 
            this.DeactivateCollegeRecord.Name = "DeactivateCollegeRecord";
            this.DeactivateCollegeRecord.Size = new System.Drawing.Size(113, 22);
            this.DeactivateCollegeRecord.Text = "Delete";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LsvCollege);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College Details";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.CtxMenuStripCollegeList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CtxMenuStripDepartmentList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LsvCollege;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ContextMenuStrip CtxMenuStripCollegeList;
        private System.Windows.Forms.ToolStripMenuItem RefreshRecords;
        private System.Windows.Forms.ToolStripMenuItem UpdateRecord;
        private System.Windows.Forms.ToolStripMenuItem DeactivateRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ToolStripMenuItem ViewDepartments;
        private System.Windows.Forms.ContextMenuStrip CtxMenuStripDepartmentList;
        private System.Windows.Forms.ToolStripMenuItem RefreshDepartmentRecords;
        private System.Windows.Forms.ToolStripMenuItem UpdateDepartmentRecord;
        private System.Windows.Forms.ToolStripMenuItem DeactivateCollegeRecord;
    }
}

