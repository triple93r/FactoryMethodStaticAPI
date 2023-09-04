using FactoryMethodAPI.Factories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace FactoryMethodAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : Controller
    {
        [HttpPost]
        public JsonResult Pateints(string patientTyp, bool Casuality, bool Surgery)
        {
            var a = PatientFactory.GetPatientInfo(carModel);
            return Json();
        }
    }
}
