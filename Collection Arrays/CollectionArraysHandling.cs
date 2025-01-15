

//SYNTAX GUIDE TO OBTAIN, LOOP, AND MANIPULATE COLLECTION ARRAYS IN BIZAGI BUSINESS RULES



//DELETE ALL RECORDS OF A COLLECTION AT SCOPE CONTEXT
Me.deleteAllCollectionItems("mProcessEntityName.kmForeignKeytoEntity2.xCollectionName");




//USE .CONTEXT WHEN XPATH DOESN´T BEGING WITH THE PROCESS ENTITY NAME
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
	



