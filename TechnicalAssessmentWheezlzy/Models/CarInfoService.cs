namespace TechnicalAssessmentWheezlzy.Models
{
    public class CarInfoService
    {

        private readonly CarInfoContext _context;

        public CarInfoService(CarInfoContext context)
        {
            _context = context;
        }



        public IQueryable<CarDetailsDto> GetCarDetails()
        {
            return _context.Cars
                .Select(c => new CarDetailsDto
                {
                    CarId = c.CarId,
                    CarName = c.CarName,
                    BuyerName = c.Buyer.BuyerName,
                    QuoteAmount = c.Quote.QuoteAmount,
                    StatusName = c.Status.StatusName,
                    StatusDate = c.StatusDate.StatusDate
                });
        }
    }
}
