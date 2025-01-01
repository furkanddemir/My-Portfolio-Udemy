using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL__Data_Access_Layer_.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {

        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
