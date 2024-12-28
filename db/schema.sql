-- MySQL dump 10.13  Distrib 8.0.40, for Linux (x86_64)
--
-- Host: localhost    Database: datadb
-- ------------------------------------------------------
-- Server version	8.0.40-0ubuntu0.24.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `table_standarts`
--

DROP TABLE IF EXISTS `table_standarts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `table_standarts` (
  `id` int NOT NULL AUTO_INCREMENT,
  `category` int DEFAULT NULL,
  `age_group` int DEFAULT NULL,
  `score` int DEFAULT NULL,
  `rating_5` varchar(50) DEFAULT NULL,
  `rating_4` varchar(50) DEFAULT NULL,
  `rating_3` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `category_check` CHECK (((`category` > 0) and (`category` <= 3)))
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `table_standarts`
--

LOCK TABLES `table_standarts` WRITE;
/*!40000 ALTER TABLE `table_standarts` DISABLE KEYS */;
INSERT INTO `table_standarts` VALUES (1,1,25,85,'295/390','275/360','255/340'),(2,2,25,80,'280/370','260/340','240/320'),(3,3,25,80,'280/370','260/340','240/320'),(4,1,30,85,'295/390','275/360','255/340'),(5,2,30,75,'265/350','245/320','225/300'),(6,3,30,75,'265/350','245/320','225/300'),(7,1,35,80,'280/370','260/340','240/320'),(8,2,35,70,'250/330','230/300','210/280'),(9,3,35,70,'250/330','230/300','210/280'),(10,1,40,80,'280/370','260/340','240/320'),(11,2,40,65,'235/310','215/280','195/260'),(12,3,40,60,'220/290','200/260','180/240'),(13,1,45,65,'235/310','215/280','195/260'),(14,2,45,55,'205/270','185/240','165/220'),(15,3,45,45,'175/230','155/200','135/180'),(16,1,50,55,'205','185','165'),(17,2,50,45,'175','155','135'),(18,3,50,35,'145','125','105'),(19,1,55,45,'175','155','135'),(20,2,55,35,'145','125','105'),(21,3,55,25,'115','95','75'),(22,1,60,35,'145','125','105'),(23,2,60,25,'115','105','75'),(24,3,60,15,'85','65','45'),(25,1,70,25,'115','95','75'),(26,2,70,15,'85','65','45'),(27,3,70,5,'55','35','15');
/*!40000 ALTER TABLE `table_standarts` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-27 18:50:26
