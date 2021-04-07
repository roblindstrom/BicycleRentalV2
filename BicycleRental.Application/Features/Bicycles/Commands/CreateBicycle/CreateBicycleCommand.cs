using MediatR;

namespace BicycleRental.Application.Features.Bicycles.Commands.CreateBicycle
{
    public class CreateBicycleCommand : IRequest<CreateBicycleCommandResponse>
    {
        public double BicycleID { get; set; }

        public double PricePerDay { get; set; }


        // public BicycleBrand BicycleBrand { get; set; }

        // public BicycleSize BicycleSize { get; set; }


        


        //Returnerar detta meddelandet när Biycle skapas
        public override string ToString()
        {
            return $"BicycleID: {BicycleID}; PricePerDay: {PricePerDay};  ";
        }
    }
}
