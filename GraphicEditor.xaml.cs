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
using Microsoft.Win32;
using System.IO;

namespace Task_WPF5
{
    /// <summary>
    /// Логика взаимодействия для GraphicEditor.xaml
    /// </summary>
    public partial class GraphicEditor : Window
    {
        public GraphicEditor()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Загрузочный файл (*.GIF)|*.GIF|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Загрузочный файл (*.GIF)|*.GIF|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
            }

        }

        private void Pen_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void Eraser_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
