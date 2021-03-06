﻿using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WebconIntegrationSystem.Data.BPSMainAtt;
using WebconIntegrationSystem.Models.BPSMainAtt;

namespace WebconIntegrationSystem.Data.BPSMainAttDbContext
{
    #region public partial class BPSMainAttDbContext : DbContext
    /// <summary>
    /// Klasa kontekstu bazy danych System integracji ICASA UNIMOT
    /// Database context class ICASA UNIMOT integration system
    /// </summary>
    public partial class BPSMainAttDbContext : DbContext
    {
        #region private readonly ILog _log4Net
        /// <summary>
        /// private readonly ILog _log4Net
        /// </summary>
        private static readonly log4net.ILog Log4net = Log4netLogger.Log4netLogger.GetLog4netInstance(MethodBase.GetCurrentMethod()?.DeclaringType);
        #endregion

        #region private static readonly AppSettings appSettings...
        /// <summary>
        /// Instancja do klasy modelu ustawień jako AppSettings
        /// Instance to the settings model class as AppSettings
        /// </summary>
        private readonly AppSettings AppSettings = AppSettings.GetInstance();
        #endregion

        //#region private static readonly MemoryCacheEntryOptions memoryCacheEntryOptions
        ///// <summary>
        ///// Opcje wpisu pamięci podręcznej
        ///// Memory Cache Entry Options
        ///// </summary>
        //private static readonly MemoryCacheEntryOptions MemoryCacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(AppSettings.CacheLifeTime > 0 ? AppSettings.CacheLifeTime : 86400));
        //#endregion

        #region public BPSMainAttDbContext()
        /// <summary>
        /// Konstruktor Klasy kontekstu bazy danych
        /// Constructor Database Context Classes
        /// </summary>
        public BPSMainAttDbContext()
        {
        }
        #endregion

        #region public BPSMainAttDbContext(DbContextOptions<BPSMainAttDbContext> options)
        /// <summary>
        /// Konstruktor klasy kontekstu bazy danych api wykazu podatników VAT
        /// Constructor database context classes api list of VAT taxpayers
        /// </summary>
        /// <param name="options">
        /// Opcje połączenia da bazy danych options AS DbContextOptions<BPSMainAttDbContext>
        /// Connection options will give the options AS DbContextOptions<BPSMainAttDbContext>
        /// </param>
        public BPSMainAttDbContext(DbContextOptions<BPSMainAttDbContext> options)
            : base(options)
        {
        }
        #endregion

        public virtual DbSet<WfattachmentFiles> WfattachmentFiles { get; set; }

        #region protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        /// <summary>
        /// Zdarzenie wyzwalające konfigurację bazy danych
        /// Database configuration triggering event
        /// </summary>
        /// <param name="optionsBuilder">
        /// Fabryka budowania połączenia do bazy danych optionsBuilder jako DbContextOptionsBuilder
        /// Factory building connection to the database optionsBuilder AS DbContextOptionsBuilder
        /// </param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                //#if DEBUG
                //                ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
                //                {
                //                    builder.AddFilter(level => level == LogLevel.Debug).AddConsole();
                //                });
                //                optionsBuilder.UseLoggerFactory(loggerFactory);
                //#endif
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(AppSettings.GetConnectionString());
                }
            }
            catch (Exception e)
            {
                Log4net.Error($"\n{e.GetType()}\n{e.InnerException?.GetType()}\n{e.Message}\n{e.StackTrace}\n", e);
            }
        }
        #endregion

        #region protected override void OnModelCreating(ModelBuilder modelBuilder)
        /// <summary>
        /// Zdarzenie wyzwalające tworzenie modelu bazy danych
        /// The event that triggers the creation of the database model
        /// </summary>
        /// <param name="modelBuilder">
        /// Fabryka budowania modelu bazy danych modelBuilder jako ModelBuilder
        /// ModelBuilder database model building as ModelBuilder
        /// </param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WfattachmentFilesConfiguration());
        }
        #endregion

        #region partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        /// <summary>
        /// OnModelCreatingPartial
        /// </summary>
        /// <param name="modelBuilder">
        /// ModelBuilder modelBuilder
        /// </param>
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        #endregion

        //#region public MemoryCacheEntryOptions GetMemoryCacheEntryOptions()
        ///// <summary>
        ///// Uzyskaj opcje wpisu pamięci podręcznej
        ///// Get Memory Cache Entry Options
        ///// </summary>
        ///// <returns>
        ///// Opcje wpisu pamięci podręcznej
        ///// Memory Cache Entry Options
        ///// </returns>
        //public MemoryCacheEntryOptions GetMemoryCacheEntryOptions()
        //{
        //    return MemoryCacheEntryOptions;
        //}
        //#endregion
    }
    #endregion
}