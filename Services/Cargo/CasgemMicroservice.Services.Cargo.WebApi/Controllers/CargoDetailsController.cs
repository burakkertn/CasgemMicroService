using CasgemMicroService.Services.Cargo.BusinessLayer.Abstract;
using CasgemMicroService.Services.Cargo.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroService.Services.Cargo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _cargoDetailService;

        public CargoDetailsController(ICargoDetailService cargoDetailService)
        {
            _cargoDetailService = cargoDetailService;
        }
        [HttpGet]
        public IActionResult CargoDetailList()
        {
            var values = _cargoDetailService.GetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult CargoDetailGet(int id)
        {
            var values = _cargoDetailService.GetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CargoDetailCreate(CargoDetail cargoDetail)
        {
         _cargoDetailService.Insert(cargoDetail);
            return Ok("KArgo Detayı Eklendi");
        }
        [HttpPut]
        public IActionResult CargoDetailUpdate(CargoDetail cargoDetail)
        {
            _cargoDetailService.Update(cargoDetail);
            return Ok("KArgo Detayı Güncellendi");
        }
        [HttpDelete]
        public IActionResult CargoDetailDelete(CargoDetail cargoDetail)
        {
            _cargoDetailService.Delete(cargoDetail);
            return Ok("Kargo Detayı Silindi");
        }
    }
}
