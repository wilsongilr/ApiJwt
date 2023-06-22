using ApiJwt.Models;

namespace ApiJwt.Constans
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
                        
                new UserModel()
                {
                    Username = "wgil",          
                    Password = "wg123",
                    Rol = "Administrador",
                    EmailAdress = "wgil@coorditamques.com",
                    LastName = "Gil",
                    FirstName = "Wilson"
                },
                new UserModel()
                {
                    Username = "pgomez",          
                    Password = "wg123",
                    Rol = "Vendedor",
                    EmailAdress = "pgomez@coorditamques.com",
                    LastName = "Gomez",
                    FirstName = "Paula"
                },
                new UserModel()
                {
                    Username = "sgil",          
                    Password = "sg123",
                    Rol = "Administrador",
                    EmailAdress = "sgil@coorditamques.com",
                    LastName = "Wilson",
                    FirstName = "Gil"
                },
                new UserModel()
                {
                    Username = "lgil",          
                    Password = "lg123",
                    Rol = "Tic",
                    EmailAdress = "lgil@coorditamques.com",
                    LastName = "Wilson",
                    FirstName = "Gil"
                }
        };
    }
}
