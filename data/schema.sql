DROP DATABASE IF EXISTS chronocorp;
CREATE DATABASE chronocorp;

USE chronocorp;

DROP TABLE IF EXISTS employee;
CREATE TABLE employee(
	id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	id_superieur INT,
	prenom VARCHAR(30) NOT NULL,
	nom VARCHAR(30) NOT NULL,
	courriel VARCHAR(50),
	adresse_ligne1 VARCHAR(50),
	adresse_ligne2 VARCHAR(50),
	ville VARCHAR(30),
	code_postal VARCHAR(6),
	telephone VARCHAR(10),
	date_naissance DATE NOT NULL,
	contact_urgence_tel VARCHAR(10),
	contact_urgence_nom VARCHAR(30),
	date_embauche DATE NOT NULL,
	departement VARCHAR(30),
	poste VARCHAR(30) NOT NULL,
	salaire FLOAT NOT NULL,
	est_actif BOOL NOT NULL
);

DROP TABLE IF EXISTS employee_credentials;
CREATE TABLE employee_credentials(
	id_employee INT NOT NULL,
	username VARCHAR(20) NOT NULL,
	mdp VARCHAR(60) NOT NULL,
	`role` VARCHAR(20) NOT NULL
);

DROP TABLE IF EXISTS cedule_quart;
CREATE TABLE cedule_quart(
	id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	id_employee INT NOT NULL,
	id_createur INT NOT NULL,
	heure_debut DATETIME NOT NULL,
	heure_fin DATETIME NOT NULL
);

DROP TABLE IF EXISTS cedule_pause;
CREATE TABLE cedule_pause(
	id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	id_quart INT NOT NULL,
	heure_debut DATETIME NOT NULL,
	heure_fin DATETIME NOT NULL,
	est_payee BOOL NOT NULL
);

DROP TABLE IF EXISTS cedule_pointage;
CREATE TABLE cedule_pointage(
	id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	id_employee INT NOT NULL,
	heure_debut DATETIME NOT NULL,
	heure_fin DATETIME NOT NULL
);

DROP TABLE IF EXISTS demande_conge; 
CREATE TABLE demande_conge(
	id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	id_emetteur INT NOT NULL,
	id_destinataire INT NOT NULL,
	temps_soumission TIMESTAMP NOT NULL,
	date_debut DATE NOT NULL,
	date_fin DATE NOT NULL,
	`type` VARCHAR(30) NOT NULL,
	commentaire VARCHAR(1000) NOT NULL,
	reponse VARCHAR(1000),
	est_approuve BOOL NOT NULL,
	temps_modif TIMESTAMP
);

DROP TABLE IF EXISTS messagerie;
CREATE TABLE messagerie(
	id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	id_emetteur INT NOT NULL,
	id_destinataire INT NOT NULL,
	titre VARCHAR(30) NOT NULL,
	contenu VARCHAR(1000) NOT NULL,
	fichier BLOB,
	temps TIMESTAMP NOT NULL,
	est_lu BOOL NOT NULL 
);

DROP TABLE IF EXISTS fiche_paie;
CREATE TABLE fiche_paie(
	id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	id_employee INT NOT NULL,
	debut_periode DATE NOT NULL,
	fin_periode DATE NOT NULL,
	montant FLOAT NOT NULL,
	date_paie DATE NOT NULL
);


ALTER TABLE cedule_quart
	ADD FOREIGN KEY (id_employee) REFERENCES employee(id),
	ADD FOREIGN KEY (id_createur) REFERENCES employee(id);
	
ALTER TABLE cedule_pause
	ADD FOREIGN KEY (id_quart) REFERENCES cedule_quart(id);
	
ALTER TABLE cedule_pointage
	ADD FOREIGN KEY (id_employee) REFERENCES employee(id);

ALTER TABLE demande_conge
	ADD FOREIGN KEY (id_emetteur) REFERENCES employee(id),
	ADD FOREIGN KEY (id_destinataire) REFERENCES employee(id);
	
ALTER TABLE messagerie
	ADD FOREIGN KEY (id_emetteur) REFERENCES employee(id),
	ADD FOREIGN KEY (id_destinataire) REFERENCES employee(id);
	
ALTER TABLE fiche_paie
	ADD FOREIGN KEY (id_employee) REFERENCES employee(id);

