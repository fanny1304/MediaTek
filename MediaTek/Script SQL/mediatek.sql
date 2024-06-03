-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 27 mai 2024 à 11:52
-- Version du serveur : 8.2.0
-- Version de PHP : 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek`
--
CREATE DATABASE IF NOT EXISTS `mediatek` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
DROP USER 'mediatek'@'%';
FLUSH PRIVILEGES;
CREATE USER 'mediatek'@'%' IDENTIFIED BY 'motdepasseuser';
GRANT USAGE ON *.* TO 'mediatek'@'%';
GRANT ALL PRIVILEGES ON `mediatek`.* TO 'mediatek'@'%';
USE `mediatek`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(4, '2024-03-15 02:05:41', '2025-04-10 07:44:54', 1),
(10, '2024-02-13 13:15:43', '2024-10-01 16:45:19', 2),
(4, '2023-09-15 19:02:59', '2024-07-29 16:14:39', 2),
(10, '2024-01-15 02:02:18', '2024-02-22 03:30:24', 4),
(9, '2023-07-22 02:58:36', '2023-10-21 07:58:57', 3),
(8, '2024-02-01 11:06:58', '2024-04-15 14:19:26', 2),
(2, '2023-06-05 04:36:01', '2024-05-06 00:12:20', 2),
(9, '2023-10-02 03:08:59', '2024-03-13 03:56:15', 1),
(8, '2023-05-06 01:07:59', '2023-06-18 20:23:40', 2),
(5, '2023-01-03 10:47:03', '2023-10-08 14:17:44', 4),
(7, '2023-10-06 08:35:51', '2024-06-14 01:57:34', 2),
(7, '2024-07-11 06:10:00', '2024-08-03 15:41:47', 3),
(3, '2023-09-26 10:58:22', '2024-08-20 06:48:03', 1),
(1, '2023-11-04 00:52:35', '2024-05-10 18:39:47', 4),
(7, '2023-07-30 02:07:46', '2023-10-04 14:58:47', 3),
(7, '2023-02-26 20:36:14', '2023-05-25 21:12:27', 3),
(4, '2024-01-06 05:20:13', '2024-09-30 19:15:28', 4),
(9, '2023-06-14 14:09:08', '2024-05-23 17:57:33', 2),
(9, '2023-05-12 04:36:50', '2023-10-10 23:49:54', 3),
(9, '2023-12-05 02:09:28', '2024-03-24 01:06:20', 2),
(5, '2023-04-14 19:20:05', '2023-10-31 23:54:47', 4),
(5, '2023-06-18 13:08:41', '2024-08-06 02:59:01', 4),
(7, '2023-07-31 13:04:17', '2023-09-26 18:49:33', 2),
(9, '2024-05-20 17:54:07', '2024-12-01 20:48:05', 4),
(3, '2024-06-30 00:44:54', '2024-11-19 16:25:15', 4),
(10, '2023-08-07 05:51:17', '2025-03-12 22:49:58', 3),
(7, '2023-04-10 17:47:32', '2023-06-21 04:09:56', 1),
(3, '2024-04-20 12:28:02', '2024-12-24 03:10:29', 1),
(10, '2023-08-19 15:42:26', '2024-11-14 20:28:16', 3),
(8, '2023-08-13 21:19:53', '2024-01-18 19:15:05', 4),
(7, '2024-11-28 03:09:40', '2024-10-07 13:09:20', 2),
(2, '2024-02-16 19:08:50', '2024-12-16 07:01:42', 2),
(8, '2023-10-11 06:32:35', '2024-04-06 07:12:11', 1),
(4, '2023-10-26 11:26:10', '2024-03-19 12:42:41', 4),
(10, '2023-07-09 14:16:40', '2025-04-26 18:37:28', 2),
(6, '2024-08-01 07:57:32', '2025-02-06 05:45:27', 2),
(6, '2023-11-11 19:36:52', '2024-05-07 03:34:00', 3),
(2, '2024-08-09 16:37:20', '2025-04-22 08:55:18', 1),
(4, '2023-09-08 09:07:22', '2024-12-22 23:10:38', 1),
(10, '2023-01-06 00:07:38', '2024-04-22 09:29:46', 4),
(10, '2023-09-29 02:52:05', '2023-11-09 02:03:38', 1),
(8, '2024-05-22 23:33:39', '2024-07-20 02:46:15', 4),
(7, '2024-10-25 05:58:31', '2025-01-06 07:50:04', 3),
(3, '2023-03-16 11:09:06', '2023-09-26 03:40:48', 4),
(7, '2023-09-18 15:26:20', '2024-08-09 02:01:59', 3),
(9, '2023-08-24 17:52:19', '2025-01-17 02:34:04', 4),
(1, '2023-06-08 02:26:17', '2023-09-21 19:35:53', 1),
(3, '2023-01-09 04:02:45', '2023-08-09 15:57:31', 2),
(8, '2023-09-24 10:08:20', '2024-09-03 01:14:41', 3),
(9, '2024-05-21 15:55:34', '2024-06-12 15:55:34', 2),
(3, '2024-05-21 15:57:47', '2024-05-24 15:57:46', 3),
(3, '2024-05-21 15:57:50', '2024-05-23 15:57:50', 4),
(1, '2024-05-21 15:58:27', '2024-05-26 15:58:26', 3);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Blair', 'Rowan', '03 52 73 62 80', 'enim.non@protonmail.com', 2),
(2, 'Ramirez', 'Gannon', '01 15 78 62 57', 'nullam@outlook.ca', 1),
(3, 'Morrison', 'Victor', '06 13 82 76 36', 'felis.orci@yahoo.com', 2),
(4, 'Workman', 'Callum', '07 05 26 85 62', 'aenean@google.ca', 3),
(5, 'Atkins', 'Dalton', '09 29 09 40 67', 'integer.eu.lacus@google.couk', 3),
(6, 'Kane', 'Cruz', '06 85 38 41 46', 'nisi.magna@hotmail.edu', 1),
(7, 'Barrera', 'Tatyana', '08 47 12 81 69', 'morbi@hotmail.couk', 2),
(8, 'Barry', 'Sean', '03 31 63 85 37', 'tincidunt@yahoo.net', 2),
(9, 'Raymond', 'Kerry', '05 78 54 34 68', 'adipiscing@icloud.couk', 1),
(10, 'Leblanc', 'Haley', '04 56 18 12 82', 'a.tortor@hotmail.org', 3);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('esn86', 'a1159e9df3670d549d04524532629f5477ceb7deec9b45e47e8c009506ecb2c8');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
