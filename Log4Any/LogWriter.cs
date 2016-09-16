// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.If not, see<http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using log4net;
using log4net.Config;

namespace Log4Any
{
    public class LogWriter
    {
        private static ILog _logger;
        private Type _type;

        static LogWriter()
        {
            // Set up a simple configuration that logs on the console
            BasicConfigurator.Configure();
        }

        /// <summary>
        /// Constructor with one argument.
        /// </summary>
        /// <param name="type">type of class</param>
        public LogWriter(Type type)
        {
            _type = type;
            _logger = LogManager.GetLogger(type);
        }

        /// <summary>
        /// Print Verbose message.
        /// </summary>
        /// <param name="message">message</param>
        public void Verbose(string message) => _logger.Verbose(_type.DeclaringType, message);

        /// <summary>
        /// Prints formatted Verbose message <para />
        /// Example: _logWriter.VerboseFormat("foo: {0}", bar);
        /// </summary>
        /// <param name="format">format.</param>
        /// <param name="args">arguments</param>
        public void VerboseFormat(string format, params object[] args) => _logger.VerboseFormat(_type, args);

        /// <summary>
        /// Print Trace message.
        /// </summary>
        /// <param name="message">message</param>
        public void Trace(string message) => _logger.Trace(_type.DeclaringType, message);

        /// <summary>
        /// Prints formatted Trace message <para />
        /// Example: _logWriter.TraceFormat("foo: {0}", bar);
        /// </summary>
        /// <param name="format">format.</param>
        /// <param name="args">arguments</param>
        public void TraceFormat(string format, params object[] args) => _logger.TraceFormat(_type, format, args);

        /// <summary>
        /// Print Debug message.
        /// </summary>
        /// <param name="message">message</param>
        public void Debug(string message) => _logger.Debug(message);

        /// <summary>
        /// Prints formatted Debug message <para />
        /// Example: _logWriter.DebugFormat("foo: {0}", bar);
        /// </summary>
        /// <param name="format">format.</param>
        /// <param name="args">arguments</param>
        public void DebugFormat(string format, params object[] args) => _logger.DebugFormat(format, args);

        /// <summary>
        /// Print Info message.
        /// </summary>
        /// <param name="message"></param>
        public void Info(string message) => _logger.Info(message);

        /// <summary>
        /// Prints formatted Info message <para />
        /// Example: _logWriter.InfoFormat("foo: {0}", bar);
        /// </summary>
        /// <param name="format">format.</param>
        /// <param name="args">arguments</param>
        public void InfoFormat(string format, params object[] args) => _logger.InfoFormat(format, args);

        /// <summary>
        /// Prints Warn message.
        /// </summary>
        /// <param name="message">message</param>
        public void Warn(string message) => _logger.Warn(message);

        /// <summary>
        /// Prints formatted Warn message <para />
        /// Example: _logWriter.WarnFormat("foo: {0}", bar);
        /// </summary>
        /// <param name="format">format.</param>
        /// <param name="args">arguments</param>
        public void WarnFormat(string format, params object[] args) => _logger.WarnFormat(format, args);

        /// <summary>
        /// Prints Error message.
        /// </summary>
        /// <param name="message">message</param>
        public void Error(string message) => _logger.Error(message);

        /// <summary>
        /// Prints formatted Error message <para />
        /// Example: _logWriter.ErrorFormat("foo: {0}", bar);
        /// </summary>
        /// <param name="format">format.</param>
        /// <param name="args">arguments</param>
        public void ErrorFormat(string format, params object[] args) => _logger.ErrorFormat(format, args);

        /// <summary>
        /// Prints Fatal message. Use this when thing went even worse than ERROR.
        /// </summary>
        /// <param name="message">message</param>
        public void Fatal(string message) => _logger.Fatal(message);

        /// <summary>
        /// Prints formatted Fatal message <para />
        /// Example: _logWriter.FatalFormat("foo: {0}", bar);
        /// </summary>
        /// <param name="format">format.</param>
        /// <param name="args">arguments</param>
        public void FatalFormat(string format, params object[] args) => _logger.FatalFormat(format, args);
    }
}
