# Tâches à réaliser

## Rapport

Pour Betty:

* Écrire le cahier des charges.

## Sur la base de données

### Vues

Pour Betty:

* Plat: ID, Label, Label type plat (Plat + Type_de_plat)
* Invité: idem table
* Réception: idem table
* Menu proposé: ID réception, label réception, id plat, label plat, label type plat (Proposer)
* Menu réservé: ID réception, label réception, ID invité, prénom invité, nom invité, id plat, label plat, label type plat (Choisir)
* Inscrits: ID réception, label réception, ID invité, prénom invité, nom invité (Participer)
* Tables de réception: ID réception, label réception, ID table, ID invité, prénom invité, nom invité (Se placer)
* Relation entre invités:  ID invité, prénom invité, nom invité, type relation, ID invité autre, prénom invité autre, nom invité autre. (Ressentir)
* Relation entre invité et plat: ID invité, prénom invité, nom invité, type relation, id plat, label plat, label type plat (Eprouver)

!!!! Dates et utilisateur pour modification

### Procédures stockées

Pour Betty:

* Création/modification/suppression réception
* Création/modification/suppression menu
* Création(/modification/suppression) client

Pour Sébastien:

* "Get" Menu pour une réception
* Création/modification/suppression relation entre clients
* Création/modification/suppression relation entre client et plat
* Choisir plat pour réception
* Inscription/annulation client à réception
* Liste client pour table
* asseoire client à une table
* liste clients pour une réception
* liste des plats commandés pour une réception

### Triggers

Pour Sébastien:

Á déterminer suivant les règles métier.

## Remarques:

Ne pas oublier de mettre à jour le diagramme de Gantt!!!