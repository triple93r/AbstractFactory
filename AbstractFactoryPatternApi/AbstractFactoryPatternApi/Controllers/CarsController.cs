using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactoryPatternApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : Controller
    {
        [HttpGet]
        public JsonResult GetAcar(string sel)
        {
            FactorySelector factorySelector = new FactorySelector();
            MasterFactory pref = factorySelector.selector(sel);

            //Factory Hondafactry = new HondaFactory();
            Car myCar = pref.Getcar();
            //myCar.drive();

            //Factory Toyotafactry = new ToyotaFactory();
            //Car myCar2 = Toyotafactry.Getcar();
            //myCar2.drive();

            //return Json(myCar.drive() +" - "+ myCar2.drive());
            return Json(myCar.drive());
        }
    }
}
