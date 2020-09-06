using Entities;
using System;

namespace DataAccess.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationDbContext Context { get; }
        void Commit();

        IRepository<Concert> ConcertRepository { get; }
        IRepository<ConcertView> ConcertViewRepository { get; }
        IRepository<Singer> SingerRepository { get; }
        IRepository<Location> LocationRepository { get; }
        IRepository<ConcertSinger> ConcertSingerRepository { get; }


    }
}
