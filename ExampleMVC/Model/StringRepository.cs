using ExampleMVC.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMVC.Model
{
    internal class StringRepository : IStringRepository
    {
        StringData _data;

        public StringRepository()
        {
            _data = new StringData();    
        }

        public string GetString()
        {
            return _data.strData.Trim(); ;
        }

        public void SaveString(string value)
        {
            _data.strData = value.Trim();
        }
    }
}
