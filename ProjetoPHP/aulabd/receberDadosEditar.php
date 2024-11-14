<?php
require_once('conexao.php');

$id = $_GET['id'];
var_dump($id);
$nome = $_POST['txtNome'];

$consulta = "UPDATE contatos SET nome=:nome WHERE id=:id";

$comando = $pdo->prepare($consulta);
$comando->bindValue(":id", $id, PDO::PARAM_INT);
$comando->bindValue(":nome", $nome, PDO::PARAM_STR);

if($comando->execute()){
    header('location:/index.php');
}
