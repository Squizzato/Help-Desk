﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelpDesk
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DatabaseHelpDesk")]
	public partial class DataClassesStatusDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_Status(tbl_Status instance);
    partial void Updatetbl_Status(tbl_Status instance);
    partial void Deletetbl_Status(tbl_Status instance);
    #endregion
		
		public DataClassesStatusDataContext() : 
				base(global::HelpDesk.Properties.Settings.Default.DatabaseHelpDeskConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesStatusDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesStatusDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesStatusDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesStatusDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_Status> tbl_Status
		{
			get
			{
				return this.GetTable<tbl_Status>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_Status")]
	public partial class tbl_Status : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Status;
		
		private string _Desc_Status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_StatusChanging(int value);
    partial void OnId_StatusChanged();
    partial void OnDesc_StatusChanging(string value);
    partial void OnDesc_StatusChanged();
    #endregion
		
		public tbl_Status()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Status", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Status
		{
			get
			{
				return this._Id_Status;
			}
			set
			{
				if ((this._Id_Status != value))
				{
					this.OnId_StatusChanging(value);
					this.SendPropertyChanging();
					this._Id_Status = value;
					this.SendPropertyChanged("Id_Status");
					this.OnId_StatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Desc_Status", DbType="VarChar(50)")]
		public string Desc_Status
		{
			get
			{
				return this._Desc_Status;
			}
			set
			{
				if ((this._Desc_Status != value))
				{
					this.OnDesc_StatusChanging(value);
					this.SendPropertyChanging();
					this._Desc_Status = value;
					this.SendPropertyChanged("Desc_Status");
					this.OnDesc_StatusChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
