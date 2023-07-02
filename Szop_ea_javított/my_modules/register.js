let sha512 = require('js-sha512');
let mysql = require('mysql');
let connection = mysql.createConnection({
    host     : 'localhost',
    user     : 'root', 
    password : '', 
    database : 'bolt'
});
exports.areInputsfilled = async function areAllFilled(fullName,uname,pwd,email,role){
    if(!fullName || !uname || !pwd || !email || !role){
      console.log("Error, one of the inputs missing");
      return false;
    }
    if(fullName.trim().length == 0 ||uname.trim().length == 0|| pwd.trim().length == 0|| email.trim().length == 0|| role.trim().length == 0){
      return false;
    }
    return true;
  }
exports.register = function register(fullName,uname,pwd,email,role){
      return new Promise((success,fail) => {
      connection.query("INSERT INTO user (TeljesNev,username,passwd,email,role) VALUES (?,?,?,?,?)",[fullName,uname,sha512(pwd),email,role],function(error,results,fields){
      if(error){ 
        return fail(error);
      }
      if(results.length != 0){
        return success(true);
      }
      else{
        return success(false);
      }
      
    });
  });
  }