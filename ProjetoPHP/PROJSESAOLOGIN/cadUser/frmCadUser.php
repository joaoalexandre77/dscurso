<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cadastro de usuário</title>
</head>
<body>
    <h1>Cadastro de usuários</h1>
    <hr>
    <form action="./recCadUser.php" method="post">
        <input type="text" name="txtNome" id="txtNome" required placeholder="Nome do usuário"><br><br>
        <input type="email" name="txtEmail" id="txtEmail" required placeholder="Email"><br><br>
        <input type="password" name="txtSenha" id="txtSenha" required placeholder="Senha"><br><br>
        <hr>
        <input type="submit" value="cadastrar">
    </form>

    <h2>LISTA DE USUARIOS CADASTRADOS</h2>
    <?php
    require_once('../conexao.php');
    $sql = "SELECT id, nome, senha FROM usuarios";
    $comando = $conexao->prepare($sql);
    $comando->execute();
    $usuarios = $comando->fetchAll();
    foreach($usuarios as $usuario){
    ?>
        <li><?= $usuario['id']?> -- <?= $usuario['nome']?> -- <?= $usuario['senha']?></li>
    <?php
    }
    ?>
</body>
</html>