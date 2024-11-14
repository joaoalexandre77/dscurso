<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulario Login</title>
</head>
<body>
    <h2>Login Do Sistema</h2>
    <form action="./recLogin.php" method="POST">
        <input type="text" name="txtEmail" id="txtEmail" placeholder="Digite o Email" required><br><br>
        <input type="password" name="txtSenha" id="txtSenha" placeholder="Digite A Senha" required><br><br>
        <hr>
        <input type="submit" value="enter">
    </form>
</body>
</html>