
//Ways to assign values to master entity attributes in business rules at process or entity level


//Assign a value to an attribute in mEntity, depends on xpath context navigation (process or entity level)
<mProcessEntityName.kmForeignKeytoEntity2.attributeName> = valueToAssign;


//Assign a value to an attribute in mEntity, depends on expression context (process or entity level)
//Attribute value remains in the current scope, doesen't PERSIST in the database
Me.setXPath( "mEntityName.attributeName", valueToAssign);


//
//CustomMe is an object (foreign or primary key) that refers to a context different than the business rule default context (Me)
//CustomMe lets the method getXPath navigate the data model starting from the foreign entity 

var CustomMeExample = Me.newCollectionItem("mEntityName.xEntityCollectionName");
var valueToAssign="Sample string text"		
CustomMeExample.setXPath("EntityCollectionAttributeName",valueToAssign);



//This method overwrites a specific record in mEntity, the record is searched using the primary key as a parameter
//The attribute value is forced to PERSIST in the database
var  mEntityPrimaryKey=mEntityArray.get(0).getXPath("idmEntityName");

CHelper.setAttrib("mEntityName", mEntityPrimaryKey ,"attributeName" ,valueToAssign);

CHelper.setAttrib("mEntityName", mEntityPrimaryKey ,"attributeName" ,null);






//Obtain and save the PRIMARY KEY of a process/transactional master entity
var processEntityPrimaryKeyd=<mEntityName>;




//Clean data value of  a master entity attribute
<mEntity1Name.kmForeingKeyEntity2.kmForeingKeyEntity3.attributeNameinEntity3> = null;


//Cleans an attribute value of ALL RECORDS of a filtered collection  (two nested collections sample)
<mEntity1Name.xCollection1Name[bBooleanAttribute1 = true AND bBooleanAttribute2 = true].xCollection2Name[bBooleanAttribute3 == false].attributeToCleanName> = null;

<mEntity1Name.xCollection1Name[bBooleanAttribute1 = true AND bBooleanAttribute2 = true AND bBooleanAttribute3 != true].attributeToCleanName> = null;




//Clean value of a parameter entity relationship (clean dropdown list selected value)
<mEntityName.kpForeingKeyParameterEntity> = null;





//Clean value of TWO NESTED PARAMETER ENTITIES relationships at the same time (two nested dropdown lists )
//ParameterEntityL2  has a relationship to ParameterEntityL1  (kpParameterEntityL2)
<PurchaseRequisition.kpParameterEntityL2>= null;





//Set value to TWO NESTED PARAMETER ENTITIES at the same time (two nested dropdown lists )
//ParameterEntityL2  has a relationship to ParameterEntityL1  (kpParameterEntityL2)
<PurchaseRequisition.kpParameterEntityL2>= CHelper.getEntityAttrib("ParameterEntityL2Name","idParameterEntityL2Name", "stringCode = 'InsertCodeValue' ");





//Save the Id of a user that enters an activity
//ksForeignKeyWFUSER is the relationship key between mEntity and a user system entity
<mEntityName.ksForeignKeyWFUSER>=Me.Case.WorkingCredential.UserId;

CHelper.trace(traceName, "Validate primary key id in system entity"+ <mEntityName.ksForeignKeyWFUSER.idUser>);














