using System;
using System.Collections.Generic;
using System.Text;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.DTO
{
    public class AssemblyDto : IAssemblyDto
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

        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        private string _manu;
        public string ManufacturerId
        {
            get { return _manu; }
            set { _manu = value; }
        }

        private long _model;
        public long ModelId
        {
            get { return _model; }
            set { _model = value; }
        }


        private IEnumerable<IPartDto> _components;
        public IEnumerable<IPartDto> Components
        {
            get { return _components; }
            set { _components = value; }
        }

        private IEnumerable<long> _subs;
        public IEnumerable<long> SubAssemblies
        {
            get { return _subs; }
            set { _subs = value; }
        }

        private long _parent;
        public long Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

    }
}
