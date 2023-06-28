var express = require('express');
var bodyParser = require('body-parser');
var app = express();
var mysql = require('mysql');
var loginCheck = require('./my_modules/login');
var registerCheck = require('./my_modules/register');
var raktar = require('./my_modules/raktar');
var vasarlas = require('./my_modules/vasarlas');
//var jsonCodes = require('./my_modules/jsonCodes');
var connection = mysql.createConnection({
    host     : 'localhost',
    user     : 'root', 
    password : '', 
    database : 'bolt'
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
const aruSikertelen = {"status":0,"msg":"Sikertelen árufeltöltés"}
const aruSikeres = {"status":1,"msg":"Sikeres árufeltöltés"}
const hianyos = {"status":2,"msg":"Hiányzó paraméterek"}
const nemAdmin = {"status":2,"msg":"Nem vagy admin!"}
const loginSikertelen = {'status':0,'msg':"Sikertelen bejelentkezés"}
const loginSiker = {'status':1,'msg':"Sikeres bejelentkezés"}
const registerSiker = {'status':1,'msg':"Sikeres regisztráció"}
const registerSikertelen = {'status':0,'msg':"Sikertelen regisztráció"}
const nemLogin = {"status":3,"msg":"Nem vagy bejelentkezve!"}
const updateSikertelen = {"status":0,"msg":"Sikertelen update"}
const updateSiker = {"status":1,"msg":"Sikeres update"}
const torlesSikertelen ={"status":0,"msg":"Sikertelen törlés"}
const torlesSikeres ={"status":1,"msg":"Sikeres törlés"}
const vasarlasSikertelen = {"status":0,"msg":"Sikertelen vásárlás"}
const vasarlasSikeres = {"status":1,"msg":"Sikeres vásárlás"}
var server = app.listen(8080,"127.0.0.1",function (){
  var host = server.address().address
  var port = server.address().port
});
function isAdmin(uname){
  return new Promise((success,fail)=>connection.query("SELECT role FROM user WHERE username = ? and role = 'admin'",[uname],function(error, results){
    if(error) return fail(error);
    if(results.length != 0) {
        return success(true);
    }
    return success(false);
  }));
}
app.get('/login/:username&:password',async function (req,res){
  var name = req.params.username;
  var passwd = req.params.password;
  let tryLog = await loginCheck.login(name,passwd);
  if(tryLog){
    res.json(loginSiker);
  }
  else{
    res.json(loginSikertelen);
  }
  });
app.post('/register',async function(req,res){
    let values =  req.body;
    let isFilled = await registerCheck.areInputsfilled(values.teljesNev,values.username,values.password,values.email,values.role);
    if(isFilled){
        let isReg = await registerCheck.register(values.teljesNev,values.username,values.password,values.email,values.role);
        if(isReg){
          res.json(registerSiker);
        }
    }
    else{
        res.json(registerSikertelen);
    }
});
app.get('/raktar',function(req,res){
    connection.query("SELECT * FROM raktar",function(error,results,fields){
    if(error) throw error;
    res.json(results);
})});
app.post('/raktar',async function(req,res){
  let values = req.body;
  if(values == null){
    res.json(aruSikertelen);
    return;
  }
  let islogged = await loginCheck.login(values.username,values.password);
  if(!islogged){
    res.json(nemLogin);
    return;
  }
  let isadmin = await isAdmin(values.username);
  if(!isadmin){
    res.json(nemAdmin);
    return;
  } 
  let isFeltolt = await raktar.aruFeltolt(values.aruNev,values.ar,values.mennyiseg);
  console.log(isFeltolt);
  if(!isFeltolt){
    res.json(hianyos);
    return;
  }
  res.json(aruSikeres);   
  }
);
app.put('/raktar',async function(req,res){
  let values = req.body;
  if(values.id == null||values.aruNev == null||values.ar == null||values.mennyiseg == null){
    res.json(hianyos);
    return;
  }
  let islogged = await loginCheck.login(values.username,values.password);
  if(!islogged){
    res.json(nemLogin);
    return;
  }
  let isadmin = await isAdmin(values.username);
  if(!isadmin){
    res.json(nemAdmin);
    return;
  } 
  let isUpdate = await raktar.updateRaktar(values.id,values.aruNev,values.ar,values.mennyiseg);
  if(!isUpdate) {
    res.json(updateSikertelen);
    return;
  }
  res.json(updateSiker);
});
app.delete('/raktar/:id',async function(req,res){
  let values = req.body;
  let islogged = await loginCheck.login(values.username,values.password);
  if(!islogged){
    res.json(nemLogin);
    return;
  }
  let isadmin = await isAdmin(values.username);
  if(!isadmin){
    res.json(nemAdmin);
    return;
  }
  let isTorles = await raktar.torlesAru(req.params.id);
  if(!isTorles){
    res.json(torlesSikertelen);
    return;
  }
  res.json(torlesSikeres);
});
app.put('/vasarlas',async function(req,res){
  let values = req.body;
  if(values.mennyiseg == null || values.id == null){
    res.json(hianyos);
    return;
  }
  let islogged = await loginCheck.login(values.username,values.password);
  if(!islogged){
    res.json(nemLogin);
    return;
  }
  let isVasar = await vasarlas.updateVasarlas(values.id,values.mennyiseg);
  if(!isVasar){
    res.json(vasarlasSikertelen);
    return;
  }
  let isTorol = await vasarlas.deleteWhereZero();
  if(!isTorol){
    return;
  }
  res.json(vasarlasSikeres);
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