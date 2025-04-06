# employee
INSERT INTO employee (prenom, nom, courriel, adresse_ligne1, adresse_ligne2, ville, code_postal, telephone, date_naissance, contact_urgence_tel, contact_urgence_nom, date_embauche, departement, poste, salaire, est_actif) VALUES ('Amalee', 'Lombard', 'alombard0@ning.com', '8 Linden Hill', 'Room 325', 'Yingcui', null, '2619454579', '2000-02-16', '3483298657', 'Amalee Lombard', '2021-11-10', 'Games', 'Nurse', 27.43, 1);
INSERT INTO employee (id_superieur, prenom, nom, courriel, adresse_ligne1, adresse_ligne2, ville, code_postal, telephone, date_naissance, contact_urgence_tel, contact_urgence_nom, date_embauche, departement, poste, salaire, est_actif) VALUES (1, 'Hadlee', 'Towers', 'htowers1@usa.gov', '9 Dahle Crossing', 'Suite 64', 'Idanre', null, '5991885505', '1990-05-30', '6901477338', 'Hadlee Towers', '2021-08-04', 'Movies', 'Senior Financial Analyst', 21.29, 1);
INSERT INTO employee (id_superieur, prenom, nom, courriel, adresse_ligne1, adresse_ligne2, ville, code_postal, telephone, date_naissance, contact_urgence_tel, contact_urgence_nom, date_embauche, departement, poste, salaire, est_actif) VALUES (1, 'Nona', 'Fillon', 'nfillon2@wordpress.com', '66 Spenser Circle', 'Room 1924', 'Vogan', null, '3354048261', '2003-05-05', '7365638403', 'Nona Fillon', '2015-03-20', 'Tools', 'Nurse Practicioner', 26.98, 1);
INSERT INTO employee (id_superieur, prenom, nom, courriel, adresse_ligne1, adresse_ligne2, ville, code_postal, telephone, date_naissance, contact_urgence_tel, contact_urgence_nom, date_embauche, departement, poste, salaire, est_actif) VALUES (2, 'Lila', 'Tomasoni', 'ltomasoni3@upenn.edu', '628 Norway Maple Plaza', 'Suite 70', 'Lazarat', null, '4097371461', '1986-07-17', '3523333007', 'Lila Tomasoni', '2022-05-01', 'Sports', 'Registered Nurse', 24.86, 1);
INSERT INTO employee (id_superieur, prenom, nom, courriel, adresse_ligne1, adresse_ligne2, ville, code_postal, telephone, date_naissance, contact_urgence_tel, contact_urgence_nom, date_embauche, departement, poste, salaire, est_actif) VALUES (3, 'Adrian', 'Torbeck', 'atorbeck4@icio.us', '972 Bluestem Street', 'Suite 66', 'Samho-rodongjagu', null, '4196268115', '2000-02-10', '8533600489', 'Adrian Torbeck', '2023-11-15', 'Grocery', 'Registered Nurse', 28.5, 1);
INSERT INTO employee (id_superieur, prenom, nom, courriel, adresse_ligne1, adresse_ligne2, ville, code_postal, telephone, date_naissance, contact_urgence_tel, contact_urgence_nom, date_embauche, departement, poste, salaire, est_actif) VALUES (1, 'Esteban', 'Synnot', 'esynnot5@pcworld.com', '298 Briar Crest Pass', '20th Floor', 'Yangchun', null, '5917379415', '1981-07-11', '8013733112', 'Esteban Synnot', '2023-06-21', 'Games', 'Web Developer IV', 16.39, 1);
INSERT INTO employee (id_superieur, prenom, nom, courriel, adresse_ligne1, adresse_ligne2, ville, code_postal, telephone, date_naissance, contact_urgence_tel, contact_urgence_nom, date_embauche, departement, poste, salaire, est_actif) VALUES (2, 'Darrel', 'Chardin', 'dchardin6@ask.com', '5912 Charing Cross Trail', 'Apt 1025', 'Kembang', null, '4004106016', '1991-01-01', '1131519685', 'Darrel Chardin', '2015-10-01', 'Electronics', 'Tax Accountant', 24.46, 1);
INSERT INTO employee (id_superieur, prenom, nom, courriel, adresse_ligne1, adresse_ligne2, ville, code_postal, telephone, date_naissance, contact_urgence_tel, contact_urgence_nom, date_embauche, departement, poste, salaire, est_actif) VALUES (2, 'Valina', 'Quakley', 'vquakley7@smh.com.au', '83 Paget Circle', 'Apt 968', 'Lanot', '5815', '4535978928', '2000-07-21', '9338947542', 'Valina Quakley', '2024-12-26', 'Jewelry', 'Financial Analyst', 28.58, 1);
INSERT INTO employee (id_superieur, prenom, nom, courriel, adresse_ligne1, adresse_ligne2, ville, code_postal, telephone, date_naissance, contact_urgence_tel, contact_urgence_nom, date_embauche, departement, poste, salaire, est_actif) VALUES (2, 'Karel', 'Ivashechkin', 'kivashechkin8@prnewswire.com', '6 Kim Crossing', '15th Floor', 'Villarrica', null, '3141376029', '1991-06-18', '9822749277', 'Karel Ivashechkin', '2022-07-27', 'Industrial', 'Analog Circuit Design manager', 21.5, 1);
INSERT INTO employee (id_superieur, prenom, nom, courriel, adresse_ligne1, adresse_ligne2, ville, code_postal, telephone, date_naissance, contact_urgence_tel, contact_urgence_nom, date_embauche, departement, poste, salaire, est_actif) VALUES (1, 'Ferdinande', 'Byles', 'fbyles9@goo.gl', '6825 Corben Street', '7th Floor', 'Chonghe', null, '9853481572', '2000-09-18', '2003423397', 'Ferdinande Byles', '2018-03-31', 'Garden', 'Actuary', 15.3, 1);

#employee_credentials
INSERT INTO employee_credentials (id_employee, username, mdp, `role`) VALUES (1, 'alombard0', '$2a$04$rGR1KGj7SUr9hMn4K/dwH.5dGE74rmGQ9PoDHMKbmLY0onu7kRmwu', 'Gestionnaire');
INSERT INTO employee_credentials (id_employee, username, mdp, `role`) VALUES (2, 'htowers1', '$2a$04$KlRkYVDQm.qKWMp989N7RO5aCTQ0.iECdhhMuDrm9a3w5Ju38Hghq', 'Gestionnaire');
INSERT INTO employee_credentials (id_employee, username, mdp, `role`) VALUES (3, 'nfillon2', '$2a$04$cdlmVK.M1C/X8oYhe3z5h.V2zqtCP1LTnCvSyemzz4uy2rD6Qno1a', 'Gestionnaire');
INSERT INTO employee_credentials (id_employee, username, mdp, `role`) VALUES (4, 'ltomasoni3', '$2a$04$mVXJil/RHq5quhxgPyT6ueCcEfwTxXLGMdYOqK9LgdGIcIUB0nhVi', 'Ressources humaines');
INSERT INTO employee_credentials (id_employee, username, mdp, `role`) VALUES (5, 'atorbeck4', '$2a$04$/AayZ2qjrOr7LLdNdml1s.PoVMz9cveEq.RVDIJ3EH3r7ykuiSr.6', 'Préposé.e');
INSERT INTO employee_credentials (id_employee, username, mdp, `role`) VALUES (6, 'esynnot5', '$2a$04$hLP654lGRAOpcj.LF2U6ReQEjLDH/6pW6K5vYsnxbPAbrtYBUCVNK', 'Préposé.e');
INSERT INTO employee_credentials (id_employee, username, mdp, `role`) VALUES (7, 'dchardin6', '$2a$04$vZf4YDoP1dJXfA6kiwrEYOHpLe41oTCiZOngsVO/nTHNZAqXPLV/K', 'Préposé.e');
INSERT INTO employee_credentials (id_employee, username, mdp, `role`) VALUES (8, 'vquakley7', '$2a$04$.F6KiRfQQ9S4MXFZuqgOf.CG1wBYsHHO82pwqaAPgODvdrpgfnY5u', 'Préposé.e');
INSERT INTO employee_credentials (id_employee, username, mdp, `role`) VALUES (9, 'kivashechkin8', '$2a$04$lvLAI5k6ISS3/ZiUovvncekwExXzFAiK5iQvmJbZYo132rNqzCQ4m', 'Préposé.e');
INSERT INTO employee_credentials (id_employee, username, mdp, `role`) VALUES (10, 'fbyles9', '$2a$04$PTtiSDgV/FcHts66GvPLEuGnmm7kSIiAQ41V1AxjQXHrfOuav.7Hi', 'Préposé.e');

# cedule_quart
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (1, 1, '2025-03-29 09:00:00', '2025-03-29 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (2, 1, '2025-03-29 09:00:00', '2025-03-29 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (3, 1, '2025-03-29 09:00:00', '2025-03-29 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (4, 2, '2025-03-29 09:00:00', '2025-03-29 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (5, 2, '2025-03-29 09:00:00', '2025-03-29 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (6, 1, '2025-03-29 09:00:00', '2025-03-29 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (7, 2, '2025-03-29 09:00:00', '2025-03-29 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (8, 3, '2025-03-29 09:00:00', '2025-03-29 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (9, 3, '2025-03-29 09:00:00', '2025-03-29 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (10, 3, '2025-03-29 09:00:00', '2025-03-29 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (1, 1, '2025-03-30 09:00:00', '2025-03-30 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (2, 1, '2025-03-30 09:00:00', '2025-03-30 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (3, 1, '2025-03-30 09:00:00', '2025-03-30 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (4, 2, '2025-03-30 09:00:00', '2025-03-30 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (5, 2, '2025-03-30 09:00:00', '2025-03-30 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (6, 1, '2025-03-30 09:00:00', '2025-03-30 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (7, 2, '2025-03-30 09:00:00', '2025-03-30 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (8, 3, '2025-03-30 09:00:00', '2025-03-30 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (9, 3, '2025-03-30 09:00:00', '2025-03-30 17:00:00');
INSERT INTO cedule_quart (id_employee, id_createur, heure_debut, heure_fin) VALUES (10, 3, '2025-03-30 09:00:00', '2025-03-30 17:00:00');

# cedule_pause
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (1, '2025-03-29 11:30:00', '2025-03-29 12:30:00', 1);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (1, '2025-03-29 14:30:00', '2025-03-29 15:00:00', 0);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (2, '2025-03-29 12:00:00', '2025-03-29 13:00:00', 1);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (2, '2025-03-29 15:00:00', '2025-03-29 15:00:00', 0);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (3, '2025-03-29 12:30:00', '2025-03-29 13:30:00', 1);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (3, '2025-03-29 15:30:00', '2025-03-29 16:00:00', 0);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (4, '2025-03-29 12:00:00', '2025-03-29 13:00:00', 1);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (4, '2025-03-29 15:15:00', '2025-03-29 15:45:00', 0);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (5, '2025-03-29 11:45:00', '2025-03-29 12:45:00', 1);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (5, '2025-03-29 14:45:00', '2025-03-29 15:15:00', 0);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (6, '2025-03-29 12:00:00', '2025-03-29 13:00:00', 1);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (6, '2025-03-29 15:15:00', '2025-03-29 15:45:00', 0);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (7, '2025-03-29 11:45:00', '2025-03-29 12:45:00', 1);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (7, '2025-03-29 14:45:00', '2025-03-29 15:15:00', 0);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (8, '2025-03-29 12:00:00', '2025-03-29 13:00:00', 1);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (8, '2025-03-29 15:15:00', '2025-03-29 15:45:00', 0);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (9, '2025-03-29 11:45:00', '2025-03-29 12:45:00', 1);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (9, '2025-03-29 14:45:00', '2025-03-29 15:15:00', 0);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (10, '2025-03-29 12:00:00', '2025-03-29 13:00:00', 1);
INSERT INTO cedule_pause (id_quart, heure_debut, heure_fin, est_payee) VALUES (10, '2025-03-29 15:15:00', '2025-03-29 15:45:00', 0);


# cedule_pointage
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (1, '2025-03-29 08:57:00', '2025-03-29 17:03:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (2, '2025-03-29 08:55:00', '2025-03-29 17:00:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (3, '2025-03-29 09:01:00', '2025-03-29 17:10:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (4, '2025-03-29 09:00:00', '2025-03-29 17:00:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (5, '2025-03-29 09:02:00', '2025-03-29 17:01:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (6, '2025-03-29 09:12:00', '2025-03-29 16:55:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (7, '2025-03-29 08:59:00', '2025-03-29 17:05:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (8, '2025-03-29 09:01:00', '2025-03-29 17:10:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (9, '2025-03-29 08:58:00', '2025-03-29 16:59:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (10, '2025-03-29 09:06:00', '2025-03-29 17:09:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (1, '2025-03-30 08:57:00', '2025-03-30 17:03:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (2, '2025-03-30 08:55:00', '2025-03-30 17:00:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (3, '2025-03-30 09:01:00', '2025-03-30 17:10:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (4, '2025-03-30 09:00:00', '2025-03-30 17:00:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (5, '2025-03-30 09:02:00', '2025-03-30 17:01:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (6, '2025-03-30 09:12:00', '2025-03-30 16:55:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (7, '2025-03-30 08:59:00', '2025-03-30 17:05:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (8, '2025-03-30 09:01:00', '2025-03-30 17:10:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (9, '2025-03-30 08:58:00', '2025-03-30 16:59:00');
INSERT INTO cedule_pointage (id_employee, heure_debut, heure_fin) VALUES (10, '2025-03-30 09:06:00', '2025-03-30 17:09:00');

# demande_conge
INSERT INTO demande_conge (id_emetteur, id_destinataire, temps_soumission, date_debut, date_fin, `type`, commentaire, reponse, est_approuve, temps_modif) VALUES (5, 1, '2025-03-18 21:04:30', '2025-03-19', '2025-03-19', 'Payé', 'Je ne me sens pas bien ce soir, je ne pourrai pas venir demain. Merci.', 'Bien reçu, reposez vous bien.', 1, '2025-03-18 22:33:24');
INSERT INTO demande_conge (id_emetteur, id_destinataire, temps_soumission, date_debut, date_fin, `type`, commentaire, reponse, est_approuve, temps_modif) VALUES (3, 2, '2025-03-18 20:59:56', '2025-05-18', '2025-05-20', 'Sans solde', 'Un membre de la famille d''outre-mer viendra me vister pendant ces dates.', 'Aucun problème!', 1, '2025-03-20 14:22:16');
INSERT INTO demande_conge (id_emetteur, id_destinataire, temps_soumission, date_debut, date_fin, `type`, commentaire, reponse, est_approuve, temps_modif) VALUES (9, 1, '2025-03-19 21:34:21', '2025-05-21', '2025-06-20', 'Vacances', 'J''aimerais réserver ces dates pour mes vacances.', 'Approuvé.', 1, '2025-03-20 14:22:23');
INSERT INTO demande_conge (id_emetteur, id_destinataire, temps_soumission, date_debut, date_fin, `type`, commentaire, reponse, est_approuve, temps_modif) VALUES (6, 2, '2025-03-21 23:54:45', '2025-04-30', '2025-05-30', 'Vacances', 'Voici mon choix pour mes dates de vacances. Merci.', 'Bonjour, Esteban. Je dois vérifier auprès de Mme. Lombard car quelqu''un est déjà en vacance entre le 21 et le 30 mai.', 0, '2025-03-22 19:24:01');
INSERT INTO demande_conge (id_emetteur, id_destinataire, temps_soumission, date_debut, date_fin, `type`, commentaire, reponse, est_approuve, temps_modif) VALUES (7, 3, '2025-03-26 22:23:25', '2025-03-27', '2025-03-27', 'Maladie', 'me sens pô ben...', null, 0, null);


# messagerie
INSERT INTO messagerie (id_emetteur, id_destinataire, titre, contenu, fichier, temps, est_lu) VALUES (7, 3, 'Titre', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.', null, '2025-01-26 23:56:07', 1);
INSERT INTO messagerie (id_emetteur, id_destinataire, titre, contenu, fichier, temps, est_lu) VALUES (8, 1, 'Titre', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.', null, '2025-02-01 22:56:01', 0);
INSERT INTO messagerie (id_emetteur, id_destinataire, titre, contenu, fichier, temps, est_lu) VALUES (2, 2, 'Titre', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.', null, '2025-02-09 03:12:28', 0);
INSERT INTO messagerie (id_emetteur, id_destinataire, titre, contenu, fichier, temps, est_lu) VALUES (7, 2, 'Titre', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.', null, '2025-03-09 22:41:28', 1);
INSERT INTO messagerie (id_emetteur, id_destinataire, titre, contenu, fichier, temps, est_lu) VALUES (5, 9, 'Titre', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.', null, '2025-03-06 04:43:22', 0);


# fiche_paie
INSERT INTO fiche_paie (id_employee, debut_periode, fin_periode, montant, date_paie) VALUES (1, '2025-03-09', '2025-03-22', 2141.62, '2025-03-27');
INSERT INTO fiche_paie (id_employee, debut_periode, fin_periode, montant, date_paie) VALUES (2, '2025-03-09', '2025-03-22', 2183.38, '2025-03-27');
INSERT INTO fiche_paie (id_employee, debut_periode, fin_periode, montant, date_paie) VALUES (3, '2025-03-09', '2025-03-22', 1912.82, '2025-03-27');
INSERT INTO fiche_paie (id_employee, debut_periode, fin_periode, montant, date_paie) VALUES (4, '2025-03-09', '2025-03-22', 1086.79, '2025-03-27');
INSERT INTO fiche_paie (id_employee, debut_periode, fin_periode, montant, date_paie) VALUES (5, '2025-03-09', '2025-03-22', 1740.61, '2025-03-27');
INSERT INTO fiche_paie (id_employee, debut_periode, fin_periode, montant, date_paie) VALUES (6, '2025-03-09', '2025-03-22', 1896.08, '2025-03-27');
INSERT INTO fiche_paie (id_employee, debut_periode, fin_periode, montant, date_paie) VALUES (7, '2025-03-09', '2025-03-22', 1698.76, '2025-03-27');
INSERT INTO fiche_paie (id_employee, debut_periode, fin_periode, montant, date_paie) VALUES (8, '2025-03-09', '2025-03-22', 1212.96, '2025-03-27');
INSERT INTO fiche_paie (id_employee, debut_periode, fin_periode, montant, date_paie) VALUES (9, '2025-03-09', '2025-03-22', 992.45, '2025-03-27');
INSERT INTO fiche_paie (id_employee, debut_periode, fin_periode, montant, date_paie) VALUES (10, '2025-03-09', '2025-03-22', 1653.47, '2025-03-27');