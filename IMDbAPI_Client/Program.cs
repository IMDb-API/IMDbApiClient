using System;
using System.Net;
using System.Windows.Forms;

namespace IMDbAPI_Client
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static WebProxy GetWebProxy()
        {
            if (!Properties.Settings.Default.UseProxy)
                return null;

            var webProxy = new WebProxy();
            webProxy.Address = new Uri(Properties.Settings.Default.ProxyServer);
            webProxy.Credentials = new NetworkCredential(
                Properties.Settings.Default.ProxyUsername,
                Properties.Settings.Default.ProxyPassword);
            webProxy.UseDefaultCredentials = false;
            webProxy.BypassProxyOnLocal = false;

            return webProxy;
        }
    }
}
