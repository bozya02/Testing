using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prak4.DataBase
{
    public partial class ToysShopEntities
    {
        private static ToysShopEntities _context;

        public static ToysShopEntities GetContext()
        {
            if (_context == null)
                _context = new ToysShopEntities();

            return _context;
        }
    }
}
