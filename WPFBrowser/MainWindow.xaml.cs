using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace WPFBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<string> comboBoxDataSource = new List<string>();

        public MainWindow()
        {
           
            InitializeComponent();
            
            //home
            brwControl.Navigate("https://www.spartaglobal.com");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
              brwControl.Navigate(combo1.SelectedItem.ToString());
            //MessageBox.Show(combo1.SelectedItem.ToString());

        }
        //public void populateCombo()
        //    {
        //    comboBoxDataSource.Add("http://www.google.com");
        //    comboBoxDataSource.Add("http://www.yahoo.com");
        //    comboBoxDataSource.Add("http://www.aws.com");
        //    }

        private void OnKeyPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                brwControl.Navigate(combo1.Text);
            }
        }

        public void Read(object sender, EventArgs e)
        {
            //combo1.Items.AddRange(File.ReadAllLines(@"C:\Users\tech-w78a.LAPTOP-T9HE3QOO\Engineering26\week6\Day3\WPFBrowser\WPFBrowser\url.txt"));

            string x = @"C:\Users\tech-w78a.LAPTOP-T9HE3QOO\Engineering26\week6\Day3\WPFBrowser\WPFBrowser\url.txt";
            foreach (string url in File.ReadAllLines(x))
            {
                brwControl.Navigate(@"C:\Users\tech-w78a.LAPTOP-T9HE3QOO\Engineering26\week6\Day3\WPFBrowser\WPFBrowser\url.txt");
                File.ReadAllLines(x);
            }
        }

            //private void write(object sender, EventArgs e)
            //{
            //    StreamWriter sw = new StreamWriter(@"C:\Users\tech-w78a.LAPTOP-T9HE3QOO\Engineering26\week6\Day3\WPFBrowser\WPFBrowser\url.txt");
            //    sw.WriteLine(combo1.Text);
               
                                  
            //}
}
}

