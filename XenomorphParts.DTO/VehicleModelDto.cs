using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.DTO;


namespace XenomorphParts.DTO
{
    public class VehicleModelDto : IVehicleModelDto
    {
        private long _Id;
        public long Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private long _manufacturerId;
        public long ManufacturerId
        {
            get { return _manufacturerId; }
            set { _manufacturerId = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
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
    }
}
