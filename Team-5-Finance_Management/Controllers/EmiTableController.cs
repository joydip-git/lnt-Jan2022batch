using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

using Finance_Management.DataAccessLayer.Implementation;
using Finance_Management.DataAccessLayer;

namespace Finance_Management.DataAccessLayer
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmiTableController : Controller
    {

        private IEmiTable obj;
        public EmiTableController(IEmiTable obj)
        {
            this.obj = obj;
        }
        //[HttpGet]
        //[Route("fetchById")]
        //public IActionResult FetchById(int id)
        //{
        //    var fetchedData = obj.FetchById();
        //    return Ok(fetchedData);
        //}
        //[HttpPost]
        //[Route("updateAmount")]
        //public IActionResult UpdateAmount()
        //{
        //    var products = obj.UpdateAmount();
        //    return Ok(products);
        //}

    }
}

