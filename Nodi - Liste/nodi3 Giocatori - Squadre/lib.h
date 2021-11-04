//
// Created by e.cucchietti.1732 on 04/11/2021.
//

#ifndef NODI3_GIOCATORI___SQUADRE_LIB_H
#define NODI3_GIOCATORI___SQUADRE_LIB_H


#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct giocatori{
    char cognome[20];
    int codiceSquadra;
};

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

#endif //NODI3_GIOCATORI___SQUADRE_LIB_H
