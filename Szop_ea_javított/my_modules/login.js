let sha512 = require('js-sha512');
let mysql = require('mysql');
let connection = mysql.createConnection({
    host     : 'localhost',
    user     : 'root', 
    password : '', 
    database : 'bolt'
});

exports.login =  function login(uname,passwd){
    return new Promise((success,fail) => {
      if(uname == null || passwd == null){
        return success(false);
      }
    connection.query("SELECT * FROM user WHERE username = ? and passwd = ?",[uname,sha512(passwd)],function(error,results,fields){
      try{
        if(error){ 
          throw error;
          return fail(error);
        }
        if(results.length != 0){
          return success(true);
        }
        else{
          return success(false);
        }
  }
  catch{
    console.log(error);
  }
  });
});
};