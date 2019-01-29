using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace project0
{
    public class UserButton: INotifyPropertyChanged
    {

        public const bool DEBUG = true;

        #region instance variables
        private int power = 0;

        #endregion

        #region attributes

        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
                RaisePropertyChanged(new PropertyChangedEventArgs("Power"));
            }
        }

        #endregion


        #region Methods
        public void processClick()
        {
            if (DEBUG) { Console.Write("[ProcessClick]\n"); }
            //TODO: Enter Code Here
            this.incrementPower();
        }

        public void incrementPower()
        {
            this.power++;
            RaisePropertyChanged(new PropertyChangedEventArgs("Power"));
            if (DEBUG) { Console.Write("[incrementPower]Power Incremented to:" + power + "\n"); }
        }

        #endregion

        #region Events

        /*
         * the PropertyChanged event is part of the implementation of
         * INotifyPropertyChanged (remember, interfaces start with I, this is an interface)
         * This will let us trigger an event whenever a property, in this case Count, is updated
         */

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(PropertyChangedEventArgs e)
        {
            // Most events have a similar structure, they have a "sender", and some
            // type of event args
            PropertyChanged?.Invoke(this, e);
            if (DEBUG) { Console.Write("[Property Changed]\n"); }
        }
        #endregion


    }

}
