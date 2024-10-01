using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.CRUDMethods.PublishingCRUD;

namespace ClassLibrary.CRUDMethods.Factory
{
    public class PublishingCrudFactory : ICrudFactory
    {
        public ICreate Create() => new PublishingCreate();
        public IReed Read() => new PublishingReed();
        public IUpdate Update() => new PublishingUpdate();
        public IDelete Delete() => new PublishingDelete();
    }
}

