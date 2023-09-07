

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
	//Method1:
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	
	//Method2:
	var attributeValueRecord-ith=collectionArray.get(i).getXPath("AttributeName");
	

}






//CEntityManager methods to create collection arrays
//Obtain data from database without context reference 







//Me Entity list methods to create collection arrays
//Obtain data from database with context Me reference (They don´t compile in global rules or start events )
var collectionArray= Me.getXPath("entity-list('POtemStatus','')");


//Static filter syntax entity list
user = Me.getXPath("entity-list('Invoiceuploaderemail','uploaderrole =\"UK\"')");
performer = Me.getXPath("entity-list('Wfuser','username =\""+user[0].getXPath("username")+"\"')");

//Dynamic filter syntax entity list


//Me Entity list  array navigation for-loop syntax:
for(var i=0; i<collectionArray.size(); i++)
{
	//Obtain primary key of i-th entity record
	var attributeValueRecord-ith = Me.getXPath("entity-list('EntityName')")[0];
	
	//Obtain attribute of i-th entity record 
	//Method1:
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	

	

}








//XPath navigation to obtain collection arrays
//Obtain data from activity scope with context Me reference 

var collectionArray =Me.getXPath("PurchaseRequisition.BlanketPOinvoices.SelectedItems[RequestedItem.ItemIndex = "+index+" ].AmountToBePaid")




//XPath collection navigation for-loop syntax:
for(var i=0; i<collectionArray.size(); i++)
{
	//Obtain primary key of i-th entity record
	
	
	//Obtain attribute of i-th entity record 
	//Method1:
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	
	//Method2:
	//CHelper methods iterating syntax:
	var attributeValueRecord-ith = <mProcessEntityName.kmForeignKeyEntity2.xCollectionName>[0].getXPath("AttributeName");
	
	
	
	
	//Obtain data from activity scope with CustomMeExample reference
	

}
	

