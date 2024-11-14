<?php
if(isset($_GET['id'])){
    $id= $_GET['id'];

}else{
    header('location: /index.php');
}
?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Editando o Registro</title>

</head>
<body class="corpo">
<h2 class="titulo">EDITAR FORMULARIOS</h2>
<hr>
    <form action="/receberDadosEditar.php/?id=<?= $id ?>" method="post" >
        <input type="text" name="txtNome" placeholder="Informe o Nome"required />
        <br><br>
        <input type="submit" value="Confirmar alteração" />
    </form>
    <hr>
</body>
</html>