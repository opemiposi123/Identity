using Identity.Models.Domain;
using Identity.Models.DTO;
using Identity.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Identity.Repository.Implementation
{
    public  class Seeder
    {
        private  readonly DatabaseContext _context;
        private  readonly IUserAuthenticationService _service;

        public Seeder(DatabaseContext context, IUserAuthenticationService service)
        {
            _context = context;
            _service = service;
        }


        //public RegistrationModel GetByEmail(string mail)
        //{
        //    return _context.IdentityRole<ApplicationUer>.Where(s => s.Email == mail).FirstOrDefault();
        //}
     
        //public static async Task RegisterAdmin()
        //{
        //    RegistrationModel model = new RegistrationModel
        //    {
        //        Username = "admin",
        //        Email = "admin@gmail.com",
        //        FirstName = "John",
        //        LastName = "Doe",
        //        Password = "Admin@12345#"
        //    };
        //    model.Role = "admin";
        //    var result = await _service.RegisterAsync(model);
        //    return Ok(result);
        //}
    }
}
