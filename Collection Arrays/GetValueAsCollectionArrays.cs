

//CHELPER METHODS TO CREATE COLLECTION ARRAYS ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//OBTAIN DATA FROM ACTIVITY FORM SCOPE
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




//CHELPER METHODS FOR LOOP SYNTAX:
for(var i=0; i<collectionArray.size(); i++)
{
	//OBTAIN PRIMARY KEY OF I-TH ENTITY RECORD
	var primaryKeyRecord-ith= collectionArray.get(i);
	
	var primaryKeyRecord-ith=collectionArray.get(i).getXPath("Id"); //OBTAIN THE NUMERIC VALUE OF THE PRIMARY KEY OF THE I-TH ENTITY RECORD
	
	var primaryKeyRecord-ith=collectionArray.get(i).getXPath("idEntityName");
	
	var primaryKeyRecord-ith=collectionArray[i];
	
	
	//OBTAIN ATTRIBUTE OF I-TH ENTITY RECORD 
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	
	var attributeValueRecord-ith=collectionArray.get(i).getXPath("AttributeName");
	
}