using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Reflection;
using NetAppCommon;
using Newtonsoft.Json;

namespace WebconIntegrationSystem.Models.BPSMainAtt
{
    #region public partial class AppSettings
    /// <summary>
    /// Klasa modelu ustawień aplikacji ErpSerwis.Core.Models
    /// The settings model class of the ErpSerwis.Core.Models
    /// </summary>
    [NotMapped]
    public partial class AppSettings : INotifyPropertyChanged
    {
        #region private static readonly log4net.ILog log4net
        /// <summary>
        /// Log4 Net Logger
        /// </summary>
        private static readonly log4net.ILog Log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region private static readonly string FileName
        /// <summary>
        /// Nazwa pliku z ustawieniami aplikacji ustawiona w zależności od wersji środowiska
        /// Application settings file name set depending on the version of the environment
        /// </summary>
        private static readonly string FileName = "bps.main.att.db.context.json";
        #endregion

        #region private static readonly string FilePath...
        /// <summary>
        /// Absolutna ścieżka do pliku konfiguracji
        /// The absolute path to the configuration file
        /// </summary>
        private readonly string _filePath = Path.Combine(Configuration.GetBaseDirectory(), FileName);
        #endregion

        #region public string GetFilePath()
        /// <summary>
        /// Pobierz bieżącą ścieżkę do pliku konfiguracji
        /// Get the current path to the configuration file
        /// </summary>
        /// <returns>
        /// Bieżąca ścieżka do pliku konfiguracji jako string
        /// Current path to the configuration file as a string
        /// </returns>
        public string GetFilePath()
        {
            return _filePath;
        }
        #endregion

        #region private static readonly string ConnectionStringName
        /// <summary>
        /// Nazwa połączenia bazy danych Mssql dla bieżącej aplikacji
        /// The name of the Mssql database connection for the current application
        /// </summary>
        private static readonly string ConnectionStringName = "BPSMainAttDbContext";
        #endregion

        #region public static AppSettings GetInstance()
        /// <summary>
        /// Pobierz instancję klasy AppSettings
        /// Get an instance of the AppSettings class
        /// </summary>
        /// <returns>
        /// Instanacja klasy AppSettings
        /// Instance of the AppSettings class
        /// </returns>
        public static AppSettings GetInstance()
        {
            return new AppSettings();
        }
        #endregion

        #region public AppSettings()
        /// <summary>
        /// Konstruktor - przypisanie zmiennych z pliku konfiguracyjnego
        /// Constructor - assigning variables from the configuration file
        /// </summary>
        public AppSettings()
        {
            try
            {
                var sourceFileName = _filePath;
                var destFileName = Path.Combine(Configuration.GetUserProfileDirectory(), FileName);
                if (File.Exists(sourceFileName) && !File.Exists(destFileName))
                {
                    if (!Directory.Exists(Path.GetDirectoryName(destFileName)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(destFileName));
                    }
                    File.Copy(sourceFileName, destFileName);
                }
                if (File.Exists(destFileName))
                {
                    _filePath = destFileName;
                }
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("\n{0}\n{1}\n{2}\n{3}\n", e.GetType(), e.InnerException?.GetType(), e.Message, e.StackTrace), e);
            }
            try
            {
                ConnectionString = Configuration.GetValue<string>(_filePath, string.Format("{0}:{1}", "ConnectionStrings", ConnectionStringName)) ?? @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=%Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)%\ErpSerwisMSSQLLocalDB\ErpSerwisMSSQLLocalDB.mdf; Database=%AttachDbFilename%; MultipleActiveResultSets=true; Integrated Security=True; Trusted_Connection=Yes";
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("\n{0}\n{1}\n{2}\n{3}\n", e.GetType(), e.InnerException?.GetType(), e.Message, e.StackTrace), e);
            }
        }
        #endregion

        #region private bool _cheskForConnection { get; set; }
        /// <summary>
        /// Sprawdź możliwość podłączenia do bazy danych\nz wpisanego parametru Ciąg połączenia do bazy danych Mssql
        /// Check the possibility of connecting to the database by entering the Mssql database connection string parameter
        /// </summary>
        private bool _cheskForConnection { get; set; }
        #endregion

        #region public bool CheskForConnection { get; set; }
        /// <summary>
        /// Sprawdź możliwość podłączenia do bazy danych\nz wpisanego parametru Ciąg połączenia do bazy danych Mssql
        /// Check the possibility of connecting to the database by entering the Mssql database connection string parameter
        /// </summary>
        [JsonIgnore]
        [Display(Name = "Sprawdź możliwość podłączenia do bazy danych\nz wpisanego parametru Ciąg połączenia do bazy danych Mssql", Prompt = "Zaznacz, jeśli chcesz sprawdzić możliwość podłączenia do bazy danych z wpisanego parametru Ciąg połączenia do bazy danych Mssql", Description = "Sprawdź możliwość podłączenia do bazy danych\nz wpisanego parametru Ciąg połączenia do bazy danych Mssql")]
        public bool CheskForConnection
        {
            get => _cheskForConnection;
            set
            {
                if (value != _cheskForConnection)
                {
                    _cheskForConnection = value;
                    OnPropertyChanged(nameof(CheskForConnection));
                }
            }
        }
        #endregion

        #region private string _connectionString { get; set; }
        /// <summary>
        /// Dostęp prywatny - ciąg połączenia do bazy danych Mssql jako string
        /// Private Access - Mssql database connection string as string
        /// </summary>
        private string _connectionString { get; set; }
        #endregion

        #region public string ConnectionString
        /// <summary>
        /// Dostęp publiczny - ciąg połączenia do bazy danych Mssql jako string
        /// Public Access - Mssql database connection string as a string
        /// </summary>
        [JsonIgnore]
        [Display(Name = "Ciąg połączenia do bazy danych Mssql", Prompt = "Wpisz ciąg połączenia do bazy danych Mssql", Description = "Ciąg połączenia do bazy danych Mssql")]
        [Required]
        [NetAppCommon.Validation.MssqlCanConnect]
        public string ConnectionString
        {
            get => _connectionString;
            set
            {
                _connectionString = value;
                OnPropertyChanged(nameof(ConnectionString));
                if (null != value && !string.IsNullOrWhiteSpace(value))
                {
                    ConnectionStrings = new Dictionary<string, string>
                    {
                        { ConnectionStringName, value }
                    };
                }
            }
        }
        #endregion

        #region public Dictionary<string, string> ConnectionStrings { get; private set; }
        /// <summary>
        /// Słownik zawierający definicję połączenia z nazwąklucza konfiguracji i wartością jako Dictionary
        /// A dictionary containing a connection definition with a configuration key name and value as Dictionary
        /// </summary>
        [JsonProperty(nameof(ConnectionStrings))]
        public Dictionary<string, string> ConnectionStrings { get; private set; }
        #endregion

        #region public string GetConnectionString()
        /// <summary>
        /// Pobierz parametry połączenia
        /// Get the connection string
        /// </summary>
        /// <returns>
        /// Parametry połączenia jako string lub null
        /// Connection string as string or null
        /// </returns>
        public string GetConnectionString()
        {
            try
            {
                return DatabaseMssql.ParseConnectionString(ConnectionString);
            }
            catch (Exception e)
            {
                Log4net.Error(string.Format("\n{0}\n{1}\n{2}\n{3}\n", e.GetType(), e.InnerException?.GetType(), e.Message, e.StackTrace), e);
            }
            return null;
        }
        #endregion

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
    }
    #endregion
}
