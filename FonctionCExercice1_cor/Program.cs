/**
 * Exercice 1 : programme avec une fonction saisie() avec paramettre et qui retourne un résultat
 * author : CT
 * date : 11/2022
 */
using System;

namespace FonctionCExercice1_cor
{
    internal class Program
    {
        /// <summary>
        /// Saisie de O ou N avec contrôle de saisie
        /// </summary>
        /// <param name="message">Message à afficher</param>
        /// <param name="valeur1">1er caractère accepté</param>
        /// <param name="valeur2">2e caractère accepté</param>
        /// <returns>lettre saisie</returns>
        static char saisie(string message, char valeur1, char valeur2)
        {
            char reponse;
            do
            {
                Console.WriteLine();
                Console.Write(message);
                reponse = Console.ReadKey().KeyChar;
            } while (reponse != valeur1 && reponse != valeur2);
            return reponse;
        }

        static void Main(string[] args)
        {
            // Déclarations
            float prix, total = 0;
            char rep;

            // demande si un prix est à saisir
            rep = saisie("Avez-vous un prix à saisir ? (O/N) ", 'O', 'N');

            // Boucle sur la saisie des prix et le cumul
            while (rep == 'O')
            {
                // saisie d'un nouveau prix
                Console.Write("   Entrez un prix = ");
                prix = float.Parse(Console.ReadLine());
                // cumul
                total = total + prix;
                // demande si un nouveau prix est à saisir
                rep = saisie("Avez-vous un prix à saisir ? (O/N) ", 'O', 'N');
            }

            // Affichage du total
            Console.WriteLine("   total des prix = " + total);
            Console.ReadLine();
        }
    }
}
