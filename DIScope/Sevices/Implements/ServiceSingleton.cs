using DIScope.Sevices.Interfaces;

namespace DIScope.Sevices.Implements
{
    public class ServiceSingleton : IServiceSingleton
    {
        public Guid Id { get; set; }
        private readonly ILogger<IServiceSingleton> _logger;

        public ServiceSingleton(ILogger<IServiceSingleton> logger)
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
