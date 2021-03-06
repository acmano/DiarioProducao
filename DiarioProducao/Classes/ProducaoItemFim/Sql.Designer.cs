﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiarioProducao.Classes.ProducaoItemFim {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DiarioProducao.Classes.ProducaoItemFim.Sql", typeof(Sql).Assembly);
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
        ///      SELECT  lor_man_producao_item_fim.num_serie_lmpifim
        ///        FROM  lor_man_producao_item_fim
        ///        WHERE lor_man_producao_item_fim.num_serie_lmpifim = {1}
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
        ///        FROM  lor_man_producao_item_fim
        ///        WHERE lor_man_producao_item_fim.num_serie_lmpi = {1}
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
        ///        FROM  lor_man_producao_item_fim
        ///        WHERE lor_man_producao_item_fim.num_serie_lmpifim = {1}
        ///        AND   1 = 0
        ///  &apos;
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
        ///        FROM  lor_man_producao_item_fim
        ///        WHERE lor_man_producao_item_fim.num_serie_lmpifim = {1}
        ///  &apos;
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
        ///      SELECT  lor_man_producao_item_fim.num_serie_lmpi
        ///           ,  lor_man_producao_item_fim.hor_fim
        ///           ,  lor_man_producao_item_fim.qtd_funcionarios
        ///        FROM  lor_man_producao_item_fim
        ///    &apos;
        ///  )
        ///  VALUES
        ///  (
        ///    {1}
        ///  , &quot;{2}&quot;
        ///  , {3}
        ///  ).
        /// </summary>
        internal static string InsertRecord {
            get {
                return ResourceManager.GetString("InsertRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  tabela.serie_producao_item_fim
        ///     ,  tabela.serie_producao_item
        ///     ,  tabela.hora_fim
        ///     ,  tabela.quantidade_funcionarios
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_producao_item_fim.num_serie_lmpifim    AS serie_producao_item_fim
        ///           ,  lor_man_producao_item_fim.num_serie_lmpi       AS serie_producao_item
        ///           ,  lor_man_producao_item_fim.hor_fim::CHAR(5)     AS hora_fim
        ///           ,  lor_man_producao_item_fim.qtd_funcionarios     AS quantidade_funciona [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QueryRecordAk {
            get {
                return ResourceManager.GetString("QueryRecordAk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  tabela.serie_producao_item_fim
        ///     ,  tabela.serie_producao_item
        ///     ,  tabela.hora_fim
        ///     ,  tabela.quantidade_funcionarios
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_producao_item_fim.num_serie_lmpifim    AS serie_producao_item_fim
        ///           ,  lor_man_producao_item_fim.num_serie_lmpi       AS serie_producao_item
        ///           ,  lor_man_producao_item_fim.hor_fim::CHAR(5)     AS hora_fim
        ///           ,  lor_man_producao_item_fim.qtd_funcionarios     AS quantidade_funciona [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QueryRecordAll {
            get {
                return ResourceManager.GetString("QueryRecordAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  tabela.serie_producao_item_fim
        ///     ,  tabela.serie_producao_item
        ///     ,  tabela.hora_fim
        ///     ,  tabela.quantidade_funcionarios
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_producao_item_fim.num_serie_lmpifim    AS serie_producao_item_fim
        ///           ,  lor_man_producao_item_fim.num_serie_lmpi       AS serie_producao_item
        ///           ,  lor_man_producao_item_fim.hor_fim::CHAR(5)     AS hora_fim
        ///           ,  lor_man_producao_item_fim.qtd_funcionarios     AS quantidade_funciona [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QueryRecordPk {
            get {
                return ResourceManager.GetString("QueryRecordPk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Término da Produção do item.
        /// </summary>
        internal static string TableDescription {
            get {
                return ResourceManager.GetString("TableDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to lor_man_producao_item_fim.
        /// </summary>
        internal static string TableName {
            get {
                return ResourceManager.GetString("TableName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_producao_item_fim.num_serie_lmpi     AS serie_producao_item
        ///           ,  lor_man_producao_item_fim.hor_fim            AS hora_fim
        ///           ,  lor_man_producao_item_fim.qtd_funcionarios   AS quantidade_funcionarios
        ///        FROM  lor_man_producao_item_fim
        ///        WHERE lor_man_producao_item_fim.num_serie_lmpifim = {1}
        ///    &apos;
        ///  ) 
        ///  SET  serie_producao_item = {2}
        ///    ,  hora_fim = &apos;{3}&apos;
        ///    ,  quantidade_funcionarios = {4}.
        /// </summary>
        internal static string UpdateRecord {
            get {
                return ResourceManager.GetString("UpdateRecord", resourceCulture);
            }
        }
    }
}
