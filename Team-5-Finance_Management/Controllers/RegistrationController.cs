using Finance_Management.Repository;
using Finance_Management.DataAccessLayer.Implementation;
using Finance_Management.DataAccessLayer.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;


namespace Finance_Management.DataAccessLayer
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : Controller
    {

        private IRegistration objectdata;

        public RegistrationController(IRegistration objectdata)
        {
            this.objectdata = objectdata;
        }
                                                                                               
        [HttpPost]
        public IActionResult InsertRegistration(Registration registration)
        {
            if (this.ModelState.IsValid)
            {
                this.objectdata.Add(registration);
            }
            return null;
        }

        private IActionResult CreatedAction(string v)
        {
            throw new NotImplementedException();
        }

        




        [HttpGet]
        [Route("  GetById /{id}")]
        public IActionResult GetById(int  id)
        {
            
            var result = objectdata.GetById( id);
            return this.Ok(result);
        }
         [HttpGet]
         [Route(" GetAllDetails")]
         public IActionResult GetAllDetails( )
        {
             
            var result = objectdata.GetAllDetails();
            return this.Ok(result);

            //ar result = RegistrationDao.GetAllDetails();
            //return this.Ok(result);
        }
        

    }

    public class RegistrationRepsitory
    {
    }

    public class RegId
    {
    }
}

