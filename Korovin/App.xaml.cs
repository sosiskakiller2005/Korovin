using Korovin.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Korovin
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static KorovinDbEntities _context;
        public static KorovinDbEntities GetContext()
        {
            if (_context == null)
            {
                _context = new KorovinDbEntities();
            }
            return _context;
        }
    }
}
