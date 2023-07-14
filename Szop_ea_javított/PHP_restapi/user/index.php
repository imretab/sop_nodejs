<?php

include("../common.php");

// HTTP METHODS from CRUD
$request = $_SERVER["REQUEST_METHOD"];
switch ($request) {
    
    case "GET": // select
        if (login($_GET["username"], $_GET["passwd"])) {
            $result = $conn -> query("SELECT * FROM user WHERE username = '{$_GET["username"]}'");
            $user = $result -> fetch_assoc();
            $response = array(
                'status' => 1,
                'msg' => "Sikeres belépés",
            );
        }
        else
            $response = array(
                'status'=>0,
                'msg'=>"Sikertelen belépés"
            );
        echo json_encode($response);
        break;
    case "POST": // insert
        if(register($_POST["TeljesNev"],$_POST["username"],$_POST["passwd"],$_POST["szamlaszam"],$_POST["bankNev"])){
            $response = array(
                'status'=>1,
                'msg'=>"Sikeres regisztráció"
            );
        }
        else{
            $response = array(
                'status'=>0,
                'msg'=>"Sikertelen regisztráció"
            );
        }
        echo json_encode($response);
        break;
    default:
        http_response_code(405);
        header("allowed: GET, POST");
        break;
}

?>