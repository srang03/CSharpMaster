using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleMVC.Controller
{
    internal class StringController : IStringController
    {
        IView _view;
        IStringRepository _repository;

        public StringController(IView view, IStringRepository repository)
        {
            _view = view;
            _repository = repository;
            _view.SetController(this);
        }

        public void ChangeValue(string strText)
        {
            _repository.SaveString(strText);
        }

        public string GetValue()
        {
            return _repository.GetString();
        }
    }
}
