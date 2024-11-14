<?php
define('CONECTOR', 'mysql');
define('HOST', 'localhost');
define('PORT', '3306');
define('DBNAME', 'bdsistema');
define('CHARSET', 'utf8');
define('USER', 'root');
define('PASSWORD', '123456');

$opcoes = array(
    PDO::MYSQL_ATTR_INIT_COMMAND => 'SET NAMES UTF8',
    PDO::ATTR_PERSISTENT => TRUE
);

$pdo = new PDO (
    CONECTOR.
    ":host=" . HOST .
    ";port=". PORT .
    ";dbname=". DBNAME .
    ";charset=". CHARSET . ";",
    USER, PASSWORD, $opcoes);

    $email =$_POST['txtEmail'];
    $senha =$_POST['txtSenha'];

    $consulta = "INSERT INTO tblogin (email, senha) VALUES (:email , :senha)";
    $comando = $pdo->prepare($consulta);
    $comando->bindValue(":email", $email, PDO::PARAM_STR);
    $comando->bindValue(":senha", $senha, PDO::PARAM_STR);
    if($comando->execute()){
        header('location: /index.php');
    }