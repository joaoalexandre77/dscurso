<?php

$animais=['gato','cachorro','papagaio','coruja'];


echo $animais[0]. "<br>";
echo $animais[1]. "<br>";
echo $animais[2]. "<br>";
echo $animais[3]. "<br>";

$animais[]='gavião';
$animais[]='cavalo';
$animais[]='cobra';
$animias[]='potro';
$animais[]='javali';
$animais[]='porco';
$animais[]='macaco';
$animais[]='tubarão';
$animais[]='peixe';
$animais[]='tigre';
$animais[]='leão';
$animais[]='leoa';
$animais[]='lagarto';
$animais[]='mariposa';
$animais[]='jaguatirica';

echo "<hr>";

echo $animais[4]. "<br>";
echo $animais[5]. "<br>";
echo $animais[6]. "<br>";
echo "<hr>";

$animais[4]='periquito';
$animais[5]='mico leão dourado';
$animais[6]='patinho feio';

echo $animais[4]. "<br>";
echo $animais[5]. "<br>";
echo $animais[6]. "<br>";

echo "<hr>";

echo "Quantos elementos tem na array animais?". "<br>";
echo count($animais);

echo "<hr>";

//unset($animais[0]);
//unset($animais[1]);
//unset($animais[2]);
//unset($animais[3]);
//unset($animais[4]);
//unset($animais[5]);

//array_splice($animais,0,2);

//array_splice($animais,2,5);

//array_splice($animais,9,1);

echo "<pre>";
print_r($animais);
echo "</pre>";

//loop

/*for(inicio;fim;passo;){
    echo $animais[$inicio]. "<br>";
}*/

for($inicio = 1; $inicio < count($animais); $inicio+=2){
 echo "o animal ". $inicio. " é o : ".$animais[$inicio]. "<br>";
}