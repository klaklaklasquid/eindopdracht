
using Eindopdracht.Logic;
using Eindopdracht.Presentation.Windows;

namespace Eindopdracht.Presentation {
    public class EindopdrachtApplication {
        private readonly DomainManager _domainManager;
        private readonly TestWindow _testWindow;

        public EindopdrachtApplication(DomainManager domainManager) {
            _domainManager = domainManager;

            _testWindow = new TestWindow();
            _testWindow.Show();
        }
    }

}
