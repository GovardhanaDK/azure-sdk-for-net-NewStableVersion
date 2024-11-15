// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> The UpdateAgentRequest. </summary>
    internal partial class UpdateAgentRequest
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UpdateAgentRequest"/>. </summary>
        internal UpdateAgentRequest()
        {
            Tools = new ChangeTrackingList<ToolDefinition>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="UpdateAgentRequest"/>. </summary>
        /// <param name="model"> The ID of the model to use. </param>
        /// <param name="name"> The modified name for the agent to use. </param>
        /// <param name="description"> The modified description for the agent to use. </param>
        /// <param name="instructions"> The modified system instructions for the new agent to use. </param>
        /// <param name="tools">
        /// The modified collection of tools to enable for the agent.
        /// Please note <see cref="ToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureAISearchToolDefinition"/>, <see cref="BingGroundingToolDefinition"/>, <see cref="CodeInterpreterToolDefinition"/>, <see cref="FileSearchToolDefinition"/>, <see cref="FunctionToolDefinition"/>, <see cref="MicrosoftFabricToolDefinition"/> and <see cref="SharepointToolDefinition"/>.
        /// </param>
        /// <param name="toolResources">
        /// A set of resources that are used by the agent's tools. The resources are specific to the type of tool. For example,
        /// the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random,
        /// while lower values like 0.2 will make it more focused and deterministic.
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass.
        /// So 0.1 means only the tokens comprising the top 10% probability mass are considered.
        ///
        /// We generally recommend altering this or temperature but not both.
        /// </param>
        /// <param name="responseFormat"> The response format of the tool calls used by this agent. </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdateAgentRequest(string model, string name, string description, string instructions, IReadOnlyList<ToolDefinition> tools, ToolResources toolResources, float? temperature, float? topP, BinaryData responseFormat, IReadOnlyDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Model = model;
            Name = name;
            Description = description;
            Instructions = instructions;
            Tools = tools;
            ToolResources = toolResources;
            Temperature = temperature;
            TopP = topP;
            ResponseFormat = responseFormat;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of the model to use. </summary>
        public string Model { get; }
        /// <summary> The modified name for the agent to use. </summary>
        public string Name { get; }
        /// <summary> The modified description for the agent to use. </summary>
        public string Description { get; }
        /// <summary> The modified system instructions for the new agent to use. </summary>
        public string Instructions { get; }
        /// <summary>
        /// The modified collection of tools to enable for the agent.
        /// Please note <see cref="ToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureAISearchToolDefinition"/>, <see cref="BingGroundingToolDefinition"/>, <see cref="CodeInterpreterToolDefinition"/>, <see cref="FileSearchToolDefinition"/>, <see cref="FunctionToolDefinition"/>, <see cref="MicrosoftFabricToolDefinition"/> and <see cref="SharepointToolDefinition"/>.
        /// </summary>
        public IReadOnlyList<ToolDefinition> Tools { get; }
        /// <summary>
        /// A set of resources that are used by the agent's tools. The resources are specific to the type of tool. For example,
        /// the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
        /// </summary>
        public ToolResources ToolResources { get; }
        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random,
        /// while lower values like 0.2 will make it more focused and deterministic.
        /// </summary>
        public float? Temperature { get; }
        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass.
        /// So 0.1 means only the tokens comprising the top 10% probability mass are considered.
        ///
        /// We generally recommend altering this or temperature but not both.
        /// </summary>
        public float? TopP { get; }
        /// <summary>
        /// The response format of the tool calls used by this agent.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="string"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="AgentsApiResponseFormatMode"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="AgentsApiResponseFormat"/></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData ResponseFormat { get; }
        /// <summary> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
