#include <stdio.h>
#include "lib.h"

/* Date le seguenti strutture
 * Giocatore{
 *  char nome[20+1];
 *  int squadra;
 *  int golfatti;
 * }
 * Squadra{
 *  int cod;
 *  char nome[20+1];
 * }
 * Sviluppare un programma che, mediante menù, consenta di:
 * 1. Caricare, nelle opportune liste, giocatori e squadre leggendo i file csv rispettivi
 * 2. Aggiungere un nuovo giocatore ed una nuova squadra (attenzione: il codice squadra è univoco)
 * 3. Rimuovere una squadra (attenzione: non possono esistere giocatori senza una squadra di riferimento)
 * 4. Stampare la classifica marcatori
 * 5. Dato in input una squadra stampare in ouput tutti i giocatori che appartengono ad essa, con il rispettivo numero di gol
 * */
int main() {

    int progStu = 0; //Progressivo Codice Studente
    Studente *testa = NULL; //Puntatore al primo nodo
    int scelta;
    int pos;
    char file_name[60+1];

    do {
        printf("Menu: \n");
        printf("1. Aggiungi Nodo in Testa\n");
        printf("2. Aggiungi Nodo in Coda\n");
        printf("3. Stampa lista\n");
        printf("4. Conta Nodi lista\n");
        printf("5. Aggiungi nodo alla posizione inserita\n");
        printf("6. Carica lista da File: \n");
        printf("7. Elimina nodo alla posizione inserita\n");
        printf("8. Ordina Lista per cognome\n");
        printf("0. Esci\n");
        printf("Scelta: ");
        scanf("%d",&scelta);
        switch (scelta) {
            case 1:
                testa = addOnHead(testa, &progStu); //Aggiungo nuovo nodo in testa alla lista
                break;
            case 2:
        }
    } while (scelta != 0);

    return 0;
}