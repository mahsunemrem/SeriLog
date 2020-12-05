using SeriLog.Logger.SeriLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeriLog.Logger
{
    public class DatabaseLogger : LoggingConfiguration, ILogManager
    {
        //protected override Logger GetLogger()
        //{
        //    var configuration = new ConfigurationBuilder()
        //         .SetBasePath(Directory.GetCurrentDirectory())
        //         .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        //         .Build();

        //    return new LoggerConfiguration()
        //            .WriteTo.MSSqlServer(connectionString: configuration.GetConnectionString("ConnectionString"), tableName: "Log", autoCreateSqlTable: true)
        //            .CreateLogger();
        //}

        //public void Verbose(string message) => GetLogger().Verbose(message);
        //public void Verbose(string message, T t) => GetLogger().Verbose(message, t);
        //public void Fatal(string message) => GetLogger().Fatal(message);
        //public void Fatal(string message, T t) => GetLogger().Fatal(message, t);
        //public void Information(string message) => GetLogger().Information(message);
        //public void Information(string message, T t) => GetLogger().Information(message, t);
        //public void Warning(string message) => GetLogger().Warning(message);
        //public void Warning(string message, T t) => GetLogger().Warning(message, t);
        //public void Debug(string message) => GetLogger().Debug(message);
        //public void Debug(string message, T t) => GetLogger().Debug(message, t);
        //public void Error(string message) => GetLogger().Error(message);
        //public void Error(string message, T t) => GetLogger().Error(message, t);

    }
}
