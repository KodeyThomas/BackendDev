<?php
$drinks = ["Coke" => " £2","Fanta" => " £1.20","Sprite" => " £1.67"];
$pastries = ["Chocolate Bread","French Toast","Croissant"];
?>

<h1>Welcome to the Repetitive Cafe</h1>

<h3>Drinks!</h3>
<ul>
<?php foreach($drinks as $drink=>$price):?>
<li><?=$drink?><?=$price?></li>
<?php endforeach;?>
</ul>
<h3>Pastries! (£2 each)</h3>
<ul>
<?php foreach($pastries as $item):?>
<li><?=$item?></li>
<?php endforeach;?>
</ul>