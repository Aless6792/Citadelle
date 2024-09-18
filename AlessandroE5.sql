-- MySQL dump 10.13  Distrib 5.1.72, for Win32 (ia32)
--
-- Host: localhost    Database: huginnmuninn
-- ------------------------------------------------------
-- Server version	5.1.72-community-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `auteur`
--

DROP TABLE IF EXISTS `auteur`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `auteur` (
  `idAuteur` int(11) NOT NULL DEFAULT '0',
  `nomAuteur` varchar(20) DEFAULT NULL,
  `prenomAuteur` varchar(20) DEFAULT NULL,
  `dateNaissance` varchar(10) DEFAULT NULL,
  `dateMort` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idAuteur`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `auteur`
--

LOCK TABLES `auteur` WRITE;
/*!40000 ALTER TABLE `auteur` DISABLE KEYS */;
INSERT INTO `auteur` VALUES (1,'Horikoshi','Kohei','01/01/1980','05/10/2023'),(3,'Pradeau-Paulin','Alessandro','28/11/2005','01/01/2099');
/*!40000 ALTER TABLE `auteur` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `definir`
--

DROP TABLE IF EXISTS `definir`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `definir` (
  `idLivre` int(11) NOT NULL DEFAULT '0',
  `idGenre` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idLivre`,`idGenre`),
  KEY `idGenre` (`idGenre`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `definir`
--

LOCK TABLES `definir` WRITE;
/*!40000 ALTER TABLE `definir` DISABLE KEYS */;
/*!40000 ALTER TABLE `definir` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `devise`
--

DROP TABLE IF EXISTS `devise`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `devise` (
  `idDevise` int(11) NOT NULL DEFAULT '0',
  `devise` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idDevise`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devise`
--

LOCK TABLES `devise` WRITE;
/*!40000 ALTER TABLE `devise` DISABLE KEYS */;
INSERT INTO `devise` VALUES (0,'Francs'),(1,'Euros'),(2,'Ancien fra');
/*!40000 ALTER TABLE `devise` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ecrire`
--

DROP TABLE IF EXISTS `ecrire`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ecrire` (
  `idLivre` int(11) NOT NULL DEFAULT '0',
  `idAuteur` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idLivre`,`idAuteur`),
  KEY `idAuteur` (`idAuteur`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ecrire`
--

LOCK TABLES `ecrire` WRITE;
/*!40000 ALTER TABLE `ecrire` DISABLE KEYS */;
/*!40000 ALTER TABLE `ecrire` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `editeur`
--

DROP TABLE IF EXISTS `editeur`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `editeur` (
  `idEditeur` int(11) NOT NULL DEFAULT '0',
  `nomEditeur` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idEditeur`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `editeur`
--

LOCK TABLES `editeur` WRITE;
/*!40000 ALTER TABLE `editeur` DISABLE KEYS */;
INSERT INTO `editeur` VALUES (0,'JJoris'),(1,'Toho');
/*!40000 ALTER TABLE `editeur` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `etat`
--

DROP TABLE IF EXISTS `etat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `etat` (
  `idEtat` int(11) NOT NULL DEFAULT '0',
  `libelle` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idEtat`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `etat`
--

LOCK TABLES `etat` WRITE;
/*!40000 ALTER TABLE `etat` DISABLE KEYS */;
INSERT INTO `etat` VALUES (0,'Excellent');
/*!40000 ALTER TABLE `etat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `genre`
--

DROP TABLE IF EXISTS `genre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `genre` (
  `idGenre` int(11) NOT NULL DEFAULT '0',
  `libelle` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idGenre`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genre`
--

LOCK TABLES `genre` WRITE;
/*!40000 ALTER TABLE `genre` DISABLE KEYS */;
INSERT INTO `genre` VALUES (0,'Romance');
/*!40000 ALTER TABLE `genre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `livre`
--

DROP TABLE IF EXISTS `livre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `livre` (
  `idLivre` int(11) NOT NULL DEFAULT '0',
  `titre` varchar(50) DEFAULT NULL,
  `isbn` varchar(20) DEFAULT NULL,
  `nombrePages` int(11) DEFAULT NULL,
  `poids` int(11) DEFAULT NULL,
  `datePremierePublication` varchar(20) DEFAULT NULL,
  `datePublication` varchar(20) DEFAULT NULL,
  `prixInitial` decimal(4,2) DEFAULT NULL,
  `dateEntreeStock` varchar(20) DEFAULT NULL,
  `dateSortieStock` varchar(20) DEFAULT NULL,
  `hauteur` decimal(3,2) DEFAULT NULL,
  `largeur` decimal(3,2) DEFAULT NULL,
  `commentaire` varchar(1000) DEFAULT NULL,
  `synopsys` varchar(1000) DEFAULT NULL,
  `idTypeLivre` int(11) NOT NULL,
  `idDevise` int(11) NOT NULL,
  `idSortie` int(11) NOT NULL,
  `idEtat` int(11) NOT NULL,
  `idEditeur` int(11) NOT NULL,
  PRIMARY KEY (`idLivre`),
  KEY `idTypeLivre` (`idTypeLivre`),
  KEY `idDevise` (`idDevise`),
  KEY `idSortie` (`idSortie`),
  KEY `idEtat` (`idEtat`),
  KEY `idEditeur` (`idEditeur`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `livre`
--

LOCK TABLES `livre` WRITE;
/*!40000 ALTER TABLE `livre` DISABLE KEYS */;
/*!40000 ALTER TABLE `livre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sortie`
--

DROP TABLE IF EXISTS `sortie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sortie` (
  `idSortie` int(11) NOT NULL DEFAULT '0',
  `raisonSortie` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idSortie`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sortie`
--

LOCK TABLES `sortie` WRITE;
/*!40000 ALTER TABLE `sortie` DISABLE KEYS */;
INSERT INTO `sortie` VALUES (0,'hvhv');
/*!40000 ALTER TABLE `sortie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `typelivre`
--

DROP TABLE IF EXISTS `typelivre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `typelivre` (
  `idTypeLivre` int(11) NOT NULL DEFAULT '0',
  `libelle` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`idTypeLivre`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `typelivre`
--

LOCK TABLES `typelivre` WRITE;
/*!40000 ALTER TABLE `typelivre` DISABLE KEYS */;
INSERT INTO `typelivre` VALUES (2,'Doc'),(1,'Livre'),(0,'coucou');
/*!40000 ALTER TABLE `typelivre` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-11 11:53:47
