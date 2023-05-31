using System.Collections;
using System.Collections.Generic;

namespace MVCPattern.Model
{
    public interface IStaffRepository
    {
        IEnumerable<Staff> GetAll();

        bool SaveStaff(Staff staff);
        bool DeleteStaff(string id);
        bool Exist(string id);

    }
}