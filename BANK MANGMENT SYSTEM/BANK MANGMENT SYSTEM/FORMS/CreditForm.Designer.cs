﻿namespace BANK_MANGMENT_SYSTEM.FORMS
{
    partial class CreditForm
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
            this.datalbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.acctext = new System.Windows.Forms.TextBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.oldbaltext = new System.Windows.Forms.TextBox();
            this.amounttext = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.detailbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Date";
            // 
            // datalbl
            // 
            this.datalbl.AutoSize = true;
            this.datalbl.Location = new System.Drawing.Point(388, 79);
            this.datalbl.Name = "datalbl";
            this.datalbl.Size = new System.Drawing.Size(0, 13);
            this.datalbl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Account No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Old Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Deposit Amount";
            // 
            // acctext
            // 
            this.acctext.Location = new System.Drawing.Point(180, 127);
            this.acctext.Name = "acctext";
            this.acctext.Size = new System.Drawing.Size(168, 20);
            this.acctext.TabIndex = 7;
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(180, 174);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(168, 20);
            this.nametext.TabIndex = 8;
            // 
            // oldbaltext
            // 
            this.oldbaltext.Location = new System.Drawing.Point(180, 212);
            this.oldbaltext.Name = "oldbaltext";
            this.oldbaltext.Size = new System.Drawing.Size(168, 20);
            this.oldbaltext.TabIndex = 9;
            // 
            // amounttext
            // 
            this.amounttext.Location = new System.Drawing.Point(180, 287);
            this.amounttext.Name = "amounttext";
            this.amounttext.Size = new System.Drawing.Size(168, 20);
            this.amounttext.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // detailbutton
            // 
            this.detailbutton.Location = new System.Drawing.Point(241, 332);
            this.detailbutton.Name = "detailbutton";
            this.detailbutton.Size = new System.Drawing.Size(147, 45);
            this.detailbutton.TabIndex = 12;
            this.detailbutton.Text = "UPDATE";
            this.detailbutton.UseVisualStyleBackColor = true;
            this.detailbutton.Click += new System.EventHandler(this.detailbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "GET DETAILS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.detailbutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.amounttext);
            this.Controls.Add(this.oldbaltext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.acctext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datalbl);
            this.Controls.Add(this.label1);
            this.Name = "CreditForm";
            this.Text = "CreditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datalbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox acctext;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox oldbaltext;
        private System.Windows.Forms.TextBox amounttext;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button detailbutton;
        private System.Windows.Forms.Button button1;
    }
}