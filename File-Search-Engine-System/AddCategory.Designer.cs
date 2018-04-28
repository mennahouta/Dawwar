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
            this.CategorytextBox = new System.Windows.Forms.TextBox();
            this.KeywordtextBox = new System.Windows.Forms.TextBox();
            this.AddKeywordButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategorytextBox
            // 
            this.CategorytextBox.Location = new System.Drawing.Point(186, 121);
            this.CategorytextBox.Name = "CategorytextBox";
            this.CategorytextBox.Size = new System.Drawing.Size(168, 24);
            this.CategorytextBox.TabIndex = 0;
            // 
            // KeywordtextBox
            // 
            this.KeywordtextBox.Location = new System.Drawing.Point(186, 224);
            this.KeywordtextBox.Name = "KeywordtextBox";
            this.KeywordtextBox.Size = new System.Drawing.Size(168, 24);
            this.KeywordtextBox.TabIndex = 1;
            // 
            // AddKeywordButton
            // 
            this.AddKeywordButton.Location = new System.Drawing.Point(395, 111);
            this.AddKeywordButton.Name = "AddKeywordButton";
            this.AddKeywordButton.Size = new System.Drawing.Size(66, 32);
            this.AddKeywordButton.TabIndex = 3;
            this.AddKeywordButton.Text = "Add";
            this.AddKeywordButton.UseVisualStyleBackColor = true;
            this.AddKeywordButton.Click += new System.EventHandler(this.AddKeywordButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(232, 350);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(66, 23);
            this.DoneButton.TabIndex = 4;
            this.DoneButton.Text = "DONE";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(400, 368);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 35);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(526, 459);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.AddKeywordButton);
            this.Controls.Add(this.KeywordtextBox);
            this.Controls.Add(this.CategorytextBox);
            this.Name = "AddCategory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CategorytextBox;
        private System.Windows.Forms.TextBox KeywordtextBox;
        private System.Windows.Forms.Button AddKeywordButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button homeButton;
    }
}

