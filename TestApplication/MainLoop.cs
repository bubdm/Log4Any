using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Log4Any;

namespace TestApplication
{
    public class MainLoop
    {
        private LogWriter _logWriter;

        #region static void Run();
        private static MainLoop _instance;
        static MainLoop() { }
        public static void Run(params object[] args) => _instance = new MainLoop(args);
        #endregion

        private MainLoop(params object[] args)
        {
            #region string message initializes
            var format = "{0} message.";
            var trace = string.Format(format, "Trace");
            var debug = string.Format(format, "Debug");
            var info = string.Format(format, "Info");
            var warn = string.Format(format, "Warn");
            var error = string.Format(format, "Error");
            var fatal = string.Format(format, "Fatal");
            var type = GetType();
            #endregion

            _logWriter = new LogWriter( GetType() );
            _logWriter.Trace(trace);
            _logWriter.Debug(debug);
            _logWriter.Info(info);
            _logWriter.Warn(warn);
            _logWriter.Error(error);
            _logWriter.Fatal(fatal);

            if (args.Length == 0)
                return;

            _logWriter.Debug("Wait!");
            _logWriter.Info("There are more!!");
            _logWriter.Warn("");

            foreach(var arg in args)
            {
                _logWriter.Error(arg.ToString());
            }

        }
    }
}
