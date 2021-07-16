﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DW.Billing.Common.Resources {
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
    public class Queries {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Queries() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DW.Billing.Common.Resources.Queries", typeof(Queries).Assembly);
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
        ///   Looks up a localized string similar to select b.Nombres from 
        ///(select ( cli.Nombres+&apos; &apos;+cli.Apellidos)Nombres,
        ///        (year(CURRENT_TIMESTAMP) - year(cli.Fecha_Nacimiento)) edad,
        ///		fact.Fecha_Facturacion
        /// from Tbl_Factura fact,
        ///      Tbl_Cliente cli
        ///where fact.Codigo_cliente=cli. Documento) As B
        ///where b.edad&lt;=35
        ///And Fecha_Facturacion BETWEEN  @initial AND @final.
        /// </summary>
        public static string CustomersPaymentsTo35Years {
            get {
                return ResourceManager.GetString("CustomersPaymentsTo35Years", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select id_producto, descripcion, Precio,Stock,Fecha_Ingreso
        ///from Tbl_Producto.
        /// </summary>
        public static string GetAll {
            get {
                return ResourceManager.GetString("GetAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select descripcion, Precio 
        ///from Tbl_Producto.
        /// </summary>
        public static string PricesByProduct {
            get {
                return ResourceManager.GetString("PricesByProduct", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select descripcion 
        ///from Tbl_Producto
        ///where stock&lt;=5.
        /// </summary>
        public static string ProductByStockMinimum {
            get {
                return ResourceManager.GetString("ProductByStockMinimum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select pro.descripcion , sum(det.Total) total
        ///From Tbl_Factura fact
        ///    JOIN Tbl_Detalle_Factura det ON fact.Num_Factura=det.Cod_Factura
        ///	JOIN Tbl_Producto pro ON  pro.Id_Producto=det.Codigo_producto
        ///where Fecha_Facturacion BETWEEN @initial AND @final
        ///Group by  det.Total,pro.descripcion.
        /// </summary>
        public static string TotalProductByYear {
            get {
                return ResourceManager.GetString("TotalProductByYear", resourceCulture);
            }
        }
    }
}