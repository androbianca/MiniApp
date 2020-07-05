using DataAccess.Abstractions;
using Entities;

namespace DataAccess.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationDbContext Context { get; }
        private IRepository<Concert> concertRepository;
        private IRepository<Singer> singerRepository;
        private IRepository<Location> locationRepository;
        private IRepository<ConcertSinger> concertSingerRepository;


        public IRepository<Concert> ConcertRepository
        {
            get
            {

                if (concertRepository == null)
                {
                    concertRepository =  new Repository<Concert>(Context);
                }
                return concertRepository;
            }
        }

        public IRepository<Singer> SingerRepository
        {
            get
            {

                if (singerRepository == null)
                {
                    singerRepository = new Repository<Singer>(Context);
                }
                return singerRepository;
            }
        }
        public IRepository<Location> LocationRepository
        {
            get
            {

                if (locationRepository == null)
                {
                    locationRepository = new Repository<Location>(Context);
                }
                return locationRepository;
            }
        }

        public IRepository<ConcertSinger> ConcertSingerRepository
        {
            get
            {

                if (concertSingerRepository == null)
                {
                    concertSingerRepository = new Repository<ConcertSinger>(Context);
                }
                return concertSingerRepository;
            }
        }


        public UnitOfWork(ApplicationDbContext context)
        {
            Context = context;
        }
        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();

        }
    }
}
