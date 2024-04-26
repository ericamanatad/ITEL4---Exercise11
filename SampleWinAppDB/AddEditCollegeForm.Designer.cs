
namespace SampleWinAppDB
{
    partial class AddEditCollegeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditCollegeForm));
            this.labelCollegeName = new System.Windows.Forms.Label();
            this.labelCollegeCode = new System.Windows.Forms.Label();
            this.TxtCollegeName = new System.Windows.Forms.TextBox();
            this.TxtCollegeCode = new System.Windows.Forms.TextBox();
            this.BtnAddEdit = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCollegeName
            // 
            this.labelCollegeName.AutoSize = true;
            this.labelCollegeName.Location = new System.Drawing.Point(29, 35);
            this.labelCollegeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCollegeName.Name = "labelCollegeName";
            this.labelCollegeName.Size = new System.Drawing.Size(76, 13);
            this.labelCollegeName.TabIndex = 0;
            this.labelCollegeName.Text = "College Name:";
            // 
            // labelCollegeCode
            // 
            this.labelCollegeCode.AutoSize = true;
            this.labelCollegeCode.Location = new System.Drawing.Point(32, 63);
            this.labelCollegeCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCollegeCode.Name = "labelCollegeCode";
            this.labelCollegeCode.Size = new System.Drawing.Size(73, 13);
            this.labelCollegeCode.TabIndex = 1;
            this.labelCollegeCode.Text = "College Code:";
            // 
            // TxtCollegeName
            // 
            this.TxtCollegeName.Location = new System.Drawing.Point(118, 32);
            this.TxtCollegeName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCollegeName.Name = "TxtCollegeName";
            this.TxtCollegeName.Size = new System.Drawing.Size(174, 20);
            this.TxtCollegeName.TabIndex = 2;
            // 
            // TxtCollegeCode
            // 
            this.TxtCollegeCode.Location = new System.Drawing.Point(118, 61);
            this.TxtCollegeCode.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCollegeCode.Name = "TxtCollegeCode";
            this.TxtCollegeCode.Size = new System.Drawing.Size(173, 20);
            this.TxtCollegeCode.TabIndex = 3;
            // 
            // BtnAddEdit
            // 
            this.BtnAddEdit.Location = new System.Drawing.Point(103, 102);
            this.BtnAddEdit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddEdit.Name = "BtnAddEdit";
            this.BtnAddEdit.Size = new System.Drawing.Size(58, 24);
            this.BtnAddEdit.TabIndex = 4;
            this.BtnAddEdit.Text = "Add";
            this.BtnAddEdit.UseVisualStyleBackColor = true;
            this.BtnAddEdit.Click += new System.EventHandler(this.BtnAddEdit_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(180, 102);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(64, 24);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // AddEditCollegeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 397);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnAddEdit);
            this.Controls.Add(this.TxtCollegeCode);
            this.Controls.Add(this.TxtCollegeName);
            this.Controls.Add(this.labelCollegeCode);
            this.Controls.Add(this.labelCollegeName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddEditCollegeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample App v1.0";
            this.Load += new System.EventHandler(this.AddEditCollegeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCollegeName;
        private System.Windows.Forms.Label labelCollegeCode;
        private System.Windows.Forms.TextBox TxtCollegeName;
        private System.Windows.Forms.TextBox TxtCollegeCode;
        private System.Windows.Forms.Button BtnAddEdit;
        private System.Windows.Forms.Button BtnClear;
    }
}