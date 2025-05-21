<img src="https://github.com/user-attachments/assets/275bf7e7-cebb-44bc-b42b-5fa9ede968e3" alt="Chrono Corp's logo" style="width:auto; height:60px;">

## Description du projet 
ChronoCorp est une application moderne et intuitive pour les entreprises qui offre un système de gestion d'horaire, gestion de demande de congé et qui permet de générer et envoyer la paie. Cette solution permet de conserver un historique structuré et facilite le suivi des informations pour l’ensemble du personnel.

## Technologie Utilisées
-	Frontend: WPF
-	Backend: Développement C# à l'aide de MVVM Toolkit
-	Persistance : Implémentation de EntityFrameworkCore, EntityFrameworkCore.Design, EntityFrameworkCore.Relational, Pomelo.EntityFrameworkCored.MySql, MySql.Data (BD MySql sur serveur local)


## Démo employée
https://github.com/user-attachments/assets/fb63c7b3-9afc-4758-b801-6a6e33780448


## Démo gestionnaire
https://github.com/user-attachments/assets/c5ff90ee-f1c7-44ee-be3e-009293d2be81


## Démo ressources humaines
https://github.com/user-attachments/assets/961bc6a2-08ee-4933-b985-e6d87b13d619


## Étapes de déploiement
- Créer une bd "chronocorp" dans Heidi
- À partir des fichiers, double-cliquez sur ChronoCorp.sln
- Onglet Outils > Gestionnaires de package NuGet > Console du gestionnaires de package (ou git bash depuis le dossier ChronoCorp)
```
cd ChronoCorp
```
```
dotnet tool install --global dotnet-ef --version 8.*
```
** FERMER Visual Studio -> Rouvrir VS à partir de la solution et rouvrir la console
```
cd ChronoCorp
```
```
dotnet restore
```
```
dotnet ef database update
```
ceci devrait être le résultat:
```
Build started...
Build succeeded.
Applying migration '20250508230848_UpdateBd'.
```
- Prendre les donnes_bidon.sql dans le dossier Planification > sql et les insérer dans la bd
