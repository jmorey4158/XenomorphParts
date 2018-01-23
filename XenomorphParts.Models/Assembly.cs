using System;
using System.Collections.Generic;
using System.Text;
using XenomorphParts.Interfaces.Model;

namespace XenomorphParts.Models
{
    public class Assembly : IAssembly
    {

        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private IEntity _manu;
        public IEntity Manufacturer
        {
            get { return _manu; }
            set { _manu = value; }
        }

        private IEnumerable<IPart> _components;
        public IEnumerable<IPart> Components
        {
            get { return _components; }
            set { _components = value; }
        }

        private IEnumerable<IAssembly> _suAssemblies;
        public IEnumerable<IAssembly> SubAssemblies
        {
            get { return _suAssemblies; }
            set { _suAssemblies = value; }
        }

    }
}
