namespace File_Search_Engine_System
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.searchRichTextBox = new System.Windows.Forms.RichTextBox();
            this.filesButton = new System.Windows.Forms.Button();
            this.catButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.fileCombo = new System.Windows.Forms.ComboBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchCombo
            // 
            this.searchCombo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.Location = new System.Drawing.Point(360, 97);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(485, 34);
            this.searchCombo.TabIndex = 6;
            // 
            // searchRichTextBox
            // 
            this.searchRichTextBox.BackColor = System.Drawing.Color.White;
            this.searchRichTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchRichTextBox.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.searchRichTextBox.Location = new System.Drawing.Point(360, 146);
            this.searchRichTextBox.Name = "searchRichTextBox";
            this.searchRichTextBox.ReadOnly = true;
            this.searchRichTextBox.Size = new System.Drawing.Size(485, 340);
            this.searchRichTextBox.TabIndex = 7;
            this.searchRichTextBox.Text = "";
            this.searchRichTextBox.Visible = false;
            // 
            // filesButton
            // 
            this.filesButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.filesButton.FlatAppearance.BorderSize = 0;
            this.filesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filesButton.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(40)))));
            this.filesButton.Image = global::File_Search_Engine_System.Properties.Resources.folder;
            this.filesButton.Location = new System.Drawing.Point(0, 321);
            this.filesButton.Name = "filesButton";
            this.filesButton.Size = new System.Drawing.Size(315, 315);
            this.filesButton.TabIndex = 10;
            this.filesButton.Text = "Files";
            this.filesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.filesButton.UseVisualStyleBackColor = false;
            this.filesButton.Click += new System.EventHandler(this.filesButton_Click);
            // 
            // catButton
            // 
            this.catButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.catButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.catButton.FlatAppearance.BorderSize = 0;
            this.catButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catButton.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(40)))));
            this.catButton.Image = global::File_Search_Engine_System.Properties.Resources.icon__2_;
            this.catButton.Location = new System.Drawing.Point(0, 0);
            this.catButton.Name = "catButton";
            this.catButton.Size = new System.Drawing.Size(315, 315);
            this.catButton.TabIndex = 9;
            this.catButton.Text = "Categories";
            this.catButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.catButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.catButton.UseVisualStyleBackColor = false;
            this.catButton.Click += new System.EventHandler(this.catButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Image = global::File_Search_Engine_System.Properties.Resources.file;
            this.SearchButton.Location = new System.Drawing.Point(851, 92);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(35, 40);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(512, 9);
            this.label1.MaximumSize = new System.Drawing.Size(500, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 70);
            this.label1.TabIndex = 12;
            // 
            // viewButton
            // 
            this.viewButton.FlatAppearance.BorderSize = 0;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.Image = ((System.Drawing.Image)(resources.GetObject("viewButton.Image")));
            this.viewButton.Location = new System.Drawing.Point(851, 559);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(41, 34);
            this.viewButton.TabIndex = 13;
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Visible = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // fileCombo
            // 
            this.fileCombo.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.fileCombo.FormattingEnabled = true;
            this.fileCombo.Location = new System.Drawing.Point(584, 559);
            this.fileCombo.Name = "fileCombo";
            this.fileCombo.Size = new System.Drawing.Size(261, 34);
            this.fileCombo.TabIndex = 14;
            this.fileCombo.Visible = false;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.fileLabel.Location = new System.Drawing.Point(355, 519);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(361, 26);
            this.fileLabel.TabIndex = 15;
            this.fileLabel.Text = "View search results in a specific file:";
            this.fileLabel.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(915, 633);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.fileCombo);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filesButton);
            this.Controls.Add(this.catButton);
            this.Controls.Add(this.searchRichTextBox);
            this.Controls.Add(this.searchCombo);
            this.Controls.Add(this.SearchButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.RichTextBox searchRichTextBox;
        private System.Windows.Forms.Button catButton;
        private System.Windows.Forms.Button filesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.ComboBox fileCombo;
        private System.Windows.Forms.Label fileLabel;
    }
}