//Sample syntax to create filter expressions in parametric dropdown lists in forms (form combos)
//Sample syntax that can be used INSIDE dropdown list fields in Bizagi user forms (parameter entities)
//This functions return a variable containing the values to display in the dropdown list


//Filter structure using in() SQL function, filter parameter entity values that have the following attribute values 
var filter = "sStringAttributeName in('StringValue','LADV','TEA')";




//Filter a parameter entity values by a value selected  in another dropdown list
var ParamEntityAttributeValue=<kmForeignKeyEntity.kpForeignKeyParamEntity1.sStringParamAttribute>;  //sStringParamAttribute could be a parameter entity business key attribute

filter="(kpForeignKeyParamEntity1.sStringParamAttribute='"+ParamEntityAttributeValue+"')"; //The filtered param entity has a  relationship to ParamEntity1






//Filter the parameter entity values that DO NOT have certain attribute values (business key attribute sCode)
var iIntegerValue= Me.Case.ParentProcessId;

if(idParent != null  && idParent !=0)
{
	var ArrayExample = CEntityManager.GetEntity("mMasterEntityExample").GetEntityList("","","iIntegerAttribute="+iIntegerValue,"");
	var ArrayExampleLength = ArrayExample.Length;
	
	if (ArrayExampleLength> 0)
	{
		//Display the attribute values in the dropdown list that do not have the following  sStringAttributeName values
		filter = "sStringAttributeName <> 'SA' AND sStringAttributeName <> 'LADV' AND sStringAttributeName <> 'NDA' AND sStringAttributeName <> 'CON'";
	}
		
		
		
		

//Concatenate multiple values in an in() SQL function inside a dropdownlist (WFUSER)
var filter = "idUser in(";
var role = "SampleRoleToSearch";
var ArrayUserswithRole = CHelper.getUsersForRole(role);

for(var i = 0; i<ArrayUserswithRole.Count;i++)
{
	var UserId-ith = ArrayUserswithRole(i);
	
	
	if(filter == "idUser in(")
	{
		filter = filter + UserId-ith;
	}else
	{
		filter = filter + "," + UserId-ith;
	}
}

//Display the WFUSER  users whose idUser value is in the in() SQL function
filter = filter + ")";







//Concatenate multiple values in an in() SQL function inside a dropdownlist
//Uses multiple conditions to create the in() filter
var ArrayUserswithRole=null; //object
var i=null; //int
var UserId-ith=null; //object
var IdValues='null'; //STRING THAT CONCATENATES THE IN() FUNCTION FILTER VALUES************************

ArrayUserswithRole = CHelper.getUsersForRole("SampleRoleToSearch1");

//Open in( SQL function
IdValues = "("

//Evaluate condition 1
for (i = 0; i < ArrayUserswithRole.Count; i = i + 1) {
	
	UserId-ith = ArrayUserswithRole(i);
	
	if (IdValues == "(")
	{
		IdValues = IdValues + UserId-ith ;
	} else {
		IdValues = IdValues + ", " + UserId-ith;
	}
}

ArrayUserswithRole = CHelper.getUsersForRole("SampleRoleToSearch2");

//Evaluate condition 2
for (i = 0; i < ArrayUserswithRole.Count; i = i + 1) 
{
	UserId-ith = ArrayUserswithRole(i);
	
	if (IdValues == "(")
	{
		IdValues = IdValues + UserId-ith ;
	} else {
		IdValues = IdValues + ", " + UserId-ith;
	}
}

//Close in() SQL function 
IdValues= IdValues + " )"


filter = "idUser in " + IdValues;



filter; //Filter variable output ************************************



//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//Sample syntax to create filter expressions in parametric dropdown lists in forms (form combos)
//This functions return a variable containing the values to display in the dropdown list
//The filtered values of the parameter entity business key are INTEGERS and STRINGS combined in single statements

var filter;

if (<kpForeignKeyParamEntity.sParamEntityAttributeName>=="STD")
{
	if(<kpForeignKeyParamEntity2.sParamEntityAttributeName>=="AS")
	{
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="DF")
		{
		filter= "(iParamEntityAttributeName=3)"+"OR"+"(iParamEntityAttributeName=18)";
		}
		if (<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AC")
		{
		filter= "(iParamEntityAttributeName=4)"+"OR"+"(iParamEntityAttributeName=16)";
		}
		if (<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="CB")
		{
		filter= "(iParamEntityAttributeName=10)"+"OR"+"(iParamEntityAttributeName=15)";
		}
		if (<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="CBNC")
		{
		filter= "(iParamEntityAttributeName=15)";
		}
		if (<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AF")
		{
		filter= "(iParamEntityAttributeName=12)";
		}
	}
	if(<kpForeignKeyParamEntity2.sParamEntityAttributeName>=="CS")
	{
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="DF")
		{
		filter= "(iParamEntityAttributeName=3)"+"OR"+"(iParamEntityAttributeName=18)";
		}
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AC")
		{
		filter= "(iParamEntityAttributeName=4)"+"OR"+"(iParamEntityAttributeName=16)";
		}
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="SU")
		{
		filter= "(iParamEntityAttributeName=11)";
		}
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AF")
		{
		filter= "(iParamEntityAttributeName=12)";
		}
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="CBNC")
		{
		filter= "(iParamEntityAttributeName=15)";
		}
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="TPS")
		{
		filter= "(iParamEntityAttributeName=19)";
		}
	}
	if(<kpForeignKeyParamEntity2.sParamEntityAttributeName>=="CP")
	{
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="DF")
		{
		filter= "(iParamEntityAttributeName=3)"+"OR"+"(iParamEntityAttributeName=18)";
		}
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AC")
		{
		filter= "(iParamEntityAttributeName=4)"+"OR"+"(iParamEntityAttributeName=16)";
		}
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="CB")
		{
		filter= "(iParamEntityAttributeName=10)";
		}
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="CBNC")
		{
		filter= "(iParamEntityAttributeName=15)";
		}
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AF")
		{
		filter= "(iParamEntityAttributeName=12)";
		}
	}
	if(<kpForeignKeyParamEntity2.sParamEntityAttributeName>=="MS")
	{
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName> == "DF")
		{
			filter= "(iParamEntityAttributeName=3)"+"OR"+"(iParamEntityAttributeName=18)";
		}
		if (<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AC")
		{
			filter= "(iParamEntityAttributeName=4)";
		}
		if (<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AF")
		{
			filter= "(iParamEntityAttributeName=12)";
		}
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="CBNC")
		{
			filter= "(iParamEntityAttributeName=15)";
		}
	}

	if(<kpForeignKeyParamEntity2.sParamEntityAttributeName>=="SCS")
	{
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>== "DF")
		{
			filter="(iParamEntityAttributeName=3)"+"OR"+"(iParamEntityAttributeName=18)";
		}
		if( <kpForeignKeyParamEntity3.sParamEntityAttributeName>== "AC")
		{
			filter="(iParamEntityAttributeName=4)"+"OR"+"(iParamEntityAttributeName=16)";
		}
		if (<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="CBNC")
		{
			filter="(iParamEntityAttributeName=15)";
		}
		if (<kpForeignKeyParamEntity3.sParamEntityAttributeName>== "CB")
		{
			filter="(iParamEntityAttributeName=10)";
		}
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AF")
		{
			filter="(iParamEntityAttributeName=12)";
		}

	}

	if(<kpForeignKeyParamEntity2.sParamEntityAttributeName>=="ASME" || <kpForeignKeyParamEntity2.sParamEntityAttributeName>=="CSME" || <kpForeignKeyParamEntity2.sParamEntityAttributeName>=="MSME" || <kpForeignKeyParamEntity2.sParamEntityAttributeName>=="SCSME")
	{
			filter= "(iParamEntityAttributeName=20)";
	}
	

}

// "(iParamEntityAttributeName=3)"+"OR"+"(iParamEntityAttributeName=18)";
if (<kpForeignKeyParamEntity.Code>=="NORM")
{
	if(<kpForeignKeyParamEntity2.sParamEntityAttributeName>=="AS")
	{
		if (<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AF")
		{
		filter="(iParamEntityAttributeName=1)";
		}
		if (<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AU")
		{
		filter="(iParamEntityAttributeName=2)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="ARCHC")
		{
		filter="(iParamEntityAttributeName=5)"+"OR"+"(iParamEntityAttributeName=6)"+"OR"+"(iParamEntityAttributeName=14)"+"OR"+"(iParamEntityAttributeName=17)";
		}
		if (<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="CB")
		{
		filter="(iParamEntityAttributeName=8)"+"OR"+"(iParamEntityAttributeName=9)"+"OR"+"(iParamEntityAttributeName=13)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="UM")
		{
		filter="(iParamEntityAttributeName=7)";
		}
	}
	if(<kpForeignKeyParamEntity2.sParamEntityAttributeName>=="CS")
	{
		if ( <kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AF")
		{
		filter="(iParamEntityAttributeName=1)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AU")
		{
		filter="(iParamEntityAttributeName=2)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="ARCHC")
		{
		filter="(iParamEntityAttributeName=5)"+"OR"+"(iParamEntityAttributeName=6)"+"OR"+"(iParamEntityAttributeName=17)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="CB")
		{
		filter="(iParamEntityAttributeName=8)"+"OR"+"(iParamEntityAttributeName=9)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="UM")
		{
		filter="(iParamEntityAttributeName=7)";
		}

	}
	if(<kpForeignKeyParamEntity2.sParamEntityAttributeName>=="CP")
	{
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AF")
		{
		filter="(iParamEntityAttributeName=1)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AU")
		{
		filter="(iParamEntityAttributeName=2)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="ARCHC")
		{
		filter="(iParamEntityAttributeName=5)"+"OR"+"(iParamEntityAttributeName=6)"+"OR"+"(iParamEntityAttributeName=17)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="CB")
		{
		filter="(iParamEntityAttributeName=8)"+"OR"+"(iParamEntityAttributeName=9)"+"OR"+"(iParamEntityAttributeName=13)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="UM")
		{
		filter="(iParamEntityAttributeName=7)";
		}

	}
	if(<kpForeignKeyParamEntity2.sParamEntityAttributeName>=="MS")
	{
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AF")
		{
		filter="(iParamEntityAttributeName=1)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AU")
		{
		filter="(iParamEntityAttributeName=2)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="ARCHC")
		{
		filter="(iParamEntityAttributeName=5)"+"OR"+"(iParamEntityAttributeName=6)"+"OR"+"(iParamEntityAttributeName=17)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="CB")
		{
		filter="(iParamEntityAttributeName=8)"+"OR"+"(iParamEntityAttributeName=9)";
		}
	}
	if(<kpForeignKeyParamEntity2.sParamEntityAttributeName>=="SCS")
	{
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AF")
		{
		filter="(iParamEntityAttributeName=1)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="AU")
		{
		filter="(iParamEntityAttributeName=2)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="ARCHC")
		{
		filter="(iParamEntityAttributeName=5)"+"OR"+"(iParamEntityAttributeName=6)"+"OR"+"(iParamEntityAttributeName=17)";
		}
		if(<kpForeignKeyParamEntity3.sParamEntityAttributeName>=="CB")
		{
		filter="(iParamEntityAttributeName=8)"+"OR"+"(iParamEntityAttributeName=9)"+"OR"+"(iParamEntityAttributeName=13)";
		}
	}
	if(<kpForeignKeyParamEntity2.sParamEntityAttributeName>=="ASME" || <kpForeignKeyParamEntity2.sParamEntityAttributeName>=="CSME" || <kpForeignKeyParamEntity2.sParamEntityAttributeName>=="MSME" || <kpForeignKeyParamEntity2.sParamEntityAttributeName>=="SCSME")
	{
			filter= "(iParamEntityAttributeName=20)";
	}
}

if(<kpForeignKeyParamEntity.Code>=="EMER")
{
			if(<kpForeignKeyParamEntity2.sParamEntityAttributeName>=="ASME" || <kpForeignKeyParamEntity2.sParamEntityAttributeName>=="CSME" || <kpForeignKeyParamEntity2.sParamEntityAttributeName>=="MSME" || <kpForeignKeyParamEntity2.sParamEntityAttributeName>=="SCSME")
			{
			filter="(iParamEntityAttributeName=20)";
			}
			else
			{
			filter="(iParamEntityAttributeName=1)"+"OR"+"(iParamEntityAttributeName=2)"+"OR"+"(iParamEntityAttributeName=3)"+"OR"+"(iParamEntityAttributeName=4)"+"OR"+"(iParamEntityAttributeName=5)"+"OR"+"(iParamEntityAttributeName=6)"+"OR"+"(iParamEntityAttributeName=7)"+"OR"+"(iParamEntityAttributeName=8)"+"OR"+"(iParamEntityAttributeName=9)"+"OR"+"(iParamEntityAttributeName=10)"+"OR"+"(iParamEntityAttributeName=11)"+"OR"+"(iParamEntityAttributeName=12)"+"OR"+"(iParamEntityAttributeName=13)"+"OR"+"(iParamEntityAttributeName=14)"+"OR"+"(iParamEntityAttributeName=15)"+"OR"+"(iParamEntityAttributeName=16)"+"OR"+"(iParamEntityAttributeName=17)"+"OR"+"(iParamEntityAttributeName=18)"+"OR"+"(iParamEntityAttributeName=19)";
			}
}

if(<Requester.Roles[roleName = 'SupportEngineer']>==null && <Requester.Roles[roleName = 'ProductManager']>==null && <Requester.Roles[roleName = 'ProductTeamTechLeader']>==null)
{
	filter="(iParamEntityAttributeName=21)";
}


filter;