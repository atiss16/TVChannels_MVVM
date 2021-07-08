using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLS_lab3.Commands
{
    public class NumberCommand : Command
    {
        public NumberCommand(IScreen screen, int number) : base(screen)
        {
            Screen = screen;
            Number = number;
        }
        public int Number { get; set; }
        public override void Execute()
        {
            Screen.ClickButtonNumber(Number);
        }
    }
}
