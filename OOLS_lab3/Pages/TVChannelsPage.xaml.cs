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
    /// Логика взаимодействия для TVChannelsPage.xaml
    /// </summary>
    public partial class TVChannelsPage : Page, IScreen
    {
        public TVChannelsPage()
        {
            InitializeComponent();
            InitializeChannels();
            ItemsGrid.ItemsSource = Channels;
            ItemsGrid.SelectedIndex = 0;
            CommandExecuter = new CommandExecuter(this);
            //SelectedChannel = Channels[0];
        }
        public CommandExecuter CommandExecuter { get; set; }
        private List<Channel> Channels { get; set; }
        //public Channel SelectedChannel { get; set; }
        private Navigation Navigation { get; set; } = Navigation.GetInstance();
        private void InitializeChannels()
        {
            Channels = new List<Channel>()
            {
                new Channel(1, "Культура", "Балет"),
                new Channel(2, "МУЗ ТВ", "Балет"),
                new Channel(3, "Котики", ":3"),
                new Channel(4, "Новости", "Новости 24"),
                new Channel(5, "Планета животных", "Марианская впадина"),
            };
        }
        public bool TryExecute(string commandText)
        {
            return CommandExecuter.TryExecute(commandText);
        }
        public void ClickButtonNumber(int number)
        {
            if (number > Channels.Count)
                return;

            ItemsGrid.SelectedIndex = number - 1;
            //SelectedChannel = Channels[number];        
        }
        public void Up()
        {
            int selectedIndex = ItemsGrid.SelectedIndex;
            ItemsGrid.SelectedIndex = (selectedIndex == 0) ? (Channels.Count - 1) : (selectedIndex - 1);
            //SelectedChannel = (Channel)ItemsGrid.SelectedItem;
        }

        public void Down()
        {
            int selectedIndex = ItemsGrid.SelectedIndex;
            ItemsGrid.SelectedIndex = (selectedIndex + 1) % Channels.Count;
            //SelectedChannel = (Channel)ItemsGrid.SelectedItem;
        }

        public void Left()
        {
            Down();
        }

        public void Right()
        {
            Up();
        }

        public void Ok()
        {
            Navigation.Navigate(new PlayerPage((Channel)ItemsGrid.SelectedItem));
        }

        public void Back()
        {
            Navigation.GoBack();
        }
    }
}
