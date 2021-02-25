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

namespace WpfAppProj
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        wpfAppEntities _db = new wpfAppEntities();
        public static DataGrid datagrid;
        public MainWindow()
        {
            InitializeComponent();
            Load();
        }

    /// <summary>
    /// Wczytanie rekordów z bazy
    /// </summary>
        private void Load()
        {
            myDataGrid.ItemsSource = _db.members.ToList();
            datagrid = myDataGrid;
        }

    /// <summary>
    /// Obsługa przycisku Dodania użytkownika
    /// </summary>
        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            InsertPage Ipage = new InsertPage();
            Ipage.ShowDialog();
        }
    /// <summary>
    /// Obsługa przycisku Aktualizacji użytkownika
    /// </summary>
        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as member).id;
            UpdatePage Upage = new UpdatePage(Id);
            Upage.ShowDialog();
        }
    /// <summary>
    /// Obsługa przycisku Usunięcia użytkownika
    /// </summary>
        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as member).id;
            var deleteMember = _db.members.Where(m => m.id == Id).Single();
            _db.members.Remove(deleteMember);
            _db.SaveChanges();
            myDataGrid.ItemsSource = _db.members.ToList();
        }
    }
}
