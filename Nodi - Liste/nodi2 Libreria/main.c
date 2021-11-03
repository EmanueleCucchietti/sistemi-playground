#include "listaLib.h"

int main()
{
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
                testa = addOnTail(testa, &progStu, NULL);
                break;
            case 3:
                showList(testa);
                break;
            case 4:
                printf("La lista presenta %d nodi\n",contaNodi(testa));
                break;
            case 5:
                printf("Inserire la posizione in cui inserire il nuovo nodo: ");
                scanf("%d",&pos);
                testa = addByPos(testa,&progStu,pos);
                break;
            case 6:
                printf("Inserire nome file: ");
                scanf("%s",file_name);
                testa = loadFromFile(testa,&progStu,file_name);
                break;
            case 7:
                printf("Inserire la posizione in cui rimuovere il nodo: ");
                scanf("%d",&pos);
                testa = delByPos(testa,pos);
                break;
            case 8:
                sortList(testa);
                break;

        }
    } while (scelta != 0);

    return 0;
}