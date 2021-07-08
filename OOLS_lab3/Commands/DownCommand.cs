using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLS_lab3.Commands
{
    public class DownCommand : Command
    {
        public DownCommand(IScreen screen) : base(screen)
        {

        }
        public override void Execute()
        {
            Screen.Down();
        }
    }
}
