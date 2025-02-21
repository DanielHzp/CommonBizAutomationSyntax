


var bizagiUtil = require('bz-util');
var REQUIRED = bizagiUtil.REQUIRED;
var ERROR = bizagiUtil.error;
var RESPONSE = bizagiUtil.getResponse;
var axios = require('axios');
var qs = require('qs');
 
 

function invoke(globals, actionName, data, authenticationType, LOG, callback) {
    var URL = globals.systemproperties.AuthURL;
    var ServiceURL = globals.systemproperties.ServiceURL;
    var TenantID = globals.systemproperties.TenantID;
    URL = URL+TenantID+'/oauth2/v2.0/token';
    ServiceURL = ServiceURL+'.default';
    var ClientID = globals.systemproperties.ClientID;
    var ClientSecret= globals.systemproperties.ClientSecret;
    LOG.info('AuthURL: ' + URL);
    LOG.info('Scope: ' + ServiceURL);
 
// set content-type header and data as json in args parameter

var info = qs.stringify({
    'grant_type': 'client_credentials',
    'client_id': ClientID,
    'client_secret': ClientSecret,
    'scope': ServiceURL
    });

var config = {
  method: 'post',
  url: URL,
  headers: { 
    'Content-Type': 'application/x-www-form-urlencoded'
  },
  data : info
};

LOG.info('Var Config: '+JSON.stringify(config));

    axios(config).then(function (response) {
      LOG.info('Response: ' +JSON.stringify(response.data));
      LOG.info('Status: '+response.status);
      LOG.info('StatusText: '+response.statusText);
      var success = RESPONSE(response.data, null, 200);
      LOG.info(JSON.stringify("Var success "+JSON.stringify(success)));
      callback(success);  
    }).catch(function (errors) {
        if (errors.response) {
        LOG.info('Error: '+errors);
        var errorMessage = errors.response.data.error.message;
        LOG.info('Error Response: '+JSON.stringify(errors.response.data));
        var errorType = errors;
        LOG.info('Error Status: '+errors.response.status);
        var errorStatusCode = errors.response.status;
        LOG.info('Error StatusText: '+errors.response.statusText);
        LOG.info('Error Headers: '+JSON.stringify(errors.response.headers));
        var errorData = {
          error : {
            error: errorType,
            message: errorMessage,
            status: errorStatusCode
          }
        };
        var error = RESPONSE(null, errorData, errors.response.status, errors.response.data.error.message);
        LOG.info('Error Message',+JSON.stringify(error.message));
        callback(error);
        }
    });

}

exports.invoke = invoke;