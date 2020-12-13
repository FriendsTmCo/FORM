using System.Threading.Tasks;

namespace Services.Manager
{
    public interface ICrudManager
    {
        Task<bool> InsertAsync();
        Task<bool> UpdateAsync();
        Task<bool> DeleteAsync();
        Task<bool> DeleteAsync(object Id);
    }
}
