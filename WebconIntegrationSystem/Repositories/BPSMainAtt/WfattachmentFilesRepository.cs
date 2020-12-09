using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebconIntegrationSystem.Data.BPSMainAttDbContext;
using WebconIntegrationSystem.Models.BPSMainAtt;
using WebconIntegrationSystem.Repositories.BPSMainAtt.Interface;

namespace WebconIntegrationSystem.Repositories.BPSMainAtt
{
    public class WfattachmentFilesRepository : /*MvxViewModel, */IWfattachmentFilesRepository, INotifyPropertyChanged
    {
        private IEnumerable<WfattachmentFiles> _ieEnumerableWfattachmentFiles;

        public IEnumerable<WfattachmentFiles> IEnumerableWfattachmentFiles
        {
            get => _ieEnumerableWfattachmentFiles;
            set
            {
                if (value != _ieEnumerableWfattachmentFiles)
                {
                    _ieEnumerableWfattachmentFiles = value;
                    OnPropertyChanged(nameof(IEnumerableWfattachmentFiles));
                }
            }
        }

        private WfattachmentFiles _wfattachmentFiles;

        public WfattachmentFiles WfattachmentFiles
        {
            get => _wfattachmentFiles;
            set
            {
                if (value != _wfattachmentFiles)
                {
                    _wfattachmentFiles = value;
                    OnPropertyChanged(nameof(WfattachmentFiles));
                }
            }
        }

        #region private static readonly log4net.ILog log4net
        /// <summary>
        /// Log4net Logger
        /// Log4net Logger
        /// </summary>
        private readonly log4net.ILog _log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region private readonly BPSMainAttDbContext _context
        /// <summary>
        /// Kontekst do bazy danych jako WebconIntegrationSystem.Data.BPSMainAttDbContext
        /// Context to the database as WebconIntegrationSystem.Data.BPSMainAttDbContext
        /// </summary>
        private readonly BPSMainAttDbContext _context;
        #endregion

        public WfattachmentFilesRepository()
        {
            _context = new BPSMainAttDbContext();
        }

        public WfattachmentFilesRepository(BPSMainAttDbContext context)
        {
            _context = context;
        }

        public static WfattachmentFilesRepository GetInstance()
        {
            return new WfattachmentFilesRepository();
        }

        public static WfattachmentFilesRepository GetInstance(BPSMainAttDbContext context)
        {
            return new WfattachmentFilesRepository(context);
        }

        public WfattachmentFiles FindByAtfId(int atfId)
        {
            try
            {
                return _context.WfattachmentFiles.Find(atfId);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("\n{0}\n{1}\n{2}\n{3}\n", e.GetType(), e.InnerException?.GetType(), e.Message, e.StackTrace), e);
            }
            return WfattachmentFiles;
        }

        public async Task<WfattachmentFiles> FindByAtfIdAsync(int atfId)
        {
            try
            {
                WfattachmentFiles = await _context.WfattachmentFiles.FindAsync(atfId);
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("\n{0}\n{1}\n{2}\n{3}\n", _context.Database.GetDbConnection().ConnectionString, e.InnerException?.GetType(), e.Message, e.StackTrace), e);
            }
            return WfattachmentFiles;
        }

        public WfattachmentFiles Modify(WfattachmentFiles wfattachmentFiles)
        {
            try
            {
                WfattachmentFiles = wfattachmentFiles;
                _context.Entry(wfattachmentFiles).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("\n{0}\n{1}\n{2}\n{3}\n", e.GetType(), e.InnerException?.GetType(), e.Message, e.StackTrace), e);
            }
            return WfattachmentFiles;
        }

        public async Task<WfattachmentFiles> ModifyAsync(WfattachmentFiles wfattachmentFiles)
        {
            try
            {
                WfattachmentFiles = wfattachmentFiles;
                _context.Entry(wfattachmentFiles).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _log4net.Error(string.Format("\n{0}\n{1}\n{2}\n{3}\n", e.GetType(), e.InnerException?.GetType(), e.Message, e.StackTrace), e);
            }
            return WfattachmentFiles;
        }

        #region Interface implementation INotifyPropertyChanged
        #region public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// PropertyChangedEventHandler PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        /// <summary>
        /// protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        /// </summary>
        /// <param name="args"></param>
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            PropertyChanged?.Invoke(this, args);
            //base.PropertyChanged += PropertyChanged;
        }
        #endregion

        #region private void OnPropertyChanged(string propertyName)
        /// <summary>
        /// private void OnPropertyChanged(string propertyName)
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #endregion
    }
}
