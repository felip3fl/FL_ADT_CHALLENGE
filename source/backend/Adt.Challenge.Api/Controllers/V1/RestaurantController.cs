using Adt.Challenge.Business.Interfaces.Services;
using Adt.Challenge.Business.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adt.Challenge.Api.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [EnableCors("AllowOrigin")]
    public class RestaurantController : BaseController
    {
        private readonly IRestaurantService _usuarioService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _usuarioService = restaurantService;
        }

        /// <summary>
        /// Retorna lista de restaurante por hora e minuto
        /// </summary>
        /// <remarks>Informar horário no formato: HH:MM</remarks>
        /// <param name="hourMinute" example="12:59">Hora e minuto</param>
        /// <response code="200">Lista de restaurantes retornado com sucesso</response>
        /// <response code="404">Nenhum dado encontrado</response>
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
