namespace StudentInformationSystem
{
    partial class SortForm
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
            this.Sortlabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.viewbutton1 = new System.Windows.Forms.Button();
            this.sortcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.depcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sortlabel
            // 
            this.Sortlabel.AutoSize = true;
            this.Sortlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sortlabel.Location = new System.Drawing.Point(404, 71);
            this.Sortlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sortlabel.Name = "Sortlabel";
            this.Sortlabel.Size = new System.Drawing.Size(72, 17);
            this.Sortlabel.TabIndex = 1;
            this.Sortlabel.Text = "COURSE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1015, 289);
            this.dataGridView1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(869, 26);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(158, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "PREVIOUS PAGE";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // viewbutton1
            // 
            this.viewbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbutton1.ForeColor = System.Drawing.Color.Olive;
            this.viewbutton1.Location = new System.Drawing.Point(901, 65);
            this.viewbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewbutton1.Name = "viewbutton1";
            this.viewbutton1.Size = new System.Drawing.Size(140, 28);
            this.viewbutton1.TabIndex = 4;
            this.viewbutton1.Text = "VIEW DATA";
            this.viewbutton1.UseVisualStyleBackColor = true;
            this.viewbutton1.Click += new System.EventHandler(this.viewbutton1_Click);
            // 
            // sortcomboBox
            // 
            this.sortcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortcomboBox.FormattingEnabled = true;
            this.sortcomboBox.Items.AddRange(new object[] {
            "Computer Science and Engineering",
            "IT",
            "Electronics and Communication Engineering",
            "Electrical and Electronics Engineering"});
            this.sortcomboBox.Location = new System.Drawing.Point(489, 64);
            this.sortcomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortcomboBox.Name = "sortcomboBox";
            this.sortcomboBox.Size = new System.Drawing.Size(211, 25);
            this.sortcomboBox.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 92;
            this.label1.Text = "DEPARTMENT NAME";
            // 
            // depcomboBox
            // 
            this.depcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depcomboBox.FormattingEnabled = true;
            this.depcomboBox.Items.AddRange(new object[] {
            "Computer Science",
            "Electronics"});
            this.depcomboBox.Location = new System.Drawing.Point(195, 64);
            this.depcomboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depcomboBox.Name = "depcomboBox";
            this.depcomboBox.Size = new System.Drawing.Size(192, 25);
            this.depcomboBox.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(709, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "SEMESTER";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox2.Location = new System.Drawing.Point(812, 68);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 24);
            this.comboBox2.TabIndex = 95;
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1073, 471);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortcomboBox);
            this.Controls.Add(this.viewbutton1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sortlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SortForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Sortlabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button viewbutton1;
        private System.Windows.Forms.ComboBox sortcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox depcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}