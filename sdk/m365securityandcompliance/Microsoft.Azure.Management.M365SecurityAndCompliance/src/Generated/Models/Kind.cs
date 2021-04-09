// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.M365SecurityAndCompliance.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Kind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Kind
    {
        [EnumMember(Value = "fhir")]
        Fhir,
        [EnumMember(Value = "fhir-Stu3")]
        FhirStu3,
        [EnumMember(Value = "fhir-R4")]
        FhirR4
    }
    internal static class KindEnumExtension
    {
        internal static string ToSerializedValue(this Kind? value)
        {
            return value == null ? null : ((Kind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this Kind value)
        {
            switch( value )
            {
                case Kind.Fhir:
                    return "fhir";
                case Kind.FhirStu3:
                    return "fhir-Stu3";
                case Kind.FhirR4:
                    return "fhir-R4";
            }
            return null;
        }

        internal static Kind? ParseKind(this string value)
        {
            switch( value )
            {
                case "fhir":
                    return Kind.Fhir;
                case "fhir-Stu3":
                    return Kind.FhirStu3;
                case "fhir-R4":
                    return Kind.FhirR4;
            }
            return null;
        }
    }
}
