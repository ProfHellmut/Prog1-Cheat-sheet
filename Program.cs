using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1CheatSheet   // Projektmapp
{
    class Program   // "Kodritning"
    {
        static void Main(string[] args) // Ingångspunkten för appen
        {
            // Variabel är en behållare för ett värde
            // Variabel kräver Datatyp och namn

            int tal1 = 10;                  // Heltal
            byte tal2 = 255;                // Heltal, 0-255
            long tal3 = 199005301234L;      // Heltal, många siffrer -Marcus

            // Flyttal är tal med decimaler
            float flyttal1 = 12.345f;       // 8 i precisionsvärde
            double flyttal2 = 123.456;      // Använd när float inte är möjligt
            decimal decimalTal = 1234.345M; // ANVÄND VID PENGAHANTERING

            // Tecken
            string text1 = "Hej på dig";    // Håller flera tecken text
            char text2 = '1';               // Håller ett tecken

            bool santEllerFalskt = true;    // Håller sant/falskt, 1/0

            // VAR
            var var1 = 1234.1234;           // Tar formen av värdet givet

            // Konstanter
            const float TAX_RATE = 0.25f;   // Kan inte ändra värde

            // BESLUTSATSER
            int input = 2;
            switch (input)  // switch tar in ett input som
            {               // den jämför med olika cases
                case 1:
                    // Kod
                    break;

                case 2:     // Kollar om värdet är "2"
                    // kod  // Kör koden om ovan stämmer
                    break;  // Hoppar ur switch-satsen

                case 3:
                    // Kod
                    break;

                default:
                    // Körs om inget ovan stämmer
                    break;
            }

            // IF-satsen
            if (input == 10 || input > 5) // ||(OR) kräver att ett av påståendena är true
            {
                // Kör kod om true
            }
            else if (((tal1 < 5 && tal2 > 2) || (tal3 == tal2/tal1)) && flyttal1 != 40)
            {
                // Kör kod om true
            }
            else
            {
                // Om inget ovan stämmer, kör kod
                // Tilldelningsoperander
                tal1 = 10;
                tal1 += 5; // tal1 15
                tal1 -= 5; // tal1 10
                tal1 *= 10;
                tal1 /= 10;
                tal1 %= 2; // modulus/rest

                tal1++; // Lägger till 1 efter koden körts
                ++tal1; // Lägger till 1 före
            }

            // Arrays
            int[] array1 = new int[4]; //datatyp[] namn = new datatyp[platser]
            array1[0] = 1;
            array1[1] = 2;
            array1[2] = 3;
            array1[3] = 4;

            int pos1 = array1[0]; // Lagrar första positionen i pos1

            // LOOPAR
            bool b1 = false;

            while(b1)   // Körs så länge argumentet är sant
            {
                // Kod
            }

            do // Precis som while fast den kör koden minst 1 gång
            {

            }
            while (b1);

            // Loop med räknare
            // 1. Skapa räknaren i och tilldela 0
            // 2. Kolla argumentet i < 10
            // 3. Kör kod
            // 4. Addera 1 till i, i++
            // 5. Kolla argument
            // 6. Kör kod
            // 7. Addera 1
            // Osv.
            for (int i = 0; i < 10; i++)
            {
                // Kod
            }

            // Foreach, använd när vi vill iterera igenom en samling
            // För varje integer i array1
            foreach (int tal in array1)
            {
                Console.WriteLine(tal);
            }
        }

        // METODER
        // accesstyp static returtyp Namn(parametrar)
        // Definierar man ingen accesstyp är den private
        static void Metod1()
        {
            // returtypen void betyder att den inte returnerar
            // ett värde.
        }

        // Metod som tar in en parameter
        // Returnerar talet i kvadrat
        public static int NumberSquared(int tal)
        {
            int x = tal * tal;
            return x;
        }

        // Metod som skapar objekt
        static void SkapaObjekt()
        {
            // Skapar objekt av klassen Person
            Person p1 = new Person("Charlie", 12, "Falun");
            Person p2 = new Person("Arvid", 3, "Falun");
        }


    }
}
