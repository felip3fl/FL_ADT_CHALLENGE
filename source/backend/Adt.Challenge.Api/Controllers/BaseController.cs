using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adt.Challenge.Api.Controllers
{
    [ApiController]
    public abstract class BaseController : Controller
    {
        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = true,
                errors = "MENSAGEM DE ERRO"
            }); 
        }

        private bool OperacaoValida()
        {
            return true;
        }
    }
}
