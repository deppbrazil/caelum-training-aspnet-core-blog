using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Blog.Models;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {

            Post postOne = new Post()
            {
                Title = "Pirates of the Caribbean",
                Resume = "William Turner, a resourceful young blacksmith, " +
                "teams up with the eccentric pirate Captain Jack Sparrow " +
                "to save his love, the Governor's daughter, Elizabeth Swann, " +
                "who has been mistakenly captured by the clever and " +
                "treacherous Barbossa, a former ally of Jack, to make a blood " +
                "sacrifice so as to end the curse that has ...",
                Category = "Action"
            };

            Post postTwo = new Post()
            {
                Title = "Avengers",
                Resume = "S.H.I.E.L.D. has located the mysterious Tesseract " +
                "device and the Army's super soldier Captain America. The Tesseract " +
                "is actually a gateway to an entirely new world called Asgard. " +
                "A mysterious being known as Loki arrives on earth and immediately " +
                "assumes that he can rule all human beings. But that irks S.H.I.E.L.D. " +
                "director Nick Fury the wrong way. As Loki escapes with the Tesseract, " +
                "Nick Fury believes this is an act of war against Earth. His only hope " +
                "is to assemble an actual team of super heroes. Dr. Bruce Banner, " +
                "who turns into an enormous green rage monster known as the Hulk. " +
                "Tony Stark and his venerable Iron Man armor. Captain America, " +
                "the Stark Enterprises created super soldier. Thor, the god of thunder, " +
                "protector of Earth and his home planet of Asgard, and Loki's brother. " +
                "Master assassins Hawkeye and Natasha Romanoff. Together they will become " +
                "a team to take on an attack that will call them to become the greatest of all time.",
                Category = "Action"
            };

            Post[] posts = new Post[] { postOne, postTwo };
            
            //ViewBag.Posts = posts;
            
            return View(posts);
        }        
    }
}
