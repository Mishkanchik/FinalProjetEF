using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.CRUDMethods.CostBookCRUD;

namespace ClassLibrary.CRUDMethods.Factory
{
    public class CostBookCrudFactory : ICrudFactory
    {
        public ICreate Create() => new CostBookCreate();
        public IReed Read() => new CostBookReed();
        public IUpdate Update() => new CostBookUpdate();
        public IDelete Delete() => new CostBookDelete();
    }
}
