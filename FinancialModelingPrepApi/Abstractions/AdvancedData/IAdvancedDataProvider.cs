﻿using MatthiWare.FinancialModelingPrep.Model;
using MatthiWare.FinancialModelingPrep.Model.AdvancedData;
using System.Threading.Tasks;

namespace MatthiWare.FinancialModelingPrep.Abstractions.AdvancedData
{
    public interface IAdvancedDataProvider
    {
        #region Annual Reports On Form 10-K
        Task<ApiResponse<string>> GetAnnualReportsForm10KJsonAsync(string symbol, int year);
        Task<ApiResponse<string>> GetQuarterlyReportsForm10QJsonAsync(string symbol, int year, Quarter quarter);
        #endregion

        #region Standard Industrial Classification
        Task<ApiResponse<StandardIndustrialClassificationResponse>> GetStandardIndustrialClassificationByCikAsync(string cik);
        Task<ApiResponse<StandardIndustrialClassificationResponse>> GetStandardIndustrialClassificationBySymbolAsync(string symbol);
        Task<ApiResponse<StandardIndustrialClassificationResponse>> GetStandardIndustrialClassificationBySicCodeAsync(string sic);
        #endregion
    }
}