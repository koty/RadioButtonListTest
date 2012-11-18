using System.Windows;

namespace RadioButtonListTest
{
    public class MainWindowViewModel : DependencyObject
    {
        public MainWindowViewModel()
        {
            this.RBItems1 = new[] { "Radio1", "Radio2" };
            this.SelectedItem1 = "Radio1";
        }
        
        public static readonly DependencyProperty RBItems1Property
            = DependencyProperty.Register("RBItems1",
                                          typeof (string[]),
                                          typeof (MainWindowViewModel),
                                          new PropertyMetadata(default(string[])));

        public static readonly DependencyProperty SelectedItem1Property
            = DependencyProperty.Register("SelectedItem1",
                                          typeof (string),
                                          typeof (MainWindowViewModel),
                                          new PropertyMetadata(default(string)));

        public string[] RBItems1
        {
            get { return (string[]) GetValue(RBItems1Property); }
            set { SetValue(RBItems1Property, value); }
        }

        public string SelectedItem1
        {
            get { return (string)GetValue(SelectedItem1Property); }
            set { SetValue(SelectedItem1Property, value); }
        }
    }
}
