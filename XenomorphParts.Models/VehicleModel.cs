using System;
using System.Collections.Generic;
using System.Text;
using XenomorphParts.Interfaces.Model;

namespace XenomorphParts.Models
{
    public class VehicleModel : IVehicleModel
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

        private IEntity _manu;
        public IEntity Manufacturer
        {
            get { return _manu; }
            set { _manu = value; }
        }

        private int _beginYear;
        public int BeginYear
        {
            get { return _beginYear; }
            set { _beginYear = value; }
        }

        private int _endYear;
        public int EndYear
        {
            get { return _endYear; }
            set { _endYear = value; }
        }

        private IAssembly _assembly;
        public IAssembly Assembly
        {
            get { return _assembly; }
            set { _assembly = value; }
        }
    }
}
