#
# DUMP FILE
#
# Database is ported from MS Access
#------------------------------------------------------------------
# Created using "MS Access to MySQL" form http://www.bullzip.com
# Program Version 5.5.282
#
# OPTIONS:
#   sourcefilename=C:/Users/vedra/Desktop/baza.accdb
#   sourceusername=
#   sourcepassword=
#   sourcesystemdatabase=
#   destinationdatabase=db
#   storageengine=InnoDB
#   dropdatabase=0
#   createtables=1
#   unicode=1
#   autocommit=1
#   transferdefaultvalues=1
#   transferindexes=1
#   transferautonumbers=1
#   transferrecords=1
#   columnlist=1
#   tableprefix=
#   negativeboolean=0
#   ignorelargeblobs=0
#   memotype=LONGTEXT
#   datetimetype=DATETIME
#

CREATE DATABASE IF NOT EXISTS `db`;
USE `db`;

#
# Table structure for table 'KorisnickiPodaci'
#

DROP TABLE IF EXISTS `KorisnickiPodaci`;

CREATE TABLE `KorisnickiPodaci` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  `Ime` VARCHAR(255), 
  `Prezime` VARCHAR(255), 
  `Lozinka` LONGTEXT, 
  `Aktivan` TINYINT(1) DEFAULT 0, 
  `Adresa` LONGTEXT, 
  `Email` LONGTEXT, 
  PRIMARY KEY (`ID`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'KorisnickiPodaci'
#

INSERT INTO `KorisnickiPodaci` (`ID`, `Ime`, `Prezime`, `Lozinka`, `Aktivan`, `Adresa`, `Email`) VALUES (1, 'id', NULL, NULL, 0, NULL, NULL);
# 1 records

#
# Table structure for table 'Nastava'
#

DROP TABLE IF EXISTS `Nastava`;

CREATE TABLE `Nastava` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  `NastavnikID` INTEGER DEFAULT 0, 
  `PredmetID` INTEGER DEFAULT 0, 
  INDEX (`PredmetID`), 
  PRIMARY KEY (`ID`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Nastava'
#

# 0 records

#
# Table structure for table 'Nastavnik'
#

DROP TABLE IF EXISTS `Nastavnik`;

CREATE TABLE `Nastavnik` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  `BrojPredmeta` INTEGER DEFAULT 0, 
  PRIMARY KEY (`ID`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Nastavnik'
#

INSERT INTO `Nastavnik` (`ID`, `BrojPredmeta`) VALUES (1, NULL);
# 1 records

#
# Table structure for table 'Pedagog'
#

DROP TABLE IF EXISTS `Pedagog`;

CREATE TABLE `Pedagog` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  PRIMARY KEY (`ID`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Pedagog'
#

INSERT INTO `Pedagog` (`ID`) VALUES (1);
# 1 records

#
# Table structure for table 'Predmet'
#

DROP TABLE IF EXISTS `Predmet`;

CREATE TABLE `Predmet` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  `Naziv` VARCHAR(255), 
  `BrojSati` INTEGER DEFAULT 0, 
  `Tip` VARCHAR(255), 
  INDEX (`BrojSati`), 
  PRIMARY KEY (`ID`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Predmet'
#

INSERT INTO `Predmet` (`ID`, `Naziv`, `BrojSati`, `Tip`) VALUES (1, 'predmet', NULL, NULL);
# 1 records

#
# Table structure for table 'Roditelj'
#

DROP TABLE IF EXISTS `Roditelj`;

CREATE TABLE `Roditelj` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  `BrojDjece` INTEGER DEFAULT 0, 
  `Spol` INTEGER DEFAULT 0, 
  PRIMARY KEY (`ID`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Roditelj'
#

INSERT INTO `Roditelj` (`ID`, `BrojDjece`, `Spol`) VALUES (1, NULL, NULL);
# 1 records

#
# Table structure for table 'Suradnja'
#

DROP TABLE IF EXISTS `Suradnja`;

CREATE TABLE `Suradnja` (
  `ID` INTEGER NOT NULL AUTO_INCREMENT, 
  `RoditeljID` INTEGER DEFAULT 0, 
  `PedagogID` INTEGER NOT NULL DEFAULT 0, 
  `DatumSuradnje` DATETIME, 
  `Bilješke` LONGTEXT, 
  UNIQUE (`ID`), 
  PRIMARY KEY (`ID`), 
  INDEX (`RoditeljID`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Suradnja'
#

INSERT INTO `Suradnja` (`ID`, `RoditeljID`, `PedagogID`, `DatumSuradnje`, `Bilješke`) VALUES (1, NULL, 1, NULL, NULL);
# 1 records

