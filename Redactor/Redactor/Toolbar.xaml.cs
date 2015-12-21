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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : UserControl
    {
        public Page1()
        {
            InitializeComponent();
        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        { //меняю допустимое значение размера шрифта 
            for (double i = 8; i < 119; i += 2)
            {
                fontSize.Items.Add(i);

            }
            fontColor.Items.Add("Black");
            fontColor.Items.Add("Red");
            fontColor.Items.Add("Orange");
            fontColor.Items.Add("Green");
            fontColor.Items.Add("Blue");
            fontColor.Items.Add("Yellow");
            fontColor.Items.Add("Purple");
            fontColor.Items.Add("Whine");
        }

    }
}
