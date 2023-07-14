<?php
include("../db.php");

function login($username, $passwd) {
    global $conn;
    $result = $conn -> query("SELECT * FROM user WHERE username = '{$username}'");
    $user = $result -> fetch_assoc();
    if (is_null($user)) {
        echo "ERROR: Nincs {$username} nevű user az adatbázisban";
        return false;
    }

    if ($user["passwd"] == hash("sha512", $passwd)) {
        return true;
        
    }
    else
        return false;
}
function register($teljesnev,$username,$passwd,$szamlaszam,$bankNev){
    global $conn;
    $hashed = hash("sha512", $passwd);
    $query = "INSERT INTO user(TeljesNev,username,passwd,szamlaszam,bankNev) VALUES('$teljesnev','$username','$hashed','$szamlaszam','$bankNev')";
    $querySelect = "SELECT * FROM user WHERE username = '$username'";
    $letezikE = mysqli_query($conn, $querySelect);
    if ($letezikE) {
        if (mysqli_num_rows($letezikE)>0) {
            return false;
        } else {
            mysqli_query($conn, $query);
            return true;
        }
    }
}
?>