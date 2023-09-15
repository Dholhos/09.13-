using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace _09._13_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Operator> operatorok;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                //lblEditor.Content = File.ReadAllText(openFileDialog.FileName);
                FileBeolvas(openFileDialog.FileName);
                lblDarab.Content = operatorok.Count();

            }
        }
        public void FileBeolvas(string filename)
        {
            operatorok = new List<Operator>();
            foreach (var sorok in File.ReadAllLines(filename))
            {
                int a = int.Parse(sorok.Split()[0]);
                int c = int.Parse(sorok.Split()[2]);
                string b = sorok.Split()[1];
                operatorok.Add(new Operator(a, c, b));
            }
        }

        private void btMaradek_Click(object sender, RoutedEventArgs e)
        {
            lblMaradekos.Content = operatorok.Count(x => x.Opertaor == "mod");
        }

        private void btDontes_Click(object sender, RoutedEventArgs e)
        {
            if (operatorok.Any(x => x.Operandus1 % 10 == 0))
            {
                if (operatorok.Any(x => x.Operandus2 % 10 == 0))
                {
                    lblVanE.Content = "Van ilyen kifejezés!";
                }
            }
            else
            {
                lblVanE.Content = "Nincs ilyen kifejezés!";
            }
        }

        private void btStat_Click(object sender, RoutedEventArgs e)
        {
            lbiEgy.Content = "mod -> " + operatorok.Count(x => x.Opertaor == "mod") + "db";
            lbiKetto.Content = "/ -> " + operatorok.Count(x => x.Opertaor == "/") + "db";
            lbiHarom.Content = "div -> " + operatorok.Count(x => x.Opertaor == "div") + "db";
            lbiNegy.Content = "- -> " + operatorok.Count(x => x.Opertaor == "-") + "db";
            lbiOt.Content = "* -> " + operatorok.Count(x => x.Opertaor == "*") + "db";
            lbiHat.Content = "+ -> " + operatorok.Count(x => x.Opertaor == "+") + "db";

        }
    }
}
