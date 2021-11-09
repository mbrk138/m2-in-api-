using M2_in_api_2.Date;
using M2_in_api_2.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2_in_api_2.Controllers
{
    [Route("page/Entrance")]
    [ApiController]

    public class Creataccontandlogin : Controller
    {

        [HttpGet("creataccont")]
        public string userlogin(Create_a_user_account_login login)
        {
            using (var context = new ShorpDbContext())
            {
                Creataccontandlogin sqlData = new Creataccontandlogin(context);
                sqlData.Add(login);
            }




            return login.Fullname + login.Username + login.Age + login.Password;

        }


        private ShorpDbContext _context;
        public Creataccontandlogin(ShorpDbContext context)
        {
            _context = context;
        }
        public void Add(Create_a_user_account_login emp)
        {
            _context.useraccont.Add(emp);
            _context.SaveChanges();
        }

        [HttpGet("login")]
        public Create_a_user_account_login Getage(Create_a_user_account_login option)
        {
              var returninformation = _context.useraccont.FirstOrDefault(a => a.Password == option.Password && a.Username == option.Username);
            if (returninformation != null)
            {
                return returninformation;

            }
            else { return null; }

        }


        public IEnumerable<Create_a_user_account_login> GetAll()
        {



            return _context.useraccont.ToList();




        }


    }

}
