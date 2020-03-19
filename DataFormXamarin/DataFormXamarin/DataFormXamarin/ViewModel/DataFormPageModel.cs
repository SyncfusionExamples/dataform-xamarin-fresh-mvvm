using DataFormXamarin;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFormXamarin
{
    public class DataFormPageModel : FreshBasePageModel
    {
        private ContactsInfo contactsInfo;
        public ContactsInfo ContactsInfo
        {
            get { return this.contactsInfo; }
            set
            {
                this.contactsInfo = value;
                this.RaisePropertyChanged("ContactsInfo");
            }
        }

        public DataFormPageModel()
        {
            this.contactsInfo = new ContactsInfo();
        }
    }
}
