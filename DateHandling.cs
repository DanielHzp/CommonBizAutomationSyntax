


//Date handling syntax in busines rules and process expressions 


//Obtain the exact current date
var Today=DateTime.Today;


//Obtain a date type attribute navigating the data model 
var dDateAttributeValue = <mProcessEntityName.kmForeingKeyToEntity2.dDateAttributeName>;

//C# System properties to extract all the date time components of a date attribute:
var sSecond = dDateAttributeValue.Second;
var sMinute = dDateAttributeValue.Minute;
var sHour = dDateAttributeValue.Hour;
var sDay = dDateAttributeValue.Day;
var sMonth = dDateAttributeValue.Month;
var sYear = dDateAttributeValue.Year;


//Date time object to create a custom date value. Receives date time properties as parameters
var newCustomDate = new DateTime(sYear, sMonth, sDay, sHour, sMinute, sSecond);


//Validate if date time value is a working day or not
if(CHelper.IsWorkingDay(Me,dDateAttributeValue)==true){ ... }


//Calculate the time difference between two dates, the result is in MINUTES considering only WORKING  TIME
var minutes = CHelper.getEffectiveDuration(Me,StartDateAttribute,EndDateAttribute);

//Convert to days
var days = minutes / 480;



//Add or substract hours, minutes, days, etc. to a date time value
var dDateAttribute = <mProcessEntityName.kmForeingKeyToEntity2.dDateAttributeName>;

//Amount of hours, minutes, days to add must be declared as an integer variable
int DaystoAdd =10;
var DateResult = dDateAttribute.AddDays(DaystoAdd);//Add 
var DateResult=dDateAttribute.AddDays(-DaystoAdd); //Substract


int HourstoAdd=5;
var DateResult = dDateAttribute.AddHours(HourstoAdd);











// Set timer event  to wait until a specific date
Me.EstimatedSolutionDate=<mProcessEntityName.kmForeingKeyToEntity2.dDateAttributeName>;


//Set timer event waiting time in minutes (timer attached events)
var Customdays = CHelper.resolveVocabulary(Me,"ExampleAmountofDays");

Me.TimerEventDuration = Customdays * 8 * 60;
Me.Duration = Customdays * 8 * 60;







// Set date difference in days in a timer

var traceName = "NC test dif times: "+Me.Case.CaseNumber;
var now=DateTime.Now;
CHelper.trace(traceName, "now"+now);
var dueDate=now.AddDays(32);
CHelper.trace(traceName, "dueDate"+dueDate);
var difTime=dueDate-now;
CHelper.trace(traceName, "difTime:"+difTime);

var difTimeDays=difTime.Days;
CHelper.trace(traceName, "difTimeDays:"+difTimeDays);


