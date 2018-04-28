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
            this.SearchButton = new System.Windows.Forms.Button();
            this.CategoryEditComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.searchRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(554, 67);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(35, 32);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "S";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CategoryEditComboBox
            // 
            this.CategoryEditComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryEditComboBox.FormattingEnabled = true;
            this.CategoryEditComboBox.Items.AddRange(new object[] {
            "Add",
            "Edit"});
            this.CategoryEditComboBox.Location = new System.Drawing.Point(210, 470);
            this.CategoryEditComboBox.Name = "CategoryEditComboBox";
            this.CategoryEditComboBox.Size = new System.Drawing.Size(121, 32);
            this.CategoryEditComboBox.TabIndex = 2;
            this.CategoryEditComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryEditComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Files";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add",
            "Edit"});
            this.comboBox1.Location = new System.Drawing.Point(468, 470);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // searchCombo
            // 
            this.searchCombo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.Items.AddRange(new object[] {
            "Sport",
            "Movies"});
            this.searchCombo.Location = new System.Drawing.Point(103, 67);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(445, 32);
            this.searchCombo.TabIndex = 6;
            // 
            // searchRichTextBox
            // 
            this.searchRichTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.searchRichTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchRichTextBox.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRichTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.searchRichTextBox.Location = new System.Drawing.Point(103, 123);
            this.searchRichTextBox.Name = "searchRichTextBox";
            this.searchRichTextBox.ReadOnly = true;
            this.searchRichTextBox.Size = new System.Drawing.Size(486, 321);
            this.searchRichTextBox.TabIndex = 7;
            this.searchRichTextBox.Text = "";
            this.searchRichTextBox.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 527);
            this.Controls.Add(this.searchRichTextBox);
            this.Controls.Add(this.searchCombo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryEditComboBox);
            this.Controls.Add(this.SearchButton);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox CategoryEditComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.RichTextBox searchRichTextBox;
    }
}