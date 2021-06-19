using Adt.Challenge.Business.Interfaces.Services;
using Adt.Challenge.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adt.Challenge.Api.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("[controller]")]
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _usuarioService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _usuarioService = restaurantService;
        }

        [HttpGet("GetNameByHourMinute/{hourMinute}")]
        public async Task<ActionResult> GetNameByHourMinute(string hourMinute)
        {
            var restaurants = await _usuarioService.GetNameByHourMinute(hourMinute);

            if(restaurants == null)
                return NotFound(hourMinute);

            return Ok(restaurants);
        }
    }
}
