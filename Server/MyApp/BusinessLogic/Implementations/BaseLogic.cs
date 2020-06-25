using DataAccess.Abstractions;

namespace BusinessLogic.Implementations
{
    public class BaseLogic
    {
        protected readonly IUnitOfWork _unitOfWork;

        public BaseLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
