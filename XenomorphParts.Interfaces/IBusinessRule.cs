using System;
using System.Collections.Generic;
using System.Text;
using XenomorphParts.Common.Enums;

namespace XenomorphParts.Interfaces
{
    public interface IBusinessRule
    {
        long Id { get; }
        IBusinessRule Group { get; }
        string Name { get; }

    }
}
