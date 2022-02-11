using SalesWebMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWebMvc.Application.Services.Interfaces
{
    public interface ISaleRecordService
    {
        Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate);
        Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate);
    }
}
