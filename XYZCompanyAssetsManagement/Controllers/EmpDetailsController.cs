using Microsoft.AspNetCore.Mvc;
using XYZCompanyAssetsManagement.Models;
using XYZCompanyAssetsManagement.Repositories;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace XYZCompanyAssetsManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmpDetailsController : Controller
    {
        Repository Repository;
        public EmpDetailsController(Repository repository)
        {
            Repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var Get = new EmpDetailsRepositoy(Repository).GetAll();
                return Ok(Get);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }
        [HttpGet]
        public IActionResult Get(EmpDetails get)
        {
            try
            {
                var emp = new EmpDetailsRepositoy(Repository).Get(get);
                return Ok(emp);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

        [HttpPost]
        public IActionResult AddEmpDetails(EmpDetails emp)
        {
            try
            {
                var result = new EmpDetailsRepositoy(Repository).AddEmpDetails(emp);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPut]
        public IActionResult UpdateEmpDetails(EmpDetails update)
        {
            try
            {
                var result = new EmpDetailsRepositoy(Repository).UpdateEmpDetails(update);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }
    }
}