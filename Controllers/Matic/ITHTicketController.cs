using ApiJwt.Contexts;
using ApiJwt.Models.Matic;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiJwt.Controllers.Matic
{
    [Route("api/[controller]")]
    [ApiController]
    public class ITHTicketController : ControllerBase
    {

        public readonly CnSQLSerever context;

        public ITHTicketController(CnSQLSerever context)
        {
            this.context = context; 
        }    

        // GET: api/<ITHTicketController>
        [HttpGet]
        public IEnumerable<ITHTicket> Get()
        {
            return context.ITHticket.ToList();
        }

        // GET api/<ITHTicketController>/5
        [HttpGet("{id}")]
        public IActionResult GetTicket([Required] int id)
        {
            try
            {
                var ticket = context.ITHticket.FirstOrDefault(t => t.IdTicket == id);

                if (ticket == null) 
                {
                    return NotFound("Ticket " + id + " no existe");
                }
                
                    return Ok(ticket);
                
            }
            catch (Exception  e)
            {
                return BadRequest(e.Message.ToString());
            }


        }

        // POST api/<ITHTicketController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ITHTicketController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ITHTicketController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
