﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fs2ff {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
    internal sealed partial class Preferences : global::System.Configuration.ApplicationSettingsBase {
        
        private static Preferences defaultInstance = ((Preferences)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Preferences())));
        
        public static Preferences Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ip_address {
            get {
                return ((string)(this["ip_address"]));
            }
            set {
                this["ip_address"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool att_enabled {
            get {
                return ((bool)(this["att_enabled"]));
            }
            set {
                this["att_enabled"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool gdl90_enabled
        {
            get
            {
                return ((bool)(this["gdl90_enabled"]));
            }
            set
            {
                this["gdl90_enabled"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool stratus_enabled
        {
            get
            {
                return ((bool)(this["stratus_enabled"]));
            }
            set
            {
                this["stratus_enabled"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool stratux_enabled
        {
            get
            {
                return ((bool)(this["stratux_enabled"]));
            }
            set
            {
                this["stratux_enabled"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool pos_enabled {
            get {
                return ((bool)(this["pos_enabled"]));
            }
            set {
                this["pos_enabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool tfk_enabled {
            get {
                return ((bool)(this["tfk_enabled"]));
            }
            set {
                this["tfk_enabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ip_detection_enabled {
            get {
                return ((bool)(this["ip_detection_enabled"]));
            }
            set {
                this["ip_detection_enabled"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool auto_connect_enabled {
            get {
                return ((bool)(this["auto_connect_enabled"]));
            }
            set {
                this["auto_connect_enabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("20")]
        public uint att_freq {
            get {
                return ((uint)(this["att_freq"]));
            }
            set {
                this["att_freq"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public uint ip_hint_time {
            get {
                return ((uint)(this["ip_hint_time"]));
            }
            set {
                this["ip_hint_time"] = value;
            }
        }
    }
}
