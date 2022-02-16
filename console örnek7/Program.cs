string[] metin = new string[5];
int i, x, z, sayac = 0;
string[] sesli = new string[] { "a", "e", "ı", "i", "u", "ü", "o", "ö" };

while (true)
{

    for (i = 0; i < 5; i++)
    {
        Console.Write("{0}. isimi giriniz: ", i + 1);
        metin[i] = Console.ReadLine();
    }





    foreach (var item in metin)
    {

        for (x = 0; x < 8; x++)
        {

            for (z = 0; z < item.Length; z++)
            {

                if (sesli[x].Contains(item[z]))
                {
                    sayac++;
                }

            }

        }

        Console.WriteLine("'{0}' ismindeki sesli harf sayısı: {1}", item.ToUpper(), sayac);
        sayac = 0;

    }

    Console.WriteLine("********************************************************************************");

}

//Girilen 5 isimdeki sesli harfleri bulma