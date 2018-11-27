using ContactManager.Models;
using ContactManager.Services;
using System.Web.Http;

namespace ContactManager.Controllers
{
    public class ContactController : ApiController
    {
        
            private ContactRepository contactRepository;

            public ContactController()
            {
                this.contactRepository = new ContactRepository();
            }

        // GET api/<controller>
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}