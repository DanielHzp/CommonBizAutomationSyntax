

//METHODS, FUNCTIONS AND PROPERTIES THAT OBTAIN INFORMATION ABOUT THE AN ACTIVE PROCESS OR USER TASK


//OBTAIN TASK/ACTIVITY/EVENT DISPLAY NAME OF A CURRENT PROCESS INSTANCE
var taskDisplayName = Me.Task.DisplayName;




//OBTAIN THE PROCESS NAME OF THE CASE THAT IS BEING EXECUTED
var processName=Me.Case.ProcessDefinition.Name;

if(Me.Case.ProcessDefinition.Name=="InsertProcessName"){.....}



//OBTAIN AN ARRAY OF ALL PROCESS ACTIVE WORKFLOW ELEMENTS (ACTIVITES, EVENTS, ETC.) IN A CASE AND ITERATE OVER ALL OF THEM
var workItemsArray = CaseInfo.getCurrentWorkItems();

for(var i = 0; i<workItemsArray.Count; i++)
{
	
	
			if(workItems[i].Task.Name == "EventName")
			{
				
				CHelper.setEvent(Me,Me.Case.Id,"EventName",null);  //SUBMIT OR PASS THROUGH A TASK FROM A BUSINESS RULE EXPRESSION
			}
			if(workItems[i].Task.Name == "EventName")
			{
				
				CHelper.setEvent(Me,Me.Case.Id,"EventName",null); //SUBMIT OR PASS THROUGH A TASK FROM A BUSINESS RULE EXPRESSION
			}
	
	
}