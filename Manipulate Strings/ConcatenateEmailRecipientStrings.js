


var PRManagerStakeholders=CHelper.GetUsersForStakeholder("shPRManagers");

var ManagerRecipients="";

if(PRManagerStakeholders.Count>0)
{

for(var i=0;i<SecManagerStakeholders.Count;i++)
{

var sSecManagerUser=SecManagerStakeholders[i].getXPath("associatedUser.contactEmail");

ManagerRecipients=ManagerRecipients+sSecManagerUser+";";

}

}

<mARMAssetsRisksMngt.sSCManagerRecipient>=ManagerRecipients;