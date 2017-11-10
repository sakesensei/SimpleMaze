using System;


namespace SimpleMaze
{
	class Program
	{
		static class Util
		{
			public static string GetWall(int num)
			{
				string wall;

				if (num == 1)
				{
					wall = "\\";
				}
				else
				{
					wall = "/";
				}

				return wall;
			}
		}

		static void Main(string[] args)
		{
			Random rng = new Random();

			int width = Console.WindowWidth - 1;
			int height = Console.WindowHeight - 1;

			for (int j = 0; j < height; j++)
			{
				for (int i = 0; i < width; i++)
				{
					//wall = (rng.Next(0, 1) == 1) ? "\\" : "/";

					if (rng.Next(1,2) == 2)
					{

					}

					if (i < width - 1)
					{
						Console.Write(Util.GetWall(rng.Next(2)));
					}
					else
					{
						Console.WriteLine(Util.GetWall(rng.Next(2)));
					}
				}
			}

			Console.ReadLine();
		}
	}
}
