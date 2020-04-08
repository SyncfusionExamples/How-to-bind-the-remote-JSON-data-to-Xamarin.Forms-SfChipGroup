using Syncfusion.XForms.Buttons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleSample
{
    public class Model
    {
        public double OrderID { get; set; }

        public string CustomerID { get; set; }

        public int EmployeeID { get; set; }

        public double Freight { get; set; }

        public string ShipCity { get; set; }

        public bool Verified { get; set; }

        public string OrderDate { get; set; }

        public string ShipName { get; set; }

        public string ShipCountry { get; set; }

        public string ShippedDate { get; set; }

        public string ShipAddress { get; set; }

    }
}
