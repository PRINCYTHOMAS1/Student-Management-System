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
            this.mark1 = new System.Windows.Forms.TextBox();
            this.mark2 = new System.Windows.Forms.TextBox();
            this.mark3 = new System.Windows.Forms.TextBox();
            this.markbutton = new System.Windows.Forms.Button();
            this.insermark = new System.Windows.Forms.Label();
            this.regtext = new System.Windows.Forms.TextBox();
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
            // mark1
            // 
            this.mark1.Location = new System.Drawing.Point(196, 111);
            this.mark1.Name = "mark1";
            this.mark1.Size = new System.Drawing.Size(46, 20);
            this.mark1.TabIndex = 3;
            // 
            // mark2
            // 
            this.mark2.Location = new System.Drawing.Point(196, 159);
            this.mark2.Name = "mark2";
            this.mark2.Size = new System.Drawing.Size(46, 20);
            this.mark2.TabIndex = 4;
            // 
            // mark3
            // 
            this.mark3.Location = new System.Drawing.Point(196, 210);
            this.mark3.Name = "mark3";
            this.mark3.Size = new System.Drawing.Size(46, 20);
            this.mark3.TabIndex = 5;
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
            // regtext
            // 
            this.regtext.Location = new System.Drawing.Point(179, 57);
            this.regtext.Name = "regtext";
            this.regtext.Size = new System.Drawing.Size(100, 20);
            this.regtext.TabIndex = 8;
            // 
            // addmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.regtext);
            this.Controls.Add(this.insermark);
            this.Controls.Add(this.markbutton);
            this.Controls.Add(this.mark3);
            this.Controls.Add(this.mark2);
            this.Controls.Add(this.mark1);
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
        private System.Windows.Forms.TextBox mark1;
        private System.Windows.Forms.TextBox mark2;
        private System.Windows.Forms.TextBox mark3;
        private System.Windows.Forms.Button markbutton;
        private System.Windows.Forms.Label insermark;
        private System.Windows.Forms.TextBox regtext;
    }
}