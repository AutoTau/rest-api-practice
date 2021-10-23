using System;

namespace Catalog.Dtos
{
    // Use record types for immutable objects
    // With-expressions support
    // Value-based equality support
    // This is our Item data transfer object
    public record ItemDto
    {
        // init allows for setting a value only on initialization
        public Guid Id { get; init; }

        public string Name { get; init; }

        public decimal Price { get; init; }

        public DateTimeOffset CreatedDate { get; init; }
    }

}