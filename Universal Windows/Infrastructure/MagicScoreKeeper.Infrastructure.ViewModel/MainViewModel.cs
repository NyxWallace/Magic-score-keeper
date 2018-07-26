using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicScoreKeeper.Infrastructure.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private PlayerViewModel _player1 = null;
        private PlayerViewModel _player2 = null;

        public PlayerViewModel Player1
        {
            get
            {
                if(_player1 == null)
                {
                    _player1 = new PlayerViewModel("Player 1");
                }
                return _player1;
            }
            set
            {
                if (_player1 == value) return;
                _player1 = value;
                RaisePropertyChanged(() => Player1);
            }
        }

        public PlayerViewModel Player2
        {
            get
            {
                if (_player2 == null)
                {
                    _player2 = new PlayerViewModel("Player 2");
                }
                return _player2;
            }
            set
            {
                if (_player2 == value) return;
                _player2 = value;
                RaisePropertyChanged(() => Player2);
            }
        }
    }
}
