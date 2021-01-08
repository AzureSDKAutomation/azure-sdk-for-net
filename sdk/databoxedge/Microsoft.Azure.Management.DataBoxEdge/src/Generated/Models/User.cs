// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a user who has access to one or more shares on the Data Box
    /// Edge/Gateway device.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class User : ARMBaseModel
    {
        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        public User()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The object name.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="systemData">User in DataBoxEdge Resource</param>
        /// <param name="encryptedPassword">The password details.</param>
        /// <param name="shareAccessRights">List of shares that the user has
        /// rights on. This field should not be specified during user
        /// creation.</param>
        /// <param name="userType">Type of the user. Possible values include:
        /// 'Share', 'LocalManagement', 'ARM'</param>
        public User(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), AsymmetricEncryptedSecret encryptedPassword = default(AsymmetricEncryptedSecret), IList<ShareAccessRight> shareAccessRights = default(IList<ShareAccessRight>), string userType = default(string))
            : base(id, name, type)
        {
            SystemData = systemData;
            EncryptedPassword = encryptedPassword;
            ShareAccessRights = shareAccessRights;
            UserType = userType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user in DataBoxEdge Resource
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; set; }

        /// <summary>
        /// Gets or sets the password details.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptedPassword")]
        public AsymmetricEncryptedSecret EncryptedPassword { get; set; }

        /// <summary>
        /// Gets list of shares that the user has rights on. This field should
        /// not be specified during user creation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.shareAccessRights")]
        public IList<ShareAccessRight> ShareAccessRights { get; private set; }

        /// <summary>
        /// Gets or sets type of the user. Possible values include: 'Share',
        /// 'LocalManagement', 'ARM'
        /// </summary>
        [JsonProperty(PropertyName = "properties.userType")]
        public string UserType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EncryptedPassword != null)
            {
                EncryptedPassword.Validate();
            }
            if (ShareAccessRights != null)
            {
                foreach (var element in ShareAccessRights)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
