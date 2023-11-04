using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PNumG
{
    public class MainWindowViewModel : SharedWPF.ViewModelBase
    {
        #region == CurrentNumber ==

        private BigInteger _CurrentNumber;
        public BigInteger CurrentNumber
        {
            get => _CurrentNumber;
            set
            {
                if (_CurrentNumber != value)
                {
                    _CurrentNumber = value;
                    RaisePropertyChanged(nameof(CurrentNumber));
                }
            }
        }

        #endregion

        #region == SepalationNumber ==

        private BigInteger _SepalationNumber;
        public BigInteger SepalationNumber
        {
            get => _SepalationNumber;
            set
            {
                if (_SepalationNumber != value)
                {
                    _SepalationNumber = value;
                    RaisePropertyChanged(nameof(SepalationNumber));
                }
            }
        }

        #endregion

        public MainWindowViewModel()
        {
            CurrentNumber = new BigInteger(0);
            SepalationNumber = new BigInteger(0);
        }
    }
}
