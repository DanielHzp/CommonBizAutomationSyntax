
//ARRAYLISTS CREATED IN BIZAGI STUDIO BUSINESS RULES CONTAIN ONE COLUMN

//DECLARE AN ARRAYLIST AND ADD ITEMS INSIDE A BUSINESS RULE

var arrayListName = new ArrayList();

arrayListName.Add(VariableName);




//VALIDATE IF AN ARRAYLIST CONTAINS A VALUE IN ONE OF IT'S RECORDS

var variableValue=123456

if(!arrayListName.Contains(variableValue)) //IF THE ARRAYLIST DOESN'T HAVE THE SPECIFIED VALUE
{
		arrayListName.Add(VariableName);

}


//OBTAIN THE ARRAYLIST sizeToContent

var iArrayListSize=arrayListName.Count;




//LOOP OVER ARRAYLIST RECORDS

for(var j=0;j<iArrayListSize;j++)
{
		//EXTRACT SURROGATE KEY ID FROM EACH RECORD IN THE ARRAYLIST
			var iIdCasetoCreate=arrLCMNewCases[j].toString(); 
			
}


