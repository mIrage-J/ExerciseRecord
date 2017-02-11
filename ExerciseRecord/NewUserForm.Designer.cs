namespace ExerciseRecord
{
    partial class NewUserForm
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
            this.newUserNameTextBox = new System.Windows.Forms.TextBox();
            this.createUserbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newUserNameTextBox
            // 
            this.newUserNameTextBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newUserNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.newUserNameTextBox.Name = "newUserNameTextBox";
            this.newUserNameTextBox.Size = new System.Drawing.Size(167, 26);
            this.newUserNameTextBox.TabIndex = 0;
            this.newUserNameTextBox.Text = "输入您的名字";
            this.newUserNameTextBox.Click += new System.EventHandler(this.newUserNameTextBox_Click);
            this.newUserNameTextBox.TextChanged += new System.EventHandler(this.newUserNameTextBox_TextChanged);
            // 
            // createUserbutton
            // 
            this.createUserbutton.Location = new System.Drawing.Point(185, 12);
            this.createUserbutton.Name = "createUserbutton";
            this.createUserbutton.Size = new System.Drawing.Size(99, 26);
            this.createUserbutton.TabIndex = 1;
            this.createUserbutton.Text = "确定";
            this.createUserbutton.UseVisualStyleBackColor = true;
            this.createUserbutton.Visible = false;
            this.createUserbutton.Click += new System.EventHandler(this.createUserbutton_Click);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 51);
            this.Controls.Add(this.createUserbutton);
            this.Controls.Add(this.newUserNameTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUserForm";
            this.Text = "建立新用户";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newUserNameTextBox;
        private System.Windows.Forms.Button createUserbutton;
    }
}