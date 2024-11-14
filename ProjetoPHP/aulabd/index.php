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

    $consulta = "SELECT  * FROM contatos";
    $comando = $pdo->prepare($consulta);
    $comando->execute();
    $contatos = $comando->fetchAll();

?>




<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Inicializando Conexões com o Banco de Dados</title>
    <link rel="stylesheet" href="estilo.css">
</head>
<body class="corpo">
    <h1>Conexão com o BD - Cadastro Contados</h1>
    <hr>
    <h2 class="titulo">Formulário Cadastros</h2>
    <form action="receberDadosCadastro.php" method="post" >
        <input type="text" name="txtNome" placeholder="Informe o Nome" required class="nome"/>
        <br><br>
        <input type="submit" value="Cadastrar Agora" class="botao"/>
    </form>

    <hr>

    <h2>Lista de Contatos Atualizados</h2>
    <div class="div">
    <table border="1">
        <tr>
            <td>id</td>
            <td>nome</td>
            <td>Acões</td>
        </tr>
        <?php foreach($contatos as $contato){?>
        <tr>
            <td><?= $contato['id'] ?></td>
            <td><?= $contato['nome'] ?></td>
            <td>
                <a href="receberDadosExcluir.php/?id=<?= $contato['id'] ?>">Excluir</a>
                <a href="formDadosEditar.php/?id=<?= $contato['id'] ?>">Editar</a>
                <a href="#">Detalhar</a>
            </td>
        </tr>
        <?php } ?>
    </table>
    </div>
</body>
</html>