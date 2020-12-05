using NetAppCommon;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WebconIntegrationSystem.Data.BPSMainAttDbContext;
using WebconIntegrationSystem.Models.BPSMainAtt;
using WebconIntegrationSystem.Repositories.BPSMainAtt.Interface;


namespace WebconIntegrationSystem.Repositories.BPSMainAtt
{
    public class AppSettingsRepository : IAppSettingsRepository
    {
        #region private static readonly log4net.ILog log4net
        /// <summary>
        /// Log4net Logger
        /// Log4net Logger
        /// </summary>
        private static readonly log4net.ILog Log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        //#region protected Data.IUIntegrationSystemDataDbContext context...
        ///// <summary>
        ///// Kontekst do bazy danych jako Data.IUIntegrationSystemDataDbContext
        ///// Context to the database as Data.IUIntegrationSystemDataDbContext
        ///// </summary>
        //private readonly BPSMainAttDbContext _context;
        //#endregion

        public AppSettingsRepository()
        {
            //_context = new BPSMainAttDbContext();
        }

        //public AppSettingsRepository(BPSMainAttDbContext context)
        //{
        //    _context = context;
        //}

        public static AppSettingsRepository GetInstance()
        {
            return new AppSettingsRepository();
        }

        //public static AppSettingsRepository GetInstance(BPSMainAttDbContext context)
        //{
        //    return new AppSettingsRepository(context);
        //}

        public bool Save(AppSettings appSettings)
        {
            try
            {
                Configuration.SaveConfigurationToFile(appSettings, appSettings.GetFilePath());
                return true;
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("\n{0}\n{1}\n{2}\n{3}\n", e.GetType(), e.InnerException?.GetType(), e.Message, e.StackTrace), e);
            }
            return false;
        }

        public async Task<bool> SaveAsync(AppSettings appSettings)
        {
            try
            {
                return await Task.Run(async () =>
                {
                    await Configuration.SaveConfigurationToFileAsync(appSettings, appSettings.GetFilePath());
                    return true;
                });
            }
            catch (Exception e)
            {
                await Task.Run(() => Log4net.Error(string.Format("{0}, {1}.", e.Message, e.StackTrace), e));
            }
            return false;
        }
    }
}
