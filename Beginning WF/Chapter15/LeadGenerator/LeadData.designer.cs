﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeadGenerator
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Chapter14")]
	public partial class LeadDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLead(Lead instance);
    partial void UpdateLead(Lead instance);
    partial void DeleteLead(Lead instance);
    partial void InsertTrackActivity(TrackActivity instance);
    partial void UpdateTrackActivity(TrackActivity instance);
    partial void DeleteTrackActivity(TrackActivity instance);
    partial void InsertTrackBookmark(TrackBookmark instance);
    partial void UpdateTrackBookmark(TrackBookmark instance);
    partial void DeleteTrackBookmark(TrackBookmark instance);
    partial void InsertTrackCustom(TrackCustom instance);
    partial void UpdateTrackCustom(TrackCustom instance);
    partial void DeleteTrackCustom(TrackCustom instance);
    partial void InsertTrackInstance(TrackInstance instance);
    partial void UpdateTrackInstance(TrackInstance instance);
    partial void DeleteTrackInstance(TrackInstance instance);
    partial void InsertAssignment(Assignment instance);
    partial void UpdateAssignment(Assignment instance);
    partial void DeleteAssignment(Assignment instance);
    #endregion
		
		public LeadDataDataContext() : 
				base(global::LeadGenerator.Properties.Settings.Default.Chapter14ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LeadDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LeadDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LeadDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LeadDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Lead> Leads
		{
			get
			{
				return this.GetTable<Lead>();
			}
		}
		
		public System.Data.Linq.Table<TrackActivity> TrackActivities
		{
			get
			{
				return this.GetTable<TrackActivity>();
			}
		}
		
		public System.Data.Linq.Table<TrackBookmark> TrackBookmarks
		{
			get
			{
				return this.GetTable<TrackBookmark>();
			}
		}
		
		public System.Data.Linq.Table<TrackCustom> TrackCustoms
		{
			get
			{
				return this.GetTable<TrackCustom>();
			}
		}
		
		public System.Data.Linq.Table<TrackInstance> TrackInstances
		{
			get
			{
				return this.GetTable<TrackInstance>();
			}
		}
		
		public System.Data.Linq.Table<Assignment> Assignments
		{
			get
			{
				return this.GetTable<Assignment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lead")]
	public partial class Lead : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LeadID;
		
		private System.Guid _WorkflowID;
		
		private string _ContactName;
		
		private string _ContactPhone;
		
		private string _Interests;
		
		private string _Comments;
		
		private string _Status;
		
		private string _AssignedTo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLeadIDChanging(int value);
    partial void OnLeadIDChanged();
    partial void OnWorkflowIDChanging(System.Guid value);
    partial void OnWorkflowIDChanged();
    partial void OnContactNameChanging(string value);
    partial void OnContactNameChanged();
    partial void OnContactPhoneChanging(string value);
    partial void OnContactPhoneChanged();
    partial void OnInterestsChanging(string value);
    partial void OnInterestsChanged();
    partial void OnCommentsChanging(string value);
    partial void OnCommentsChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnAssignedToChanging(string value);
    partial void OnAssignedToChanged();
    #endregion
		
		public Lead()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LeadID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int LeadID
		{
			get
			{
				return this._LeadID;
			}
			set
			{
				if ((this._LeadID != value))
				{
					this.OnLeadIDChanging(value);
					this.SendPropertyChanging();
					this._LeadID = value;
					this.SendPropertyChanged("LeadID");
					this.OnLeadIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkflowID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid WorkflowID
		{
			get
			{
				return this._WorkflowID;
			}
			set
			{
				if ((this._WorkflowID != value))
				{
					this.OnWorkflowIDChanging(value);
					this.SendPropertyChanging();
					this._WorkflowID = value;
					this.SendPropertyChanged("WorkflowID");
					this.OnWorkflowIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactName", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string ContactName
		{
			get
			{
				return this._ContactName;
			}
			set
			{
				if ((this._ContactName != value))
				{
					this.OnContactNameChanging(value);
					this.SendPropertyChanging();
					this._ContactName = value;
					this.SendPropertyChanged("ContactName");
					this.OnContactNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactPhone", DbType="VarChar(20)")]
		public string ContactPhone
		{
			get
			{
				return this._ContactPhone;
			}
			set
			{
				if ((this._ContactPhone != value))
				{
					this.OnContactPhoneChanging(value);
					this.SendPropertyChanging();
					this._ContactPhone = value;
					this.SendPropertyChanged("ContactPhone");
					this.OnContactPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Interests", DbType="VarChar(100)")]
		public string Interests
		{
			get
			{
				return this._Interests;
			}
			set
			{
				if ((this._Interests != value))
				{
					this.OnInterestsChanging(value);
					this.SendPropertyChanging();
					this._Interests = value;
					this.SendPropertyChanged("Interests");
					this.OnInterestsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comments", DbType="VarChar(500)")]
		public string Comments
		{
			get
			{
				return this._Comments;
			}
			set
			{
				if ((this._Comments != value))
				{
					this.OnCommentsChanging(value);
					this.SendPropertyChanging();
					this._Comments = value;
					this.SendPropertyChanged("Comments");
					this.OnCommentsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssignedTo", DbType="VarChar(50)")]
		public string AssignedTo
		{
			get
			{
				return this._AssignedTo;
			}
			set
			{
				if ((this._AssignedTo != value))
				{
					this.OnAssignedToChanging(value);
					this.SendPropertyChanging();
					this._AssignedTo = value;
					this.SendPropertyChanged("AssignedTo");
					this.OnAssignedToChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TrackActivity")]
	public partial class TrackActivity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TrackActivityID;
		
		private System.Guid _WorkflowID;
		
		private string _ActivityName;
		
		private System.DateTime _EventDate;
		
		private string _Status;
		
		private string _Variables;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTrackActivityIDChanging(int value);
    partial void OnTrackActivityIDChanged();
    partial void OnWorkflowIDChanging(System.Guid value);
    partial void OnWorkflowIDChanged();
    partial void OnActivityNameChanging(string value);
    partial void OnActivityNameChanged();
    partial void OnEventDateChanging(System.DateTime value);
    partial void OnEventDateChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnVariablesChanging(string value);
    partial void OnVariablesChanged();
    #endregion
		
		public TrackActivity()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrackActivityID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TrackActivityID
		{
			get
			{
				return this._TrackActivityID;
			}
			set
			{
				if ((this._TrackActivityID != value))
				{
					this.OnTrackActivityIDChanging(value);
					this.SendPropertyChanging();
					this._TrackActivityID = value;
					this.SendPropertyChanged("TrackActivityID");
					this.OnTrackActivityIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkflowID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid WorkflowID
		{
			get
			{
				return this._WorkflowID;
			}
			set
			{
				if ((this._WorkflowID != value))
				{
					this.OnWorkflowIDChanging(value);
					this.SendPropertyChanging();
					this._WorkflowID = value;
					this.SendPropertyChanged("WorkflowID");
					this.OnWorkflowIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityName", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string ActivityName
		{
			get
			{
				return this._ActivityName;
			}
			set
			{
				if ((this._ActivityName != value))
				{
					this.OnActivityNameChanging(value);
					this.SendPropertyChanging();
					this._ActivityName = value;
					this.SendPropertyChanged("ActivityName");
					this.OnActivityNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventDate", DbType="DateTime NOT NULL")]
		public System.DateTime EventDate
		{
			get
			{
				return this._EventDate;
			}
			set
			{
				if ((this._EventDate != value))
				{
					this.OnEventDateChanging(value);
					this.SendPropertyChanging();
					this._EventDate = value;
					this.SendPropertyChanged("EventDate");
					this.OnEventDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Variables", DbType="VarChar(2000)")]
		public string Variables
		{
			get
			{
				return this._Variables;
			}
			set
			{
				if ((this._Variables != value))
				{
					this.OnVariablesChanging(value);
					this.SendPropertyChanging();
					this._Variables = value;
					this.SendPropertyChanged("Variables");
					this.OnVariablesChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TrackBookmark")]
	public partial class TrackBookmark : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TrackBookmarkID;
		
		private System.Guid _WorkflowID;
		
		private string _BookmarkName;
		
		private System.DateTime _EventDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTrackBookmarkIDChanging(int value);
    partial void OnTrackBookmarkIDChanged();
    partial void OnWorkflowIDChanging(System.Guid value);
    partial void OnWorkflowIDChanged();
    partial void OnBookmarkNameChanging(string value);
    partial void OnBookmarkNameChanged();
    partial void OnEventDateChanging(System.DateTime value);
    partial void OnEventDateChanged();
    #endregion
		
		public TrackBookmark()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrackBookmarkID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TrackBookmarkID
		{
			get
			{
				return this._TrackBookmarkID;
			}
			set
			{
				if ((this._TrackBookmarkID != value))
				{
					this.OnTrackBookmarkIDChanging(value);
					this.SendPropertyChanging();
					this._TrackBookmarkID = value;
					this.SendPropertyChanged("TrackBookmarkID");
					this.OnTrackBookmarkIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkflowID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid WorkflowID
		{
			get
			{
				return this._WorkflowID;
			}
			set
			{
				if ((this._WorkflowID != value))
				{
					this.OnWorkflowIDChanging(value);
					this.SendPropertyChanging();
					this._WorkflowID = value;
					this.SendPropertyChanged("WorkflowID");
					this.OnWorkflowIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookmarkName", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string BookmarkName
		{
			get
			{
				return this._BookmarkName;
			}
			set
			{
				if ((this._BookmarkName != value))
				{
					this.OnBookmarkNameChanging(value);
					this.SendPropertyChanging();
					this._BookmarkName = value;
					this.SendPropertyChanged("BookmarkName");
					this.OnBookmarkNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventDate", DbType="DateTime NOT NULL")]
		public System.DateTime EventDate
		{
			get
			{
				return this._EventDate;
			}
			set
			{
				if ((this._EventDate != value))
				{
					this.OnEventDateChanging(value);
					this.SendPropertyChanging();
					this._EventDate = value;
					this.SendPropertyChanged("EventDate");
					this.OnEventDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TrackCustom")]
	public partial class TrackCustom : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TrackCustomID;
		
		private System.Guid _WorkflowID;
		
		private string _CustomEventName;
		
		private System.DateTime _EventDate;
		
		private string _UserData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTrackCustomIDChanging(int value);
    partial void OnTrackCustomIDChanged();
    partial void OnWorkflowIDChanging(System.Guid value);
    partial void OnWorkflowIDChanged();
    partial void OnCustomEventNameChanging(string value);
    partial void OnCustomEventNameChanged();
    partial void OnEventDateChanging(System.DateTime value);
    partial void OnEventDateChanged();
    partial void OnUserDataChanging(string value);
    partial void OnUserDataChanged();
    #endregion
		
		public TrackCustom()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrackCustomID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TrackCustomID
		{
			get
			{
				return this._TrackCustomID;
			}
			set
			{
				if ((this._TrackCustomID != value))
				{
					this.OnTrackCustomIDChanging(value);
					this.SendPropertyChanging();
					this._TrackCustomID = value;
					this.SendPropertyChanged("TrackCustomID");
					this.OnTrackCustomIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkflowID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid WorkflowID
		{
			get
			{
				return this._WorkflowID;
			}
			set
			{
				if ((this._WorkflowID != value))
				{
					this.OnWorkflowIDChanging(value);
					this.SendPropertyChanging();
					this._WorkflowID = value;
					this.SendPropertyChanged("WorkflowID");
					this.OnWorkflowIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomEventName", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string CustomEventName
		{
			get
			{
				return this._CustomEventName;
			}
			set
			{
				if ((this._CustomEventName != value))
				{
					this.OnCustomEventNameChanging(value);
					this.SendPropertyChanging();
					this._CustomEventName = value;
					this.SendPropertyChanged("CustomEventName");
					this.OnCustomEventNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventDate", DbType="DateTime NOT NULL")]
		public System.DateTime EventDate
		{
			get
			{
				return this._EventDate;
			}
			set
			{
				if ((this._EventDate != value))
				{
					this.OnEventDateChanging(value);
					this.SendPropertyChanging();
					this._EventDate = value;
					this.SendPropertyChanged("EventDate");
					this.OnEventDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserData", DbType="VarChar(2000)")]
		public string UserData
		{
			get
			{
				return this._UserData;
			}
			set
			{
				if ((this._UserData != value))
				{
					this.OnUserDataChanging(value);
					this.SendPropertyChanging();
					this._UserData = value;
					this.SendPropertyChanged("UserData");
					this.OnUserDataChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TrackInstance")]
	public partial class TrackInstance : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TrackInstanceID;
		
		private System.Guid _WorkflowID;
		
		private System.DateTime _EventDate;
		
		private string _Status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTrackInstanceIDChanging(int value);
    partial void OnTrackInstanceIDChanged();
    partial void OnWorkflowIDChanging(System.Guid value);
    partial void OnWorkflowIDChanged();
    partial void OnEventDateChanging(System.DateTime value);
    partial void OnEventDateChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    #endregion
		
		public TrackInstance()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrackInstanceID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TrackInstanceID
		{
			get
			{
				return this._TrackInstanceID;
			}
			set
			{
				if ((this._TrackInstanceID != value))
				{
					this.OnTrackInstanceIDChanging(value);
					this.SendPropertyChanging();
					this._TrackInstanceID = value;
					this.SendPropertyChanged("TrackInstanceID");
					this.OnTrackInstanceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkflowID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid WorkflowID
		{
			get
			{
				return this._WorkflowID;
			}
			set
			{
				if ((this._WorkflowID != value))
				{
					this.OnWorkflowIDChanging(value);
					this.SendPropertyChanging();
					this._WorkflowID = value;
					this.SendPropertyChanged("WorkflowID");
					this.OnWorkflowIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventDate", DbType="DateTime NOT NULL")]
		public System.DateTime EventDate
		{
			get
			{
				return this._EventDate;
			}
			set
			{
				if ((this._EventDate != value))
				{
					this.OnEventDateChanging(value);
					this.SendPropertyChanging();
					this._EventDate = value;
					this.SendPropertyChanged("EventDate");
					this.OnEventDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Assignment")]
	public partial class Assignment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AssignmentID;
		
		private System.Guid _WorkflowID;
		
		private int _LeadID;
		
		private string _AssignedTo;
		
		private System.DateTime _DateAssigned;
		
		private string _Status;
		
		private System.Nullable<System.DateTime> _DateDue;
		
		private System.Nullable<System.DateTime> _DateCompleted;
		
		private string _Remarks;
		
		private EntityRef<Lead> _Lead;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAssignmentIDChanging(int value);
    partial void OnAssignmentIDChanged();
    partial void OnWorkflowIDChanging(System.Guid value);
    partial void OnWorkflowIDChanged();
    partial void OnLeadIDChanging(int value);
    partial void OnLeadIDChanged();
    partial void OnAssignedToChanging(string value);
    partial void OnAssignedToChanged();
    partial void OnDateAssignedChanging(System.DateTime value);
    partial void OnDateAssignedChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnDateDueChanging(System.Nullable<System.DateTime> value);
    partial void OnDateDueChanged();
    partial void OnDateCompletedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateCompletedChanged();
    partial void OnRemarksChanging(string value);
    partial void OnRemarksChanged();
    #endregion
		
		public Assignment()
		{
			this._Lead = default(EntityRef<Lead>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssignmentID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AssignmentID
		{
			get
			{
				return this._AssignmentID;
			}
			set
			{
				if ((this._AssignmentID != value))
				{
					this.OnAssignmentIDChanging(value);
					this.SendPropertyChanging();
					this._AssignmentID = value;
					this.SendPropertyChanged("AssignmentID");
					this.OnAssignmentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkflowID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid WorkflowID
		{
			get
			{
				return this._WorkflowID;
			}
			set
			{
				if ((this._WorkflowID != value))
				{
					this.OnWorkflowIDChanging(value);
					this.SendPropertyChanging();
					this._WorkflowID = value;
					this.SendPropertyChanged("WorkflowID");
					this.OnWorkflowIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LeadID", DbType="Int NOT NULL")]
		public int LeadID
		{
			get
			{
				return this._LeadID;
			}
			set
			{
				if ((this._LeadID != value))
				{
					if (this._Lead.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLeadIDChanging(value);
					this.SendPropertyChanging();
					this._LeadID = value;
					this.SendPropertyChanged("LeadID");
					this.OnLeadIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AssignedTo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string AssignedTo
		{
			get
			{
				return this._AssignedTo;
			}
			set
			{
				if ((this._AssignedTo != value))
				{
					this.OnAssignedToChanging(value);
					this.SendPropertyChanging();
					this._AssignedTo = value;
					this.SendPropertyChanged("AssignedTo");
					this.OnAssignedToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateAssigned", DbType="DateTime NOT NULL")]
		public System.DateTime DateAssigned
		{
			get
			{
				return this._DateAssigned;
			}
			set
			{
				if ((this._DateAssigned != value))
				{
					this.OnDateAssignedChanging(value);
					this.SendPropertyChanging();
					this._DateAssigned = value;
					this.SendPropertyChanged("DateAssigned");
					this.OnDateAssignedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateDue", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateDue
		{
			get
			{
				return this._DateDue;
			}
			set
			{
				if ((this._DateDue != value))
				{
					this.OnDateDueChanging(value);
					this.SendPropertyChanging();
					this._DateDue = value;
					this.SendPropertyChanged("DateDue");
					this.OnDateDueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCompleted", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateCompleted
		{
			get
			{
				return this._DateCompleted;
			}
			set
			{
				if ((this._DateCompleted != value))
				{
					this.OnDateCompletedChanging(value);
					this.SendPropertyChanging();
					this._DateCompleted = value;
					this.SendPropertyChanged("DateCompleted");
					this.OnDateCompletedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Remarks", DbType="VarChar(200)")]
		public string Remarks
		{
			get
			{
				return this._Remarks;
			}
			set
			{
				if ((this._Remarks != value))
				{
					this.OnRemarksChanging(value);
					this.SendPropertyChanging();
					this._Remarks = value;
					this.SendPropertyChanged("Remarks");
					this.OnRemarksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lead_Assignment", Storage="_Lead", ThisKey="LeadID", OtherKey="LeadID", IsForeignKey=true)]
		public Lead Lead
		{
			get
			{
				return this._Lead.Entity;
			}
			set
			{
				if ((this._Lead.Entity != value))
				{
					this.SendPropertyChanging();
					this._Lead.Entity = value;
					this.SendPropertyChanged("Lead");
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