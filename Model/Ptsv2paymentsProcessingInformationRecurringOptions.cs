/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
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
    /// Ptsv2paymentsProcessingInformationRecurringOptions
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsProcessingInformationRecurringOptions :  IEquatable<Ptsv2paymentsProcessingInformationRecurringOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsProcessingInformationRecurringOptions" /> class.
        /// </summary>
        /// <param name="LoanPayment">Flag that indicates whether this is a payment towards an existing contractual loan.  (default to false).</param>
        /// <param name="FirstRecurringPayment">Flag that indicates whether this transaction is the first in a series of recurring payments. This field is supported only for **Atos**, **FDC Nashville Global**, and **OmniPay Direct**.  (default to false).</param>
        public Ptsv2paymentsProcessingInformationRecurringOptions(bool? LoanPayment = false, bool? FirstRecurringPayment = false)
        {
            // use default value if no "LoanPayment" provided
            if (LoanPayment == null)
            {
                this.LoanPayment = false;
            }
            else
            {
                this.LoanPayment = LoanPayment;
            }
            // use default value if no "FirstRecurringPayment" provided
            if (FirstRecurringPayment == null)
            {
                this.FirstRecurringPayment = false;
            }
            else
            {
                this.FirstRecurringPayment = FirstRecurringPayment;
            }
        }
        
        /// <summary>
        /// Flag that indicates whether this is a payment towards an existing contractual loan. 
        /// </summary>
        /// <value>Flag that indicates whether this is a payment towards an existing contractual loan. </value>
        [DataMember(Name="loanPayment", EmitDefaultValue=false)]
        public bool? LoanPayment { get; set; }

        /// <summary>
        /// Flag that indicates whether this transaction is the first in a series of recurring payments. This field is supported only for **Atos**, **FDC Nashville Global**, and **OmniPay Direct**. 
        /// </summary>
        /// <value>Flag that indicates whether this transaction is the first in a series of recurring payments. This field is supported only for **Atos**, **FDC Nashville Global**, and **OmniPay Direct**. </value>
        [DataMember(Name="firstRecurringPayment", EmitDefaultValue=false)]
        public bool? FirstRecurringPayment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsProcessingInformationRecurringOptions {\n");
            sb.Append("  LoanPayment: ").Append(LoanPayment).Append("\n");
            sb.Append("  FirstRecurringPayment: ").Append(FirstRecurringPayment).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsProcessingInformationRecurringOptions);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsProcessingInformationRecurringOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsProcessingInformationRecurringOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsProcessingInformationRecurringOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LoanPayment == other.LoanPayment ||
                    this.LoanPayment != null &&
                    this.LoanPayment.Equals(other.LoanPayment)
                ) && 
                (
                    this.FirstRecurringPayment == other.FirstRecurringPayment ||
                    this.FirstRecurringPayment != null &&
                    this.FirstRecurringPayment.Equals(other.FirstRecurringPayment)
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
                if (this.LoanPayment != null)
                    hash = hash * 59 + this.LoanPayment.GetHashCode();
                if (this.FirstRecurringPayment != null)
                    hash = hash * 59 + this.FirstRecurringPayment.GetHashCode();
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