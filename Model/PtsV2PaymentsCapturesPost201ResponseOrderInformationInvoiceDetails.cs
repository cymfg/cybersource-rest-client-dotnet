/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// PtsV2PaymentsCapturesPost201ResponseOrderInformationInvoiceDetails
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsCapturesPost201ResponseOrderInformationInvoiceDetails :  IEquatable<PtsV2PaymentsCapturesPost201ResponseOrderInformationInvoiceDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsCapturesPost201ResponseOrderInformationInvoiceDetails" /> class.
        /// </summary>
        /// <param name="Level3TransmissionStatus">Indicates whether CyberSource sent the Level III information to the processor. The possible values are:  If your account is not enabled for Level III data or if you did not include the purchasing level field in your request, CyberSource does not include the Level III data in the request sent to the processor.  For processor-specific information, see the &#x60;bill_purchasing_level3_enabled&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html)  Possible values: - **true** - **false** .</param>
        public PtsV2PaymentsCapturesPost201ResponseOrderInformationInvoiceDetails(bool? Level3TransmissionStatus = default(bool?))
        {
            this.Level3TransmissionStatus = Level3TransmissionStatus;
        }
        
        /// <summary>
        /// Indicates whether CyberSource sent the Level III information to the processor. The possible values are:  If your account is not enabled for Level III data or if you did not include the purchasing level field in your request, CyberSource does not include the Level III data in the request sent to the processor.  For processor-specific information, see the &#x60;bill_purchasing_level3_enabled&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html)  Possible values: - **true** - **false** 
        /// </summary>
        /// <value>Indicates whether CyberSource sent the Level III information to the processor. The possible values are:  If your account is not enabled for Level III data or if you did not include the purchasing level field in your request, CyberSource does not include the Level III data in the request sent to the processor.  For processor-specific information, see the &#x60;bill_purchasing_level3_enabled&#x60; field description in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html)  Possible values: - **true** - **false** </value>
        [DataMember(Name="level3TransmissionStatus", EmitDefaultValue=false)]
        public bool? Level3TransmissionStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsCapturesPost201ResponseOrderInformationInvoiceDetails {\n");
            sb.Append("  Level3TransmissionStatus: ").Append(Level3TransmissionStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PtsV2PaymentsCapturesPost201ResponseOrderInformationInvoiceDetails);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsCapturesPost201ResponseOrderInformationInvoiceDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsCapturesPost201ResponseOrderInformationInvoiceDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsCapturesPost201ResponseOrderInformationInvoiceDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Level3TransmissionStatus == other.Level3TransmissionStatus ||
                    this.Level3TransmissionStatus != null &&
                    this.Level3TransmissionStatus.Equals(other.Level3TransmissionStatus)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Level3TransmissionStatus != null)
                    hash = hash * 59 + this.Level3TransmissionStatus.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
