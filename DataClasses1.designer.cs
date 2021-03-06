﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommonService
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DataSource")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTblBodyPart(TblBodyPart instance);
    partial void UpdateTblBodyPart(TblBodyPart instance);
    partial void DeleteTblBodyPart(TblBodyPart instance);
    partial void InserttblCategory(tblCategory instance);
    partial void UpdatetblCategory(tblCategory instance);
    partial void DeletetblCategory(tblCategory instance);
    partial void InsertTbl_UserReg(Tbl_UserReg instance);
    partial void UpdateTbl_UserReg(Tbl_UserReg instance);
    partial void DeleteTbl_UserReg(Tbl_UserReg instance);
    partial void Inserttblclientreg(tblclientreg instance);
    partial void Updatetblclientreg(tblclientreg instance);
    partial void Deletetblclientreg(tblclientreg instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DataSourceConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TblBodyPart> TblBodyParts
		{
			get
			{
				return this.GetTable<TblBodyPart>();
			}
		}
		
		public System.Data.Linq.Table<tblCategory> tblCategories
		{
			get
			{
				return this.GetTable<tblCategory>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_UserReg> Tbl_UserRegs
		{
			get
			{
				return this.GetTable<Tbl_UserReg>();
			}
		}
		
		public System.Data.Linq.Table<tblclientreg> tblclientregs
		{
			get
			{
				return this.GetTable<tblclientreg>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TblBodyPart")]
	public partial class TblBodyPart : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pkBPid;
		
		private string _BodyPart;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpkBPidChanging(int value);
    partial void OnpkBPidChanged();
    partial void OnBodyPartChanging(string value);
    partial void OnBodyPartChanged();
    #endregion
		
		public TblBodyPart()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pkBPid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pkBPid
		{
			get
			{
				return this._pkBPid;
			}
			set
			{
				if ((this._pkBPid != value))
				{
					this.OnpkBPidChanging(value);
					this.SendPropertyChanging();
					this._pkBPid = value;
					this.SendPropertyChanged("pkBPid");
					this.OnpkBPidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BodyPart", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string BodyPart
		{
			get
			{
				return this._BodyPart;
			}
			set
			{
				if ((this._BodyPart != value))
				{
					this.OnBodyPartChanging(value);
					this.SendPropertyChanging();
					this._BodyPart = value;
					this.SendPropertyChanged("BodyPart");
					this.OnBodyPartChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblCategory")]
	public partial class tblCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pkCat_Id;
		
		private string _Cat_name;
		
		private string _Cat_desc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpkCat_IdChanging(int value);
    partial void OnpkCat_IdChanged();
    partial void OnCat_nameChanging(string value);
    partial void OnCat_nameChanged();
    partial void OnCat_descChanging(string value);
    partial void OnCat_descChanged();
    #endregion
		
		public tblCategory()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pkCat_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pkCat_Id
		{
			get
			{
				return this._pkCat_Id;
			}
			set
			{
				if ((this._pkCat_Id != value))
				{
					this.OnpkCat_IdChanging(value);
					this.SendPropertyChanging();
					this._pkCat_Id = value;
					this.SendPropertyChanged("pkCat_Id");
					this.OnpkCat_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cat_name", DbType="VarChar(20)")]
		public string Cat_name
		{
			get
			{
				return this._Cat_name;
			}
			set
			{
				if ((this._Cat_name != value))
				{
					this.OnCat_nameChanging(value);
					this.SendPropertyChanging();
					this._Cat_name = value;
					this.SendPropertyChanged("Cat_name");
					this.OnCat_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cat_desc", DbType="VarChar(50)")]
		public string Cat_desc
		{
			get
			{
				return this._Cat_desc;
			}
			set
			{
				if ((this._Cat_desc != value))
				{
					this.OnCat_descChanging(value);
					this.SendPropertyChanging();
					this._Cat_desc = value;
					this.SendPropertyChanged("Cat_desc");
					this.OnCat_descChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_UserReg")]
	public partial class Tbl_UserReg : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pkuser_id;
		
		private string _first_Name;
		
		private string _last_Name;
		
		private string _userName;
		
		private string _pass_Word;
		
		private string _email_Id;
		
		private string _contact_No;
		
		private string _birth_Date;
		
		private string _Gender;
		
		private string _Education;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onpkuser_idChanging(int value);
    partial void Onpkuser_idChanged();
    partial void Onfirst_NameChanging(string value);
    partial void Onfirst_NameChanged();
    partial void Onlast_NameChanging(string value);
    partial void Onlast_NameChanged();
    partial void OnuserNameChanging(string value);
    partial void OnuserNameChanged();
    partial void Onpass_WordChanging(string value);
    partial void Onpass_WordChanged();
    partial void Onemail_IdChanging(string value);
    partial void Onemail_IdChanged();
    partial void Oncontact_NoChanging(string value);
    partial void Oncontact_NoChanged();
    partial void Onbirth_DateChanging(string value);
    partial void Onbirth_DateChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnEducationChanging(string value);
    partial void OnEducationChanged();
    #endregion
		
		public Tbl_UserReg()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pkuser_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pkuser_id
		{
			get
			{
				return this._pkuser_id;
			}
			set
			{
				if ((this._pkuser_id != value))
				{
					this.Onpkuser_idChanging(value);
					this.SendPropertyChanging();
					this._pkuser_id = value;
					this.SendPropertyChanged("pkuser_id");
					this.Onpkuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_Name", DbType="VarChar(50)")]
		public string first_Name
		{
			get
			{
				return this._first_Name;
			}
			set
			{
				if ((this._first_Name != value))
				{
					this.Onfirst_NameChanging(value);
					this.SendPropertyChanging();
					this._first_Name = value;
					this.SendPropertyChanged("first_Name");
					this.Onfirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_Name", DbType="VarChar(50)")]
		public string last_Name
		{
			get
			{
				return this._last_Name;
			}
			set
			{
				if ((this._last_Name != value))
				{
					this.Onlast_NameChanging(value);
					this.SendPropertyChanging();
					this._last_Name = value;
					this.SendPropertyChanged("last_Name");
					this.Onlast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userName", DbType="VarChar(30)")]
		public string userName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if ((this._userName != value))
				{
					this.OnuserNameChanging(value);
					this.SendPropertyChanging();
					this._userName = value;
					this.SendPropertyChanged("userName");
					this.OnuserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass_Word", DbType="VarChar(30)")]
		public string pass_Word
		{
			get
			{
				return this._pass_Word;
			}
			set
			{
				if ((this._pass_Word != value))
				{
					this.Onpass_WordChanging(value);
					this.SendPropertyChanging();
					this._pass_Word = value;
					this.SendPropertyChanged("pass_Word");
					this.Onpass_WordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email_Id", DbType="VarChar(50)")]
		public string email_Id
		{
			get
			{
				return this._email_Id;
			}
			set
			{
				if ((this._email_Id != value))
				{
					this.Onemail_IdChanging(value);
					this.SendPropertyChanging();
					this._email_Id = value;
					this.SendPropertyChanged("email_Id");
					this.Onemail_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contact_No", DbType="VarChar(15)")]
		public string contact_No
		{
			get
			{
				return this._contact_No;
			}
			set
			{
				if ((this._contact_No != value))
				{
					this.Oncontact_NoChanging(value);
					this.SendPropertyChanging();
					this._contact_No = value;
					this.SendPropertyChanged("contact_No");
					this.Oncontact_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birth_Date", DbType="VarChar(10)")]
		public string birth_Date
		{
			get
			{
				return this._birth_Date;
			}
			set
			{
				if ((this._birth_Date != value))
				{
					this.Onbirth_DateChanging(value);
					this.SendPropertyChanging();
					this._birth_Date = value;
					this.SendPropertyChanged("birth_Date");
					this.Onbirth_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(6)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Education", DbType="VarChar(30)")]
		public string Education
		{
			get
			{
				return this._Education;
			}
			set
			{
				if ((this._Education != value))
				{
					this.OnEducationChanging(value);
					this.SendPropertyChanging();
					this._Education = value;
					this.SendPropertyChanged("Education");
					this.OnEducationChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblclientreg")]
	public partial class tblclientreg : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _clientid;
		
		private string _name;
		
		private string _caddress;
		
		private string _city;
		
		private string _gender;
		
		private string _dateofbirth;
		
		private string _contactno;
		
		private string _qualification;
		
		private string _emailid;
		
		private string _pwd;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnclientidChanging(int value);
    partial void OnclientidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OncaddressChanging(string value);
    partial void OncaddressChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OndateofbirthChanging(string value);
    partial void OndateofbirthChanged();
    partial void OncontactnoChanging(string value);
    partial void OncontactnoChanged();
    partial void OnqualificationChanging(string value);
    partial void OnqualificationChanged();
    partial void OnemailidChanging(string value);
    partial void OnemailidChanged();
    partial void OnpwdChanging(string value);
    partial void OnpwdChanged();
    #endregion
		
		public tblclientreg()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_clientid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int clientid
		{
			get
			{
				return this._clientid;
			}
			set
			{
				if ((this._clientid != value))
				{
					this.OnclientidChanging(value);
					this.SendPropertyChanging();
					this._clientid = value;
					this.SendPropertyChanged("clientid");
					this.OnclientidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(20)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_caddress", DbType="VarChar(200)")]
		public string caddress
		{
			get
			{
				return this._caddress;
			}
			set
			{
				if ((this._caddress != value))
				{
					this.OncaddressChanging(value);
					this.SendPropertyChanging();
					this._caddress = value;
					this.SendPropertyChanged("caddress");
					this.OncaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="VarChar(200)")]
		public string city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					this.OncityChanging(value);
					this.SendPropertyChanging();
					this._city = value;
					this.SendPropertyChanged("city");
					this.OncityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="VarChar(7)")]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateofbirth", DbType="VarChar(20)")]
		public string dateofbirth
		{
			get
			{
				return this._dateofbirth;
			}
			set
			{
				if ((this._dateofbirth != value))
				{
					this.OndateofbirthChanging(value);
					this.SendPropertyChanging();
					this._dateofbirth = value;
					this.SendPropertyChanged("dateofbirth");
					this.OndateofbirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactno", DbType="VarChar(15)")]
		public string contactno
		{
			get
			{
				return this._contactno;
			}
			set
			{
				if ((this._contactno != value))
				{
					this.OncontactnoChanging(value);
					this.SendPropertyChanging();
					this._contactno = value;
					this.SendPropertyChanged("contactno");
					this.OncontactnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qualification", DbType="VarChar(30)")]
		public string qualification
		{
			get
			{
				return this._qualification;
			}
			set
			{
				if ((this._qualification != value))
				{
					this.OnqualificationChanging(value);
					this.SendPropertyChanging();
					this._qualification = value;
					this.SendPropertyChanged("qualification");
					this.OnqualificationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailid", DbType="VarChar(100)")]
		public string emailid
		{
			get
			{
				return this._emailid;
			}
			set
			{
				if ((this._emailid != value))
				{
					this.OnemailidChanging(value);
					this.SendPropertyChanging();
					this._emailid = value;
					this.SendPropertyChanged("emailid");
					this.OnemailidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pwd", DbType="VarChar(30)")]
		public string pwd
		{
			get
			{
				return this._pwd;
			}
			set
			{
				if ((this._pwd != value))
				{
					this.OnpwdChanging(value);
					this.SendPropertyChanging();
					this._pwd = value;
					this.SendPropertyChanged("pwd");
					this.OnpwdChanged();
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
