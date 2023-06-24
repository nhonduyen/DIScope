using DIScope.Sevices.Interfaces;

namespace DIScope.Sevices.Implements
{
    public class ServiceTransient : IServiceTransient
    {
        public Guid Id { get; set; }
        private readonly ILogger<IServiceTransient> _logger;

        public ServiceTransient(ILogger<IServiceTransient> logger)
        {
            Id = Guid.NewGuid();
            _logger = logger;
        }
        public void ShowId()
        {
            _logger.LogInformation($"{nameof(ServiceTransient)} : {Id}");
        }

        public Guid GetId()
        {
            return Id;
        }
    }
}
