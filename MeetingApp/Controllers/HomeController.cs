using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers {
    public class HomeController : Controller {
        public IActionResult Index(){
            int saat = DateTime.Now.Hour;
            

            ViewBag.Selamlama = saat > 12 ? "İyi günler" : "Günaydın";
            int usercount = Repository.Users.Where(i=>i.WillAttend == true).Count();

            //ViewBag.userName = "Ozan";

            var meetinginfo = new MeetingInfo(){
                Id = 1,
                location = "Eskişehir , Merkez",
                date = new DateTime(2025,02,6,20 ,0 , 0),
                numberofpeople = usercount
            };

            return View(meetinginfo);
        }
    }
}