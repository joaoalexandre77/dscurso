<?php
if (isset($_POST['txtEmail']) && isset($_POST['txtSenha'])) {

    require_once('../conexao.php');
    //dados enviados do fomulario login
    $email = $_POST['txtEmail'];
    $senha = $_POST['txtSenha'];

    //dados do usuario do banco
    $sql = "SELECT * From usuarios WHERE email = :email";
    $comando = $conexao->prepare($sql);
    $comando->bindValue(":email", $email, PDO::PARAM_STR);

    if($comando->execute()){
        $usuario = $comando->fetch();

        if(isset($usuario['email'])){ 
            if(password_verify($senha, $usuario['senha']))
            {
            
            session_start();
            $_SESSION['email'] =$email;

            header('location: ../paginaRestrita.php');
            }else{
                echo"Usuario ou senha incorretos";
            }
        }else{
            header('location: ./index.php');
        }
    }
}else{
    header('location: ./index.php');
}    