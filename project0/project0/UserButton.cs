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
        private const int maxPower = 12;

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

        /// <summary>
        /// Checks if power is at max level
        /// </summary>
        /// <returns>true or false</returns>
        public bool isMax()
        {
            return power >= maxPower;
        }

        #region Methods
        /// <summary>
        /// Processes the events when the button is clicked
        /// </summary>
        public void processClick()
        {
            if (DEBUG) { Console.Write("[ProcessClick]\n"); }
            //TODO: Enter Code Here
            this.incrementPower();
        }

        /// <summary>
        /// increment power by 1
        /// </summary>
        public void incrementPower()
        {
            this.power++;
            RaisePropertyChanged(new PropertyChangedEventArgs("Power"));
            if (DEBUG) { Console.Write("[incrementPower]Power Incremented to:" + power + "\n"); }
        }

        #endregion

        #region Events

        /// <summary>
        /// notifies listeners/observers of a property change
        /// </summary>
        /// <param name="e"></param>
        /// 
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
