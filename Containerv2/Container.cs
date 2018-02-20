using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containerv2
{
    public class Container
    {
        private ContainerClass _containerClass;
        private ContainerType _containerType;
        private int _containerPosition;
        private int _containerNumber;
        private string _colour;
        private string _serialno;
        private DateTime _dateArrived;
        private decimal _price;
        private bool _isEmpty;
        private string _hiree;

        public Container(int pos)
        {
            
            _containerType = ContainerType.NONE;
            _containerClass = ContainerClass.Empty;
            _isEmpty = true;
            _containerPosition = pos;
            _dateArrived = DateTime.Now;
        }

        public ContainerClass ContainerClass
        {
            get { return _containerClass; }

            set
            {
                _containerClass = value;
            }
        }

        public ContainerType ContainerType { get { return _containerType; } set { _containerType = value; } }

        public int ContainerPos { get { return _containerPosition; } set { _containerPosition = value; } }

        public int ContainerNum { get { return _containerNumber; } set { _containerNumber = value; } }

        public string ContainerColour { get { return _colour; } set { _colour = value; } }

        public string ContainerSerial { get { return _serialno; } set { _serialno = value; } }

        public DateTime ArrivalTime { get { return _dateArrived; } set { _dateArrived = value; } }

        public decimal ContainerPrice { get { return _price; } set { _price = value; } }

        public bool ContainerEmpty { get { return _isEmpty; } set { _isEmpty = value; } }

        public string Hiree { get { return _hiree; } set { _hiree = value; } }

        public void emptyContainer()
        {
            _containerType = ContainerType.NONE;
            _containerClass = ContainerClass.Empty;
            _isEmpty = true;
            _dateArrived = DateTime.Now;
            _hiree = "";
            _colour = "";
            _containerNumber = 0;
            _price = 0;
            _serialno = "";
        }

        //Function used to populate random dates into container objects for demonstration.
        /*static readonly Random rnd = new Random();
        
        public static DateTime GetRandomDate(DateTime from, DateTime to)
        {
            var range = to - from;

            var randTimeSpan = new TimeSpan((long)(rnd.NextDouble() * range.Ticks));

            return from + randTimeSpan;
        }*/
    }
}
