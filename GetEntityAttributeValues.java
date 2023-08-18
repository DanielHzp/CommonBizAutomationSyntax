


//Obtain attribute value using an XPath to navigate to the attribute (XPath starting entity depends on the business rule context/scope)
var AttributeValuetoObtain=<mMasterEntityName.Attribute>;

//Obtain attribute value using contextualized XPath method
//Me object refers to the business rule context/scope (Process or entity level)
var AttributeValuetoObtain=Me.getXPath("mMasterEntityName.AttributeName");

//Obtain attribute value when XPath doesen´t start from process entity (always use it inside collection form rules)
var AttributeValuetoObtain=Me.Context.getXPath("mMasterEntityName.AttributeName");


//Obtain attribute value using contextualized XPath method
//CustomMe is an object (foreign or primary key) that refers to a context different than the business rule default context (Me)
//CustomMe lets the method getXPath navigate the data model starting from the foreign entity
var CustomMe=<mMasterEntityName.kmForeignEntityKey>;

var AttributeValuetoObtain=CustomMe.getXPath("ForeignEntityAttributeName");


//CHelper Method to obtain a SPECIFIC value of an attribute of an entity in business rules or process level expressions
// It can fetch data from any type of entity (System, parametric or master)
var AttributeValuetoObtain= CHelper.getEntityAttrib("EntityName","AttributeName(ColumnName)","sStringAttribute = '" + sStringVariable + "'");

var AttributeValuetoObtain= CHelper.getEntityAttrib("EntityName","AttributeName(ColumnName)","iIntegerAttribute = " + iIntegerVariable );

