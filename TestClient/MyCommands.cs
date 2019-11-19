using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestClient
{
    public class MyCommands
    {
        public static RoutedUICommand Exit = new RoutedUICommand("Exit", "Exit", typeof(MyCommands), new InputGestureCollection() { new KeyGesture(Key.Q, ModifierKeys.Control) });
        public static RoutedUICommand FontSize = new RoutedUICommand("FontSize", "EditFontSize", typeof(MyCommands));
        public static RoutedUICommand Load = new RoutedUICommand("Load session", "Load", typeof(MyCommands));
    }
}
