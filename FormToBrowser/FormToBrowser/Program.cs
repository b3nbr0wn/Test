using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FormToBrowser
    {
    static class Program
        {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            
            // force webbrowser out of compatibility mode
            string appName = "";
            int browserValue = 11000; // IE 11

            try
                {
                const string IE_EMULATION = @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
                
                appName = Path.GetFileName(Assembly.GetEntryAssembly().Location);
                using (var fbeKey = Registry.CurrentUser.OpenSubKey(IE_EMULATION, true))
                    fbeKey.SetValue(appName, browserValue, RegistryValueKind.DWord);

                appName.Replace(".exe", "vhost.exe");
                using (var fbeKey = Registry.CurrentUser.OpenSubKey(IE_EMULATION, true))
                    fbeKey.SetValue(appName, browserValue, RegistryValueKind.DWord);
                }

            catch (Exception ex)
                {
                MessageBox.Show(appName + "\n" + ex, "Unexpected error setting browser mode!");
                }

            

            Application.Run(new FormToBrowser());
            }
        }
    }
