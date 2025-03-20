
//Sample syntax to create filters in parametric dropdown lists in forms (form combos)
//This functions return a variable containing the values to display in the dropdown list


var filter; //Function output declaration

//If the user case creator has one of these roles
if(<Requester.Roles[roleName = 'SampleUserRoleName1']>!=null || <Requester.Roles[roleName = 'SampleUserRoleName2']>!=null)
{

filter="(sParamEntityAttributeName='stringValue1')"+"OR"+"(sParamEntityAttributeName='stringValue2')";     //sParamEntityAttributeName is the parameter entity business key i.e. ssParamEntityAttributeName

}
//If the user case creator has this role
else if( <Requester.Roles[roleName = 'SampleUserRoleName3']>!=null)
{
	//If the parameter entity combo  has the following value selected
	if (<kpForeignKeyParamEntity.sParamEntityAttributeName>=="STD")
	{
		if(<kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="AS" || <kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="CP" || <kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="SCS")
		{
			filter= "(sParamEntityAttributeName='AC')" + " OR " + "(sParamEntityAttributeName='AF')"+" OR " + "(sParamEntityAttributeName='CB')"+" OR " + "(sParamEntityAttributeName='CBNC')"+" OR " + "(sParamEntityAttributeName='DF')";
		}
		if( <kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="CS")
		{
			filter= "(sParamEntityAttributeName='AC')" + " OR " + "(sParamEntityAttributeName='AF')"+" OR " + "(sParamEntityAttributeName='CBNC')"+ " OR " + "(sParamEntityAttributeName='DF')"+" OR " + "(sParamEntityAttributeName='SU')"+" OR " + "(sParamEntityAttributeName='TPS')";
		}
		if(<kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="MS")
		{
			filter= "(sParamEntityAttributeName='AC')" + " OR " + "(sParamEntityAttributeName='AF')"+ " OR " + "(sParamEntityAttributeName='DF')"+" OR " + "(sParamEntityAttributeName='CBNC')";
		}

	}
	else if(<kpForeignKeyParamEntity.sParamEntityAttributeName>=="NORM")
	{
		if(<kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="AS" || <kpForeignKeyParamEntity2.sParamEntity2AttributeName>== "CS" || <kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="CP")
		{
			filter= "(sParamEntityAttributeName='AU')" + " OR " + "(sParamEntityAttributeName='AF')"+" OR " + "(sParamEntityAttributeName='CB')"+" OR " + "(sParamEntityAttributeName='ARCHC')"+" OR " + "(sParamEntityAttributeName='UM')";
		}
		if (<kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="MS" || <kpForeignKeyParamEntity2.sParamEntity2AttributeName>== "SCS")
		{
			filter= "(sParamEntityAttributeName='AU')" + " OR " + "(sParamEntityAttributeName='AF')"+" OR " + "(sParamEntityAttributeName='CB')"+" OR " + "(sParamEntityAttributeName='ARCHC')";
		}

	}
	else
	{
	// Display the remaining  values
		filter="(sParamEntityAttributeName='AF')" + " OR " +"(sParamEntityAttributeName='AU')" + " OR "+"(sParamEntityAttributeName='DF')" + " OR "+"(sParamEntityAttributeName='AC')" + " OR "+"(sParamEntityAttributeName='ARCHC')" + " OR "+"(sParamEntityAttributeName='UM')" + " OR "+"(sParamEntityAttributeName='CBNC')" + " OR "+"(sParamEntityAttributeName='CB')" + " OR "+"(sParamEntityAttributeName='SU')" + " OR "+"(sParamEntityAttributeName='TPS')";

	}
}
else
{
//filter="(sParamEntityAttributeName='NA')";
	if(<kpForeignKeyParamEntity.sParamEntityAttributeName>=="STD")
	{
		if(<kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="ITMSP")
		{
			filter="(sParamEntityAttributeName='ITSUCC')";
		}

		if(<kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="ITND")
		{
			filter="(sParamEntityAttributeName='ITNDOFU')" + " OR " + "(sParamEntityAttributeName='ITNDCC')";
		}
		if(<kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="ITNSD")
		{
			filter="(sParamEntityAttributeName='ITDOFU')" + " OR " + "(sParamEntityAttributeName='ITDCC')";
		}
		if(<kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="ITPAAS")
		{
			filter="(sParamEntityAttributeName='ITSCC')";
		}
		if(<kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="ITSA")
		{
			filter="(sParamEntityAttributeName='ITAFU')" + " OR " + "(sParamEntityAttributeName='ITACH')";
		}
		if(<kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="ITSH")
		{
			filter="(sParamEntityAttributeName='ITSHRC')";
		}
		if(<kpForeignKeyParamEntity2.sParamEntity2AttributeName>=="ITSO")
		{
			filter="(sParamEntityAttributeName='ITOSFU')" + " OR " + "(sParamEntityAttributeName='ITOSCH')";
		}
	}
}




filter; //Return variable with filter string