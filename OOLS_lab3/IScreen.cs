using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLS_lab3
{
    public interface IScreen
    {
        CommandExecuter CommandExecuter { get; set; }
        void ClickButtonNumber(int number);
        void Up();
        void Down();
        void Left();
        void Right();
        void Ok();
        void Back();
        bool TryExecute(string commandText);
    }
}
