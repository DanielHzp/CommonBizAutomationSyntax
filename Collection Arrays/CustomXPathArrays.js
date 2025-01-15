

// CUSTOM COLLECTION ARRAYS CONTAINING ONE ATTRIBUTE (ONE COLUMN)



//CREATES AN ARRAY WITH ONE COLUMN CONTAINING ATTRIBUTENAME VALUES FILTERED
var collectionArray=<mProcessEntityName.xCollectionName[...].AttributeName>;  



 //CREATES AN ARRAY WITH ONE COLUMN CONTAINING KMFOREINGKEY ID VALUES FILTERED
var collectionArray=<mProcessEntityName.xCollectionName[...].kmForeingKey.Id>; 






//CREATES AN ARRAY CONTAINING ALL ATTRIBUTE COLUMNS OF THE COLLECTION ENTITY
var collectionArray = <mProcessEntityName.xCollectionName>; 

var collectionArraySize=collectionArray.size();  //Array size 

var collectionArraySize=<mProcessEntityName.kmForeignKeyEntity2.xCollectionName>.size(); //Array size





//OBTAIN THE VALUE FROM ONE ATTRIBUTE IN PARTICULAR INSIDE A COLLECTION ARRAY
var collectionAttributeValue=<mProcessEntityName.xCollectionName[1].AttributeName>;  //INDEX START IN 1 USING THIS SYNTAX!!



var idkmCP= Me.getXPath("mONB.xCP[kpStatus.sCode = '3' AND kmCP.kpSKU.kpProductType.kpSupportType.sCode != null AND kmCP.kpSKU.kpProductType.kpSupportType.bPremium != true].kmCP



var sTechLastName = <mONB.xOnbContacts[kpContactRole.sCode = '6'].kmPerson.sLastName>;



var iIdService = Me.getXPath("mONB.kmCustomer.xCustomerServices[kmCP.Id = "+iIdCP+"].Id");



Me.setXPath("mONB.kmCustomer.xCustomerServices[kmCP.Id = "+iIdCP+"].kpStatus",iIdStatusActive);