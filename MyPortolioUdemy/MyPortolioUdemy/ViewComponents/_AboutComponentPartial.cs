using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL__Data_Access_Layer_.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _AboutComponentPartial: ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle=portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription=portfolioContext.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutetail=portfolioContext.Abouts.Select(x=>x.Details).FirstOrDefault();
            ViewBag.aboutDetail=portfolioContext.Abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}
