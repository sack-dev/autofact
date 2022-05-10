-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : sam. 19 mars 2022 à 18:14
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `autofact`
--

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `IDC` int(2) NOT NULL AUTO_INCREMENT,
  `NOM` varchar(32) NOT NULL,
  `MAIL` varchar(32) NOT NULL,
  `TEL` varchar(10) NOT NULL,
  `ADRESSE` varchar(255) NOT NULL,
  `VILLE` varchar(100) NOT NULL,
  `CODE_POSTAL` int(5) NOT NULL,
  PRIMARY KEY (`IDC`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`IDC`, `NOM`, `MAIL`, `TEL`, `ADRESSE`, `VILLE`, `CODE_POSTAL`) VALUES
(4, 'La corne abondante', 'tonini.abondante@wanadoo.fr', '0568250630', '67 Avenue de l\'Europe', 'Versailles', 78000),
(3, 'Gai pâturage', 'eliane.noz@pro.fr', '0353614251', 'Bat. B 3 Rue des Alpes', 'Annecy', 74000),
(2, 'Escargots Nouveaux', 'escargots@orange.fr', '0947159576', '22 Rue H. Voiron', 'Montceau', 71300),
(1, 'Aux joyeux gastronomes', 'lesgastronomes@gmail.com', '0756841542', '203 Rue des Francs-Bourgeois', 'Paris', 75004),
(5, 'La maison Asiatique', 'maisonasie@gmail.com', '0949711242', '1 Rue Alsace-Lorraine', 'Toulouse', 31000),
(6, 'Paris spécialités', 'mariebertrand@free.fr', '0452227835', '265 Boulevard Charonne', 'Paris', 75012),
(7, 'Spécialités du monde', 'specialitesdumonde@gmail.com', '0773607412', '25 Rue Lauriston', 'Paris', 75016),
(8, 'Victuailles en stock', 'victuailles@pro.fr', '0277954917', '2 Rue du Commerce', 'Lyon', 69004),
(9, 'Vins et alcools Chevalier', 'paulhenriot@orange.fr', '0560845626', '59 Rue de l\'Abbaye', 'Reims', 51100);

-- --------------------------------------------------------

--
-- Structure de la table `concerner`
--

DROP TABLE IF EXISTS `concerner`;
CREATE TABLE IF NOT EXISTS `concerner` (
  `IDD` int(2) NOT NULL,
  `IDP` int(2) NOT NULL,
  `QUANTITE` int(5) NOT NULL,
  PRIMARY KEY (`IDD`,`IDP`),
  KEY `I_FK_CONCERNER_DOCUMENT` (`IDD`),
  KEY `I_FK_CONCERNER_PRESTATION` (`IDP`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `concerner`
--

INSERT INTO `concerner` (`IDD`, `IDP`, `QUANTITE`) VALUES
(1, 3, 1),
(2, 1, 1),
(3, 1, 2),
(4, 2, 2),
(5, 1, 2),
(6, 2, 2),
(7, 2, 1),
(8, 2, 1),
(9, 3, 1),
(10, 3, 1),
(11, 3, 3),
(12, 3, 1),
(13, 3, 2),
(14, 3, 1),
(15, 1, 1),
(16, 1, 1),
(17, 1, 3),
(18, 1, 1),
(19, 1, 2),
(20, 2, 1),
(21, 2, 1),
(22, 2, 1),
(23, 2, 1),
(24, 2, 1);

-- --------------------------------------------------------

--
-- Structure de la table `devenir`
--

DROP TABLE IF EXISTS `devenir`;
CREATE TABLE IF NOT EXISTS `devenir` (
  `IDT` int(2) NOT NULL,
  `IDD` int(2) NOT NULL,
  `DATE` date NOT NULL,
  PRIMARY KEY (`IDT`,`IDD`),
  KEY `I_FK_DEVENIR_TYPE` (`IDT`),
  KEY `I_FK_DEVENIR_DOCUMENT` (`IDD`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `devenir`
--

INSERT INTO `devenir` (`IDT`, `IDD`, `DATE`) VALUES
(1, 1, '2021-01-19'),
(1, 2, '2021-02-19'),
(1, 3, '2021-03-19'),
(1, 4, '2021-04-19'),
(1, 5, '2021-05-19'),
(1, 6, '2021-06-19'),
(1, 7, '2021-07-19'),
(1, 8, '2021-08-19'),
(1, 9, '2021-09-19'),
(1, 10, '2021-10-19'),
(1, 11, '2021-11-19'),
(1, 12, '2021-12-19'),
(1, 13, '2022-01-19'),
(1, 14, '2022-02-19'),
(1, 15, '2022-03-19'),
(1, 16, '2022-04-19'),
(1, 17, '2022-05-19'),
(1, 18, '2022-06-19'),
(1, 19, '2022-07-19'),
(1, 20, '2022-08-19'),
(1, 21, '2022-09-19'),
(1, 22, '2022-10-19'),
(1, 23, '2022-11-19'),
(1, 24, '2022-12-19');

-- --------------------------------------------------------

--
-- Structure de la table `document`
--

DROP TABLE IF EXISTS `document`;
CREATE TABLE IF NOT EXISTS `document` (
  `IDD` int(2) NOT NULL AUTO_INCREMENT,
  `IDU` int(2) NOT NULL,
  `IDC` int(2) NOT NULL,
  `DESCRIPTION` varchar(255) NOT NULL,
  `PRIXTOTAL` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`IDD`),
  KEY `I_FK_DOCUMENT_UTILISATEUR` (`IDU`),
  KEY `I_FK_DOCUMENT_CLIENT` (`IDC`)
) ENGINE=MyISAM AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `document`
--

INSERT INTO `document` (`IDD`, `IDU`, `IDC`, `DESCRIPTION`, `PRIXTOTAL`) VALUES
(1, 3, 4, 'E-Commerce', '52.15'),
(2, 3, 2, 'E-Commerce', '52.15'),
(3, 3, 5, 'E-Commerce', '52.15'),
(4, 3, 7, 'E-Commerce', '52.15'),
(5, 3, 9, 'E-Commerce', '52.15'),
(6, 3, 3, 'Audit', '56.32'),
(7, 3, 1, 'Audit', '36.76'),
(8, 3, 6, 'Audit', '75.88'),
(9, 3, 8, 'Audit', '36.76'),
(10, 3, 4, 'Audit', '36.76'),
(11, 3, 4, 'Site Spécial', '67.19'),
(12, 3, 2, 'Site Spécial', '117.18'),
(13, 3, 1, 'Site Spécial', '67.19'),
(14, 3, 5, 'Site Spécial', '167.17'),
(15, 3, 7, 'Site Spécial', '67.19'),
(16, 3, 2, 'Site Escargots', '67.19'),
(17, 3, 3, 'E-Commerce', '52.15'),
(18, 3, 6, 'E-Commerce', '52.15'),
(19, 3, 8, 'E-Commerce', '87.10'),
(20, 3, 9, 'Audit', '56.32'),
(21, 3, 1, 'E-Commerce', '87.10'),
(22, 3, 6, 'Site Perso', '67.19'),
(23, 3, 5, 'Audit', '56.32'),
(24, 3, 7, 'Audit', '36.76');

-- --------------------------------------------------------

--
-- Structure de la table `prestation`
--

DROP TABLE IF EXISTS `prestation`;
CREATE TABLE IF NOT EXISTS `prestation` (
  `IDP` int(2) NOT NULL AUTO_INCREMENT,
  `NOM` varchar(255) NOT NULL,
  `TVA` varchar(10) NOT NULL,
  `PRIX` decimal(10,2) NOT NULL,
  PRIMARY KEY (`IDP`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `prestation`
--

INSERT INTO `prestation` (`IDP`, `NOM`, `TVA`, `PRIX`) VALUES
(1, 'Audit Informatique', '10', '19.56'),
(2, 'Site E-Commerce', '15', '34.95'),
(3, 'Site Personnalisé', '20', '49.99');

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

DROP TABLE IF EXISTS `type`;
CREATE TABLE IF NOT EXISTS `type` (
  `IDT` int(2) NOT NULL AUTO_INCREMENT,
  `LIBELLE` varchar(32) NOT NULL,
  PRIMARY KEY (`IDT`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `type`
--

INSERT INTO `type` (`IDT`, `LIBELLE`) VALUES
(1, 'Devis'),
(2, 'Facture');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `IDU` int(2) NOT NULL AUTO_INCREMENT,
  `NOM_UTILISATEUR` varchar(32) NOT NULL,
  `MAIL` varchar(32) NOT NULL,
  `MDP` varchar(255) NOT NULL,
  `SALT` varchar(255) NOT NULL,
  PRIMARY KEY (`IDU`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`IDU`, `NOM_UTILISATEUR`, `MAIL`, `MDP`, `SALT`) VALUES
(1, 'Adeline', 'adeline@gmail.com', '$2a$11$oKdS1Lf6qPV9TqjVKln/Juu5u3BlNOdKlcD4Bxp9EP05zvqaECFL2', '$2a$11$oKdS1Lf6qPV9TqjVKln/Ju'),
(2, 'Clément', 'clement@gmail.com', '$2a$11$DrFPAm68iJAoQp1jbf/Pl.trVkX96p7l7lcPivsFjOkAbYqGcGYbC', '$2a$11$DrFPAm68iJAoQp1jbf/Pl.'),
(3, 'a', 'a', '$2a$11$i3YcuCDOPoFM4sdr/S1H3O.I8ur7EbSfPSvFAmNkre2V9nWRSUGZG', '$2a$11$i3YcuCDOPoFM4sdr/S1H3O');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
