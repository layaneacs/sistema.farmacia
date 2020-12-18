using System.Collections.Generic;
using Farmacia.API.Domain.Entities;
using Farmacia.API.Domain.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace Farmacia.API.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ICliente _cliente;

        public ClienteController(ICliente cliente)
        {
            _cliente = cliente;
        }

        [HttpGet]
        public ActionResult<List<Cliente>> GetAll(){
            return _cliente.GetAll();
        }

        [HttpPost]
        public ActionResult<Cliente> Create(Cliente model){
            try
            {
                _cliente.Create(model);
                return Ok(model);
            }
            catch (System.Exception)
            {
               return BadRequest("Não foi possível incluir o cliente");
            }
        }
        
    }
}