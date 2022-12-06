using System.ComponentModel;

void Day2()
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

void Day3()
{
    string[] items = File.ReadAllLines("Day3.txt");
    string compartment1;
    string compartment2;
    int count = 0;
    int position = 0;
    foreach (string item in items)
    {
        count = item.Count() / 2;
        compartment1 = item.Substring(0, count);
        compartment2 = item.Substring(count);
        foreach (char c in compartment1)
        {
            if (compartment2.Contains(c))
            {
                if (c >= 'a' && c <= 'z')
                {
                    position += Math.Abs(c - 'a' + 1);
                    break;
                }
                else
                {
                    position += Math.Abs(c - 'A' + 27);
                    break;
                }
            }
        }
    }
    Console.WriteLine(position);
}

void Day3Part2()
{
    string[] items = File.ReadAllLines("Day3.txt");
    string first;
    string second;
    string third;
    int f=0;
    int s=1;
    int t=2;
    int position = 0;
    for (int i=0; i<items.Length; i++)
    {
        first = items[f];
        second = items[s];
        third = items[t];
        foreach (char c in first)
        {
            if (second.Contains(c) && third.Contains(c))
            {
                if (c >= 'a' && c <= 'z')
                {
                    position += Math.Abs(c - 'a' + 1);
                    break;
                }
                else
                {
                    position += Math.Abs(c - 'A' + 27);
                    break;
                }
            }
        }
        f += 3;
        s += 3;
        t += 3;
    }
    Console.WriteLine(position);
}