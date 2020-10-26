using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mapper.Models;
using AutoMapper;
using Mapper.Entities.OuterSourceWrapper;
using Mapper.Models.OuterDestWrapper;
using System;
using Mapper.Entities;

namespace Mapper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }  

        public IActionResult Index()
        {
            UserViewModel userViewModel = new UserViewModel() { Email = "Email", Name = "Name", Password = "Password", UserName = "UserName" };
            AppUser domainUser = _mapper.Map<AppUser>(userViewModel);
            domainUser.UserId = 10;
            domainUser.Email = "Hehe";
            UserViewModel userViewModel2 = _mapper.Map<UserViewModel>(domainUser);
            return View(domainUser);
        }
         
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("MappingNestedObject")]
        public IActionResult MappingNestedObject()
        {
            var source = new OuterSource
            {
                Value = 5,
                Inner = new InnerSource { OtherValue = 15 }
            };
            var destination = _mapper.Map<OuterDest>(source);
            return Ok(destination);
        }

        [HttpGet("Projection")]
        public IActionResult Projection()
        {
            var calendarEvent = new ProjectionCalenderEvent
            {
                Date = new DateTime(2008, 12, 15, 20, 30, 0),
                Title = "Company Holiday Party"
            };
            var eventForm = _mapper.Map<ProjectionCalenderEvent, ProjectionCalenderEventForm>(calendarEvent);
            return Ok(eventForm);
        }
    }
}
