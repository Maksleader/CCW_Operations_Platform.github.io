using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CareProviderPortal.MultiTenancy.HostDashboard.Dto;

namespace CareProviderPortal.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}