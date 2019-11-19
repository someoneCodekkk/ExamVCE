using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForTest;

namespace TestAdminServer
{
    public class MakeTestForJSON
    {
        public List<LibraryForTest.Question> questions { get; set; }
        public string Subject { get; set; }
        public string NameTeacher { get; set; }

    }
}
