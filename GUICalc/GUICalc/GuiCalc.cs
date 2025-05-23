using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUICalc
{
    class GuiCalc
    {
        public int Number1
        {
            get;
            set;
        }

        public int Number2
        {
            get;
            set;
        }

        public int Add()
        {
            return Number1 + Number2;
        }

        public int Sub()
        {
            return Number1 - Number2;
        }

        public int Multiply()
        {
            return Number1 * Number2;
        }

        public int Divide()
        {
            return Number1 / Number2;
        }
    }
}
