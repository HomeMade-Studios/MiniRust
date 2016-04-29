using UnityEngine;
using System.Collections;

public static class Structs {

	public struct Tool {

		float bulletDamage { get; set; }
		float biteDamage { get; set; }
		float slashDamage { get; set; }
		float stabDamage { get; set; }
		float bluntDamage { get; set; }
		float maxRange { get; set; }
		float minRange { get; set; }
		float attackSpeed { get; set; }

		float rockGathering { get; set; }
		float woodGathering { get; set; }
		float animalGathering { get; set; }

	}

	public struct Armor {

		float bulletResistance { get; set; }
		float biteResistance { get; set; }
		float slashResistance { get; set; }
		float stabResistance { get; set; }
		float bluntResistance { get; set; }

	}

}
