
//Sample syntax to manipulate file attributes in bizagi business rules 


// Set file attribute visibility if it´s not empty/null
var visible = false;

var sizeFile = <count(Xpath navigating to file attribute)>;

if (sizeFile > 0)

{

visible = true;

}

visible;   //Returns a variable true/false if the rule is executed inside the file attribute visibility property 


//Get the user that performed the task
var userId = Me.Case.WorkingCredential.UserId;

//Delete the content of a file attribute uploaded by a user
	Me.deleteAllCollectionItems("mProcessEntity.uFileAttributeName");
	
var NewCollectionRecord = Me.addRelation("mProcessEntity.xCollectionName");
	
//File attributes are treated as collections since they can store more than one file 
var fileAttributeArray = Me.getXPath("mProcessEntity.uFileAttributeName");

//Loop over each file inside the file attribute
	for (var i=0; i < fileAttributeArray.size(); i++)
	{
		//Obtain the i-th file record (primary key)
		var FileRecordtoCopy = fileAttributeArray.get(i);
		
		//Obtain the i-th file name
		var FileName = FiletoCopy.getXPath("FileName");
		
		//Obtain the i-th file content data
		var FileData = FiletoCopy.getXPath("Data");
		
//Send file attribute content (FileRecordtoCopy) to a file attribute of a new record in a collection:		
var NewFileAttributeContent = NewCollectionRecord.addRelation("uFileAttribute");
NewFileAttributeContent.setXPath("FileName", FileName);
NewFileAttributeContent.setXPath("Data", FileData);
	
	}

	

	
//Add a file content to a file attribute 
var NewFileAttributeContent = Me.addRelation("mProcessEntity.uFileAttribute");
NewFileAttributeContent.setXPath("FileName", FileName);
NewFileAttributeContent.setXPath("Data", FileData);

	