using System;
using Microsoft.AspNetCore.Mvc;
using XYZCompanyAssetsManagement.Models;
using XYZCompanyAssetsManagement.Repositories;

namespace XYZCompanyAssetsManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AssetsMappingController : Controller
    {
        Repository Repository;
        public AssetsMappingController(Repository repository)
        {
            Repository = repository;
        }

        [HttpGet]
        public IActionResult Get(int empId)
        {
            try
            {
                var result= new AssetsMappingRepository(Repository).Get(empId);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
           
        }


        [HttpPost]
        public IActionResult AddAssetsMapping(AssetsMapping AM)
        {
            try
            {
                var result = new AssetsMappingRepository(Repository).AddAssetsMapping(AM);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
           
        }

        [HttpPut]
        public IActionResult UpdateAssetsMapping(AssetsMapping update)
        {
            try
            {
                var result = new AssetsMappingRepository(Repository).UpdateAssetsMapping(update);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}