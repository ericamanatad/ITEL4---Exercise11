
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCollegeName
            // 
            this.labelCollegeName.AutoSize = true;
            this.labelCollegeName.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F);
            this.labelCollegeName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCollegeName.Location = new System.Drawing.Point(40, 46);
            this.labelCollegeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCollegeName.Name = "labelCollegeName";
            this.labelCollegeName.Size = new System.Drawing.Size(91, 16);
            this.labelCollegeName.TabIndex = 0;
            this.labelCollegeName.Text = "College Name:";
            // 
            // labelCollegeCode
            // 
            this.labelCollegeCode.AutoSize = true;
            this.labelCollegeCode.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCollegeCode.Location = new System.Drawing.Point(39, 113);
            this.labelCollegeCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCollegeCode.Name = "labelCollegeCode";
            this.labelCollegeCode.Size = new System.Drawing.Size(86, 16);
            this.labelCollegeCode.TabIndex = 1;
            this.labelCollegeCode.Text = "College Code:";
            // 
            // TxtCollegeName
            // 
            this.TxtCollegeName.Location = new System.Drawing.Point(43, 66);
            this.TxtCollegeName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCollegeName.Name = "TxtCollegeName";
            this.TxtCollegeName.Size = new System.Drawing.Size(223, 20);
            this.TxtCollegeName.TabIndex = 2;
            // 
            // TxtCollegeCode
            // 
            this.TxtCollegeCode.Location = new System.Drawing.Point(43, 133);
            this.TxtCollegeCode.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCollegeCode.Name = "TxtCollegeCode";
            this.TxtCollegeCode.Size = new System.Drawing.Size(223, 20);
            this.TxtCollegeCode.TabIndex = 3;
            // 
            // BtnAddEdit
            // 
            this.BtnAddEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddEdit.Location = new System.Drawing.Point(43, 193);
            this.BtnAddEdit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddEdit.Name = "BtnAddEdit";
            this.BtnAddEdit.Size = new System.Drawing.Size(88, 39);
            this.BtnAddEdit.TabIndex = 4;
            this.BtnAddEdit.Text = "Add";
            this.BtnAddEdit.UseVisualStyleBackColor = false;
            this.BtnAddEdit.Click += new System.EventHandler(this.BtnAddEdit_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.IndianRed;
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClear.Location = new System.Drawing.Point(178, 193);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(88, 39);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 62);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD/EDIT FORM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtCollegeCode);
            this.groupBox1.Controls.Add(this.labelCollegeName);
            this.groupBox1.Controls.Add(this.BtnClear);
            this.groupBox1.Controls.Add(this.labelCollegeCode);
            this.groupBox1.Controls.Add(this.BtnAddEdit);
            this.groupBox1.Controls.Add(this.TxtCollegeName);
            this.groupBox1.Location = new System.Drawing.Point(38, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 254);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // AddEditCollegeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 397);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddEditCollegeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample App v1.0";
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.Load += new System.EventHandler(this.AddEditCollegeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCollegeName;
        private System.Windows.Forms.Label labelCollegeCode;
        private System.Windows.Forms.TextBox TxtCollegeName;
        private System.Windows.Forms.TextBox TxtCollegeCode;
        private System.Windows.Forms.Button BtnAddEdit;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}