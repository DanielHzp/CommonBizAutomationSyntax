

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
var exists=CustomMe.getXPath("exists(xCollectionName[kpForeignKey.sStringAttribute  ='"+ sStringVariable +"'])");
var exists=Me.getXPath("exists(mProcessEntityName.xCollectionName[kpForeignKey.sStringAttribute  ='"+sStringVariable+"'])");


//Sum all values of a collection integer/currency attribute with custom filter
var AttributeSum= Me.getXPath("sum(mProcessEntityName.kmForeignKey.xCollectionName[kpForeignKey.StringAttributeName = '"+StringVariable+"'AND kpForeignKey.kpForeignKey2.StringAttributeName = '"+StringVariable2+"' AND StringAttributeName = '"+StringVariable3+"'].cCurrencyAttribute)");



//Declare an arraylist and add items inside a business rule
var arrayListName = new ArrayList();
arrayListName.Add(VariableName);







//CHelper methods to create collection arrays ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Obtain data from activity scope
var collectionArray=CHelper.GetValueAsCollection(<mProcessEntityName.kmForeignKeytoEntity2.xCollectionName>);  
var collectionArraySize=collectionArray.size();


//Static filter in CHelper methods
var collectionArray = CHelper.GetValueAsCollection(<mProcessEntityName.xCollectionName[bBooleanAttributeName = true]>);
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
	
	var primaryKeyRecord-ith=collectionArray.get(i).getXPath("Id");
	
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
var collectionFilteredArray = Me.getXPath("entity-list('Wfuser','username =\""+sStringAttributeName+"\"')");

//Dynamic filter syntax entity list
var filter="mEntityName.dDateAttributeName= "+"\""+startDateString+"\""+" and mEntityName.dDateAttributeName2= "+"\""+endDateString+"\"";

var filter="mEntityName.dDateAttributeName= "+"\""+startDateString+"\""+" and mEntityName.dDateAttributeName2= "+"\""+endDateString+"\""+" and kpForeignKey.sStringAttribute= "+"\""+StringVariable+"\""+" and mEntityName.sStringAttribute= "+"\""+StringVariable+"\"";

var filter="kpForeignKey.sStringAttribute = "+"\""+ sStringVariable+"\""+" and bBooleanAttribute = true and kpForeignKey.ksForeignKeySystemEntity.bBooleanAttribute=true";
		
var filter="iIntegerAttribute="+ExampleArray[i]+" AND bBooleanAttribute=1";

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
	
	//Obtain attribute of i-th entity record 
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	var attributeValueRecord-ith=collectionArray.get(i).getXPath("kpForeignKey.ksForeignKeySystemEntity");

	

}








//XPath navigation to obtain collection arrays----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Obtain data from activity scope with context Me reference 

var collectionArray =Me.getXPath("mProcessEntityName.kmForeignKey.xCollectionName[RequestedItem.ItemIndex = "+index+" ].AmountToBePaid");
var collectionArray = <mProcessEntityName.xCollectionName>;
var collectionArraySize=collectionArray.size();
var collectionArraySize=<mProcessEntityName.kmForeignKeyEntity2.xCollectionName>.size();



//XPath collection navigation for-loop syntax:
for(var i=0; i<collectionArray.size(); i++)
{
	//Obtain primary key of i-th entity record
	var primaryKeyRecord-ith = <mProcessEntityName.kmForeignKeyEntity2.xCollectionName>[i];
	
	
	//Obtain attribute of i-th entity record 
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	
	var attributeValueRecord-ith = <mProcessEntityName.kmForeignKeyEntity2.xCollectionName>[i].getXPath("AttributeName");
	
	
	//Obtain data from activity scope with CustomMeExample reference
	var collectionArrayRecord-ith = collectionArray[i].getXPath("xCollectionNameofRecord-ith");
	var collectionArrayRecord-ith =CustomMe.getXPath("xCollectionNameofRecord-ith[kpForeignKey.sStringAttribute ='"+ StringVariable +"'])");
	
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
