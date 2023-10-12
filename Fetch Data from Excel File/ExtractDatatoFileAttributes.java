

//Sample syntax for business rules where collections data has to be automatically uploaded from an Excel file 
//These business rules are executed when a button is clicked to upload a loaded excel file

//File attributes are handled as collection arrays because they can store multiple files or only one

// Obtains the file collection from the data model:
var uFileAttribute= <mProessEntityName.kmForeignKeyEntity.uFileAttributeName>;
var uFileAttributeContentSize = uFileAttribute.size();

// Empty file validation
if(!uFileAttributeContentSize > 0)
{
	CHelper.ThrowValidationAlert("The file is empty");
}


// Obtain the  loaded file and its data (assuming only one file is loaded)
var FileAttributeLoaded = uFileAttributeContent.get(0);

//Obtain the content of the loaded file data
var FileAttributeData = FileAttributeLoaded.getXPath("Data");


// CHelper method that extracts the file content for manipulation:
var FileContent = CHelper.GetDataTableFromWorkSheet(FileAttributeData, 0); // 0 Refers to the spreadsheet number where data is extracted

//Alternative syntax:
var FileAttributeData = <mProcessEntityName.kmForeignKeyEntity.uFileAttributeName>[0].getXPath("Data");
var FileContent = CHelper.GetDataTableFromWorkSheetAsString(FileAttributeData, 0);


// Loop over the excel spreadsheet  rows 
for(var i=0; i < FileContent.Rows.Count; i++)
{
	//Obtain the i-th object/row from the spreadsheet
	var RowExtracted-ith = FileContent.Rows[i];
	
	//Create new collection record to be populated
	var newRecordtoAdd = Me.newCollectionItem("mProcessEntityName.xCollectionSaveDataExtracted");
	
	//Standing on the i-th row iterated, extract the corresponding column values
	//0,1,2,3,4 represent the columns order from left to right on the current row
	firstColumnValue = RowExtracted-ith[0];
	SecondColumnValue = RowExtracted-ith[1];
	ThirdColumnValue = RowExtracted-ith[2];
	FourthColumnValue = RowExtracted-ith[3];
	FifthColumnValue= RowExtracted-ith[4];
	

	
	if (CHelper.IsNull(firstColumnValue))
	{
		CHelper.ThrowValidationAlert("firstColumnValue record is empty");
	}
	


newRecordtoAdd.setXPath("kmTSMStudentHistory.sCorporateEmail",firstColumnValue);
newRecordtoAdd.setXPath("kmTSMStudentHistory.sFirstName",SecondColumnValue);
newRecordtoAdd.setXPath("kmTSMStudentHistory.sLastName",ThirdColumnValue);
			
			
}
	