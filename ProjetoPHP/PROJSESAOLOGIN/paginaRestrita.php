<?php

session_start();
if(isset($_SESSION['email'])){


?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Só Pessoal Autorizado</title>
</head>

<body>
    <h2>Acesso Restrido</h2>
    <hr>
    <h3>Pagina Só Acessivel Com Login</h3>
    <ol>
        <li>Você Fez o Login Corretamente Com Usuario e Senha</li>
        <li>Seu Sistema Esta Com Falha De Segurança</li>
     </ol>
     <hr>
     <a href="./login/logout.php">Logout Do Sistema </a>

</body>
</html>
<?php
}
else
{
    header('location: ./login/index.php');

}
?>