/* Tables */
CREATE TABLE FORNITORE (
    CodiceFiscale INTEGER NOT NULL,
    Indirizzo INTEGER NOT NULL,
    Nome INTEGER NOT NULL,
    PRIMARY KEY (CodiceFiscale)
);
CREATE TABLE PIANTA (
    CodP INTEGER NOT NULL,
    NomeComune INTEGER NOT NULL,
    NomeLatino INTEGER NOT NULL,
    Giardino INTEGER NOT NULL,
    Esotica INTEGER NOT NULL,
    Type INTEGER NOT NULL,
    FORNITORE_CodiceFiscale INTEGER,
    PRIMARY KEY (CodP),
    FOREIGN KEY (FORNITORE_CodiceFiscale) REFERENCES FORNITORE(CodiceFiscale)
);
CREATE TABLE CLIENTE (
    CodC INTEGER NOT NULL,
    Nome INTEGER NOT NULL,
    PIVA INTEGER,
    CodiceFiscale INTEGER,
    Type INTEGER NOT NULL,
    Civico_Indirizzo INTEGER NOT NULL,
    Nome_Indirizzo INTEGER NOT NULL,
    TipoVia_Indirizzo INTEGER NOT NULL,
    Citta_Indirizzo INTEGER NOT NULL,
    PRIMARY KEY (CodC)
);
CREATE TABLE TEMPO (
    Data INTEGER NOT NULL,
    PRIMARY KEY (Data)
);
CREATE TABLE TEMPO2 (
    DataInizio INTEGER NOT NULL,
    PRIMARY KEY (DataInizio)
);
CREATE TABLE HAS_COLORE (
    PIANTA_CodP INTEGER NOT NULL,
    COLORE_Colore INTEGER NOT NULL,
    PRIMARY KEY (PIANTA_CodP, COLORE_Colore),
    FOREIGN KEY (PIANTA_CodP) REFERENCES PIANTA(CodP)
);
CREATE TABLE ACQUISTO (
    PIANTA_CodP INTEGER NOT NULL,
    CLIENTE_CodC INTEGER NOT NULL,
    TEMPO_Data INTEGER NOT NULL,
    Quantita INTEGER NOT NULL,
    PRIMARY KEY (PIANTA_CodP, CLIENTE_CodC, TEMPO_Data),
    FOREIGN KEY (PIANTA_CodP) REFERENCES PIANTA(CodP),
    FOREIGN KEY (CLIENTE_CodC) REFERENCES CLIENTE(CodC),
    FOREIGN KEY (TEMPO_Data) REFERENCES TEMPO(Data)
);
CREATE TABLE LISTINO (
    PIANTA_CodP INTEGER NOT NULL,
    TEMPO2_DataInizio INTEGER NOT NULL,
    DataFIne INTEGER,
    Prezzo INTEGER NOT NULL,
    PRIMARY KEY (PIANTA_CodP, TEMPO2_DataInizio),
    FOREIGN KEY (PIANTA_CodP) REFERENCES PIANTA(CodP),
    FOREIGN KEY (TEMPO2_DataInizio) REFERENCES TEMPO2(DataInizio)
);