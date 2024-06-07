using CodeChallenge.Models;
using CodeChallenge.Repositories;
using Microsoft.Extensions.Logging;

namespace CodeChallenge.Services
{
    public class CompensationService : ICompensationService
    {
        private readonly ICompensationRepository _compensationRepository;
        private readonly ILogger<CompensationService> _logger;

        public CompensationService(ILogger<CompensationService> logger, ICompensationRepository compensationRepository)
        {
            _logger = logger;
            _compensationRepository = compensationRepository;
        }

        public Compensation Create(Compensation compensation)
        {
            if (compensation is not null)
            {
                _compensationRepository.Add(compensation);
                _compensationRepository.SaveAsync();
            }

            return compensation;
        }

        public Compensation GetById(string id)
        {
            return _compensationRepository.GetById(id);
        }
    }
}
