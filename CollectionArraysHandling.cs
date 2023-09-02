

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


//CEntityManager methods to create collection arrays
//Obtain data from database without context reference 







//Me Entity list methods to create collection arrays
//Obtain data from database with context Me reference (They don´t compile in global rules or start events )







//XPath navigation to obtain collection arrays
//Obtain data from activity scope with context Me reference 

var collectionArray =Me.getXPath("PurchaseRequisition.BlanketPOinvoices.SelectedItems[RequestedItem.ItemIndex = "+index+" ].AmountToBePaid")