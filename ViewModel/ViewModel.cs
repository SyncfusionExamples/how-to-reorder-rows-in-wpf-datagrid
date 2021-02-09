using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SfDataGridDemo
{
    public class UserInfoViewModel : INotifyPropertyChanged, IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public UserInfoViewModel()
        {
            UserDetails = new UserInfoRepository().GetUserDetails(10);

            UserDetails1 = new UserInfoRepository().GetUserDetails1(10);
        }

        private ObservableCollection<UserInfo> userDetails;
        public ObservableCollection<UserInfo> UserDetails
        {
            get { return userDetails; }
            set { userDetails = value; RaisePropertyChanged("UserDetails"); }
        }

        public void Dispose()
        {
            if (UserDetails != null)
                UserDetails.Clear();
        }

        private ObservableCollection<UserInfo> userDetails1;
        public ObservableCollection<UserInfo> UserDetails1
        {
            get { return userDetails1; }
            set { userDetails1 = value; RaisePropertyChanged("UserDetails1"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
