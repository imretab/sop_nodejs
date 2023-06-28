let mysql = require('mysql');
let connection = mysql.createConnection({
    host     : 'localhost',
    user     : 'root', 
    password : '', 
    database : 'bolt'
});
exports.aruFeltolt = function aruFeltolt(termekNev,ar,mennyiseg){
    return new Promise((success,fail) => {
      if(!termekNev || !ar||!mennyiseg){
        return success(false);
      }
      if(isNaN(ar) || isNaN(mennyiseg) || termekNev == null || ar == null || mennyiseg == null){
        return success(false);
      }
      connection.query("INSERT INTO raktar (termek,ar,mennyiseg) VALUES (?,?,?)",[termekNev,ar,mennyiseg],async function(error,results,fields){
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
exports.updateRaktar = function updateRaktar(id,termekNev,ar,mennyiseg){
    return new Promise((success,fail) => {
      if(!id || !termekNev || !ar || !mennyiseg){
        return success(false);
      }
      if(isNaN(ar) || isNaN(mennyiseg)){
        return success(false);
      }
      connection.query("UPDATE raktar SET termek = ?, ar = ?,mennyiseg = ? WHERE id = ?",[termekNev,ar,mennyiseg,id],async function(error,results,fields){
      if(error){ 
        return fail(error);
      }
      else{
        if(results.affectedRows != 0) return success(true);
        return success(false);
      }
    })});
  }
exports.torlesAru = function torlesAru(id){
    return new Promise((success,fail) => {
      if(!id){
        return success(false);
      }
      if(isNaN(id)){
        return success(false);
      }
      connection.query("DELETE FROM raktar WHERE id = ?",[id],async function(error,results,fields){
      if(error){ 
        return fail(error);
      }
      else{
        console.log(results.affectedRows);
        if(results.affectedRows != 0) return success(true);
        return success(false);
      }
    })});
  }