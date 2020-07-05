using DataAccess.Implementations;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationDbContext Context { get; }
        void Commit();

        IRepository<Concert> ConcertRepository { get; }
        IRepository<Singer> SingerRepository { get; }
        IRepository<Location> LocationRepository { get; }
        IRepository<ConcertSinger> ConcertSingerRepository { get; }


    }
}
