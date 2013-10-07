<HTML>
<HEAD>
<TITLE>Fresh Fish</TITLE>
</HEAD>
<BODY>

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
$sale_notts=(($cod_notts*$cod_weight)+($octo_notts*$octo_weight)+($crab_notts*$crab_weight));
$sale_leeds=(($cod_leeds*$cod_weight)+($octo_leeds*$octo_weight)+($crab_leeds*$crab_weight));
$sale_glasgow=(($cod_glas*$cod_weight)+($octo_glas*$octo_weight)+($crab_glas*$crab_weight));
$degradation_notts=($sale_notts*0.08); 
$degradation_leeds=($sale_leeds*0.06);
$degradation_glas=($sale_glasgow*0.11);
$notts_profit=(($sale_notts-$degradation_notts)-$petrol_notts);
$leeds_profit=(($sale_leeds-$degradation_leeds)-$petrol_leeds);
$glas_profit=(($sale_glasgow-$degradation_glas)-$petrol_glas);
$highest_profit=max($notts_profit, $leeds_profit, $glas_profit);
if ($highest_profit==$notts_profit){
$city="Nottingham";
}elseif($highest_profit==$leeds_profit){
$city="Leeds";
}elseif($highest_profit==$glas_profit){
$city="Glasgow";
}else{
$city="There appears to have been an error";
}


$message=<<<EOT

The total profit if sold in Nottingham is {$notts_profit} <br />
The total profit if sold in Glasgow is {$glas_profit}<br />
The total profit if sold in Leeds is {$leeds_profit}<br />
Therefore, based on the stated quantities, he should sell the fish in {$city}
EOT;


echo $message;






?>
</BODY>
</HTML>
