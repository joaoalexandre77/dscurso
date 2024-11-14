<?php

$agenda = [
    "contato" =>["nome"=> "Claudinei", "email"=> "Claudinei@gmail.com", "telefone"=> 13996436232],
    "contato2"=>["nome"=>"Gabriel", "email" => "Gabriel@gmail.com", "telefone"=> 13992468732],
    "contato3"=>["nome"=>"Miguel", "email" => "Miguel@gmail.com", "telefone"=> 13445633212],
    "contato4"=>["nome" =>"eliseu", "email" => "Eliseu@gmail.com", "telefone"=> 132234323242]

];

echo "<pre>";
print_r($agenda);
echo "</pre>";


$lojaCarros = [
    ["placa"=>"ptp4343", "modelo" => "fusion", "ano"=>"2015"],
    ["placa"=>"alb3212", "modelo"=> "uno", "ano"=>"1999"],
    ["placa"=>"zce6666", "modelo"=>"civic", "ano"=>"2008"],
    ["placa"=>"lta5423", "modelo"=>"gt-r34", "ano"=>"2001"]

];

echo $lojaCarros[0]['placa']. "<br>";
echo "<hr>";

echo "usando o for <br>";

for ($i=0;$i < count($lojaCarros); $i++){
    echo $lojaCarros [$i]['placa']. "<br>";
};

echo "<hr>";

echo "usando o foreach";

foreach($lojaCarros as $carro){
    echo $carro ['modelo']. "<br>";
};


echo "<hr>";
echo "atividade 01 <br>";


$times = ["São Paulo", "Santos", "Corinthians", "Palmeiras"];

for ($inicio = 0; $inicio < count($times); $inicio++){
    echo $times [$inicio]. "<br>";
};
echo "<hr>";

foreach ($times as $time){
    echo $time . "<br>";
};


$times = [
    ["nome"=>"São Paulo", "tecnico"=> "Seila", "estado"=>"sp"],
    ["nome"=> "Corinthians", "tecnico"=> "nsei",
    "estado"=>"sp"],
    ["nome"=> "Palmeiras", "tecnico"=> "astoufo",
    "estado"=>"sp"]
];

echo "<hr>";

foreach ($times as $time){
    echo $time ["nome"]."/". $time ["tecnico"]."/". $time ["estado"] . "<br>";
};