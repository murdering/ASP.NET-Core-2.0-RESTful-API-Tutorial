﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MyRestful.Core.DomainModels;

namespace MyRestful.Core.Interfaces
{
    public interface ICountryRepository
    {
        Task<PaginatedList<Country>> GetCountriesAsync(CountryResourceParameters parameters);
        void AddCountry(Country country);
        Task<Country> GetCountryByIdAsync(int id, bool includeCities = false);
        Task<bool> CountryExistAsync(int countryId);
        Task<IEnumerable<Country>> GetCountriesAsync(IEnumerable<int> ids);
        void DeleteCountry(Country country);
        void UpdateCountry(Country country);
    }
}