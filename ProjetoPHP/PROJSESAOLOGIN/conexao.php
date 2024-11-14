<?php
define('CONECTOR', 'mysql');
define('HOST', 'localhost');
define('PORT', '3306');
define('DBNAME', 'prjloginsenha');
define('CHARSET', 'utf8');
define('USER', 'root');
define('PASSWORD', '123456');

$opcoes = array(
    PDO::MYSQL_ATTR_INIT_COMMAND => 'SET NAMES UTF8',
    PDO::ATTR_PERSISTENT => TRUE
);

$conexao = new PDO (
    CONECTOR.
    ":host=" . HOST .
    ";port=". PORT .
    ";dbname=". DBNAME .
    ";charset=". CHARSET . ";",
    USER, PASSWORD, $opcoes);