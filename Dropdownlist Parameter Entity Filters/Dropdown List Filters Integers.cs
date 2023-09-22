
//Sample syntax to create filter expressions in parametric dropdown lists in forms (form combos)
//This functions return a variable containing the values to display in the dropdown list
//The filtered values of the parameter entity business key are INTEGERS

var filter; //Output variable declaration

filter="(iIntegerAttributeName2=0)";

//If the user selects one of the following parameter entity records in dropdown list  1 , then the selectable values of dropdown list 2 are assigned to 'filter'
if(<kpForeignKeyParamEntity1.iIntegerAttributeName1>==2|| <kpForeignKeyParamEntity1.iIntegerAttributeName1>==3 || <kpForeignKeyParamEntity1.iIntegerAttributeName1>==22 || (<kpForeignKeyParamEntity1.iIntegerAttributeName1>==5 && <Activity.ActivityCode>=="StringValue"))
{
filter="(iIntegerAttributeName2=0)";
}

if(<kpForeignKeyParamEntity1.iIntegerAttributeName1>==6 || <kpForeignKeyParamEntity1.iIntegerAttributeName1>==7 || <kpForeignKeyParamEntity1.iIntegerAttributeName1>==8 ||(<kpForeignKeyParamEntity1.iIntegerAttributeName1>==5 && <Activity.ActivityCode>=="CB")|| <kpForeignKeyParamEntity1.iIntegerAttributeName1>==13|| <kpForeignKeyParamEntity1.iIntegerAttributeName1>==18|| <kpForeignKeyParamEntity1.iIntegerAttributeName1>== 19)
{
filter="(iIntegerAttributeName2=10)";
}
if(<kpForeignKeyParamEntity1.iIntegerAttributeName1>== 17)
{
filter="(iIntegerAttributeName2=120)";
}
if(<kpForeignKeyParamEntity1.iIntegerAttributeName1>==16)
{
filter="(iIntegerAttributeName2=15)";
}
if(<kpForeignKeyParamEntity1.iIntegerAttributeName1>==9 || <kpForeignKeyParamEntity1.iIntegerAttributeName1>==10 || <kpForeignKeyParamEntity1.iIntegerAttributeName1>==12 || <kpForeignKeyParamEntity1.iIntegerAttributeName1>==15)
{
filter="(iIntegerAttributeName2=20)";
}
if(<kpForeignKeyParamEntity1.iIntegerAttributeName1>==1 || <kpForeignKeyParamEntity1.iIntegerAttributeName1>==20 || <kpForeignKeyParamEntity1.iIntegerAttributeName1>==21)
{
filter="(iIntegerAttributeName2=30)";
}
if(<kpForeignKeyParamEntity1.iIntegerAttributeName1>==11 || <kpForeignKeyParamEntity1.iIntegerAttributeName1>==14)
{
filter="(iIntegerAttributeName2=60)";
}
if(<kpForeignKeyParamEntity1.iIntegerAttributeName1>==4)
{
filter="(iIntegerAttributeName2=11)";
}
if(<kpForeignKeyParamEntity1.iIntegerAttributeName1>==4)
{
filter="(iIntegerAttributeName2=11)";
}
if(<kpForeignKeyParamEntity1.iIntegerAttributeName1>==24){

filter="(iIntegerAttributeName2=10)";

}
if(<kpForeignKeyParamEntity1.iIntegerAttributeName1>==23){

filter="(iIntegerAttributeName2=240)";

}



filter;  //Output string containing the values to display in the dropdown list