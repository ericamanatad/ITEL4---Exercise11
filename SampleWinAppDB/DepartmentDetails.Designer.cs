namespace SampleWinAppDB
{
    partial class DepartmentDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LsvDepartment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CtxMenuStripDepartmentList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.DeactivateRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.CtxMenuStripDepartmentList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEPARTMENT DETAILS";
            // 
            // LsvDepartment
            // 
            this.LsvDepartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LsvDepartment.ContextMenuStrip = this.CtxMenuStripDepartmentList;
            this.LsvDepartment.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvDepartment.FullRowSelect = true;
            this.LsvDepartment.HideSelection = false;
            this.LsvDepartment.Location = new System.Drawing.Point(42, 96);
            this.LsvDepartment.Name = "LsvDepartment";
            this.LsvDepartment.Size = new System.Drawing.Size(605, 187);
            this.LsvDepartment.TabIndex = 1;
            this.LsvDepartment.UseCompatibleStateImageBehavior = false;
            this.LsvDepartment.View = System.Windows.Forms.View.Details;
            this.LsvDepartment.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LsvDepartment_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Department ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Department Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Department Code";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // CtxMenuStripDepartmentList
            // 
            this.CtxMenuStripDepartmentList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshRecords,
            this.UpdateRecord,
            this.DeactivateRecord});
            this.CtxMenuStripDepartmentList.Name = "CMSDepartmentList";
            this.CtxMenuStripDepartmentList.Size = new System.Drawing.Size(114, 70);
            // 
            // RefreshRecords
            // 
            this.RefreshRecords.Name = "RefreshRecords";
            this.RefreshRecords.Size = new System.Drawing.Size(180, 22);
            this.RefreshRecords.Text = "Refresh";
            this.RefreshRecords.Click += new System.EventHandler(this.RefreshRecords_Click);
            // 
            // UpdateRecord
            // 
            this.UpdateRecord.Name = "UpdateRecord";
            this.UpdateRecord.Size = new System.Drawing.Size(180, 22);
            this.UpdateRecord.Text = "Update";
            this.UpdateRecord.Click += new System.EventHandler(this.UpdateRecord_Click);
            // 
            // DeactivateRecord
            // 
            this.DeactivateRecord.Name = "DeactivateRecord";
            this.DeactivateRecord.Size = new System.Drawing.Size(180, 22);
            this.DeactivateRecord.Text = "Delete";
            this.DeactivateRecord.Click += new System.EventHandler(this.DeactivateRecord_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(577, 302);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(70, 31);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(42, 289);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(106, 44);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Visible = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(328, 326);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 6;
            this.BtnConnect.Text = "Connect DB";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // DepartmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LsvDepartment);
            this.Controls.Add(this.panel1);
            this.Name = "DepartmentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentDetails";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.DepartmentDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CtxMenuStripDepartmentList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LsvDepartment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip CtxMenuStripDepartmentList;
        private System.Windows.Forms.ToolStripMenuItem RefreshRecords;
        private System.Windows.Forms.ToolStripMenuItem UpdateRecord;
        private System.Windows.Forms.ToolStripMenuItem DeactivateRecord;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label label2;
    }
}