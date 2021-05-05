/*
 * Copyright (c) 2021 Víctor Vives - All rights reserved.
 * 
 * Licensed under the MIT License. 
 * See LICENSE file in the project root for full license information.
 */

using EmbeddedSystemsApi.Entities;

using Microsoft.EntityFrameworkCore;

namespace EmbeddedSystemsApi.Context
{
    /// <summary>
    /// The application context.
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the temperatures.
        /// </summary>
        /// <value>
        /// The temperatures.
        /// </value>
        public DbSet<Temperature> Temperatures { get; set; }

        /// <summary>
        /// Called when [model creating].
        /// </summary>
        /// <param name="builder">The model builder.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Temperature>().ToTable("Temperature");
        }
    }
}
