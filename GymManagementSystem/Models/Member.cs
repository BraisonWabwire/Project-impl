using System;

namespace GymManagementSystem.Models
{
    public class Member : Person
    {
        public string MemberID { get; set; }
        public string MembershipType { get; set; }

        public Member(string name, string address, string phoneNumber, string memberID, string membershipType)
            : base(name, address, phoneNumber)
        {
            MemberID = memberID;
            MembershipType = membershipType;
        }
    }
}
