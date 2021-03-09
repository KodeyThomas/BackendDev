<?php
  
function cookSoup(){
	// Write your code here:
  global $location,$has_mushrooms,$has_soup;

  if ($location && $has_mushrooms) {
    echo "You made some mushroom soup. Mushroom is the queen of all soups!\n";
    $has_mushrooms = false;
    $has_soup = true;
  } else {
    echo "You can't cook like this! You need something to cook AND to be in the kitchen.\n";
  }
}