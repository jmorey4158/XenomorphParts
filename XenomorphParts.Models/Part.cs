using System;
using System.Collections.Generic;
using System.Text;
using XenomorphParts.Interfaces.Model;

namespace XenomorphParts.Models
{
    public class Part : IPart
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _desc;
        public string Description
        {
            get { return _desc; }
            set { _desc = value; }
        }

        private decimal _wholePrice;
        public decimal WholesalePrice
        {
            get { return _wholePrice; }
            set { _wholePrice = value; }
        }

        private decimal _retailPrice;
        public decimal RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }

        private IEntity _manufacturer;
        public IEntity Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

        private IVehicleModel _model;
        public IVehicleModel VehicleModel
        {
            get { return _model; }
            set { _model = value; }
        }

        private int _year;
        public int ModelYear
        {
            get { return _year; }
            set { _year = value; }
        }

        private int _reserved;
        public int Reserved
        {
            get { return _reserved; }
            set { _reserved = value; }
        }

        private int _available;
        public int Available
        {
            get { return _available; }
            set { _available = value; }
        }

        private int _locAvailable;
        public int LocatorAvailable
        {
            get { return _locAvailable; }
            set { _locAvailable = value; }
        }

    }
}
