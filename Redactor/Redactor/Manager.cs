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
using Microsoft.Win32;
using System.IO;



namespace Redactor_Class
{/*
    class Mager1
    {
        static Employee create(int type)
        {
            employee = new Employee(type);
            // do some heavy lifting.
            return employee;
        }
        //...
    }
    */
    public class Manager
    {
        private string _currentFile;
        private RichTextBox _textBox;

        public Manager(RichTextBox textBox)
        {
            _textBox = textBox;
        }
        public void NewDocument()
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Сохранить документ перед выходом?\nЕсли нет - закройте это окно", "Решите, что делать дальше");

            if (messageBoxResult == MessageBoxResult.Yes)
            {
                this.SaveDocument();
            }
            if (!String.IsNullOrEmpty(_currentFile))
            {
                this._currentFile = null;
            }
            this._textBox.Document.Blocks.Clear();

        }
        public bool OpenDocument()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".rtf";
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf";

            if (dlg.ShowDialog() == true)
            {
                _currentFile = dlg.FileName;
                using (Stream stream = dlg.OpenFile())
                {
                    TextRange range = new TextRange(_textBox.Document.ContentStart, _textBox.Document.ContentEnd);
                    range.Load(stream, DataFormats.Rtf);
                }
                return true;

            }
            else return false;
        }


        public bool SaveDocument()
        {
            if (string.IsNullOrEmpty(_currentFile)) return SaveDocumentAs();
            else
            {
                using (Stream stream = new FileStream(_currentFile, FileMode.Create))
                {
                    TextRange range = new TextRange(_textBox.Document.ContentStart, _textBox.Document.ContentEnd);
                    range.Save(stream, DataFormats.Rtf);
                }
                return true;

            }
        }

        public bool SaveDocumentAs()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf";

            if (dlg.ShowDialog() == true)
            {
                _currentFile = dlg.FileName;
                return SaveDocument();

            }


            return false;
        }


        public bool PrintDocument()
        {
            this.SaveDocument();
            PrintDialog pDialog = new PrintDialog();
            if (pDialog.ShowDialog() == true)
            {
                pDialog.PrintVisual(this._textBox as Visual, "Rich text box");
                return true;
            }
            return false;
        }
        public bool CloseDocument(MainWindow window)
        {

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Вы?\nЕсли нет - закройте это окно", "Решите, что делать дальше");
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                if (this.SaveDocument() == false)
                {
                    window.Close();

                }
            }
            window.Close();
            return true;
        }

        public void Undo_Click()
        {
            _textBox.Undo();

        }
        public void Redo_Click()
        {
            _textBox.Redo();
        }
        public void Cut_Click()
        {
            _textBox.Cut();

        }
        public void Copy_Click()
        {
            _textBox.Copy();

        }
        public void Paste_Click()
        {
            _textBox.Paste();
        }
        public void Paste_Click_1()
        {
            _textBox.Paste();
        }
        public void Delete_Click()
        {
            _textBox.Document.Blocks.Clear();
        }
        public void Bold_Click()
        {
            _textBox.FontWeight = FontWeights.Bold;

        }
        public void Italic_Click()
        {
            _textBox.FontStyle = FontStyles.Italic;
        }


        public void ApplyToSelection(DependencyProperty property, object value)
        {
            if (value != null)
            {
                _textBox.Selection.ApplyPropertyValue(property, value);
            }
        }
        public void Smiles_Click()
        {
            Smiles smiles = new Smiles();
            smiles.Show();
        }
        /*
        public bool? HasEmoji
        {
            get
            {
                return hasEmoji;
            }

            set
            {
                hasEmoji = value;
            }
        }
        
        public static void  CheckMessageHasEmojiWithMySysmbol(t)
        {
            Regex regex = new Regex(":[)]|:[(]");
          MatchCollection matchCollection = regex.Matches(_textBox);
            message.HasEmoji = matchCollection.Count != 0 ? true : message.HasEmoji.Value;
            return message;
        }*/



    }
   
        
       
    
}
