using System.Windows.Input;
using Tutorial2.Models;        
using Prism.Commands;         
using Tutorial2.ViewModels;     

namespace Tutorial2.ViewModels.Pages
{
    public class MainPageViewModel : BaseViewModel
    {
        private MyModel _model;
        public MyModel Model
        {
            get { return _model; }
            set { SetProperty(ref _model, value); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

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