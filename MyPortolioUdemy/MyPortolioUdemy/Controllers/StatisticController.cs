using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL__Data_Access_Layer_.Context;

namespace MyPortolioUdemy.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count(); //Message tablosundaki toplam mesaj sayısı
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count(); //Message tablosundaki okunmayan mesaj sayısı
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count(); //Message tablosundaki okunan mesaj sayısı
            return View();
        }
    }
}
