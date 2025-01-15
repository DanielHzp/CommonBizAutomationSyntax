

//SYNTAX GUIDE TO OBTAIN, LOOP, AND MANIPULATE COLLECTION ARRAYS IN BIZAGI BUSINESS RULES



//DELETE ALL RECORDS OF A COLLECTION AT SCOPE CONTEXT
Me.deleteAllCollectionItems("mProcessEntityName.kmForeignKeytoEntity2.xCollectionName");




//USE .CONTEXT WHEN XPATH DOESEN´T START NAVIGATING FROM THE PROCESS ENTITY
Me.Context.deleteAllCollectionItems("kmForeignKeytoEntity2.xCollectionName");





//DELETE ONE RECORD SPECIFICALLY, THE RECORD THAT HAS TO BE DELETED IS IDENTIFIED BY THE PRIMARY KEY
var ExampleArray = CHelper.GetValueAsCollection(Me.getXPath("mProcessEntityName.xCollectionName[iIntegerAttributeName = " + integerFilter+ "]")); //Example scope array

Me.deleteCollectionItem("mProcessEntityName.kmForeignKeytoEntity2.xCollectionName",ExampleArray[0]); //Delete the first record of the example array collection



//DELETE REPEATED RECORD IN A FILTERED COLLECTION:
if(ExampleArray.size()>1) //Validates if the collection has replicated records with the specified filter condition
{
	Me.deleteCollectionItem("mProcessEntityName.xCollectionName",ExampleArray[0]); //Delete the duplicated record of the example array collection
}






//VALIDATE IF AT LEAST ONE RECORD EXISTS IN THE COLLECTION GIVEN A FILTERED CONDITION STATIC FILTERS
var bExists=<exists(mProcessEntityName.xCollectionName[kmProdExec.bCloudActionReq = false AND kmProdExec.bExecuted != true])>;






//VALIDATE IF AT LEAST ONE RECORD EXISTS IN THE COLLECTION GIVEN A FILTERED CONDITION DYNAMIC FILTERS
var exists=CustomMe.getXPath("exists(xCollectionName[kpForeignKey.sStringAttribute  ='"+ sStringVariable +"'])");

var exists=Me.getXPath("exists(mProcessEntityName.xCollectionName[kpForeignKey.sStringAttribute  ='"+sStringVariable+"'])");

var exists=Me.getXPath("exists(mProcessEntityName.xCollectionName[kpForeignKey.sStringAttribute = '1'])");







//SUM ALL VALUES OF A COLLECTION INTEGER/CURRENCY ATTRIBUTE WITH CUSTOM FILTER
var AttributeSum= Me.getXPath("sum(mProcessEntityName.kmForeignKey.xCollectionName[kpForeignKey.StringAttributeName = '"+StringVariable+"'AND kpForeignKey.kpForeignKey2.StringAttributeName = '"+StringVariable2+"' AND StringAttributeName = '"+StringVariable3+"'].cCurrencyAttribute)");

var AttributeSum=<sum(mProcessEntityName.kmForeignKey.xCollectionName[PaymentByCompany.MethodofPayment.Code = 'REI'].cCurrencyAttribute)>; //This function version doesn´t depend on Me context but ONLY works with STATIC filters
							
var AttributeSum=<sum(xCollectionName[kpRelatedAttribute != null].iIntegerAttribute)>;





//COUNT RECORDS OF A FILTERED COLLECTION ONLY WITH STATIC FILTERS
var countRecords = <count(mProcessEntity.xCollectionName[kpForeignKeyParamEntity.iAttributeName = mProcessEntity.AttributeName])>;

var countRecords=<count(mProcessEntity.xCollectionName[kpStatus.sCode = '5'])>;






//IDENTIFY THE MAXIMUN VALUE OF A COLLECTION INTEGER ATTRIBUTE
var maxValue= <max(mProcessEntity.xCollectionName.iIntegerAttribute)>;

var zero=0;

var maxValue=CHelper.Math.Max([<max(mProcessEntity.xCollectionName.iIntegerAttribute)>, zero]);





//DECLARE AN ARRAYLIST AND ADD ITEMS INSIDE A BUSINESS RULE
var arrayListName = new ArrayList();
arrayListName.Add(VariableName);





//OBTAIN UNIQUE ATTRIBUTE RECORDS FROM A COLLECTION 
var DistinctRecordsArray = <distinct-values(mProcessEntityName.xCollectionName.AttributeName)>;
var CollectionArray = CHelper.GetValueAsCollection(DistinctRecordsArray);





//ATTACH NEW RECORDS TO COLLECTION1 FROM COLLECTION2 ACCORDING TO SPECIFIC CONDITION 
	Me.attachCollectionItems("mProcessEntity.xCollection1Name", Me.getXPath("mProcessEntity.xCollectionName2[kpStatus.sCode = '5']")); //xCollectionName and xCollectionName2 must be collections of the same entity



//ATTACH RECORDS TO COLLECTION1 FROM COLLECTION2 USING A FOR LOOP

var collection2Array=CHelper.GetValueAsCollection(<mProcessEntity.xCollection2>);


			for(var k=0;k<collection2Array.size();k++)
			{
					var oCollectionRecord=collection2Array.get(k);

					Me.attachCollectionItem("mProcessEntity.xCollection1", oCollectionRecord);

					var oNestedCollection=oCollectionRecord.getXPath("xNestedCollection");  //ATTACH RECORDS TO COLLECTION1 FROM A COLLECTION INSIDE COLLECTION2


							for(var c=0;c<oNestedCollection.size();c++)
							{

									var oCollectionRecord=oNestedCollection.get(c);

									Me.attachCollectionItem("mProcessEntity.xCollectionNth", oCollectionRecord);

							}




//DETTACH EXISTING RECORDS IN COLLECTION1 ACCORDING TO CRITERIA
	Me.detachCollectionItems("mProcessEntity.xCollection1Name", Me.getXPath("mProcessEntity.xCollectionName[kpStatus.sCode = '5']"));
	






//CHELPER METHODS TO CREATE COLLECTION ARRAYS ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//OBTAIN DATA FROM ACTIVITY SCOPE
var collectionArray=CHelper.GetValueAsCollection(<mProcessEntityName.kmForeignKeytoEntity2.xCollectionName>);  
var collectionArraySize=collectionArray.size();


//STATIC FILTER IN CHELPER METHODS
var collectionArray = CHelper.GetValueAsCollection(<mProcessEntityName.xCollectionName[bBooleanAttributeName = true]>);

var collectionArray = CHelper.GetValueAsCollection(<mProcessEntityName.xCollectionName[cCurrencyAttributeName = null OR cCurrencyAttributeName <= 0]>);

var collectionArray = CHelper.GetValueAsCollection(<mProcessEntityName.xCollectionName[kmForeignKeytoEntity.bBooleanAttributeName = true]>);

var collectionArraySize=collectionArray.size();


//DYNAMIC FILTER IN CHELPER METHODS
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








//CENTITYMANAGER METHODS TO CREATE COLLECTION ARRAYS (FROM PARAMETER ,MASTER AND SYSTEM WF ENTITIES)-------------------------------------------------------------------------------------------------------------------------------
//OBTAIN DATA FROM DATABASE WITHOUT CONTEXT REFERENCE  (THEY COMPILE IN GLOBAL RULES OR START EVENTS )
//CENTITYMANAGER GET ENTITY METHOD CAN ONLY BE FILTERED BY ATTRIBUTES DIRECTLY RELATED TO THE SEARCHED ENTITY,  ATTRIBUTES IN RELATED/CONNECTED ENTITIES CAN´T BE NAVIGATED
var collectionArray=CEntityManager.GetEntity("EntityName").GetEntityList("","","","");

var filterString = "sStringAttributeName = 'StringSampleText' ";
var filterStringConcat="sStringAttribute='"+sStringVariable+"'";

var filterBoolean="bBooleanAttributeName ="+true;

var filterDate="dDateAttribute IS NOT NULL";

var MultiplefiltersExample = "(bBooleanAttributeName <>" + true + " OR bBooleanAttributeName IS NULL) and dDateAttribute > "+ "'" + DateVariable.ToString("yyyy-MM-dd") + "'" +" and dDateAttribute2 <= " + "'" + DateVariable2.ToString("yyyy-MM-dd")+ "'";

var collectionArray = CEntityManager.GetEntity("EntityName").GetEntityList("", "", MultiplefiltersExample, "");

var collectionArray = CEntityManager.GetEntity("EntityName").GetEntityList("","","iIntegerAttribute="+Array[i]+" AND bBooleanAttribute=1","");

var collectionArray=CEntityManager.GetEntity("EntityName").GetEntityList("","","sStringAttribute='"+sStringVariable+"'","");

var collectionArraySize=collectionArray.Length;

	//Obtain primary key of i-th entity record
		var primaryKeyRecord-ith = collectionArray[i].SurrogateKeyValue;

	//Obtain attribute of i-th entity record 

	var attributeValueRecord-ith=collectionArray[i].Attributes["AttributeName"].Value;
	
	if(attributeValueRecord.Contains('@')){....}









//ME ENTITY LIST METHODS TO CREATE COLLECTION ARRAYS (FROM PARAMETER ,MASTER AND SYSTEM WF ENTITIES)---------------------------------------------------------------------------------------------------------------------------------
//OBTAIN DATA FROM DATABASE WITH CONTEXT ME REFERENCE (THEY DON´T COMPILE IN GLOBAL RULES OR START EVENTS )
var collectionArray= Me.getXPath("entity-list('EntityName','')");


//STATIC FILTER SYNTAX ENTITY LIST
var collectionFilteredArray = Me.getXPath("entity-list('pEntityName','sStringAttributeName =\"UK\"')");
var collectionFilteredArray = Me.getXPath("entity-list('Wfuser','username =\""+sStringAttributeName+"\"')"); //Filter all records where username equals ...
var collectionFilteredArray = Me.getXPath("entity-list('pEntityName','sStringAttributeName <>\"Insert String Value Here\"')"); //Filter all records where the attribute value is different than...


//DYNAMIC FILTER SYNTAX ENTITY LIST
var filter="mEntityName.dDateAttributeName= "+"\""+startDateString+"\""+" and mEntityName.dDateAttributeName2= "+"\""+endDateString+"\"";

var filter="mEntityName.dDateAttributeName= "+"\""+startDateString+"\""+" and mEntityName.dDateAttributeName2= "+"\""+endDateString+"\""+" and kpForeignKey.sStringAttribute= "+"\""+StringVariable+"\""+" and mEntityName.sStringAttribute= "+"\""+StringVariable+"\"";

var filter="kpForeignKey.sStringAttribute = "+"\""+ sStringVariable+"\""+" and bBooleanAttribute = true and kpForeignKey.ksForeignKeySystemEntity.bBooleanAttribute=true";
		
var filter="iIntegerAttribute="+ExampleArray[i]+" AND bBooleanAttribute=1";


var collectionArray=Me.getXPath("entity-list('EntityName','sStringAttributeName2 =\""+sStringVariable+"\""+" and sStringAttributeName <>\"Insert String Value Here\"')");

var collectionArray = Me.getXPath("entity-list('SystemEntityName','"+filter+"')");		

var collectionArray=Me.getXPath("entity-list('pParamEntityName','"+filter+"')");
var collectionArray=Me.getXPath("entity-list('EntityName','"+filter+"')");

//ME ENTITY LIST  ARRAY NAVIGATION FOR-LOOP SYNTAX:
for(var i=0; i<collectionArray.size(); i++)
{
	//OBTAIN PRIMARY KEY OF I-TH ENTITY RECORD
	var primaryKeyRecord-ith = Me.getXPath("entity-list('EntityName')")[i];
	
	var  primaryKeyRecord-ith = collectionArray[i];
	
	var  primaryKeyRecord-ith =collectionArray.get(i);
	
	//OBTAIN THE NUMERIC VALUE OF THE PRIMARY KEY OF THE I-TH ENTITY RECORD
	var primaryKeyRecord-ith=collectionArray.get(i).getXPath("Id"); //OBTAIN THE NUMERIC VALUE OF THE PRIMARY KEY OF THE I-TH ENTITY RECORD
	
	//Obtain attribute of i-th entity record 
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	var attributeValueRecord-ith=collectionArray.get(i).getXPath("kpForeignKey.ksForeignKeySystemEntity");

	

}








//XPATH NAVIGATION TO OBTAIN COLLECTION ARRAYS----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//OBTAIN DATA FROM ACTIVITY SCOPE WITH CONTEXT ME REFERENCE 
var collectionArray =Me.getXPath("mProcessEntityName.kmForeignKey.xCollectionName[RequestedItem.ItemIndex = "+index+" ].iIntegerAttributeName"); //Creates an array with one column containing iIntegerAttributeName values filtered



//OBTAIN VALUE FROM ONE ATTRIBUTE IN PARTICULAR INSIDE A COLLECTION ARRAY
var collectionAttributeValue=<mProcessEntityName.xCollectionName[1].AttributeName>;  //INDEX START IN 1 USING THIS SYNTAX

var idkmCP= Me.getXPath("mONB.xCP[kpStatus.sCode = '3' AND kmCP.kpSKU.kpProductType.kpSupportType.sCode != null AND kmCP.kpSKU.kpProductType.kpSupportType.bPremium != true].kmCP

var sTechLastName = <mONB.xOnbContacts[kpContactRole.sCode = '6'].kmPerson.sLastName>;

var iIdService = Me.getXPath("mONB.kmCustomer.xCustomerServices[kmCP.Id = "+iIdCP+"].Id");

Me.setXPath("mONB.kmCustomer.xCustomerServices[kmCP.Id = "+iIdCP+"].kpStatus",iIdStatusActive);
		
		
		
		
//CREATE CUSTOM COLLECTION ARRAYS CONTAINING ONE ATTRIBUTE (ONE COLUMN)

//CREATES AN ARRAY WITH ONE COLUMN CONTAINING ATTRIBUTENAME VALUES FILTERED
var collectionArray=<mProcessEntityName.xCollectionName[...].AttributeName>;  

 //CREATES AN ARRAY WITH ONE COLUMN CONTAINING KMFOREINGKEY ID VALUES FILTERED
var collectionArray=<mProcessEntityName.xCollectionName[...].kmForeingKey.Id>; 

//CREATES AN ARRAY CONTAINING ALL ATTRIBUTE COLUMNS OF THE COLLECTION ENTITY
var collectionArray = <mProcessEntityName.xCollectionName>; 

var collectionArraySize=collectionArray.size();  //Array size 

var collectionArraySize=<mProcessEntityName.kmForeignKeyEntity2.xCollectionName>.size(); //Array size





//XPATH COLLECTION NAVIGATION FOR-LOOP SYNTAX:
for(var i=0; i<collectionArray.size(); i++)  //Or
for(var i=0;i< <mProcessEntityName.kmForeignKeyEntity2.xCollectionName>.size();i++)
{
	//OBTAIN PRIMARY KEY OF I-TH ENTITY RECORD
	var primaryKeyRecord-ith = <mProcessEntityName.kmForeignKeyEntity2.xCollectionName>[i];  //INDEX i STARTS IN 0 USING THIS SYNTAX
	
	var primaryKeyRecord-ith=collectionArray[i].getXPath("Id"); //Obtain the NUMERIC value of the primary key of the i-th entity record
	
	
	//OBTAIN ATTRIBUTE OF I-TH ENTITY RECORD 
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	
	var attributeValueRecord-ith = <mProcessEntityName.kmForeignKeyEntity2.xCollectionName>[i].getXPath("AttributeName");  //INDEX i STARTS IN 0 USING THIS SYNTAX
	
	if(CHelper.IsNull(attributeValueRecord-ith)){ ... }
	
	
	
	//OBTAIN DATA FROM ACTIVITY SCOPE WITH CUSTOMMEEXAMPLE REFERENCE
	var collectionArrayRecord-ith = collectionArray[i].getXPath("xCollectionNameofRecord-ith");
	
	var collectionArrayRecord-ith=<mProcessEntityName.kmForeignKeyEntity2.xCollectionName>[i].getXPath("xCollectionNameofRecord-ith");
	
	var collectionFilteredArrayRecord-ith =CustomMe.getXPath("xCollectionNameofRecord-ith[kpForeignKey.sStringAttribute ='"+ StringVariable +"'])"); //CustomMe refers to collectionArray[i] object
	
	
	var newRecord= CustomMe.newCollectionItem("xCollectionNameofRecord-ith");
	

	newRecord.setXPath("BuildingC",attendees[i].getXPath("SelectedWorkshop[Selected = true AND Workshop.WorkshopType.Code = "+codigo+"].BuildingConectorsPre").toString()+"%")
}
	
	
	




//CHELPER METHOD TO OBTAIN AND MANIPULATE USER PROPERTIES ARRAYS (USER ROLES, SKILLS, ETC.)----------------------------------------------------------------------------------------------------------------------------------------------------------
//OBTAIN ALL USERS WITH CERTAIN ROLE:
var UsersRoleArray=CHelper.getUsersForRole("UserRoleName");
var UsersPositionArray=CHelper.getUsersForPosition("UserPositionName");

for(var i=0;i<UsersRole.Count; i++){
	
	//OBTAIN PRIMARY KEY (WF USER ID) OF I-TH RECORD 
	var userId=UsersRoleArray[i];
	
}


//VALIDATE IF A SPECIFIC USER HAS CERTAIN ROLE
if(<mProcessEntity.kmWFUserForeingKey.Roles[roleName = 'UserRoleName']>!=null){...}




//METHOD THAT OBTAINS THE SIZE OF AN ARRAY CONTAINING ALL ASSIGNEES OF AN ACTIVE TASK/ACTIVITY 

var CountUsersAssigned=Me.Assignees.Count;

for(var j=0;j<CountUsersAssigned;j++){

						var assigneeIterated=Me.Assignees[j].FullName; //Obtain the full name of the i-th user assigned to a task/activity
						
						

}

