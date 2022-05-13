# AutoFact
===========================================================================
- AutoFact est un logiciel destiné à simplifier la facturation pour les autoentrepreneurs.

## Prérequis et Installation
===========================================================================
- Visual Studio 2019 ou 2022
- SGBD SQL
- Décompresser le dossier si ce n'est pas déjà fait
- Insérer le dossier AutoFact dans le dossier source de votre Visual Studio (Optionnel)
- Importer le fichier .sql dans PhpMyAdmin (PhpMyAdmin est inclu dans WAMP)
- Modifier le fichier ../Login/bin/Documents/Template/templateAutoFact pour y mettre les coordonnées de votre entreprise en haut à gauche du document
  - Ne surtout pas modifier les informations notées avec les signes #

### Utilisation
===========================================================================
- Ouvrir le fichier AutoFact.sln grâce à Visual Studio
- Démarrer le programme dans Visual Studio
- Lancer le SGBD
- Cliquer sur le bouton d'authentification
- Créer un compte lors de la première utilisation (ensuite vous n'aurez plus qu'à vous connectez avec votre compte)
- Une fois connecter, vous pouvez grâce aux boutons dédiés :
  - Gérer vos client
  - Gérer vos prestations
- Une fois les prestations et les clients créés, cliquez sur le bouton "Ajouter un Document", puis :
  - Sélectionnez votre client
  - Ajoutez la description du document ainsi que les prestations concernées avec leur quantité
  - Enregistrez le Devis ou la Facture
- Retrouvez le devis / la facture, créé(e) dans la page Document,dans le dossier du logiciel au chemin ../Login/bin/Documents/Devis&Factures
- Retrouvez le graphique de votre Chiffre d'Affaire grâce au bouton Graphique.

### Améliorations à venir
===========================================================================
- Régler le problème de sélection lors de la création d'un document

#### Contributeurs
===========================================================================
- Rochette Adeline alias @adelinerochette
- Chevrier Clément alias @RedOren28

https://github.com/sack-dev/autofact
