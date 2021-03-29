using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA_Cukcuk_WebAPI.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA_Cukcuk_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        [HttpGet]
        public ResponseResult Get()
        {
            var res = new ResponseResult();
            try
            {
                
                res.Data = DbContext.GetCustomer();
            }
            catch (Exception ex)
            {
               
            }

        }
        
    }
}
