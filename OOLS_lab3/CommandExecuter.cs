using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOLS_lab3.Commands;

namespace OOLS_lab3
{
    public class CommandExecuter
    {
        public CommandExecuter(IScreen screen)
        {
            this.screen = screen;
            InitializeDictionaries(screen);
        }
        private IScreen screen { get; set; }
        private Dictionary<string, Dictionary<int, Command>> RemoteControllers { get; set; }
        private Dictionary<int, Command> SonyCommands { get; set; }
        private Dictionary<int, Command> SamsungCommands { get; set; }
        private Dictionary<int, Command> LGCommands { get; set; }
        private void InitializeDictionaries(IScreen screen)
        {
            SonyCommands = new Dictionary<int, Command>()
            {
                { 0, new NumberCommand(screen, 0) },
                { 1, new NumberCommand(screen, 1) },
                { 2, new NumberCommand(screen, 2) },
                { 3, new NumberCommand(screen, 3) },
                { 4, new NumberCommand(screen, 4) },
                { 5, new NumberCommand(screen, 5) },
                { 6, new NumberCommand(screen, 6) },
                { 7, new NumberCommand(screen, 7) },
                { 8, new NumberCommand(screen, 8) },
                { 9, new NumberCommand(screen, 9) },
                { 10, new UpCommand(screen) },
                { 11, new DownCommand(screen) },
                { 12, new LeftCommand(screen) },
                { 13, new RightCommand(screen) },
                { 14, new OkCommand(screen) },
            };
            SamsungCommands = new Dictionary<int, Command>()
            {
                { 23, new NumberCommand(screen, 0) },
                { 24, new NumberCommand(screen, 1) },
                { 25, new NumberCommand(screen, 2) },
                { 26, new NumberCommand(screen, 3) },
                { 27, new NumberCommand(screen, 4) },
                { 28, new NumberCommand(screen, 5) },
                { 29, new NumberCommand(screen, 6) },
                { 30, new NumberCommand(screen, 7) },
                { 31, new NumberCommand(screen, 8) },
                { 32, new NumberCommand(screen, 9) },
                { 56, new UpCommand(screen) },
                { 58, new DownCommand(screen) },
                { 57, new LeftCommand(screen) },
                { 55, new RightCommand(screen) },
                { 123, new OkCommand(screen) },
                { 321, new BackCommand(screen) },
                { 45, new BackCommand(screen) },
            };
            LGCommands = new Dictionary<int, Command>()
            {
                { 65, new NumberCommand(screen, 0) },
                { 66, new NumberCommand(screen, 1) },
                { 67, new NumberCommand(screen, 2) },
                { 68, new NumberCommand(screen, 3) },
                { 69, new NumberCommand(screen, 4) },
                { 70, new NumberCommand(screen, 5) },
                { 71, new NumberCommand(screen, 6) },
                { 72, new NumberCommand(screen, 7) },
                { 73, new NumberCommand(screen, 8) },
                { 74, new NumberCommand(screen, 9) },
                { 1, new UpCommand(screen) },
                { 2, new DownCommand(screen) },
                { 3, new LeftCommand(screen) },
                { 4, new RightCommand(screen) },
                { 55, new OkCommand(screen) },
                { 77, new BackCommand(screen) },
            };
            RemoteControllers = new Dictionary<string, Dictionary<int, Command>>()
            {
                { "sony", SonyCommands },
                { "samsung", SamsungCommands },
                { "lg", LGCommands },
            };
        }
        public bool TryExecute(string commandText)
        {
            try
            {
                string[] values = commandText.Split(new char[] { '-' });

                Dictionary<int, Command> controllerCommands = RemoteControllers[values[0]];
                int numberCommand = int.Parse(values[1]);

                controllerCommands[numberCommand].Execute();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
