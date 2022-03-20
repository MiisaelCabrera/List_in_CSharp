using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_in_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> team1 = new LinkedList<string>();
            List<string> team2 = new LinkedList<string>();
            List<string> team3 = new LinkedList<string>();
            List<string> team4 = new ArrayList<string>();
            List<string> team5 = new ArrayList<string>();
            List<string> team6 = new ArrayList<string>();
            funcs(team1, team2, team3, 0);
            funcs(team4, team5, team6, 1);
        }

        static void funcs(List<string> team1, List<string> team2, List<string> team3, int controller)
        {
            controller *= 3;
            team1.addAtTail("Jesús");
            team1.addAtTail("Salomón");
            team1.addAtTail("Yael");

            team2.addAtFront("Cristian");
            team2.addAtFront("Daniel");
            team2.addAtFront("Diego");
            team3.addAtFront("Imelda");

            Iterator<string> iterator;

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Jesús
            // Salomón
            // Yael

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Diego
            // Daniel
            // Cristian

            team1.remove(0);
            team1.addAtFront("Rebeca");
            controller ++;
            Console.WriteLine("Team " + controller + " tiene: " + team1.getSize() + " integrantes"); // debe imprimir "Team 1 tiene 3 integrantes"

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Rebeca
            // Salomón
            // Yael

            team2.remove(2);
            team2.addAtTail("Rita");
            controller++;
            Console.WriteLine("Team "+controller+" tiene: " + team2.getSize() + " integrantes"); // debe imprimir "Team 2 tiene 3 integrantes"

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Diego
            // Daniel
            // Rita

            team3.remove(0);
            team3.remove(0); // El elemento no existe pero el programa no debe cerrarse por algún error

            team3.addAtTail("Tadeo");
            team3.addAtFront("Isai");

            controller++;
            Console.WriteLine("Team "+controller+" tiene: " + team3.getSize() + " integrantes"); // debe imprimir "Team 3 tiene 2 integrantes"

            iterator = team3.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            // Debió haber impreso
            // Tadeo
            // Isai

            if (team1.getAt(1).Equals("Salomón"))
                team1.setAt(1, "Luis");
            controller -= 2;
            Console.WriteLine("Team "+controller+" tiene: " + team1.getSize() + " integrantes"); // debe imprimir "Team 1 tiene 3 integrantes"

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }
            Console.WriteLine();
            Console.WriteLine();

            // Debió haber impreso
            // Rebeca
            // Luis
            // Yael

        }
    }
}
