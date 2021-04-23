using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiNorthwind.Data;
using WebApiNorthwind.Models;

namespace WebApiNorthwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly NorthwindContext _context;
        public CustomerController(NorthwindContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Customers> Get()
        {

            return _context.Customers.ToList();
        }

        //api/customer/ 2 (codigo del customer)    /
        [HttpGet("{id}")]
        public ActionResult<Customers> Get(string id)  // ActionResult es una var para devolver todo tipo de resultados
        {
            return _context.Customers.Find(id);
        }

        [HttpGet("GetByCity/{city}")]
        //customer/GetByCity/Berlin
        public IEnumerable<Customers> GetByCity(string city) 
        {
            List<Customers> customers = (from c in _context.Customers
                                         where c.City == city
                                         select c).ToList();
            if (customers == null)
            {
                 NotFound();
            }
            return customers;
        }

        // CREAR UN NUEVO CUSTOMER
        [HttpPost]
        public ActionResult Post([FromBody] Customers customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();    //conecta a la DB-insert a la tabla customer-desconecta

            return new CreatedAtRouteResult("ObtenerCustomer", new { id = customer.CustomerId, customer });
            // metodo donde paso la ruta y el id del customer insertado
        }

        // MODIFICAR EL CUSTOMER
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Customers customer)
        {
            if (id != customer.CustomerId)
            {
                BadRequest();
            }
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();        //envia el update de la tabla a la base de datos
            return Ok();

        }

        // ELIMINAR EL CUSTOMER
        [HttpDelete("{id}")]
        public ActionResult<Customers> Delete(string id)
        {
            var customer = _context.Customers.Find(id);

            if (customer == null)
            {
                return NotFound();
            }


            _context.Customers.Remove(customer);
            _context.SaveChanges();//enviar el delete from a la base de datos
            return customer;

        }
    }
}

