using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataFormXamarin
{
    public class ContactsInfo : INotifyPropertyChanged
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string contactNo;
        private string email;
        private string address;
        private DateTime? birthDate;
        private string groupName;
        public ContactsInfo()
        {

        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
                this.RaisePropertyChanged("FirstName");
            }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                this.middleName = value;
                this.RaisePropertyChanged("MiddleName");
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
                this.RaisePropertyChanged("LastName");
            }
        }
        public string ContactNumber
        {
            get { return contactNo; }
            set
            {
                this.contactNo = value;
                this.RaisePropertyChanged("ContactNumber");
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                this.RaisePropertyChanged("Email");
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                this.RaisePropertyChanged("Address");
            }
        }
        public DateTime? BirthDate
        {
            get { return birthDate; }
            set
            {
                birthDate = value;
                this.RaisePropertyChanged("BirthDate");
            }
        }
        public string GroupName
        {
            get { return groupName; }
            set
            {
                groupName = value;
                this.RaisePropertyChanged("GroupName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }
    }
}
