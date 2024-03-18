namespace HudaKasemClinc.All_Main_Forms.Appointments
{
    partial class frmAddAppointment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWrong = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TimerDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.RDAM = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RDPM = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.EndMunits = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEndM = new System.Windows.Forms.Label();
            this.EndHour = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.lblEndH = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.StartMunits = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSM = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StartHours = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSH = new System.Windows.Forms.Label();
            this.CBDoctors = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBPatients = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndMunits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartMunits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblWrong);
            this.panel1.Controls.Add(this.txtNotes);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TimerDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.guna2GroupBox1);
            this.panel1.Controls.Add(this.CBDoctors);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CBPatients);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(616, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 747);
            this.panel1.TabIndex = 2;
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWrong.Font = new System.Drawing.Font("Simplified Arabic Fixed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.ForeColor = System.Drawing.Color.Red;
            this.lblWrong.Location = new System.Drawing.Point(101, 503);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(200, 23);
            this.lblWrong.TabIndex = 61;
            this.lblWrong.Text = "(Get Suggestion)...";
            this.lblWrong.Visible = false;
            this.lblWrong.Click += new System.EventHandler(this.lblWrong_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.AutoScroll = true;
            this.txtNotes.BackColor = System.Drawing.Color.White;
            this.txtNotes.BorderRadius = 20;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.Color.Black;
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(32, 814);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNotes.PlaceholderText = "Have Notes?";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(625, 248);
            this.txtNotes.TabIndex = 60;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 27);
            this.label6.TabIndex = 59;
            this.label6.Text = "Time";
            // 
            // TimerDate
            // 
            this.TimerDate.Checked = true;
            this.TimerDate.FillColor = System.Drawing.Color.Teal;
            this.TimerDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerDate.ForeColor = System.Drawing.Color.White;
            this.TimerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimerDate.Location = new System.Drawing.Point(40, 430);
            this.TimerDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TimerDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TimerDate.Name = "TimerDate";
            this.TimerDate.Size = new System.Drawing.Size(611, 52);
            this.TimerDate.TabIndex = 58;
            this.TimerDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimerDate.Value = new System.DateTime(2024, 2, 21, 16, 21, 54, 294);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 27);
            this.label3.TabIndex = 57;
            this.label3.Text = "Date";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Teal;
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.Controls.Add(this.RDAM);
            this.guna2GroupBox1.Controls.Add(this.RDPM);
            this.guna2GroupBox1.Controls.Add(this.label19);
            this.guna2GroupBox1.Controls.Add(this.label18);
            this.guna2GroupBox1.Controls.Add(this.EndMunits);
            this.guna2GroupBox1.Controls.Add(this.label13);
            this.guna2GroupBox1.Controls.Add(this.lblEndM);
            this.guna2GroupBox1.Controls.Add(this.EndHour);
            this.guna2GroupBox1.Controls.Add(this.label15);
            this.guna2GroupBox1.Controls.Add(this.lblEndH);
            this.guna2GroupBox1.Controls.Add(this.guna2VSeparator1);
            this.guna2GroupBox1.Controls.Add(this.StartMunits);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.lblSM);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.StartHours);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.lblSH);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Teal;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(40, 533);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(611, 231);
            this.guna2GroupBox1.TabIndex = 56;
            // 
            // RDAM
            // 
            this.RDAM.AutoSize = true;
            this.RDAM.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDAM.CheckedState.BorderThickness = 0;
            this.RDAM.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDAM.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RDAM.CheckedState.InnerOffset = -4;
            this.RDAM.FlatAppearance.BorderSize = 10;
            this.RDAM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.RDAM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.RDAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RDAM.Location = new System.Drawing.Point(284, 200);
            this.RDAM.Name = "RDAM";
            this.RDAM.Size = new System.Drawing.Size(52, 24);
            this.RDAM.TabIndex = 62;
            this.RDAM.Text = "AM";
            this.RDAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RDAM.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RDAM.UncheckedState.BorderThickness = 2;
            this.RDAM.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RDAM.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // RDPM
            // 
            this.RDPM.AutoSize = true;
            this.RDPM.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDPM.CheckedState.BorderThickness = 0;
            this.RDPM.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDPM.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RDPM.CheckedState.InnerOffset = -4;
            this.RDPM.FlatAppearance.BorderSize = 10;
            this.RDPM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.RDPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.RDPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RDPM.Location = new System.Drawing.Point(284, 170);
            this.RDPM.Name = "RDPM";
            this.RDPM.Size = new System.Drawing.Size(50, 24);
            this.RDPM.TabIndex = 61;
            this.RDPM.Text = "PM";
            this.RDPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RDPM.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RDPM.UncheckedState.BorderThickness = 2;
            this.RDPM.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RDPM.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(434, 125);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 27);
            this.label19.TabIndex = 34;
            this.label19.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(123, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 27);
            this.label18.TabIndex = 33;
            this.label18.Text = ":";
            // 
            // EndMunits
            // 
            this.EndMunits.BackColor = System.Drawing.Color.Transparent;
            this.EndMunits.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EndMunits.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EndMunits.Location = new System.Drawing.Point(494, 86);
            this.EndMunits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndMunits.Name = "EndMunits";
            this.EndMunits.Size = new System.Drawing.Size(54, 25);
            this.EndMunits.TabIndex = 32;
            this.EndMunits.UpDownButtonFillColor = System.Drawing.Color.Teal;
            this.EndMunits.ValueChanged += new System.EventHandler(this.EndMunits_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(489, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 27);
            this.label13.TabIndex = 30;
            this.label13.Text = "Minutes";
            // 
            // lblEndM
            // 
            this.lblEndM.AutoSize = true;
            this.lblEndM.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndM.Location = new System.Drawing.Point(464, 125);
            this.lblEndM.Name = "lblEndM";
            this.lblEndM.Size = new System.Drawing.Size(24, 27);
            this.lblEndM.TabIndex = 31;
            this.lblEndM.Text = "0";
            // 
            // EndHour
            // 
            this.EndHour.BackColor = System.Drawing.Color.Transparent;
            this.EndHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EndHour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EndHour.Location = new System.Drawing.Point(343, 86);
            this.EndHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndHour.Name = "EndHour";
            this.EndHour.Size = new System.Drawing.Size(54, 25);
            this.EndHour.TabIndex = 29;
            this.EndHour.UpDownButtonFillColor = System.Drawing.Color.Teal;
            this.EndHour.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.EndHour.ValueChanged += new System.EventHandler(this.EndHour_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(349, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 27);
            this.label15.TabIndex = 27;
            this.label15.Text = "Hour";
            // 
            // lblEndH
            // 
            this.lblEndH.AutoSize = true;
            this.lblEndH.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndH.Location = new System.Drawing.Point(404, 125);
            this.lblEndH.Name = "lblEndH";
            this.lblEndH.Size = new System.Drawing.Size(24, 27);
            this.lblEndH.TabIndex = 28;
            this.lblEndH.Text = "2";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(303, 55);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 109);
            this.guna2VSeparator1.TabIndex = 26;
            // 
            // StartMunits
            // 
            this.StartMunits.BackColor = System.Drawing.Color.Transparent;
            this.StartMunits.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StartMunits.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartMunits.Location = new System.Drawing.Point(182, 86);
            this.StartMunits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartMunits.Name = "StartMunits";
            this.StartMunits.Size = new System.Drawing.Size(54, 25);
            this.StartMunits.TabIndex = 25;
            this.StartMunits.UpDownButtonFillColor = System.Drawing.Color.Teal;
            this.StartMunits.ValueChanged += new System.EventHandler(this.StartMunits_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 27);
            this.label10.TabIndex = 23;
            this.label10.Text = "Minutes";
            // 
            // lblSM
            // 
            this.lblSM.AutoSize = true;
            this.lblSM.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSM.Location = new System.Drawing.Point(153, 125);
            this.lblSM.Name = "lblSM";
            this.lblSM.Size = new System.Drawing.Size(24, 27);
            this.lblSM.TabIndex = 24;
            this.lblSM.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(434, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 27);
            this.label9.TabIndex = 22;
            this.label9.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(102, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 27);
            this.label8.TabIndex = 21;
            this.label8.Text = "From";
            // 
            // StartHours
            // 
            this.StartHours.BackColor = System.Drawing.Color.Transparent;
            this.StartHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StartHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartHours.Location = new System.Drawing.Point(31, 86);
            this.StartHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartHours.Name = "StartHours";
            this.StartHours.Size = new System.Drawing.Size(54, 25);
            this.StartHours.TabIndex = 20;
            this.StartHours.UpDownButtonFillColor = System.Drawing.Color.Teal;
            this.StartHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartHours.ValueChanged += new System.EventHandler(this.StartHours_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hour";
            // 
            // lblSH
            // 
            this.lblSH.AutoSize = true;
            this.lblSH.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSH.Location = new System.Drawing.Point(81, 125);
            this.lblSH.Name = "lblSH";
            this.lblSH.Size = new System.Drawing.Size(24, 27);
            this.lblSH.TabIndex = 19;
            this.lblSH.Text = "1";
            // 
            // CBDoctors
            // 
            this.CBDoctors.BackColor = System.Drawing.Color.Transparent;
            this.CBDoctors.BorderRadius = 10;
            this.CBDoctors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDoctors.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBDoctors.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBDoctors.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBDoctors.ForeColor = System.Drawing.Color.Black;
            this.CBDoctors.ItemHeight = 30;
            this.CBDoctors.Items.AddRange(new object[] {
            "Huda"});
            this.CBDoctors.Location = new System.Drawing.Point(40, 336);
            this.CBDoctors.Name = "CBDoctors";
            this.CBDoctors.Size = new System.Drawing.Size(611, 36);
            this.CBDoctors.StartIndex = 0;
            this.CBDoctors.TabIndex = 55;
            this.CBDoctors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 54;
            this.label2.Text = "Doctor";
            // 
            // CBPatients
            // 
            this.CBPatients.BackColor = System.Drawing.Color.Transparent;
            this.CBPatients.BorderRadius = 10;
            this.CBPatients.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBPatients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPatients.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBPatients.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBPatients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBPatients.ForeColor = System.Drawing.Color.Black;
            this.CBPatients.ItemHeight = 30;
            this.CBPatients.Items.AddRange(new object[] {
            "Rami"});
            this.CBPatients.Location = new System.Drawing.Point(40, 239);
            this.CBPatients.Name = "CBPatients";
            this.CBPatients.Size = new System.Drawing.Size(611, 36);
            this.CBPatients.StartIndex = 0;
            this.CBPatients.TabIndex = 53;
            this.CBPatients.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(497, 1070);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(311, 1070);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 45);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Save";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(85, 1120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 27);
            this.label11.TabIndex = 29;
            this.label11.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 782);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 21;
            this.label5.Text = "Notes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic Fixed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Patient ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::HudaKasemClinc.Properties.Resources._426758566_1081644026247297_8207540777470835514_n;
            this.pictureBox1.Location = new System.Drawing.Point(207, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1942, 783);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddAppointment";
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.frmAddAppointment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndMunits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartMunits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox CBDoctors;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox CBPatients;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker TimerDate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown StartHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2NumericUpDown EndMunits;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblEndM;
        private Guna.UI2.WinForms.Guna2NumericUpDown EndHour;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblEndH;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2NumericUpDown StartMunits;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2RadioButton RDPM;
        private Guna.UI2.WinForms.Guna2RadioButton RDAM;
        private System.Windows.Forms.Label lblWrong;
    }
}