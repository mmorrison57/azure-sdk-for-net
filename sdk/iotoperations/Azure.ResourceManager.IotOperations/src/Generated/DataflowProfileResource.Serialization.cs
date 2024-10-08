// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.IoTOperations
{
    public partial class DataflowProfileResource : IJsonModel<DataflowProfileResourceData>
    {
        void IJsonModel<DataflowProfileResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DataflowProfileResourceData>)Data).Write(writer, options);

        DataflowProfileResourceData IJsonModel<DataflowProfileResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DataflowProfileResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DataflowProfileResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DataflowProfileResourceData IPersistableModel<DataflowProfileResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DataflowProfileResourceData>(data, options);

        string IPersistableModel<DataflowProfileResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DataflowProfileResourceData>)Data).GetFormatFromOptions(options);
    }
}
