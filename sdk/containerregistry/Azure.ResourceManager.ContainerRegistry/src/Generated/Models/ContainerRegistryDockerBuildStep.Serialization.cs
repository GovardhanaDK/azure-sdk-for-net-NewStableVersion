// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryDockerBuildStep : IUtf8JsonSerializable, IJsonModel<ContainerRegistryDockerBuildStep>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryDockerBuildStep>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerRegistryDockerBuildStep>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildStep)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(ImageNames))
            {
                writer.WritePropertyName("imageNames"u8);
                writer.WriteStartArray();
                foreach (var item in ImageNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsPushEnabled))
            {
                writer.WritePropertyName("isPushEnabled"u8);
                writer.WriteBooleanValue(IsPushEnabled.Value);
            }
            if (Optional.IsDefined(NoCache))
            {
                writer.WritePropertyName("noCache"u8);
                writer.WriteBooleanValue(NoCache.Value);
            }
            writer.WritePropertyName("dockerFilePath"u8);
            writer.WriteStringValue(DockerFilePath);
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsCollectionDefined(Arguments))
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        ContainerRegistryDockerBuildStep IJsonModel<ContainerRegistryDockerBuildStep>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildStep)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryDockerBuildStep(document.RootElement, options);
        }

        internal static ContainerRegistryDockerBuildStep DeserializeContainerRegistryDockerBuildStep(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> imageNames = default;
            bool? isPushEnabled = default;
            bool? noCache = default;
            string dockerFilePath = default;
            string target = default;
            IList<ContainerRegistryRunArgument> arguments = default;
            ContainerRegistryTaskStepType type = default;
            IReadOnlyList<ContainerRegistryBaseImageDependency> baseImageDependencies = default;
            string contextPath = default;
            string contextAccessToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    imageNames = array;
                    continue;
                }
                if (property.NameEquals("isPushEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPushEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("noCache"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    noCache = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dockerFilePath"u8))
                {
                    dockerFilePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arguments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryRunArgument> array = new List<ContainerRegistryRunArgument>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryRunArgument.DeserializeContainerRegistryRunArgument(item, options));
                    }
                    arguments = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ContainerRegistryTaskStepType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("baseImageDependencies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryBaseImageDependency> array = new List<ContainerRegistryBaseImageDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryBaseImageDependency.DeserializeContainerRegistryBaseImageDependency(item, options));
                    }
                    baseImageDependencies = array;
                    continue;
                }
                if (property.NameEquals("contextPath"u8))
                {
                    contextPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contextAccessToken"u8))
                {
                    contextAccessToken = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerRegistryDockerBuildStep(
                type,
                baseImageDependencies ?? new ChangeTrackingList<ContainerRegistryBaseImageDependency>(),
                contextPath,
                contextAccessToken,
                serializedAdditionalRawData,
                imageNames ?? new ChangeTrackingList<string>(),
                isPushEnabled,
                noCache,
                dockerFilePath,
                target,
                arguments ?? new ChangeTrackingList<ContainerRegistryRunArgument>());
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ImageNames), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  imageNames: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ImageNames))
                {
                    if (ImageNames.Any())
                    {
                        builder.Append("  imageNames: ");
                        builder.AppendLine("[");
                        foreach (var item in ImageNames)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsPushEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isPushEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsPushEnabled))
                {
                    builder.Append("  isPushEnabled: ");
                    var boolValue = IsPushEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NoCache), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  noCache: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NoCache))
                {
                    builder.Append("  noCache: ");
                    var boolValue = NoCache.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DockerFilePath), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dockerFilePath: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DockerFilePath))
                {
                    builder.Append("  dockerFilePath: ");
                    if (DockerFilePath.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DockerFilePath}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DockerFilePath}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Target), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  target: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Target))
                {
                    builder.Append("  target: ");
                    if (Target.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Target}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Target}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Arguments), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  arguments: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Arguments))
                {
                    if (Arguments.Any())
                    {
                        builder.Append("  arguments: ");
                        builder.AppendLine("[");
                        foreach (var item in Arguments)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  arguments: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContainerRegistryTaskStepType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  type: ");
                builder.AppendLine($"'{ContainerRegistryTaskStepType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BaseImageDependencies), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  baseImageDependencies: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(BaseImageDependencies))
                {
                    if (BaseImageDependencies.Any())
                    {
                        builder.Append("  baseImageDependencies: ");
                        builder.AppendLine("[");
                        foreach (var item in BaseImageDependencies)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  baseImageDependencies: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContextPath), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  contextPath: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContextPath))
                {
                    builder.Append("  contextPath: ");
                    if (ContextPath.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ContextPath}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ContextPath}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContextAccessToken), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  contextAccessToken: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContextAccessToken))
                {
                    builder.Append("  contextAccessToken: ");
                    if (ContextAccessToken.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ContextAccessToken}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ContextAccessToken}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerRegistryDockerBuildStep>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildStep>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildStep)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerRegistryDockerBuildStep IPersistableModel<ContainerRegistryDockerBuildStep>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildStep>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerRegistryDockerBuildStep(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildStep)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryDockerBuildStep>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
