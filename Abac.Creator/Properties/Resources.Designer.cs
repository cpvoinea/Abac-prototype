﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abac.Creator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Abac.Creator.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;firstName&quot;: &quot;John&quot;,
        ///  &quot;lastName&quot;: &quot;Smith&quot;,
        ///  &quot;isAlive&quot;: true,
        ///  &quot;age&quot;: 25,
        ///  &quot;address&quot;: {
        ///    &quot;streetAddress&quot;: &quot;21 2nd Street&quot;,
        ///    &quot;city&quot;: &quot;New York&quot;,
        ///    &quot;state&quot;: &quot;NY&quot;,
        ///    &quot;postalCode&quot;: &quot;10021-3100&quot;
        ///  },
        ///  &quot;phoneNumbers&quot;: [
        ///    {
        ///      &quot;type&quot;: &quot;home&quot;,
        ///      &quot;number&quot;: &quot;212 555-1234&quot;
        ///    },
        ///    {
        ///      &quot;type&quot;: &quot;office&quot;,
        ///      &quot;number&quot;: &quot;646 555-4567&quot;
        ///    },
        ///    {
        ///      &quot;type&quot;: &quot;mobile&quot;,
        ///      &quot;number&quot;: &quot;123 456-7890&quot;
        ///    }
        ///  ],
        ///  &quot;children&quot;: [],
        ///  &quot;spouse&quot;: null
        ///}.
        /// </summary>
        internal static string jsonSample {
            get {
                return ResourceManager.GetString("jsonSample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application.
        /// </summary>
        internal static string titleApplication {
            get {
                return ResourceManager.GetString("titleApplication", resourceCulture);
            }
        }
    }
}
