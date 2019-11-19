using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TestClient
{
    abstract class TypeQuestion
    {
        public Button Place { get; set; }
        public TypeQuestion(string content)
        {
            Place = new Button();
        }
        public TypeQuestion()
        {

        }
    }
}
