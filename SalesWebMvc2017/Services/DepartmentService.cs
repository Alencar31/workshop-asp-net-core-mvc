using SalesWebMvc2017.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc2017.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc2017Context _context;

        public DepartmentService(SalesWebMvc2017Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
