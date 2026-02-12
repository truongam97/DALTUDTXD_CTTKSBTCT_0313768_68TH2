using CTTKSBTCT1.view;
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

namespace CTTKSBTCT1
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

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Open");
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Save");
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Exit");
            this.Close();
        }
        private void New_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm New");
        }
        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Cut");
        }
        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Copy");
        }
        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Paste");
        }
        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Undo");
        }
        private void Redo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Redo");
        }
        private void AddMaterial_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Advanced");
        }
        private void EditMaterial_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Edit Material");
        }
        private void DeleteMaterial_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Delete Material");
        }
        private void thongsodauvao_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Thông số đầu vào");
        }
        private void thongsothietke_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Thông số thiết kế");
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm About");
        }
        private void Help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bạn vừa bấm Help");
        }
        private void Etabs_Click(object sender, RoutedEventArgs e)
        {
            ketnoietabsView ketnoietabsView = new ketnoietabsView();
            ketnoietabsView.ShowDialog();
        }

    }
}
