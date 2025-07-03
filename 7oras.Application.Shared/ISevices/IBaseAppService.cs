namespace _7oras.Application.Shared.ISevices
{
    public interface IBaseAppService<TAppCreateDto, TAppUpdateDto, TAppResDto>
        where TAppCreateDto : class
        where TAppUpdateDto : class
        where TAppResDto : class
    {
        Task<TAppResDto> GetAsync(Guid id);
        Task<IList<TAppResDto>> GetAllAsync();
        Task<TAppResDto> CreateAsync(TAppCreateDto dto);
        Task<TAppResDto> UpdateAsync(TAppUpdateDto dto);
        Task<TAppResDto> DeleteAsync(Guid id);
    }
}
