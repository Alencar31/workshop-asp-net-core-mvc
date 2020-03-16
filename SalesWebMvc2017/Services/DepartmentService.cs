using SalesWebMvc2017.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc2017.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc2017Context _context;

        public DepartmentService(SalesWebMvc2017Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
