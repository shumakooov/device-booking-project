﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Visus.LdapAuthentication.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Visus.LdapAuthentication.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to An entry with a value of &quot;{1}&quot; for &quot;{0}&quot; does not exist in the directory..
        /// </summary>
        public static string ErrorEntryNotFound {
            get {
                return ResourceManager.GetString("ErrorEntryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given byte sequence &quot;{0}&quot; does not represent a valid security identifier..
        /// </summary>
        public static string ErrorInvalidSid {
            get {
                return ResourceManager.GetString("ErrorInvalidSid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Paging of LDAP search results must start at 0..
        /// </summary>
        public static string ErrorLdapPage {
            get {
                return ResourceManager.GetString("ErrorLdapPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The size of a page of LDAP search results must be at least 1..
        /// </summary>
        public static string ErrorLdapPageSize {
            get {
                return ResourceManager.GetString("ErrorLdapPageSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given property &quot;{0}&quot; was not found..
        /// </summary>
        public static string ErrorPropertyNotFound {
            get {
                return ResourceManager.GetString("ErrorPropertyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given property &quot;{0}&quot; has no LDAP attribute mapped for the current schema &quot;{1}&quot;..
        /// </summary>
        public static string ErrorPropertyNotMapped {
            get {
                return ResourceManager.GetString("ErrorPropertyNotMapped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login succeeded, but user information for &quot;{0}&quot; could not be found..
        /// </summary>
        public static string ErrorUserNotFound {
            get {
                return ResourceManager.GetString("ErrorUserNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performing LDAP bind as user &quot;{0}&quot;..
        /// </summary>
        public static string InfoBindingAsUser {
            get {
                return ResourceManager.GetString("InfoBindingAsUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authenticated successfully as user &quot;{0}&quot;..
        /// </summary>
        public static string InfoBoundAsUser {
            get {
                return ResourceManager.GetString("InfoBoundAsUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connecting to LDAP server {0}:{1}..
        /// </summary>
        public static string InfoConnectingLdap {
            get {
                return ResourceManager.GetString("InfoConnectingLdap", resourceCulture);
            }
        }
    }
}
