namespace CarRentingSystem.Services.Statistics
{
    using System.Linq;
    using CarRentingSystem.Data;

    public class StatisticsService : IStatisticsService
    {
        private readonly SupercarDbContext data;

        public StatisticsService(SupercarDbContext data)
            => this.data = data;

        public StatisticsServiceModel Total()
        {
            var totalCars = this.data.Cars.Count(c => c.IsPublic);
            var totalUsers = this.data.Users.Count();

            return new StatisticsServiceModel
            {
                TotalCars = totalCars,
                TotalUsers = totalUsers
            };
        }
    }
}
