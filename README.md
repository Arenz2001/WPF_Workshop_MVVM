Introduction

Pour ce workshop, vous allez développer en C# une petite application de conversion d'une chaine de caractères de minuscules à majuscules. Cette application devra être conçue selon un schéma d'architecture de type MVVM et pourra évoluer fonctionnellement en limitant au maximum la propagation des modifications dans le code source.

Pour cela, vous allez utiliser l'environnement de développement logiciel que vous avez installé et configuré pendant la séquence 0. Cet environnement de travail est composé de :

    Visual Studio 2019

    .NET Core 3.0

    Git

Vous n'oublierez donc pas de réaliser les activités proposées dans ce workshop en utilisant l'outil Git de gestion des versions que vous avez installé dans votre environnement.

De plus, vous réaliserez la conception de votre application avec le formalisme UML que vous utiliserez pour décrire, avant de coder, votre modèle d'architecture MVVM ainsi que les objets et données qui le composent. Vous proposerez au moins une vue statique (diagramme de classes) et au moins une vue dynamique (diagramme de séquences) de votre architecture.

Si besoin, l'outil gratuit ArgoUML pourra vous aider pour travailler la conception UML de votre application.

https://www.clubic.com/telecharger-fiche122322-argouml.html

Nota : Dans le cas d'un choix d'utilisation de ArgoUML, il est conseillé d'avoir d'abord installé en pre-requis la dernière version disponible du JRE pour Windows. En effet, les installations du JRE et de ArgoUML au travers de l'installer de ArgoUML ne donnent pas entière satisfaction.

https://www.oracle.com/java/technologies/javase/javase8-archive-downloads.html

Deuxième version de votre application - Le mode graphique

Cette deuxième version de votre application répond au même cahier des charges de conversion, en majuscules, d'une chaine de caractères en minuscules.

L'évolution fonctionnelle par rapport à la première version consiste à gérer les interactions avec l'utilisateur en mode graphique au travers d'une IHM (Interface Homme Machine).

Le développement de cette deuxième version de votre application devra s'appuyer sur WPF (Windows Presentation Foundation), les spécifications graphiques du framework .NET.

L'interface graphique devra comporter :

    Un champ éditable pour la saisie de la chaîne à convertir.

    Un champ non éditable pour l'affichage de la chaîne convertie en majuscule.

    Un bouton poussoir pour lancer le traitement de conversion.

Pour cette deuxième version de votre application en mode graphique, vous devez faire évoluer votre conception UML de l'architecture et des données de l'application précédemment conçue pour le mode console.

Vous montrerez et commenterez alors comment l'architecture de type MVVM permet de limiter la propagation des modifications du code source pour passer de la première version (mode console) à la deuxième version (mode graphique).

Une fois la conception terminée, vous procéderez au développement en langage C# de votre application en mode graphique.

Bien entendu, avant de considérer le développement de votre application en mode graphique comme TERMINE, vos procédez de nouveau aux tests de recette tels que proposés pour le mode console. Vous vérifierez alors que tous les tests de recette sont OK.
