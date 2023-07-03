let mysql = require('mysql');
let connection = mysql.createConnection({
    host     : 'localhost',
    user     : 'root', 
    password : '', 
    database : 'shop'
});
exports.insertGoods = function insertGoods(prodcutName,price,quantity){
    return new Promise((success,fail) => {
      if(!prodcutName || !price || !quantity){
        return success(false);
      }
      if(isNaN(price) || isNaN(quantity)){
        return success(false);
      }
      connection.query("INSERT INTO inventory (goods,price,quantity) VALUES (?,?,?)",[prodcutName,price,quantity],async function(error,results,fields){
      if(error){ 
        return fail(error);
      }
      else{
        if(results.length != 0){
          return success(true);
        }
        return success(false);
      }
    })});
  }
exports.updateGoods = function updateGoods(id,prodcutName,price,quantity){
    return new Promise((success,fail) => {
      if(!id || !prodcutName || !price || !quantity){
        return success(false);
      }
      if(isNaN(price) || isNaN(quantity)){
        return success(false);
      }
      connection.query("UPDATE inventory SET goods = ?, price = ?,quantity = ? WHERE id = ?",[prodcutName,price,quantity,id],async function(error,results,fields){
      if(error){ 
        return fail(error);
      }
      else{
        if(results.affectedRows != 0) return success(true);
        return success(false);
      }
    })});
  }
exports.deleteGoods = function deleteGoods(id){
    return new Promise((success,fail) => {
      if(!id){
        return success(false);
      }
      if(isNaN(id)){
        return success(false);
      }
      connection.query("DELETE FROM inventory WHERE id = ?",[id],async function(error,results,fields){
      if(error){ 
        return fail(error);
      }
      else{
        if(results.affectedRows != 0) return success(true);
        return success(false);
      }
    })});
  }