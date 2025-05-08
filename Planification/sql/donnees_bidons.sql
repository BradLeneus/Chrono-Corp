# employee
INSERT INTO employee (Id, IdSuperieur, Prenom, Nom, Courriel, AdresseLigne1, AdresseLigne2, Ville, CodePostal, Telephone, DateNaissance, ContactUrgenceTel, ContactUrgenceNom, DateEmbauche, Departement, Poste, Salaire, EstActif) VALUES
(330152, NULL, 'Amalee', 'Lombard', 'alombard0@ning.com', '8 Linden Hill', 'Room 325', 'Yingcui', NULL, '2619454579', '2000-02-16', '3483298657', 'Amalee Lombard', '2021-11-10', 'Ventes', 'Chef de rayon', 24.12, TRUE),
(431999, 330152, 'Hadlee', 'Towers', 'htowers1@usa.gov', '9 Dahle Crossing', 'Suite 64', 'Idanre', NULL, '5991885505', '1990-05-30', '6901477338', 'Hadlee Towers', '2021-08-04', 'Marketing', 'Caissier', 17.85, TRUE),
(432401, 330152, 'Nona', 'Fillon', 'nfillon2@wordpress.com', '66 Spenser Circle', 'Room 1924', 'Vogan', NULL, '3354048261', '2003-05-05', '7365638403', 'Nona Fillon', '2015-03-20', 'Service à la clientèle', 'Conseiller client', 19.74, TRUE),
(433753, 330152, 'Lila', 'Tomasoni', 'ltomasoni3@upenn.edu', '628 Norway Maple Plaza', 'Suite 70', 'Lazarat', NULL, '4097371461', '1986-07-17', '3523333007', 'Lila Tomasoni', '2022-05-01', 'Logistique', 'Réceptionniste marchandises', 22.47, TRUE),
(434212, 330152, 'Adrian', 'Torbeck', 'atorbeck4@icio.us', '972 Bluestem Street', 'Suite 66', 'Samho-rodongjagu', NULL, '4196268115', '2000-02-10', '8533600489', 'Adrian Torbeck', '2023-11-15', 'Inventaire', 'Préposé aux stocks', 20.99, TRUE),
(435377, 330152, 'Esteban', 'Synnot', 'esynnot5@pcworld.com', '298 Briar Crest Pass', '20th Floor', 'Yangchun', NULL, '5917379415', '1981-07-11', '8013733112', 'Esteban Synnot', '2023-06-21', 'Ventes', 'Conseiller en électronique', 16.03, TRUE),
(436222, 330152, 'Darrel', 'Chardin', 'dchardin6@ask.com', '5912 Charing Cross Trail', 'Apt 1025', 'Kembang', NULL, '4004106016', '1991-01-01', '1131519685', 'Darrel Chardin', '2015-10-01', 'Comptabilité', 'Commis comptable', 20.55, TRUE),
(437745, 330152, 'Valina', 'Quakley', 'vquakley7@smh.com.au', '83 Paget Circle', 'Apt 968', 'Lanot', NULL, '4535978928', '2000-07-21', '9338947542', 'Valina Quakley', '2024-12-26', 'Achats', 'Agent d''approvisionnement', 18.90, TRUE),
(438412, 330152, 'Karel', 'Ivashechkin', 'kivashechkin8@prnewswire.com', '6 Kim Crossing', '15th Floor', 'Villarrica', NULL, '3141376029', '1991-06-18', '9822749277', 'Karel Ivashechkin', '2022-07-27', 'Ressources humaines', 'Gestionnaire RH', 22.01, TRUE),
(439204, 330152, 'Ferdinande', 'Byles', 'fbyles9@goo.gl', '6825 Corben Street', '7th Floor', 'Chonghe', NULL, '9853481572', '2000-09-18', '2003423397', 'Ferdinande Byles', '2018-03-31', 'Entrepôt', 'Préparateur de commandes', 16.89, TRUE);


# employee_credentials
INSERT INTO employee_credentials (Id, Mdp, Role) VALUES
(330152, 'Amalee123', 'Gestionnaire'),
(431999, 'Hadlee123', 'Employé'),
(432401, 'Nona123', 'Employé'),
(433753, 'Lila123', 'Employé'),
(434212, 'Adrian123', 'Employé'),
(435377, 'Esteban123', 'Employé'),
(436222, 'Darrel123', 'Employé'),
(437745, 'Valina123', 'Employé'),
(438412, 'Karel123', 'Ressources humaines'),
(439204, 'Ferdinande123', 'Employé');

# type_quart
INSERT INTO type_quart (Id, Nom, Code, EstConge, TauxMajoration, Description) VALUES
(1, 'Quart de jour', 'JOUR', 0, 1.0, 'Quart régulier de jour'),
(2, 'Quart de soir', 'SOIR', 0, 1.15, 'Quart effectué en soirée avec une légère majoration'),
(3, 'Quart de nuit', 'NUIT', 0, 1.25, 'Quart de nuit avec majoration'),
(4, 'Quart de fin de semaine', 'FDS', 0, 1.5, 'Quart effectué durant le week-end'),
(5, 'Congé payé', 'CONGE_P', 1, 1.0, 'Congé rémunéré selon la convention'),
(6, 'Congé non payé', 'CONGE_NP', 1, 0.0, 'Congé sans rémunération'),
(7, 'Férié travaillé', 'FERIE_T', 0, 2.0, 'Jour férié travaillé avec double rémunération'),
(8, 'Férié non travaillé', 'FERIE_NT', 1, 1.0, 'Jour férié non travaillé mais payé'),
(9, 'Maladie', 'MALADIE', 1, 0.8, 'Absence pour maladie, rémunérée partiellement'),
(10, 'Formation', 'FORMATION', 0, 1.0, 'Temps passé en formation rémunérée'),
(11, 'Temps supplémentaire jour', 'TS_JOUR', 0, 1.5, 'Heures supplémentaires effectuées de jour'),
(12, 'Temps supplémentaire nuit', 'TS_NUIT', 0, 2.0, 'Heures supplémentaires effectuées de nuit'),
(13, 'Congé parental', 'CONGE_PAR', 1, 0.75, 'Congé parental partiellement rémunéré'),
(14, 'Congé maternité/paternité', 'CONGE_MATPAT', 1, 1.0, 'Congé maternité ou paternité rémunéré'),
(15, 'Absence injustifiée', 'ABS_INJ', 1, 0.0, 'Absence non autorisée, non rémunérée'),
(16, 'Congé sabbatique', 'CONGE_SAB', 1, 0.0, 'Congé prolongé non rémunéré pour projets personnels'),
(17, 'Congé de deuil', 'CONGE_DEUIL', 1, 1.0, 'Congé payé pour décès d’un proche'),
(18, 'Congé sans solde', 'CONGE_SS', 1, 0.0, 'Congé autorisé mais sans rémunération'),
(19, 'Congé pour raisons personnelles', 'CONGE_PERSO', 1, 0.75, 'Congé pour événements personnels, partiellement rémunéré');


# cedule_quart
INSERT INTO cedule_quart (Id, IdEmployee, IdCreateur, TypeQuart, HeureDebut, HeureFin, HeureEntree, HeureDepart, IsPausePayee) VALUES
(1, 432401, 330152, 1, '2025-05-01 07:00:00', '2025-05-01 15:00:00', '2025-05-01 07:05:00', '2025-05-01 15:00:00', 1),
(2, 432401, 330152, 1, '2025-05-02 07:00:00', '2025-05-02 15:00:00', '2025-05-02 07:00:00', '2025-05-02 14:55:00', 1),
(3, 437745, 330152, 2, '2025-05-01 15:00:00', '2025-05-01 23:00:00', '2025-05-01 15:10:00', '2025-05-01 23:00:00', 1),
(4, 437745, 330152, 2, '2025-05-02 15:00:00', '2025-05-02 23:00:00', NULL, NULL, 1),
(5, 434212, 330152, 1, '2025-05-01 07:00:00', '2025-05-01 15:00:00', '2025-05-01 07:00:00', '2025-05-01 14:45:00', 1),
(6, 434212, 330152, 5, '2025-05-02 07:00:00', '2025-05-02 15:00:00', NULL, NULL, 0),
(7, 435377, 330152, 6, '2025-05-01 07:00:00', '2025-05-01 15:00:00', NULL, NULL, 0),
(8, 435377, 330152, 1, '2025-05-02 07:00:00', '2025-05-02 15:00:00', '2025-05-02 07:03:00', '2025-05-02 15:00:00', 1),
(9, 436222, 330152, 1, '2025-05-01 07:00:00', '2025-05-01 15:00:00', '2025-05-01 07:00:00', '2025-05-01 15:00:00', 1),
(10, 436222, 330152, 9, '2025-05-02 07:00:00', '2025-05-02 15:00:00', NULL, NULL, 0),
(11, 437745, 330152, 1, '2025-05-03 07:00:00', '2025-05-03 15:00:00', '2025-05-03 07:00:00', '2025-05-03 14:50:00', 1),
(12, 437745, 330152, 1, '2025-05-04 07:00:00', '2025-05-04 15:00:00', NULL, NULL, 1),
(13, 438412, 330152, 2, '2025-05-01 15:00:00', '2025-05-01 23:00:00', '2025-05-01 15:00:00', '2025-05-01 23:00:00', 1),
(14, 438412, 330152, 2, '2025-05-02 15:00:00', '2025-05-02 23:00:00', '2025-05-02 15:05:00', '2025-05-02 23:00:00', 1),
(15, 439204, 330152, 1, '2025-05-03 07:00:00', '2025-05-03 15:00:00', '2025-05-03 07:00:00', '2025-05-03 15:00:00', 1),
(16, 439204, 330152, 5, '2025-05-04 07:00:00', '2025-05-04 15:00:00', NULL, NULL, 0),
(17, 432401, 330152, 2, '2025-05-03 15:00:00', '2025-05-03 23:00:00', '2025-05-03 15:00:00', '2025-05-03 23:00:00', 1),
(18, 432401, 330152, 1, '2025-05-04 07:00:00', '2025-05-04 15:00:00', '2025-05-04 07:00:00', '2025-05-04 15:00:00', 1),
(19, 434212, 330152, 6, '2025-05-03 07:00:00', '2025-05-03 15:00:00', NULL, NULL, 0),
(20, 434212, 330152, 9, '2025-05-04 07:00:00', '2025-05-04 15:00:00', NULL, NULL, 0);


# demande_conge
INSERT INTO demande_conge (Id, IdEmetteur, IdDestinataire, TempsSoumission, DateDebut, DateFin, TypeQuart, Commentaire, Reponse, EstApprouve, TempsModif) VALUES
(1, 432401, 330152, '2025-05-01 08:00:00', '2025-06-01', '2025-06-05', 5, 'Demande de congé pour vacances', NULL, NULL, NULL),
(2, 437745, 330152, '2025-05-02 09:00:00', '2025-06-10', '2025-06-15', 6, 'Raisons personnelles', NULL, NULL, NULL),
(3, 434212, 330152, '2025-05-03 10:00:00', '2025-07-01', '2025-07-05', 5, 'Banque de vacances a passer', NULL, NULL, NULL),
(4, 439204, 330152, '2025-05-04 11:00:00', '2025-06-15', '2025-06-20', 5, 'Demande de congé pour un événement, banque de vacances', NULL, NULL, NULL),
(5, 435377, 330152, '2025-05-05 12:00:00', '2025-06-05', '2025-06-10', 19, 'Demande de congé pour raison personnelle', NULL, NULL, NULL);


# messagerie
INSERT INTO messagerie (Id, IdEmetteur, IdDestinataire, TypeMessage, Contenu, Temps) VALUES
(1, 432401, 330152, 'demande_conge', 'Vous avez reçu une demande de congé', '2025-05-01'),
(2, 330152, 432401, 'approbation_conge', 'Votre demande de congé à été approuvée', '2025-05-02'),
(3, 330152, 432401, 'paie', 'Vous avez reçu une nouvelle fiche de paie', '2025-05-01');


# fiche_paie
INSERT INTO fiche_paie (Id, IdEmployee, DateDebut, DateFin, Montant, NbrHeure, VacanceCumul, DatePaie) VALUES
(1, 432401, '2025-04-01', '2025-04-15', 1500.00, 75.0, 10.0, '2025-04-16'),
(2, 432401, '2025-04-16', '2025-04-30', 1520.00, 76.0, 11.0, '2025-05-01'),
(3, 437745, '2025-04-01', '2025-04-15', 1400.00, 70.0, 8.0, '2025-04-16'),
(4, 437745, '2025-04-16', '2025-04-30', 1450.00, 72.0, 9.0, '2025-05-01'),
(5, 434212, '2025-04-01', '2025-04-15', 1600.00, 80.0, 12.0, '2025-04-16'),
(6, 435377, '2025-04-01', '2025-04-15', 1700.00, 85.0, 14.0, '2025-04-16'),
(7, 435377, '2025-04-16', '2025-04-30', 1750.00, 87.0, 15.0, '2025-05-01'),
(8, 438412, '2025-04-01', '2025-04-15', 1600.00, 80.0, 13.0, '2025-04-16'),
(9, 438412, '2025-04-16', '2025-04-30', 1620.00, 81.0, 13.5, '2025-05-01'),
(10, 439204, '2025-04-01', '2025-04-15', 1550.00, 78.0, 12.0, '2025-04-16');