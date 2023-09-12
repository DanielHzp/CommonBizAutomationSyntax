

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

			CHelper.NewCase(XML);