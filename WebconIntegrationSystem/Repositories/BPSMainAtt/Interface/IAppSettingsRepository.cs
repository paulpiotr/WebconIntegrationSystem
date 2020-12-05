using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebconIntegrationSystem.Models.BPSMainAtt;

namespace WebconIntegrationSystem.Repositories.BPSMainAtt.Interface
{
    interface IAppSettingsRepository
    {
        bool Save(AppSettings appSettings);

        Task<bool> SaveAsync(AppSettings appSettings);
    }
}
