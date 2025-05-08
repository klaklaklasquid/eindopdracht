using Eindopdracht.Logic.Repositories;

namespace Eindopdracht.Logic {
    public class DomainManager {
        private readonly ICarRepository _carRepository;
        private readonly IEstablishmentRepository _establishmentRepository;
        private readonly ICustomerRepository _customerRepository;

        public DomainManager(ICarRepository carRepository, IEstablishmentRepository establishmentRepository, ICustomerRepository customerRepository) {
            _carRepository = carRepository;
            _establishmentRepository = establishmentRepository;
            _customerRepository = customerRepository;
        }
    }
}
