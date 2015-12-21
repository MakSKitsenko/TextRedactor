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
using Redactor;
using Redactor_Class;
using MahApps.Metro.Controls;

namespace Redactor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private Manager _documentmanager;
        public Image i = new Image();
       

        public MainWindow()
        {
            InitializeComponent();
            _documentmanager = new Manager(body);
            

        }


        private void menu_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menu = e.OriginalSource as MenuItem;
            switch (menu.Name)
            {
                case "New":
                  _documentmanager.NewDocument();
                    break;
                case "Open":
                    _documentmanager.OpenDocument();
                    status.Text = "Документ загружен";
                    break;
                case "Save":
                    _documentmanager.SaveDocument();
                    break;
                case "SaveAs":
                    _documentmanager.SaveDocumentAs();
                    break;

                case "Print":
                    _documentmanager.PrintDocument();
                    break;
                case "Close":
                    if (body != null) { _documentmanager.SaveDocument(); }
                    _documentmanager.CloseDocument(this);
                    break;
                case "Undo":
                    _documentmanager.Undo_Click();
                    break;
                case "Redo":
                    _documentmanager.Redo_Click();
                    break;
                case "Cut":
                    _documentmanager.Cut_Click();
                    break;
                case "Copy":
                    _documentmanager.Copy_Click();
                    break;
                case "Paste":
                    _documentmanager.Paste_Click();
                    break;
                case "Delete":
                    _documentmanager.Delete_Click();
                    break;
                default:
                    break;
            }
        }
        private void toolBar_Click(object sender, RoutedEventArgs e)
        {
            Button button = e.OriginalSource as Button;
            if (button == null) return;
            switch (button.Name)
            {
                case "_Open":

                    _documentmanager.OpenDocument();
                    status.Text = "Документ загружен";
                    break;
                case "_Save":
                    _documentmanager.SaveDocument();
                    break;
                case "_Cut":
                    _documentmanager.Cut_Click();
                    break;
                case "_Copy":
                    _documentmanager.Copy_Click();
                    break;
                case "_Paste":
                    _documentmanager.Paste_Click();
                    break;
                case "_Undo":
                    _documentmanager.Undo_Click();
                    break;
                case "_Redo":
                    _documentmanager.Redo_Click();
                    break;
                case "_Smiles":
                    _documentmanager.Smiles_Click();
                    break;

                case "boldButton":
                    _documentmanager.Bold_Click();
                    break;
                case "ItalicButton":
                    _documentmanager.Italic_Click();
                    break;
                default:
                    break;
            }
            body.Focus();

        }

        private void Smiles_Clicks(object sender, RoutedEventArgs e)
        {
            Button button = e.OriginalSource as Button;
            if (button == null) return;
            switch (button.Name)
            {
                case "_Smiles":
                    _documentmanager.Paste_Click();
                    break;
            }

        }
        private void toolBar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox source = e.OriginalSource as ComboBox;
            if (source == null) return;
            switch (source.Name)
            {
                case "fonts"://выбор (семейства) шрифта
                    _documentmanager.ApplyToSelection(TextBlock.FontFamilyProperty, source.SelectedItem);
                    break;
                case "fontSize"://изменение размера
                    _documentmanager.ApplyToSelection(TextBlock.FontSizeProperty, source.SelectedItem);
                    break;
                case "fontColor"://изменение цвета
                    _documentmanager.ApplyToSelection(TextBlock.BackgroundProperty, source.SelectedItem);
                    break;
            }
            body.Focus();
        }


        private void menu_Click_1(object sender, RoutedEventArgs e)
        {
            MenuItem menu = e.OriginalSource as MenuItem;
            switch (menu.Name)
            {
                case "New":
                    _documentmanager.NewDocument();
                    break;
                case "Open":
                    _documentmanager.OpenDocument();
                    status.Text = "Документ загружен";
                    break;
                case "Save":
                    _documentmanager.SaveDocument();
                    break;
                case "SaveAs":
                    _documentmanager.SaveDocumentAs();
                    break;

                case "Print":
                    _documentmanager.PrintDocument();
                    break;
                case "Close":
                    _documentmanager.CloseDocument(this);
                    break;
                case "Undo":
                    _documentmanager.Undo_Click();
                    break;
                case "Redo":
                    _documentmanager.Redo_Click();
                    break;
                case "Cut":
                    _documentmanager.Cut_Click();
                    break;
                case "Copy":
                    _documentmanager.Copy_Click();
                    break;
                case "Paste":
                    _documentmanager.Paste_Click();
                    break;
                case "Delete":
                    _documentmanager.Delete_Click();
                    break;
                default:
                    break;

            }
        }

        private void body_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

   

    }

}
