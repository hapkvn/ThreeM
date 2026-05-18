-- MySQL dump 10.13  Distrib 8.0.44, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: musicmanagerdb
-- ------------------------------------------------------
-- Server version	8.0.44

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `albumsongs`
--

DROP TABLE IF EXISTS `albumsongs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `albumsongs` (
  `AlbumID` varchar(50) NOT NULL,
  `SongID` varchar(50) NOT NULL,
  PRIMARY KEY (`AlbumID`,`SongID`),
  KEY `SongID` (`SongID`),
  CONSTRAINT `albumsongs_ibfk_1` FOREIGN KEY (`AlbumID`) REFERENCES `useralbums` (`AlbumID`) ON DELETE CASCADE,
  CONSTRAINT `albumsongs_ibfk_2` FOREIGN KEY (`SongID`) REFERENCES `songs` (`SongID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `albumsongs`
--

LOCK TABLES `albumsongs` WRITE;
/*!40000 ALTER TABLE `albumsongs` DISABLE KEYS */;
INSERT INTO `albumsongs` VALUES ('ALB_4335','MS_01'),('ALB_01','MS_04');
/*!40000 ALTER TABLE `albumsongs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `CategoryID` varchar(10) NOT NULL,
  `CategoryName` varchar(100) NOT NULL,
  PRIMARY KEY (`CategoryID`),
  UNIQUE KEY `CategoryName` (`CategoryName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES ('CT_03','EDM'),('CT_04','Lofi'),('CT_01','Pop'),('CT_05','R&B'),('CT_02','Rock');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `playhistory`
--

DROP TABLE IF EXISTS `playhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `playhistory` (
  `HistoryID` varchar(10) NOT NULL,
  `UserID` varchar(10) DEFAULT NULL,
  `SongID` varchar(10) DEFAULT NULL,
  `PlayedAt` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`HistoryID`),
  KEY `UserID` (`UserID`),
  KEY `SongID` (`SongID`),
  CONSTRAINT `playhistory_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`),
  CONSTRAINT `playhistory_ibfk_2` FOREIGN KEY (`SongID`) REFERENCES `songs` (`SongID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `playhistory`
--

LOCK TABLES `playhistory` WRITE;
/*!40000 ALTER TABLE `playhistory` DISABLE KEYS */;
INSERT INTO `playhistory` VALUES ('HS_01','US_01','MS_01','2026-05-12 17:58:12'),('HS_02','US_02','MS_02','2026-05-12 17:58:12'),('HS_03','US_01','MS_03','2026-05-12 17:58:12'),('HS_04','US_03','MS_01','2026-05-12 17:58:12'),('HS_05','US_05','MS_05','2026-05-12 17:58:12');
/*!40000 ALTER TABLE `playhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `songs`
--

DROP TABLE IF EXISTS `songs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `songs` (
  `SongID` varchar(10) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Artist` varchar(255) DEFAULT NULL,
  `Album` varchar(255) DEFAULT NULL,
  `FilePath` varchar(500) NOT NULL,
  `CategoryID` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`SongID`),
  KEY `CategoryID` (`CategoryID`),
  CONSTRAINT `songs_ibfk_1` FOREIGN KEY (`CategoryID`) REFERENCES `categories` (`CategoryID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `songs`
--

LOCK TABLES `songs` WRITE;
/*!40000 ALTER TABLE `songs` DISABLE KEYS */;
INSERT INTO `songs` VALUES ('MS_01','Seven','Jung Kook','Golden','D:/Netcuoiki/src/Music/seven.mp3','CT_01'),('MS_02','Numb','Linkin Park','Meteora','D:/Netcuoiki/src/Music/numb.mp3','CT_02'),('MS_03','Stay','The Kid LAROI','F*ck Love','D:/Netcuoiki/src/Music/stay.mp3','CT_03'),('MS_04','Muộn Rồi Mà Sao Còn','Sơn Tùng M-TP','Single','D:/Netcuoiki/src/Music/muonroi.mp3','CT_01'),('MS_05','Double Take','Dhruv','Rapis','D:/Netcuoiki/src/Music/doubletake.mp3','CT_04');
/*!40000 ALTER TABLE `songs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `useralbums`
--

DROP TABLE IF EXISTS `useralbums`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `useralbums` (
  `AlbumID` varchar(50) NOT NULL,
  `AlbumName` varchar(255) NOT NULL,
  `UserID` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`AlbumID`),
  KEY `UserID` (`UserID`),
  CONSTRAINT `useralbums_ibfk_1` FOREIGN KEY (`UserID`) REFERENCES `users` (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `useralbums`
--

LOCK TABLES `useralbums` WRITE;
/*!40000 ALTER TABLE `useralbums` DISABLE KEYS */;
INSERT INTO `useralbums` VALUES ('ALB_01','My Favorite Songs','US_01'),('ALB_4108','Local Song','US_01'),('ALB_4335','local song','US_01');
/*!40000 ALTER TABLE `useralbums` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `UserID` varchar(10) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Role` varchar(10) NOT NULL,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `Username` (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('US_01','admin','123','Admin'),('US_02','user01','123','User'),('US_03','user02','123','User'),('US_04','manager','123','Admin'),('US_05','guest','123','User');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'musicmanagerdb'
--

--
-- Dumping routines for database 'musicmanagerdb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-05-17 14:37:42
