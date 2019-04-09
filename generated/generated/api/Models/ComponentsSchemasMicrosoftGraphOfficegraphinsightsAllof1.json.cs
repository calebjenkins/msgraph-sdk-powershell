namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>officeGraphInsights</summary>
    public partial class ComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1
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
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="ComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1"
        /// />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_shared = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("shared"), out var __jsonShared) ? If( __jsonShared as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphSharedInsight[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IMicrosoftGraphSharedInsight) (Sample.API.Models.MicrosoftGraphSharedInsight.FromJson(__u) )) ))() : null : Shared;}
            {_trending = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("trending"), out var __jsonTrending) ? If( __jsonTrending as Sample.API.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphTrending[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Sample.API.Models.IMicrosoftGraphTrending) (Sample.API.Models.MicrosoftGraphTrending.FromJson(__p) )) ))() : null : Trending;}
            {_used = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("used"), out var __jsonUsed) ? If( __jsonUsed as Sample.API.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Sample.API.Models.IMicrosoftGraphUsedInsight[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Sample.API.Models.IMicrosoftGraphUsedInsight) (Sample.API.Models.MicrosoftGraphUsedInsight.FromJson(__k) )) ))() : null : Used;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Sample.API.Models.IComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1.
        /// </returns>
        public static Sample.API.Models.IComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1 FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new ComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1" /> into a <see cref="Sample.API.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComponentsSchemasMicrosoftGraphOfficegraphinsightsAllof1" /> as a <see cref="Sample.API.Runtime.Json.JsonNode"
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
            if (null != Shared)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Shared )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("shared",__w);
            }
            if (null != Trending)
            {
                var __r = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __s in Trending )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("trending",__r);
            }
            if (null != Used)
            {
                var __m = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __n in Used )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("used",__m);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}