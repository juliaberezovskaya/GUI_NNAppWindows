using Catel.IoC;
using Catel.Logging;
using Catel.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {

        }

        protected override void OnLoadCompleted(NavigationEventArgs e)
        {
            base.OnLoadCompleted(e);
        }

        private void Application_Activated(object sender, EventArgs e)
        {
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
#if DEBUG
            LogManager.AddDebugListener();
#endif
            // тут создаётся нс и окна
            //var service = TypeFactory.Default.GetServiceLocator().GetService(typeof(IUIVisualizerService));
            //MainWindow = new MainWindow();
        }
    }
}
