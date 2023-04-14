// See https://aka.ms/new-console-template for more information
/*
 Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi).
Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
La lunghezza della classifica
La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
Il vostro cibo top (prima posizione della classifica)
Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
Cercate per ogni richiesta che viene fatta di preparare le rispettive funzioni  e di usarle nel vostro programma principale!
 */

//MAIN PROGRAM
//PASSO 1 : dichiaro l'array

using System;

string[] favouriteFoods = { "pizza", "carbonara", "parmigiana", "spezzatino", "alici" };

//PASSO 2 : stampo la lunghezza della mia classifica
Console.Write("La lunghezza della classifica è: " + favouriteFoods.Length);

//PASSO 3 : stampare l’intero array in ordine indicando la posizione in classifica
printElementArray(favouriteFoods);
printFirstElementArray(favouriteFoods);
printLastElementArray(favouriteFoods);





//FUNCTIONS

//PASSO 3 : creo una funzione che mi fa stampare l’intero array in ordine indicando la posizione in classifica
void printElementArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.WriteLine("- " + array[i] + " è l'elemento in posizione " + (i+1));
  
    }
}

void printFirstElementArray(string[]array)
{
    Console.WriteLine("Il primo elemento è : " + array[0]);
}

void printLastElementArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if ( i ==  array.Length - 1 )
        {
            Console.WriteLine("L'ultimo elemento è : " + array[i]);
        }
    }
}