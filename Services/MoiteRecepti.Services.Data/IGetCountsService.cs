namespace MoiteRecepti.Services.Data
{
    using MoiteRecepti.Services.Data.Models;

    public interface IGetCountsService
    {
        // 1. Use the view model
        // 2. Create DTO -> view model
        // 3. Tuples
        CountsDto GetCounts();
    }
}
