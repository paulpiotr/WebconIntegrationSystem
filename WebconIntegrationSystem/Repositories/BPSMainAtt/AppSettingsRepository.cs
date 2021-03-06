using System;
using System.Reflection;
using System.Threading.Tasks;
using NetAppCommon;
using WebconIntegrationSystem.Models.BPSMainAtt;
using WebconIntegrationSystem.Repositories.BPSMainAtt.Interface;

namespace WebconIntegrationSystem.Repositories.BPSMainAtt
{
    public class AppSettingsRepository : IAppSettingsRepository
    {
        #region private readonly log4net.ILog log4net
        /// <summary>
        /// Log4net Logger
        /// Log4net Logger
        /// </summary>
        private static readonly log4net.ILog Log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod()?.DeclaringType);
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
                Configuration.SaveToFile(appSettings, appSettings.GetFilePath());
                return true;
            }
            catch (Exception e)
            {
                Log4net.Error($"\n{e.GetType()}\n{e.InnerException?.GetType()}\n{e.Message}\n{e.StackTrace}\n", e);
            }
            return false;
        }

        public async Task<bool> SaveAsync(AppSettings appSettings)
        {
            try
            {
                return await Task.Run(async () =>
                {
                    await Configuration.SaveToFileAsync(appSettings, appSettings.GetFilePath());
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
