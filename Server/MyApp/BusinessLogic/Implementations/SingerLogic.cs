using BusinessLogic.Abstractions;
using DataAccess.Abstractions;

namespace BusinessLogic.Implementations
{
    public class SingerLogic : BaseLogic, ISingerLogic
    {

        public SingerLogic(IRepository repository)
     : base(repository)
        {
        }

 
    }
}
