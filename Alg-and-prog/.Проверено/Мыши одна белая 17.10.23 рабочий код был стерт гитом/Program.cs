int n, k, pos, cur_position;
List<int> mice = new List<int>();
List<int> killed_mice = new List<int>();

Console.WriteLine("Введите количество мышей");
n = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine("Введите какую каждую мышь съедать");
k = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine("Введите позицию белой мыши");
pos = Convert.ToInt32(Console.ReadLine()) - 1;

for (int i = 0; i < n; i++)
{

    for (int j = 0; j <= n; j++)
    {
        if (i == pos)
        {
            killed_mice.Add(1);
        }
        else
        {
            killed_mice.Add(0);
        }
    }

    cur_position = i + k;
    if (cur_position >= killed_mice.Count)
    {
        while (cur_position >= killed_mice.Count)
        {
            cur_position -= killed_mice.Count;
        }
    }
    killed_mice.RemoveAt(cur_position);

    while (killed_mice.Count > 1)
    {
        cur_position += (k + 1 - (mice.Count - killed_mice.Count));

        if(cur_position >= killed_mice.Count) {
            while (cur_position >= killed_mice.Count)
            {
                cur_position -= killed_mice.Count;
            }
        }

        killed_mice.RemoveAt(cur_position);
    }

    if (killed_mice[0] == 1)
    {
        Console.WriteLine(i);
        break;
    }
} 