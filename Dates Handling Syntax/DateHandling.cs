
//Date handling syntax in busines rules and process expressions 


//Obtain the exact current date
var Today=DateTime.Today;



//Obtain the creation date of a current case instance
var creationDate = Me.Case.CreationDate;



//Obtain a date type attribute navigating the data model 
var dDateAttributeValue = <mProcessEntityName.kmForeingKeyToEntity2.dDateAttributeName>;



//C# System properties to extract all the date time components of a date attribute:
var sSecond = dDateAttributeValue.Second;
var sMinute = dDateAttributeValue.Minute;
var sHour = dDateAttributeValue.Hour;
var sDay = dDateAttributeValue.Day;
var sMonth = dDateAttributeValue.Month;
var sYear = dDateAttributeValue.Year;



//Transform a date into a string value
var date = DateTime.Today;
var yearDate = date.Year;
var stringDate = yearDate.ToString();




//Transform a date into a custom date time format value
var CustomDateFormat = CHelper.FormatDate( dDateAttributeValue, "dddd, MMMM dd, yyyy hh:mm tt"); //This function parameter receives the format standard to convert the date time value



//Extract AM/PM of a date time object
var DateValue = <mProcessEntityName.kmForeingKeyToEntity2.dDateAttributeName>.AddHours(-5);
var DateAM_PM = CHelper.FormatDate(DateValue, "tt");






//Date time object to create a custom date value. Receives date time properties as parameters
var newCustomDate = new DateTime(sYear, sMonth, sDay, sHour, sMinute, sSecond);
var newCustomDate = new DateTime(eYear, eMonth, eDay, 16, 59, 00);



//Validate if date time value is a working day or not
if(CHelper.IsWorkingDay(Me,dDateAttributeValue)==true){ ... }




//Add or substract hours, minutes, days, etc. to a date time value
var dDateAttribute = <mProcessEntityName.kmForeingKeyToEntity2.dDateAttributeName>;




//Amount of hours, minutes, days to add must be declared as an integer variable
int DaystoAdd =10;
var DateResult = dDateAttribute.AddDays(DaystoAdd);//Add 
var DateResult=dDateAttribute.AddDays(-DaystoAdd); //Substract


int HourstoAdd=5;
var DateResult = dDateAttribute.AddHours(HourstoAdd); //Add hours








//Calculate the time difference between two dates, the result is in MINUTES considering only WORKING  TIME
var minutes = CHelper.getEffectiveDuration(Me,StartDateAttribute,EndDateAttribute);
var minutes = CHelper.getEffectiveDuration(Me,StartDateAttribute,now);


//Convert to WORKING days
var days = minutes / 480;
var daysRoundedDown=CHelper.Math.Floor(days);


//Convert to WORKING days
var differenceDays = (minutes / 60) / 8;




// Calculate the date time difference between two dates. the result is in days considering calendar time (includes non working hours)
var now=DateTime.Now;

var dueDate=now.AddDays(32);
var difTime=dueDate-now;
var difTimeDays=difTime.Days;

var dDateAttribute = <mProcessEntityName.dDateAttributeName>;
var difTime=dDateAttribute-now;









// Set timer event  to wait until a specific date
Me.EstimatedSolutionDate=<mProcessEntityName.kmForeingKeyToEntity2.dDateAttributeName>;

var dateTimer=<mProcessEntityName.dDateAttributeName>;
Me.EstimatedSolutionDate=dateTimer;




//Set timer event waiting time in minutes (timer attached events)
var Customdays = CHelper.resolveVocabulary(Me,"ExampleAmountofDays");

Me.TimerEventDuration = Customdays * 8 * 60;
Me.Duration = Customdays * 8 * 60;






//Methods to CANCEL/CLOSE process instances of events

var CaseId = CHelper.getCaseById(Me.Case.Id);
var workItemsArray = CaseInfo.getCurrentWorkItems();
for(var i = 0; i<workItemsArray.Count; i++)
{
	if(workItems[i].Task.Name == "EventName")
	{
		CHelper.setEvent(Me,Me.Case.Id,"EventName",null);
	}
	if(workItems[i].Task.Name == "EventName")
	{
		CHelper.setEvent(Me,Me.Case.Id,"EventName",null);
	}
}









