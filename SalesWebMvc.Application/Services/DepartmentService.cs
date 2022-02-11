using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Application.Services.Interfaces;
using SalesWebMvc.Domain.Models;
using SalesWebMvc.Infra.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SalesWebMvc.Application.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<Department> GetByIdAsync(int? id)
        {
            var department = await _context.Department
                .FirstOrDefaultAsync(m => m.Id == id);

            return department;
        }

        public async Task CreateAsync(Department department)
        {
            _context.Add(department);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(Department department)
        {
            _context.Update(department);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int? id)
        {
            var department = _context.Department.FirstOrDefault(x => x.Id == id);
            if (department != null)
            {
                return;
            }
            _context.Department.Remove(department);
            await _context.SaveChangesAsync();
        }

        public bool DepartmentExists(int id)
        {
            return _context.Department.Any(e => e.Id == id);
        }
    }
}