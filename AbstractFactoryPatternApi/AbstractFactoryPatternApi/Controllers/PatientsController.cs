using AbstractFactoryPatternApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static AbstractFactoryPatternApi.PatientDetails;

namespace AbstractFactoryPatternApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : Controller
    {
        private readonly ApplicationDBContext _context;
        public PatientsController(ApplicationDBContext db)
        {
            _context = db;
        }

        [HttpPost]
        public JsonResult SetPatient(string FirstName, string LastName, int age, string Address, int ptype)
        {
            FactorySelector2 factorySelector = new FactorySelector2();
            AbstractFactory pref = factorySelector.selector("T");

            //Factory Hondafactry = new HondaFactory();
            //Car myCar = pref.Getcar();
            AbstractPatient abstractPatient = pref.GetPatient();
            return Json(abstractPatient.FirstName(FirstName) + " - " + abstractPatient.LastName(LastName));
        }
    }
}
