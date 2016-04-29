using UnityEngine;
using System.Collections;

public static class Dictionaries {

	public readonly Dictionary<Enums.Weapon, > FILE_TYPE_DICT = new Dictionary<string, XlFileFormat>
		{
			{"csv", XlFileFormat.xlCSV},
			{"html", XlFileFormat.xlHtml}
		};

}
