let mysql = require('mysql');
let connection = mysql.createConnection({
    host     : 'localhost',
    user     : 'root', 
    password : '', 
    database : 'shop'
});
exports.deleteWhereZero = function deleteWhereZero(){
    return new Promise((success,fail) => {
      connection.query("DELETE from inventory Where quantity <= 0",async function(error,results){
        if(error) return fail(error);
        else{
          if(results.length!=0) return success(true);
          return success(false);
        }
      });
    });
  }
exports.purchase = function Purchase(id,quantity){
    return new Promise((success,fail) => {
      if(!id || !quantity){
        return success(false);
      }
      if(isNaN(id) || isNaN(quantity)){
        return success(false);
      }
      connection.query("SELECT * FROM inventory where id = ?",[id],async function(error,results){
        if(error) return fail(error);
        else{
          if(results.length != 0){
            connection.query("UPDATE inventory SET quantity = (quantity-?) Where id = ?",[quantity,id],async function(error,results){
              if(error){
                return fail(error);
              }
              else{
                if(results.length != 0) {
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
exports.insertToHistroy = function insertToHistroy(userId,prodID, quantity){
  return new Promise((success,fail)=>{
    if(!userId || !prodID || !quantity){
      return success(false);
    }
    if(isNaN(userId) || isNaN(prodID) || isNaN(quantity)){
      return success(false);
    }
    connection.query("INSERT into purchasehistory(buyerID,productID,quantity) values(?,?,?)",[userId,prodID,quantity],async function (error,results){
      if(error) return fail(error);
      else{
        if(results.length != 0) return success(true);
        else return success(false);
      }
    });
  })

}