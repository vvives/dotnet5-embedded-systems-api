/*
 * Copyright (c) 2021 Víctor Vives - All rights reserved.
 * 
 * Licensed under the MIT License. 
 * See LICENSE file in the project root for full license information.
 */

using System.Threading.Tasks;

using EmbeddedSystemsApi.Entities;
using EmbeddedSystemsApi.Repositories;

namespace EmbeddedSystemsApi.Services
{
    /// <summary>
    /// The temperature service.
    /// </summary>
    /// <seealso cref="EmbeddedSystemsApi.Services.ITemperatureService" />
    public class TemperatureService : ITemperatureService
    {
        /// <summary>
        /// Gets or sets the temperature repository.
        /// </summary>
        /// <value>
        /// The temperature repository.
        /// </value>
        private ITemperatureRepository TemperatureRepository { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureService"/> class.
        /// </summary>
        /// <param name="temperatureRepository">The temperature repository.</param>
        public TemperatureService(ITemperatureRepository temperatureRepository)
        {
            this.TemperatureRepository = temperatureRepository;
        }

        /// <summary>
        /// Creates the specified temperature.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <returns>
        /// The created temperature.
        /// </returns>
        public async Task<Temperature> Create(Temperature temperature)
        {
            return await this.TemperatureRepository.Create(temperature);
        }

        /// <summary>
        /// Reads the temperature with the specified identifier.
        /// </summary>
        /// <param name="id">The temperature identifier.</param>
        /// <returns>
        /// The temperature with the specified identifier.
        /// </returns>
        public async Task<Temperature> Read(int id)
        {
            return await this.TemperatureRepository.Read(id);
        }
    }
}
