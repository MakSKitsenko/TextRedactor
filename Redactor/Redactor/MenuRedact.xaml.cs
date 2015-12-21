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

namespace Redactor
{
    /// <summary>
    /// Логика взаимодействия для MenuRedact.xaml
    /// </summary>
    public partial class MenuRedact : UserControl
    {
        public MenuRedact()
        {
            InitializeComponent();

        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Курсовая работа на тему\nСоздание текстового редактора с раширенными возможностями\nРазработана студентом II курса НИТУ МИСиС\nКиценко Максимом\n Дата проверки " + DateTime.Now.ToString(), "Я старался");

        }
    }
}
