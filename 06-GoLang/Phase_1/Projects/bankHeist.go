package main

import (
	"fmt"
	"math/rand"
	"time"
)

func main() {
	rand.Seed(time.Now().UnixNano())

	isHeistOn := true
	eludedGuards := rand.Intn(100)

	// Phase 1 Of Heist
	if eludedGuards >= 50 {
		fmt.Println("Looks like you've managed to make it past the guards. Good job, but remember, this is the first step.")
	} else {
		isHeistOn = false
		fmt.Println("Plan a better disguse next time?")
	}

	// Phase 2 Of Heist
	openedValue := rand.Intn(100)

	if isHeistOn && openedValue >= 70 {
		fmt.Println("Grab and GO!")
	} else if isHeistOn {
		isHeistOn = false
		fmt.Println("Damm... The vault can't be opened")
	}

	// Phase 3 Of Heist
	leftSafely := rand.Intn(5)
	if isHeistOn {
		switch leftSafely {
		case 0:
			isHeistOn = false
			fmt.Println("They caught us!!")
		case 1:
			isHeistOn = false
			fmt.Println("Oh No! My hands stuck in the door!")
			fmt.Println("... The Police caught us")
		case 5:
			isHeistOn = false
			fmt.Println("Wait... I forgot the bags.")
			fmt.Println("Damm. They got us")
		default:
			fmt.Println("Start the getaway car!")
		}
	}

	// Phase 4 Of Heist
	if isHeistOn {
		amtStolen := 10000 + rand.Intn(1000000)
		fmt.Printf("Wow we stole $%d", amtStolen)
	}
	fmt.Println(isHeistOn)
}
