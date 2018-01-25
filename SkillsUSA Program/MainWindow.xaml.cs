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
        int type = 0; /* Value for switch*/

        OpenFileDialog ofd = new OpenFileDialog();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XDocument doc = new XDocument();
            using (StreamReader streamReader = new StreamReader(ofd.FileName, true))
            {
                doc = XDocument.Load(streamReader);
            }
            switch (type) /* Changes between combobox based on user input */
            {
                case 1:
                    string type1 = "Name";
                    doc.Root.Add(
                    new XElement(type1, txtbox.Text));
                    doc.Save(@"C:\Desktop.xml");
                    break;
                case 2:
                    string type2 = "Email";
                    doc.Root.Add(
                    new XElement(type2, txtbox.Text));
                    doc.Save(@"C:\Desktop.xml");
                    break;
                default:
                    string type3 = "Phone";
                    doc.Root.Add(
                    new XElement(type3, txtbox.Text));
                    doc.Save(@"C:\Desktop.xml");
                    break;
            }
            if (Combo1.IsSelected = true)
            {
                type = 1;
            }
            if (Combo2.IsSelected = true)
            {
                type = 2;
            }
            if (Combo3.IsSelected = true)
            {
                type = 3;
            }
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
