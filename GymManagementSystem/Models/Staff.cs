namespace GymManagementSystem.Models
{
    public class Staff : Person
    {
        public string StaffID { get; set; }
        public string Role { get; set; }

        public Staff(string name, string address, string phoneNumber, string staffID, string role)
            : base(name, address, phoneNumber)
        {
            StaffID = staffID;
            Role = role;
        }
    }
}
