using GalaSoft.MvvmLight;
using Magic_the_gathering.Model;
using System.Collections.ObjectModel;

namespace Magic_the_gathering.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Player> _playerList;

        public ObservableCollection<Player> PlayerList
        {
            get
            {
                if (_playerList == null)
                    _playerList = new ObservableCollection<Player>();
                return _playerList;
            }
            set
            {
                if (_playerList != value)
                    _playerList = value;
                RaisePropertyChanged("PlayerList");
            }
        }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            PlayerList.Add(new Player("Player 1"));
            PlayerList.Add(new Player("Player 2"));
            RaisePropertyChanged(() => PlayerList);

            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }
    }
}