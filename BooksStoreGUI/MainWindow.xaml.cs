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

namespace BooksStoreGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BooksStoreBL.BookStoreBL booksStoreBL; 
        public MainWindow()
        {
            booksStoreBL = new BooksStoreBL.BookStoreBL();
            
            InitializeComponent();
            //1
            var res = booksStoreBL.GetAllBooksPriceMore30();
            BooksDataGrid.ItemsSource = res;
            //2
            var res1 = booksStoreBL.GetAllBooksSort();
            BooksDataGrid.ItemsSource = res1;
            //3
            var res2 = booksStoreBL.GetAllBooksPriceOfComiks();
            BooksDataGrid.ItemsSource = res2.Select(x => new { Value = x }).ToList();
            //4
            var res3 = booksStoreBL.GetAllBooksNameOf9();
            BooksDataGrid.ItemsSource = res3.Select(x => new { Value = x }).ToList();


        }
    }
}
