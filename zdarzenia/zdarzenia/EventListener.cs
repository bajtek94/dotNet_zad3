using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zdarzenia
{
    class EventListener
    {
        private MyArray myArray;
        public EventListener(MyArray myArray)
        {
            this.myArray = myArray;
            myArray.Changed += new EventHandler(ListChanged);
        }
        private void ListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("This is called when the event fires.");
        }
        public void Detach()
        {
            myArray.Changed -= new EventHandler(ListChanged);
            myArray = null;
        }
    }
}
