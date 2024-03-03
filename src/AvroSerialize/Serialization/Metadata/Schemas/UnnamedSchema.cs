﻿namespace AvroSerialize.Serialization.Metadata.Schemas;

public abstract class UnnamedSchema : Schema
{
    protected UnnamedSchema(SchemaType tag)
        : base(tag)
    {
    }

    public override string Name => Tag.ToString().ToLowerInvariant();
}