

//The standard way to obtain a vocabulary value thats administered from the work portal
//Process level invoke
var vocabularyValue=CHelper.resolveVocabulary( Me , "vocabularyName");


//Uncontextualized way to obtain a vocabulary values thats administered from the work portal 
//Global level invoke
var contractNotifDays=CHelper.resolveVocabulary( null , "vocabularyName");


