// (c) 2022 Yuto Inoue

Console.WriteLine("π=");

foreach (var c in CalculatePi())
{
	Console.Write(c);
	Task.Delay(30).Wait();
}

static IEnumerable<string> CalculatePi()
{
	foreach (var c in "3.141592653589793238462643383279502884")
	{
		yield return c.ToString();
	}

	var rand = new Random();
	while (true)
	{
		yield return rand.Next(10).ToString();
	}
}
