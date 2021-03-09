<?php
  // Change player location
function changeLocation(){	
  // Write your code here:
  global $location;
  
  echo "Where do you want to go?\n";

  $whereDoIWantToGo = readline(">> ");

  $whereDoIWantToGo = strtolower($whereDoIWantToGo);
  
  // Decision making based on location
  if (($location === "kitchen") && ($whereDoIWantToGo === "bathroom")) {
    echo "You go to: bathroom.\n";
    $location = "bathroom";
  } elseif (($location === "kitchen") && ($whereDoIWantToGo === "woods")) {
    echo "You follow the winding path, shivering as you make your way deep into the Terror Woods.\n";
    $location = "woods";
  } elseif (($location === "bathroom") && ($whereDoIWantToGo === "kitchen")) {
    echo "You go to: kitchen.\n";
    $location = "kitchen";
  } elseif (($location === "woods") && ($whereDoIWantToGo === "kitchen")) {
    echo "You go to: kitchen.\n";
    $location = "kitchen";
  } elseif ($whereDoIWantToGo === "woods" || "kitchen" || "bathroom") {
    echo "You can't go directly to there from your current location. Try going somewhere else first.\n";
  } else {
    echo "That doesn't make sense. Are you confused? Try 'look around'.\n";
  }
}