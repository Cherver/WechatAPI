﻿using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System.Text.Json.Converters
{
    public class CommonDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        private readonly JsonConverter<DateTimeOffset?> _converter = new CommonNullableDateTimeOffsetConverter();

        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return _converter.Read(ref reader, typeToConvert, options) ?? default;
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            _converter.Write(writer, value, options);
        }
    }
}
