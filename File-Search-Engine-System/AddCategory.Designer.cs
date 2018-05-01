namespace File_Search_Engine_System
{
    partial class AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            this.CategorytextBox = new System.Windows.Forms.TextBox();
            this.KeywordtextBox = new System.Windows.Forms.TextBox();
            this.AddKeywordButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.filesButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.catCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategorytextBox
            // 
            this.CategorytextBox.Location = new System.Drawing.Point(504, 120);
            this.CategorytextBox.Name = "CategorytextBox";
            this.CategorytextBox.Size = new System.Drawing.Size(168, 24);
            this.CategorytextBox.TabIndex = 0;
            // 
            // KeywordtextBox
            // 
            this.KeywordtextBox.Location = new System.Drawing.Point(504, 171);
            this.KeywordtextBox.Name = "KeywordtextBox";
            this.KeywordtextBox.Size = new System.Drawing.Size(168, 24);
            this.KeywordtextBox.TabIndex = 1;
            // 
            // AddKeywordButton
            // 
            this.AddKeywordButton.Location = new System.Drawing.Point(723, 166);
            this.AddKeywordButton.Name = "AddKeywordButton";
            this.AddKeywordButton.Size = new System.Drawing.Size(66, 32);
            this.AddKeywordButton.TabIndex = 3;
            this.AddKeywordButton.Text = "Add";
            this.AddKeywordButton.UseVisualStyleBackColor = true;
            this.AddKeywordButton.Click += new System.EventHandler(this.AddKeywordButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(820, 171);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(66, 23);
            this.DoneButton.TabIndex = 4;
            this.DoneButton.Text = "DONE";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // filesButton
            // 
            this.filesButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.filesButton.FlatAppearance.BorderSize = 0;
            this.filesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filesButton.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(40)))));
            this.filesButton.Image = global::File_Search_Engine_System.Properties.Resources.folder;
            this.filesButton.Location = new System.Drawing.Point(-3, 319);
            this.filesButton.Name = "filesButton";
            this.filesButton.Size = new System.Drawing.Size(315, 315);
            this.filesButton.TabIndex = 11;
            this.filesButton.Text = "Files";
            this.filesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.filesButton.UseVisualStyleBackColor = false;
            this.filesButton.Click += new System.EventHandler(this.filesButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(40)))));
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(-3, -2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(315, 315);
            this.homeButton.TabIndex = 12;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(515, 9);
            this.label1.MaximumSize = new System.Drawing.Size(500, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 70);
            this.label1.TabIndex = 13;
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.BackColor = System.Drawing.Color.White;
            this.infoRichTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.infoRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(44)))));
            this.infoRichTextBox.Location = new System.Drawing.Point(395, 421);
            this.infoRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.ReadOnly = true;
            this.infoRichTextBox.Size = new System.Drawing.Size(452, 185);
            this.infoRichTextBox.TabIndex = 21;
            this.infoRichTextBox.Text = "";
            this.infoRichTextBox.Visible = false;
            // 
            // catCombo
            // 
            this.catCombo.BackColor = System.Drawing.Color.White;
            this.catCombo.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.catCombo.FormattingEnabled = true;
            this.catCombo.Location = new System.Drawing.Point(560, 373);
            this.catCombo.Name = "catCombo";
            this.catCombo.Size = new System.Drawing.Size(261, 34);
            this.catCombo.TabIndex = 20;
            this.catCombo.SelectedIndexChanged += new System.EventHandler(this.catCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(6)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(409, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Category Info:";
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(915, 633);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.catCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.filesButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.AddKeywordButton);
            this.Controls.Add(this.KeywordtextBox);
            this.Controls.Add(this.CategorytextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCategory_FormClosed);
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CategorytextBox;
        private System.Windows.Forms.TextBox KeywordtextBox;
        private System.Windows.Forms.Button AddKeywordButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button filesButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.ComboBox catCombo;
        private System.Windows.Forms.Label label4;
    }
}

