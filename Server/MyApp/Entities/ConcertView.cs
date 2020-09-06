
namespace Entities
{
   public class ConcertView: BaseEntity
    {
        public string ConcertName { get; set; }
        public long Price { get; set; }
        public string LocationName { get; set; }
        public string SingerName { get; set; }
    }
}
