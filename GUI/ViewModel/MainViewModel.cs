using Catel.MVVM;
using Catel.Services;
using System.Threading.Tasks;

namespace GUI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
       IUIVisualizerService _visualizerService;

        public MainViewModel(IUIVisualizerService uIVisualizerService)
        {
            _visualizerService = uIVisualizerService;
        }

        public override string Title { get { return "View model title"; } }

        // TODO: Register models with the vmpropmodel codesnippet
        // TODO: Register view model properties with the vmprop or vmpropviewmodeltomodel codesnippets
        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: subscribe to events here
        }

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }
    }

}
