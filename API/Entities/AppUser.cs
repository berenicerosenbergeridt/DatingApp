using System.Data;
using API.Extensions;

namespace API.Entities
//TOUJOURS ça au debut pour préciser l'environnement
{
    public class AppUser

    {
        public int Id { get; set; }
        public string UserName {get;set;}

        public  byte[] PasswordHash {get;set;} //sauvegarde sur la bdd sous forme d'octets

        public  byte[] PasswordSalt {get;set;}

        public DateOnly DateOfBirth { get; set; }
        public string knowAs { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime LastActive { get; set; } = DateTime.UtcNow;

        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public List<Photo> Photos { get; set; } = new();

        // public int GetAge()
        // {
        //     return DateOfBirth.CalculateAge();
        // }

    }
}