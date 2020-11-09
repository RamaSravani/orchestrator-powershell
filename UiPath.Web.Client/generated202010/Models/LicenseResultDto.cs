// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client202010.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LicenseResultDto
    {
        /// <summary>
        /// Initializes a new instance of the LicenseResultDto class.
        /// </summary>
        public LicenseResultDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LicenseResultDto class.
        /// </summary>
        /// <param name="errorCode">Possible values include: 'NoLicense',
        /// 'LicenseExpired', 'LicenseUnregistered', 'NoAvailableLicenses',
        /// 'NotEnoughAvailableSlots', 'NotEnoughRuntimeLicenses',
        /// 'LicenseIsAlreadyInUse', 'InvalidRequest',
        /// 'SlotsExceedLicenseLimit', 'RuntimeDisabled',
        /// 'ExternalNotSupported', 'UsageExceedsLicenseLimit',
        /// 'LicenseNotCompatible'</param>
        public LicenseResultDto(bool? isSuccess = default(bool?), LicenseResultDtoErrorCode? errorCode = default(LicenseResultDtoErrorCode?), string errorMessage = default(string))
        {
            IsSuccess = isSuccess;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isSuccess")]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NoLicense',
        /// 'LicenseExpired', 'LicenseUnregistered', 'NoAvailableLicenses',
        /// 'NotEnoughAvailableSlots', 'NotEnoughRuntimeLicenses',
        /// 'LicenseIsAlreadyInUse', 'InvalidRequest',
        /// 'SlotsExceedLicenseLimit', 'RuntimeDisabled',
        /// 'ExternalNotSupported', 'UsageExceedsLicenseLimit',
        /// 'LicenseNotCompatible'
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public LicenseResultDtoErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

    }
}