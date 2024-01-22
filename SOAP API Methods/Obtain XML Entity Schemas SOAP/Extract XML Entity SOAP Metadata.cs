


//Method that extracts the XML info from an entity in order to use it in SOAP API requests
var entitiesInfo = CHelper.getXSL("mMasterEntityName", "XSLentitiesInfoOnly");

//Method that extracts the XSD info from an entity in order to use it to request SOAP API methods
var xsdInput = CHelper.getXSD("mMasterEntityName","XSDGetOnlyProject");

//Create the XML of the entity (containing all the entity attributes) using the XSD 
var xmlRequest = CEntityXmlHelper.entityToStringXmlWithScopes(Me,xsdInput,"");

//Obtain the string format XML of the entity 
var xmlentitiesInfo = CEntityXmlHelper.transformXmlAsString(xmlRequest, entitiesInfo);

//Method that extracts the XML Schema from an entity in order to use it in SOAP API requests
var schema = CHelper.getXSL("mMasterEntityName", "XSLSchemaStages");



