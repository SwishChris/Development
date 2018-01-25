using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
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
using System.Windows.Forms;
using System.IO;

namespace SkillsUSA_Program
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XDocument doc = new XDocument();
            using (StreamReader streamReader = new StreamReader(ofd.FileName, true))
            {
                doc = XDocument.Load(streamReader);
            }
            doc.Root.Add(
                new XElement("Name", txtbox.Text));
            doc.Save(@"C:\Desktop.xml");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        { 
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "(*.xml)|*.xml|(*.*)|*.*";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            ofd.ShowDialog();

            
        }
    }
}
