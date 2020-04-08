// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for QueueItemDtoProcessingExceptionType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueueItemDtoProcessingExceptionType
    {
        [EnumMember(Value = "ApplicationException")]
        ApplicationException,
        [EnumMember(Value = "BusinessException")]
        BusinessException
    }
    internal static class QueueItemDtoProcessingExceptionTypeEnumExtension
    {
        internal static string ToSerializedValue(this QueueItemDtoProcessingExceptionType? value)
        {
            return value == null ? null : ((QueueItemDtoProcessingExceptionType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this QueueItemDtoProcessingExceptionType value)
        {
            switch( value )
            {
                case QueueItemDtoProcessingExceptionType.ApplicationException:
                    return "ApplicationException";
                case QueueItemDtoProcessingExceptionType.BusinessException:
                    return "BusinessException";
            }
            return null;
        }

        internal static QueueItemDtoProcessingExceptionType? ParseQueueItemDtoProcessingExceptionType(this string value)
        {
            switch( value )
            {
                case "ApplicationException":
                    return QueueItemDtoProcessingExceptionType.ApplicationException;
                case "BusinessException":
                    return QueueItemDtoProcessingExceptionType.BusinessException;
            }
            return null;
        }
    }
}