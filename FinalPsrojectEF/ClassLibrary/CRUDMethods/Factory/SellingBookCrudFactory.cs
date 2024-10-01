using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.CRUDMethods.SellingCRUD;

namespace ClassLibrary.CRUDMethods.Factory
{
    public class SellingBookCrudFactory : ICrudFactory
    {
        public ICreate Create() => new SellingBookCreate();
        public IReed Read() => new SellingBookReed();
        public IUpdate Update() => new SellingBookUpdate();
        public IDelete Delete() => new SellingBookDelete();
    }
}
