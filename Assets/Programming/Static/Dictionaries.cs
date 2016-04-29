using UnityEngine;
using System.Collections;

public static class Dictionary {

	public readonly Dictionary<string, XlFileFormat> FILE_TYPE_DICT = new Dictionary<string, XlFileFormat>
		{
			{"csv", XlFileFormat.xlCSV},
			{"html", XlFileFormat.xlHtml}
		};

}
