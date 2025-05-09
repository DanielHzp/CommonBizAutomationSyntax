
//Ways to assign values to master entity attributes in business rules at process or entity level


//Assign a value to an attribute in mEntity, depends on xpath context navigation (process or entity level)
<mProcessEntityName.kmForeignKeytoEntity2.attributeName> = valueToAssign;




//Assign a value to an attribute in mEntity, depends on expression context (process or entity level)
//Attribute value remains in the current scope, doesen't PERSIST in the database
Me.setXPath( "mEntityName.attributeName", valueToAssign);
Me.setXPath("mEntityName.StringAttributeName","String value");






//Assign a value to attribute in mEntity of a collection, depends on expression context (process or entity level)
//CustomMe is an object (foreign or primary key) that refers to a context different than the business rule default context (Me)
//CustomMe lets the method setXPath navigate the data model starting from the foreign entity 
var CustomMeExample = Me.newCollectionItem("mEntityName.xEntityCollectionName");
var valueToAssign="Sample string text"	
	
CustomMeExample.setXPath("EntityCollectionAttributeName",valueToAssign);

CustomMeExample.setXPath("EntityCollectionStringAttributeName","String Value");






//Assign a value to an attribute of  collection entity 2 which is INSIDE  collection entity 1 (i is an index inside a for-loop)
//Option 1 (mEntityName --> xEntityCollection1 --> xEntityCollection2)
var CustomMeExample = Me.newCollectionItem("mEntityName.xEntityCollection1Name["+i+"].xEntityCollection2Name");

//Obtain attribute value of collection entity 2 which is INSIDE collection entity 1 
var sValuetoAssign = Me.getXPath("mEntityName.xEntityCollection1Name[0].xEntityCollection2Name[1].sAttributeName");

CustomMeExample.setXPath("EntityCollection2AttributeName",sValuetoAssign);


//Alternate way to assign a attribute value 
//In this case we need to assign the primary key of an array record (entity list) to a foreign key
CustomMeExample.setXPath("EntityCollection2ForeignKey",ExampleArray[i].getXPath("Id"));


//ASSIGN A VALUE TO AN ATTRIBUTE OF COLLECTION ENTITY 2 WHICH IS INSIDE  COLLECTION ENTITY 1 (I IS AN INDEX INSIDE A FOR-LOOP)
//OPTION 2 (MENTITYNAME --> XENTITYCOLLECTION1 --> XENTITYCOLLECTION2)
var CustomMeExample2=Me.newCollectionItem("mEntityName.xEntityCollection1Name");

var CustomMeExample3=CustomMeExample2.newCollectionItem("xEntityCollection2");







//OVERWRITE AN EXISTING ATTRIBUTE VALUE OF A COLLECTION RECORD
//CUSTOMME AS A REFERENCE OF A BIZAGI ARRAY EXAMPLE, HERE WE NEED TO SET AN ATTRIBUTE VALUE OF A SPECIFIC RECORD IN AN ARRAY:
var ExampleScopeArray= CHelper.GetValueAsCollection(<mProcessEntityName.xCollectionName>);
var valueToAssign=items[i].getXPath("AttributeName");

ExampleScopeArray[i].setXPath("EntityCollectionAttributeName", valueToAssign);





//ALTERNATE WAY TO OVERWRITE AN EXISTING ATTRIBUTE VALUE OF A COLLECTION RECORD 
Me.setXPath("mEntityName.xEntityCollectionName["+i+"].EntityCollectionAttributeName", <mEntityName.AttributeName>);









//OVERWRITE A SPECIFIC RECORD IN AN ENTITY, THE RECORD IS SEARCHED USING THE PRIMARY KEY AS A PARAMETER
//THE ATTRIBUTE VALUE IS FORCED TO PERSIST IN THE DATABASE
var  mEntityPrimaryKey=mEntityArray.get(0).getXPath("idmEntityName");

CHelper.setAttrib("mEntityName", mEntityPrimaryKey ,"attributeName" ,valueToAssign);

CHelper.setAttrib("mEntityName", mEntityPrimaryKey ,"attributeName" ,null);



//UPDATE/OVERWRITE AN ATTRIBUTE VALUE IN THE SCOPE OF A TASK AND DATABASE OF THE APP

<mEntityName.attributeName>=valueToAssign;  //PERSIST DATA IN SCOPE OF A TASK

CHelper.setAttrib("mEntityName", mEntityPrimaryKey ,"attributeName" ,valueToAssign); //PERSIST DATA IN DATABASE





//OBTAIN AND SAVE THE PRIMARY KEY OF A PROCESS/TRANSACTIONAL MASTER ENTITY
var processEntityPrimaryKeyd=<mEntityName>;    //Primary key of the case




//CLEAN DATA VALUE OF  A MASTER ENTITY ATTRIBUTE
<mEntity1Name.kmForeingKeyEntity2.kmForeingKeyEntity3.attributeNameinEntity3> = null;


//CLEANS AN ATTRIBUTE VALUE OF ALL RECORDS OF A FILTERED COLLECTION  (TWO NESTED COLLECTIONS SAMPLE)
<mEntity1Name.xCollection1Name[bBooleanAttribute1 = true AND bBooleanAttribute2 = true].xCollection2Name[bBooleanAttribute3 == false].attributeToCleanName> = null;

<mEntity1Name.xCollection1Name[bBooleanAttribute1 = true AND bBooleanAttribute2 = true AND bBooleanAttribute3 != true].attributeToCleanName> = null;


//Sets an attribute value of ALL RECORDS of a filtered collection :
<mEntity1Name.xCollection1Name[bBooleanAttribute1 = true].attributeToSetName> = valueToAssign;

<mEntity1Name.xCollection1Name[kpForeignKeyParamEntity.sStringAttribute = 4].attributeToSetName> = true







//Clean value of a parameter entity relationship (clean dropdown list selected value)
<mEntityName.kpForeingKeyParameterEntity> = null;



//Clean values of TWO CASCADING PARAMETER ENTITIY relationships at the same time 
//Cascading dropdown lists: Process Entity ---> ParameterEntityL2 ---> ParameterEntityL1 
//ParameterEntityL2  has a relationship to ParameterEntityL1 (kpParameterEntityL2): Process Entity ---> ParameterEntityL2 ---> ParameterEntityL1

<PurchaseRequisition.kpParameterEntityL2>= null;  //Deletes Id key of the parent category L1 in the process entity table



//Set value to TWO CASCADING PARAMETER ENTITIES at the same time (two nested dropdown lists )
//ParameterEntityL2  has a relationship to ParameterEntityL1 (kpParameterEntityL2): Process Entity ---> ParameterEntityL2 ---> ParameterEntityL1
<PurchaseRequisition.kpParameterEntityL2>= CHelper.getEntityAttrib("ParameterEntityL2Name","idParameterEntityL2Name", "stringCode = 'InsertCodeValue' ");








//Save the Id of a user that enters an activity
//ksForeignKeyWFUSER is the relationship key between mEntity and a user system entity
<mEntityName.ksForeignKeyWFUSER>=Me.Case.WorkingCredential.UserId;

CHelper.trace(traceName, "Validate primary key id in system entity"+ <mEntityName.ksForeignKeyWFUSER.idUser>);















