using System.ComponentModel;
using WPF_Workshop_MVVM.Models;

namespace WPF_Workshop_MVVM.ViewModels
{
    public class StringViewModel : INotifyPropertyChanged
    {
        private StringModel model = new StringModel();
        private string _inputString;

        public string InputString
        {
            get => _inputString;
            set
            {
                if (_inputString != value)
                {
                    _inputString = value;
                    OnPropertyChanged(nameof(InputString));
                    // Automatically update output when input changes
                    OnPropertyChanged(nameof(OutputString));
                }
            }
        }

        public string OutputString => model.ToUpperCase(InputString);

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
