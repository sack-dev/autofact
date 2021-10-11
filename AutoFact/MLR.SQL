DROP DATABASE IF EXISTS AUTOFACT;

CREATE DATABASE IF NOT EXISTS AUTOFACT;
USE AUTOFACT;
# -----------------------------------------------------------------------------
#       TABLE : TYPE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE
 (
   IDT INT(2) NOT NULL AUTO_INCREMENT,
   LIBELLE VARCHAR(32) NOT NULL, 
PRIMARY KEY (IDT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : UTILISATEUR
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS UTILISATEUR
 (
   IDU INT(2) NOT NULL AUTO_INCREMENT ,
   NOM_UTILISATEUR VARCHAR (32) NOT NULL  ,
   MAIL VARCHAR (32) NOT NULL  ,
   MDP VARCHAR (255) NOT NULL , 
   SALT VARCHAR (255) NOT NULL  ,
 PRIMARY KEY (IDU) 
 )
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : CLIENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CLIENT
 (
   IDC INT(2) NOT NULL AUTO_INCREMENT,
   IDU INT(2) NOT NULL  ,
   NOM VARCHAR (32) NOT NULL  ,
   MAIL VARCHAR (32) NOT NULL  ,
   TEL VARCHAR (10) NOT NULL  ,
   ADRESSE VARCHAR (255) NOT NULL  , 
PRIMARY KEY (IDC) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE CLIENT
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_CLIENT_UTILISATEUR
     ON CLIENT (IDU ASC);

# -----------------------------------------------------------------------------
#       TABLE : PRESTATION
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PRESTATION
 (
   IDP INT(2) NOT NULL AUTO_INCREMENT ,
   PRODUIT BOOLEAN NOT NULL  ,
   SERVICE BOOLEAN NOT NULL  ,
   TVA VARCHAR (10) NOT NULL  ,
   PRIX VARCHAR (5) NOT NULL  , 
PRIMARY KEY (IDP) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : DOCUMENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DOCUMENT
 (
   IDD INT(2) NOT NULL AUTO_INCREMENT ,
   IDU INT(2) NOT NULL  ,
   IDC INT(2) NOT NULL  ,
   DESCRIPTION VARCHAR (255) NOT NULL  , 
PRIMARY KEY (IDD) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE DOCUMENT
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_DOCUMENT_UTILISATEUR
     ON DOCUMENT (IDU ASC);

CREATE  INDEX I_FK_DOCUMENT_CLIENT
     ON DOCUMENT (IDC ASC);

# -----------------------------------------------------------------------------
#       TABLE : DEVENIR
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DEVENIR
 (
   IDT INT(2) NOT NULL  ,
   IDD INT(2) NOT NULL  ,
   DATE DATE NOT NULL , 
PRIMARY KEY (IDT,IDD) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE DEVENIR
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_DEVENIR_TYPE
     ON DEVENIR (IDT ASC);

CREATE  INDEX I_FK_DEVENIR_DOCUMENT
     ON DEVENIR (IDD ASC);

# -----------------------------------------------------------------------------
#       TABLE : CONCERNER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CONCERNER
 (
   IDD INT(2) NOT NULL  ,
   IDP INT(2) NOT NULL  ,
   QUANTITÉ INT(5) NOT NULL  , 
PRIMARY KEY (IDD,IDP) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE CONCERNER
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_CONCERNER_DOCUMENT
     ON CONCERNER (IDD ASC);

CREATE  INDEX I_FK_CONCERNER_PRESTATION
     ON CONCERNER (IDP ASC);


# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE CLIENT 
  ADD FOREIGN KEY FK_CLIENT_UTILISATEUR (IDU)
      REFERENCES UTILISATEUR (IDU) ;


ALTER TABLE DOCUMENT 
  ADD FOREIGN KEY FK_DOCUMENT_UTILISATEUR (IDU)
      REFERENCES UTILISATEUR (IDU) ;


ALTER TABLE DOCUMENT 
  ADD FOREIGN KEY FK_DOCUMENT_CLIENT (IDC)
      REFERENCES CLIENT (IDC) ;


ALTER TABLE DEVENIR 
  ADD FOREIGN KEY FK_DEVENIR_TYPE (IDT)
      REFERENCES TYPE (IDT) ;


ALTER TABLE DEVENIR 
  ADD FOREIGN KEY FK_DEVENIR_DOCUMENT (IDD)
      REFERENCES DOCUMENT (IDD) ;


ALTER TABLE CONCERNER 
  ADD FOREIGN KEY FK_CONCERNER_DOCUMENT (IDD)
      REFERENCES DOCUMENT (IDD) ;


ALTER TABLE CONCERNER 
  ADD FOREIGN KEY FK_CONCERNER_PRESTATION (IDP)
      REFERENCES PRESTATION (IDP) ;
