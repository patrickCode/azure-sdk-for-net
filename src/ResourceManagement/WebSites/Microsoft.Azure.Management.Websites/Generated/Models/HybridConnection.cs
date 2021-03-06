// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Hybrid Connection contract. This is used to configure a Hybrid
    /// Connection.
    /// </summary>
    [JsonTransformation]
    public partial class HybridConnection : Resource
    {
        /// <summary>
        /// Initializes a new instance of the HybridConnection class.
        /// </summary>
        public HybridConnection() { }

        /// <summary>
        /// Initializes a new instance of the HybridConnection class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="serviceBusNamespace">The name of the Service Bus
        /// namespace.</param>
        /// <param name="relayName">The name of the Service Bus relay.</param>
        /// <param name="relayArmUri">The ARM URI to the Service Bus
        /// relay.</param>
        /// <param name="hostname">The hostname of the endpoint.</param>
        /// <param name="port">The port of the endpoint.</param>
        /// <param name="sendKeyName">The name of the Service Bus key which has
        /// Send permissions. This is used to authenticate to Service
        /// Bus.</param>
        /// <param name="sendKeyValue">The value of the Service Bus key. This
        /// is used to authenticate to Service Bus. In ARM this key will not be
        /// returned
        /// normally, use the POST /listKeys API instead.</param>
        public HybridConnection(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string serviceBusNamespace = default(string), string relayName = default(string), string relayArmUri = default(string), string hostname = default(string), int? port = default(int?), string sendKeyName = default(string), string sendKeyValue = default(string))
            : base(location, id, name, kind, type, tags)
        {
            ServiceBusNamespace = serviceBusNamespace;
            RelayName = relayName;
            RelayArmUri = relayArmUri;
            Hostname = hostname;
            Port = port;
            SendKeyName = sendKeyName;
            SendKeyValue = sendKeyValue;
        }

        /// <summary>
        /// Gets or sets the name of the Service Bus namespace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceBusNamespace")]
        public string ServiceBusNamespace { get; set; }

        /// <summary>
        /// Gets or sets the name of the Service Bus relay.
        /// </summary>
        [JsonProperty(PropertyName = "properties.relayName")]
        public string RelayName { get; set; }

        /// <summary>
        /// Gets or sets the ARM URI to the Service Bus relay.
        /// </summary>
        [JsonProperty(PropertyName = "properties.relayArmUri")]
        public string RelayArmUri { get; set; }

        /// <summary>
        /// Gets or sets the hostname of the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or sets the port of the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets the name of the Service Bus key which has Send
        /// permissions. This is used to authenticate to Service Bus.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sendKeyName")]
        public string SendKeyName { get; set; }

        /// <summary>
        /// Gets or sets the value of the Service Bus key. This is used to
        /// authenticate to Service Bus. In ARM this key will not be returned
        /// normally, use the POST /listKeys API instead.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sendKeyValue")]
        public string SendKeyValue { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

