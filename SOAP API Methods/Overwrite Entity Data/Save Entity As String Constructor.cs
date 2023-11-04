

//.Net constructor that builds a string XML which is a parameter of SaveEntityAsString SOAP method:

public string Xml(int idAttendee, int idCourse, ArrayList prerequisite)
        {
            string str = "<BizAgiWSParam>" + "<Entities>" + "<MasterEntityName key ='" + (object)idAttendee + "'>";
            if (idCourse == 1)
                str = str + "<ModelingPre>" + (object)Convert.ToInt32(prerequisite[0]) + "</ModelingPre>";
            if (idCourse == 2)
                str = str + "<Auto1Pre>" + (object)Convert.ToInt32(prerequisite[0]) + "</Auto1Pre>";
            if (idCourse == 3)
                str = str + "<InteanddevPre>" + (object)Convert.ToInt32(prerequisite[0]) + "</InteanddevPre>" + "<BuildingConectorsPre>" + (object)Convert.ToInt32(prerequisite[1]) + "</BuildingConectorsPre>" + "<WidgetsPre>" + (object)Convert.ToInt32(prerequisite[2]) + "</WidgetsPre>";
            if (idCourse == 4)
                str = str + "<Auto2Pre>" + (object)Convert.ToInt32(prerequisite[0]) + "</Auto2Pre>";
            return str + "</MasterEntityName>" + "</Entities>" + "</BizAgiWSParam>";
        }
		
		
		
		
		  SoaProduccion.SecureEntityManagerSOAClient managerSoaSoapClient = new SoaProduccion.SecureEntityManagerSOAClient();
             ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
               ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;

     managerSoaSoapClient.ClientCredentials.UserName.UserName = "SOAP Client User Name";
     managerSoaSoapClient.ClientCredentials.UserName.Password = "12345678";
					
	managerSoaSoapClient.saveEntityAsString(this.Xml(personList[index2].XpressId, num, prerequisite));