# Test Technique L’Atelier tenisu - Backend 🕷

Créer une API simple permettant de retourner les statistiques des joueurs de tennis.

Condition :
- Compléter les tâches avec tes technos préférées
- Créer le projet from scratch

Tâches :
- [x] Créer un endpoint qui retourne les joueurs. La liste doit être triée du meilleur au moins bon.
- [x] Créer un endpoint qui permet de retourner les informations d’un joueur grâce à sont ID.

- Créer un endpoint qui retourne les statistiques suivantes :
  - - [ ] Pays qui a le plus grand ratio de parties gagnées (Je n'ai pas compris comment calculer ce ratio)
  - - [x] IMC moyen de tous les joueurs
  - - [x] La médiane de la taille des joueurs
- [x] Déploie ton projet sur le Cloud.

## Versioning
| GitHub Release | .NET Core Version |
|----------------|-------------------|
| master         | 7                 |

Pour fonctionner, installer la version 7 de .NET Core ou utiliser Docker.

Pour configurer ce projet, vous devez cloner le dépôt git :

```sh
$ git clone https://github.com/YetiYetYet/TestTechniqueLAtelier.git
$ cd dotnet-core-web-api
```
suivi de la commande suivante pour restaurer les packages NuGet

```sh
$ dotnet restore
```
## Docker
Pour lancer l'application avec Docker, il suffit de lancer la commande suivante :

```sh
$ docker-compose up
```

La demo swagger de l'API est disponible sur ce lien :
https://lateliertesttechnique.azurewebsites.net/swagger/index.html

## Docker
Pour lancer l'application avec Docker, il suffit de lancer la commande suivante :

## Commentaires :
L'API est loin d'être parfaite et pourrait encore être améliorée.
- Première la tache 3 devait être renvoyer en un endpoints mais j'ai préférer les diviser en plusieurs endpoints pour plus de clarté. 
- Deuxièmement, je n'ai pas compris comment calculer le ratio de victoire d'un pays. J'ai donc renvoyé le premier joueur du fichier Json.
- Troisièmement, Pour le déploiement sur Azure, j'aurai pu l'améliorer pour faire un check des tests a chaque pull request puis le déployer sur azure automatiquement.

Je n'ai pas utilisé de base de données pour que le fichier Json puisse être remplacé.


