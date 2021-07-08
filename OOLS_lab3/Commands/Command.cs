using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLS_lab3.Commands
{
    public abstract class Command
    {
        public Command(IScreen screen)
        {
            this.Screen = screen;
        }
        public IScreen Screen { get; set; }
        public abstract void Execute();
    }
}
