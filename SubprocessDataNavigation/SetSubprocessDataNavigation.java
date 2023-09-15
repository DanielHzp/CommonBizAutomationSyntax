

//Way to initialize a foreing key relationship between 2 master entities (  Entity 2 --> mMasterEntity1Name)
//kmForeingKeyProcessEntity is the relationship key between  Entity 2 and mMasterEntity1Name
var  masterEntityId = <mMasterEntity1Name>;

<mMasterEntity1Name.kmForeingKeyEntity2.kmForeingKeyEntity1> =  masterEntityId;






//Ways to initialize the process entity of a SUBPROCESS , this expressions are created to access the parent entity process information inside subprocesses:



//NON-MULTIPLE SUBPROCESS - Inside parent process business rule
//Set foreing key from subprocess to parent process:
<mParentProcessEntityName.kmForeingKeytoSubprocessEntity.kmParentProcessEntity> = <mParentProcessEntityName>;

//Set subprocess entity primary key:
<mSubprocessEntityName> = <mParentProcessEntity.kmForeingKeytoSubprocessEntity>;







//MULTIPLE NON-GROUPED SUBPROCESSES - Inside parent process business rule
var caseNumber = Me.Case.CaseNumber;
var filterExample = "CaseNumber ='"+caseNumber+"'";

//Alternate way to obtain the process entity primary key of the case:
var idProcessEntity = CHelper.getEntityAttrib("mParentProcessEntityName","idmParentProcessEntityName",filterExample);

//Set foreign key from subprocess to parent process:
<mSubprocessEntityName.kmForeingKeytoSubprocessEntity.kmForeingKeytoParentProcessEntity> = idProcessEntity;

cm






//MULTIPLE GROUPED SUBPROCESS - Inside subprocess business rule
// Set foreing key from subprocess to parent process:
var idParentProcessEntity = <mSubprocessEntityName.xMultipleInstancesCollectionName[ 1 ].mParentProcessEntityName>;

<mSubprocessEntityName.kmForeingKeytoParentProcessEntity> = idParentProcessEntity;






//MULTIPLE GROUPED SUBPROCESS - Inside subprocess business rule
// Set foreing key from subprocess to parent process entity navigating multiple entities:
var idParentProcessEntity = <mSubprocessEntityName.xMultipleInstancesCollection[1].mParentEntityName.kmForeingKeytoProcessEntity>;

<mSubprocessEntityName.kmForeingKeytoProcessEntity> = idParentProcessEntity;



//MULTIPLE GROUPED SUBPROCESS - Inside subprocess business rule
//Set foreing key from subprocess entity to parameter entity 
var foreignKeyParamEntity2 = <mSubprocessEntityName.xMultipleInstancesCollection[1].kpForeignKeyParamEntity1.kpForeignKeyParamEntity2>;

<mSubprocessEntityName.kpForeignKeyParamEntity2> = foreignKeyParamEntity2;