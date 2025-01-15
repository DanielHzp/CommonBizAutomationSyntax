
//XPATH SYNTAX USED TO OBTAIN AND LOOP OVER COLLECTION ARRAYS----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//OBTAIN DATA FROM FORM SCOPE TO CREATE A COLLECTION ARRAY 
var collectionArray =Me.getXPath("mProcessEntityName.kmForeignKey.xCollectionName[RequestedItem.ItemIndex = "+index+" ].iIntegerAttributeName"); //Creates an array with one column containing iIntegerAttributeName values filtered



//OBTAIN THE VALUE FROM ONE ATTRIBUTE IN PARTICULAR INSIDE A COLLECTION ARRAY
var collectionAttributeValue=<mProcessEntityName.xCollectionName[1].AttributeName>;  //INDEX START IN 1 USING THIS SYNTAX


//OBTAIN THE VALUE FROM ONE ATTRIBUTE INSIDE A COLLECTION ARRAY USING A COLLECTION FILTER:

//EXTRACTS THE RELATIONSHIP ID (FOREING KEY) OF A COLLECTION RECORD (xCP) THAT MEETS THE FILTER CRITERIA
var idkmCP= Me.getXPath("mONB.xCP[kpStatus.sCode = '3' AND kmCP.kpSKU.kpProductType.kpSupportType.sCode != null AND kmCP.kpSKU.kpProductType.kpSupportType.bPremium != true].kmCP

var sTechLastName = <mONB.xOnbContacts[kpContactRole.sCode = '6'].kmPerson.sLastName>; //EXTRACT THE LAST NAME ATTRIBUTE VALUE OF A RECORD THAT MEETS THE FILTER CRITERIA

var iIdService = Me.getXPath("mONB.kmCustomer.xCustomerServices[kmCP.Id = "+iIdCP+"].Id");  //EXTRACT THE ID OF A COLLECTION RECORD THAT MEETS THE FILTER CRITERIA

		
		
		


//XPATH COLLECTION  FOR-LOOP SYNTAX:
for(var i=0; i<collectionArray.size(); i++)  //Or
for(var i=0;i< <mProcessEntityName.kmForeignKeyEntity2.xCollectionName>.size();i++)
{
	
	//OBTAIN PRIMARY KEY OF I-TH ENTITY RECORD
	var primaryKeyRecord-ith = <mProcessEntityName.kmForeignKeyEntity2.xCollectionName>[i];  //INDEX i STARTS IN 0 USING THIS SYNTAX
	
	var primaryKeyRecord-ith=collectionArray[i].getXPath("Id"); //OBTAIN THE NUMERIC VALUE OF THE PRIMARY KEY OF THE I-TH COLLECTION RECORD
	
	
	
	//OBTAIN ATTRIBUTE OF EACH COLLECTION RECORD IN THE FOR LOOP
	var attributeValueRecord-ith=collectionArray[i].getXPath("AttributeName");
	
	var attributeValueRecord-ith = <mProcessEntityName.kmForeignKeyEntity2.xCollectionName>[i].getXPath("AttributeName");  //INDEX i STARTS IN 0 USING THIS SYNTAX
	
	if(CHelper.IsNull(attributeValueRecord-ith)){ ... }
	
	
	
	
	//OBTAIN A COLLECTION INSIDE ANOTHER COLLECTION RECORD (EXTRACT A COLLECTION FROM EACH  RECORD IN THE FOR-LOOP)
	var collectionArrayRecord-ith = collectionArray[i].getXPath("xCollectionNameofRecord-ith");
	
	var collectionArrayRecord-ith=<mProcessEntityName.kmForeignKeyEntity2.xCollectionName>[i].getXPath("xCollectionNameofRecord-ith");
	
	
	
	//OBTAIN A COLLECTION INSIDE ANOTHER COLLECTION RECORD USING A FILTER (EXTRACT A COLLECTION FROM EACH  RECORD IN THE FOR-LOOP)
	var CustomMe=collectionArray[i];
	var collectionFilteredArrayRecord-ith =CustomMe.getXPath("xCollectionNameofRecord-ith[kpForeignKey.sStringAttribute ='"+ StringVariable +"'])"); //CustomMe refers to collectionArray[i] object
	
	
	
	
	//ADD A NEW  RECORD TO THE INNER COLLECTION OF EACH RECORD
	var newRecord= CustomMe.newCollectionItem("xCollectionNameofRecord-ith");
	
	
	
	//SET THE VALUE OF AN ATTRIBUTE IN THE INNER COLLECTION RECORD CREATED
	newRecord.setXPath("sStringAttribute",array[i].getXPath("SelectedWorkshop[Selected = true AND Workshop.WorkshopType.Code = "+codigo+"].BuildingConectorsPre").toString()+"%")
}