using System.Threading.Tasks;
using WebconIntegrationSystem.Models.BPSMainAtt;

namespace WebconIntegrationSystem.Repositories.BPSMainAtt.Interface
{
    internal interface IAppSettingsRepository
    {
        bool Save(AppSettings appSettings);

        Task<bool> SaveAsync(AppSettings appSettings);
    }
}
