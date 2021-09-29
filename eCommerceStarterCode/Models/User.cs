using Microsoft.AspNetCore.Identity;

namespace eCommerceStarterCode.Models
{
    public class User : IdentityUser
    {
<<<<<<< HEAD
        public string FirstName { get; set; }
        public string LastName { get; set; }
=======

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LoginName { get; set; }
>>>>>>> faeeb9e5992fb6ee65f4c8fabca8000fdd118d91
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}
