﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FloatingGlucose.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://...")]
        public string DataPathLocation {
            get {
                return ((string)(this["DataPathLocation"]));
            }
            set {
                this["DataPathLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableExceptionLoggingToStderr {
            get {
                return ((bool)(this["EnableExceptionLoggingToStderr"]));
            }
            set {
                this["EnableExceptionLoggingToStderr"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int RefreshIntervalInSeconds {
            get {
                return ((int)(this["RefreshIntervalInSeconds"]));
            }
            set {
                this["RefreshIntervalInSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public float GuiScalingRatio {
            get {
                return ((float)(this["GuiScalingRatio"]));
            }
            set {
                this["GuiScalingRatio"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableAlarms {
            get {
                return ((bool)(this["EnableAlarms"]));
            }
            set {
                this["EnableAlarms"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("13")]
        public decimal AlarmUrgentHigh {
            get {
                return ((decimal)(this["AlarmUrgentHigh"]));
            }
            set {
                this["AlarmUrgentHigh"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("11")]
        public decimal AlarmHigh {
            get {
                return ((decimal)(this["AlarmHigh"]));
            }
            set {
                this["AlarmHigh"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4.5")]
        public decimal AlarmLow {
            get {
                return ((decimal)(this["AlarmLow"]));
            }
            set {
                this["AlarmLow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3.8")]
        public decimal AlarmUrgentLow {
            get {
                return ((decimal)(this["AlarmUrgentLow"]));
            }
            set {
                this["AlarmUrgentLow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableRawGlucoseDisplay {
            get {
                return ((bool)(this["EnableRawGlucoseDisplay"]));
            }
            set {
                this["EnableRawGlucoseDisplay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mmol")]
        public string GlucoseUnits {
            get {
                return ((string)(this["GlucoseUnits"]));
            }
            set {
                this["GlucoseUnits"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15")]
        public int AlarmStaleDataWarning {
            get {
                return ((int)(this["AlarmStaleDataWarning"]));
            }
            set {
                this["AlarmStaleDataWarning"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public int AlarmStaleDataUrgent {
            get {
                return ((int)(this["AlarmStaleDataUrgent"]));
            }
            set {
                this["AlarmStaleDataUrgent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableSoundAlarms {
            get {
                return ((bool)(this["EnableSoundAlarms"]));
            }
            set {
                this["EnableSoundAlarms"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DisableSoundAlarmsOnWorkstationLock {
            get {
                return ((bool)(this["DisableSoundAlarmsOnWorkstationLock"]));
            }
            set {
                this["DisableSoundAlarmsOnWorkstationLock"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("85")]
        public int GuiOpacity {
            get {
                return ((int)(this["GuiOpacity"]));
            }
            set {
                this["GuiOpacity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FloatingGlucose.Classes.DataSources.Plugins.NightscoutPebbleEndpoint")]
        public string DataSourceFullName {
            get {
                return ((string)(this["DataSourceFullName"]));
            }
            set {
                this["DataSourceFullName"] = value;
            }
        }
    }
}
