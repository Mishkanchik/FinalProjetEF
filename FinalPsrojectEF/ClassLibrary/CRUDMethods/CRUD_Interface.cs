using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.CRUDMethods;

namespace ClassLibrary.CRUDMethods
{

    public interface ICreate
    {
        void Create();
    }

    public interface IReed
    {
        void Read();
    }

    public interface IUpdate
    {
        void Update();
    }

    public interface IDelete
    {
        void Delete();
    }

    public interface ICrudFactory
    {
        ICreate Create();
        IReed Read();
        IUpdate Update();
        IDelete Delete();
    }
}


