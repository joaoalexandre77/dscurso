<?php

echo "<h1>Arquivo receber dados</h1>";
echo "<hr>";

echo $_POST['txtNome']; 

echo "<hr>";

echo "<PRE>";
echo print_r($_POST);
echo "</PRE>";