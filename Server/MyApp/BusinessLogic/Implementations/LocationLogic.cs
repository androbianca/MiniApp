using BusinessLogic.Abstractions;
using DataAccess.Abstractions;

namespace BusinessLogic.Implementations
{
    public class LocationLogic : BaseLogic, ILocationLogic
    {

        public LocationLogic(IRepository repository)
     : base(repository)
        {
        }
    }
}
