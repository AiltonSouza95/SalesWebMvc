using SalesWebMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalesWebMvc.Application.Services.Interfaces
{
    public interface ISellerService
    {
        Task<List<Seller>> FindAllAsync();
        Task InsertAsync(Seller obj);
        Task<Seller> FindByIdAsync(int id);
        Task RemoveAsync(int id);
        Task UpdateAsync(Seller obj);
    }
}