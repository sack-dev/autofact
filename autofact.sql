-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 12 mai 2022 à 10:29
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
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

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
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

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

COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
