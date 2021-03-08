<?php

function magic8ball() {
  $input = readline("What's you question >> ");
  echo "Your question is ".$input."\n";

  $randInt = rand(0,19);

  // echo $randInt;

  switch ($randInt) {
    case 0:
      echo "It is certain.";
      break;
    case 1:
      echo "It is decidedly so.";
      break;
    case 2:
      echo "Without a doubt.";
      break;
    case 3:
      echo "Yes - definitely.";
      break;
    case 4:
      echo "You may rely on it.";
      break;
    case 5:
      echo "As I see it, yes.";
      break;
    case 6:
      echo "Most likely";
      break;
    default:
      echo "No it won't..."; // TODO add more responses but oh well, it's only a mini project
      break;
  }
  echo "\n";
}

magic8Ball();