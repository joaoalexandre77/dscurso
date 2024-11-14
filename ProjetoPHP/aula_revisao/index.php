<?php 

$lanches=[
    "x-tudo",
    "y-burger jacu",
    "MC-JACs"
];

$porcoes=[
    "Batata-frita",
    "Bananinhas fritas",
    "Macaxeira"
];


//echo $porcoes [2];

//for($i=0;$i<count($lanches); $i ++){
    //echo $lanches[$i]. "  ";
//};

//foreach($porcoes as $porcao){
 //   echo $porcao. "  ";
//};

$cardapio=[
    ["X-TUDO","Y-BURGER JACU", "MC-JACs"],
    ["Batata-frita","Bananinhas fritas","Macaxeira"]

];

//echo "<pre>";
//print_r($cardapio);
//echo "</pre>";

foreach($cardapio as $itens){
     echo $itens[0]. " / ". $itens[1]." / ". $itens[2]. "<br>";
};