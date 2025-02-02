﻿using PhoneBook.Shared.Dtos;
using PhoneBook.Shared.ResultTypes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhoneBook.Reports.Host.Services.Abstract
{
    public interface IReportManager
    {
        Task<DataResult<List<ReportDto>>> GetAllAsync();
        Task<DataResult<ReportDto>> GetByIdAsync(string id);
        Task<DataResult<ReportDto>> AddAsync(ReportDto model);
        Task<Result> UpdateAsync(ReportDto model);
    }
}
