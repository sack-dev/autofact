DROP DATABASE IF EXISTS MLR1;

CREATE DATABASE IF NOT EXISTS MLR1;
USE MLR1;
# -----------------------------------------------------------------------------
#       TABLE : TYPE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPE
 (
   IDT DB_INTEGER(2) NOT NULL  ,
   LIBELLE DB_TEXT, 32 NOT NULL  
   , PRIMARY KEY (IDT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : UTILISATEUR
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS UTILISATEUR
 (
   IDU DB_INTEGER(2) NOT NULL  ,
   NOM_UTILISATEUR DB_TEXT, 32 NOT NULL  ,
   MAIL DB_TEXT, 32 NOT NULL  ,
   MDP DB_TEXT, 32 NOT NULL  
   , PRIMARY KEY (IDU) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : CLIENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CLIENT
 (
   IDC DB_INTEGER(2) NOT NULL  ,
   IDU DB_INTEGER(2) NOT NULL  ,
   NOM DB_TEXT, 32 NOT NULL  ,
   MAIL DB_TEXT, 32 NOT NULL  ,
   TEL DB_TEXT, 32 NOT NULL  ,
   ADRESSE DB_TEXT, 32 NOT NULL  
   , PRIMARY KEY (IDC) 
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
   IDP DB_INTEGER(2) NOT NULL  ,
   PRODUIT DB_INTEGER(1) NOT NULL  ,
   SERVICE DB_INTEGER(1) NOT NULL  ,
   TVA DB_TEXT, 32 NOT NULL  ,
   PRIX DB_LONG(4) NOT NULL  
   , PRIMARY KEY (IDP) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : DOCUMENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DOCUMENT
 (
   IDD DB_INTEGER(2) NOT NULL  ,
   IDU DB_INTEGER(2) NOT NULL  ,
   IDC DB_INTEGER(2) NOT NULL  ,
   DESCRIPTION DB_TEXT, 32 NOT NULL  
   , PRIMARY KEY (IDD) 
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
   IDT DB_INTEGER(2) NOT NULL  ,
   IDD DB_INTEGER(2) NOT NULL  ,
   DATE DB_DATE(8) NOT NULL  
   , PRIMARY KEY (IDT,IDD) 
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
   IDD DB_INTEGER(2) NOT NULL  ,
   IDP DB_INTEGER(2) NOT NULL  ,
   QUANTITÉ DB_INTEGER(2) NOT NULL  
   , PRIMARY KEY (IDD,IDP) 
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

