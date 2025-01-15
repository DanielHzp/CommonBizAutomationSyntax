
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






//ME ENTITY LIST COLLECTION ARRAY FOR-LOOP SYNTAX:
for(var i=0; i<collectionArray.size(); i++)
{
	//OBTAIN PRIMARY KEY OF I-TH ENTITY RECORD
	var primaryKeyRecord-ith = Me.getXPath("entity-list('EntityName')")[i];
	
	var  primaryKeyRecord-ith = collectionArray[i];
	
	var  primaryKeyRecord-ith =collectionArray.get(i);
	
	
	
	//OBTAIN THE NUMERIC VALUE OF THE PRIMARY KEY OF THE I-TH ENTITY RECORD
	var primaryKeyRecord-ith=collectionArray.get(i).getXPath("Id"); //OBTAIN THE NUMERIC VALUE OF THE PRIMARY KEY OF THE I-TH ENTITY RECORD
	
	
	
	//OBTAIN ATTRIBUTE OF I-TH COLLECTION RECORD 
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	
	var attributeValueRecord-ith=collectionArray.get(i).getXPath("kpForeignKey.ksForeignKeySystemEntity");

	

}