CREATE DATABASE  IF NOT EXISTS `jpcsreg` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `jpcsreg`;
-- MySQL dump 10.13  Distrib 5.6.24, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: jpcsreg
-- ------------------------------------------------------
-- Server version	5.6.26

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
-- Table structure for table `courseyearsectionlist`
--

DROP TABLE IF EXISTS `courseyearsectionlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `courseyearsectionlist` (
  `coyesec` varchar(20) NOT NULL,
  PRIMARY KEY (`coyesec`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courseyearsectionlist`
--

LOCK TABLES `courseyearsectionlist` WRITE;
/*!40000 ALTER TABLE `courseyearsectionlist` DISABLE KEYS */;
INSERT INTO `courseyearsectionlist` VALUES ('BSCPE-1A'),('BSCPE-2A'),('BSCPE-3A'),('BSCPE-4A'),('BSCPE-5A'),('BSCS-1A'),('BSCS-2A'),('BSCS-3A'),('BSCS-4A'),('BSIT-1A'),('BSIT-2A'),('BSIT-3A'),('BSIT-4A');
/*!40000 ALTER TABLE `courseyearsectionlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `existingevents`
--

DROP TABLE IF EXISTS `existingevents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `existingevents` (
  `eventname` varchar(255) NOT NULL,
  `date` text,
  `time` text,
  `location` text,
  `eventtable` varchar(255) NOT NULL,
  `status` text,
  PRIMARY KEY (`eventname`,`eventtable`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `existingevents`
--

LOCK TABLES `existingevents` WRITE;
/*!40000 ALTER TABLE `existingevents` DISABLE KEYS */;
INSERT INTO `existingevents` VALUES ('1st IT Workshop 2016','August 22, 2016','1:00PM-5:00PM','ISC 402, ISC 403','participants1stitworkshop2016','I'),('2nd IT Workshop 2016','August 17, 2016','1:00PM-5:00PM','ISC 402, 403','studentlist2ndITWorkshop2016','I'),('CLAP 1','August 24, 2016','5:00PM-7:00PM','ISC 503','participantsclap1','A'),('General Assembly 2016','July 21, 2016','2:00PM-5:00PM','LA Auditorium','studentlistgeneralassembly2016','I');
/*!40000 ALTER TABLE `existingevents` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `participants1stitworkshop2016`
--

DROP TABLE IF EXISTS `participants1stitworkshop2016`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `participants1stitworkshop2016` (
  `fname` text,
  `mname` text,
  `lname` text,
  `coyesec` text,
  `studnum` text,
  `timein` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `participants1stitworkshop2016`
--

LOCK TABLES `participants1stitworkshop2016` WRITE;
/*!40000 ALTER TABLE `participants1stitworkshop2016` DISABLE KEYS */;
INSERT INTO `participants1stitworkshop2016` VALUES ('CHRISTIAN','PARAISO','FLORENDO','BSIT-3A','14-01895','12:50:04'),('JEMSON ERIS','F','CANON','BSIT-3A','13-02098','12:50:34'),('JULIUS DAVE','OBAR','ALCA','BSIT-3A','14-03176','12:51:04'),('RYAN DAVID','DICDICAN','SAMONTE','BSIT-3A','15-03022','12:51:39'),('MATTHEW','SALVADOR','LIM','BSIT-3A','14-00807','13:00:14'),('IZABELLE','GARCIA','MORENO','BSIT-3A','14-00122','13:15:09'),('ROBE MARLUI','DE LEON','BASA','BSIT-3A','14-01122','13:07:40'),('MAHEALANI JOY','GALANG','REMOS','BSIT-3A','14-00978','13:15:33'),('JESICA DIANE','GALICIA','DE LEON','BSIT-3A','14-02278','13:08:11'),('ALYSSA JENNEL','CALAMIONG','VERGARA','BSIT-3A','14-01556','13:15:53'),('DONITA ROSE','MONSANTO','DELA PAZ','BSIT-3A','14-01496','13:16:25'),('LESLEY','NAVALES','LAWAS','BSIT-3A','14-01754','13:08:46'),('JOHN RITCHIE','MEDESEO','DAVID','BSIT-3A','13-02188','13:16:55'),('JOMARI','RIVERA','VIENTE','BSIT-3A','14-00554','13:09:18'),('FELI BLANCA','DOMINNO','RONQUILLO','BSIT-3A','14-02316','13:17:33'),('GENELYNE','NATIVIDAD','CORPUZ','BSIT-3A','14-03109','13:10:04'),('VALERIE JOY','MANALANG','EULALIA','BSIT-3A','14-00504','13:18:08'),('JOSHUA ALLENKYLE','REYES','DAVID','BSIT-3A','13-01913','13:18:34'),('ROMEL','GARCIA','VIERNES','BSIT-3A','14-02907','13:10:58'),('KRISTEL MAE','GOMEZ','SANTIAGO','BSIT-3A','14-03395','13:18:59'),('ROSE JAZZREL','AGUILA','MARQUEZ','BSIT-3A','14-01139','13:11:22'),('LESTER IAN','VALENCIA','YACAT','BSIT-3A','08-04558','13:19:25'),('JUSTINE EARL','DIACAMUS','FERNANDEZ','BSCPE-3A','13-02885','13:43:31'),('JANICA','VALLEJO','SAGUN','BSCPE-5A','12-01150','13:47:42'),('JANN KENNETH','S','CRUZ','BSIT-3A','14-01610','13:57:32'),('KURT VINCENT ANDREI','ERMINO','ACUNA','BSIT-2A','13-02838','13:58:17'),('ALLIXON KRISTOFFER','EVANGELISTA','FRANCISCO','BSIT-3A','14-01285','13:58:41'),('PATRICK BRIAN','TAN','CAN','BSCS-4A','11-01878','14:40:55'),('LOIS BUNNY','RUBANTE','BERJA','BSCS-4A','13-02123','14:41:33'),('JAMES RYAN','DAVID','CUNANAN','BSCS-4A','14-03385','14:41:53'),('DEO VICENT','NICANDRO','DE GUZMAN','BSCS-4A','10-03446','14:43:15'),('RENARD','SALEN','BUGASH','BSCS-4A','13-02136','14:43:41'),('ANGEL JOY','LAPUZ','SUMBILLO','BSIT-3A','14-00516','16:34:34'),('RAEMOND ALDRIN','LABRADOR','AMILLAR','BSIT-3A','14-02873','16:35:05'),('JOSE MARI ','CORONEL','COBAR','BSCPE-3A','14-01840','17:08:13'),('ALEXZANDRA','MAYANDOC','YBANEZ','BSCPE-3A','14-01967','17:09:05'),('OLIVER','SIMBULAN','CARANTO','BSCPE-3A','15-02888','17:09:31'),('EUJOHN','CASTRO','MAGNO','BSCPE-3A','14-00522','17:10:01'),('MARK STEPHEN','MORALES','MONTENEGRO','BSCPE-3A','14-00699','17:10:35'),('ROMNICK','BALANGON','SACLOLO','BSCPE-3A','14-01274','17:11:02'),('PETER PAUL','DELOS REYES','LAVADO','BSIT-3A','14-03492','17:29:31'),('JONATHAN','SALUDARIO','GACILO','BSIT-3A','14-01212','17:29:56'),('MATJOSEPH','SALES`','FLORES','BSIT-3A','14-00073','17:30:16'),('MARION-NEL','TION','DAYAO','BSIT-3A','12-03997','17:31:18'),('LUCIO MIGUEL','TUMALIUAN','BINAG','BSIT-3A','14-03580','17:32:49');
/*!40000 ALTER TABLE `participants1stitworkshop2016` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `participantsclap1`
--

DROP TABLE IF EXISTS `participantsclap1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `participantsclap1` (
  `fname` text,
  `mname` text,
  `lname` text,
  `coyesec` text,
  `studnum` text,
  `timein` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `participantsclap1`
--

LOCK TABLES `participantsclap1` WRITE;
/*!40000 ALTER TABLE `participantsclap1` DISABLE KEYS */;
INSERT INTO `participantsclap1` VALUES ('JEMSON ERIS ','FORMOSO','CANON','BSIT-3A','13-02098','17:25:25'),('JOMARI','RIVERA','VIENTE','BSIT-3A','14-00554','17:25:40'),('GENELYNE','NATIVIDAD','CORPUZ','BSIT-3A','14-03109','17:26:45'),('VALERIE JOY','MANALANG','EULALIA','BSIT-3A','14-00504','17:27:12'),('FELI BLANCA','DOMINNO','RONQUILLO','BSIT-3A','14-02316','17:27:39'),('ROSE JAZZREL','AGUILA','MARQUEZ','BSIT-3A','14-01139','17:28:32'),('KRISTEL MAE','GOMEZ','SANTIAGO','BSIT-3A','14-03395','17:28:52'),('ROBE MARLUI ','DE LEON','BASA','BSIT-3A','14-01122','17:29:18'),('VICTORIA','U','GANAPIN','BSIT-3A','14-01959','17:32:44'),('IZABELLE','GARCIA','MORENO','BSIT-3A','14-00122','17:54:05'),('LESTER IAN','VALENCIA','YACAT','BSIT-3A','08-04558','18:00:53'),('ALYSSA JENNEL','CALAMIONG','VERGARA','BSIT-3A','14-01556','18:01:10');
/*!40000 ALTER TABLE `participantsclap1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `referencetableregistration`
--

DROP TABLE IF EXISTS `referencetableregistration`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `referencetableregistration` (
  `fname` text,
  `mname` text,
  `lname` text,
  `coyesec` text,
  `studnum` text,
  `timein` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `referencetableregistration`
--

LOCK TABLES `referencetableregistration` WRITE;
/*!40000 ALTER TABLE `referencetableregistration` DISABLE KEYS */;
/*!40000 ALTER TABLE `referencetableregistration` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registered`
--

DROP TABLE IF EXISTS `registered`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `registered` (
  `fname` varchar(50) DEFAULT NULL,
  `mname` varchar(45) DEFAULT NULL,
  `lname` varchar(45) DEFAULT NULL,
  `id` text,
  `course` varchar(45) DEFAULT NULL,
  `year` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registered`
--

LOCK TABLES `registered` WRITE;
/*!40000 ALTER TABLE `registered` DISABLE KEYS */;
/*!40000 ALTER TABLE `registered` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studentlist2nditworkshop2016`
--

DROP TABLE IF EXISTS `studentlist2nditworkshop2016`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `studentlist2nditworkshop2016` (
  `fname` text,
  `mname` text,
  `lname` text,
  `coyesec` text,
  `studnum` text,
  `timein` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentlist2nditworkshop2016`
--

LOCK TABLES `studentlist2nditworkshop2016` WRITE;
/*!40000 ALTER TABLE `studentlist2nditworkshop2016` DISABLE KEYS */;
INSERT INTO `studentlist2nditworkshop2016` VALUES ('PATRICK JENKIN','CHAN GO','WU','BSIT-4A','13-00299','12:40:00'),('RALPH KHRISTOPHER DAVE ','CABAEL','CO','BSIT-2A','15-02923','12:46:01'),('JOHSUA','DE VERA','LIM','BSIT-2A','15-00352','12:38:31'),('EARL JAMES','RUIZ','SANTOS','BSCPE-2A','15-00397','12:39:25'),('LAWRENCE','SAMONTE','CACHILA','BSCPE-2A','15-03148','12:40:15'),('JAY-PEE','MACARAEG','PRESENTACION','BSIT-2A','14-09290','12:48:20'),('MARC RHANDALL','LOTO','PANUCULAN','BSCPE-2A','15-00288','12:40:52'),('FRANCIS DWIGHT','SARABIA','CABRAL','BSCS-2A','15-02346','12:49:01'),('JAN MELVIN','GUILLERMO','MANALO','BSCS-2A','14-03795','12:41:39'),('PEACHY ANNE','TIGLAO','FELICIANO','BSCS-2A','15-02727','12:49:36'),('JEZREEL','SUAREZ','SAN JUAN','BSCS-2A','15-03321','12:42:15'),('ADRIANNE','VILLAREAL','ROMERO','BSIT-2A','15-01827','12:50:01'),('JOHN PATRICK','PARAISO','RABAJA','BSIT-2A','15-01784','12:50:39'),('MARK DANIEL','MONTAOS','AN','BSIT-2A','15-00491','12:43:21'),('JOSH ANGELO','SANDIG','LABTO','BSIT-2A','15-00778','12:51:09'),('JHYNE','MIRA','JAPSON','BSIT-2A','15-02067','12:44:00'),(' GLENFORD LUIGI ACE','CORPUZ','GALICANO','BSIT-2A','15-00472','12:51:44'),('RICO ANGELO MIGUEL','BARNUEVO','SANTIAGO','BSIT-2A','15-02061','12:52:24'),('VICTOR SETH ANGELO','TAGLE','QUIMSING','BSIT-2A','15-02021','12:44:57'),('RUEL JOSHUA','MARCELO','SAPUNGAN','BSIT-2A','15-01028','12:52:55'),('HAZEL FAITH','MERCED','MILLAMA','BSIT-2A','15-00849','12:45:29'),('LESTER JOHN','PONCE','GUMOGDA','BSIT-2A','16-00158','12:53:18'),('JANE ANDREA','VERZOSA','OSIT','BSIT-2A','15-02367','12:53:46'),('ARNETH JOY','SANTOS','DELA PAZ','BSIT-2A','15-01738','12:46:21'),('JOELAND','MARANAN','QUIOD','BSIT-2A','15-00369','12:54:07'),('PHILIP BRIAN','GREGORIO','STA. ANA','BSIT-2A','15-01818','12:46:55'),('JOSEF EMERSON','BANCOD','ABARTOSA','BSIT-2A','15-00317','12:54:36'),('EMERSON ','ORTALEZA','CELI','BSIT-2A','15-02900','12:47:59'),('LESTER','DEL MUNDO','LONDN','BSCS-3A','06-04984','12:58:44'),('LIL SAMUELLE','DE JESUS','MARCELO','BSCPE-2A','15-03246','12:51:48'),('DENNESSE IVER','HERNANDEZ','ASINAS','BSIT-3A','09-01698','12:55:56'),('CHARLES BRENT','BAUTISTA','BUGARING','BSIT-2A','16-00139','13:15:22'),('KENNETH','CORDEZ','HILAIRON','BSIT-2A','14-00167','13:19:39'),('JILLIANE MAE','OBLENIDA','BERNABE','BSIT-2A','15-02040','13:20:32'),('DEBORAH MARCELLA','OFERIANO','FERNANDO','BSIT-2A','15-00412','13:13:07'),('JOSEPHENE ANNETTE','CATEDRILLA','GUIFAYA','BSIT-2A','15-03378','13:21:08'),('JANINE','AMABILES','DE LUNA','BSIT-2A','16-00190','13:13:46'),('RADEL JON','TUNGOL','BALAJADIA','BSCPE-4A','13-04761','13:16:16'),('ANGELO','CUTINES','ADVINCULA','BSCPE-4A','13-02104','13:16:45'),('LUISITO','R.','BALAJADIA','BSCS-2A','15-00665','13:18:06'),('HANS','ALZATE','MARTINEZ','BSCPE-4A','13-03997','13:20:11'),('MOHAMED','O','BASHIR','BSCPE-4A','12-04495','13:28:01'),('JOSHUA LLOYD','CRUZ','SANGCAP','BSCPE-4A','13-03931','13:20:33'),('JE-REMY','MABUTAS','MELGAR','BSCPE-4A','13-02119','13:28:26'),('ZAKARYA','A.A','ALSALAHI','BSCPE-4A','13-03969','13:21:16'),('REMUS KRISTOFFER','BRUCA','VELASCO','BSCPE-4A','13-03996','13:29:02'),('JEAN BENEDCIT','CONTRERAS','GAELA','BSCPE-4A','13-00279','13:41:32'),('ARWIN','VALENCIA','CUTINES','BSCPE-4A','13-02110','13:41:49'),('ALVIEN JAE','M.','CAYABYAB','BSCPE-4A','12-03088','13:45:00'),('ALLEN JOSHUA','RECINTO','ANOT','BSCPE-4A','13-04753','14:06:50');
/*!40000 ALTER TABLE `studentlist2nditworkshop2016` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studentlistgeneralassembly2016`
--

DROP TABLE IF EXISTS `studentlistgeneralassembly2016`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `studentlistgeneralassembly2016` (
  `fname` text,
  `mname` text,
  `lname` text,
  `coyesec` text,
  `studnum` text,
  `timein` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentlistgeneralassembly2016`
--

LOCK TABLES `studentlistgeneralassembly2016` WRITE;
/*!40000 ALTER TABLE `studentlistgeneralassembly2016` DISABLE KEYS */;
INSERT INTO `studentlistgeneralassembly2016` VALUES ('Victoria Kate','U','Ganapin','BSIT-3A','14-01959','12:32:19'),('Patrick Jenkin','Chan Go','Wu','BSIT-4A','13-00299','12:33:12'),('Kail Andrew','Rivera','Hamili','BSIT-4A','13-02815','12:34:11'),('Adrianne','Villareal','Romero','BSIT-2A','15-01827','12:36:51'),('Izabelle','Garcia','Moreno','BSIT-3A','14-00122','12:53:01'),('Christian Angelo','Reyes','Umali','BSIT-4A','13-02321','12:52:14'),('Janica','Vallejo','Sagun','BSCPE-5A','12-01150','12:53:43'),('Philip Brian','Gregorio','Sta. Ana','BSIT-2A','15-01818','13:09:39'),('Anmari Claire','Deiparine ','Mendoza','BSIT-2A','15-03274','13:10:43'),('Hans Christian','Alzate','Martinez','BSCPE-4A','13-03997','13:14:35'),('John Christian','Menor','Bolivar','BSCPE-4A','13-02833','13:15:54'),('Christine Mae','Guiang','Raquidan','BSIT-4A','13-00256','13:17:00'),('Kent Lee','Armada','Subigca','BSIT-4A','13-02186','13:17:35'),('Eriselle Dainielle Joice','Pangilinan','Co','BSIT-2A','15-01653','13:18:45'),('KLEIMAR','BELTRAN','PEREZ','BSIT-4A','12-02883','13:18:51'),('PATRICIA MAE','A','CRUZ','BSIT-4A','13-02851','13:20:39'),('JOHN KENNETH','G.','PADILLA','BSIT-4A','12-03994','13:21:09'),('lucio miguel','t','binag','BSIT-3A','14-03580','13:22:16'),('Alyssa Jennel','Calamiong','Vergara','BSIT-3A','14-01556','13:24:20'),('justine','silo','aban','BSCPE-5A','12-00077','13:30:23'),('john joshua','ancheta','olaer','BSCPE-5A','12-00231','13:31:43'),('arsenio','ebana','aguilon','BSCPE-5A','12-03725','13:30:54'),('jake marlvin','valencia','tan','BSCPE-5A','12-02226','13:32:12'),('amschel andrei','aguirre','bentor','BSCPE-5A','12-03729','13:31:16'),('Heidel Ann','Dollentas','Tarog','BSIT-4A','13-02191','13:33:25'),('elton john','manalo','ano','BSCPE-5A','15-03172','13:34:29'),('Justinn','Malabunga','Monton','BSIT-4A','13-03937','13:33:54'),('Rico Angelo Miguel','Barnuevo','Santiago','BSIT-2A','15-02061','13:34:44'),('Deborah Marcella','Oferiano','Fernando','BSIT-2A','15-00422','13:36:03'),('Earl Jansen','Lim','Tan','BSIT-2A','15-02044','13:35:13'),('John Patrick','Paraiso','Rabaja','BSIT-2A','15-01784','13:35:41'),('Wai Yin','D.C.','Sham','BSCPE-5A','12-02900','13:36:39'),('Jilliane Mae','Oblenida','Bernabe','BSIT-2A','15-02040','13:36:24'),('Johsua','De Vera','Lim','BSIT-2A','15-00352','13:37:28'),('Josephene Annette','Catedrilla','Guifaya','BSIT-2A','15-03378','13:37:05'),('Mark Daniel','Montaos','An','BSIT-2A','15-00491','13:38:09'),('Junius Reginald','Tan','Tan','BSIT-4A','13-00262','13:39:28'),('Sean Freidey','Dela Cruz','Domingo','BSIT-2A','15-00671','13:41:53'),('joeland','maranan','quiod','BSIT-2A','15-00369','13:42:54'),('Lester John','Ponce','Gumogda','BSIT-2A','16-00158','13:42:40'),('Josef Emerson','Bancod','Abartosa','BSIT-2A','15-00317','13:43:50'),('Jerico','Villanueva','Penamante','BSIT-2A','15-01246','13:43:57'),('Ruel Joshua','Marcelo','Sapungan','BSIT-2A','15-01028','13:45:07'),('Emerson','Ortaleza','Celi','BSIT-2A','15-02900','13:44:20'),('Jane Andrea','Verzosa','Osit','BSIT-2A','15-02367','13:46:33'),('Arneth Joy','Santos','Dela Paz','BSIT-2A','15-01738','13:47:01'),('Hazel Faith','Merced','Millama','BSIT-2A','15-00849','13:48:06'),('Victor Seth Angelo','Tagle','Quimsing','BSIT-2A','15-02021','13:47:47'),('Karl','Credo','Zulueta','BSIT-2A','15-01363','13:48:57'),('Jan Melvin','Guillermo','Manalo','BSCS-2A','14-03795','13:50:31'),('jezreel','suarez','San Juan','BSCS-2A','15-03321','13:51:22'),('Marc Rhandall','Loto','Panuculan','BSCS-2A','15-00288','13:52:09'),('Francis Dwight','Sarabia','Cabral','BSCS-2A','15-02346','13:53:23'),('Mark Christian Anthony','Singui','Minlay','BSIT-4A','13-02892','13:53:11'),('Audrey Mae','Lambojon','Baluyot','BSIT-4A','13-00261','13:53:49'),('Josh','Sandig','Labto','BSIT-4A','15-00778','13:56:14'),('Tyrone','Nambio','Monteagudo','BSIT-4A','15-01590','13:56:45'),('kenneth','cordez','hilairon','BSIT-2A','14-00167','13:58:21'),('Jessie II','Combalicer','Cacanando','BSIT-4A','13-02182','13:57:43'),('miguel','hizon','tecson','BSIT-4A','12-03068','13:58:14'),('Glenford Luigi Ace','Corpuz','Galicano','BSIT-2A','15-00472','13:59:26'),('dennesse iver','hernandez','asinas','BSIT-3A','09-01698','13:59:13'),('Ma. Jasmin Chrizelle','Caballero','Jao','BSIT-2A','15-03031','14:01:09'),('Elaine','Valencia','Fernandez','BSCPE-5A','12-03063','14:00:23'),('Jhyne ','Mira','Japson','BSIT-2A','15-02067','14:01:43'),('JALO SHEEN','DALA','OLEA','BSCPE-5A','12-01148','14:01:05'),(' BIEN MIGUEL','REYES','BUAZON','BSCPE-5A','12-03053','14:01:49'),('JUSTINE EARL','DIACAMUS','FERNANDEZ','BSCPE-3A','13-02885','14:02:26'),('Angel Joy','Lapuz','Sumbillo','BSIT-3A','14-00516','14:03:47'),('LESLEY','NAVALES','LAWAS','BSIT-3A','14-01754','14:04:07'),('Jesica','Galicia','De Leon','BSIT-3A','14-02278','14:05:15'),('DONITA ROSE','MONSANTO','DELA PAZ','BSIT-3A','14-01496','14:04:38'),('ROSE JAZZREL','AGUILA','MARQUEZ','BSIT-3A','14-01139','14:05:04'),('KRISTEL MAE','GOMEZ','SANTIAGO','BSIT-3A','14-03395','14:06:12'),('VALERIE','MANALANG','EULALIA','BSIT-3A','14-00504','14:05:36'),('GENELYNE','NATIVIDAD','CORPUZ','BSIT-3A','14-03109','14:06:14'),('RAFFAEL MIKKO','MANALO','GARCIA','BSIT-2A','14-03546','14:06:56'),('RENZ JOHN','G','MITRA','BSIT-3A','12-04016','14:08:19'),('MARK JEROME','REYES','NAVARRO','BSIT-2A','16-00195','14:07:46'),('CHRISTIAN NOEL','PARAISO','FLORENDO','BSIT-3A','14-01895','14:08:58'),('MATTHEW','SALVADOR','LIM','BSIT-3A','14-00807','14:08:15'),('JOSHUA ALLENKYLE','REYES','DAVID','BSIT-3A','13-01913','14:09:32'),('LALAINE','SISON','BILLONES','BSCS-4A','97-01240','14:08:46'),('CARLO MIGUEL','V','LING','BSIT-3A','14-01171','14:09:56'),('JANINE','AMABILES','DE LUNA','BSCS-4A','16-00019','14:09:48'),('MARION','TION','DAYAO','BSIT-3A','12-03997','14:10:46'),('LAWRENCE','SAMONTE','CACHILA','BSIT-2A','15-03148','14:10:56'),('Josh Martin','Tanael','Mejia','BSIT-4A','13-03922','14:12:19'),('Lois Bunny','Rubante','Berja','BSCS-4A','13-02123','14:12:55'),('Rean Heart Chrisitian','cada','Cua','BSIT-4A','12-00991','14:13:36'),('Jean Benedict','C','Gaela','BSCPE-4A','13-00279','14:13:27'),('jaira','valentin','constantino','BSCPE-2A','15-01596','14:14:40'),('winnie joyce','padilla','ong','BSCPE-2A','15-01048','14:14:05'),('Arwin','Valencia','Cutines','BSCPE-4A','13-02110','14:14:42'),('Lil Samuelle ','de jesus ','Marcelo','BSCPE-2A','15-03246','14:15:45'),('Angelo Allan Noel','Cutines','Advincula','BSCPE-4A','13-02104','14:15:11'),('Christian Raniel','Valdoria','Paez','BSCPE-2A','16-00157','14:16:25'),('Mark Gabrielle','Zabal','Dungca','BSCPE-4A','13-02888','14:15:28'),('Michael Alfred ','Centeno','Encienzo','BSCPE-4A','13-02850','14:15:52'),('jazteen dave','Belano','Cometa','BSCPE-2A','15-03245','14:17:14'),('Robe Marlui','D.','Basa','BSIT-3A','14-01122','14:16:32'),('Earl James','Ruiz','Santos','BSCPE-2A','15-00397','14:17:39'),('Jann Kenneth','S.','Cruz','BSIT-3A','14-01610','14:16:55'),('John Ritchie','M','David','BSIT-3A','13-02188','14:17:19'),('Knight','S','Caranto','BSCPE-3A','15-02888','14:18:18'),('kurt vincent andrei','ermino','acuna','BSIT-3A','13-02838','14:17:58'),('Jemson Eris','Formoso','Canon','BSIT-3A','13-02098','14:18:25'),('Allixon Kristoffer','Evangelista','Francisco','BSIT-3A','14-01285','14:19:35'),('Ernesto','Roldan','Andrade Jr.','BSIT-3A','14-02578','14:19:10'),('lester ian','valencia','yacat','BSIT-3A','08-04558','14:19:32'),('Fatma Jasrin','Rasul','Saipoden','BSCS-3A','14-03072','14:21:03'),('Nigel Angelo','Sanchez','Edra','BSCS-3A','14-01617','14:20:21'),('Jiven Vladimir','Lagman','Andrabado','BSCS-3A','14-03211','14:21:45'),('Jeremy Shir','Cabrera','Arpon','BSCS-3A','14-03458','14:20:52'),('Matjoseph','Sales','Flores','BSIT-3A','14-00073','14:21:27'),('Gian','Uno','Dela Rosa','BSIT-3A','14-02840','14:21:44'),('Lance Patrick','Dimapilis','Bendo','BSIT-4A','15-02996','14:23:53'),('kevin','b','calimlim','BSCPE-5A','10-00893','14:24:34'),('jovito','b','vinagrera III','BSIT-2A','14-03856','14:26:43'),('john spencer','t','san pedro','BSIT-4A','13-02828','14:27:51'),('Christian Paul','Moya','Glorioso','BSIT-4A','13-03960','14:26:54'),('reiden','dela cruz','cabanela','BSIT-4A','13-03925','14:28:19'),('Dennis Christian','Sabelo','Bunao','BSIT-4A','13-00278','14:27:25'),('Twinkle','Tepora','Estabillo','BSIT-4A','13-02108','14:27:48'),('kristian peter','tan','timpug','BSIT-4A','13-02180','14:28:54'),('Ramon','A','Banes','BSIT-4A','13-03974','14:29:12'),('Remus Kristoffer','Bruca','Velasco','BSCPE-4A','13-03995','14:28:52'),('Radel','Tungol','Balajadia','BSCPE-4A','13-04761','14:30:06'),('Jethro John','Riego','Bautista','BSCPE-5A','12-02858','14:29:34'),('Joshua','Cruz','Sangcap','BSCPE-4A','13-03931','14:30:56'),('Je-remy','Mabutas','Melgar','BSCPE-4A','13-02119','14:29:59'),('jomari','rivera','viente','BSIT-3A','14-00554','14:30:27'),('allen joshua','recinto','anot','BSCPE-4A','13-04753','14:31:30'),('John Ray','Pondang','Mendez','BSIT-2A','15-02702','14:34:44'),('charles andrei','tumang','sakhrani','BSIT-2A','15-01321','14:35:43'),('Irvin Paul','Castro','Medrano','BSCPE-2A','15-02434','14:35:29'),('Hanna Krishna','Obaniana','Espejon','BSIT-4A','13-03981','14:36:53'),('John Ryan Cristopher ','Notarte','Hulog','BSIT-4A','13-02160','14:36:01'),('Karl Theodore','Paterno','Gonzales','BSIT-4A','10-01954','14:38:01'),('Lyle Emmanuel Ross','Magbanua','Ogbac','BSCS-3A','14-03457','14:38:34'),('sean','brunio','santiago','BSIT-2A','15-02991','14:39:07'),('Luisito','Reyes','Balajadia','BSCS-2A','15-00665','14:40:25'),('ralph khristopher dave','cabael','co','BSIT-2A','15-02923','14:41:50'),('bryan joe','uriarte','gonzales','BSIT-2A','15-03275','14:42:14'),('Jan Macneil','Tolentino','Masangya','BSIT-2A','15-01793','14:43:38'),('Shan Austin','Silos','Lenon','BSIT-2A','15-00646','14:42:55'),('Jean Andrew','Edos','Aurellano','BSIT-2A','15-02597','14:44:26'),('John Wendell','Geronimo','Martin','BSIT-2A','15-02661','14:45:54'),('Daniello Kelly','Nalong','Madrona','BSIT-2A','15-02329','14:45:03'),('Abdul Hafez','Angantap','Dida-agun','BSIT-2A','15-02421','14:45:44'),('Fonciano Wackin','Santos','Salazar','BSIT-2A','15-02878','14:46:47'),('mohamed ','o','bashir','BSCPE-4A','12-04495','14:46:29'),('Prince Wilson','Rentillo','Co','BSIT-4A','13-02193','14:47:31'),('zakarya','abdulhadi ali','alsalahi','BSCPE-4A','13-03969','14:47:12'),('Peachy','Tiglao','Feliciano','BSCS-2A','15-02727','14:52:55'),('Angelo','Asuncion','Baloso','BSCS-4A','12-01170','14:56:22'),('james ryan','david','cunanan','BSCS-4A','14-03385','14:57:33'),('Mark Stephen','Morales','Montenegro','BSCPE-3A','14-00699','14:58:01');
/*!40000 ALTER TABLE `studentlistgeneralassembly2016` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-08-24 23:01:40
