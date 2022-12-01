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

namespace _7_renamer
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

        private void TextBox_Drop(object sender, DragEventArgs e)
        {
            List<TextBox> TextBoxes = new List<TextBox>() { Tbx1, Tbx2, Tbx3, Tbx4, Tbx5, Tbx6, Tbx7, Tbx8, Tbx9, Tbx10, Tbx11, Tbx12, Tbx13 };

            string[] dataString = (string[])e.Data.GetData(DataFormats.FileDrop, true); //получаем путь и имя файлов в массив строк.

            int numSlash = dataString[0].LastIndexOf("\\");
            string str1 = dataString[0].Remove(numSlash+1); //путь файла
            int numDot = dataString[0].LastIndexOf('.');
            string str1_1 = dataString[0].Substring(numDot); //расширение файла

            string str3 = sender.ToString();
            int num3 = str3.LastIndexOf(":");
            string str4 = str3.Substring(num3 + 2);   //номер кнопки на которую дроп файла
            int num5 = int.Parse(str4) - 1;

            string str2 = str1 + TextBoxes[num5].Text + Tbx14.Text + str1_1; //новое имя файла + расширение

            File.Move(dataString[0], str2);
        }
    }
}
