using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMVC.Controller
{
    internal interface IStringController
    {
        void ChangeValue(string strText);
        string GetValue();
    }
}
