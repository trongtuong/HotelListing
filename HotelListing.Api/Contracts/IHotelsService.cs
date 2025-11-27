using HotelListing.Api.DTOs.Hotel;

namespace HotelListing.Api.Contracts;

public interface IHotelsService
{
    Task<bool> HotelExistsAsync(int id);
    Task<bool> HotelExistsAsync(string name);
    Task<IEnumerable<GetHotelDto>> GetHotelsAsync();
    Task<GetHotelDto?> GetHotelAsync(int id);
    Task<GetHotelDto> CreateHotelAsync(CreateHotelDto createDto);
    Task UpdateHotelAsync(int id, UpdateHotelDto updateDto);
    Task DeleteHotelAsync(int id);
}