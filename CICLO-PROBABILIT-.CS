Random ran = new Random();

int maxEsecuzioni = 5;
bool ciclo = true;
int startEsecuzioni = 0;

while (ciclo)
{
    int percentuale = ran.Next(1, 101); // Genera il primo numero casuale
    Console.WriteLine(percentuale);

    if (percentuale <= 30) // SI ATTIVA SOLO SE IL NUMERO è MENO DI 30 SEMPRE
    {
        int probabilitaSecondaria = ran.Next(1, 101); // Genera il secondo numero casuale dallo stesso oggetto IN MODO CHE LA CONDIZIONE IF SI ATTIVI SOLO UNA CERTA % DI VOLTE
        if (probabilitaSecondaria <= 40) // Secondo controllo con probabilità del 40%
        {
            startEsecuzioni++;
            Console.WriteLine($"CONTEGGIO SIAMO A {startEsecuzioni}");
        }

        if (startEsecuzioni == maxEsecuzioni)
        {
            ciclo = false;
            Console.WriteLine($"CICLO FINITO HAI RAGGIUNTO LE {startEsecuzioni}");
        }
    }
}

Console.ReadKey();
