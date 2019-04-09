namespace Sample.API.Models
{

    /// <summary>FIXME: Class MicrosoftGraphListItemVersion is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphListItemVersionTypeConverter))]
    public partial class MicrosoftGraphListItemVersion
    {

        /// <summary>
        /// Creates a new instance of <see cref="MicrosoftGraphListItemVersion" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMicrosoftGraphListItemVersion FromJsonString(string jsonText) => FromJson(Sample.API.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Sample.API.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IMicrosoftGraphListItemVersion is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(MicrosoftGraphListItemVersionTypeConverter))]
    public partial interface IMicrosoftGraphListItemVersion {

    }
}