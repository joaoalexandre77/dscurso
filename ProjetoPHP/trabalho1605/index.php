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

    $consulta = "SELECT  * FROM tblogin";
    $comando = $pdo->prepare($consulta);
    $comando->execute();
    $login = $comando->fetchAll();

?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link href="Estilizando.css" rel="stylesheet">
</head>
<body>
    <h1 class="titulo">CADASTRO USUARIOS</h1>
    <hr>
    <form action="receberDados.php" method="post">
    <input type="text" name="txtEmail" id="txtEmail" placeholder="informe o e-mail">
    <br>
    <input type="password" name="txtSenha" id="txtSenha" placeholder="informe a senha">
    <br>
    <input type="submit" value="cadastrar">
    </form>
    <hr>
    <table border="1">
        <tr>
            <td>email</td>
            <td>senha</td>

        </tr>
        <?php foreach($login as $valores){?>
        <tr>
            <td><?= $valores['email'] ?></td>
            <td><?= $valores['senha'] ?></td>

        </tr>
        <?php } ?>
</body>
</html>