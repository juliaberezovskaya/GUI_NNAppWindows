using Catel.IoC;
using Catel.Services;
using GUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                var service = (IUIVisualizerService)(TypeFactory.Default.GetServiceLocator().GetService(typeof(IUIVisualizerService)));
//                DataContext = TypeFactory.Default.CreateInstance<MainViewModel>();
                DataContext = new MainViewModel(service);
            }
            catch { }
        }
    }
}
