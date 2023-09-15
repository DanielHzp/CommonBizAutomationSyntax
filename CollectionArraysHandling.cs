

//Syntax guide to obtain, loop, and manipulate collection arrays in Bizagi business rules

//Delete all records of a collection at scope context
Me.deleteAllCollectionItems("mProcessEntityName.kmForeignKeytoEntity2.xCollectionName");

//Use .context when xpath doesen´t start navigating from the process entity
Me.Context.deleteAllCollectionItems("kmForeignKeytoEntity2.xCollectionName");


//Delete one record specifically, the record that has to be deleted is identified by the primary key
var ExampleArray = CHelper.GetValueAsCollection(Me.getXPath("mProcessEntityName.xCollectionName[iIntegerAttributeName = " + integerFilter+ "]"));

Me.deleteCollectionItem("mProcessEntityName.kmForeignKeytoEntity2.xCollectionName",ExampleArray[0]);

//Delete repeated record in a filtered collection:
if(ExampleArray.size()>1)
{
	Me.deleteCollectionItem("mProcessEntityName.xCollectionName",ExampleArray[0]);
}



//Validate if at least one record exists in the collection given a filtered condition
Me.getXPath("exists(xMGxInvoiceSectionSubs[kpSubscriptionMGxIS.sIdSubscription ='"+ subsMGChildSubsId +"'])");
var existsSubscription=Me.getXPath("exists(mABC.kmBudgetInfo.xBudgetDetails[kpSubscription.sIdSubscription ='"+recordSubscriptionID+"'])");



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






//CEntityManager methods to create collection arrays (from parameter ,master and system WF entities)
//Obtain data from DATABASE without context reference  (They compile in global rules or start events )
//CEntityManager get Entity method can only be filtered by attributes directly related to the searched entity,  attributes in related/connected entities can´t be navigated
var filterString = "sStringAttributeName = 'StringSampleText' ";
var filterBoolean="RecurringPurchase ="+true;
var filterDate="dContractEndDate IS NOT NULL";
var filter = "(RenewalCertificationSent <>" + true + " OR RenewalCertificationSent IS NULL) and ExpirationDate > "+ "'" + Today.ToString("yyyy-MM-dd") + "'" +" and ExpirationDate <= " + "'" + CalculateExpirationDate.ToString("yyyy-MM-dd")+ "'";

var collectionArray = CEntityManager.GetEntity("EntityName").GetEntityList("", "", filter, "");
var collectionArraySize=collectionArray.Length;

	//Obtain primary key of i-th entity record
		var primaryKeyRecord-ith = collectionArray[i].SurrogateKeyValue;

	//Obtain attribute of i-th entity record 

	var attributeValueRecord-ith=collectionArray[i].Attributes["AttributeName"].Value;










//Me Entity list methods to create collection arrays (from parameter ,master and system WF entities)
//Obtain data from database with context Me reference (They don´t compile in global rules or start events )
var collectionArray= Me.getXPath("entity-list('EntityName','')");


//Static filter syntax entity list
var collectionFilteredArray = Me.getXPath("entity-list('Invoiceuploaderemail','uploaderrole =\"UK\"')");
var collectionFilteredArray = Me.getXPath("entity-list('Wfuser','username =\""+sStringAttributeName+"\"')");

//Dynamic filter syntax entity list
var filter="mABCBudgetInfo.dStartDate= "+"\""+startDateString+"\""+" and mABCBudgetInfo.dEndDate= "+"\""+endDateString
var filterIterated="mABCBudgetInfo.dStartDate= "+"\""+startDateString+"\""+" and mABCBudgetInfo.dEndDate= "+"\""+endDateString+"\""+" and kpSubscription.sIdSubscription= "+"\""+budgetLoadedId+"\""+" and mABCBudgetInfo.kmABC.kpBudgetType.sBudgetCode= "+"\""+budgetSubIteratedBudgetType+"\"";

var allBudgetSubsinEnvironment=Me.getXPath("entity-list('EntityName','"+filter+"')");

//Me Entity list  array navigation for-loop syntax:
for(var i=0; i<collectionArray.size(); i++)
{
	//Obtain primary key of i-th entity record
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
	

