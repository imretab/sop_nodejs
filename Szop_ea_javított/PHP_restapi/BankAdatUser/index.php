<?php
//include("../db.php");
include_once("../common.php");

// HTTP METHODS from CRUD

$request = $_SERVER["REQUEST_METHOD"];

switch ($request) {
    case "GET": // select
        $bank = getBankAdatok();
        echo json_encode($bank, JSON_NUMERIC_CHECK);
        
        break;
    /*case "PUT":
        break;*/
}

function getBankAdatok() {
    global $conn;
    $result = $conn -> query("SELECT TeljesNev, szamlaszam FROM user");
    return $result->fetch_all(MYSQLI_ASSOC);
}
?>