using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using log4net;
using log4net.Core;
using System.Reflection;

namespace Log4Any
{
    internal static class ILogExtensions
    {
        private static readonly ILog _log;

        static ILogExtensions()
        {
            _log = LogManager.GetLogger(nameof(ILogExtensions));
        }

        public static void Verbose(this ILog log, Type callerStackBoundaryDeclaringType, object message, Exception exception)
        {
            _log.Logger.Log(callerStackBoundaryDeclaringType, Level.Verbose, message, exception);
        }

        public static void Verbose(this ILog log, Type callerStackBoundaryDeclaringType, object message)
        {
            _log.Verbose(callerStackBoundaryDeclaringType, message, null);
        }

        public static void VerboseFormat(this ILog log, Type callerStackBoundaryDeclaringType, params object[] args)
        {
            var arg0 = args[0].ToString();
            var args123 = args.Skip(1).ToArray();

            _log.Verbose(callerStackBoundaryDeclaringType, string.Format(arg0, args123), null);
        }

        public static void Trace(this ILog log, Type callerStackBoundaryDeclaringType, object message, Exception exception)
        {
            _log.Logger.Log(callerStackBoundaryDeclaringType, Level.Trace, message, exception);
        }

        public static void Trace(this ILog log, Type callerStackBoundaryDeclaringType, object message)
        {
            _log.Trace(callerStackBoundaryDeclaringType, message, null);
        }

        public static void TraceFormat(this ILog log, Type callerStackBoundaryDeclaringType, params object[] args)
        {
            var arg0 = args[0].ToString();
            var args123 = args.Skip(1).ToArray();

            _log.Trace(callerStackBoundaryDeclaringType, string.Format(arg0, args123), null);
        }
    }
}
