using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForTest
{
    [Serializable]
    public class MakeTest
    {
        public string NameTeacher { get; set; }
        public string Subject { get; set; }
        public List<Question> questions { get; set; }
    }
}
