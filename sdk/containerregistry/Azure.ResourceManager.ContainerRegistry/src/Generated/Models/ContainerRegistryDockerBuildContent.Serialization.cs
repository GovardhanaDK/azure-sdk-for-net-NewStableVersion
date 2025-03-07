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
    public partial class ContainerRegistryDockerBuildContent : IUtf8JsonSerializable, IJsonModel<ContainerRegistryDockerBuildContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryDockerBuildContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerRegistryDockerBuildContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildContent)} does not support writing '{format}' format.");
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
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            writer.WritePropertyName("platform"u8);
            writer.WriteObjectValue(Platform, options);
            if (Optional.IsDefined(AgentConfiguration))
            {
                writer.WritePropertyName("agentConfiguration"u8);
                writer.WriteObjectValue(AgentConfiguration, options);
            }
            if (Optional.IsDefined(SourceLocation))
            {
                writer.WritePropertyName("sourceLocation"u8);
                writer.WriteStringValue(SourceLocation);
            }
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials, options);
            }
        }

        ContainerRegistryDockerBuildContent IJsonModel<ContainerRegistryDockerBuildContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryDockerBuildContent(document.RootElement, options);
        }

        internal static ContainerRegistryDockerBuildContent DeserializeContainerRegistryDockerBuildContent(JsonElement element, ModelReaderWriterOptions options = null)
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
            int? timeout = default;
            ContainerRegistryPlatformProperties platform = default;
            ContainerRegistryAgentProperties agentConfiguration = default;
            string sourceLocation = default;
            ContainerRegistryCredentials credentials = default;
            string type = default;
            bool? isArchiveEnabled = default;
            string agentPoolName = default;
            string logTemplate = default;
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
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("platform"u8))
                {
                    platform = ContainerRegistryPlatformProperties.DeserializeContainerRegistryPlatformProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("agentConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentConfiguration = ContainerRegistryAgentProperties.DeserializeContainerRegistryAgentProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sourceLocation"u8))
                {
                    sourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = ContainerRegistryCredentials.DeserializeContainerRegistryCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isArchiveEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isArchiveEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("agentPoolName"u8))
                {
                    agentPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logTemplate"u8))
                {
                    logTemplate = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerRegistryDockerBuildContent(
                type,
                isArchiveEnabled,
                agentPoolName,
                logTemplate,
                serializedAdditionalRawData,
                imageNames ?? new ChangeTrackingList<string>(),
                isPushEnabled,
                noCache,
                dockerFilePath,
                target,
                arguments ?? new ChangeTrackingList<ContainerRegistryRunArgument>(),
                timeout,
                platform,
                agentConfiguration,
                sourceLocation,
                credentials);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TimeoutInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeout: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TimeoutInSeconds))
                {
                    builder.Append("  timeout: ");
                    builder.AppendLine($"{TimeoutInSeconds.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Platform), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  platform: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Platform))
                {
                    builder.Append("  platform: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Platform, options, 2, false, "  platform: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("AgentCpu", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  agentConfiguration: ");
                builder.AppendLine("{");
                builder.Append("    cpu: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(AgentConfiguration))
                {
                    builder.Append("  agentConfiguration: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AgentConfiguration, options, 2, false, "  agentConfiguration: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceLocation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sourceLocation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceLocation))
                {
                    builder.Append("  sourceLocation: ");
                    if (SourceLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SourceLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SourceLocation}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Credentials), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  credentials: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Credentials))
                {
                    builder.Append("  credentials: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Credentials, options, 2, false, "  credentials: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RunRequestType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RunRequestType))
                {
                    builder.Append("  type: ");
                    if (RunRequestType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RunRequestType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RunRequestType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsArchiveEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isArchiveEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsArchiveEnabled))
                {
                    builder.Append("  isArchiveEnabled: ");
                    var boolValue = IsArchiveEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AgentPoolName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  agentPoolName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AgentPoolName))
                {
                    builder.Append("  agentPoolName: ");
                    if (AgentPoolName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AgentPoolName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AgentPoolName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LogTemplate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  logTemplate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LogTemplate))
                {
                    builder.Append("  logTemplate: ");
                    if (LogTemplate.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LogTemplate}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LogTemplate}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerRegistryDockerBuildContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildContent)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerRegistryDockerBuildContent IPersistableModel<ContainerRegistryDockerBuildContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryDockerBuildContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerRegistryDockerBuildContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryDockerBuildContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryDockerBuildContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
