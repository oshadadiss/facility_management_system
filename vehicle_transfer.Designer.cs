namespace Facility_Management_System
{
    partial class vehicle_transfer
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtvehicleno = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbadmindept = new System.Windows.Forms.RadioButton();
            this.rbhrdept = new System.Windows.Forms.RadioButton();
            this.rbtechnical = new System.Windows.Forms.RadioButton();
            this.rbtransdept = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtvehicleno
            // 
            this.txtvehicleno.Location = new System.Drawing.Point(136, 39);
            this.txtvehicleno.Name = "txtvehicleno";
            this.txtvehicleno.Size = new System.Drawing.Size(187, 20);
            this.txtvehicleno.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbadmindept);
            this.groupBox2.Controls.Add(this.rbhrdept);
            this.groupBox2.Controls.Add(this.rbtechnical);
            this.groupBox2.Controls.Add(this.rbtransdept);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(67, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 126);
            this.groupBox2.TabIndex = 32;
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
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Vehicle Number";
            // 
            // vehicle_transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(377, 299);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtvehicleno);
            this.Controls.Add(this.button1);
            this.Name = "vehicle_transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Transfer Request";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtvehicleno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbadmindept;
        private System.Windows.Forms.RadioButton rbhrdept;
        private System.Windows.Forms.RadioButton rbtechnical;
        private System.Windows.Forms.RadioButton rbtransdept;
        private System.Windows.Forms.Label label1;
    }
}