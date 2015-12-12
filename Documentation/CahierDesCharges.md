# Cahier des charges

Ce projet est réalisé dans le cadre de notre cours de développement SGBD. Il nous est demandé de réaliser une application permettant d'organisation des réceptions.

L'application doit permettre de gérer les réceptions, les invités et les repas.

L'organisateur doit pouvoir créer une réception pour une date donnée. Pour cette réception, un menu sera établit. Ce menu doit être composé d'au moins une entrée, un plat principal et un dessert. L’organisateur pourra également définir le nombre maximum d'invités et le nombre de places par tables pour chaque réception.

Les invités pourront s'inscrire aux réceptions, une seule inscription par invité et par réception. Lorsqu'ils seront inscrits, les clients devront obligatoirement choisir dans le menu proposé pour cette réception une (et une seule) entrée, un (et un seul) plat principal et un (et un seul) dessert. Il est évident qu'un client ne pourra pas s'inscrire à une réception déjà terminée et ne pourra pas non plus s'inscrire à plusieurs réceptions qui ont lieu en même temps.

Pour qu'une réception soit réussie, il faut que l'organisateur puisse connaitre les goûts des invités en matière de plats, et les affinités entre les invités. Ainsi, un invité devra pouvoir donner ses préférences ("j'aime", "je n'aime pas") vis à vis des plats et des autres invités. Sur base de ces informations, l'organisateur pourra établir son menu et son plan de table.

Sur base des relations entre les invités, l'application pourra proposer un plan de table. Il ne pourra y avoir autour d'une même table des personnes qui ne s'aiment pas, et, dans la mesure du possible, on essaiera de réunir les personnes qui s'apprécient. L'organisateur aura le loisir de modifier, ou non, ce plan de table. Dans tous les cas, une table ne pourra pas contenir un seul invité.

Pour chaque réception, nous devrons avoir son nom et la date et l'heure à laquelle elle aura lieu.

Pour chaque invités,  nous devrons connaitre son nom, son prénom, son sexe, son âge et sa profession. La combinaison "nom" et "prénom" devra être unique.

Pour chaque plat, nous devrons connaître sa nature et son nom. Par nature, nous entendons "entrée", "plat principal" et "dessert".

Pour sa gestion quotidienne, l'organisateur doit pouvoir déterminer par qui et quand une modification a été apportée. Un acronyme unique sera attribué à chaque invité et il servira à les identifier pour les modifications.

Pour la base de données, un organisateur pourra accéder aux informations concernant les clients, mais les clients ne pourront pas accéder aux informations propres à l'organisation des réceptions.