namespace Facility_Management_System
{
    partial class pool_vehicle
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
            this.txtvehicleno = new System.Windows.Forms.TextBox();
            this.rbpetrol = new System.Windows.Forms.RadioButton();
            this.rbdiesel = new System.Windows.Forms.RadioButton();
            this.rbelectric = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbadmindept = new System.Windows.Forms.RadioButton();
            this.rbhrdept = new System.Windows.Forms.RadioButton();
            this.rbtechnical = new System.Windows.Forms.RadioButton();
            this.rbtransdept = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbvan = new System.Windows.Forms.RadioButton();
            this.rbcar = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtvehicleno
            // 
            this.txtvehicleno.Location = new System.Drawing.Point(112, 34);
            this.txtvehicleno.Name = "txtvehicleno";
            this.txtvehicleno.Size = new System.Drawing.Size(162, 20);
            this.txtvehicleno.TabIndex = 0;
            // 
            // rbpetrol
            // 
            this.rbpetrol.AutoSize = true;
            this.rbpetrol.Location = new System.Drawing.Point(6, 24);
            this.rbpetrol.Name = "rbpetrol";
            this.rbpetrol.Size = new System.Drawing.Size(52, 17);
            this.rbpetrol.TabIndex = 2;
            this.rbpetrol.TabStop = true;
            this.rbpetrol.Text = "Petrol";
            this.rbpetrol.UseVisualStyleBackColor = true;
            // 
            // rbdiesel
            // 
            this.rbdiesel.AutoSize = true;
            this.rbdiesel.Location = new System.Drawing.Point(6, 47);
            this.rbdiesel.Name = "rbdiesel";
            this.rbdiesel.Size = new System.Drawing.Size(54, 17);
            this.rbdiesel.TabIndex = 3;
            this.rbdiesel.TabStop = true;
            this.rbdiesel.Text = "Diesel";
            this.rbdiesel.UseVisualStyleBackColor = true;
            // 
            // rbelectric
            // 
            this.rbelectric.AutoSize = true;
            this.rbelectric.Location = new System.Drawing.Point(6, 70);
            this.rbelectric.Name = "rbelectric";
            this.rbelectric.Size = new System.Drawing.Size(60, 17);
            this.rbelectric.TabIndex = 4;
            this.rbelectric.TabStop = true;
            this.rbelectric.Text = "Electric";
            this.rbelectric.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbpetrol);
            this.groupBox1.Controls.Add(this.rbelectric);
            this.groupBox1.Controls.Add(this.rbdiesel);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(29, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuel Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbadmindept);
            this.groupBox2.Controls.Add(this.rbhrdept);
            this.groupBox2.Controls.Add(this.rbtechnical);
            this.groupBox2.Controls.Add(this.rbtransdept);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(29, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 126);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Department";
            // 
            // rbadmindept
            // 
            this.rbadmindept.AutoSize = true;
            this.rbadmindept.Location = new System.Drawing.Point(6, 29);
            this.rbadmindept.Name = "rbadmindept";
            this.rbadmindept.Size = new System.Drawing.Size(112, 17);
            this.rbadmindept.TabIndex = 11;
            this.rbadmindept.TabStop = true;
            this.rbadmindept.Text = "Admin Department";
            this.rbadmindept.UseVisualStyleBackColor = true;
            // 
            // rbhrdept
            // 
            this.rbhrdept.AutoSize = true;
            this.rbhrdept.Location = new System.Drawing.Point(6, 52);
            this.rbhrdept.Name = "rbhrdept";
            this.rbhrdept.Size = new System.Drawing.Size(99, 17);
            this.rbhrdept.TabIndex = 12;
            this.rbhrdept.TabStop = true;
            this.rbhrdept.Text = "HR Department";
            this.rbhrdept.UseVisualStyleBackColor = true;
            // 
            // rbtechnical
            // 
            this.rbtechnical.AutoSize = true;
            this.rbtechnical.Location = new System.Drawing.Point(6, 75);
            this.rbtechnical.Name = "rbtechnical";
            this.rbtechnical.Size = new System.Drawing.Size(130, 17);
            this.rbtechnical.TabIndex = 28;
            this.rbtechnical.TabStop = true;
            this.rbtechnical.Text = "Technical Department";
            this.rbtechnical.UseVisualStyleBackColor = true;
            // 
            // rbtransdept
            // 
            this.rbtransdept.AutoSize = true;
            this.rbtransdept.Location = new System.Drawing.Point(6, 98);
            this.rbtransdept.Name = "rbtransdept";
            this.rbtransdept.Size = new System.Drawing.Size(217, 17);
            this.rbtransdept.TabIndex = 14;
            this.rbtransdept.TabStop = true;
            this.rbtransdept.Text = "Transport and Motor Vehicle Department";
            this.rbtransdept.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Vehicle number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbvan);
            this.groupBox3.Controls.Add(this.rbcar);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(294, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 100);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vehicle Type";
            // 
            // rbvan
            // 
            this.rbvan.AutoSize = true;
            this.rbvan.Location = new System.Drawing.Point(7, 53);
            this.rbvan.Name = "rbvan";
            this.rbvan.Size = new System.Drawing.Size(44, 17);
            this.rbvan.TabIndex = 1;
            this.rbvan.TabStop = true;
            this.rbvan.Text = "Van";
            this.rbvan.UseVisualStyleBackColor = true;
            // 
            // rbcar
            // 
            this.rbcar.AutoSize = true;
            this.rbcar.Location = new System.Drawing.Point(7, 29);
            this.rbcar.Name = "rbcar";
            this.rbcar.Size = new System.Drawing.Size(41, 17);
            this.rbcar.TabIndex = 0;
            this.rbcar.TabStop = true;
            this.rbcar.Text = "Car";
            this.rbcar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(294, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pool_vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(442, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtvehicleno);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "pool_vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pool Vehicle Request";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvehicleno;
        private System.Windows.Forms.RadioButton rbpetrol;
        private System.Windows.Forms.RadioButton rbdiesel;
        private System.Windows.Forms.RadioButton rbelectric;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbadmindept;
        private System.Windows.Forms.RadioButton rbhrdept;
        private System.Windows.Forms.RadioButton rbtechnical;
        private System.Windows.Forms.RadioButton rbtransdept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbvan;
        private System.Windows.Forms.RadioButton rbcar;
        private System.Windows.Forms.Button button1;
    }
}