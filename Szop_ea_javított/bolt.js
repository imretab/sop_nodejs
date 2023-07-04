var express = require('express');
var bodyParser = require('body-parser');
var app = express();
var mysql = require('mysql');
var loginCheck = require('./my_modules/login');
var registerCheck = require('./my_modules/register');
var inventory = require('./my_modules/inventory');
var purchase = require('./my_modules/purchase');
//var jsonCodes = require('./my_modules/jsonCodes');
var connection = mysql.createConnection({
    host     : 'localhost',
    user     : 'root', 
    password : '', 
    database : 'shop'
});
connection.connect(function(err){
  try{
    if(err) throw err;
  }
  catch{
    console.log(err);
  }
});
const swaggerUI = require('swagger-ui-express');
const swaggerDoc =  require('./openapi');
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: false }));
app.use('/api_docs',swaggerUI.serve,swaggerUI.setup(swaggerDoc));
//json error codes
const goodsInsertFail = {"status":0,"msg":"Inserting good(s) was/were unsuccessful"}
const goodsInsertSuccess = {"status":1,"msg":"Inserting good(s) was/were successful"}
const incomplete = {"status":2,"msg":"Incomplete parameters"}
const notAdmin = {"status":2,"msg":"You don't have the required privilage!"}
const loginFail = {'status':0,'msg':"The attempt to login was unsuccessful"}
const loginSuccess = {'status':1,'msg':"The attempt to login was successful"}
const registerSuccess = {'status':1,'msg':"Successfully registered"}
const registerFail = {'status':0,'msg':"Registered unsuccessfully"}
const notLoggedIn = {"status":3,"msg":"You aren't logged in!"}
const goodsUpdateFail = {"status":0,"msg":"Updating the selected product has failed"}
const goodsupdateSuccess = {"status":1,"msg":"Updating the selected product has succeeded"}
const goodsDeleteFail ={"status":0,"msg":"Deleting the selected product has failed"}
const goodsDeleteSuccess ={"status":1,"msg":"Deleting the selected product has succeeded"}
const purchaseFail = {"status":0,"msg":"Purchasing the selected item has failed"}
const purchaseSuccess = {"status":1,"msg":"Purchasing the selected item has succeeded"}
var server = app.listen(8080,"127.0.0.1",function (){
  var host = server.address().address
  var port = server.address().port
});
async function isLoggedAndAdmin(values){
  let islogged = await loginCheck.login(values.username,values.password);
  let isadmin = await isAdmin(values.username);
  return islogged && isadmin;
}
function isAdmin(uname){
  return new Promise((success,fail)=>connection.query("SELECT role FROM user WHERE username = ? and role = 'admin'",[uname],function(error, results){
    if(error) return fail(error);
    if(results.length != 0) {
        return success(true);
    }
    return success(false);
  }));
}
let userId = null;
app.get('/login/:username&:password',async function (req,res){
  var name = req.params.username;
  var passwd = req.params.password;
  let tryLog = await loginCheck.login(name,passwd);
  if(tryLog){
    userId = await loginCheck.getId(name,passwd);
    res.json(loginSuccess);
  }
  else{
    res.json(loginFail);
  }
});
app.post('/register',async function(req,res){
    let values = req.body;
    let isFilled = await registerCheck.areInputsfilled(values.teljesNev,values.username,values.password,values.email,values.role);
    if(isFilled){
        let isReg = await registerCheck.register(values.teljesNev,values.username,values.password,values.email,values.role);
        if(isReg){
          res.json(registerSuccess);
        }
    }
    else{
        res.json(registerFail);
    }
});
app.get('/inventory',function(req,res){
    connection.query("SELECT * FROM inventory",function(error,results,fields){
    if(error) throw error;
    res.json(results);
})});
app.post('/inventory',async function(req,res){
  let values = req.body;
  if(values == null){
    res.json(goodsInsertFail);
    return;
  }
  let isAdminAndLogged = await isLoggedAndAdmin(values);
  if(!isAdminAndLogged) {
    res.json(notAdmin);
    return;
  }
  let isInsertToInventory = await inventory.insertGoods(values.productName,values.price,values.quantity);
  console.log(isInsertToInventory);
  if(!isInsertToInventory){
    res.json(goodsInsertFail);
    return;
  }
  res.json(goodsInsertSuccess);
  }
);
app.put('/inventory',async function(req,res){
  let values = req.body;
  if(values.id == null||values.productName == null||values.price == null||values.quantity == null){
    res.json(incomplete);
    return;
  }
  let isAdminAndLogged = await isLoggedAndAdmin(values);
  if(!isAdminAndLogged) {
    res.json(notAdmin);
    return;
  }
  let isUpdate = await inventory.updateGoods(values.id,values.prodcutName,values.price,values.quantity);
  if(!isUpdate) {
    res.json(goodsUpdateFail);
    return;
  }
  res.json(goodsupdateSuccess);
});
app.delete('/inventory/:id',async function(req,res){
  let values = req.body;
  let isAdminAndLogged = await isLoggedAndAdmin(values);
  if(!isAdminAndLogged) {
    res.json(notAdmin);
    return;
  }
  let isDelete = await inventory.deleteGoods(req.params.id);
  if(!isDelete){
    res.json(goodsDeleteFail);
    return;
  }
  res.json(goodsDeleteSuccess);
});
app.get('/purchase',async function(req,res){
  connection.query("SELECT purchasehistory.id, u.fullName as 'Buyer', i.goods as 'ProductName', purchasehistory.quantity FROM purchasehistory INNER JOIN user u ON purchasehistory.buyerID = u.id INNER JOIN inventory i ON purchasehistory.productID = i.id WHERE buyerID = ?",[userId],function(error,results,fields){
    if(error) throw error;
    res.json(results);
  })
})
app.put('/purchase',async function(req,res){
  let values = req.body;
  if(values.quantity == null || values.id == null){
    res.json(incomplete);
    return;
  }
  let islogged = await loginCheck.login(values.username,values.password);
  if(!islogged){
    res.json(notLoggedIn);
    return;
  }
  let isPurchase = await purchase.purchase(values.id,values.quantity);
  if(!isPurchase){
    res.json(purchaseFail);
    return;
  }
  let isTorol = await purchase.deleteWhereZero();
  if(!isTorol){
    return;
  }
  let isInsertToInventory = await purchase.insertToHistroy(userId,values.id,values.quantity);
  if(!isInsertToInventory){
    res.json(purchaseFail);
    return;
  }
  res.json(purchaseSuccess);
});
app.get('/php',async function(req,res){
  let phpConn =mysql.createConnection({
    host: 'localhost',
    user: 'root', 
    password: '', 
    database: 'bank'
  });
  phpConn.query("SELECT * FROM utalas",function(error,results,fields){
    if(error) throw error;
    res.json(results);
})
});