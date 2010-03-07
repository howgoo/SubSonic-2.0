using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace Northwind
{
    /// <summary>
    /// Controller class for DisposeTable
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class DisposeTableController
    {
        // Preload our schema..
        DisposeTable thisSchemaLoad = new DisposeTable();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public DisposeTableCollection FetchAll()
        {
            DisposeTableCollection coll = new DisposeTableCollection();
            Query qry = new Query(DisposeTable.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public DisposeTableCollection FetchByID(object DisposeTableId)
        {
            DisposeTableCollection coll = new DisposeTableCollection().Where("DisposeTableId", DisposeTableId).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public DisposeTableCollection FetchByQuery(Query qry)
        {
            DisposeTableCollection coll = new DisposeTableCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object DisposeTableId)
        {
            return (DisposeTable.Delete(DisposeTableId) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object DisposeTableId)
        {
            return (DisposeTable.Destroy(DisposeTableId) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Name,DateTime? CreatedOn,DateTime? ModifiedOn,string CreatedBy,string ModifiedBy)
	    {
		    DisposeTable item = new DisposeTable();
		    
            item.Name = Name;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedOn = ModifiedOn;
            
            item.CreatedBy = CreatedBy;
            
            item.ModifiedBy = ModifiedBy;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int DisposeTableId,string Name,DateTime? CreatedOn,DateTime? ModifiedOn,string CreatedBy,string ModifiedBy)
	    {
		    DisposeTable item = new DisposeTable();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.DisposeTableId = DisposeTableId;
				
			item.Name = Name;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedOn = ModifiedOn;
				
			item.CreatedBy = CreatedBy;
				
			item.ModifiedBy = ModifiedBy;
				
	        item.Save(UserName);
	    }
    }
}