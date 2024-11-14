<?php
define('CONECTOR', 'mysql');
define('HOST', 'localhost');
define('PORT', '3306');
define('DBNAME', 'prjconexao');
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

    $nome =$_POST['txtNome'];

    $consulta = "INSERT INTO contatos (nome) VALUES (:nome)";
    $comando = $pdo->prepare($consulta);
    $comando->bindValue(":nome", $nome, PDO::PARAM_STR);
    if($comando->execute()){
        header('location: /index.php');
    }