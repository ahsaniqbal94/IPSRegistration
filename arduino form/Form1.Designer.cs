namespace arduino_form
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rfid = new System.Windows.Forms.Label();
            this.Acc_for = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.active = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.vtype = new System.Windows.Forms.Label();
            this.vno = new System.Windows.Forms.Label();
            this.batch = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.byear = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.depart = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox11 = new System.Windows.Forms.Label();
            this.enrollment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Charlemagne Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "COM Port";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(672, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rfid
            // 
            this.rfid.AutoSize = true;
            this.rfid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfid.Location = new System.Drawing.Point(259, 151);
            this.rfid.Name = "rfid";
            this.rfid.Size = new System.Drawing.Size(52, 20);
            this.rfid.TabIndex = 8;
            this.rfid.Text = "RFID";
            // 
            // Acc_for
            // 
            this.Acc_for.AutoSize = true;
            this.Acc_for.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc_for.Location = new System.Drawing.Point(259, 210);
            this.Acc_for.Name = "Acc_for";
            this.Acc_for.Size = new System.Drawing.Size(107, 20);
            this.Acc_for.TabIndex = 9;
            this.Acc_for.Text = "Account For";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(261, 182);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(55, 20);
            this.name.TabIndex = 10;
            this.name.Text = "Name";
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.active.Location = new System.Drawing.Point(258, 238);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(129, 20);
            this.active.TabIndex = 11;
            this.active.Text = "Active Account";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex.Location = new System.Drawing.Point(259, 269);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(69, 20);
            this.sex.TabIndex = 12;
            this.sex.Text = "Gender";
            this.sex.Click += new System.EventHandler(this.label6_Click);
            // 
            // vtype
            // 
            this.vtype.AutoSize = true;
            this.vtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtype.Location = new System.Drawing.Point(258, 301);
            this.vtype.Name = "vtype";
            this.vtype.Size = new System.Drawing.Size(111, 20);
            this.vtype.TabIndex = 13;
            this.vtype.Text = "Vehicle Type";
            // 
            // vno
            // 
            this.vno.AutoSize = true;
            this.vno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vno.Location = new System.Drawing.Point(259, 331);
            this.vno.Name = "vno";
            this.vno.Size = new System.Drawing.Size(135, 20);
            this.vno.TabIndex = 14;
            this.vno.Text = "Vehicle Number";
            // 
            // batch
            // 
            this.batch.AutoSize = true;
            this.batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batch.Location = new System.Drawing.Point(260, 364);
            this.batch.Name = "batch";
            this.batch.Size = new System.Drawing.Size(56, 20);
            this.batch.TabIndex = 15;
            this.batch.Text = "Batch";
            this.batch.Click += new System.EventHandler(this.batch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Student",
            "Employee"});
            this.comboBox1.Location = new System.Drawing.Point(672, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "Student";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(672, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Active",
            "Suspended"});
            this.comboBox2.Location = new System.Drawing.Point(672, 237);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 21);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.Text = "Active";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox3.Location = new System.Drawing.Point(672, 271);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(136, 21);
            this.comboBox3.TabIndex = 25;
            this.comboBox3.Text = "Male";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Car",
            "Bike"});
            this.comboBox4.Location = new System.Drawing.Point(673, 303);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(137, 21);
            this.comboBox4.TabIndex = 26;
            this.comboBox4.Text = "Car";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(673, 333);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 20);
            this.textBox3.TabIndex = 27;
            // 
            // byear
            // 
            this.byear.FormattingEnabled = true;
            this.byear.Items.AddRange(new object[] {
            "2010-11"});
            this.byear.Location = new System.Drawing.Point(673, 366);
            this.byear.Name = "byear";
            this.byear.Size = new System.Drawing.Size(136, 21);
            this.byear.TabIndex = 28;
            this.byear.Text = "2012-13";
            this.byear.SelectedIndexChanged += new System.EventHandler(this.byear_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(675, 112);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 30;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // depart
            // 
            this.depart.FormattingEnabled = true;
            this.depart.Items.AddRange(new object[] {
            "AR",
            "AU",
            "CT",
            "BO",
            "CE",
            "CH",
            "CS",
            "AU",
            "EE",
            "FO",
            "IM",
            "ME",
            "MM",
            "MY",
            "PE",
            "PP",
            "SE",
            "EL",
            "TC",
            "TE",
            "UE",
            "CF",
            "IC",
            "AP",
            "MG",
            "TS",
            "DS"});
            this.depart.Location = new System.Drawing.Point(673, 399);
            this.depart.Name = "depart";
            this.depart.Size = new System.Drawing.Size(136, 21);
            this.depart.TabIndex = 32;
            this.depart.Text = "AR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Department";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textbox11
            // 
            this.textbox11.AutoSize = true;
            this.textbox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox11.Location = new System.Drawing.Point(261, 429);
            this.textbox11.Name = "textbox11";
            this.textbox11.Size = new System.Drawing.Size(127, 20);
            this.textbox11.TabIndex = 33;
            this.textbox11.Text = "Enrollment No.";
            // 
            // enrollment
            // 
            this.enrollment.Location = new System.Drawing.Point(673, 429);
            this.enrollment.Name = "enrollment";
            this.enrollment.Size = new System.Drawing.Size(137, 20);
            this.enrollment.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Roll No.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "CNIC";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(673, 460);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 20);
            this.textBox4.TabIndex = 37;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(673, 486);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(137, 20);
            this.textBox5.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(260, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "     ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enrollment);
            this.Controls.Add(this.textbox11);
            this.Controls.Add(this.depart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.byear);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.batch);
            this.Controls.Add(this.vno);
            this.Controls.Add(this.vtype);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.active);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Acc_for);
            this.Controls.Add(this.rfid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IPS data entry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label rfid;
        private System.Windows.Forms.Label Acc_for;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label active;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label vtype;
        private System.Windows.Forms.Label vno;
        private System.Windows.Forms.Label batch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ComboBox byear;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox depart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textbox11;
        private System.Windows.Forms.TextBox enrollment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
    }
}

