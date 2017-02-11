using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ExerciseRecord
{
    [Serializable]
    public class Entry
    {
        public string Description { get;set; }
        public DateTime DateTime { get;set; }
        
        [XmlIgnore]
        public TimeSpan Duration { get;set; }

        public long DurationTick
        {
            get { return Duration.Ticks; }
            set { Duration = new TimeSpan(value); }
        }


        public Entry() { }

        public Entry(string description,DateTime dateTime,TimeSpan timeSpan)
        {
            Description = description;
            DateTime = dateTime;
            Duration = timeSpan;
        }
    }
}
