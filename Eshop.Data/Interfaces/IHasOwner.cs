using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }


    }
}
