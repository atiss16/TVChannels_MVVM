using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLS_lab3.Commands
{
    public class UpCommand : Command
    {
        public UpCommand(IScreen screen) : base(screen)
        {

        }
        public override void Execute()
        {
            Screen.Up();
        }
    }
}
