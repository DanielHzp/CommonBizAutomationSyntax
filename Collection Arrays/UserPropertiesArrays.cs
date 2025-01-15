

//CHELPER METHOD TO OBTAIN AND MANIPULATE USER PROPERTIES ARRAYS (USER ROLES, SKILLS, ETC.)----------------------------------------------------------------------------------------------------------------------------------------------------------


//OBTAIN ALL USERS WITH CERTAIN ROLE:
var UsersRoleArray=CHelper.getUsersForRole("UserRoleName");
var UsersPositionArray=CHelper.getUsersForPosition("UserPositionName");

for(var i=0;i<UsersRole.Count; i++){
	
	//OBTAIN PRIMARY KEY (WF USER ID) OF I-TH RECORD 
	var userId=UsersRoleArray[i];
	
}





//VALIDATE IF A SPECIFIC USER HAS CERTAIN ROLE
if(<mProcessEntity.kmWFUserForeingKey.Roles[roleName = 'UserRoleName']>!=null){...}





//METHOD THAT OBTAINS THE SIZE OF AN ARRAY CONTAINING ALL ASSIGNEES OF AN ACTIVE TASK/ACTIVITY 

var CountUsersAssigned=Me.Assignees.Count;

for(var j=0;j<CountUsersAssigned;j++){

						var assigneeIterated=Me.Assignees[j].FullName; //Obtain the full name of the i-th user assigned to a task/activity
						
						

}