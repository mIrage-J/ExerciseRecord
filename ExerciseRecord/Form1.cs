using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ExerciseRecord
{
    public partial class Form1 : Form
    {
        public string RecordFile;
        BusinessLogicLayer middleLayer;
        DateTime currentDay;
        DateTime trainingStartTime;
        bool timerStarted;        

        /// <summary>
        /// 获取程序是否载入完毕
        /// </summary>
        bool programReady = false;

        private NewUserForm newUserForm = new NewUserForm();


        public Form1()
        {
            InitializeComponent();

            
            
            newUserForm.Owner = this;
            newUserForm.CreateNewUser += NewUserForm_CreateNewUser;
            newUserForm.FormClosed += ShowMainForm;

            

            if (GetLastFile(ref RecordFile))
            {
                middleLayer = new BusinessLogicLayer(RecordFile);
                LoadRecordFormFile();

            }
            else
            {
                if (MessageBox.Show("是否建立新的锻炼档案", "没有已存在的档案", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Hide();
                    newUserForm.Show(this);
                }
            }
            
        }



        private void ShowMainForm(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void NewUserForm_CreateNewUser(object sender, UserNameEventArgs e)
        {
            middleLayer = new BusinessLogicLayer(e.UserName, true);
            LoadRecordFormFile();
            bindingSource.Add(new Entry("", currentDay, TimeSpan.Parse("0")));
        }

        private void LoadRecordFormFile()
        {
            currentDay = middleLayer.DateTime.Date;
            dateTimePicker.Value = currentDay;
            bindingSource.DataSource = middleLayer.Record;
            recordGird.DataSource = bindingSource;
            AdjustRecordGird();
            this.Text = middleLayer.Owner + "'s Exercises' Records";
            recordGird.Columns[3].Visible = false;
            recordGird.Columns[1].ReadOnly = true;
            recordGird.Columns[2].ReadOnly = true;

            programReady = true;
        }

        /// <summary>
        /// 获取当前文件夹内最后修改过的xml文件
        /// </summary>
        /// <param name="lastFile">xml文件的完整路径，包括文件名</param>
        /// <returns>若当前文件夹内没有xml文件，则返回false</returns>        
        private static bool GetLastFile(ref string lastFile)
        {
            String[] fileNames = Directory.GetFiles(Directory.GetCurrentDirectory());
            DateTime fileTime = new DateTime();
            lastFile = "";
            foreach (string file in fileNames)
            {
                if (file.Contains("xml") || (file.Contains("XML")))
                    if (fileTime < File.GetLastWriteTime(file))
                    {
                        fileTime = File.GetLastWriteTime(file);
                        lastFile = file;
                    }
            }
            if (lastFile == "")
                return false;
            else
                return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectCurrentDayRecords();
            openFileDialog1.Filter = "xml|*.xml;*.XML";
            openFileDialog1.Title = "打开现有记录文件";
            openFileDialog1.FileName = "";
        }

        private void recordGird_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;

        }

        private void addRowButoon_Click(object sender, EventArgs e)
        {
            bindingSource.Add(new Entry("", currentDay, TimeSpan.Parse("0")));
            SelectCurrentDayRecords();
        }

        private void removeRowButton_Click(object sender, EventArgs e)
        {
            if (recordGird.CurrentRow == null)
            {
                if (recordGird.Rows.Count < 1)
                    MessageBox.Show("请选择要删除的记录");
            }
            else
            {
                bindingSource.RemoveAt(recordGird.CurrentRow.Index);
            }
        }

        //由于已改为实时保存数据，因此(button)Save的功能弃用
        private void saveButton_Click(object sender, EventArgs e)
        {
            middleLayer.SaveRecord();
            MessageBox.Show("已保存");
        }

        private void SelectCurrentDayRecords()
        {
            if (programReady)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[recordGird.DataSource];
                cm.SuspendBinding();
                for (int i = 0; i < middleLayer.Record.Count(); i++)
                {
                    recordGird.Rows[i].Visible = true;
                    if (middleLayer.Record[i].DateTime.Date != currentDay.Date)
                        recordGird.Rows[i].Visible = false;
                }
                cm.ResumeBinding();
            }
        }

        /// <summary>
        /// 设置recordGird中各列的宽度
        /// </summary>
        private void AdjustRecordGird()
        {
            recordGird.Columns[0].Width = 500;
            recordGird.Columns[1].Width = 150;
            recordGird.Columns[2].Width = 150;
            recordGird.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            recordGird.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (programReady)
            {
                currentDay = dateTimePicker.Value;
                SelectCurrentDayRecords();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("是否建立新档案", "建立新档案", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (MessageBox.Show("是否保存当前记录", "保存", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    middleLayer.SaveRecord();
                    MessageBox.Show("已保存");
                }
                //防止newUserForm在执行释放命令后没有内存回收导致的冲突
                if (newUserForm.IsDisposed)
                {
                    newUserForm = new NewUserForm();
                    newUserForm.Owner = this;
                    newUserForm.CreateNewUser += NewUserForm_CreateNewUser;
                    newUserForm.FormClosed += ShowMainForm;
                }
                newUserForm.Show(this);
                this.Hide();
                //以下语句整合到事件处理方法NewUserForm_CreateNewUser中
                //boundary = new Boundary(NewUserName, true);
                //LoadRecordFormFile();
            }
        }

        private void stratButton_Click(object sender, EventArgs e)
        {
            if (recordGird.CurrentRow == null)
            {
                MessageBox.Show("请选择要计时的条目");
                return;
            }
            if ((TimeSpan)recordGird.CurrentRow.Cells[2].Value != TimeSpan.Parse("0"))
            {
                if (MessageBox.Show("当前条目有时长记录，确定重新计时？", "Warning", MessageBoxButtons.YesNo) ==
                    DialogResult.No)
                    return;
            }
            trainingStartTime = DateTime.Now;
            timerForStripStatus.Start();
            timerStarted = true;
        }

        private void endTimingButton_Click(object sender, EventArgs e)
        {
            if (timerStarted)
            {
                if (recordGird.CurrentRow.Cells[2].Value is TimeSpan)
                {
                    recordGird.CurrentRow.Cells[2].Value = TimeSpan.Parse(RemoveDecimalOfSeconds(DateTime.Now - trainingStartTime));

                    MessageBox.Show("此次锻炼时长为:" + recordGird.CurrentRow.Cells[2].Value.ToString());
                    middleLayer.SaveRecord();
                }
                timerForStripStatus.Stop();
                timerStarted = false;
            }
            else
                MessageBox.Show("还未开始计时");
        }

        private void timerForStripStatus_Tick(object sender, EventArgs e)
        {

            timerStripStatusLabel.Text = RemoveDecimalOfSeconds(DateTime.Now - trainingStartTime);
        }

        /// <summary>
        /// 将以秒为单位的时长的小数点后的数字去掉
        /// </summary>
        /// <param name="timespan">要去除小数的时长</param>
        /// <returns>返回标准格式的无小数时长字符串</returns>
        private string RemoveDecimalOfSeconds(TimeSpan timespan)
        {
            return Regex.Replace(timespan.ToString(), @"\.\d+$", string.Empty);
        }

        //让recordGird在输入状态下实时更新数据源
        private void recordGird_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            middleLayer.SaveRecord();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否保存当前记录", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                middleLayer.SaveRecord();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                middleLayer = new BusinessLogicLayer(openFileDialog1.FileName);
                LoadRecordFormFile();
            }
        }
    }    
}
