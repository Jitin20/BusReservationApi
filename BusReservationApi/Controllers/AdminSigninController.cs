﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BusReservationApi.Controllers
{
    public class Admin {
        public int AdminId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class AdminSigninController : ControllerBase
    {

        static List<Admin> admins = new List<Admin> {
            new Admin{ AdminId = 1, Email = "admin1@gmail.com", Password = "admin", FirstName = "Anshul", LastName = "Bansal"},
            new Admin{ AdminId = 2, Email = "admin2@gmail.com", Password = "admin", FirstName = "Jitin", LastName = "Sharma"},
            new Admin{ AdminId = 3, Email = "admin3@gmail.com", Password = "admin", FirstName = "Divya", LastName = "Kumar"},
            new Admin{ AdminId = 4, Email = "admin4@gmail.com", Password = "admin", FirstName = "Omkar", LastName = "Bhagwat"}

        };

        
    }
}