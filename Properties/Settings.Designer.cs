﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace nilnul.dev.bak.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool upgradeRequired {
            get {
                return ((bool)(this["upgradeRequired"]));
            }
            set {
                this["upgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int semaphore {
            get {
                return ((int)(this["semaphore"]));
            }
            set {
                this["semaphore"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection shieldsBaked {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["shieldsBaked"]));
            }
            set {
                this["shieldsBaked"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection modulesBaked {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["modulesBaked"]));
            }
            set {
                this["modulesBaked"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tmp")]
        public string branchTmp {
            get {
                return ((string)(this["branchTmp"]));
            }
            set {
                this["branchTmp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("bak")]
        public string branchBak {
            get {
                return ((string)(this["branchBak"]));
            }
            set {
                this["branchBak"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection shields2Bak {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["shields2Bak"]));
            }
            set {
                this["shields2Bak"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7")]
        public uint pushErrsAsWarningIfSuccessesGe {
            get {
                return ((uint)(this["pushErrsAsWarningIfSuccessesGe"]));
            }
            set {
                this["pushErrsAsWarningIfSuccessesGe"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int warnIfOverG {
            get {
                return ((int)(this["warnIfOverG"]));
            }
            set {
                this["warnIfOverG"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("bak_clients")]
        public string git_module_remote_bak_clients {
            get {
                return ((string)(this["git_module_remote_bak_clients"]));
            }
            set {
                this["git_module_remote_bak_clients"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool update_umbrella_remote_always {
            get {
                return ((bool)(this["update_umbrella_remote_always"]));
            }
            set {
                this["update_umbrella_remote_always"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool remove_azure_remote_with_invalid_reponame {
            get {
                return ((bool)(this["remove_azure_remote_with_invalid_reponame"]));
            }
            set {
                this["remove_azure_remote_with_invalid_reponame"] = value;
            }
        }
    }
}
