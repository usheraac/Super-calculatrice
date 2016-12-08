using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace labo3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t ******Bienvenu dans la SUPERCALCULATRICE******\n\n");
            Console.WriteLine("\t\t Pour effectuer un calcul: entrez le nom de la fonction suivi des paramètres du calcul\n");
            Console.WriteLine("\t\t Les fonctions disponibles: adder, sum, diff, multi, cos, sin, tan\n");
            Console.WriteLine("\t\t Synthaxe: fonction  paramètre.\t Exemple 1:cos 50 \t Exemple 2: Sum 1 2\n\n");
            Console.WriteLine("\t\t\t\t *****Entrez 'exit' pour quitter!******\n\n");

            //chargement des chemins vers les fichiers dll

            string[] filePaths = Directory.GetFiles(@".\command", "*.dll");

            string line = "";
            while (line != "exit")
            {

                string[] value;
                int i = 0;
                int n = 0;
                string fonction = "";
                bool test = true;




                try {

                    //récuperation des commandes utilisateurs

                    line = Console.ReadLine();

                    //récuperation de la chaine entrante en tableau de string
                    value = line.Split();

                    // récupération de la longueur de la chaine
                    n = value.Length;

                    //initialisation d'un tableau de données pour les opérations
                    string[] liste = new string[n];

                    //boucle de tri de la chaine entrée par l'utilisateur 
                    foreach (string t in value)
                    {
                        //récuperation de la fonction 
                        if (i == 0) { fonction = t; }

                        //récuperation des données
                        else { liste[i] = t; }
                        i++;

                    }

                    foreach (string chemin in filePaths) {
                        Assembly computer = Assembly.LoadFrom(chemin);



                        // boucle de recherche de toute les classes qui héritent de l'interface computer 
                        foreach (Type t in computer.GetTypes())

                        {
                            if (t.Name == fonction)
                            //if (t.IsClass && typeof(computer.Computer).IsAssignableFrom(t))
                            {

                                test = true;
                                Console.WriteLine(">>> Calling: " + t.Name);

                                computer.Computer var = (computer.Computer)Activator.CreateInstance(t);
                                Console.WriteLine(var.Execute(liste));
                                break;
                            }
                            else { test = false; }

                        }

                        if (test) { break; }

                    }

                   if (!test) { Console.WriteLine("sorry, Votre fonction n'est pas reconnu."); }
                }
                
                
                
                catch (Exception)
                {
                    Console.WriteLine("Sorry, vous avez dû entrer une séquence érronée, calmez-vous et recommencez.");

                }
            }


       
       }
    }
}
