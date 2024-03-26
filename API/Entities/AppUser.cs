
namespace API.Entities
//TOUJOURS ça au debut pour préciser l'environnement
{
    public class AppUser

    {
        public int Id { get; set; }
        public string UserName {get;set;}

        public  byte[] PasswordHash {get;set;} //sauvegarde sur la bdd sous forme d'octets

        public  byte[] PasswordSalt {get;set;}

    }
}