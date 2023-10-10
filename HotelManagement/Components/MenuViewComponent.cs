using Microsoft.AspNetCore.Mvc;
using HotelManagement.Models;

namespace HotelManagement.Components
{
    [ViewComponent(Name = "MenuView")]
    public class MenuViewComponent : ViewComponent
    {
        private HotelManagementContext _context;

        public MenuViewComponent(HotelManagementContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Result = _context.Menus.Where(i => i.IsActive == 1 && i.Position == 1).ToList();

            return await Task.FromResult((IViewComponentResult)View("Default", Result));
        }
    }
}
