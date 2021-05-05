using EmbeddedSystemsApi.Context;
using EmbeddedSystemsApi.Entities;
using System.Threading.Tasks;

namespace EmbeddedSystemsApi.Repositories
{
    public class TemperatureRepository : ITemperatureRepository
    {
        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        /// <value>
        /// The context.
        /// </value>
        private ApplicationContext context { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public TemperatureRepository(ApplicationContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Creates the specified temperature.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <returns></returns>
        public async Task<Temperature> Create(Temperature temperature)
        {
            this.context.Add(temperature);

            await this.context.SaveChangesAsync();

            return temperature;
        }

        /// <summary>
        /// Reads the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<Temperature> Read(int id)
        {
            Temperature temperature = await this.context.Temperatures.FindAsync(id);

            return temperature;
        }
    }
}
