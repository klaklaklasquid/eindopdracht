
using Eindopdracht.Logic;
using Eindopdracht.Presentation.Windows;
using Eindopdracht.Presentation.Windows.Gegevensinitialisatie;

namespace Eindopdracht.Presentation {
    public class EindopdrachtApplication {
        private readonly DomainManager _domainManager;
        private readonly InitialisatieGegevens initialisatieGegevens;

        public EindopdrachtApplication(DomainManager domainManager) {
            _domainManager = domainManager;

            // Start de applicatie met het initialisatie venster
            initialisatieGegevens = new InitialisatieGegevens();
            initialisatieGegevens.Show();
        }
    }

}
