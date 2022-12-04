void Day1()
{
    string[] match = File.ReadAllLines("Day2.txt");

    int count = 0;
    int rock = 1;
    int paper = 2;
    int scissors = 3;

foreach (string line in match)
{
        if (line[0] == 'A')
        {
            if (line[2] == 'X')
                count = count + scissors + 0;
            if (line[2] == 'Y')
                count = count + rock + 3;
            if (line[2] == 'Z')
                count = count + paper + 6;
        }

        if (line[0] == 'B')
        {
            if (line[2] == 'X')
                count = count + rock + 0;
            if (line[2] == 'Y')
                count = count + paper + 3;
            if (line[2] == 'Z')
                count = count + scissors + 6;
        }

        if (line[0] == 'C')
        {
            if (line[2] == 'X')
                count = count + paper + 0;
            if (line[2] == 'Y')
                count = count + scissors + 3;
            if (line[2] == 'Z')
                count = count + rock + 6;
        }
    }

    Console.WriteLine(count);
}

