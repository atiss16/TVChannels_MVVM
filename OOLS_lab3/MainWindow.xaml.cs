using OOLS_lab3.Pages;
using ReactiveUI;
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

namespace OOLS_lab3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WhenAnyValue(x => x.CurrentPage).Subscribe(value =>
            {
                frCurrentPage.Content = CurrentPage;
            });

            Navigation.OnPageChanged += (page) => OnPageChanged(page);
            Navigation.Navigate(new LoginPage());
            tbCommandLine.Focus();
        }
        private IScreen CurrentPage { get; set; }
        private Navigation Navigation { get; set; } = Navigation.GetInstance();
        private void TbCommandLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string commandText = ((TextBox)sender).Text;
                if (CurrentPage.TryExecute(commandText))
                    tbCommandLine.Text = "";
            }
        }
        private void OnPageChanged(Page page)
        {
            frCurrentPage.Content = page;
            CurrentPage = (IScreen)page;
        }
    }
}
