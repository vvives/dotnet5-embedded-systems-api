/*
 * Copyright (c) 2021 Víctor Vives - All rights reserved.
 * 
 * Licensed under the MIT License. 
 * See LICENSE file in the project root for full license information.
 */

using System.Threading.Tasks;

using EmbeddedSystemsApi.Entities;

namespace EmbeddedSystemsApi.Repositories
{
    public interface ITemperatureRepository
    {
        /// <summary>
        /// Creates the specified temperature.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <returns>
        /// The created temperature.
        /// </returns>
        Task<Temperature> Create(Temperature temperature);

        /// <summary>
        /// Reads the temperature with the specified identifier.
        /// </summary>
        /// <param name="id">The temperature identifier.</param>
        /// <returns>
        /// The temperature with the specified identifier.
        /// </returns>
        Task<Temperature> Read(int id);
    }
}
