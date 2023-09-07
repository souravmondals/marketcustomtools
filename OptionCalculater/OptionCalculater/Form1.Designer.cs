namespace OptionCalculater
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_S = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_K = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_r = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_v = new System.Windows.Forms.TextBox();
            this.tb_Call = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.transactionDate = new System.Windows.Forms.DateTimePicker();
            this.expirationdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Get Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 999;
            this.label1.Text = "S Current Price";
            // 
            // tb_S
            // 
            this.tb_S.Location = new System.Drawing.Point(203, 41);
            this.tb_S.Name = "tb_S";
            this.tb_S.Size = new System.Drawing.Size(133, 20);
            this.tb_S.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 999;
            this.label2.Text = "K strike price";
            // 
            // tb_K
            // 
            this.tb_K.Location = new System.Drawing.Point(203, 76);
            this.tb_K.Name = "tb_K";
            this.tb_K.Size = new System.Drawing.Size(133, 20);
            this.tb_K.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 999;
            this.label3.Text = "R Rate of Interest";
            // 
            // tb_r
            // 
            this.tb_r.Location = new System.Drawing.Point(203, 111);
            this.tb_r.Name = "tb_r";
            this.tb_r.Size = new System.Drawing.Size(133, 20);
            this.tb_r.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 999;
            this.label5.Text = "Date of Transaction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 999;
            this.label6.Text = "V  Implied Volatility";
            // 
            // tb_v
            // 
            this.tb_v.Location = new System.Drawing.Point(203, 211);
            this.tb_v.Name = "tb_v";
            this.tb_v.Size = new System.Drawing.Size(133, 20);
            this.tb_v.TabIndex = 6;
            // 
            // tb_Call
            // 
            this.tb_Call.Location = new System.Drawing.Point(203, 312);
            this.tb_Call.Name = "tb_Call";
            this.tb_Call.Size = new System.Drawing.Size(133, 20);
            this.tb_Call.TabIndex = 999;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Call / Put price";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 262);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Call";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(84, 263);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Put";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1000;
            this.label4.Text = "Find Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Location = new System.Drawing.Point(81, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 1000;
            this.label8.Text = "Find S R";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 1002;
            this.label9.Text = "Expiration Date";
            // 
            // transactionDate
            // 
            this.transactionDate.Location = new System.Drawing.Point(203, 148);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Size = new System.Drawing.Size(133, 20);
            this.transactionDate.TabIndex = 4;
            // 
            // expirationdate
            // 
            this.expirationdate.Location = new System.Drawing.Point(203, 177);
            this.expirationdate.Name = "expirationdate";
            this.expirationdate.Size = new System.Drawing.Size(133, 20);
            this.expirationdate.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 367);
            this.Controls.Add(this.expirationdate);
            this.Controls.Add(this.transactionDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tb_Call);
            this.Controls.Add(this.tb_v);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_r);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_K);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_S);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Option Calculater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_S;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_K;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_r;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_v;
        private System.Windows.Forms.TextBox tb_Call;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker transactionDate;
        private System.Windows.Forms.DateTimePicker expirationdate;
    }
}

