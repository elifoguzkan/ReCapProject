using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IIdService
    {
        List<Id> GetById();
    }
}
