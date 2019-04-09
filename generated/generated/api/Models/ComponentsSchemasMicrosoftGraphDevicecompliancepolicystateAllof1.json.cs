namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>Device Compliance Policy State for a given device.</summary>
    public partial class ComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Sample.API.Runtime.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Sample.API.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Sample.API.Runtime.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Sample.API.Runtime.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Sample.API.Runtime.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_displayName = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_platformType = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("platformType"), out var __jsonPlatformType) ? (string)__jsonPlatformType : (string)PlatformType;}
            {_settingCount = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("settingCount"), out var __jsonSettingCount) ? (int?)__jsonSettingCount : SettingCount;}
            {_settingStates = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("settingStates"), out var __jsonSettingStates) ? If( __jsonSettingStates as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicySettingState[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphDeviceCompliancePolicySettingState) (Sample.API.Models.MicrosoftGraphDeviceCompliancePolicySettingState.FromJson(__u) )) ))() : null : SettingStates;}
            {_state = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;}
            {_version = If( json?.PropertyT<Sample.API.Runtime.Json.JsonNumber>("version"), out var __jsonVersion) ? (int?)__jsonVersion : Version;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1" /> into a <see
        /// cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphDevicecompliancepolicystateAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </returns>
        public Sample.API.Runtime.Json.JsonNode ToJson(Sample.API.Runtime.Json.JsonObject container, Sample.API.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Sample.API.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)DisplayName)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(DisplayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)PlatformType)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(PlatformType.ToString()) : null, "platformType" ,container.Add );
            AddIf( null != SettingCount ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)SettingCount) : null, "settingCount" ,container.Add );
            if (null != SettingStates)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in SettingStates )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("settingStates",__w);
            }
            AddIf( null != (((object)State)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(State.ToString()) : null, "state" ,container.Add );
            AddIf( null != Version ? (Sample.API.Runtime.Json.JsonNode)new Sample.API.Runtime.Json.JsonNumber((int)Version) : null, "version" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}