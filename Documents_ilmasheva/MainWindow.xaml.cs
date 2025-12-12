using Documents_ilmasheva.Classes;
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

namespace Documents_ilmasheva
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// <summary> Логика взаимодействия для MainWindow.xaml</summary>
    public partial class MainWindow : Window
    {
        /// <summary> Ссылка на главное окно</summary>
        public static MainWindow init;
        /// <summary> Коллекция документов</summary>
        public List<DocumentContext> AllDocuments = new DocumentContext().AllDocuments();
        // Переменная для перечисления
        public enum pages
        {
            main, // главная страница
            add // страница добавления
        }

        public MainWindow()
        {
            InitializeComponent();
            init = this;
            OpenPages(pages.main); // открываем главную страницу
        }

        /// <summary> Метод открытия страниц</summary>
        public void OpenPages(pages _pages)
        {
            if (_pages == pages.main) // если главная страница
                frame.Navigate(new Pages.Main()); // открываем главную страницу
            else if (_pages == pages.add) // если страница добавления
                frame.Navigate(new Pages.Add()); // открываем страницу добавления
        }
    }
}
