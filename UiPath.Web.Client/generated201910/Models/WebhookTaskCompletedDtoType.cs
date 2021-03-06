// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WebhookTaskCompletedDtoType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookTaskCompletedDtoType
    {
        [EnumMember(Value = "FormTask")]
        FormTask
    }
    internal static class WebhookTaskCompletedDtoTypeEnumExtension
    {
        internal static string ToSerializedValue(this WebhookTaskCompletedDtoType? value)
        {
            return value == null ? null : ((WebhookTaskCompletedDtoType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebhookTaskCompletedDtoType value)
        {
            switch( value )
            {
                case WebhookTaskCompletedDtoType.FormTask:
                    return "FormTask";
            }
            return null;
        }

        internal static WebhookTaskCompletedDtoType? ParseWebhookTaskCompletedDtoType(this string value)
        {
            switch( value )
            {
                case "FormTask":
                    return WebhookTaskCompletedDtoType.FormTask;
            }
            return null;
        }
    }
}
