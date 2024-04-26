using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinAppDB.Model
{
    public class Department
    {
        private int departmentID;
        private string departmentName;
        private string departmentCode;
        private bool isActive;
        private int collegeID;

        //mao ning depID ang var sa db oke?
        public int depID { get => departmentID; set => departmentID = value; }
        public string depName { get => departmentName; set => departmentName = value; }
        public string depCode { get => departmentCode; set => departmentCode = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        public int CollegeID { get => collegeID; set => collegeID = value; }

        public Department()
        {

        }

        public Department(int departmentID, string departmentName, string departmentCode, bool isActive, int collegeID )
        {
            depID = departmentID;
            depName = departmentName;
            depCode = departmentCode;
            IsActive = isActive;
            CollegeID = collegeID;
        }
    }
}