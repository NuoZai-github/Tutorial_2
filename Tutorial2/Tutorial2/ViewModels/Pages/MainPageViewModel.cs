using System.Windows.Input;
using Tutorial2.Models;
using Tutorial2.ViewModels;
using Prism.Commands;

namespace Tutorial2.ViewModels.Pages
{
    public class MainPageViewModel : BaseViewModel
    {
        public MyModel Model { get; set; }
        public string Message { get; set; }
        private int Counter { get; set; }

        public ICommand TestCommand { get; set; }

        public MainPageViewModel()
        {
            Message = "Click me.";
            Model = new();
            TestCommand = new DelegateCommand(Count);
        }

        private void Count()
        {
            Counter++;
            Message = $"Clicked {Counter}";
        }
    }
}