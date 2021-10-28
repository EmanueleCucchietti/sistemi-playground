#ifndef INC_01_NODO_LISTALIB_H
#define INC_01_NODO_LISTALIB_H

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <io.h>

typedef struct studente{
    int codice;
    char cognome[20];
    float media;
    struct studente *next;
}Studente;

Studente* addOnHead(Studente *testa, int *prog); //Aggiungo nuovo nodo in testa alla lista
Studente* addOnTail(Studente *head, int *prog, Studente *newSt);
Studente* nuovoStudente(int *prog);
Studente* nuovoStudenteDaFile(int *prog,char *cogn, float media);
int contaNodi(Studente *testa);
void showList(Studente *head);
Studente* addByPos(Studente *testa, int *prog,int posizione);
Studente* delByPos(Studente *testa, int *prog,int posizione);
Studente* loadFromFile(Studente *head, int *prog, char* file_name);

void showList(Studente *head){
    Studente *pLista;
    if(head == NULL)
        printf("Lista Vuota\n");
    else
    {
        pLista = head;
        printf("Lista Studenti\n");
        printf("\nCodice\tCognome\t\tMedia");
        do{
            printf("\n%d\t%s\t\t%f\n", pLista->codice, pLista ->cognome, pLista->media);
            pLista = pLista->next;
        }
        while(pLista != NULL);
    }

}
Studente* addOnHead(Studente *head, int *prog){
    Studente *pStu; //Puntatore al nuovo nodo
    pStu = nuovoStudente(prog);
    pStu ->next = head;
    return pStu;
}
Studente* addOnTail(Studente *head, int *prog, Studente *newSt){
    Studente *pLista;
    Studente *pStu;
    if(newSt == NULL)
        pStu = nuovoStudente(prog);
    else
        pStu = newSt;

    if(head == NULL)
        head =  pStu;
    else
    {
        pLista = head;
        while (pLista->next != NULL)
            pLista = pLista->next;
        pLista -> next = pStu;
    }
    return head;

    pLista = head;
    while (pLista->next != NULL)
        pLista = pLista -> next;
    pLista -> next = pStu;
}
Studente* nuovoStudente(int* prog){
    int cod;
    char cogn[20];
    float med;
    Studente *pNew;


    (*prog)++;
    printf("Nuovo Studente: \n");
    printf("Inserisce Cognome: ");
    scanf("%s",cogn);
    do {
        printf("Inserisci Media: ");
        scanf("%f",&med);
    } while (med < 2 || med > 10);

    pNew = (Studente*) malloc(sizeof (Studente));
    pNew -> codice = *prog;
    strcpy(pNew -> cognome,cogn);
    pNew -> media = med;
    pNew -> next = NULL;

    return pNew;
}
Studente* nuovoStudenteDaFile(int *prog,char *cogn, float media){
    int cod;
    Studente *pNew;


    (*prog)++;

    pNew = (Studente*) malloc(sizeof (Studente));
    pNew -> codice = *prog;
    strcpy(pNew -> cognome,cogn);
    pNew -> media = media;
    pNew -> next = NULL;

    return pNew;
}
int contaNodi(Studente *head){
    Studente *pLista;
    int cont =0;
    if(head == NULL)
        cont =0;
    else
    {
        pLista = head;
        while (pLista->next != NULL){
            cont++;
            pLista = pLista->next;
        }
        cont++;
    }
    return cont;
}
Studente* addByPos(Studente *head, int *prog,int posizione)
{
    Studente *pLista;
    Studente *pStu;
    Studente *forwardedNext;
    pStu = nuovoStudente(prog);

    if(head == NULL){
        pStu ->next = head;
        return pStu;
    }
    else
    {
        pLista = head;

        int i=0;
        while (pLista->next != NULL && i<posizione-1){
            pLista = pLista->next;
            i++;
        }
        forwardedNext = pLista -> next;
        pLista -> next = pStu;
        pStu -> next = forwardedNext;
    }
    return head;

}
/*
Studente* delByPos(Studente *head, int *prog,int posizione)
{
    Studente *pLista;
    Studente *pStu;
    Studente *forwardedNext;
    pStu = nuovoStudente(prog);

    if(head == NULL){
        pStu ->next = head;
        return pStu;
    }
    else
    {
        pLista = head;

        int i=0;
        while (pLista->next != NULL && i<posizione-1){
            pLista = pLista->next;
            i++;
        }
        forwardedNext = pLista -> next;
        pLista -> next = pStu;
        pStu -> next = forwardedNext;
    }
    return head;

}*/
Studente* loadFromFile(Studente *head, int *prog, char* file_name){

    FILE *fp;
    char row_file[20+1];
    char cogn[15+1], med[15+1];
    float media;
    int nb;
    int i,j;
    Studente *pNew;
    fp=fopen(file_name, "r");
    if(fp == NULL)
        printf("Apertura non avvenuta\n");
    else
    {
        while(!feof(fp))
        {

            fgets(row_file, 20+1, fp);

            i=0;
            j=0;
            while (row_file[i]!=';')
            {
                cogn[i] = row_file[i];
                i++;
            }
            cogn[i]= '\0';
            i++;
            while (row_file[i]!= '\0')
            {
                med[j] = row_file[i];
                i++;
                j++;
            }
            med[j]= '\0';
            media = atof(med);
            printf("Cogn: %s - Media: %.2f\n",cogn,media);
            pNew = nuovoStudenteDaFile(prog,cogn,media);
            head = addOnTail(head,&prog,pNew);


            //nb = fread(row_file, sizeof(char), sizeof(row_file), fp);
            int len = strlen(row_file);
        }
        fclose(fp);
    }

}
#endif //INC_01_NODO_LISTALIB_H