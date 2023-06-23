using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoProgramm.Models
{
    class TodoModel : INotifyPropertyChanged
    {
        public string Creation { get; set; } = DateTime.Now.ToString("dd.MM HH:mm");

        private bool _isDone;

        private string _Task;



        public bool IsDone
        {
            get
            {
                return _isDone;
            }
            set
            {
                if (_isDone == value)
                    return;
                _isDone = value;
                OnPropertyChanged("IsDone");
            }
        }

        public string Task
        {
            get
            {
                return _Task;
            }
            set
            {
                if (_Task == value)
                    return;
                _Task = value;
                OnPropertyChanged("Task");
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
