﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArchivePDF.csproj.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\AMSTORE-SVR-22\\cad\\Solid Works\\Amstore_Macros\\gauges.xml")]
        public string GaugePath {
            get {
                return ((string)(this["GaugePath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\AMSTORE-SVR-01\\details\\JPGs\\")]
        public string JPGPath {
            get {
                return ((string)(this["JPGPath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\AMSTORE-SVR-01\\details\\")]
        public string KPath {
            get {
                return ((string)(this["KPath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\AMSTORE-SVR-22\\cad\\PDF ARCHIVE\\")]
        public string GPath {
            get {
                return ((string)(this["GPath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\AMSTORE-SVR-02\\shared\\shared\\general\\Metals\\METAL MANUFACTURING\\")]
        public string MetalPath {
            get {
                return ((string)(this["MetalPath"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SaveFirst {
            get {
                return ((bool)(this["SaveFirst"]));
            }
            set {
                this["SaveFirst"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SilenceGaugeErrors {
            get {
                return ((bool)(this["SilenceGaugeErrors"]));
            }
            set {
                this["SilenceGaugeErrors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExportPDF {
            get {
                return ((bool)(this["ExportPDF"]));
            }
            set {
                this["ExportPDF"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExportEDrw {
            get {
                return ((bool)(this["ExportEDrw"]));
            }
            set {
                this["ExportEDrw"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExportImg {
            get {
                return ((bool)(this["ExportImg"]));
            }
            set {
                this["ExportImg"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dbo.GEN_DRAWINGS")]
        public string PDFTable {
            get {
                return ((string)(this["PDFTable"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FName")]
        public string basename {
            get {
                return ((string)(this["basename"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FPath")]
        public string fullpath {
            get {
                return ((string)(this["fullpath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DateCreated")]
        public string datecreated {
            get {
                return ((string)(this["datecreated"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("K:\\")]
        public string KMapped {
            get {
                return ((string)(this["KMapped"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool WriteToDb {
            get {
                return ((bool)(this["WriteToDb"]));
            }
            set {
                this["WriteToDb"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dbo.GEN_DRAWINGS_MTL")]
        public string metalTable {
            get {
                return ((string)(this["metalTable"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Server=AMSTORE-SQL-07;Database=ENGINEERING;Trusted_Connection=True;")]
        public string connectionString {
            get {
                return ((string)(this["connectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Optimize\\ArchivePDF.json")]
        public string localJSON {
            get {
                return ((string)(this["localJSON"]));
            }
            set {
                this["localJSON"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\AMSTORE-SVR-22\\cad\\Solid Works\\Amstore_Macros\\ArchivePDF.json")]
        public string defaultJSON {
            get {
                return ((string)(this["defaultJSON"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("G:\\PDF ARCHIVE\\")]
        public string GMapped {
            get {
                return ((string)(this["GMapped"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("S:\\shared\\general\\Metals\\METAL MANUFACTURING\\")]
        public string SMapped {
            get {
                return ((string)(this["SMapped"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>AMS</string>\r\n  <string>CUS</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection LayerHeads {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["LayerHeads"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>.1-5</string>
  <string>.6-10</string>
  <string>.11-15</string>
  <string>.16-20</string>
  <string>.21-25</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection LayerTails {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["LayerTails"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>\\AMSTORE-SVR-22\cad\Solid Works\AMSTORE_SHEET_FORMATS\zPostCard.slddrt</string>
  <string>\\AMSTORE-SVR-22\cad\Solid Works\\AMSTORE_SHEET_FORMATS\\zThm.slddrt</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ShtFmtPath {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ShtFmtPath"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\\\AMSTORE-SVR-02\\shared\\shared\\general\\KOHLS\\Ariba Label Images\\")]
        public string AribaPath {
            get {
                return ((string)(this["AribaPath"]));
            }
            set {
                this["AribaPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.005")]
        public double WeirdArbitraryFactor {
            get {
                return ((double)(this["WeirdArbitraryFactor"]));
            }
            set {
                this["WeirdArbitraryFactor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("^[0-9]{1,2}\\ ?GA\\.?")]
        public string GaugeRegex {
            get {
                return ((string)(this["GaugeRegex"]));
            }
            set {
                this["GaugeRegex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("K:\\TARGET\\PROFILE\\")]
        public string TargetProfilePath {
            get {
                return ((string)(this["TargetProfilePath"]));
            }
            set {
                this["TargetProfilePath"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("dbo.GEN_DRAWINGS_EDRW")]
        public string eDrawingTable {
            get {
                return ((string)(this["eDrawingTable"]));
            }
        }
    }
}
