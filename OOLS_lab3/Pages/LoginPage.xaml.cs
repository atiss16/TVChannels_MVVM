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

namespace OOLS_lab3.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page, IScreen
    {
        public LoginPage()
        {
            InitializeComponent();
            InitializeControlsList();
            CommandExecuter = new CommandExecuter(this);
        }
        private List<Control> Controls { get; set; }
        private Control SelectedControl { get; set; }
        public CommandExecuter CommandExecuter { get; set; }
        private Navigation Navigation { get; set; } = Navigation.GetInstance();

        private void InitializeControlsList()
        {
            Controls = new List<Control>()
            {
                tbLogin,
                tbPassword
            };
            SelectedControl = Controls[0];
            ChangeSelectionView(null, SelectedControl);
        }

        public bool TryExecute(string commandText)
        {
            return CommandExecuter.TryExecute(commandText);
        }
        public void ClickButtonNumber(int number)
        {
            ((TextBox)SelectedControl).Text += number;
        }
        public void Up()
        {
            Control oldControl = SelectedControl;

            int selectedIndex = Controls.IndexOf(SelectedControl);
            SelectedControl = Controls[(selectedIndex == 0) ? Controls.Count - 1 : --selectedIndex];

            ChangeSelectionView(oldControl, SelectedControl);
        }

        public void Down()
        {
            Control oldControl = SelectedControl;

            int selectedIndex = Controls.IndexOf(SelectedControl);
            SelectedControl = Controls[++selectedIndex % Controls.Count];

            ChangeSelectionView(oldControl, SelectedControl);
        }

        public void Left()
        {
            Up();
        }

        public void Right()
        {
            Down();
        }

        public void Ok()
        {
            if (tbLogin.Text == "" || tbPassword.Text == "")
                return;
            Navigation.Navigate(new TVChannelsPage());
        }

        public void Back()
        {

        }
        private void ChangeSelectionView(Control oldSelection, Control newSelection)
        {
            if(oldSelection != null)
                oldSelection.BorderBrush = Brushes.Gray;
            newSelection.BorderBrush = Brushes.Crimson;
        }
    }
}
