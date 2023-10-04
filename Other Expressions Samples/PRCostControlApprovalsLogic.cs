

var setApprovers = false;
Me.deleteAllCollectionItems("PurchaseRequisition.Purchaseapprovers");
var employee = <PurchaseRequisition.OtherUser>;
var currency = <PurchaseRequisition.RequisitionCurrency.Id>;
var isHR=<bIsHRPurchase>;
var index = 1;
var fpavalidation = false;
var mktvalidation = false;
var specialLevelValidation=false;
var mktapproverid = 0;
var mktapproverid2 = 0;
var specialLevelId=0;
var traceName = "Purchase_Requisition_Approvers_"+Me.Case.CaseNumber+".txt"
CHelper.trace(traceName, "Getting approvers for Employee " + <PurchaseRequisition.OtherUser.fullName> + " with amount " + <PurchaseRequisition.RequisitionValue>);

//CHelper.ThrowValidationError(<RequisitionValue>);
CHelper.trace(traceName, "RequisitionValue = "+<RequisitionValue>);
CHelper.trace(traceName, "RequisitionCurrency = "+<RequisitionCurrency.Code>);

while (!setApprovers)
{
	CHelper.trace(traceName, "Entra while !setApprovers");

	// set FPA approval to all HR purchases
	if(isHR && fpavalidation==false)
	{
		CHelper.trace(traceName, "Esta PO es de HR por lo que debe ser aprobada por FPA");

		//var approver = Me.newCollectionItem("PurchaseRequisition.Purchaseapprovers");
		var OUser= CHelper.getUsersForRole("FPApurchaseapprover");
		CHelper.trace(traceName,"First user id in FPApurchaseapprover array: "+OUser[0]);
		var mainFPA=CHelper.getUsersForSkill("MainFPAApprover");
		var countMainFPA=mainFPA.Count;
		CHelper.trace(traceName,"mainFPA array count:"+countMainFPA);

		//Only one user must have the Main FPA skill
		if(countMainFPA==1){

		//for(var i=0;i<mainFPA.Count;i++){
		CHelper.trace(traceName,"mainFPA user id: "+mainFPA[0]);

				var approver = Me.newCollectionItem("PurchaseRequisition.Purchaseapprovers");
				approver.setXPath("Approver",mainFPA[0]);
				//approver.setXPath("Approver",OUser[0]);
				approver.setXPath("ApprovalIndex", 1);

				if(<RequisitionCurrency.Code>!='COP')
				{
					//approver.setXPath("ApproverAmount", 10000);
					approver.setXPath("ApproverAmount", 5000);
				}
				else
				{
					//approver.setXPath("ApproverAmount", 10000000);
					approver.setXPath("ApproverAmount", 5000000);
				}


				}
		else if(countMainFPA>1){
		CHelper.trace(traceName,"Number of users with FPA main approver skill: "+countMainFPA);
		CHelper.ThrowValidationError("More than one user with FPA main approver skill");
		}
		else{
		CHelper.trace(traceName,"Number of users with FPA main approver skill: "+countMainFPA);
		CHelper.ThrowValidationError("No users with FPA main approver skill");

		}

		fpavalidation = true;
		<FPAapproval>=true;
		index=index+1;
	}


	//set FPA approval to NON HR purchases,  FPA must be added to all mkt purchases
	//if(((<RequisitionValue>>=10000 && <RequisitionCurrency.Code>!='COP') || (<RequisitionValue>>=10000000 && <RequisitionCurrency.Code>=='COP') || <IsthisaMarketingpurcha>) && fpavalidation==false)
	if(((<RequisitionValue>>=5000 && <RequisitionCurrency.Code>!='COP') || (<RequisitionValue>>=5000000 && <RequisitionCurrency.Code>=='COP') || <IsthisaMarketingpurcha>) && fpavalidation==false)
	{
		CHelper.trace(traceName, "Esta PO es >=5k o es de marketing por lo que debe ser aprobada por FPA ");
		var OUser= CHelper.getUsersForRole("FPApurchaseapprover");
		CHelper.trace(traceName,"First user id in FPApurchaseapprover array: "+OUser[0]);
		var mainFPA=CHelper.getUsersForSkill("MainFPAApprover");
		var countMainFPA=mainFPA.Count;
		CHelper.trace(traceName,"mainFPA array count:"+countMainFPA);

		if(countMainFPA==1){

			//for(var i=0;i<mainFPA.Count;i++){
				CHelper.trace(traceName,"mainFPA user id: "+mainFPA[0]);

				var approver = Me.newCollectionItem("PurchaseRequisition.Purchaseapprovers");
				approver.setXPath("Approver",mainFPA[0]);
				//approver.setXPath("Approver",OUser[0]);
				approver.setXPath("ApprovalIndex", 1);

				if(<RequisitionCurrency.Code>!='COP')
				{
					//approver.setXPath("ApproverAmount", 10000);
					approver.setXPath("ApproverAmount", 5000);
				}
				else
				{
					//approver.setXPath("ApproverAmount", 10000000);
					approver.setXPath("ApproverAmount", 5000000);
				}


				}
		else if(countMainFPA>1){

		CHelper.trace(traceName,"Number of users with FPA main approver skill: "+countMainFPA);
		CHelper.ThrowValidationError("More than one user with FPA main approver skill");
		}
		else{

		CHelper.trace(traceName,"Number of users with FPA main approver skill: "+countMainFPA);
		CHelper.ThrowValidationError("No users with FPA main approver skill");

		}

		fpavalidation = true;
		<FPAapproval>=true;
		index=index+1;
	}

	//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	/*
	// Set approval level 0,5 to business support manager POs up to 5k
	if(((<RequisitionValue><=5000 && <RequisitionCurrency.Code>!='COP') || (<RequisitionValue><=5000000 && <RequisitionCurrency.Code>=='COP')) && <Purchaser.associatedUser.Roles.roleName>=="0,5 APPROVAL LEVEL ROL TO BE CREATED" && specialLevelValidation==false){

	CHelper.trace(traceName, "Entra a if que agrega usuario con nivel especial 0,5 para POs de hasta 5k ");
	var specialLevelUser= CHelper.getUsersForRole("0,5 APPROVAL LEVEL ROL TO BE CREATED");
	specialLevelId = specialLevelUser[0];
	var approver = Me.newCollectionItem("PurchaseRequisition.Purchaseapprovers");
	approver.setXPath("Approver",specialLevelUser[0]);
	approver.setXPath("ApprovalIndex", ?? );
		if(<RequisitionCurrency.Code>!='COP')
		{
			//approver.setXPath("ApproverAmount", 10000);
			approver.setXPath("ApproverAmount", 5000);
		}
		else
		{
			//approver.setXPath("ApproverAmount", 10000000);
			approver.setXPath("ApproverAmount", 5000000);
		}

	specialLevelValidation=true;
	// crear nuevo atributo para poner una precondicion en la asignacion de la actividad de aprobacion
	CHelper.trace(traceName, "specialLevelValidation"+specialLevelValidation);
	index=index+1;
	}
	*/

	// Set marketing approval sequence -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	if(<IsthisaMarketingpurcha> && mktvalidation==false)
	{
		CHelper.trace(traceName, "Entra if IsthisaMarketingpurcha && mktvalidation==false");
		var approver = Me.newCollectionItem("PurchaseRequisition.Purchaseapprovers");
		var OUser= CHelper.getUsersForRole("MTKpurchaseapprover");
		mktapproverid = OUser[0];
		CHelper.trace(traceName, OUser[0])
		approver.setXPath("Approver",OUser[0]);
		approver.setXPath("ApprovalIndex", index);
		approver.setXPath("ApproverAmount", 1);
		mktvalidation = true;
		index=index+1;
		//Add Controller to all mkt purchases
		//BEGIN-------------------
		// SET TO TEXT TO REMOVE CONTROLLER FROM MKT APPROVAL LOGIC

		//var approver2 = Me.newCollectionItem("PurchaseRequisition.Purchaseapprovers");
		//var OUser2 = CHelper.getUsersForPosition("controller");
		//mktapproverid2 = OUser2[0];
		//approver2.setXPath("Approver",OUser2[0]);
		//approver2.setXPath("ApprovalIndex", index);
		//approver2.setXPath("ApproverAmount", 30000);
		//index=index+1;

		// MODIFIED TO SEARCH FOR CFO INSTEAD OF CONTROLLER FOR ALL MKT PURCHASES
		var approver2 = Me.newCollectionItem("PurchaseRequisition.Purchaseapprovers");
		var OUser2 = CHelper.getUsersForPosition("ChiefFinancialOfficer");
		mktapproverid2 = OUser2[0];
		approver2.setXPath("Approver",OUser2[0]);
		approver2.setXPath("ApprovalIndex", index);
		approver2.setXPath("ApproverAmount", 30000);
		index=index+1;
		//END--------------------


		// Marketing purchases subjected to FPA approval, MKTPuchaseapprover, CFO and CEO in case of req values higher than 100K
		if ((<RequisitionValue> > 100000 && <RequisitionCurrency.Code>!='COP') || (<RequisitionValue> > 100000000 && <RequisitionCurrency.Code>=='COP'))
		{
			// MODIFIED TO SEARCH FOR CEO

			var approver2 = Me.newCollectionItem("PurchaseRequisition.Purchaseapprovers");
			var OUser2 = CHelper.getUsersForPosition("BoardofDirectors");
			mktapproverid2 = OUser2[0];
			approver2.setXPath("Approver",OUser2[0]);
			approver2.setXPath("ApprovalIndex", index);
			approver2.setXPath("ApproverAmount", 100000);
			index=index+1;
			//END--------------------
		}

	}
	//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

	// Set users boss approval logic

	var approvalLevel = employee.getXPath("idPurchaseapprovallevel.Id");
	CHelper.trace(traceName, "Approval level: " + employee.getXPath("idPurchaseapprovallevel.Approvallevel"));
	var maxAmount = CHelper.getEntityAttrib("PurchaseApprovalRanges", "MaxAmount", "Currency = " + currency + " AND PurchaseApprovalLevel = " + approvalLevel);
	//Added boss1 and boss2 variables for the special case
	var boss1 = employee.getXPath("idBossUser");
	var boss2 = boss1.getXPath("idBossUser");
	CHelper.trace(traceName, "Amount for employee: " + maxAmount);
	CHelper.trace(traceName, "Requisition Value: " + <RequisitionValue>);
	//if (maxAmount >= <PurchaseRequisition.RequisitionValue>)
	if (maxAmount >= <PurchaseRequisition.RequisitionValue> || <IsthisaMarketingpurcha>)
	{
		//End of approval cycle
		CHelper.trace(traceName, "Amount is in employee's approval");
		setApprovers = true;
	}
	else
	{
		//Add approver and repeat cycle
		CHelper.trace(traceName, "Amount is outside of employee's approval");
		var boss = employee.getXPath("idBossUser");
		var approvalLevelIndex = employee.getXPath("idPurchaseapprovallevel.LevelIndex");
		CHelper.trace(traceName, "Boss of the user is " + boss.getXPath("fullName"));
		CHelper.trace(traceName, "approvalLevelIndex:  " + approvalLevelIndex);
		CHelper.trace(traceName, "Pruchaselevelindextostopbo vosabulary:  " + CHelper.resolveVocabulary(Me,"Pruchaselevelindextostopbo"));
		//Added new condition "&& boss1.getXPath("idUser") != boss2.getXPath("idUser")"
		//if (approvalLevelIndex < CHelper.resolveVocabulary(Me,"Pruchaselevelindextostopbo") && boss.getXPath("idUser") != employee.getXPath("idUser") && boss1.getXPath("idUser") != boss2.getXPath("idUser"))
		if (!<IsthisaMarketingpurcha> && approvalLevelIndex < CHelper.resolveVocabulary(Me,"Pruchaselevelindextostopbo") && boss.getXPath("idUser") != employee.getXPath("idUser") && boss1.getXPath("idUser") != boss2.getXPath("idUser"))
		{
			var approver = Me.newCollectionItem("PurchaseRequisition.Purchaseapprovers");
			approver.setXPath("Approver", boss.getXPath("idUser"));
			approver.setXPath("ApprovalIndex", index);
			var bossApprovalLevel = boss.getXPath("idPurchaseapprovallevel.Id");
			var bossMaxAmount = CHelper.getEntityAttrib("PurchaseApprovalRanges", "MaxAmount", "Currency = " + currency + " AND PurchaseApprovalLevel = " + bossApprovalLevel);
			approver.setXPath("ApproverAmount", bossMaxAmount);
			index = index + 1;
			CHelper.trace(traceName, "Adding new approver: " + boss.getXPath("fullName"));
			employee = boss;

		}
		else
		{
		CHelper.trace(traceName, "Users boss approval logic iteration ends ------------------------------------------");
			var nextApprovalIndex = approvalLevelIndex + 1;
			var setSpecialApprovers = false;

	//sets controller- Clevel high amount purchases approval logic ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
			while (!setSpecialApprovers)
			{
				CHelper.trace(traceName, "Set special approvers controller and C level while iteration begins");
				if(approvalLevelIndex>3)
				{
					//if(CHelper.GetValueAsCollection(<Purchaseapprovers[Approver.idPurchaseapprovallevel.LevelIndex = 3]>).size()==0)
					if(CHelper.GetValueAsCollection(<Purchaseapprovers[Approver.idPurchaseapprovallevel.LevelIndex = 4]>).size()==0)
					{
						//var level = CHelper.getEntityAttrib("Purchaseapprovallevel","idPurchaseapprovallevel","LevelIndex = " + 3);

						var level = CHelper.getEntityAttrib("Purchaseapprovallevel","idPurchaseapprovallevel","LevelIndex = " + 4);
						var position = CHelper.getEntityAttrib("HighPurchaseAmountApprov", "UserPosition", "Currency = " + currency + " AND Approvallevel = "+level );
						CHelper.trace(traceName, "Entra if approvalLevelIndex > 3 with userPosition with lvl 4: "+ position +" and no lvl 4 approver in the array yet");
						var specialMaxAmount = CHelper.getEntityAttrib("HighPurchaseAmountApprov", "MaxAmount", "Currency = " + currency + " AND Approvallevel = "+level);
						var usersInPosition = CHelper.getUsersForPosition(position);
						var approver = Me.newCollectionItem("PurchaseRequisition.Purchaseapprovers");
						approver.setXPath("Approver", usersInPosition[0]);
						approver.setXPath("ApprovalIndex", index);
						approver.setXPath("ApproverAmount", specialMaxAmount);
						index = index + 1;
					}

				}
				var newLevel = CHelper.getEntityAttrib("Purchaseapprovallevel","idPurchaseapprovallevel","LevelIndex = " + nextApprovalIndex);
				CHelper.trace(traceName, "New level id is : " + newLevel);
				if (newLevel == null)
				{
					CHelper.trace(traceName, "There are no more levels");
					setSpecialApprovers = true;
				}
				else
				{
					var position = CHelper.getEntityAttrib("HighPurchaseAmountApprov", "UserPosition", "Currency = " + currency + " AND Approvallevel = " + newLevel);
					var role = CHelper.getEntityAttrib("HighPurchaseAmountApprov", "UserRole", "Currency = " + currency + " AND Approvallevel = " + newLevel);
					var specialMaxAmount = CHelper.getEntityAttrib("HighPurchaseAmountApprov", "MaxAmount", "Currency = " + currency + " AND Approvallevel = " + newLevel);
					CHelper.trace(traceName, "Entra if newLevel 5 is not null and there is already a lvl 4 approver in the array, new specialMaxAmount: "+ specialMaxAmount);
					if (position != null)
					{
						CHelper.trace(traceName, "The positions is: " + position);
						//There is a position for that level and currency
						var usersInPosition = CHelper.getUsersForPosition(position);
            			if(usersInPosition.Count > 0)
						{
							var approver = Me.newCollectionItem("PurchaseRequisition.Purchaseapprovers");
							approver.setXPath("Approver", usersInPosition[0]);
							approver.setXPath("ApprovalIndex", index);
							approver.setXPath("ApproverAmount", specialMaxAmount);
							index = index + 1;
							if (specialMaxAmount >= <RequisitionValue>)
							{
								setSpecialApprovers = true;
							}
						}
					}
					else if (role != null)
					{
						CHelper.trace(traceName, "The role is: " + role);
						var userInRole = CHelper.getUsersForRole(role);
            			if(userInRole.Count > 0)
						{
							//There is a role for that level and currency
							var approver = Me.newCollectionItem("PurchaseRequisition.Purchaseapprovers");
							approver.setXPath("Approver", userInRole[0]);
							approver.setXPath("ApprovalIndex", index);
							approver.setXPath("ApproverAmount", specialMaxAmount);
							index = index + 1;
							if (specialMaxAmount >= <PurchaseRequisition.RequisitionValue>)
							{
								setSpecialApprovers = true;
							}
						}
					}
					nextApprovalIndex = nextApprovalIndex + 1;
					CHelper.trace(traceName, "The next level is " + nextApprovalIndex);
				}
			}
			setApprovers = true;
		}
	}



}
// mktapproverid is MKTpurchaseapprover id
var mktapprovers = CHelper.GetValueAsCollection(Me.getXPath("PurchaseRequisition.Purchaseapprovers[Approver.idUser = " + mktapproverid+ "]"));
CHelper.trace(traceName, "mktapproversid " + mktapproverid);
CHelper.trace(traceName, "tamano aprovermkt " + mktapprovers.size());
// MKTpurchaseapprover should only be Current CMO not repeated
if(mktapprovers.size()>1)
{
	Me.deleteCollectionItem("PurchaseRequisition.Purchaseapprovers",mktapprovers[0]);
}
//Remove Controller Duplicate
//BEGIN-------------------------------
// mktapproverid 2 is CFO id not controller anymore
var mktapprovers2 = CHelper.GetValueAsCollection(Me.getXPath("PurchaseRequisition.Purchaseapprovers[Approver.idUser = " + mktapproverid2+ "]"));
// CFO should only appear once  not repeated
if(mktapprovers2.size()>1)
{
	Me.deleteCollectionItem("PurchaseRequisition.Purchaseapprovers",mktapprovers2[0]);
}

/*
// Remove special level user duplicate
var specialLevelUsers=CHelper.GetValueAsCollection(Me.getXPath("PurchaseRequisition.Purchaseapprovers[Approver.idUser = " + specialLevelId+ "]"));
if(specialLevelUsers.size()>1)
{
	Me.deleteCollectionItem("PurchaseRequisition.Purchaseapprovers",specialLevelUsers[0]);
}
*/

//END---------------------------------
CHelper.trace(traceName, "FPAapproval flag: " + <FPAapproval>);
CHelper.trace(traceName, "Aprovers Defined1: " + <PurchaseRequisition.Approversdefined>);
<PurchaseRequisition.Approversdefined> = true;
CHelper.trace(traceName, "Aprovers Defined2: " + <PurchaseRequisition.Approversdefined>);