﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcumenCodeExercise.Models {
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
    internal class DapperOrderSql {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DapperOrderSql() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AcumenCodeExercise.Models.DapperOrderSql", typeof(DapperOrderSql).Assembly);
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
        ///   Looks up a localized string similar to SELECT [O].[OrderID], [O].[OrderDate], [E].[LastName] + &apos; &apos; + [E].[FirstName] AS [Employee], [O].[ShipName] FROM [Orders] AS [O] 
        ///LEFT JOIN [Employees] AS [E] ON [O].[EmployeeID] = [E].[EmployeeID] 
        ///WHERE [O].[OrderID] = @OID;.
        /// </summary>
        internal static string GetOrder {
            get {
                return ResourceManager.GetString("GetOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [OD].[OrderID], [OD].[ProductID], [P].[ProductName], [OD].[Quantity], [OD].[UnitPrice] FROM [Order Details] AS [OD] 
        ///LEFT JOIN [Products] AS [P] ON [OD].[ProductID] = [P].[ProductID] 
        ///WHERE [OD].[OrderID] =  @OID;.
        /// </summary>
        internal static string GetOrderProductInfo {
            get {
                return ResourceManager.GetString("GetOrderProductInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [O].[OrderID], [O].[OrderDate], [E].[LastName] + &apos; &apos; + [E].[FirstName] AS [Employee], [O].[ShipName] FROM [Orders] AS [O] 
        ///LEFT JOIN [Employees] AS [E] ON [O].[EmployeeID] = [E].[EmployeeID] 
        ///WHERE [O].[ShipCountry]=@Country;.
        /// </summary>
        internal static string GetOrders {
            get {
                return ResourceManager.GetString("GetOrders", resourceCulture);
            }
        }
    }
}
