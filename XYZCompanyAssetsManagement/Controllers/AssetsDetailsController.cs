using System;
using Microsoft.AspNetCore.Mvc;
using XYZCompanyAssetsManagement.Models;
using XYZCompanyAssetsManagement.Repositories;

namespace XYZCompanyAssetsManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AssetsDetailsController : Controller
    {
        Repository Repository;
        public AssetsDetailsController(Repository repository)
        {
            Repository = repository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var result = new AssetsDetailRepository(Repository).GetAll();
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            try
            {
                var result = new AssetsDetailRepository(Repository).Get(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        public IActionResult AddAssetsDetails(AssetsDetails add)
        {
            try
            {
                var result = new AssetsDetailRepository(Repository).AddAssetsDetails(add);
                return Ok(result);
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpPut]
        public IActionResult UpdateAssetsDetails(AssetsDetails update)
        {
            try
            {
                var result = new AssetsDetailRepository(Repository).UpdateAssetsDetails(update);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}