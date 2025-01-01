using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL__Data_Access_Layer_.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
