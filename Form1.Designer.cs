﻿namespace bai8_pheptinhcoban_radiobutton
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RDnhan = new System.Windows.Forms.RadioButton();
            this.RDcong = new System.Windows.Forms.RadioButton();
            this.RDchia = new System.Windows.Forms.RadioButton();
            this.RDtru = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "so thu nhat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "so thu hai";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RDnhan);
            this.groupBox1.Controls.Add(this.RDcong);
            this.groupBox1.Controls.Add(this.RDchia);
            this.groupBox1.Controls.Add(this.RDtru);
            this.groupBox1.Location = new System.Drawing.Point(231, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chon phep tinh";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RDnhan
            // 
            this.RDnhan.AutoSize = true;
            this.RDnhan.Location = new System.Drawing.Point(17, 70);
            this.RDnhan.Name = "RDnhan";
            this.RDnhan.Size = new System.Drawing.Size(49, 17);
            this.RDnhan.TabIndex = 0;
            this.RDnhan.TabStop = true;
            this.RDnhan.Text = "nhan";
            this.RDnhan.UseVisualStyleBackColor = true;
            this.RDnhan.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // RDcong
            // 
            this.RDcong.AutoSize = true;
            this.RDcong.Location = new System.Drawing.Point(17, 26);
            this.RDcong.Name = "RDcong";
            this.RDcong.Size = new System.Drawing.Size(49, 17);
            this.RDcong.TabIndex = 0;
            this.RDcong.TabStop = true;
            this.RDcong.Text = "cong";
            this.RDcong.UseVisualStyleBackColor = true;
            this.RDcong.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RDchia
            // 
            this.RDchia.AutoSize = true;
            this.RDchia.Location = new System.Drawing.Point(17, 93);
            this.RDchia.Name = "RDchia";
            this.RDchia.Size = new System.Drawing.Size(45, 17);
            this.RDchia.TabIndex = 0;
            this.RDchia.TabStop = true;
            this.RDchia.Text = "chia";
            this.RDchia.UseVisualStyleBackColor = true;
            this.RDchia.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // RDtru
            // 
            this.RDtru.AutoSize = true;
            this.RDtru.Location = new System.Drawing.Point(17, 49);
            this.RDtru.Name = "RDtru";
            this.RDtru.Size = new System.Drawing.Size(37, 17);
            this.RDtru.TabIndex = 0;
            this.RDtru.TabStop = true;
            this.RDtru.Text = "tru";
            this.RDtru.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ket qua";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 280);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "tinh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RDnhan;
        private System.Windows.Forms.RadioButton RDcong;
        private System.Windows.Forms.RadioButton RDchia;
        private System.Windows.Forms.RadioButton RDtru;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}

