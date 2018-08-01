﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiarioProducao.Classes.TurnoTipo {
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
    internal class Sql {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Sql() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DiarioProducao.Classes.TurnoTipo.Sql", typeof(Sql).Assembly);
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
        ///   Looks up a localized string similar to DELETE
        ///  FROM OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_turno_tipo.num_serie_lmtrntp
        ///        FROM  lor_man_turno_tipo
        ///        WHERE lor_man_turno_tipo.num_serie_lmtrntp = {1}
        ///    &apos;
        ///  ).
        /// </summary>
        internal static string DeleteRecord {
            get {
                return ResourceManager.GetString("DeleteRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  tabela.existe
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  DISTINCT 1 AS existe
        ///        FROM  lor_man_turno_tipo
        ///        WHERE lor_man_turno_tipo.cod_turno_tipo = &quot;{1}&quot;
        ///    &apos;
        ///  ) AS tabela.
        /// </summary>
        internal static string ExisteAk {
            get {
                return ResourceManager.GetString("ExisteAk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  tabela.existe
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  DISTINCT 1 AS existe
        ///        FROM  lor_man_turno
        ///        WHERE lor_man_turno.num_serie_lmtrntp = {1}
        ///    &apos;
        ///  ) AS tabela.
        /// </summary>
        internal static string ExisteDependencias {
            get {
                return ResourceManager.GetString("ExisteDependencias", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  tabela.existe
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  DISTINCT 1 AS existe
        ///        FROM  lor_man_turno_tipo
        ///        WHERE lor_man_turno_tipo.num_serie_lmtrntp = {1}
        ///    &apos;
        ///  ) AS tabela.
        /// </summary>
        internal static string ExistePk {
            get {
                return ResourceManager.GetString("ExistePk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT
        ///  INTO OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_turno_tipo.cod_turno_tipo
        ///           ,  lor_man_turno_tipo.den_turno_tipo
        ///        FROM  lor_man_turno_tipo
        ///    &apos;
        ///  )
        ///  VALUES
        ///  (
        ///    UPPER ( &quot;{1}&quot; )
        ///  , UPPER ( &quot;{2}&quot; )
        ///  ).
        /// </summary>
        internal static string InsertRecord {
            get {
                return ResourceManager.GetString("InsertRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  tabela.serie_turno_tipo
        ///     ,  tabela.codigo_turno_tipo
        ///     ,  tabela.descricao_turno_tipo
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_turno_tipo.num_serie_lmtrntp       AS serie_turno_tipo
        ///           ,  TRIM ( lor_man_turno_tipo.cod_turno_tipo ) AS codigo_turno_tipo
        ///           ,  TRIM ( lor_man_turno_tipo.den_turno_tipo ) AS descricao_turno_tipo
        ///        FROM  lor_man_turno_tipo
        ///        WHERE lor_man_turno_tipo.cod_turno_tipo          = &quot;{1}&quot;
        ///  &apos;
        ///  ) AS tabela.
        /// </summary>
        internal static string QueryRecordAk {
            get {
                return ResourceManager.GetString("QueryRecordAk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  tabela.serie_turno_tipo
        ///     ,  tabela.codigo_turno_tipo
        ///     ,  tabela.descricao_turno_tipo
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_turno_tipo.num_serie_lmtrntp       AS serie_turno_tipo
        ///           ,  TRIM ( lor_man_turno_tipo.cod_turno_tipo ) AS codigo_turno_tipo
        ///           ,  TRIM ( lor_man_turno_tipo.den_turno_tipo ) AS descricao_turno_tipo
        ///        FROM  lor_man_turno_tipo
        ///        WHERE 1=1
        ///        {0}
        ///        ORDER BY lor_man_turno_tipo.cod_turno_tipo
        ///    &apos;
        ///  )  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QueryRecordAll {
            get {
                return ResourceManager.GetString("QueryRecordAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  tabela.serie_turno_tipo
        ///     ,  tabela.codigo_turno_tipo
        ///     ,  tabela.descricao_turno_tipo
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_turno_tipo.num_serie_lmtrntp       AS serie_turno_tipo
        ///           ,  TRIM ( lor_man_turno_tipo.cod_turno_tipo ) AS codigo_turno_tipo
        ///           ,  TRIM ( lor_man_turno_tipo.den_turno_tipo ) AS descricao_turno_tipo
        ///        FROM  lor_man_turno_tipo
        ///        WHERE lor_man_turno_tipo.num_serie_lmtrntp = {1}
        ///        ORDER BY lor_man_turno_tipo.c [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QueryRecordPk {
            get {
                return ResourceManager.GetString("QueryRecordPk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tipo de Turno.
        /// </summary>
        internal static string TableDescription {
            get {
                return ResourceManager.GetString("TableDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to lor_man_turno_tipo.
        /// </summary>
        internal static string TableName {
            get {
                return ResourceManager.GetString("TableName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string UpdateRecord {
            get {
                return ResourceManager.GetString("UpdateRecord", resourceCulture);
            }
        }
    }
}