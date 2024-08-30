


//Obtain attribute value using an XPath to navigate to the attribute (XPath starting entity depends on the business rule context/scope)
var AttributeValuetoObtain=<mMasterEntityName.Attribute>;

//Obtain and save the PRIMARY KEY of a process/transactional master entity
var processEntityPrimaryKeyd=<mProcessEntityName>;    //Primary key of the case (works at process level business rules)


//Obtain the foreign key INTEGER VALUE between a master entity and a parameter entity (use 'id' attribute SQL property)
var kpForeignKeyParamEntity = <mProcessEntityName.kmmMasterEntityName.kpForeignKeyParamEntity.Id>;   //'.Id' is a system attribute that gets the id number of a related attribute relationship








//Obtain attribute value using contextualized XPath method

//Me object refers to the business rule context/scope (Process or entity level)
var AttributeValuetoObtain=Me.getXPath("mProcessEntityName.AttributeName");  //Returns the VALUE of the attribute XPath



sXPathVariableName="mProcessEntityName.xCollectionName[kmLCMCP = "+iIntegerVariable+" ].kpForeingKeyParamEntity.sStringVariable";

var AttributeValuetoObtain=Me.getXPath(sXPathVariableName);  //Returns the VALUE of the attribute XPath


//Obtain attribute value when XPath doesen´t start from process entity (always use it inside collection form rules)
var AttributeValuetoObtain=Me.Context.getXPath("mMasterEntityName.AttributeName");


//Obtain attribute value using contextualized XPath method
//CustomMe is an object (foreign or primary key) that refers to a context different than the business rule default context (Me)
//CustomMe lets the method getXPath navigate the data model starting from the foreign entity
var CustomMe=<mMasterEntityName.kmForeignEntityKey>;

var AttributeValuetoObtain=CustomMe.getXPath("ForeignEntityAttributeName");









//CHelper Method to obtain a SPECIFIC value of an attribute of an entity in business rules or process level expressions
// It can fetch data from any type of entity (System, parametric or master)
var AttributeValuetoObtain= CHelper.getEntityAttrib("EntityName","AttributeName(ColumnName)","sStringAttributeName = '" + sStringVariable + "'");

//Using a constant string value in the filter
var AttributeValuetoObtain= CHelper.getEntityAttrib("EntityName","AttributeName(ColumnName)"," sStringAttributeName = '1' ");


var AttributeValuetoObtain= CHelper.getEntityAttrib("EntityName","AttributeName(ColumnName)","iIntegerAttributeName = " + iIntegerVariable );

var AttributeValuetoObtain= CHelper.getEntityAttrib("EntityName","AttributeName(ColumnName)","bBooleanAttributeName = 1"  );

//Filter with more than one attribue
var AttributeValuetoObtain= CHelper.getEntityAttrib("EntityName","AttributeName(ColumnName)", "iIntegerAttribute=" + iIntegerVariable + " AND bBooleanAttribute = 1 "  );

//Or
var AttributeValuetoObtain= CHelper.getEntityAttrib("EntityName","AttributeName(ColumnName)", "iIntegerAttribute=" + iIntegerVariable + " AND bBooleanAttribute =   true "  );






// if Conditional syntax in Bizagi    -  || ,  &&  , < , >, == , !=
//XPath navigation depends on business rule/expression context
if( <mProcessEntityName.kpForeignKeyParamEntity.sStringAttributeName>== 'sStringValue'){
	
}





// If conditional syntax using ternary operators
//XPath navigation depends on business rule/expression context
var comments = <mProcessEntityName.sStringAttributeName> == null ? "" : <mProcessEntityName.sStringAttributeName>;