CREATE DATABASE  IF NOT EXISTS `dbforwebservicetesting` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `dbforwebservicetesting`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: dbforwebservicetesting
-- ------------------------------------------------------
-- Server version	5.7.10-log

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
-- Table structure for table `__migrationhistory`
--

DROP TABLE IF EXISTS `__migrationhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__migrationhistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ContextKey` varchar(300) NOT NULL,
  `Model` longblob NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`,`ContextKey`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__migrationhistory`
--

LOCK TABLES `__migrationhistory` WRITE;
/*!40000 ALTER TABLE `__migrationhistory` DISABLE KEYS */;
INSERT INTO `__migrationhistory` VALUES ('201601060902140_AutomaticMigration','SoapServices.DAL.Migrations.Configuration','ã\0\0\0\0\0\0\Ì[\€n\„6}/\–ÙXd≠$ãE\€¿\ﬁE\Í$E\–\‹\'ãæ-hâvàPîJQAå¢_÷á~R°C\›Lâ\‘5∂ì.˚\‚rf8<\rg∏ˇ˛˝\œ¯”≥O≠\'\Ã#∞â}0⁄∑-\Ã\‹¿#l9±c±x˜ì˝\È\„˜ﬂçO=ˇ\Ÿ˙úè{/\«¡LM\Ï!\¬#«â\‹\Ï£h\‰óQ∞#7\‰\Œ\·˛˛\œ\Œ¡ÅÉ\¬,\À\Z\ﬂ\∆L\'¿ü”Äπ81¢óÅáiîµC\œ,AµÆêè£πxb\œ\Œ0\".éF\'\«£S/vë\0µ=gë \"ñ\ÿ\÷1%‘õa∫∞-\ƒX íQG˜û	∞\Â,ÑD\ÔV!ÜqD#ú-\Íh=º\Î˙ˆ\Â˙úı\ƒ ç#¯=\ﬁgs™\”ô\›.\n&=”ãï\\ub÷â}\ÏyGëmUeM)ó\„:}îA\ÌY\’	{wÄbÚﬂû5ç©à9û0é\Ëûu\œ)q√´ª\‡≥	ã)U’°Ø\‘\0M7<1´[º»ñs\ÓŸñSû\ÁT\'”î9\ÈJœôxh[W \Õ).x°Xe&é\≈s$∞wÉÑ¿úIúXVì^ë\‰\√X\\Ür°\–\ÁÕ∂.\—ÛfKÒ0±\·ßmùëg\Ï\Â-ô\"˜å¿ÒÑIÇ«∏ª¨√≠Àö&k\ﬂ˙Ç¿\Ê\€_J\0˛âoz5cg}Ù\Z$∏CÅ\\q\Œ˜≥SˇÚ≥©£~;¶\r≤n8Ò_eVªä˝9\Ê\rÑ8¯–âö\¬-t\«n¿ºjlÜˇß>\"tmlÉú\√\€Y\Ô#lºôÇG|\ƒ\ﬁ9€Å®3àZ\ÊA∏qQ=\‹I\Ã%\÷&\\àDzU∑ë™0\ƒy¨g\Ó Ö§\Â\Ô›ü§T∂t†kÙZ‘õâX\⁄j\‹À†æ}≥\ZdµP≠\ÎV˜§\⁄∞Ø#<èjZ≠\‹ì]\\z\√\\°\'≤Lˆ\Œh[∑ò&˝\—	\”\€hN\Â/≈ò3¯∑]òº\Î\Àé±+\Õ\Zò˚\Ô_b\—]-%lT≠4NWO\ÈÆUQcR≥ŒâGQ\‡íD±≤)\ÏU^\Î)Û¨„•úT\÷\ÃABp\n†¡\ƒ˛A≥`=jæµ\ÿ\»2\ÍÅ]u)\◊\ÏS,∞uÏ¶πÄ)ä\\\‰\Èº\€x\ÂBòK7Ä(X6øFò\–]a.	m÷Ω2≠£Øìj™=\'8\ƒL\ jﬁã.íï≥®+P»©ÿ´\Õ<cG\·U7∫©g†ç\∆±⁄ôéëÇl∫+æU\Zñ≤C&\Z∂®ãt\Â≥6¶.1ëI \n\»\Ôc∆ê\ËdûÑwœ¶\Íbø4¬ä≤kïgR\ŒãÚô\√\‡\√\÷^π\Í\›4Æñ1t*ö\–LÑmñ±¨,Ω⁄¥\0d0!\'≥°ÏèÜ≥˛p+£jæ\ÌU ¥≠\n\ÂUΩ5\Íµüew´\'ºº\Œ6(Eıv®u¢ù\›\ËP{òßÇedkg\Î\‰¡KqR\◊%\'≠Y\‰µ\rß¶∏1æDaA≤R\Ï\»Z¨YZÈòæõı\œˆ˚)Ü\„FÜ§°m!	\Óhâ+Ω\“8>#<\'H†9íGl\Í˘⁄∞6øTs*s\ÈU◊£\Ôi~XÛÚwF\√~	É´\œ0\œ¿\0æ¸Z$w/˝\–\Ë3ì≤¢ànz”Ä\∆>´ˇn\’\œ.ïTòR\«º\√:º\√>xiz_ö\Zn§\Õ\Z%π˚≤.IS-Ú\Ã|IëºQ\«;ïm\÷>\·\Z…¥®\Ã\⁄Nú69óm∞\€1\ÌOÙ. \€\·º9«Æ\‚ôGÙ\‡\\MΩD¬ö1›•˘r∂h\Ï°mû˛.©ó7v\«Q\”\€*î\⁄\ﬁM\Õ`´hj˚:yi¨∏ù”ñDõCNòybÉó\ÀR\’7gL}∑#•©9+mÔã∂N*\Îà\Îæ7√à\"h\‹%Ú\ÎCN\‘\Œ‹é´\’)\–wÛKiﬁ≤P:˙ê©∏XóyT{ﬂÆ\«RRF*VC&i\Àt\‘\Ó\’!ÖÙ\‚ûPπå≥ÿº˝Eî¨ßClåÙD<®_Æf–ë\Ï%?ßî$ó\ﬁ|\ƒ%bdÅ#ëñG\Ï£+\Ôß\ﬁ\Œ[&\'ä<\⁄\ÌA\”\Œ+<D⁄¥µÜ”∑&Æø¢[¶âü5\÷¿\Á@C°\‘\◊>\√\’QÛV§¸Vß\ÃKû\‚|¨jz\ﬁ¬ûw\◊∏lÙı\ \–\rØ<N1*õ\’_ˆˆd®z˙”í°H˙Àëçì[Kw˝\nc+\‰\÷^lå%\Êw\ﬁcl¯øu5\Í>ò5Ùë¡`,\Ì\Õ\01>Q9g~û\ÿ&≥é¨Ûﬂãî≤∑g]sõé¨}ÎØóø5\Ë*æò\ÿC¸\Ê´\ÏEÒc\«p-\√?¨\¬:®ÇYüE\ﬁVπÚ´´îõ\Í~ØW\«~M2uJ⁄æ*Ø\ﬁB\Õ[/A\’d{™Æ\Í\Î\◊\ÈΩxb{Û\0∂;uô√ã\€k\€&°•\⁄iß\‚wC\Ì\€,†O]º©,nBΩöyeìKu∫5aS1˘≠ñ\ƒ\Î	WW¥ŸæzTΩı\Ïx\Â˝Åä\»r\r!ˇ \√n\…7c\‰*s/U\—(Râ±.±@8éc.\»\Ï\›.ê$yî˙\—8πG\Œ\Â=\Ì:a,`\…ÿü\”R\rQ∫∫&˘Iiø¨Û¯:Lä}õX®I`	¯ö˝\ÍzüÇº\Z\ÈC≥@^Ó•ê˝rU ]¨#Pfæ\¬ı\ﬂa?§\0]≥z\¬Ctªè^\"wï\Á \ÎA\⁄7¢lˆÒ	AKé¸(\√Xœá?Å√ûˇ¸Ò?zûì\Ï¸:\0\0','6.1.3-40302');
/*!40000 ALTER TABLE `__migrationhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `address`
--

DROP TABLE IF EXISTS `address`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `address` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `StreetLine1` longtext,
  `StreetLine2` longtext,
  `City` longtext,
  `State` longtext,
  `Country` longtext,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `address`
--

LOCK TABLES `address` WRITE;
/*!40000 ALTER TABLE `address` DISABLE KEYS */;
INSERT INTO `address` VALUES (1,'Near Abhiruchi tiffins','SR Nagar','Hyderabad','Telangana','India'),(2,'Near Sai Convention Center',NULL,'Vijayawada','Andhra Pradesh','India');
/*!40000 ALTER TABLE `address` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contactinfo`
--

DROP TABLE IF EXISTS `contactinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contactinfo` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `PrimaryContactNumber` varchar(15) NOT NULL,
  `SecondaryContactNumber` longtext,
  `EmailId` varchar(255) NOT NULL,
  `SkypeId` longtext,
  `LinkedInId` longtext,
  `FacebookId` longtext,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contactinfo`
--

LOCK TABLES `contactinfo` WRITE;
/*!40000 ALTER TABLE `contactinfo` DISABLE KEYS */;
INSERT INTO `contactinfo` VALUES (1,'999999999',NULL,'soaptest1@mytrails.in',NULL,NULL,NULL),(2,'8888888888',NULL,'soaptest2@mytrails.in',NULL,NULL,NULL);
/*!40000 ALTER TABLE `contactinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `course`
--

DROP TABLE IF EXISTS `course`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `course` (
  `CourseId` int(11) NOT NULL AUTO_INCREMENT,
  `CourseName` varchar(255) NOT NULL,
  `CourseContents` longtext,
  PRIMARY KEY (`CourseId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `course`
--

LOCK TABLES `course` WRITE;
/*!40000 ALTER TABLE `course` DISABLE KEYS */;
/*!40000 ALTER TABLE `course` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `student` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` longtext NOT NULL,
  `FathersName` longtext NOT NULL,
  `ContactId` int(11) NOT NULL,
  `AddressId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ContactId` (`ContactId`) USING HASH,
  KEY `IX_AddressId` (`AddressId`) USING HASH,
  CONSTRAINT `FK_Student_Address_AddressId` FOREIGN KEY (`AddressId`) REFERENCES `address` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_Student_ContactInfo_ContactId` FOREIGN KEY (`ContactId`) REFERENCES `contactinfo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-01-06 14:35:36
