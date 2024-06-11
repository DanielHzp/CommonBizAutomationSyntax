

//Methods, functions and properties that obtain information about the an active process or user task


//Obtain task/activity/event display name of a current process instance
var taskDisplayName = Me.Task.DisplayName;









//Obtain an array of all process active workflow elements (activites, events, etc.) in a case and iterate over all of them
var workItemsArray = CaseInfo.getCurrentWorkItems();

for(var i = 0; i<workItemsArray.Count; i++)
{
	
	
			if(workItems[i].Task.Name == "EventName")
			{
				CHelper.setEvent(Me,Me.Case.Id,"EventName",null);
			}
			if(workItems[i].Task.Name == "EventName")
			{
				CHelper.setEvent(Me,Me.Case.Id,"EventName",null);
			}
	
	
}