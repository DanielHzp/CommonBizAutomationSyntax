

//Automate Bizagi cases creation using a CHelper method with a SOAP web service


//Build XML parameter received as input

	var XML="<BizAgiWSParam>";
			XML+="<domain>domain</domain>";
			XML+="<userName>admon</userName>";
			XML += "<Cases><Case><Process>ProcessName</Process>";
			XML += "<Entities>";
			XML += "<mProcessEntityName>";
			XML += "<kmForeingKeytoEntityX>" + foreignKeyId + "</kmForeingKeytoEntityX>";
			XML += "<dDateAttributeName>" + Today.ToString("yyyy-MM-dd") + "</dDateAttributeName>";
			XML += "<bBooleanAttributeName1>" + 'true' + "</bBooleanAttributeName1>";
			XML += "<bBooleanAttributeName2>" + 'false' + "</bBooleanAttributeName2>";
			XML += "</mProcessEntityName></Entities></Case></Cases></BizAgiWSParam>";

			CHelper.trace(TraceName, "XML Request input: "+XMl);

			CHelper.usingXPath("kmForeingKeytoEntityX");   // Used to force deployment of foreign key


			CHelper.NewCase(XML);
			
			
			
			
			
			
//SOA is a family of library rules called in a business rule in order to use the method create cases as string 
//Input parameters values are set in variable 
try
{
	sResponse = SOA.CreateCasesAsString(Me,sHost,sUserName,sPassword,sXML);

	Common.Trace(Me,sRuleName,"sResponse: " + sResponse,2);
	
}
catch (ex)
{
	Common.Trace(Me, sRuleName, "ENDED with error:" + ex.message,5);
	
	CHelper.RaiseErrorIntermediateEvent("Invocation of CreateCasesAsString in My Bizagi failed");
}