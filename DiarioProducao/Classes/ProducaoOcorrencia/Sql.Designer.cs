﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiarioProducao.Classes.ProducaoOcorrencia {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DiarioProducao.Classes.ProducaoOcorrencia.Sql", typeof(Sql).Assembly);
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
        ///      SELECT  lor_man_producao_ocorrencia.num_serie_lmpoco
        ///        FROM  lor_man_producao_ocorrencia
        ///        WHERE lor_man_producao_ocorrencia.num_serie_lmpoco = {1}
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
        ///        FROM  lor_man_producao_ocorrencia
        ///        WHERE lor_man_producao_ocorrencia.num_serie_lmp   = {1}
        ///        AND   lor_man_producao_ocorrencia.dat_ocorrencia  = &quot;{2}&quot;
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
        ///        FROM  lor_man_producao_ocorrencia
        ///        WHERE lor_man_producao_ocorrencia.num_serie_lmpoco = {1}
        ///        AND   1 = 0
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
        ///        FROM  lor_man_producao_ocorrencia
        ///        WHERE lor_man_producao_ocorrencia.num_serie_lmpoco = {1}
        ///    &apos;
        ///  ) AS tabela.
        /// </summary>
        internal static string ExistePk {
            get {
                return ResourceManager.GetString("ExistePk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AND lor_man_producao_ocorrencia.num_serie_lmp = {0}.
        /// </summary>
        internal static string FiltroProducao {
            get {
                return ResourceManager.GetString("FiltroProducao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT
        ///  INTO OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_producao_ocorrencia.num_serie_lmp
        ///           ,  lor_man_producao_ocorrencia.num_serie_lmoco
        ///           ,  lor_man_producao_ocorrencia.num_serie_lmf
        ///           ,  lor_man_producao_ocorrencia.dat_observacao
        ///        FROM  lor_man_producao_ocorrencia
        ///    &apos;
        ///  )
        ///  VALUES
        ///  (
        ///    {1}
        ///  , {2}
        ///  , {3}
        ///  , &apos;{4}&apos;
        ///  ).
        /// </summary>
        internal static string InsertRecord {
            get {
                return ResourceManager.GetString("InsertRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  tabela.serie_producao_ocorrencia
        ///     ,  tabela.serie_producao
        ///     ,  tabela.serie_ocorrencia
        ///     ,  tabela.serie_funcionario
        ///     ,  tabela.codigo_ocorrencia
        ///     ,  tabela.descricao_ocorrencia
        ///     ,  tabela.matricula_funcionario
        ///     ,  tabela.nome_funcionario
        ///     ,  tabela.data_ocorrencia
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_producao_ocorrencia.num_serie_lmpoco          AS serie_producao_ocorrencia
        ///           ,  lor_man_producao_ocorrencia.num_serie_lmp      [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QueryRecordAk {
            get {
                return ResourceManager.GetString("QueryRecordAk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  tabela.serie_producao_ocorrencia
        ///     ,  tabela.serie_producao
        ///     ,  tabela.serie_ocorrencia
        ///     ,  tabela.serie_funcionario
        ///     ,  tabela.codigo_ocorrencia
        ///     ,  tabela.descricao_ocorrencia
        ///     ,  tabela.matricula_funcionario
        ///     ,  tabela.nome_funcionario
        ///     ,  tabela.data_ocorrencia
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_producao_ocorrencia.num_serie_lmpoco          AS serie_producao_ocorrencia
        ///           ,  lor_man_producao_ocorrencia.num_serie_lmp      [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QueryRecordAll {
            get {
                return ResourceManager.GetString("QueryRecordAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT  tabela.serie_producao_ocorrencia
        ///     ,  tabela.serie_producao
        ///     ,  tabela.serie_ocorrencia
        ///     ,  tabela.serie_funcionario
        ///     ,  tabela.codigo_ocorrencia
        ///     ,  tabela.descricao_ocorrencia
        ///     ,  tabela.matricula_funcionario
        ///     ,  tabela.nome_funcionario
        ///     ,  tabela.data_ocorrencia
        ///  FROM  OPENQUERY
        ///  (
        ///    {0}
        ///  , &apos;
        ///      SELECT  lor_man_producao_ocorrencia.num_serie_lmpoco          AS serie_producao_ocorrencia
        ///           ,  lor_man_producao_ocorrencia.num_serie_lmp      [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QueryRecordPk {
            get {
                return ResourceManager.GetString("QueryRecordPk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ocorrências da Produção.
        /// </summary>
        internal static string TableDescription {
            get {
                return ResourceManager.GetString("TableDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to lor_man_producao_ocorrencia.
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
        ///      SELECT  lor_man_producao_ocorrencia.num_serie_lmp   AS serie_producao
        ///           ,  lor_man_producao_ocorrencia.num_serie_lmoco AS serie_ocorrencia
        ///           ,  lor_man_producao_ocorrencia.num_serie_lmf   AS serie_funcionario
        ///           ,  lor_man_producao_ocorrencia.dat_ocorrencia  AS data_ocorrencia
        ///        FROM  lor_man_producao_ocorrencia
        ///        WHERE lor_man_producao_ocorrencia.num_serie_lmpoco = {1}
        ///    &apos;
        ///  ) 
        ///  SET  serie_producao     = {2}
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UpdateRecord {
            get {
                return ResourceManager.GetString("UpdateRecord", resourceCulture);
            }
        }
    }
}
