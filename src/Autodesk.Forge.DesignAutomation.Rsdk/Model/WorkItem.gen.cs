/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * Design Automation
 *
 * Generated by [Forge Swagger Codegen](https://git.autodesk.com/forge-ozone/forge-rsdk-codegen)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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

namespace Autodesk.Forge.DesignAutomation.Rsdk.Model
{
    /// <summary>
    /// A WorkItem is a specification of the processing job for an Activity, and it is submitted to and executed by an Engine. Note that a WorkItem cannot be modified after it has been created. ( request only ).
    /// </summary>
    [DataContract]
    public partial class WorkItem 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkItem" /> class.
        /// </summary>
        public WorkItem()
        {
        }
        
        /// <summary>
        /// Gets Id.
        /// </summary>
        /// <value>Gets Id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Reference to the Activity that this WorkItem will invoke.  Examples: &#x60;MyPlot+Prod&#x60; (an Activity created by the caller) or  &#x60;Autodesk.PlotToPdf&#x60; (an Activity created by someone else and shared with this caller).
        /// </summary>
        /// <value>Reference to the Activity that this WorkItem will invoke.  Examples: &#x60;MyPlot+Prod&#x60; (an Activity created by the caller) or  &#x60;Autodesk.PlotToPdf&#x60; (an Activity created by someone else and shared with this caller).</value>
        [DataMember(Name="activityId", EmitDefaultValue=false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Arguments of the WorkItem.
        /// </summary>
        /// <value>Arguments of the WorkItem.</value>
        [DataMember(Name="arguments", EmitDefaultValue=false)]
        public Dictionary<string, IArgument> Arguments { get; set; }

        /// <summary>
        /// Signatures for various WorkItem attributes.
        /// </summary>
        /// <value>Signatures for various WorkItem attributes.</value>
        [DataMember(Name="signatures", EmitDefaultValue=false)]
        public WorkItemSignatures Signatures { get; set; }

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
