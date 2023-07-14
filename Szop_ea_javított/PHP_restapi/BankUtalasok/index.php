<?php
//include("../db.php");
include_once("../common.php");

// HTTP METHODS from CRUD

$request = $_SERVER["REQUEST_METHOD"];

switch ($request) {
    case "GET": // select
        if(getUtalasAdatok($_GET["username"],$_GET["passwd"]) != null){
            $utalas = getUtalasAdatok($_GET["username"], $_GET["passwd"]);
            $response = array(
                'status' => 1,
                'msg' => "Sikeres lekérdezés"
            );
            echo json_encode($utalas, JSON_NUMERIC_CHECK);
        }
        else{
            $response = array(
                'status' => 0,
                'msg' => "Sikertelen lekérdezés"
            );
            echo json_encode($response);
        }
        break;
    case "POST": // insert
        $params = json_decode(file_get_contents("php://input"), true);
        if (!login($params["username"], $params["passwd"])) {
            echo "ERROR: Login nem sikerült";
            http_response_code(401);
        } else {
            if(insertUtalas($params["adatok"])){
                $response = array(
                    'status' => 1,
                    'msg' => "Sikeres Utalás"
                );
            }
            else{
                $response = array(
                    'status' => 0,
                    'msg' => "Sikertelen Utalás"
                );
            }
            echo json_encode($response);
        }
        break;
    case "PUT":
        $params = json_decode(file_get_contents("php://input"), true);
        if (!login($params["username"], $params["passwd"])) {
            echo "ERROR: Login nem sikerült";
            http_response_code(401);
        }
        else{
            updateUtalas($params["adatok"]);
        }
        break;
    case "DELETE": // delete
        $params = json_decode(file_get_contents("php://input"), true);
        if (!login($params["username"], $params["passwd"])) {
            echo "ERROR: Login nem sikerült";
            http_response_code(401);
        } else {
            if(deleteUtalas($_GET["id"])){
                $response = array(
                    'status' => 1,
                    'msg' => "Sikeres törlés"
                );
            }
            else{
                $response = array(
                    'status' => 0,
                    'msg' => "Sikertelen törlés"
                );
            }
            echo json_encode($response);
        }
        break;
    default:
        http_response_code(405);
        header("allowed: GET, POST, PUT, DELETE");
        break;
}

function getUtalasAdatok($usern,$passwd) {
    global $conn;
    $result = $conn->query("SELECT * FROM user Where username = '$usern'");
    $name = $result->fetch_assoc();
    $teljes = $name["TeljesNev"];
    $query = $conn->query("SELECT * FROM utalas where utalas.from = '$teljes'");
    if(is_null($name)){
        echo "ERROR: Nem tudjuk adatait lekérdezni";
        return null;
    }
    if($name["passwd"] == hash("sha512",$passwd)){
        return $query ->fetch_all(MYSQLI_ASSOC);
    } else
        return null;
}

function insertUtalas($adatok) {
    global $conn;

    $stmt = $conn -> prepare("INSERT INTO utalas(utalas.from,utalas.to,szamlaszam,osszeg,kozlemeny) VALUES(?,?,?,?,?)");
    $stmt -> bind_param("sssis", $adatok["kitol"], $adatok["kinek"], $adatok["szamlaszam"],$adatok["osszeg"],$adatok["kozlemeny"]);
    if($stmt->execute()){
        $kinek = $adatok["kinek"];
        $szamla = $adatok["szamlaszam"];
        $query = "SELECT TeljesNev, szamlaszam FROM user WHERE TeljesNev = '$kinek' and szamlaszam = '$szamla'";
        $letezik = mysqli_query($conn,$query);
        if ($letezik) {
            if(mysqli_num_rows($letezik)>0){
                return true;
            }
            else{
                return false;
            }
        }

        
    }
}
function updateUtalas($bank){
    global $conn;

    $stmt = $conn -> prepare("UPDATE utalas SET kitol = ?, kinek = ?, szamlaszam = ?, osszeg = ?,kozlemeny = ? Where id = ?");
    $stmt -> bind_param("sssisi", $bank["kitol"], $bank["kinek"],$bank["szamlaszam"], $bank["osszeg"],$bank["kozlemeny"],$bank["id"]);
    $stmt -> execute();
}
function deleteUtalas($id){
    global $conn;

    $query = "DELETE FROM utalas WHERE id = '$id'";
    if(mysqli_query($conn,$query)){
        return true;
    } else
        return false;
}
?>