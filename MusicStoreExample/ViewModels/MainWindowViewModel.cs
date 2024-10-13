using ReactiveUI;
using System.Windows.Input;

namespace MusicStoreExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand BuyMusicCommand { get; }

        public MainWindowViewModel()
        {
            BuyMusicCommand = ReactiveCommand.Create(() =>
            {

            });
        }
    }
}
