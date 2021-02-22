using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        public class CarsController : ControllerBase
        {
            IBrandService _brandService;
            public CarsController(IBrandService brandService)
            {
                _brandService = brandService;
            }
            [HttpGet("getall")]
            public IActionResult Get()
            {
                var result = _brandService.GetAll();
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            [HttpPost("add")]
            public IActionResult Add(Brand brand)
            {
                var result = _brandService.Add(brand);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            [HttpDelete("delete")]
            public IActionResult Delete(Brand brand)
            {
                var result = _brandService.Delete(brand);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            [HttpPut("güncelle")]
            public IActionResult Update(Brand brand)
            {

                var result = _brandService.Update(brand);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);

            }
            [HttpGet("getbyid")]
            public IActionResult Get(int id)
            {
                var result = _brandService.GetCarsByBrandId(id);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

        }
    }
}
