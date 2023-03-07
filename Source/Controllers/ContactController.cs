﻿using Microsoft.AspNetCore.Mvc;
using Source.Contexts;

namespace Source.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactsController : Controller
{
    private readonly ContactsAPIDbContext dbContext;

    public ContactsController(ContactsAPIDbContext dbContext)
    {
        this.dbContext = dbContext;
    }


    [HttpGet]
    public IActionResult GetContacts()
    {
       return Ok(dbContext.Contacts.ToList());
    }
}
