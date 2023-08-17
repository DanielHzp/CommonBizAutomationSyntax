


//Obtain attribute value using an XPath to navigate to the attribute (XPath starting entity depends on the business rule context/scope)
var AttributeValuetoObtain=<mMasterEntityName.Attribute>;

//Obtain attribute value using contextualized XPath method
//Me object refers to the business rule context/scope (Process or entity level)
var AttributeValuetoObtain=Me.getXPath("mMasterEntityName.Attribute");

//Obtain attribute value when XPath doesen´t start from process entity (always use it inside collection form rules)
var AttributeValuetoObtain=Me.Context.getXPath("mMasterEntityName.Attribute");


//Obtain attribute value using contextualized XPath method
//

var CustomMe=<mMasterEntityName.kmForeignKey>;

var AttributeValuetoObtain=CustomMe.getXPath("")

//Method to obtain the value of an attribute of an entity in business rules or process level expressions

g