using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpf_example.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private string _name;
        private int _age;
        private string _output;

        public PersonViewModel()
        {
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertyChanged("Age");
                }
            }
        }

        public string Output
        {
            get { return _output; }
            set
            {
                if (_output != value)
                {
                    _output = value;
                    OnPropertyChanged("Output");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand SubmitCommand
        {
            get
            {
                return new RelayCommand(Submit);
            }
        }

        private void Submit()
        {
            Output = $"{Age}살 {Name}님 반갑습니다!";
        }
    }
    public class RelayCommand : ICommand
    {
        private Action _execute;
        public RelayCommand(Action execute) => _execute = execute;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => _execute.Invoke();
    }
}

