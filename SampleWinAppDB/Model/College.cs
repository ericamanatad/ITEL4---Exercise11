namespace SampleWinAppDB.Model
{
    public class College
    {
        private int collegeID;
        private string collegeName;
        private string collegeCode;
        private bool isActive;

        public int CollegeID { get => collegeID; set => collegeID = value; }
        public string CollegeName { get => collegeName; set => collegeName = value; }
        public string CollegeCode { get => collegeCode; set => collegeCode = value; }
        public bool IsActive { get => isActive; set => isActive = value; }

        public College()
        {

        }

        public College(int collegeID, string collegeName, string collegeCode, bool isActive)
        {
            CollegeID = collegeID;
            CollegeName = collegeName;
            CollegeCode = collegeCode;
            IsActive = isActive;
        }
    }
}