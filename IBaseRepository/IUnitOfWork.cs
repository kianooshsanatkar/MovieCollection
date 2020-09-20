using System;

namespace MovieCollection.DataAccess.IBaseRepository
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}
