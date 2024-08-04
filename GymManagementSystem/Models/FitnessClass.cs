using System;

namespace GymManagementSystem.Models
{
    public class FitnessClass
    {
        public string ClassID { get; set; }
        public string ClassName { get; set; }
        public Staff Instructor { get; set; }

        public FitnessClass(string classID, string className, Staff instructor)
        {
            ClassID = classID;
            ClassName = className;
            Instructor = instructor;
        }
    }
}
