/* Tables */
CREATE TABLE STANZE (
    CodiceNum INTEGER NOT NULL,
    Piano INTEGER NOT NULL,
    Superficie INTEGER NOT NULL,
    Type INTEGER NOT NULL,
    PRIMARY KEY (CodiceNum)
);
CREATE TABLE AGENZIE (
    CodiceAlfaNum INTEGER NOT NULL,
    Telefono INTEGER NOT NULL,
    SitoWeb INTEGER,
    Via_Indirizzo INTEGER NOT NULL,
    Numero_Indirizzo INTEGER NOT NULL,
    CAP_Indirizzo INTEGER NOT NULL,
    Citta_Indirizzo INTEGER NOT NULL,
    Stato_Indirizzo INTEGER NOT NULL,
    PRIMARY KEY (CodiceAlfaNum)
);
CREATE TABLE OPTIONAL (
    Optional INTEGER NOT NULL,
    STANZE_CodiceNum INTEGER NOT NULL,
    PRIMARY KEY (Optional),
    FOREIGN KEY (STANZE_CodiceNum) REFERENCES STANZE(CodiceNum),
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);
CREATE TABLE PRENOTAZIONE (
    STANZE_CodiceNum INTEGER NOT NULL,
    DataInizio INTEGER NOT NULL,
    Costo INTEGER NOT NULL,
    DataFine INTEGER NOT NULL,
    AGENZIE_CodiceAlfaNum INTEGER NOT NULL,
    PRIMARY KEY (STANZE_CodiceNum, DataInizio),
    FOREIGN KEY (STANZE_CodiceNum) REFERENCES STANZE(CodiceNum),
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
    FOREIGN KEY (AGENZIE_CodiceAlfaNum) REFERENCES AGENZIE(CodiceAlfaNum),
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);
CREATE TABLE HAS_SPAZI (
    STANZE_CodiceNum INTEGER NOT NULL,
    SPAZI_Spazi INTEGER NOT NULL,
    PRIMARY KEY (STANZE_CodiceNum, SPAZI_Spazi),
    FOREIGN KEY (STANZE_CodiceNum) REFERENCES STANZE(CodiceNum),
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);