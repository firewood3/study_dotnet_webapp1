using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class StudyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Inner()
        {
            return View();
        }

        public IActionResult Model()
        {
            var member = new Member
            {
                Age = 10,
                Name = "홍길동"
            };

            List<Member> memberList = new List<Member>();
            memberList.Add(new Member
            {
                Name = "foo", 
                Age = 1
            });
            memberList.Add(member);
            ViewBag.memberList = memberList;
            ViewBag.title = "모텔 테스트 페이지 입니다.";

            // 원시형만 가능합니다.
            ViewData["firstName"] = "Lebron";
            ViewData["lastName"] = "James";
            ViewData["age"] = 36;
            return View(member);
        }
    }
}