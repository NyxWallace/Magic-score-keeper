using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_the_gathering.Model
{
    public class Player : ViewModelBase
    {
        private string _name;
        private int _hp;
        private int _poisonCounter;

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                    _name = "Player";
                return _name;
            }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        public int HP
        {
            get
            {
                return _hp;
            }
            set
            {
                _hp = value;
                RaisePropertyChanged("HP");
            }
        }

        public int PoisonCounter
        {
            get
            {
                return _poisonCounter;
            }
            set
            {
                _poisonCounter = value;
                RaisePropertyChanged("PoisonCounter");
            }
        }

        public Player(string name)
        {
            this._name = name;
            RaisePropertyChanged(() => Name);
        }
    }
}
