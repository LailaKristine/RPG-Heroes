using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Characters
{
    internal class RequiredLevelException : Exception
    {
        public override string Message => "Your level is too low";


    }
}   
