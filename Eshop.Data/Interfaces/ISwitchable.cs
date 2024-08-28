using System;
using System.Collections.Generic;
using System.Text;
using Eshop.Data.Enums;

namespace Eshop.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
