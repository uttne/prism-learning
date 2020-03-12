using System.Collections.Generic;
using Prism.Mvvm;

namespace Module.ViewModels
{
    public class View1ViewModel:BindableBase
    {
        public View1ViewModel()
        {
        }
        public string Text { get; set; } = "Sample text";
    }
}