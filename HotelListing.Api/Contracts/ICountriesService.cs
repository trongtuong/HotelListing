using HotelListing.Api.DTOs.Country;

namespace HotelListing.Api.Contracts;

public interface ICountriesService
{
    Task<bool> CountryExistsAsync(int id);
    Task<bool> CountryExistsAsync(string name);
    Task<IEnumerable<GetCountriesDto>> GetCountriesAsync();
    Task<GetCountryDto?> GetCountryAsync(int id);
    Task<GetCountryDto> CreateCountryAsync(CreateCountryDto createDto);
    Task UpdateCountryAsync(int id, UpdateCountryDto updateDto);
    Task DeleteCountryAsync(int id);
}