


// Trace syntax to log and debug code in business rules or process level expressions
// CHelper class method 

/*
*	Rule Name: INSERT BUSINESS RULE NAME HERE
*	Creator: LDEVELOPER NAME
*	Creation Date: 30/04/2024
*	Last Update: 30/05/2024
*	Description: WHAT THE BUSINESS RULE INTENDS TO EXECUTE
*/



//Variable that stores an XPath, object, variable or attribute value that will be traced when the code is compiled
var VariableToTrace= 'Variable/object/attribute/XPath to trace';

//Create trace file name concatenating a case number identifier (optional)
var traceFileName= "Insert file name where trace will be stored " + Me.Case.CaseNumber;

CHelper.trace(traceFileName, "Name of the XPath/variable/object/attribute to log: "+ VariableToTrace); 




//Example using more than one variable in a single trace

var VariableToTrace1 = Me.Case.CaseNumber;

var VariableToTrace2 = "sStringVariable ='"+sStringVariable+"'";

CHelper.trace("Insert file name where trace will be stored", "Sample text VariableToTrace1: "+VariableToTrace1+", Smaple text VariableToTrace2: "+VariableToTrace2);



//Example using multiple variables and XPaths in a single trace

var traceName = "Insert file name "+Me.Case.CaseNumber+".FileExtension";

CHelper.trace(traceName, "Sample text, XPath 1 to trace: " + <MasterEntityName.kmForeingKey.Attribute> + " additional sample text XPath 2:" + <MasterEntityName.Attribute>);