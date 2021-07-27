
namespace Connected_Database
{
    partial class Form1
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
            this.rollNo_TextBox = new System.Windows.Forms.TextBox();
            this.Branch_TextBox = new System.Windows.Forms.TextBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.create_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rollNo_TextBox
            // 
            this.rollNo_TextBox.Location = new System.Drawing.Point(72, 41);
            this.rollNo_TextBox.Name = "rollNo_TextBox";
            this.rollNo_TextBox.Size = new System.Drawing.Size(100, 20);
            this.rollNo_TextBox.TabIndex = 0;
            // 
            // Branch_TextBox
            // 
            this.Branch_TextBox.Location = new System.Drawing.Point(72, 173);
            this.Branch_TextBox.Name = "Branch_TextBox";
            this.Branch_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Branch_TextBox.TabIndex = 1;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(72, 97);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Name_TextBox.TabIndex = 2;
            // 
            // create_Button
            // 
            this.create_Button.Location = new System.Drawing.Point(72, 237);
            this.create_Button.Name = "create_Button";
            this.create_Button.Size = new System.Drawing.Size(100, 36);
            this.create_Button.TabIndex = 3;
            this.create_Button.Text = "Create";
            this.create_Button.UseVisualStyleBackColor = true;
            this.create_Button.Click += new System.EventHandler(this.create_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(204, 237);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(100, 36);
            this.Update_Button.TabIndex = 4;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(340, 237);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(100, 36);
            this.Delete_Button.TabIndex = 5;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.create_Button);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.Branch_TextBox);
            this.Controls.Add(this.rollNo_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rollNo_TextBox;
        private System.Windows.Forms.TextBox Branch_TextBox;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Button create_Button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Delete_Button;
    }
}

