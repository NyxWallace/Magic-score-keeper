using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MagicScoreKeeper.Infrastructure.ViewModel
{
    public class PlayerViewModel : ViewModelBase
    {
        private int _hp = 20;
        private int _poison = 0;
        private string _name = string.Empty;
        private RelayCommand<int> _increaseHPCommand = null;
        private RelayCommand<int> _increasePoisonCommand = null;

        public int HP
        {
            get
            {
                return _hp;
            }
            set
            {
                if (_hp == value) return;
                _hp = value;
                RaisePropertyChanged(() => HP);
            }
        }

        public int Poison
        {
            get
            {
                return _poison;
            }
            set
            {
                if (_poison == value) return;
                _poison = value;
                RaisePropertyChanged(() => Poison);
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name == value) return;
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }

        public ICommand IncreaseHPCommand
        {
            get
            {
                return _increaseHPCommand ?? (_increaseHPCommand = new RelayCommand<int>((val) =>
                {
                    HP += val;
                }));
            }
        }

        public ICommand IncreasePoisonCommand
        {
            get
            {
                return _increasePoisonCommand ?? (_increasePoisonCommand = new RelayCommand<int>((val) =>
                {
                    Poison += val;
                }));
            }
        }

        public PlayerViewModel() { }

        public PlayerViewModel(string name) : this()
        {
            _name = name;
        }
    }
}
