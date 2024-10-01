using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.CRUDMethods.BookCRUD;

namespace ClassLibrary.CRUDMethods.Factory
{
    public class BookCrudFactory : ICrudFactory
    {
        public ICreate Create() => new BookCreate();
        public IReed Read() => new BookReed();
        public IUpdate Update() => new BookUpdate();
        public IDelete Delete() => new BookDelete();
    }
}

