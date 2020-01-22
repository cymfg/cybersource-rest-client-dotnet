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
    /// Ptsv2paymentsidreversalsClientReferenceInformationPartner
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidreversalsClientReferenceInformationPartner :  IEquatable<Ptsv2paymentsidreversalsClientReferenceInformationPartner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidreversalsClientReferenceInformationPartner" /> class.
        /// </summary>
        /// <param name="DeveloperId">Identifier for the developer that helped integrate a partner solution to CyberSource.  Send this value in all requests that are sent through the partner solutions built by that developer. CyberSource assigns the ID to the developer.  **Note** When you see a developer ID of 999 in reports, the developer ID that was submitted is incorrect. .</param>
        /// <param name="SolutionId">Identifier for the partner that is integrated to CyberSource.  Send this value in all requests that are sent through the partner solution. CyberSource assigns the ID to the partner.  **Note** When you see a partner ID of 999 in reports, the partner ID that was submitted is incorrect. .</param>
        /// <param name="ThirdPartyCertificationNumber">Value that identifies the application vendor and application version for a third party gateway. CyberSource provides you with this value during testing and validation. This field is supported only on CyberSource through VisaNet. .</param>
        public Ptsv2paymentsidreversalsClientReferenceInformationPartner(string DeveloperId = default(string), string SolutionId = default(string), string ThirdPartyCertificationNumber = default(string))
        {
            this.DeveloperId = DeveloperId;
            this.SolutionId = SolutionId;
            this.ThirdPartyCertificationNumber = ThirdPartyCertificationNumber;
        }
        
        /// <summary>
        /// Identifier for the developer that helped integrate a partner solution to CyberSource.  Send this value in all requests that are sent through the partner solutions built by that developer. CyberSource assigns the ID to the developer.  **Note** When you see a developer ID of 999 in reports, the developer ID that was submitted is incorrect. 
        /// </summary>
        /// <value>Identifier for the developer that helped integrate a partner solution to CyberSource.  Send this value in all requests that are sent through the partner solutions built by that developer. CyberSource assigns the ID to the developer.  **Note** When you see a developer ID of 999 in reports, the developer ID that was submitted is incorrect. </value>
        [DataMember(Name="developerId", EmitDefaultValue=false)]
        public string DeveloperId { get; set; }

        /// <summary>
        /// Identifier for the partner that is integrated to CyberSource.  Send this value in all requests that are sent through the partner solution. CyberSource assigns the ID to the partner.  **Note** When you see a partner ID of 999 in reports, the partner ID that was submitted is incorrect. 
        /// </summary>
        /// <value>Identifier for the partner that is integrated to CyberSource.  Send this value in all requests that are sent through the partner solution. CyberSource assigns the ID to the partner.  **Note** When you see a partner ID of 999 in reports, the partner ID that was submitted is incorrect. </value>
        [DataMember(Name="solutionId", EmitDefaultValue=false)]
        public string SolutionId { get; set; }

        /// <summary>
        /// Value that identifies the application vendor and application version for a third party gateway. CyberSource provides you with this value during testing and validation. This field is supported only on CyberSource through VisaNet. 
        /// </summary>
        /// <value>Value that identifies the application vendor and application version for a third party gateway. CyberSource provides you with this value during testing and validation. This field is supported only on CyberSource through VisaNet. </value>
        [DataMember(Name="thirdPartyCertificationNumber", EmitDefaultValue=false)]
        public string ThirdPartyCertificationNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidreversalsClientReferenceInformationPartner {\n");
            sb.Append("  DeveloperId: ").Append(DeveloperId).Append("\n");
            sb.Append("  SolutionId: ").Append(SolutionId).Append("\n");
            sb.Append("  ThirdPartyCertificationNumber: ").Append(ThirdPartyCertificationNumber).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidreversalsClientReferenceInformationPartner);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidreversalsClientReferenceInformationPartner instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidreversalsClientReferenceInformationPartner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidreversalsClientReferenceInformationPartner other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeveloperId == other.DeveloperId ||
                    this.DeveloperId != null &&
                    this.DeveloperId.Equals(other.DeveloperId)
                ) && 
                (
                    this.SolutionId == other.SolutionId ||
                    this.SolutionId != null &&
                    this.SolutionId.Equals(other.SolutionId)
                ) && 
                (
                    this.ThirdPartyCertificationNumber == other.ThirdPartyCertificationNumber ||
                    this.ThirdPartyCertificationNumber != null &&
                    this.ThirdPartyCertificationNumber.Equals(other.ThirdPartyCertificationNumber)
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
                if (this.DeveloperId != null)
                    hash = hash * 59 + this.DeveloperId.GetHashCode();
                if (this.SolutionId != null)
                    hash = hash * 59 + this.SolutionId.GetHashCode();
                if (this.ThirdPartyCertificationNumber != null)
                    hash = hash * 59 + this.ThirdPartyCertificationNumber.GetHashCode();
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
            // DeveloperId (string) maxLength
            if(this.DeveloperId != null && this.DeveloperId.Length >= 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeveloperId, length must be less than or equal to 8.", new [] { "DeveloperId" });
            }

            // SolutionId (string) maxLength
            if(this.SolutionId != null && this.SolutionId.Length >= 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolutionId, length must be less than or equal to 8.", new [] { "SolutionId" });
            }

            // ThirdPartyCertificationNumber (string) maxLength
            if(this.ThirdPartyCertificationNumber != null && this.ThirdPartyCertificationNumber.Length >= 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ThirdPartyCertificationNumber, length must be less than or equal to 12.", new [] { "ThirdPartyCertificationNumber" });
            }

            yield break;
        }
    }

}
