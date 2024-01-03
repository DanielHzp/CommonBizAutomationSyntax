

var sRuleName, sFilter, sFilterBase, sLimitDate, sXML, sMessExc;
var olCP, olCPH;
var olM, olP, olS
var alCOM;
var i, kpStatusFT, kmCOM;
//
sRuleName = "jobCOMOnboardFuture";
Common.TraceJob(null,sRuleName,"START=================x", 1);
//
kpStatusFT = CHelper.getEntityAttrib("pProductOnboardStatus","idpProductOnboardStatus","sCode='FT'"); //future
sFilterBase = "kpProductOnboardStatus=" + kpStatusFT + " AND mCustomerProduct=";
Common.TraceJob(null, sRuleName, "sFilterBase:"+sFilterBase, 5);
//
sLimitDate = Common.DateToString(null, DateTime.Today.AddDays(CHelper.resolveVocabulary(null,"COMOnboardFutureInAdvDays")), 17);
Common.TraceJob(null, sRuleName, "sLimitDate:"+sLimitDate, 5);
//
//create list of cases that contain the Future Prods------------------------
//

sFilter = " mCustomer1 is not null "
		+  " AND kpProductOnboardStatus = " + kpStatusFT
		+  " AND dStartDate <= " +  sLimitDate;
Common.TraceJob(null, sRuleName, "sFilter:"+sFilter, 5);
//
//look for Cust Prods that are Future and require an onboarding
olCP = CEntityManager.GetEntity("mCustomerProduct").GetEntityList("", "", sFilter, "");
Common.TraceJob(null, sRuleName, "olCP.Length:"+olCP.Length, 5);
if (olCP.Length > 0)
{
	alCOM = new ArrayList();
	for (i=0; i<olCP.Length; i++)
	{
		//search the case that created the CustomerProduct as Future
		sFilter = sFilterBase + olCP[i].SurrogateKeyValue.toString();
		Common.TraceJob(null, sRuleName, "i:" + i + " sFilter:"+sFilter, 5);
		//
		olCPH = CEntityManager.GetEntity("mCustomerProductHistory").GetEntityList("", "", sFilter, "dDate");
		if (olCPH.Length>0)
		{
			kmCOM = olCPH[olCPH.Length-1].Attributes["kmCOM"].Value;
			Common.TraceJob(null, sRuleName, "mCOM found:"+kmCOM, 5);
			//
			if (!alCOM.Contains(kmCOM))
			{
				Common.TraceJob(null, sRuleName, "mCOM added:"+kmCOM, 5);
				alCOM.Add(kmCOM);
			}
		}
	}
	//
	//for each obj in array (case with future) create a case
	Common.TraceJob(null, sRuleName, "alCOM.Count:"+alCOM.Count, 5);
	for (i=0; i<alCOM.Count; i++)
	{
		sXML ="<BizAgiWSParam><domain>domain</domain><userName>BizagiJob</userName><Cases><Case><Process>CustomerOnboardingMgmt</Process><Entities><mCOM><kmCOMSourceFuture>" + alCOM[i].toString() + "</kmCOMSourceFuture></mCOM></Entities></Case></Cases></BizAgiWSParam>";
	 	Common.TraceJob(null, sRuleName, "sXML:"+sXML, 5);
		try
		{
			CHelper.NewCase(sXML);
		}
		catch (ex)
		{
			sMessExc = ex.toString();
			if (sMessExc.IndexOf(Common.GetMessage(null,112)) <= 0)
			{
				CHelper.ThrowValidationError(sMessExc);
			}
			else //ignore error
			{
				Common.Trace(null,sRuleName,"No Products. Case not created: " + sMessExc,5);
			}
		}
	}
	//
	alCOM.Clear();
}
//
Common.TraceJob(null, sRuleName, "END==================", 1);