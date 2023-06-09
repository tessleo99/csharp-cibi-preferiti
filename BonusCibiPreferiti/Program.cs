﻿// See https://aka.ms/new-console-template for more information


/*
 BONUS
Chiedere all'utente quanti cibi preferiti ha, e farglieli inserite da input della Console nell'array.
Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana.
Potrebbe essere interessante creare una funzione chiamata indiciMedianaArray(int lunghezzaArray) che vi restituisce l'indice della posizione mediana
(che restituisca gli indici delle eventuali posizioni mediani) e poi fare una funzione (StampaArrayMediana) che si occupa di fare tutto il lavoro con 
la funzione precedente e richiedendo direttamente l'intero array. Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari.
In questo caso vanno stampati i 2 elementi in centro alla vostra classifica. 
 */


//MAIN PROGRAM
//PASSO 1 : chiedo all'utente quanti cibi vuole inserire e gli faccio inserire i piatti

using System;

Console.Write("Quanti piatti preferiti hai?");
uint userFoods = uint.Parse(Console.ReadLine());

string[] favouriteFoods = new string[userFoods];

inputUserFavouriteFoods(favouriteFoods);

//PASSO 2 : stampo la lunghezza della mia classifica
Console.WriteLine("La lunghezza della classifica è: " + favouriteFoods.Length);

//PASSO 3 : stampare l’intero array in ordine indicando la posizione in classifica
printElementArray(favouriteFoods);

//PASSO 4 : CIBO TOP
printFirstElementArray(favouriteFoods);

//PASSO 5: CIBO MENO TOP
printLastElementArray(favouriteFoods);

//PASSO 6 : indici della mediana
printMedianIndexArray(favouriteFoods);

//PASSO 7 :indici + eleemnto della mediana
printMedianArray(favouriteFoods);



//FUNCTIONS

//PASSO 1 : creo una funzione che fa inserire all'utente i piatti
void inputUserFavouriteFoods(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
         Console.Write($"Inserisci il {i + 1} piatto: ");
         string userFood = Console.ReadLine();
         array[i] = userFood; 
    }
}



//PASSO 3 : creo una funzione che mi fa stampare l’intero array in ordine indicando la posizione in classifica
void printElementArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("- " + array[i] + " è l'elemento in posizione " + (i + 1));

    }
}

//PASSO 4 : CIBO TOP
void printFirstElementArray(string[] array)
{
    Console.WriteLine("Il primo elemento è : " + array[0]);
}

//PASSO 5: CIBO MENO TOP
void printLastElementArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.WriteLine("L'ultimo elemento è : " + array[i]);
        }
    }
}

//PASSO 6 : creo una funzione che mi fa trovare l'indice della mediana 

void printMedianIndexArray(string[] array)
{
    if (array.Length % 2 == 1)
    {
        Console.WriteLine("L'indice della mediana è: " + ((array.Length +1 ) /2 ) );
    }
    else
    {
        Console.WriteLine("Gli indici delli mediana sono: " + (array.Length / 2) + " e " + ((array.Length / 2) + 1) );
    }
}

//PASSO 7 : creo una funzione che mi dice sia l'elemento che l'indice mediana

void printMedianArray(string[] array)
{
    if (array.Length % 2 == 1)
    {
        int index = (array.Length + 1) / 2; 
        Console.WriteLine("La mediana è l'elemento: " + array[index - 1] + " con indice " + index );
    }
    else
    {
        int indexOne = (array.Length / 2) + 1;
        int indexTwo = (array.Length / 2);
        Console.WriteLine($"La mediana sono gli elementi:  {array[indexOne - 1]} e {array[indexTwo - 1]} e con rispettivi indici {indexOne} e {indexTwo}");
     
    }
}