namespace ForeignExchange.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Models;

    public class MainViewModel : INotifyPropertyChanged
    {

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion


        #region Attributes
        bool _isRunning;
        string _isResult;
        #endregion


        #region Properties
        public string Amount { get; set; }

        public ObservableCollection< Rate> Rates { get; set; }

        public Rate SourceRate { get; set; }

        public Rate TargetRate { get; set; }

        public bool IsRunning 
        { 
            get
            {
                return _isRunning; 
            }
            set
            {
                if (_isRunning != value)
                {
                    _isRunning = value;
                    PropertyChanged?.Invoke(
                    this,
                        new PropertyChangedEventArgs(nameof(IsRunning)));
                }
            }
        }

        public bool IsEnable { get; set; }

        public string Result
        {
            get
            {
                return _isResult;
            }
            set
            {
                if (_isResult != value)
                {
                    _isResult = value;
                    PropertyChanged?.Invoke(
                    this,
                        new PropertyChangedEventArgs(nameof(Result)));
                }
            }
        }
        #endregion


        #region Commands
        public ICommand ConvertCommand 
        { 
            get
            {
                return new RelayCommand(Convert);
            }
        }

        void Convert()
        {
            throw new NotImplementedException();
        }
        #endregion


        #region Constructor
        public MainViewModel()
        {
            LoadRates();
        }
        #endregion


        #region Methods
        void LoadRates()
        {
            IsRunning = true;
            Result = "Loading rates...";
        }
        #endregion
    }
}
