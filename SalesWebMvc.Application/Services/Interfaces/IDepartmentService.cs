using SalesWebMvc.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesWebMvc.Application.Services.Interfaces
{
    public interface IDepartmentService
    {
        Task<List<Department>> FindAllAsync();
        Task<Department> GetByIdAsync(int? id);
        Task CreateAsync(Department department);
        Task EditAsync(Department department);
        Task DeleteAsync(int? id);
        bool DepartmentExists(int id);
    }
}