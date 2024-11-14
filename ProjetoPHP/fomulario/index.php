<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="receberDados.php" method="post">
        <label for="txtNome">Digite seu nome:</label>
        <input type="text" name="txtNome" id="txtNome" required>
        <hr>
        <label for="txtSenha">Digite sua senha:</label>
        <input type="password" name="txtSenha" id="txtSenha" required>
        <hr>
        <input type="submit" value="Enviar">
        
    </form>
</body>
</html>