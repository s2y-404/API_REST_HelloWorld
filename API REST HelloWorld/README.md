# Mon Projet API

Ce projet est une API REST développée en C# avec .NET, qui fournit une méthode "Hello World" pour saluer les utilisateurs.

## Configuration requise

Avant de pouvoir exécuter le projet, assurez-vous d'avoir les éléments suivants installés sur votre machine :

- .NET SDK (>= version 7.0.202) : [télécharger ici](https://dotnet.microsoft.com/download)
- IDE (par exemple, [Visual Studio Code](https://code.visualstudio.com/)) ou un autre éditeur de code

## Installation

1. Clonez le repository GitHub vers votre machine locale :

```
git clone https://github.com/s2y-404/API_REST_HelloWorld.git
```

2. Accédez au répertoire du projet :

```
cd API_REST_HelloWorld
```

## Lancement du projet

1. Ouvrez un terminal ou une invite de commandes dans le répertoire du projet.

2. Exécutez la commande suivante pour lancer le projet :

```
dotnet run --project "API_REST_HelloWorld"
```

3. L'API sera accessible à l'adresse apparue dans votre terminal, généralement : [https://localhost:5001](https://localhost:5001)

## Utilisation de l'API

Une fois le projet lancé, vous pouvez utiliser votre navigateur ou un outil tel que Postman pour effectuer des requêtes à l'API.

- Pour saluer un utilisateur, envoyez une requête GET à l'URL suivante : [https://localhost:5001/HelloWorld?firstname=Stanley](https://localhost:5001/HelloWorld?firstname=Stanley)
   Remplacez `Stanley` par le prénom de votre choix.

   Vous devriez recevoir une réponse avec le message "Hello {firstname}!", où {firstname} est le prénom que vous avez spécifié.

- Lorsque aucun nom d'utilisateur est renseigné vous devriez recevoir un reponse avec le message "Aucun nom n'a été renseigné" et un "400" en code retour.


