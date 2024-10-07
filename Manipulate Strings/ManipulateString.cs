

//STRING VALUES MANIPULATION IN BUSINESS RULES SAMPLE SYNTAX

//Convert DateTime Object into a String
var date = DateTime.Today;
var yearDate = date.Year;
var stringDate = yearDate.ToString();


//Remove all leading and trailing wite spaces from a string variable
var sModifiedString = StringValue.Trim().ToLower();
	

//Add a new line (enter command) in a string value contatenated

var sNL = System.Environment.NewLine;

sStringValue += "Sample text string value ("+sStringValue+"), additional text concatenated" + sNL;



//Remove all leading and trailing wite spaces from a string variable
var sModifiedString = StringValue.Trim().ToLower();



//Obtain task/activity/event display name of a current process instance
var taskDisplayName = Me.Task.DisplayName;

if (taskDisplayName == "Task Display Name ")
{
	StringFilterValue = "_INV_";
}



//Replace a specific part of a string with a custom String value
var sModifiedString = sModifiedString.Replace( "Specify the string or characters to BE REPLACED" , "Specify which string/characters will REPLACE"); 



//USE A LIBRARY RULE TO REPLACE A STRING VALUE (LEFT ARG) WITH INPUT STRING (RIGHT ARG)

FamilyRuleName.LibraryRuleName(Me, body , "[STRING_TAG]",<mProcessEntity.kmForeingKey.sStringAttribute>);
//REPLACE ALL [STRING_TAG]" IN A TEXT BODY WITH THE STRING VALUE OF <mProcessEntity.kmForeingKey.sStringAttribute>




//Replace spaces between characters with html space command
sStringValue = "https://URLSample="+variable1+"+|+"+variable2+"+|+"+variable3+"";
sStringValue = sStringValue.Replace(" ", "%20");






//Replace a specific part of a string with a custom String value
var StringPartToReplace="Insert characters or strings to replace in another string"

var sModifiedString = ExampleArray[i].getXPath("sStringAttributeName").Replace(" ",  String.Empty); //Delete spaces between words

var sModifiedString = sModifiedString.Replace( StringPartToReplace, "["+sModifiedString+"]"); //Replace the specified part of the string with:     [sModifiedStringValue]
	








//Simple concatenation of two string value variables
var firstName = Array[i].getXPath("sFullName");
var lastName = Array[i].getXPath("sLastName");

var fullName = firstName + " " + lastName;
	
	
	
	
	
	
//Validate if a string contains certain words/characters
var StringValue = ExampleArray[i].getXPath("sStringAttributeName");

if(StringValue.Contains('@'))  //If the string variable contains the character @
	{
		
		
	var sModifiedString = StringValue.Replace(StringPartToReplace, "mailto:"+ stringVariable);  //Replace the StringPsrtToReplace with the second parameter in the variable: StringValue
	
	
	//Replace a string part with a multiple string concatenation
	sModifiedString = StringValue.Replace(StringPartToReplace, Text1 + StringValueVariable + Text2 + ExampleArray[i].getXPath("sStringAttributeName") + Text3);
	
	}
	
	
	
	
	
	

	
	//REGULAR EXPRESSIONS MANIPULATION SAMPLE
	//oRegexStringValue is a variable that stores a regular expression command to verify if a string attribute has a valid email format
	var oRegexStringValue = new System.Text.RegularExpressions.Regex("^[[_A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[_A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?$");
	
	var oRegexStringValue = new System.Text.RegularExpressions.Regex("^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$");
	
if (oRegexStringValue.IsMatch(StringValue)==false) //Validate if a string value is equal/equivalent to another string value

if (!String.IsNullOrEmpty(StringValue) ) //Validate if a string value is null or empty
	{
			
			CHelper.ThrowValidationError("Incorrect string value format, please check email and try again");
	}
	
	
	
	
	
	
	
	//Remove all leading and trailing wite spaces from a string variable
	var sModifiedString = StringValue.Trim().ToLower();
	
	
	
	
	
	
	
	
	
	//Overwrite an attribute string value
	var sModifiedString = "First Name, ";
	var record=arrayName.get(i);
	if (record.getXPath("sStringAttributeName")=="Sample string value to validate")) //Validate if an existing collection record has a string attribute with a specific value 
	{
	sModifiedString = sModifiedString + " Email Address.";
	}
	record.setXPath("sMessage", messageVariable + sModifiedString);  //Overwrite attribute value with a concatenated string message
	
	
	
	
	
	

