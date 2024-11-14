<?php

if (isset($_GET['txtTotalRegistros'])){
    $totalRegistros = $_GET['txtTotalRegistros'];
    $registroPagina = $_GET['txtRegistroPagina'];

    $totalPaginas = 1;

    if($totalRegistros % $registroPagina == 0){
        $totalPaginas = $totalRegistros/$registroPagina;

    }else{
        $totalPaginas = ($totalRegistros/$registroPagina) + 1;
    }

    $paginaSelecionada = 1;

    if (isset($_GET['paginaSelecionada'])){
        $paginaSelecionada = $_GET['paginaSelecionada'];
    }

    $ultimoRegistroPagina = $paginaSelecionada * $registroPagina;
    $primeiroRegistroPagina = $ultimoRegistroPagina - ($registroPagina - 1);
    if($ultimoRegistroPagina > $totalRegistros){
        $ultimoRegistroPagina = $totalRegistros;
    }


}else{
    header("location: index.php");
}

?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Paginação criada </h1>
    <hr>
    <div>
        <h2>Exibindo os Registros da Página: <?= $paginaSelecionada ?></h2>
        <ul>
            <li>
                primeiro registro da pagina : <?= $primeiroRegistroPagina ?>
            </li>
            <li>
                Ultimo registro da pagina : <?= $ultimoRegistroPagina ?>
            </li>
        </ul>
    </div>

   <hr>

   <div>
    <h3>LISTA DOS REGISTROS</h3>
    <?php 
        for($i = $primeiroRegistroPagina; $i <= $ultimoRegistroPagina; $i++){
    ?>
    <p> REGISTRO NUMERO : <?= $i ?></p>
    <?php
        }
    ?>
</div>

    <?php for ($i = 1; $i <= $totalPaginas; $i++){ ?>
        <a href="?paginaSelecionada=<?= $i ?>
        &txtTotalRegistros=<?= $totalRegistros ?>
        &txtRegistroPagina=<?= $registroPagina ?>">
        <?= $i ?> - </a>
    <?php } ?>

    <hr>

    <a href="index.php">VOLTAR</a>
</body>
</html>