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
using System.Windows.Shapes;
using System.Windows.Navigation;
using Redactor_Class;

using MahApps.Metro.Controls;
namespace Redactor
{
    /// <summary>
    /// Логика взаимодействия для Smiles.xaml
    /// </summary>

    public partial class Smiles : MetroWindow
    {
        public Smiles()
        {
            InitializeComponent();

        }
        /*
        private void btnSetImageVisibility_Click(object sender, RoutedEventArgs e)
        {
            if (this.Owner is MainWindow)
            {
                MainWindow mainWnd = (MainWindow)this.Owner;
             //   mainWnd.SetImageVisibility(Visibility.Visible);
                //Или:
                //((MainWindow)this.Owner).SetImageVisibility(Visibility.Visible);
            }
        }*/

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Smile_Click_1(object sender, RoutedEventArgs e)
        {/*
            Button button = e.OriginalSource as Button;
            if (button == null) return;
            switch (button.Name)
            {


                case "_Smiles1":
                //    _documentmanager.SaveDocument();
                    break;
            }


            }
        
        */

            /*


            private void Smiles_Click(object sender, RoutedEventArgs e)

            {
                Button button = e.OriginalSource as Button;
                if (button == null) return;
                switch (button.Name)
                {/*
                    case "_Smile1":
                        /*
                        _documentmanager.OpenDocument();
                        status.Text = "Документ загружен";
                        break;
                    case "_Smile2":
                        _documentmanager.SaveDocument();
                        break;
                    case "_Smile3":
                        _documentmanager.Cut_Click();
                        break;
                    case "_Smile3":
                        _documentmanager.Copy_Click();
                        break;
                    case "_Smile4":
                        _documentmanager.Paste_Click();
                        break;
                    case "_Smile5":
                        _documentmanager.Undo_Click();
                        break;
                    case "_Smile6":
                        _documentmanager.Redo_Click();
                        break;
                    case "_Smile7":
                        _documentmanager.Smiles_Click();
                        break;

                    case "_Smile8":
                        _documentmanager.Bold_Click();
                        break;
                    case "_Smile9":
                        _documentmanager.Italic_Click();
                        break;
                    default:
                        break;
                }
                */
        }
    }
} 
