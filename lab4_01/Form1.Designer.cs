using System;

namespace lab4_01
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.chk_Clean = new System.Windows.Forms.CheckBox();
            this.chk_Whitening = new System.Windows.Forms.CheckBox();
            this.chk_Xray = new System.Windows.Forms.CheckBox();
            this.numFilling = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(130, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "DENTAL PAYMENT FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ten khach hang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "cao voi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "tay trang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "chup hinh rang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "tram rang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "tong tien ";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(135, 78);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(246, 20);
            this.txt_Name.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(129, 318);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(239, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(293, 360);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(75, 23);
            this.btn_Calc.TabIndex = 9;
            this.btn_Calc.Text = "tinh tien";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(50, 360);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "thoat";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // chk_Clean
            // 
            this.chk_Clean.AutoSize = true;
            this.chk_Clean.Location = new System.Drawing.Point(129, 150);
            this.chk_Clean.Name = "chk_Clean";
            this.chk_Clean.Size = new System.Drawing.Size(15, 14);
            this.chk_Clean.TabIndex = 11;
            this.chk_Clean.UseVisualStyleBackColor = true;
            // 
            // chk_Whitening
            // 
            this.chk_Whitening.AutoSize = true;
            this.chk_Whitening.Location = new System.Drawing.Point(129, 173);
            this.chk_Whitening.Name = "chk_Whitening";
            this.chk_Whitening.Size = new System.Drawing.Size(15, 14);
            this.chk_Whitening.TabIndex = 12;
            this.chk_Whitening.UseVisualStyleBackColor = true;
            // 
            // chk_Xray
            // 
            this.chk_Xray.AutoSize = true;
            this.chk_Xray.Location = new System.Drawing.Point(129, 196);
            this.chk_Xray.Name = "chk_Xray";
            this.chk_Xray.Size = new System.Drawing.Size(15, 14);
            this.chk_Xray.TabIndex = 13;
            this.chk_Xray.UseVisualStyleBackColor = true;
            // 
            // numFilling
            // 
            this.numFilling.Location = new System.Drawing.Point(129, 252);
            this.numFilling.Name = "numFilling";
            this.numFilling.Size = new System.Drawing.Size(164, 20);
            this.numFilling.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "$100.000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "$1.200.000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "$200.000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "$80000/cai";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numFilling);
            this.Controls.Add(this.chk_Xray);
            this.Controls.Add(this.chk_Whitening);
            this.Controls.Add(this.chk_Clean);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.CheckBox chk_Clean;
        private System.Windows.Forms.CheckBox chk_Whitening;
        private System.Windows.Forms.CheckBox chk_Xray;
        private System.Windows.Forms.NumericUpDown numFilling;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
    }
}

