namespace File_Search_Engine_System
{
    partial class EditCategory
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
            this.comboBoxSelectCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteKeyword = new System.Windows.Forms.Button();
            this.comboBoxDeleteKeyword = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddKeyword = new System.Windows.Forms.TextBox();
            this.buttonAddKeyword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSelectCat
            // 
            this.comboBoxSelectCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectCat.FormattingEnabled = true;
            this.comboBoxSelectCat.Location = new System.Drawing.Point(196, 52);
            this.comboBoxSelectCat.Name = "comboBoxSelectCat";
            this.comboBoxSelectCat.Size = new System.Drawing.Size(223, 26);
            this.comboBoxSelectCat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Category :";
            // 
            // buttonDeleteKeyword
            // 
            this.buttonDeleteKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteKeyword.Location = new System.Drawing.Point(355, 248);
            this.buttonDeleteKeyword.Name = "buttonDeleteKeyword";
            this.buttonDeleteKeyword.Size = new System.Drawing.Size(75, 31);
            this.buttonDeleteKeyword.TabIndex = 3;
            this.buttonDeleteKeyword.Text = "Delete";
            this.buttonDeleteKeyword.UseVisualStyleBackColor = true;
            // 
            // comboBoxDeleteKeyword
            // 
            this.comboBoxDeleteKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDeleteKeyword.FormattingEnabled = true;
            this.comboBoxDeleteKeyword.Location = new System.Drawing.Point(61, 248);
            this.comboBoxDeleteKeyword.Name = "comboBoxDeleteKeyword";
            this.comboBoxDeleteKeyword.Size = new System.Drawing.Size(266, 26);
            this.comboBoxDeleteKeyword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select keyword to be deleted :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter a new keyword to be Added :";
            // 
            // textBoxAddKeyword
            // 
            this.textBoxAddKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddKeyword.Location = new System.Drawing.Point(61, 162);
            this.textBoxAddKeyword.Name = "textBoxAddKeyword";
            this.textBoxAddKeyword.Size = new System.Drawing.Size(266, 24);
            this.textBoxAddKeyword.TabIndex = 7;
            // 
            // buttonAddKeyword
            // 
            this.buttonAddKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddKeyword.Location = new System.Drawing.Point(355, 161);
            this.buttonAddKeyword.Name = "buttonAddKeyword";
            this.buttonAddKeyword.Size = new System.Drawing.Size(75, 29);
            this.buttonAddKeyword.TabIndex = 8;
            this.buttonAddKeyword.Text = "Add";
            this.buttonAddKeyword.UseVisualStyleBackColor = true;
            // 
            // EditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 336);
            this.Controls.Add(this.buttonAddKeyword);
            this.Controls.Add(this.textBoxAddKeyword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDeleteKeyword);
            this.Controls.Add(this.buttonDeleteKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectCat);
            this.Name = "EditCategory";
            this.Text = "EditCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteKeyword;
        private System.Windows.Forms.ComboBox comboBoxDeleteKeyword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddKeyword;
        private System.Windows.Forms.Button buttonAddKeyword;
    }
}