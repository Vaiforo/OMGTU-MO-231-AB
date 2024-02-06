int amount_of_white, amount_of_gray, remaind_amount_of_white, remaind_amount_of_gray, k, remaind_amount_of_mice, position, counter, pos_r;
Random random = new Random();

Console.WriteLine("Введите количество серых мышек");
amount_of_gray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество белых мышек");
amount_of_white = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите каждую какую мышку съедать");
k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество серых мышек, которые должны остаться");
remaind_amount_of_gray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество белых мышек, которые должны остаться");
remaind_amount_of_white = Convert.ToInt32(Console.ReadLine());

remaind_amount_of_mice = amount_of_gray + amount_of_white;

int[] mice = new int[amount_of_gray + amount_of_white];

for (int i = 0; i < mice.Length; i++)
{
    mice[i] = 0;
}
if (k <= amount_of_gray + amount_of_white)
{
    position = 1;
    counter = mice.Length;

    while (remaind_amount_of_mice > remaind_amount_of_gray + remaind_amount_of_white)
    {
        if (position > mice.Length) position = 1;
        if (position % k == 0)
        {
            mice[position - 1] = 1;
            remaind_amount_of_mice--;
            position++;
        }
        else
        {
            if (mice[position - 1] == 0)
            {
                position++;
            }
        }
    }

    if (counter < remaind_amount_of_gray + remaind_amount_of_white)
    {
        Console.WriteLine("Невозможно рассадить");
    }
    else
    {
        counter = 0;
        while (counter < remaind_amount_of_gray)
        {
            pos_r = random.Next(0, mice.Length);
            if (mice[pos_r] == 0)
            {
                mice[pos_r] = 3;
                counter++;
            }
        }

        counter = 0;
        while (counter < amount_of_gray - remaind_amount_of_gray)
        {
            pos_r = random.Next(0, mice.Length);
            if (mice[pos_r] == 1)
            {
                mice[pos_r] = 3;
                counter++;
            }
        }

        counter = 0;
        while (counter < remaind_amount_of_white)
        {
            pos_r = random.Next(0, mice.Length);
            if (mice[pos_r] == 0)
            {
                mice[pos_r] = 2;
                counter++;
            }
        }

        counter = 0;
        while (counter < amount_of_white - remaind_amount_of_white)
        {
            pos_r = random.Next(0, mice.Length);
            if (mice[pos_r] == 1)
            {
                mice[pos_r] = 2;
                counter++;
            }
        }

        for (int i = 0; i < mice.Length; i++)
        {
            if (mice[i] == 3)
            {
                Console.Write("С");
            }
            if (mice[i] == 2)
            {
                Console.Write("Б");
            }
        }
    }
}
