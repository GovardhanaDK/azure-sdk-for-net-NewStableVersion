// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SynapseSparkJobDefinitionActivityConverter))]
    public partial class SynapseSparkJobDefinitionActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedServiceName))
            {
                writer.WritePropertyName("linkedServiceName"u8);
                writer.WriteObjectValue(LinkedServiceName);
            }
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy"u8);
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(OnInactiveMarkAs))
            {
                writer.WritePropertyName("onInactiveMarkAs"u8);
                writer.WriteStringValue(OnInactiveMarkAs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties"u8);
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("sparkJob"u8);
            writer.WriteObjectValue(SparkJob);
            if (Optional.IsCollectionDefined(Arguments))
            {
                writer.WritePropertyName("args"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue<object>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(File))
            {
                writer.WritePropertyName("file"u8);
                writer.WriteObjectValue<object>(File);
            }
            if (Optional.IsDefined(ScanFolder))
            {
                writer.WritePropertyName("scanFolder"u8);
                writer.WriteObjectValue<object>(ScanFolder);
            }
            if (Optional.IsDefined(ClassName))
            {
                writer.WritePropertyName("className"u8);
                writer.WriteObjectValue<object>(ClassName);
            }
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files"u8);
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue<object>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PythonCodeReference))
            {
                writer.WritePropertyName("pythonCodeReference"u8);
                writer.WriteStartArray();
                foreach (var item in PythonCodeReference)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue<object>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FilesV2))
            {
                writer.WritePropertyName("filesV2"u8);
                writer.WriteStartArray();
                foreach (var item in FilesV2)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue<object>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetBigDataPool))
            {
                writer.WritePropertyName("targetBigDataPool"u8);
                writer.WriteObjectValue(TargetBigDataPool);
            }
            if (Optional.IsDefined(ExecutorSize))
            {
                writer.WritePropertyName("executorSize"u8);
                writer.WriteObjectValue<object>(ExecutorSize);
            }
            if (Optional.IsDefined(Conf))
            {
                writer.WritePropertyName("conf"u8);
                writer.WriteObjectValue<object>(Conf);
            }
            if (Optional.IsDefined(DriverSize))
            {
                writer.WritePropertyName("driverSize"u8);
                writer.WriteObjectValue<object>(DriverSize);
            }
            if (Optional.IsDefined(NumExecutors))
            {
                writer.WritePropertyName("numExecutors"u8);
                writer.WriteObjectValue<object>(NumExecutors);
            }
            if (Optional.IsDefined(ConfigurationType))
            {
                writer.WritePropertyName("configurationType"u8);
                writer.WriteStringValue(ConfigurationType.Value.ToString());
            }
            if (Optional.IsDefined(TargetSparkConfiguration))
            {
                writer.WritePropertyName("targetSparkConfiguration"u8);
                writer.WriteObjectValue(TargetSparkConfiguration);
            }
            if (Optional.IsCollectionDefined(SparkConfig))
            {
                writer.WritePropertyName("sparkConfig"u8);
                writer.WriteStartObject();
                foreach (var item in SparkConfig)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue<object>(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteObjectValue(Authentication);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SynapseSparkJobDefinitionActivity DeserializeSynapseSparkJobDefinitionActivity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LinkedServiceReference linkedServiceName = default;
            ActivityPolicy policy = default;
            string name = default;
            string type = default;
            string description = default;
            ActivityState? state = default;
            ActivityOnInactiveMarkAs? onInactiveMarkAs = default;
            IList<ActivityDependency> dependsOn = default;
            IList<UserProperty> userProperties = default;
            SynapseSparkJobReference sparkJob = default;
            IList<object> args = default;
            object file = default;
            object scanFolder = default;
            object className = default;
            IList<object> files = default;
            IList<object> pythonCodeReference = default;
            IList<object> filesV2 = default;
            BigDataPoolParametrizationReference targetBigDataPool = default;
            object executorSize = default;
            object conf = default;
            object driverSize = default;
            object numExecutors = default;
            ConfigurationType? configurationType = default;
            SparkConfigurationParametrizationReference targetSparkConfiguration = default;
            IDictionary<string, object> sparkConfig = default;
            SynapseActivityAuthentication authentication = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = ActivityPolicy.DeserializeActivityPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onInactiveMarkAs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onInactiveMarkAs = new ActivityOnInactiveMarkAs(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityDependency.DeserializeActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserProperty.DeserializeUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sparkJob"u8))
                        {
                            sparkJob = SynapseSparkJobReference.DeserializeSynapseSparkJobReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("args"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetObject());
                                }
                            }
                            args = array;
                            continue;
                        }
                        if (property0.NameEquals("file"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            file = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("scanFolder"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scanFolder = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("className"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            className = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("files"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetObject());
                                }
                            }
                            files = array;
                            continue;
                        }
                        if (property0.NameEquals("pythonCodeReference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetObject());
                                }
                            }
                            pythonCodeReference = array;
                            continue;
                        }
                        if (property0.NameEquals("filesV2"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetObject());
                                }
                            }
                            filesV2 = array;
                            continue;
                        }
                        if (property0.NameEquals("targetBigDataPool"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetBigDataPool = BigDataPoolParametrizationReference.DeserializeBigDataPoolParametrizationReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("executorSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            executorSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("conf"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            conf = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("driverSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            driverSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("numExecutors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numExecutors = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("configurationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationType = new ConfigurationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetSparkConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetSparkConfiguration = SparkConfigurationParametrizationReference.DeserializeSparkConfigurationParametrizationReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sparkConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, property1.Value.GetObject());
                                }
                            }
                            sparkConfig = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("authentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authentication = SynapseActivityAuthentication.DeserializeSynapseActivityAuthentication(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseSparkJobDefinitionActivity(
                name,
                type,
                description,
                state,
                onInactiveMarkAs,
                dependsOn ?? new ChangeTrackingList<ActivityDependency>(),
                userProperties ?? new ChangeTrackingList<UserProperty>(),
                additionalProperties,
                linkedServiceName,
                policy,
                sparkJob,
                args ?? new ChangeTrackingList<object>(),
                file,
                scanFolder,
                className,
                files ?? new ChangeTrackingList<object>(),
                pythonCodeReference ?? new ChangeTrackingList<object>(),
                filesV2 ?? new ChangeTrackingList<object>(),
                targetBigDataPool,
                executorSize,
                conf,
                driverSize,
                numExecutors,
                configurationType,
                targetSparkConfiguration,
                sparkConfig ?? new ChangeTrackingDictionary<string, object>(),
                authentication);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new SynapseSparkJobDefinitionActivity FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSynapseSparkJobDefinitionActivity(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class SynapseSparkJobDefinitionActivityConverter : JsonConverter<SynapseSparkJobDefinitionActivity>
        {
            public override void Write(Utf8JsonWriter writer, SynapseSparkJobDefinitionActivity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override SynapseSparkJobDefinitionActivity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSynapseSparkJobDefinitionActivity(document.RootElement);
            }
        }
    }
}
