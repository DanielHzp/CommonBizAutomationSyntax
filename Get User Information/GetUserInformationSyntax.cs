


//Methods, functions and properties that obtain information about the user currently working in an activity


//Obtain the Id of a user that enters an activity
Me.Case.WorkingCredential.UserId;


//Obtain the name of a user that enters an activity
Me.Case.WorkingCredential.FullName




//Obtain task/activity/event display name of a current process instance
var taskDisplayName = Me.Task.DisplayName;








//Methods to CANCEL/CLOSE process instances of events

var CaseId = CHelper.getCaseById(Me.Case.Id);




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











//CHelper method to obtain and manipulate user properties arrays (user roles, skills, etc.)----------------------------------------------------------------------------------------------------------------------------------------------------------
//Obtain all users with certain role:
var UsersRoleArray=CHelper.getUsersForRole("UserRoleName");
var UsersPositionArray=CHelper.getUsersForPosition("UserPositionName");

for(var i=0;i<UsersRole.Count; i++){
	
	//Obtain primary key (WF user id) of i-th record 
	var userId=UsersRoleArray[i];
	
}







//Validate if a specific user has certain role
if(<mProcessEntity.kmWFUserForeingKey.Roles[roleName = 'UserRoleName']>!=null){...}







//Method that obtains the size of an array containing all assignees of an active task/activity 

var CountUsersAssigned=Me.Assignees.Count;

for(var j=0;j<CountUsersAssigned;j++){

	var assigneeIterated=Me.Assignees[j].FullName; //Obtain the full name of the i-th user assigned to a task/activity
						
						

}