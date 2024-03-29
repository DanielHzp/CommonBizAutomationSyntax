
// Ejemplo de sintaxis para configurar visibilidad de un campo dependiendo del rol del usuario


var visibility=false;
if (<Requester.Roles[roleName = 'ProductTeamTechLeader']>!=null)
{
	visibility=true;
}

visibility;



-------------------------------------------------------------------------------------------------------------------------------------------------------



// Ejemplo de sintaxis para extraer grupos (arrays) de usuarios segun su rol

var Users = new ArrayList();
//Depending on the change type, the role will be diferent
var UsersRole;
var WFU;
var ChangeImplementator;

UsersRole=CHelper.getUsersForRole("ProductTeamTechLeader");

	for(var i=0;i<UsersRole.Count;i++){
			
			WFU = CEntityManager.GetEntity("WFUSER").GetEntityList("","","idUser="+UsersRole[i]+" AND enabled=1","");
			
			//Or
			
			WFU=Me.getXPath("entity-list('WFUSER','idUser="+UsersRole[i].get(XPath("Id")+" AND enabled = 1')");
			
				 if( WFU.Length>0){
					 
				 	Users.Add(UsersRole[i]);
				 }
				 WFU=null;
		}	 
				 
 if(Users.Count>0)
{
	for(var j = 0;j<Users.Count;j++)
	{
		var record = Me.newCollectionItem("ChangeManagement.ImplementationContingencyP.ChangeCommitte");
		
		record.setXPath("CommitteeMember",Users[j]);
	}
	CHelper.trace("ChangeManag_Committe","Items in collection: "+<count(ChangeManagement.ImplementationContingencyP.ChangeCommitte)>);
}
else
{
	CHelper.ThrowValidationError("There was an error defining the members of the committee. Please contact your system administrator.");
}






-------------------------------------------------------------------------------------------------------------------------------------------------------


// Ejemplo para setear string o cadena de texto con correo destinatario de un usuario con rol particular

var UsersRoleC=CHelper.getUsersForRole("CloudOperationsManager");

for(var i=0; i<UsersRoleC.Count;i++)
{
	CHelper.trace("Final email notifications CH", i);
	
	var idUserC=UsersRoleC[i];
	WFU=CEntityManager.GetEntity("WFUSER").GetEntityList("","","idUser="+idUserC+" AND enabled=1","");

	if(WFU.Length>0)
	{
		var destinatario = CHelper.getEntityAttrib("WFUSER","contactEmail","idUser="+idUserC);
		CHelper.trace("Final email notifications CH", "destinatario "+destinatario);
		
		destinatarios = destinatarios + destinatario + ";";
		CHelper.trace("Final email notifications CH", "destinatarios final "+destinatarios);

		/*<ChangeManagement.RFCProductRecipientsNotif>= CHelper.getEntityAttrib("WFUSER","contactEmail","idUser="+idUserC+ " AND enabled=1")+";"+<ChangeManagement.RFCProductRecipientsNotif>;
		CHelper.trace("Final email notifications CH", <ChangeManagement.RFCProductRecipientsNotif>);
		*/
	}
	else
	{
		CHelper.ThrowValidationError("Cloud operations manager couldn't be notified about the results of this case, make sure the are users with this role");
	}
}
<ChangeManagement.RFCProductRecipientsNotif> = destinatarios;
}








-------------------------------------------------------------------------------------------------------------------------------------------------

//Configurar Visibilidad de campos dependiendo del rol del usuario usando un filtro en la entidad del usuario: 

var visibility=false;

var traceName = "Change management visilibility labels"+Me.Case.CaseNumber;
if (<Requester.Roles[roleName = 'SupportEngineer']>!=null)
{
CHelper.trace(traceName, "Support case creator role: "+<Requester.Roles[roleName = 'SupportEngineer']>);

	if(<ChangeResponsibleDecision.Code>=='NORM'){
	
	visibility=true;
	
	}
	else{
	visibility=false;
	}
}
else{
CHelper.trace(traceName, "Support case creator role: "+<Requester.Roles[roleName = 'SupportEngineer']>);
visibility=false;
}
CHelper.trace(traceName, "Label visible?"+visibility);
visibility;









-----------------------------------------------------------------------------------------------------------------------------------------------
var traceName = "Change management RFC type "+Me.Case.CaseNumber;
if (<Requester.Roles[roleName = 'SupportEngineer']>!=null)
{
CHelper.trace(traceName, "Support case creator role: "+<Requester.Roles[roleName = 'SupportEngineer']>);
	<ChangeManagement.bIsSupportRequest>=true;
}
else{
CHelper.trace(traceName, "Support case creator role: "+<Requester.Roles[roleName = 'SupportEngineer']>);
<ChangeManagement.bIsSupportRequest>=false;
}
CHelper.trace(traceName, "Is this case a support RFC?"+<ChangeManagement.bIsSupportRequest>);












-----------------------------------------------------------------------------------------------------------------------------------------------------

// SET fields visibility depending on users role using a boolean expression:


var traceName = "Change management visilibility labels"+Me.Case.CaseNumber;
var visibility = false;

var roleSupportEngineer = Me.Case.WorkingCredential.IsInRole("SupportEngineer");

CHelper.trace(traceName, "roleSupportEngineer: "+roleSupportEngineer);

if (roleSupportEngineer)
{
	var changeType  = <ChangeResponsibleDecision.Code>;
	CHelper.trace(traceName, "changeType: "+changeType);
	if (changeType == 'STD')
	{
		visibility = true;
	}
}
CHelper.trace(traceName, "visibility: "+visibility);
visibility;










-----------------------------------------------------------------------------------------------------------------------------------------------------


//This expression filters the WFUSER entity by position to obtain only the legal department employees
var filter = "idUser in(";
var skill;
if(<ChangeManagement.ChangeRequested.ChangeType.Code>=="IT"){
skill = "ChangeResponsible";
}else if(<ChangeManagement.ChangeRequested.ChangeType.Code>=="CL"){
skill = "CloudChangeManagement";
}else if(<ChangeManagement.ChangeRequested.ChangeType.Code>=="RB"){
skill = "RebaseChangeManagement";
}else{
skill = "OperationsChangeResponsibl";
}
var userSkill = CHelper.getUsersForSkill(skill);
for(var i = 0; i<userSkill.Count;i++){
var CurrentID = userSkill(i);
if(filter == "idUser in("){
filter = filter + CurrentID;
}else{
filter = filter + "," + CurrentID;
}
}
filter = filter + ")";
filter;







--------------------------------------------------------------------------------------------------------------------------------------------------------------------