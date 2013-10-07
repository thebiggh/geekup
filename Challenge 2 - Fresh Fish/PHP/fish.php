<?php
$cod_notts=500;
$cod_glas=450;
$cod_leeds=600;
$octo_notts=0;
$octo_glas=120;
$octo_leeds=100;
$crab_notts=450;
$crab_glas=0;
$crab_leeds=500;
$notts=800;
$glasgow=1100;
$leeds=600;
$cod_weight=50;
$octo_weight=100;
$crab_weight=50;
$price_per_km=2;
$petrol_notts=($notts*$price_per_km);
$petrol_glas=($glasgow*$price_per_km);
$petrol_leeds=($leeds*$price_per_km);






$message=<<<EOT

The total profit if sold in Nottingham is {$notts_profit}
The total profit if sold in Glasgow is {$glas_profit}
The total profit if sold in Leeds is {$leeds_profit}
Therefore, based on the stated quantities, he should sell the fish in {$city}
EOT;

echo $petrol_notts;
echo $petrol_glas;
echo $petrol_leeds;
echo $message;






?>
