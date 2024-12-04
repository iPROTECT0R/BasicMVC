using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BasicMVC.Models
{
    public class MVCUser : IdentityUser
    {
        // No need to override the Id property. IdentityUser already provides it.
        // Just add any additional properties you need.

        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        // FullName as a calculated property
        public string FullName => $"{FirstName} {LastName}";

        // If you want to get a numeric Id (assuming Id is a GUID or string)
        public int GetNumericId()
        {
            // If Id is a GUID, we need a different approach, as GUIDs cannot be directly converted to integers
            if (Guid.TryParse(Id, out Guid guidId))
            {
                // Convert the GUID to an integer (you might want to hash it or take part of it if necessary)
                return guidId.GetHashCode();  // Or use another approach to get a numeric value
            }

            throw new FormatException("User ID is not a valid GUID format.");
        }
    }
}
