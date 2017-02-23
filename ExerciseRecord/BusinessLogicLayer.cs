using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace ExerciseRecord
{
    public class BusinessLogicLayer
    {
        public List<Entry> Record { get; set; }

        /// <summary>
        /// 第一次获取的日期为最后一条记录的日期
        /// </summary>
        public DateTime DateTime { get; set; }

        public String Owner { get; set; }
        public String RecordAdress { get; set; }

        /// <summary>
        /// 建立新的锻炼档案
        /// </summary>
        /// <param name="lastFileName">包含文件名的完整路径</param>
        public BusinessLogicLayer(string lastFileName)
        {
            RecordAdress = lastFileName;
            LoadRecord();
            try
            {
                DateTime = Record.Last().DateTime;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("该用户目前没有记录");
                DateTime = DateTime.Now.Date;
            }
            Owner=Path.GetFileName(lastFileName);
        }
        /// <summary>
        /// 建立新的锻炼档案
        /// </summary>
        /// <param name="userName">新用户的名称，将作为记录文件的文件名</param>
        /// <param name="createNewUser">若为true，则建立新用户的对象</param>
        public BusinessLogicLayer(string userName,bool createNewUser)
        {
            if (createNewUser)
            {
                Owner = userName;
                RecordAdress = Directory.GetCurrentDirectory() +@"\" + userName + ".xml";
                DateTime = DateTime.Now;
                Record = new List<Entry>();                
            }
        }
                
        public void ChangeRecord(int column,int row,string description)
        {

        }


        public void SaveRecord()
        {
            Record.Sort(new EntryCompareByDate());
            SaveAsXML();
        }

        public void LoadRecord()
        {
            LoadXML();
        }

        private void SaveAsXML()
        {
            using(StreamWriter writter=new StreamWriter(RecordAdress))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Entry>));
                xml.Serialize(writter, Record);
            }
        }

       

        private void LoadXML()
        {
            using (StreamReader reader = new StreamReader(RecordAdress))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Entry>));
                try
                {
                    var record = xml.Deserialize(reader);
                    if (record is List<Entry>)
                    {
                        Record = record as List<Entry>;
                    }
                }
                catch
                {
                    MessageBox.Show("找不到可用的记录");
                }
            }
        }       
    }
    class EntryCompareByDate : IComparer<Entry>
    {
        public int Compare(Entry x, Entry y)
        {
            if (x.DateTime < y.DateTime)
                return -1;
            if (x.DateTime > y.DateTime)
                return 1;
            else if (x.CreatTime > y.CreatTime)
                return 1;
            else if (x.CreatTime < y.CreatTime)
                return -1;
            return 0;
        }
    }
}
