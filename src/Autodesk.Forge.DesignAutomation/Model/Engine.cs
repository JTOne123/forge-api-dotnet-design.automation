/* 
 * Forge Design Automation
 *
 * Generated by [Forge Swagger Codegen](https://git.autodesk.com/design-automation/forge-rsdk-codegen)
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Autodesk.Forge.DesignAutomation.Model
{
    /// <summary>
    /// An Engine executes a WorkItem job and processes the actions specified by an Activity. Engines are provided by Autodesk. AppBundles and Activities refer to Engines with their alias, e.g. Autodesk.Revit+23. ( request only ).
    /// </summary>
    [DataContract]
    public partial class Engine 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Engine" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Engine() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Engine" /> class.
        /// </summary>
        /// <param name="Package">The URL that points to the zip package for the AppBundle..</param>
        /// <param name="ProductVersion">The product version of the Engine (the version of the binary that will be uploaded). (required).</param>
        /// <param name="Description">Human readable description of the object..</param>
        /// <param name="Version">Version.</param>
        /// <param name="Id">Id.</param>
        public Engine(string Package = default(string), string ProductVersion = default(string), string Description = default(string), int Version = default(int), string Id = default(string))
        {
            this.Package = Package;
            this.ProductVersion = ProductVersion;
            this.Description = Description;
            this.Version = Version;
            this.Id = Id;
        }
        
        /// <summary>
        /// The URL that points to the zip package for the AppBundle.
        /// </summary>
        /// <value>The URL that points to the zip package for the AppBundle.</value>
        [DataMember(Name="package", EmitDefaultValue=false)]
        public string Package { get; set; }

        /// <summary>
        /// The product version of the Engine (the version of the binary that will be uploaded).
        /// </summary>
        /// <value>The product version of the Engine (the version of the binary that will be uploaded).</value>
        [DataMember(Name="productVersion", EmitDefaultValue=false)]
        public string ProductVersion { get; set; }

        /// <summary>
        /// Human readable description of the object.
        /// </summary>
        /// <value>Human readable description of the object.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int Version { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

}
