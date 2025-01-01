using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL__Data_Access_Layer_.Context;

namespace MyPortolioUdemy.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount=context.ToDoLists.Where(x=>x.Status==false).Count(); //Yapılmamış/okunmamış olan bildirim sayısı
            var values=context.ToDoLists.Where(x=>x.Status == false).ToList(); //Henüz yapılmamış olan metotları/bildirimleri getirir.
            return View(values);
        }
    }
}
