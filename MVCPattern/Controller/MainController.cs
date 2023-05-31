using MVCPattern.Model;
using MVCPattern.View;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern.Controller
{
    public class MainController
    {
        private readonly IMainView _view;
        private readonly IStaffRepository _staffRepository;

        private Staff GetStaffFromView()
        {
            return new Staff(_view.ID, _view.Name, _view.Age, _view.Active);
        }
        public MainController(IMainView view, IStaffRepository staffRepository)
        {
            _view = view;
            _staffRepository = staffRepository;
            _view.SetController(this);
        }

        internal void Cancel()
        {
            LoadStaff(null);
        }

        internal void Display()
        {
            _view.ItemSource =_staffRepository.GetAll();
        }

        internal bool Save()
        {
            Staff staff = GetStaffFromView();
            if (!IsValidSavestaff(staff)) return false;

            return _staffRepository.SaveStaff(staff); ;
        }

        private bool IsValidSavestaff(Staff staff)
        {
            
            if (staff.ID.Length < 1) return false;
            if (staff.ID.Length > 3) return false;
            if (staff.Age < 0) return false;
            if (string.IsNullOrEmpty(staff.Name)) return false;
     
            return true;
        }

        internal bool Delete()
        {
            return _staffRepository.DeleteStaff(_view.ID);    
        }

        private void LoadStaff(Staff staff) { 
            if(staff == null)
            {
                _view.ID = string.Empty;
                _view.Name = string.Empty;
                _view.Age = 0;
                _view.Active = false;
            }
            else
            {
                _view.ID = staff.ID;
                _view.Name = staff.Name;
                _view.Age = staff.Age;
                _view.Active = staff.Active;
            }
        }
    }
}
