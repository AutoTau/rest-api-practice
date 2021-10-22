using System;

namespace Catalog.Entities
{
    // Use record types for immutable objects
    // With-expressions support
    // Value-based equality support
    public record Item
    {
        // init allows for setting a value only on initialization
        public Guid Id { get; init; }

        public string Name { get; init; }

        public decimal Price { get; init; }

        public DateTimeOffset CreatedDate { get; init; }
    }


}