using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.CRUDMethods.GenreCRUD;

namespace ClassLibrary.CRUDMethods.Factory
{
    public class GenreCrudFactory : ICrudFactory
    {
        public ICreate Create() => new GenreCreate();
        public IReed Read() => new GenreReed();
        public IUpdate Update() => new GenreUpdate();
        public IDelete Delete() => new GenreDelete();
    }
}
