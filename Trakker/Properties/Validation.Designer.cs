﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trakker.Properties {
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
    public class Validation {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Validation() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Trakker.Properties.Validation", typeof(Validation).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not a valid email address..
        /// </summary>
        public static string Email {
            get {
                return ResourceManager.GetString("Email", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This field must be 8 to 100 characters long..
        /// </summary>
        public static string PasswordLength {
            get {
                return ResourceManager.GetString("PasswordLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passwords do not match..
        /// </summary>
        public static string PasswordsMustMatch {
            get {
                return ResourceManager.GetString("PasswordsMustMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This field is required..
        /// </summary>
        public static string Required {
            get {
                return ResourceManager.GetString("Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This field cannot be longer than 100 characters..
        /// </summary>
        public static string StringLength_100 {
            get {
                return ResourceManager.GetString("StringLength_100", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This field cannot be longer than 150 characters..
        /// </summary>
        public static string StringLength_150 {
            get {
                return ResourceManager.GetString("StringLength_150", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This field cannot be longer than 20 characters..
        /// </summary>
        public static string StringLength_20 {
            get {
                return ResourceManager.GetString("StringLength_20", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This field cannot be longer than 250 characters..
        /// </summary>
        public static string StringLength_250 {
            get {
                return ResourceManager.GetString("StringLength_250", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This field cannot be longer than 50 characters..
        /// </summary>
        public static string StringLength_50 {
            get {
                return ResourceManager.GetString("StringLength_50", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This field must be 3 or 6 characters in length..
        /// </summary>
        public static string StringLength_HexColor {
            get {
                return ResourceManager.GetString("StringLength_HexColor", resourceCulture);
            }
        }
    }
}
