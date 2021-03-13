using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfrastructureLogger
{
    public static class LoggerAdapter
    {
        private static IConfiguration _configuration;
        public static IConfiguration Configuration
        {
            set
            {
                if (_configuration == null)
                {
                    _configuration = value;
                }
            }
        }
        /// <summary>
        /// Debug
        /// </summary>
        /// <param name="message"></param>
        public static void Debug(string message)
        {
            Log.Debug(message);
        }
        /// <summary>
        /// Debug
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <param name="propertyValue"></param>
        public static void Debug<T>(string message, T propertyValue)
        {
            Log.Debug<T>(message, propertyValue);
        }

        /// <summary>
        /// Error
        /// </summary>
        /// <param name="message"></param>
        public static void Error(string message)
        {
            Log.Error(message);
        }

        /// <summary>
        /// Error
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <param name="propertyValue"></param>
        public static void Error<T>(string message, T propertyValue)
        {
            Log.Error<T>(message, propertyValue);
        }

        /// <summary>
        /// Fatal
        /// </summary>
        /// <param name="message"></param>
        public static void Fatal(string message)
        {
            Log.Fatal(message);
        }

        /// <summary>
        /// Fatal
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <param name="propertyValue"></param>
        public static void Fatal<T>(string message, T propertyValue)
        {
            Log.Fatal<T>(message, propertyValue);
        }

        /// <summary>
        /// Information
        /// </summary>
        /// <param name="message"></param>
        public static void Information(string message)
        {
            Log.Information(message);
        }

        /// <summary>
        /// Information
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <param name="propertyValue"></param>
        public static void Information<T>(string message, T propertyValue)
        {
            Log.Information<T>(message, propertyValue);
        }

        /// <summary>
        /// Warning
        /// </summary>
        /// <param name="message"></param>
        public static void Warning(string message)
        {
            Log.Warning(message);
        }

        /// <summary>
        /// Warning
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <param name="propertyValue"></param>
        public static void Warning<T>(string message, T propertyValue)
        {
            Log.Warning<T>(message, propertyValue);
        }
    }
}
