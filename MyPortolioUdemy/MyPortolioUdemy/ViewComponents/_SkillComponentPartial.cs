using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL__Data_Access_Layer_.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
