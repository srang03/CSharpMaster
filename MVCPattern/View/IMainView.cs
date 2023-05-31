using MVCPattern.Controller;
using MVCPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern.View
{
    public interface IMainView
    {
        string ID { get; set; }
        string Name { get; set; }
        int Age { get; set; } 
        bool Active { get; set; }

        void SetController(MainController controller);

        IEnumerable<Staff> ItemSource { get; set; }

    }
}
