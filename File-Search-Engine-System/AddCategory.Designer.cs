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
            this.components = new System.ComponentModel.Container();
            this.AddCatTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AddcatLbL = new System.Windows.Forms.Label();
            this.AddKeywordLbl = new System.Windows.Forms.Label();
            this.AddKeywordTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCatTextBox
            // 
            this.AddCatTextBox.Location = new System.Drawing.Point(325, 47);
            this.AddCatTextBox.Name = "AddCatTextBox";
            this.AddCatTextBox.Size = new System.Drawing.Size(100, 22);
            this.AddCatTextBox.TabIndex = 0;
            // 
            // AddcatLbL
            // 
            this.AddcatLbL.AutoSize = true;
            this.AddcatLbL.Location = new System.Drawing.Point(49, 52);
            this.AddcatLbL.Name = "AddcatLbL";
            this.AddcatLbL.Size = new System.Drawing.Size(135, 17);
            this.AddcatLbL.TabIndex = 1;
            this.AddcatLbL.Text = "Add Category Name";
            // 
            // AddKeywordLbl
            // 
            this.AddKeywordLbl.AutoSize = true;
            this.AddKeywordLbl.Location = new System.Drawing.Point(49, 199);
            this.AddKeywordLbl.Name = "AddKeywordLbl";
            this.AddKeywordLbl.Size = new System.Drawing.Size(91, 17);
            this.AddKeywordLbl.TabIndex = 2;
            this.AddKeywordLbl.Text = "Add Keyword";
            // 
            // AddKeywordTextBox
            // 
            this.AddKeywordTextBox.Location = new System.Drawing.Point(325, 194);
            this.AddKeywordTextBox.Name = "AddKeywordTextBox";
            this.AddKeywordTextBox.Size = new System.Drawing.Size(100, 22);
            this.AddKeywordTextBox.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(224, 289);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Done";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 500);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddKeywordTextBox);
            this.Controls.Add(this.AddKeywordLbl);
            this.Controls.Add(this.AddcatLbL);
            this.Controls.Add(this.AddCatTextBox);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddCatTextBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label AddcatLbL;
        private System.Windows.Forms.Label AddKeywordLbl;
        private System.Windows.Forms.TextBox AddKeywordTextBox;
        private System.Windows.Forms.Button AddButton;
    }
}