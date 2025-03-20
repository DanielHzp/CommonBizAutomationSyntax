
//SAMPLE SYNTAX OF A FILTER EXPRESSION CONFIGURED IN A COMBO BOX CONTROL IN A USER FORM

//THIS EXPRESSION FILTERS THE WFUSER ENTITY BY POSITION TO OBTAIN ONLY THE LEGAL DEPARTMENT EMPLOYEES
var filter = "idUser in(";

//IF IT IS FROM VS, THE FILTER WILL USE THE POSITIONS GENERALCOUNSELVISIONSOFTWA AND LEGALCOUNSELVISIONSOFTWARE
if(<Company.Code> == "VS"){
	var userGCVS = CHelper.getUsersForPosition("GeneralCounselVisionSoftwa");
	for(var i = 0; i<userGCVS.Count;i++){
		var current = userGCVS(i);
		if(filter == "idUser in("){
			filter = filter + current;
		}else{
			filter = filter + "," +current;
		}
	}
	var userLCVS = CHelper.getUsersForPosition("LegalcounselVisionSoftware");
	for(var i = 0; i<userLCVS.Count;i++){
		var current = userLCVS(i);
		if(filter == "idUser in("){
			filter = filter + current;
		}else{
			filter = filter + "," +current;
		}
	}
}else{
	var userGCBZ = CHelper.getUsersForPosition("GeneralCounsel");
	for(var i = 0; i<userGCBZ.Count;i++){
		var current = userGCBZ(i);
		if(filter == "idUser in("){
			filter = filter + current;
		}else{
			filter = filter + "," +current;
		}
	}
	var userLCBZ = CHelper.getUsersForPosition("LegalCounsel");
	for(var i = 0; i<userLCBZ.Count;i++){
		var current = userLCBZ(i);
		if(filter == "idUser in("){
			filter = filter + current;
		}else{
			filter = filter + "," +current;
		}
	}
	var userSLCBZ = CHelper.getUsersForPosition("SeniorLegalCounsel");
	for(var i = 0; i<userSLCBZ.Count;i++){
		var current = userSLCBZ(i);
		if(filter == "idUser in("){
			filter = filter + current;
		}else{
			filter = filter + "," +current;
		}
	}
}
filter = filter + ") and enabled = 1";
filter;