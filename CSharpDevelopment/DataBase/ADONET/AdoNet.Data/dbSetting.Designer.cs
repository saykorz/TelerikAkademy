﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdoNet.Data {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class dbSetting : global::System.Configuration.ApplicationSettingsBase {
        
        private static dbSetting defaultInstance = ((dbSetting)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new dbSetting())));
        
        public static dbSetting Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=localhost;Initial Catalog=NORTHWND;Persist Security Info=True;User ID" +
            "=nw;Password=123456; MultipleActiveResultSets=True")]
        public string SqlConnectionString {
            get {
                return ((string)(this["SqlConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Server=localhost;Database=bookstore;Uid=books;Pwd=test1234;")]
        public string MySqlConnectionString {
            get {
                return ((string)(this["MySqlConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=D:\\Projects\\VisualStudio2012\\Telerik\\TelerikAkademy\\CSharpDevelopment" +
            "\\DataBase\\ADONET\\ADONET\\ADONET.WebApp\\books.db;Version=3;")]
        public string SQLiteConnectionString {
            get {
                return ((string)(this["SQLiteConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mongodb://127.0.0.1/BookStore")]
        public string MONGOLAB_URI {
            get {
                return ((string)(this["MONGOLAB_URI"]));
            }
        }
    }
}
