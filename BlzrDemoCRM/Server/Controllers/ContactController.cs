using BlzrDemoCRM.Server.Interfaces;
using BlzrDemoCRM.Shared.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlzrDemoCRM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContact _IContact;
        public ContactController(IContact iContact)
        {
            _IContact = iContact;
        }

        [HttpGet]  
        public async Task<List<Contact>> Get()
        {
            return await Task.FromResult(_IContact.ListContacts());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Contact contact = _IContact.GetContactById(id);
            if (contact != null)
            {
                return Ok(contact);
            }
            return NotFound();
        }

        [HttpPost]
        public void Post(Contact contact)
        {
            _IContact.AddContact(contact);
        }

        [HttpPut]
        public void Put(Contact contact)
        {
            _IContact.UpdateContact(contact);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _IContact.RemoveContact(id);
            return Ok();
        }
    }
}
