using System.Threading.Tasks;
using WebconIntegrationSystem.Models.BPSMainAtt;

namespace WebconIntegrationSystem.Repositories.BPSMainAtt.Interface
{
    public interface IWfattachmentFilesRepository
    {
        WfattachmentFiles FindByAtfId(int atfId);

        Task<WfattachmentFiles> FindByAtfIdAsync(int atfId);

        WfattachmentFiles Modify(WfattachmentFiles wfattachmentFiles);

        Task<WfattachmentFiles> ModifyAsync(WfattachmentFiles wfattachmentFiles);
    }
}
