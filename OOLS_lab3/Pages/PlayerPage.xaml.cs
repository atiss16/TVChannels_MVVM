using OOLS_lab3.TV;
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
    /// Логика взаимодействия для PlayerPage.xaml
    /// </summary>
    public partial class PlayerPage : Page, IScreen
    {
        public PlayerPage(Channel currentChannel)
        {
            InitializeComponent(); 
            //CurrentChannel = currentChannel;
            lblChannelName.Content = currentChannel.Name;
            CommandExecuter = new CommandExecuter(this);
        }
        public CommandExecuter CommandExecuter { get; set; }
        //Channel CurrentChannel { get; set; }
        private Navigation Navigation { get; set; } = Navigation.GetInstance();
        public bool TryExecute(string commandText)
        {
            return CommandExecuter.TryExecute(commandText);
        }
        public void ClickButtonNumber(int number)
        {

        }
        public void Back()
        {
            Navigation.GoBack();
        }

        public void Down()
        {

        }

        public void Ok()
        {
            Back();
        }

        public void Right()
        {

        }

        public void Up()
        {

        }

        public void Left()
        {

        }
    }
}
