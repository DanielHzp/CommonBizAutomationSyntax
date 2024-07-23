
//Sample syntax to create filters inside search/ dropdown lists or suggest fields in Bizagi forms

var filter;

filter="((bBooleanAttribute=true)"+"AND"+"(kmRelatedAttribute IS NOT NULL))"+"OR"+"(bBooleanAttribute2=true)";


filter;  //The output of filter business rules is a variable containing the condition that must be executed to query the entity data