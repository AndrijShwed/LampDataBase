using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampDataBase
{
    public class Lamp
    {
        public object numb { get; set; }
        public object village { get; set; }
        public object street { get; set; }
        public object supportNumb { get; set; }
        public object produce { get; set; }
        public object date {get; set; }
        public object dateOfPurchase {get; set; }
        public object warranty {get; set; }
        public object status {get; set; }
       

        public Lamp(object _id, object _village, object _street, object _supportNumb, object _produce,
            object _warranty, object _date, object _dateOfPurchase,  object _status)
        {
            numb = _id;
            village = _village;
            street = _street;
            supportNumb = _supportNumb;
            produce = _produce;
            date = _date;
            dateOfPurchase = _dateOfPurchase;
            warranty = _warranty;
            status = _status;
        }
    }
}
