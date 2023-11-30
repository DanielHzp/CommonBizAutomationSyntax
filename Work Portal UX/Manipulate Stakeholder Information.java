
//Commmonly used methods that return stakeholder entities information in business rules/expressions

//Return an array of users  of a stakeholder given the stakeholder name
var ArrayStakeholderUsers = CHelper.GetUsersForStakeholder("StakeholderEntityName");
var ArrayStakeholderSize = ArrayStakeholderUsers.Count;


//By default stakeholder entities create a relationship to WFUSER (associatedUser)
//Return the idUser of any user of a given stakeholder
var idStakeholderUser = ArrayStakeholderUsers[0].getXPath("associatedUser.idUser");



//RETURN THE STAKEHOLDER OBJECT ACCORDING TO THE ID OF THE USER AND THE NAME OF THE STAKEHOLDER
//Return the primary key of the stakeholder entity given a user id (associatedUser) and the stakeholder name
var idUser= "Obtain user id from WFUSER"
var idStakeholderEntity = CHelper.GetStakeholdersByUser(idUser, "StakeholderEntityName");


//Assign the stakeholder primary key to the foreing key between a process entity and the stakeholder entity
//Forces the system to populate my stuff collection of a given stakeholder 
<mProcessEntity.ksForeignKeyStakeholderEntity> = idStakeholderEntity;
