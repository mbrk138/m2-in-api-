using M2_in_api_2.Date;
using M2_in_api_2.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2_in_api_2.Controllers
{
    [Route("page/product")]
    [ApiController]

    public class addproductbyaddmin : Controller
    {
        [Route("addproduct")]
        public string login ( Product listuser)
        {

            using (var context = new ShorpDbContext())
            {
                addproductbyaddmin sqlData = new addproductbyaddmin(context);
                sqlData.Add(listuser);
            }
            return listuser.ID+listuser.Name
                +listuser.Price+listuser.NameMark;
        }

 

        private ShorpDbContext _contextc;

        public addproductbyaddmin(ShorpDbContext context)
        {
            _contextc = context;
        }
        public void Add(Product emps)
        {
            _contextc.products.Add(emps);
            _contextc.SaveChanges();
        }
        [HttpGet ("returnproduct")]
        public Product Getage(Product option)
        {
            ; var returninformation = _contextc.products.FirstOrDefault(f => f.ID == option.ID);
            if (returninformation != null)
            {
                return returninformation;

            }
            else { return null; }

        }


        public IEnumerable<Product> GetAll()
        {

            return _contextc.products.ToList();


        }



    }
}
