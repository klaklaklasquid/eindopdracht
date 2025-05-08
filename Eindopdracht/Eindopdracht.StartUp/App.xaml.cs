using Eindopdracht.Database.Mappers;
using Eindopdracht.Logic;
using Eindopdracht.Logic.Repositories;
using Eindopdracht.Presentation;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Eindopdracht.StartUp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application {
    private void Application_Startup(object sender, StartupEventArgs e) {
        // database initialisatie
        ICarRepository carRepository = new CarMapper();
        IEstablishmentRepository establishmentRepository = new EstablishmentMapper();
        ICustomerRepository customerRepository = new CustomerMapper();

        // domain manager initialisatie
        DomainManager domainManager = new DomainManager(carRepository, establishmentRepository, customerRepository);

        // presentatie initialisatie
        _ = new EindopdrachtApplication(domainManager);
    }
}

