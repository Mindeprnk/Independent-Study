using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnlineBooksStore.Models;

namespace OnlineBooksStore.Controllers.API
{
    public class CustomersController : ApiController
    {
        private readonly MyDbContext _context;
        public CustomersController()
        {
            _context = new MyDbContext();
        }

        //GET /api/customers
        public IEnumerable<Customer> GetCustomers()
        {
           return _context.Customers.ToList();
        }

        //GET /api/customers/1
        public Customer GetCustomers(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return customer;
        }

        //POST /api/customers
        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if(!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return customer;

        }

        //PUT /api/customers/1
        [HttpPut]
        public Customer UpdateCustomer(int id,Customer customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerinDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerinDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            customerinDb.Name = customer.Name;
            customerinDb.DateOfBirth = customer.DateOfBirth;
            customerinDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            customerinDb.MembershipTypeId = customer.MembershipTypeId;

            _context.SaveChanges();

            return customerinDb;
        }

        //DELETE /api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerinDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerinDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerinDb);
            _context.SaveChanges();
        }
    } 
}
