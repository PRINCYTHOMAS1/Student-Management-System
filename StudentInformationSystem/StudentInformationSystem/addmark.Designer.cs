namespace StudentInformationSystem
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
            this.SuspendLayout();
            // 
            // subject1
            // 
            this.subject1.AutoSize = true;
            this.subject1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject1.Location = new System.Drawing.Point(77, 111);
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
            this.mark1txtbox.Location = new System.Drawing.Point(196, 111);
            this.mark1txtbox.Name = "mark1txtbox";
            this.mark1txtbox.Size = new System.Drawing.Size(46, 20);
            this.mark1txtbox.TabIndex = 3;
            // 
            // mark2txtbox
            // 
            this.mark2txtbox.Location = new System.Drawing.Point(196, 159);
            this.mark2txtbox.Name = "mark2txtbox";
            this.mark2txtbox.Size = new System.Drawing.Size(46, 20);
            this.mark2txtbox.TabIndex = 4;
            // 
            // mark3txtbox
            // 
            this.mark3txtbox.Location = new System.Drawing.Point(196, 210);
            this.mark3txtbox.Name = "mark3txtbox";
            this.mark3txtbox.Size = new System.Drawing.Size(46, 20);
            this.mark3txtbox.TabIndex = 5;
            // 
            // markbutton
            // 
            this.markbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markbutton.Location = new System.Drawing.Point(141, 278);
            this.markbutton.Name = "markbutton";
            this.markbutton.Size = new System.Drawing.Size(75, 30);
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
            this.SemcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.SemcomboBox.Location = new System.Drawing.Point(196, 79);
            this.SemcomboBox.Name = "SemcomboBox";
            this.SemcomboBox.Size = new System.Drawing.Size(118, 21);
            this.SemcomboBox.TabIndex = 11;
            // 
            // addmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(384, 361);
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
    }
}