

//SYNTAX GUIDE TO OBTAIN, LOOP, AND MANIPULATE COLLECTION ARRAYS IN BIZAGI BUSINESS RULES



//DELETE ALL RECORDS OF A COLLECTION AT SCOPE CONTEXT
Me.deleteAllCollectionItems("mProcessEntityName.kmForeignKeytoEntity2.xCollectionName");




//USE .CONTEXT WHEN XPATH DOESEN´T START NAVIGATING FROM THE PROCESS ENTITY
Me.Context.deleteAllCollectionItems("kmForeignKeytoEntity2.xCollectionName");





//DELETE ONE RECORD SPECIFICALLY, THE RECORD THAT HAS TO BE DELETED IS IDENTIFIED BY THE PRIMARY KEY
var ExampleArray = CHelper.GetValueAsCollection(Me.getXPath("mProcessEntityName.xCollectionName[iIntegerAttributeName = " + integerFilter+ "]")); //Example scope array

Me.deleteCollectionItem("mProcessEntityName.kmForeignKeytoEntity2.xCollectionName",ExampleArray[0]); //Delete the first record of the example array collection



//Delete repeated record in a filtered collection:
if(ExampleArray.size()>1) //Validates if the collection has replicated records with the specified filter condition
{
	Me.deleteCollectionItem("mProcessEntityName.xCollectionName",ExampleArray[0]); //Delete the duplicated record of the example array collection
}




test sample text


//Validate if at least one record exists in the collection given a filtered condition STATIC FILTERS
var bExists=<exists(mProcessEntityName.xCollectionName[kmProdExec.bCloudActionReq = false AND kmProdExec.bExecuted != true])>;






//Validate if at least one record exists in the collection given a filtered condition DYNAMIC FILTERS
var exists=CustomMe.getXPath("exists(xCollectionName[kpForeignKey.sStringAttribute  ='"+ sStringVariable +"'])");

var exists=Me.getXPath("exists(mProcessEntityName.xCollectionName[kpForeignKey.sStringAttribute  ='"+sStringVariable+"'])");







//Sum all values of a collection integer/currency attribute with custom filter
var AttributeSum= Me.getXPath("sum(mProcessEntityName.kmForeignKey.xCollectionName[kpForeignKey.StringAttributeName = '"+StringVariable+"'AND kpForeignKey.kpForeignKey2.StringAttributeName = '"+StringVariable2+"' AND StringAttributeName = '"+StringVariable3+"'].cCurrencyAttribute)");

var AttributeSum=<sum(mProcessEntityName.kmForeignKey.xCollectionName[PaymentByCompany.MethodofPayment.Code = 'REI'].cCurrencyAttribute)>; //This function version doesn´t depend on Me context but ONLY works with STATIC filters
							
var AttributeSum=<sum(xCollectionName[kpRelatedAttribute != null].iIntegerAttribute)>;





//Count records of a filtered collection ONLY WITH static filters
var countRecords = <count(mProcessEntity.xCollectionName[kpForeignKeyParamEntity.iAttributeName = mProcessEntity.AttributeName])>;

var countRecords=<count(mProcessEntity.xCollectionName[kpStatus.sCode = '5'])>;






//Identify the maximun value of a collection integer attribute
var maxValue= <max(CmProcessEntity.xCollectionName.iIntegerAttribute)>;





//Declare an arraylist and add items inside a business rule
var arrayListName = new ArrayList();
arrayListName.Add(VariableName);





//Obtain UNIQUE attribute records from a collection 
var DistinctRecordsArray = <distinct-values(mProcessEntityName.xCollectionName.AttributeName)>;
var CollectionArray = CHelper.GetValueAsCollection(DistinctRecordsArray);





//ATTACH NEW RECORDS TO COLLECTION1 FROM COLLECTION2 ACCORDING TO SPECIFIC CONDITION 
	Me.attachCollectionItems("mProcessEntity.xCollection1Name", Me.getXPath("mProcessEntity.xCollectionName2[kpStatus.sCode = '5']")); //xCollectionName and xCollectionName2 must be collections of the same entity


//DETTACH EXISTING RECORDS IN COLLECTION1 ACCORDING TO CRITERIA
	Me.detachCollectionItems("mProcessEntity.xCollection1Name", Me.getXPath("mProcessEntity.xCollectionName[kpStatus.sCode = '5']"));
	






//CHelper methods to create collection arrays ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Obtain data from activity scope
var collectionArray=CHelper.GetValueAsCollection(<mProcessEntityName.kmForeignKeytoEntity2.xCollectionName>);  
var collectionArraySize=collectionArray.size();


//Static filter in CHelper methods
var collectionArray = CHelper.GetValueAsCollection(<mProcessEntityName.xCollectionName[bBooleanAttributeName = true]>);
var collectionArray = CHelper.GetValueAsCollection(<mProcessEntityName.xCollectionName[cCurrencyAttributeName = null OR cCurrencyAttributeName <= 0]>);
var collectionArraySize=collectionArray.size();


//DYNAMIC filter in CHelper methods
var collectionArray = CHelper.GetValueAsCollection(Me.getXPath("mProcessEntityName.xCollection1Name[bBooleanAttribute = true].xCollection2Name[kmForeignKeytoEntity.integerAttrib = "+integerVariable+" AND kpForeignKeyParamEntity.integerAttrib = 2 ]"));

var collectionArray = CHelper.GetValueAsCollection(Me.getXPath("mProcessEntityName.xCollection1Name[bBooleanAttribute = true].xCollection2Name[integerAttrib = "+integerVariable+" AND kpForeignKeyParamEntity.integerAttrib = 2 ]"));

var collectionArray = CHelper.GetValueAsCollection(Me.Context.getXPath("mEntityName.kmForeignKey.xCollectionName[kpForeignKey.sStringAttribute = '"+ stringVariable +"']"));


//CHelper methods iterating syntax:
for(var i=0; i<collectionArray.size(); i++)
{
	//Obtain primary key of i-th entity record
	var primaryKeyRecord-ith= collectionArray.get(i);
	
	var primaryKeyRecord-ith=collectionArray.get(i).getXPath("Id"); //Obtain the NUMERIC value of the primary key of the i-th entity record
	
	var primaryKeyRecord-ith=collectionArray.get(i).getXPath("idEntityName");
	
	var primaryKeyRecord-ith=collectionArray[i];
	//Obtain attribute of i-th entity record 
	
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	
	var attributeValueRecord-ith=collectionArray.get(i).getXPath("AttributeName");
	


}








//CEntityManager methods to create collection arrays (from parameter ,master and system WF entities)-------------------------------------------------------------------------------------------------------------------------------
//Obtain data from DATABASE without context reference  (They compile in global rules or start events )
//CEntityManager get Entity method can only be filtered by attributes directly related to the searched entity,  attributes in related/connected entities can´t be navigated
var collectionArray=CEntityManager.GetEntity("EntityName").GetEntityList("","","","");

var filterString = "sStringAttributeName = 'StringSampleText' ";
var filterBoolean="bBooleanAttributeName ="+true;
var filterDate="dDateAttribute IS NOT NULL";
var filterExample = "(bBooleanAttributeName <>" + true + " OR bBooleanAttributeName IS NULL) and dDateAttribute > "+ "'" + DateVariable.ToString("yyyy-MM-dd") + "'" +" and dDateAttribute2 <= " + "'" + DateVariable2.ToString("yyyy-MM-dd")+ "'";

var collectionArray = CEntityManager.GetEntity("EntityName").GetEntityList("", "", filterExample, "");
var collectionArray = CEntityManager.GetEntity("EntityName").GetEntityList("","","iIntegerAttribute="+Array[i]+" AND bBooleanAttribute=1","");
var collectionArraySize=collectionArray.Length;

	//Obtain primary key of i-th entity record
		var primaryKeyRecord-ith = collectionArray[i].SurrogateKeyValue;

	//Obtain attribute of i-th entity record 

	var attributeValueRecord-ith=collectionArray[i].Attributes["AttributeName"].Value;
	
	if(attributeValueRecord.Contains('@')){....}









//Me Entity list methods to create collection arrays (from parameter ,master and system WF entities)---------------------------------------------------------------------------------------------------------------------------------
//Obtain data from database with context Me reference (They don´t compile in global rules or start events )
var collectionArray= Me.getXPath("entity-list('EntityName','')");


//Static filter syntax entity list
var collectionFilteredArray = Me.getXPath("entity-list('pEntityName','sStringAttributeName =\"UK\"')");
var collectionFilteredArray = Me.getXPath("entity-list('Wfuser','username =\""+sStringAttributeName+"\"')"); //Filter all records where username equals ...
var collectionFilteredArray = Me.getXPath("entity-list('pEntityName','sStringAttributeName <>\"Insert String Value Here\"')"); //Filter all records where the attribute value is different than...


//Dynamic filter syntax entity list
var filter="mEntityName.dDateAttributeName= "+"\""+startDateString+"\""+" and mEntityName.dDateAttributeName2= "+"\""+endDateString+"\"";

var filter="mEntityName.dDateAttributeName= "+"\""+startDateString+"\""+" and mEntityName.dDateAttributeName2= "+"\""+endDateString+"\""+" and kpForeignKey.sStringAttribute= "+"\""+StringVariable+"\""+" and mEntityName.sStringAttribute= "+"\""+StringVariable+"\"";

var filter="kpForeignKey.sStringAttribute = "+"\""+ sStringVariable+"\""+" and bBooleanAttribute = true and kpForeignKey.ksForeignKeySystemEntity.bBooleanAttribute=true";
		
var filter="iIntegerAttribute="+ExampleArray[i]+" AND bBooleanAttribute=1";

var collectionArray=Me.getXPath("entity-list('EntityName','sStringAttributeName2 =\""+sStringVariable+"\""+" and sStringAttributeName <>\"Insert String Value Here\"')");

var	collectionArray = Me.getXPath("entity-list('SystemEntityName','"+filter+"')");		

var collectionArray=Me.getXPath("entity-list('pParamEntityName','"+filter+"')");
var collectionArray=Me.getXPath("entity-list('EntityName','"+filter+"')");

//Me Entity list  array navigation for-loop syntax:
for(var i=0; i<collectionArray.size(); i++)
{
	//Obtain primary key of i-th entity record
	var primaryKeyRecord-ith = Me.getXPath("entity-list('EntityName')")[i];
	
	var  primaryKeyRecord-ith = collectionArray[i];
	
	var  primaryKeyRecord-ith =collectionArray.get(i);
	
	var primaryKeyRecord-ith=collectionArray.get(i).getXPath("Id"); //Obtain the NUMERIC value of the primary key of the i-th entity record
	
	//Obtain attribute of i-th entity record 
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	var attributeValueRecord-ith=collectionArray.get(i).getXPath("kpForeignKey.ksForeignKeySystemEntity");

	

}








//XPath navigation to obtain collection arrays----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Obtain data from activity scope with context Me reference 

var collectionArray =Me.getXPath("mProcessEntityName.kmForeignKey.xCollectionName[RequestedItem.ItemIndex = "+index+" ].iIntegerAttributeName"); //Creates an array with one column containing iIntegerAttributeName values filtered

Me.getXPath("mONB.xCP[kpStatus.sCode = '3' AND kmCP.kpSKU.kpProductType.kpSupportType.sCode != null AND kmCP.kpSKU.kpProductType.kpSupportType.bPremium != true].kmCP
var sTechLastName = <mONB.xOnbContacts[kpContactRole.sCode = '6'].kmPerson.sLastName>;

var iIdService = Me.getXPath("mONB.kmCustomer.xCustomerServices[kmCP.Id = "+iIdCP+"].Id");
		CHelper.trace(traceName, "iIdService: "+iIdService);
		Me.setXPath("mONB.kmCustomer.xCustomerServices[kmCP.Id = "+iIdCP+"].kpStatus",iIdStatusActive);
		
		
var collectionArray=<mProcessEntityName.xCollectionName[...].AttributeName>;  //Creates an array with one column containing AttributeName values filtered

var collectionArray=<mProcessEntityName.xCollectionName[...].kmForeingKey.Id>;  //Creates an array with one column containing kmForeingKey Id values filtered

var collectionArray = <mProcessEntityName.xCollectionName>; //Creates an array containing all attribute columns of the collection entity

var collectionArraySize=collectionArray.size();  //Array size 

var collectionArraySize=<mProcessEntityName.kmForeignKeyEntity2.xCollectionName>.size();



//XPath collection navigation for-loop syntax:
for(var i=0; i<collectionArray.size(); i++)  //Or
for(var i=0;i< <mProcessEntityName.kmForeignKeyEntity2.xCollectionName>.size();i++)
{
	//Obtain primary key of i-th entity record
	var primaryKeyRecord-ith = <mProcessEntityName.kmForeignKeyEntity2.xCollectionName>[i];
	
	var primaryKeyRecord-ith=collectionArray[i].getXPath("Id"); //Obtain the NUMERIC value of the primary key of the i-th entity record
	
	
	//Obtain attribute of i-th entity record 
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	
	var attributeValueRecord-ith = <mProcessEntityName.kmForeignKeyEntity2.xCollectionName>[i].getXPath("AttributeName");
	
	if(CHelper.IsNull(attributeValueRecord-ith)){ ... }
	
	//Obtain data from activity scope with CustomMeExample reference
	var collectionArrayRecord-ith = collectionArray[i].getXPath("xCollectionNameofRecord-ith");
	
	var collectionArrayRecord-ith=<mProcessEntityName.kmForeignKeyEntity2.xCollectionName>[i].getXPath("xCollectionNameofRecord-ith");
	
	var collectionFilteredArrayRecord-ith =CustomMe.getXPath("xCollectionNameofRecord-ith[kpForeignKey.sStringAttribute ='"+ StringVariable +"'])"); //CustomMe refers to collectionArray[i] object
	
	var newRecord= CustomMe.newCollectionItem("xCollectionNameofRecord-ith");
	newRecord.setXPath("BuildingC",attendees[i].getXPath("SelectedWorkshop[Selected = true AND Workshop.WorkshopType.Code = "+codigo+"].BuildingConectorsPre").toString()+"%")
}
	
	
	




//CHelper method to obtain and manipulate user properties arrays (user roles, skills, etc.)----------------------------------------------------------------------------------------------------------------------------------------------------------
//Obtain all users with certain role:
var UsersRoleArray=CHelper.getUsersForRole("UserRoleName");
var UsersPositionArray=CHelper.getUsersForPosition("UserPositionName");

for(var i=0;i<UsersRole.Count; i++){
	
	//Obtain primary key (WF user id) of i-th record 
	var userId=UsersRoleArray[i];
	
}


//Validate if a specific user has certain role
if(<mProcessEntity.kmWFUserForeingKey.Roles[roleName = 'UserRoleName']>!=null){...}


//Method that obtains the size of an array containing all assignees of an active task/activity 

var CountUsersAssigned=Me.Assignees.Count;

for(var j=0;j<CountUsersAssigned;j++){

						var assigneeIterated=Me.Assignees[j].FullName; //Obtain the full name of the i-th user assigned to a task/activity
						
						

}

