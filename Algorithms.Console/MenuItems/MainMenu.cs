using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.ConsoleApp.MenuItems
{
    internal class MainMenu
    {
        public static readonly Lazy<List<IMenuItem>> MenuItems = new Lazy<List<IMenuItem>>(GetMenuItems);

        private static List<IMenuItem> GetMenuItems()
        {
            List<IMenuItem> menuItems = new List<IMenuItem>
            {
                new SortingMenuItems(),
                new SearchMenuItems(),
                new EncriptionMenuItems(),
            };
            return menuItems;
        }
    }
}
