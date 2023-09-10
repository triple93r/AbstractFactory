using AbstractFactoryPatternApi.AbstractClasses;
using AbstractFactoryPatternApi.Data;
using AbstractFactoryPatternApi.Factories;
using AbstractFactoryPatternApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using static AbstractFactoryPatternApi.PatientDetails;

namespace AbstractFactoryPatternApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly FactorySelector2 factorySelector;
        public PatientsController(ApplicationDBContext db, FactorySelector2 _factorySelector)
        {
            _context = db;
            factorySelector = _factorySelector;
        }

        [Route("SetPatient")]
        [HttpPost]
        public JsonResult SetPatient(string FirstName, string LastName, int age, string Address, int ptype)
        {
            AbstractFactory pref = factorySelector.selector(ptype);
            AbstractPatient abstractPatient = pref.GetPatient();

            Patient ptn = new Patient();
            ptn.FirstName = abstractPatient.FirstName(FirstName);
            ptn.LastName = abstractPatient.LastName(LastName);              
            ptn.Age = abstractPatient.Age(age);
            ptn.Adrress = abstractPatient.Address(Address);
            ptn.PatientType = abstractPatient.Typ();
            if (ptn.PatientType != "Invalid Patient Entry")
            {
                _context.Patients.Add(ptn);
                _context.SaveChanges();
            }
            return Json(abstractPatient.FirstName(FirstName) + " - " + abstractPatient.LastName(LastName));
        }
    }
}
