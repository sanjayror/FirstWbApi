using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstWbApi.Models;
using FirstWbApi.Repository;

namespace FirstWbApi.Controllers
{
    public class FirstController : ApiController
    {
        public IHttpActionResult GetAllUser()
        {
            IHttpActionResult ht = null;
            MemberShip SD = new MemberShip();
            CCFirstClass clas = new CCFirstClass();
            var objlist = clas.GetAll();
            return Ok(objlist);
            //sbyte sd sdf



        }

        [HttpPost]
        public IHttpActionResult LoginPage(LoginPage log)
        {
            CCLoginPage obj = new CCLoginPage();
            var objlist = obj.getLogin(log);
            return Ok(objlist);
               }


        [HttpGet]
        public IHttpActionResult Log()
        {
            IHttpActionResult response = null;
            CCFirstClass fst = new CCFirstClass();
            fst.GetAll();
            CCLoginPage lg = new CCLoginPage();
            
            return response; 

        }
    }

}
