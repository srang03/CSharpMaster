using MVCPattern.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace MVCPattern.Model
{
    public class StaffRepository : IStaffRepository
    {

        private void SaveSettings(IEnumerable<Staff> staff)
        {
            string jsonData = JsonSerializer.Serialize<IEnumerable<Staff>>(staff);
            Settings settings = new Settings();
            settings.staffJson = jsonData;
            settings.Save();
        }

        public bool DeleteStaff(string id)
        {
            List<Staff> lStaff = GetAll().ToList();
            Staff findStaff = lStaff.Find(x => x.ID.Equals(id));

            try
            {
                if (findStaff != null)
                {
                    lStaff.Remove(findStaff);
                    SaveSettings(lStaff);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;

        }

        public bool Exist(string id)
        {
            List<Staff> lStaff = GetAll().ToList();
            return lStaff.Exists(x => x.ID.Equals(id));
        }

        public IEnumerable<Staff> GetAll()
        {
            string jsonData = new Settings().staffJson;
            if (string.IsNullOrWhiteSpace(jsonData))
            {
                return null;
            }
            else
            {
                return JsonSerializer.Deserialize<IEnumerable<Staff>>(jsonData);
            }
        }

        public bool SaveStaff(Staff staff)
        {
            try
            {
                List<Staff> lStaff = GetStaffList();
                Staff findStaff = lStaff.Find(x => x.ID.Equals(staff.ID));

                if (findStaff != null)
                {
                    // Update
                    findStaff.Update(staff);
                }
                else
                {
                    // Add
                    lStaff.Add(staff);
                }
                SaveSettings(lStaff);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        
        public List<Staff> GetStaffList()
        {
            IEnumerable<Staff> lStaff = GetAll();

            List<Staff> list;
            if (lStaff == null) list = new List<Staff>();
            else list = lStaff.ToList();

            return list;
        }

    }
}
