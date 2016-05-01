using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class Inventory {

	static int woodAmount { get; set; }
	static int stoneAmount { get; set; }
	static int metalOreAmount { get; set; }
	static int sulfurOreAmount { get; set; }
	static int metalAmount { get; set; }
	static int sulfurAmount { get; set; }
	static int clothesAmount { get; set; }
	static int boneAmount { get; set; }
	static int leatherAmount { get; set; }

	static int waterAmount { get; set; }
	static int cookedFoodAmount { get; set; }
	static int rawFoodAmount { get; set; }

	static List<object> inventoryList { get; set; }

}
