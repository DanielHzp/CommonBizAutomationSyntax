
//CENTITYMANAGER METHODS TO CREATE COLLECTION ARRAYS (FROM PARAMETER ,MASTER AND SYSTEM WF ENTITIES)-------------------------------------------------------------------------------------------------------------------------------

//OBTAIN DATA FROM DATABASE WITHOUT CONTEXT FORM  (THEY COMPILE IN GLOBAL RULES OR START EVENTS )
//CENTITYMANAGER GET ENTITY METHOD CAN ONLY BE FILTERED BY ATTRIBUTES DIRECTLY RELATED TO THE SEARCHED ENTITY,  ATTRIBUTES IN RELATED/CONNECTED ENTITIES CAN´T BE NAVIGATED
var collectionArray=CEntityManager.GetEntity("EntityName").GetEntityList("","","","");

//DECLARE AND SET ARRAY FILTER VARIABLES 
var filterString = "sStringAttributeName = 'StringSampleText' ";

var filterStringConcat="sStringAttribute='"+sStringVariable+"'";

var filterBoolean="bBooleanAttributeName ="+true;

var filterDate="dDateAttribute IS NOT NULL";

var MultiplefiltersExample = "(bBooleanAttributeName <>" + true + " OR bBooleanAttributeName IS NULL) and dDateAttribute > "+ "'" + DateVariable.ToString("yyyy-MM-dd") + "'" +" and dDateAttribute2 <= " + "'" + DateVariable2.ToString("yyyy-MM-dd")+ "'";


//CREATE AN ENTITY ARRAY WITHOUT CONTEXT OR XPATH:

var collectionArray = CEntityManager.GetEntity("EntityName").GetEntityList("", "", MultiplefiltersExample, "");

var collectionArray = CEntityManager.GetEntity("EntityName").GetEntityList("","","iIntegerAttribute="+Array[i]+" AND bBooleanAttribute=1","");

var collectionArray=CEntityManager.GetEntity("EntityName").GetEntityList("","","sStringAttribute='"+sStringVariable+"'","");

var collectionArraySize=collectionArray.Length;


//OBTAIN PRIMARY KEY OF I-TH ENTITY RECORD
var primaryKeyRecord-ith = collectionArray[i].SurrogateKeyValue;



//OBTAIN ATTRIBUTE OF I-TH ENTITY RECORD 

var attributeValueRecord-ith=collectionArray[i].Attributes["AttributeName"].Value;
	
	if(attributeValueRecord.Contains('@')){....}