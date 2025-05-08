using Eindopdracht.Logic.Repositories;

namespace Eindopdracht.Logic {
    public class DomainManager {
        private readonly ICarRepository _carRepository;

        public DomainManager(ICarRepository carRepository) {
            _carRepository = carRepository;
        }
    }
}
