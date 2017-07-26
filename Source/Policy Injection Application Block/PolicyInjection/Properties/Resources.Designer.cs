﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.PolicyInjection.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.PolicyInjection.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Base counter used to calculate average call time..
        /// </summary>
        internal static string AverageCallDurationBaseCounterHelp {
            get {
                return ResourceManager.GetString("AverageCallDurationBaseCounterHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tracks the average length of time for a monitored method to complete..
        /// </summary>
        internal static string AverageCallDurationCounterHelp {
            get {
                return ResourceManager.GetString("AverageCallDurationCounterHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tracks calls / second to the monitored methods..
        /// </summary>
        internal static string CallsPerSecondCounterHelp {
            get {
                return ResourceManager.GetString("CallsPerSecondCounterHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration information for Policy &apos;{0}&apos; can not be found in the configuration source.
        /// </summary>
        internal static string CouldNotFindPolicyInConfiguration {
            get {
                return ResourceManager.GetString("CouldNotFindPolicyInConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type must be a subclass of System.Attribute..
        /// </summary>
        internal static string ExceptionAttributeNoSubclassOfAttribute {
            get {
                return ResourceManager.GetString("ExceptionAttributeNoSubclassOfAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PolicyInjector is already set..
        /// </summary>
        internal static string ExceptionPolicyInjectorAlreadySet {
            get {
                return ResourceManager.GetString("ExceptionPolicyInjectorAlreadySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PolicyInjector has not been set for the PolicyInjection static class. Set it invoking the PolicyInjection.SetPolicyInjector method...
        /// </summary>
        internal static string ExceptionPolicyInjectorNotSet {
            get {
                return ResourceManager.GetString("ExceptionPolicyInjectorNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tracks the number of exceptions / second thrown by the monitored methods..
        /// </summary>
        internal static string ExceptionsPerSecondCounterHelp {
            get {
                return ResourceManager.GetString("ExceptionsPerSecondCounterHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} is not interceptable..
        /// </summary>
        internal static string InterceptionNotSupported {
            get {
                return ResourceManager.GetString("InterceptionNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must specify the /category=&lt;name&gt;(;&lt;name&gt;) switch on the command line..
        /// </summary>
        internal static string NoCategoryErrorMessage {
            get {
                return ResourceManager.GetString("NoCategoryErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The policy {0} does not have any handlers..
        /// </summary>
        internal static string NoHandlersInPolicy {
            get {
                return ResourceManager.GetString("NoHandlersInPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Records the total number of calls to the monitored methods..
        /// </summary>
        internal static string NumberOfCallsCounterHelp {
            get {
                return ResourceManager.GetString("NumberOfCallsCounterHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Records the total number of exceptions thrown by the monitored methods..
        /// </summary>
        internal static string NumberOfExceptionsCounterHelp {
            get {
                return ResourceManager.GetString("NumberOfExceptionsCounterHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performance counters that are updated by the Policy Injection Application Block..
        /// </summary>
        internal static string PerformanceCounterCategoryHelp {
            get {
                return ResourceManager.GetString("PerformanceCounterCategoryHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This rule is not intended to be used directly. Use the rules from the Microsoft.Practices.Unity.Interception assembly instead..
        /// </summary>
        internal static string PlaceholderRule {
            get {
                return ResourceManager.GetString("PlaceholderRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration section for Policy Injection cannot be found in the configuration source..
        /// </summary>
        internal static string PolicyInjectionSectionNotFound {
            get {
                return ResourceManager.GetString("PolicyInjectionSectionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Injection Policies applied to object..
        /// </summary>
        internal static string TracePoliciesApplied {
            get {
                return ResourceManager.GetString("TracePoliciesApplied", resourceCulture);
            }
        }
    }
}
