using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExamVCE
{
    [Serializable]
    public class Question
    {
        public string Condition { get; set; }
        public string TypeControl { get; set; }
        public int Weight { get; set; }
        public List<Answer> answers { get; set; }
    }
}
