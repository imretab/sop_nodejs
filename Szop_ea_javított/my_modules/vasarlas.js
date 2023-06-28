let mysql = require('mysql');
let connection = mysql.createConnection({
    host     : 'localhost',
    user     : 'root', 
    password : '', 
    database : 'bolt'
});
exports.deleteWhereZero = function deleteWhereZero(){
    return new Promise((success,fail) => {
      connection.query("DELETE from raktar Where mennyiseg <= 0",async function(error,results){
        if(error) return fail(error);
        else{
          if(results.length!=0) return success(true);
          return success(false);
        }
      });
    });
  }
exports.updateVasarlas = function updateVasarlas(id,mennyiseg){
    return new Promise((success,fail) => {
      if(!id || !mennyiseg){
        console.log("Error, one of the inputs missing");
        return success(false);
      }
      if(isNaN(id) || isNaN(mennyiseg)){
        console.log("Parameter error");
        return success(false);
      }
      connection.query("SELECT * FROM raktar where id = ?",[id],async function(error,results){
        if(error) return fail(error);
        else{
          if(results.length!= 0){
            connection.query("UPDATE raktar SET mennyiseg = (mennyiseg-?) Where id = ?",[mennyiseg,id],async function(error,results){
              if(error){
                console.log(vasarlasSikertelen);
                return fail(error);
              }
              else{
                if(results.length != 0) {
                  console.log(vasarlasSikeres);
                  return success(true);
                }
                return success(false);
              }
            });
          }
        }
      });
    });
  }