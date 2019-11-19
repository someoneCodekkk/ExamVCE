using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TestClient
{
    class RadioQuestion:TypeQuestion
    {
        public static int Id { get; private set; }
        int id;
        public RadioButton Choose { get; set; }
        public RadioQuestion() { }
        public RadioQuestion(string content) : base(content)
        {
            id = Id;
            Id++;
            Choose = new RadioButton();
            Place.Content = Choose;
            Place.HorizontalAlignment = HorizontalAlignment.Left;
            Choose.GroupName = "g";
            Choose.Content = content;
            Choose.Name = $"radioButton{id}";

        }
    }
}
