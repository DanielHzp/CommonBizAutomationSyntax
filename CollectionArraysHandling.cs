

//Syntax guide to obtain, loop, and manipulate collection arrays in Bizagi business rules



//CHelper methods to create collection arrays 
//Obtain data from activity scope
var collectionArray=CHelper.GetValueAsCollection(<mProcessEntityName.kmForeignKeytoEntity2.xCollectionName>);  
var collectionArraySize=collectionArray.size();


//Static filter in CHelper methods
var collectionArray = CHelper.GetValueAsCollection(<mProcessEntityName.xCollectionName[bBooleanAttributeName = true]>);
var collectionArraySize=collectionArray.size();


//DYNAMIC filter in CHelper methods
var collectionArray = CHelper.GetValueAsCollection(Me.getXPath("mProcessEntityName.xCollection1Name[bBooleanAttribute = true].xCollection2Name[kmForeignKeytoEntity.integerAttrib = "+filter+" AND kpForeignKeyParamEntity.integerAttrib = 2 ]"));

var Partial = CHelper.GetValueAsCollection(Me.getXPath("PurchaseRequisition.BlanketPOinvoices[Approved = true].SelectedItems[RequestedItem.ItemIndex = "+index+" AND ItemStatus.Code = 2 ]"));


//CHelper methods iterating syntax:
for(var i=0; i<collectionArray.size(); i++)
{
	//Obtain primary key of i-th entity record
	
	
	//Obtain attribute of i-th entity record 
	
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	
	var attributeValueRecord-ith=collectionArray.get(i).getXPath("AttributeName");
	

	

}






//CEntityManager methods to create collection arrays (parameter ,master and system WF entities)
//Obtain data from DATABASE without context reference 
var filter = "sStringAttributeName = 'StringSampleText' ";
var collectionArray = CEntityManager.GetEntity("EntityName").GetEntityList("", "", filter, "");

	//Obtain primary key of i-th entity record
		var primaryKeyRecord-ith = collectionArray[i].SurrogateKeyValue;
















//Me Entity list methods to create collection arrays
//Obtain data from database with context Me reference (They don´t compile in global rules or start events )
var collectionArray= Me.getXPath("entity-list('POtemStatus','')");


//Static filter syntax entity list
var collectionFilteredArray = Me.getXPath("entity-list('Invoiceuploaderemail','uploaderrole =\"UK\"')");
var collectionFilteredArray = Me.getXPath("entity-list('Wfuser','username =\""+user[0].getXPath("username")+"\"')");

//Dynamic filter syntax entity list


//Me Entity list  array navigation for-loop syntax:
for(var i=0; i<collectionArray.size(); i++)
{
	//Ways to obtain primary key of i-th entity record
	var primaryKeyRecord-ith = Me.getXPath("entity-list('EntityName')")[0];
	
	var  primaryKeyRecord-ith = collectionArray[i];
	
	//Obtain attribute of i-th entity record 
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	

	

}








//XPath navigation to obtain collection arrays
//Obtain data from activity scope with context Me reference 

var collectionArray =Me.getXPath("PurchaseRequisition.BlanketPOinvoices.SelectedItems[RequestedItem.ItemIndex = "+index+" ].AmountToBePaid");
var collectionArray = <mProcessEntityName.xCollectionName>;
var collectionArraySize=collectionArray.size();
var collectionArraySize=<mProcessEntityName.kmForeignKeyEntity2.xCollectionName>.size();



//XPath collection navigation for-loop syntax:
for(var i=0; i<collectionArray.size(); i++)
{
	//Obtain primary key of i-th entity record
	var primaryKeyRecord-ith = <mProcessEntityName.kmForeignKeyEntity2.xCollectionName>[0];
	
	
	//Obtain attribute of i-th entity record 
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	
	var attributeValueRecord-ith = <mProcessEntityName.kmForeignKeyEntity2.xCollectionName>[0].getXPath("AttributeName");
	
	nuevo.setXPath("BuildingC",attendees[i].getXPath("SelectedWorkshop[Selected = true AND Workshop.WorkshopType.Code = "+codigo+"].BuildingConectorsPre").toString()+"%")
	
	
	
	//Obtain data from activity scope with CustomMeExample reference
	var collectionArrayRecord-ith = collectionArray[i].getXPath("xCollectionNameofRecord-ith");
	
}
	

