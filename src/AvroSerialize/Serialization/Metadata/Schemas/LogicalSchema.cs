﻿namespace AvroSerialize.Serialization.Metadata.Schemas;

internal class LogicalSchema : UnnamedSchema
{
    public LogicalSchema(SchemaType tag)
        : base(tag)
    {
    }

    public Schema BaseSchema { get; set; }

    public string LogicalTypeName { get; set; }
}
