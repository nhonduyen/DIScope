using DIScope.Sevices.Interfaces;
using IServiceScope = DIScope.Sevices.Interfaces.IServiceScope;

namespace DIScope.Sevices.Implements
{
    public class ServiceScope : IServiceScope
    {
        public Guid Id { get; set; }
        private readonly ILogger<IServiceScope> _logger;

        public ServiceScope(ILogger<IServiceScope> logger)
        {
            Id = Guid.NewGuid();
            _logger = logger;
        }
        public void ShowId()
        {
            _logger.LogInformation($"{nameof(ServiceScope)} : {Id}");
        }

        public Guid GetId()
        {
            return Id;
        }
    }
}
