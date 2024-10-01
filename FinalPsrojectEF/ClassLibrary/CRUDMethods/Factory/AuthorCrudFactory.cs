using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.CRUDMethods.AutorCRUD;

namespace ClassLibrary.CRUDMethods.Factory
{
    public class AuthorCrudFactory : ICrudFactory
    {
        public ICreate Create() => new AuthorCreate();
        public IReed Read() => new AuthorReed();
        public IUpdate Update() => new AuthorUpdate();
        public IDelete Delete() => new AuthorDelete();
    }
}
