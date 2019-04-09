namespace Sample.API.Models
{
    using static Sample.API.Runtime.Extensions;
    public partial class OdataErrorMain
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
        /// Deserializes a <see cref="Sample.API.Runtime.Json.JsonNode"/> into an instance of Sample.API.Models.IOdataErrorMain.
        /// </summary>
        /// <param name="node">a <see cref="Sample.API.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IOdataErrorMain.</returns>
        public static Sample.API.Models.IOdataErrorMain FromJson(Sample.API.Runtime.Json.JsonNode node)
        {
            return node is Sample.API.Runtime.Json.JsonObject json ? new OdataErrorMain(json) : null;
        }
        /// <summary>
        /// Deserializes a Sample.API.Runtime.Json.JsonObject into a new instance of <see cref="OdataErrorMain" />.
        /// </summary>
        /// <param name="json">A Sample.API.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OdataErrorMain(Sample.API.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_code = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("code"), out var __jsonCode) ? (string)__jsonCode : (string)Code;}
            {_innererror = If( json?.PropertyT<Sample.API.Runtime.Json.JsonObject>("innererror"), out var __jsonInnererror) ? Sample.API.Models.OdataErrorMainInnererror.FromJson(__jsonInnererror) : Innererror;}
            {_message = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("message"), out var __jsonMessage) ? (string)__jsonMessage : (string)Message;}
            {_target = If( json?.PropertyT<Sample.API.Runtime.Json.JsonString>("target"), out var __jsonTarget) ? (string)__jsonTarget : (string)Target;}
            {_details = If( json?.PropertyT<Sample.API.Runtime.Json.JsonArray>("details"), out var __jsonDetails) ? If( __jsonDetails as Sample.API.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Sample.API.Models.IOdataErrorDetail[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Sample.API.Models.IOdataErrorDetail) (Sample.API.Models.OdataErrorDetail.FromJson(__u) )) ))() : null : Details;}
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="OdataErrorMain" /> into a <see cref="Sample.API.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Sample.API.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Sample.API.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OdataErrorMain" /> as a <see cref="Sample.API.Runtime.Json.JsonNode" />.
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
            AddIf( null != (((object)Code)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Code.ToString()) : null, "code" ,container.Add );
            AddIf( null != Innererror ? (Sample.API.Runtime.Json.JsonNode) Innererror.ToJson(null,serializationMode) : null, "innererror" ,container.Add );
            AddIf( null != (((object)Message)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Message.ToString()) : null, "message" ,container.Add );
            AddIf( null != (((object)Target)?.ToString()) ? (Sample.API.Runtime.Json.JsonNode) new Sample.API.Runtime.Json.JsonString(Target.ToString()) : null, "target" ,container.Add );
            if (null != Details)
            {
                var __w = new Sample.API.Runtime.Json.XNodeArray();
                foreach( var __x in Details )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("details",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}