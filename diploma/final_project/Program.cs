string[] weekDays = new string[] { "Sun", "Mond", "Tue", "Wed", "Thu", "Frid", "Sa" };
string result = "[";
	for (int i = 0; i < weekDays.Length; i++)
	{ 
		if (weekDays[i].Length <= 3) result += $"{weekDays[i]}, ";
		}

	result.Trim(',');
	result += "]";

System.Console.WriteLine(result);
