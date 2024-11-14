<?php
if(isset($_POST['txtNome']) && isset($_POST['txtEmail']) && isset($_POST['txtSenha'])){
    $nome = $_POST['txtNome'];
    $email = $_POST['txtEmail'];
    $senha = password_hash($_POST['txtSenha'], PASSWORD_DEFAULT);

    require_once('../conexao.php');
    $sql = "INSERT INTO usuarios (nome, email, senha) VALUES (:nome, :email, :senha)";

    $comando = $conexao->prepare($sql);
    $comando->bindValue(':nome', $nome);
    $comando->bindValue(':email', $email);
    $comando->bindValue(':senha', $senha);

    if($comando->execute()){
        header('location: ./frmCadUser.php');
    }
    
}else{
    header('location: ../index.php');
}
