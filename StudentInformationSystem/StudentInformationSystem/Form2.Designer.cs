namespace StudentInformationSystem
{
    partial class Form2
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
            this.emailidtxt = new System.Windows.Forms.TextBox();
            this.passwordbtn = new System.Windows.Forms.Button();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.confirmpasswordtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailidtxt
            // 
            this.emailidtxt.Location = new System.Drawing.Point(241, 84);
            this.emailidtxt.Name = "emailidtxt";
            this.emailidtxt.Size = new System.Drawing.Size(229, 20);
            this.emailidtxt.TabIndex = 1;
            // 
            // passwordbtn
            // 
            this.passwordbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.passwordbtn.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordbtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.passwordbtn.Location = new System.Drawing.Point(119, 249);
            this.passwordbtn.Name = "passwordbtn";
            this.passwordbtn.Size = new System.Drawing.Size(213, 43);
            this.passwordbtn.TabIndex = 2;
            this.passwordbtn.Text = "Submit";
            this.passwordbtn.UseVisualStyleBackColor = false;
            this.passwordbtn.Click += new System.EventHandler(this.passwordbtn_Click);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(241, 128);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(229, 20);
            this.passwordtxt.TabIndex = 3;
            this.passwordtxt.TextChanged += new System.EventHandler(this.passwordtxt_TextChanged);
            // 
            // confirmpasswordtxt
            // 
            this.confirmpasswordtxt.Location = new System.Drawing.Point(241, 182);
            this.confirmpasswordtxt.Name = "confirmpasswordtxt";
            this.confirmpasswordtxt.Size = new System.Drawing.Size(229, 20);
            this.confirmpasswordtxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "RESET PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirm New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter your Email Id";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmpasswordtxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.passwordbtn);
            this.Controls.Add(this.emailidtxt);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailidtxt;
        private System.Windows.Forms.Button passwordbtn;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox confirmpasswordtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}