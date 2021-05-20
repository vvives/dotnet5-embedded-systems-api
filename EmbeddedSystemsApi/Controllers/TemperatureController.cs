/*
 * Copyright (c) 2021 Víctor Vives - All rights reserved.
 * 
 * Licensed under the MIT License. 
 * See LICENSE file in the project root for full license information.
 */

using System.Threading.Tasks;

using EmbeddedSystemsApi.Entities;
using EmbeddedSystemsApi.Envelopes;
using EmbeddedSystemsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmbeddedSystemsApi.Controllers
{
    /// <summary>
    /// The temperature controller.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [ApiController]
    [Route("api/temperatures")]
    public class TemperatureController : ControllerBase
    {
        /// <summary>
        /// Gets or sets the temperature service.
        /// </summary>
        /// <value>
        /// The temperature service.
        /// </value>
        private ITemperatureService TemperatureService { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureController"/> class.
        /// </summary>
        /// <param name="temperatureService">The temperature service.</param>
        public TemperatureController(ITemperatureService temperatureService)
        {
            this.TemperatureService = temperatureService;
        }

        /// <summary>
        /// Reads the temperature with the specified identifier.
        /// </summary>
        /// <param name="id">The temperature identifier.</param>
        /// <returns>
        /// The temperature with the specified identifier.
        /// </returns>
        [Route("{id}")]
        [HttpGet]
        public async Task<ActionResult<Temperature>> Read(int id)
        {
            Temperature temperature = await this.TemperatureService.Read(id);

            if (temperature == null)
            {
                return NotFound();
            }

            return temperature;
        }

        /// <summary>
        /// Creates the specified temperature.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <returns>
        /// The created temperature.
        /// </returns>
        [Route("")]
        [HttpPost]
        public async Task<ActionResult<Temperature>> Create([FromBody] TemperatureRequest temperatureRequest)
        {
            Temperature temperature = new Temperature(temperatureRequest.Value);

            temperature = await this.TemperatureService.Create(temperature);

            return temperature;
        }
    }
}
