using AppMultTenant.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMultTenant.Controllers
{
    public class ContactsController : ControllerBase
    {
        [HttpGet("/{clientName}/contacts")]
        public async Task<IActionResult> GetContacts(
           [FromRoute] string clientName,
           [FromServices] CustomerDataContext context)
        {
           // var contacts = await context.Contacts.ToListAsync();
            var contacts = await context.Contacts.FromSqlRaw($"GetContactList").ToListAsync();

            //GetContactList sdsdfsfd

            

            return Ok(contacts);
        }
    }
}
