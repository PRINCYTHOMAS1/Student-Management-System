﻿namespace StudentInformationSystem
{
    partial class addmark
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
            this.subject1 = new System.Windows.Forms.Label();
            this.subject2 = new System.Windows.Forms.Label();
            this.subject3 = new System.Windows.Forms.Label();
            this.mark1txtbox = new System.Windows.Forms.TextBox();
            this.mark2txtbox = new System.Windows.Forms.TextBox();
            this.mark3txtbox = new System.Windows.Forms.TextBox();
            this.markbutton = new System.Windows.Forms.Button();
            this.insermark = new System.Windows.Forms.Label();
            this.regtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SemcomboBox = new System.Windows.Forms.ComboBox();
            this.sub1textBox = new System.Windows.Forms.TextBox();
            this.sub2textBox = new System.Windows.Forms.TextBox();
            this.sub3textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // subject1
            // 
            this.subject1.AutoSize = true;
            this.subject1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject1.Location = new System.Drawing.Point(77, 113);
            this.subject1.Name = "subject1";
            this.subject1.Size = new System.Drawing.Size(85, 20);
            this.subject1.TabIndex = 0;
            this.subject1.Text = "Subject 1";
            // 
            // subject2
            // 
            this.subject2.AutoSize = true;
            this.subject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject2.Location = new System.Drawing.Point(77, 159);
            this.subject2.Name = "subject2";
            this.subject2.Size = new System.Drawing.Size(85, 20);
            this.subject2.TabIndex = 1;
            this.subject2.Text = "Subject 2";
            // 
            // subject3
            // 
            this.subject3.AutoSize = true;
            this.subject3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject3.Location = new System.Drawing.Point(77, 208);
            this.subject3.Name = "subject3";
            this.subject3.Size = new System.Drawing.Size(85, 20);
            this.subject3.TabIndex = 2;
            this.subject3.Text = "Subject 3";
            // 
            // mark1txtbox
            // 
            this.mark1txtbox.Location = new System.Drawing.Point(500, 101);
            this.mark1txtbox.Name = "mark1txtbox";
            this.mark1txtbox.Size = new System.Drawing.Size(120, 20);
            this.mark1txtbox.TabIndex = 3;
            // 
            // mark2txtbox
            // 
            this.mark2txtbox.Location = new System.Drawing.Point(500, 150);
            this.mark2txtbox.Name = "mark2txtbox";
            this.mark2txtbox.Size = new System.Drawing.Size(120, 20);
            this.mark2txtbox.TabIndex = 4;
            // 
            // mark3txtbox
            // 
            this.mark3txtbox.Location = new System.Drawing.Point(500, 206);
            this.mark3txtbox.Name = "mark3txtbox";
            this.mark3txtbox.Size = new System.Drawing.Size(120, 20);
            this.mark3txtbox.TabIndex = 5;
            // 
            // markbutton
            // 
            this.markbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markbutton.Location = new System.Drawing.Point(424, 276);
            this.markbutton.Name = "markbutton";
            this.markbutton.Size = new System.Drawing.Size(196, 42);
            this.markbutton.TabIndex = 6;
            this.markbutton.Text = "Submit";
            this.markbutton.UseVisualStyleBackColor = true;
            this.markbutton.Click += new System.EventHandler(this.markbutton_Click);
            // 
            // insermark
            // 
            this.insermark.AutoSize = true;
            this.insermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insermark.Location = new System.Drawing.Point(12, 22);
            this.insermark.Name = "insermark";
            this.insermark.Size = new System.Drawing.Size(75, 18);
            this.insermark.TabIndex = 7;
            this.insermark.Text = "Add mark:";
            // 
            // regtextbox
            // 
            this.regtextbox.Location = new System.Drawing.Point(12, 43);
            this.regtextbox.Name = "regtextbox";
            this.regtextbox.Size = new System.Drawing.Size(159, 20);
            this.regtextbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Semester";
            // 
            // SemcomboBox
            // 
            this.SemcomboBox.FormattingEnabled = true;
            this.SemcomboBox.Location = new System.Drawing.Point(200, 76);
            this.SemcomboBox.Name = "SemcomboBox";
            this.SemcomboBox.Size = new System.Drawing.Size(124, 21);
            this.SemcomboBox.TabIndex = 11;
            this.SemcomboBox.SelectedIndexChanged += new System.EventHandler(this.SemcomboBox_SelectedIndexChanged);
            // 
            // sub1textBox
            // 
            this.sub1textBox.Location = new System.Drawing.Point(200, 113);
            this.sub1textBox.Name = "sub1textBox";
            this.sub1textBox.Size = new System.Drawing.Size(124, 20);
            this.sub1textBox.TabIndex = 12;
            // 
            // sub2textBox
            // 
            this.sub2textBox.Location = new System.Drawing.Point(200, 159);
            this.sub2textBox.Name = "sub2textBox";
            this.sub2textBox.Size = new System.Drawing.Size(124, 20);
            this.sub2textBox.TabIndex = 13;
            // 
            // sub3textBox
            // 
            this.sub3textBox.Location = new System.Drawing.Point(200, 210);
            this.sub3textBox.Name = "sub3textBox";
            this.sub3textBox.Size = new System.Drawing.Size(124, 20);
            this.sub3textBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "mark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mark";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(469, 22);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(129, 16);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "PREVIOUS PAGE";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // addmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(646, 361);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sub3textBox);
            this.Controls.Add(this.sub2textBox);
            this.Controls.Add(this.sub1textBox);
            this.Controls.Add(this.SemcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regtextbox);
            this.Controls.Add(this.insermark);
            this.Controls.Add(this.markbutton);
            this.Controls.Add(this.mark3txtbox);
            this.Controls.Add(this.mark2txtbox);
            this.Controls.Add(this.mark1txtbox);
            this.Controls.Add(this.subject3);
            this.Controls.Add(this.subject2);
            this.Controls.Add(this.subject1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addmark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addmark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subject1;
        private System.Windows.Forms.Label subject2;
        private System.Windows.Forms.Label subject3;
        private System.Windows.Forms.TextBox mark1txtbox;
        private System.Windows.Forms.TextBox mark2txtbox;
        private System.Windows.Forms.TextBox mark3txtbox;
        private System.Windows.Forms.Button markbutton;
        private System.Windows.Forms.Label insermark;
        private System.Windows.Forms.TextBox regtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SemcomboBox;
        private System.Windows.Forms.TextBox sub1textBox;
        private System.Windows.Forms.TextBox sub2textBox;
        private System.Windows.Forms.TextBox sub3textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}