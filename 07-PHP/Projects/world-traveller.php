<?php
  $riel = 2103942;
  $kyat = 19092;
  $krones = 109;
  $lek = 9094;

  echo "We have $riel riel, $kyat kyat, $krones krones and $lek lek";

  $rielExchange = 0.00025;
  $kyatExchange = 0.00071;
  $kronesExchange = 0.12;
  $lekExchange = 0.0097;

  $rielUSD = $riel*$rielExchange;
  $kyatUSD = $kyat*$kyatExchange;
  $kronesUSD = $krones*$kronesExchange;
  $lekUSD = $lek*$lekExchange;

  echo "\nCurrency Conversion to USD";
  echo "\n".$rielUSD."USD from riel";
  echo "\n".$kyatUSD."USD from kyat";
  echo "\n".$kronesUSD."USD from krones";
  echo "\n".$lekUSD."USD from lek";

  $final = $rielUSD + $kyatUSD + $kronesUSD + $lekUSD - 1;

  echo "\nYour final USD is: $final";