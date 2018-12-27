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
    /// Signatures for various attributes in WorkItem.
    /// </summary>
    [DataContract]
    public partial class WorkItemSignatures 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItemSignatures" /> class.
        /// </summary>
        /// <param name="ActivityId">Digital signature of the ActivityId. The client must supply this when using a 3-legged oauth token for submitting a WorkItem..</param>
        /// <param name="BaseUrls">Digitally signed base urls that are allowed in the WorkItem. The client may supply these when using a 3-legged oauth token for submitting a WorkItem..</param>
        public WorkItemSignatures(string ActivityId = default(string), List<SignedUrl> BaseUrls = default(List<SignedUrl>))
        {
            this.ActivityId = ActivityId;
            this.BaseUrls = BaseUrls;
        }
        
        /// <summary>
        /// Digital signature of the ActivityId. The client must supply this when using a 3-legged oauth token for submitting a WorkItem.
        /// </summary>
        /// <value>Digital signature of the ActivityId. The client must supply this when using a 3-legged oauth token for submitting a WorkItem.</value>
        [DataMember(Name="activityId", EmitDefaultValue=false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Digitally signed base urls that are allowed in the WorkItem. The client may supply these when using a 3-legged oauth token for submitting a WorkItem.
        /// </summary>
        /// <value>Digitally signed base urls that are allowed in the WorkItem. The client may supply these when using a 3-legged oauth token for submitting a WorkItem.</value>
        [DataMember(Name="baseUrls", EmitDefaultValue=false)]
        public List<SignedUrl> BaseUrls { get; set; }

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
