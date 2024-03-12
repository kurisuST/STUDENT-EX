namespace STUDENT_EX
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelname = new System.Windows.Forms.Label();
            this.namefield = new System.Windows.Forms.TextBox();
            this.lastnamefield = new System.Windows.Forms.TextBox();
            this.labellastname = new System.Windows.Forms.Label();
            this.mlastnamefield = new System.Windows.Forms.TextBox();
            this.labelmlastname = new System.Windows.Forms.Label();
            this.textBoxdata = new System.Windows.Forms.TextBox();
            this.labelbirthday = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.buttonaddstudent = new System.Windows.Forms.Button();
            this.labelgrade = new System.Windows.Forms.Label();
            this.textBoxcareer = new System.Windows.Forms.TextBox();
            this.labelcareer = new System.Windows.Forms.Label();
            this.numericGRADE = new System.Windows.Forms.NumericUpDown();
            this.dateTimebirthday = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericGRADE)).BeginInit();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(104, 35);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(55, 15);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Name(´s)";
            // 
            // namefield
            // 
            this.namefield.Location = new System.Drawing.Point(50, 53);
            this.namefield.Name = "namefield";
            this.namefield.Size = new System.Drawing.Size(148, 23);
            this.namefield.TabIndex = 1;
            this.namefield.TextChanged += new System.EventHandler(this.namefield_TextChanged);
            // 
            // lastnamefield
            // 
            this.lastnamefield.Location = new System.Drawing.Point(253, 53);
            this.lastnamefield.Name = "lastnamefield";
            this.lastnamefield.Size = new System.Drawing.Size(100, 23);
            this.lastnamefield.TabIndex = 3;
            this.lastnamefield.TextChanged += new System.EventHandler(this.lastnamefield_TextChanged);
            // 
            // labellastname
            // 
            this.labellastname.AutoSize = true;
            this.labellastname.Location = new System.Drawing.Point(270, 35);
            this.labellastname.Name = "labellastname";
            this.labellastname.Size = new System.Drawing.Size(63, 15);
            this.labellastname.TabIndex = 2;
            this.labellastname.Text = "Last Name";
            // 
            // mlastnamefield
            // 
            this.mlastnamefield.Location = new System.Drawing.Point(419, 53);
            this.mlastnamefield.Name = "mlastnamefield";
            this.mlastnamefield.Size = new System.Drawing.Size(100, 23);
            this.mlastnamefield.TabIndex = 5;
            this.mlastnamefield.TextChanged += new System.EventHandler(this.mlastnamefield_TextChanged);
            // 
            // labelmlastname
            // 
            this.labelmlastname.AutoSize = true;
            this.labelmlastname.Location = new System.Drawing.Point(410, 35);
            this.labelmlastname.Name = "labelmlastname";
            this.labelmlastname.Size = new System.Drawing.Size(113, 15);
            this.labelmlastname.TabIndex = 4;
            this.labelmlastname.Text = "Mother´s Last Name";
            // 
            // textBoxdata
            // 
            this.textBoxdata.Location = new System.Drawing.Point(50, 197);
            this.textBoxdata.Multiline = true;
            this.textBoxdata.Name = "textBoxdata";
            this.textBoxdata.ReadOnly = true;
            this.textBoxdata.Size = new System.Drawing.Size(703, 160);
            this.textBoxdata.TabIndex = 6;
            this.textBoxdata.TextChanged += new System.EventHandler(this.textBoxdata_TextChanged);
            // 
            // labelbirthday
            // 
            this.labelbirthday.AutoSize = true;
            this.labelbirthday.Location = new System.Drawing.Point(50, 123);
            this.labelbirthday.Name = "labelbirthday";
            this.labelbirthday.Size = new System.Drawing.Size(148, 15);
            this.labelbirthday.TabIndex = 7;
            this.labelbirthday.Text = "Birthday (\"YYYY/MM/DD\")";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(253, 141);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 10;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(272, 123);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(62, 15);
            this.labelid.TabIndex = 9;
            this.labelid.Text = "Student ID";
            // 
            // buttonaddstudent
            // 
            this.buttonaddstudent.Location = new System.Drawing.Point(562, 123);
            this.buttonaddstudent.Name = "buttonaddstudent";
            this.buttonaddstudent.Size = new System.Drawing.Size(191, 41);
            this.buttonaddstudent.TabIndex = 11;
            this.buttonaddstudent.Text = "Add Student";
            this.buttonaddstudent.UseVisualStyleBackColor = true;
            this.buttonaddstudent.Click += new System.EventHandler(this.buttonaddstudent_Click);
            // 
            // labelgrade
            // 
            this.labelgrade.AutoSize = true;
            this.labelgrade.Location = new System.Drawing.Point(449, 123);
            this.labelgrade.Name = "labelgrade";
            this.labelgrade.Size = new System.Drawing.Size(38, 15);
            this.labelgrade.TabIndex = 12;
            this.labelgrade.Text = "Grade";
            // 
            // textBoxcareer
            // 
            this.textBoxcareer.Location = new System.Drawing.Point(562, 53);
            this.textBoxcareer.Name = "textBoxcareer";
            this.textBoxcareer.Size = new System.Drawing.Size(195, 23);
            this.textBoxcareer.TabIndex = 15;
            // 
            // labelcareer
            // 
            this.labelcareer.AutoSize = true;
            this.labelcareer.Location = new System.Drawing.Point(637, 35);
            this.labelcareer.Name = "labelcareer";
            this.labelcareer.Size = new System.Drawing.Size(41, 15);
            this.labelcareer.TabIndex = 14;
            this.labelcareer.Text = "Career";
            // 
            // numericGRADE
            // 
            this.numericGRADE.Location = new System.Drawing.Point(449, 141);
            this.numericGRADE.Name = "numericGRADE";
            this.numericGRADE.Size = new System.Drawing.Size(43, 23);
            this.numericGRADE.TabIndex = 16;
            this.numericGRADE.ValueChanged += new System.EventHandler(this.numericGRADE_ValueChanged);
            // 
            // dateTimebirthday
            // 
            this.dateTimebirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimebirthday.Location = new System.Drawing.Point(50, 141);
            this.dateTimebirthday.Name = "dateTimebirthday";
            this.dateTimebirthday.Size = new System.Drawing.Size(148, 23);
            this.dateTimebirthday.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimebirthday);
            this.Controls.Add(this.numericGRADE);
            this.Controls.Add(this.textBoxcareer);
            this.Controls.Add(this.labelcareer);
            this.Controls.Add(this.labelgrade);
            this.Controls.Add(this.buttonaddstudent);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labelbirthday);
            this.Controls.Add(this.textBoxdata);
            this.Controls.Add(this.mlastnamefield);
            this.Controls.Add(this.labelmlastname);
            this.Controls.Add(this.lastnamefield);
            this.Controls.Add(this.labellastname);
            this.Controls.Add(this.namefield);
            this.Controls.Add(this.labelname);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericGRADE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelname;
        private TextBox namefield;
        private TextBox lastnamefield;
        private Label labellastname;
        private TextBox mlastnamefield;
        private Label labelmlastname;
        private TextBox textBoxdata;
        private Label labelbirthday;
        private TextBox textBoxID;
        private Label labelid;
        private Button buttonaddstudent;
        private Label labelgrade;
        private TextBox textBoxcareer;
        private Label labelcareer;
        private NumericUpDown numericGRADE;
        private DateTimePicker dateTimebirthday;
    }
}