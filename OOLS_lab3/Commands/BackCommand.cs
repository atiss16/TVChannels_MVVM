using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLS_lab3.Commands
{
    public class BackCommand : Command
    {
        public BackCommand(IScreen screen) : base(screen)
        {

        }
        public override void Execute()
        {
            Screen.Back();
        }
    }
}
