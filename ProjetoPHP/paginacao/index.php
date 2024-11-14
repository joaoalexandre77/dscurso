<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>

    <h1> Formulário paginação</h1>
    <hr>

    <form method="get" action="paginacao.php">
        <input type="number" name="txtTotalRegistros" id="txtTotalRegistros" value="100"/>
        <input type="number" name="txtRegistroPagina" id="txtRegistroPagina" value="10"/>
        <hr>
        <input type="submit" value="Gerar Paginação"/>

    </form>
</body>
</html>