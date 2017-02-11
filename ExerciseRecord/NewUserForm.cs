using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseRecord
{
    public partial class NewUserForm : Form
    {
        Form1 mainForm;

        public NewUserForm()
        {
            InitializeComponent();
            mainForm= (Form1)this.Owner;
        }        

        private void createUserbutton_Click(object sender, EventArgs e)
        {
            if (newUserNameTextBox.Text == "")
            {
                MessageBox.Show("请输入用户名");
                return;
            }
            OnCreateNewUser(new UserNameEventArgs());
            this.Close();
        }

        private void newUserNameTextBox_Click(object sender, EventArgs e)
        {
            newUserNameTextBox.Text = "";            
        }

        private void newUserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            createUserbutton.Visible = true;
        }

        public event EventHandler<UserNameEventArgs> CreateNewUser;

        public void OnCreateNewUser(UserNameEventArgs e)
        {
            if (CreateNewUser != null)
            {
                //暂时停用以下语句
                //mainForm.NewUserName = newUserNameTextBox.Text;

                e.UserName = newUserNameTextBox.Text;
                CreateNewUser(this, e);
            }
        }        
    }
    public class UserNameEventArgs : EventArgs
    {
        public string UserName { get; set; }
    }
    
}
