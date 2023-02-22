using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System.Linq;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = messageManager.TGetList().Take(5).ToList();
            return View(values);
        }
    }
}
