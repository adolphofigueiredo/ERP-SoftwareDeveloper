Obiettivo: 
Gestire il business delle riviste di una casa editrice (Es. Mondadori).
La casa editrice gestisce più riviste (es. https://www.grandiclienti.it/riviste).
Bisogna programmare l'uscita di ogni rivista e con esso quale articolo
deve essere pubblicato, quale pubblicità deve essere inserita, e quali
autori devono lavorare all'uscita.

1) Creare una tabella "Magazine" che contiene le informazioni di
base di una rivista.
    - No.           Code[20]
    - Name          Text[50]
    - Category      Code[20] - Relation: Magazine Category
    - Publication Frequency  - Enum "Publication Frequency"
(Es. Mensile, Settimanale, Quindicinale, etc.)
    - Articles No.  Integer - il numero di articoli da mettere nella
rivista
    - Ads No.       Integer - il numero di ads da mettere nella
rivista
    Creare la pagina "Magazine List" e "Magazine Card".
    Al doppio click della lista devo poter aprire la card.
    Lista collegata all'UsageCategory = Lists;

2) Creare una tabella "Magazine Category" che contiene le categorie
di riviste (es. Sport, Moda, etc.)
    - Code          Code[20]
    - Description   Text[50]
    Creare la pagina "Magazine Category List" 
    Lista collegata all'UsageCategory = Administration;

3) Estendere la tabella Item
    - "Article Type"        Enum "Article Type" = 0 - " ", 1 - "Article", 2 - "Ads"
        Al validate di Articles metter il valore 1 sul campo Publishing Max No.
    - Magazine Category     Code[20] - Relation: Magazine Category
    - Published No.         Integer - FlowField: somma tutte le occorrenze dell'item
sulla tabella Magazine Entry
    - Publishing No.        Integer - FlowField: somma tutte le occorrenze dell'item
sulla tabella Publication Line
    - Publishing Max No.    Integer - il numero massimo di volte che l'item può essere
pubblicato, vale soprattutto per le ads, per gli articles sarà sempre a 1
    Inserire i campi in un apposito group della pagina "Item Card" chiamato "Magazine"

4) Creare una struttura testata-riga per gestire le pubblicazioni:
    - Publication Header
        - No.                   Code[20]
        - Magazine No.          Code[20] - Relation: Magazine
            - Al validate del campo Magazine compilare i campi Number e Description
        - Number                Integer - Numero della rivista
        - Description           Text[100] - "%1 - %2" - Magazine.Name, Number
        - "Publication Date"    Date
    Fare la pagina "Publication List" e "Publication Card" (page type = Document)
    - Publication Line:
        - Publication No.   Code[20]
        - Line No.          Integer
        - Type              Enum "Publication Line Type" = 0 - " ", 1 - "Article",
2 - "Ads", 3 - "Resource"
        - No.               Code[20] - Relation: Item,Resouce (dipende dal campo Type)
        - Description       Text[100] - Compilato quando si compila No.
    Fare la pagina "Publication Subpage" con le caratteristiche:
    PageType = ListPart;
    AutoSplitKey = true;
    DelayedInsert = true;
    Collegarla alla pagina "Publication Card" con il campo "Publication No."

5) Creare una tabella "Magazine Entry" che contiene le informazioni di registrazione:
    - Entry No.         Integer - Autoincrement, not editable
    - Magazine No.      Code[20] - Relation: Magazine
    - Type              Enum "Publication Line Type"
    - No.               Code[20]
    - Publication Date  Date
    - Description       Text[100]
    - Magazine Number   Integer
    Creare la pagina "Magazine Entry List" 
    Lista collegata all'UsageCategory = History;

6) Creare un pulsante "Registra" sulla "Publication Card" che registri l'effettiva
pubblicazione del numero:
    - Verificare che i vincoli di numero articoli e pubblicità siano rispettati
    - Verificare che ci sia almeno una risorsa ogni due articoli (es. se ho 10 articoli
devo avere almeno 5 risorse)
    - Deve scrivere la Magazine Entry
    - Deve creare una fattura di vendita per le pubblicità ad un unico cliente impostato
a setup (es. è la loro agenzia pubblicitaria)
    - elimino la Publication Header e le Publication Line

7) Creare un pulsante "Programma" sulla "Magazine Card" che permette di programmare la
pubblicazione di una rivista:
    - Apre una pagina di programmazione che chiede il periodo da programmare
    - Crea tante Publication Header quante sono le pubblicazioni da fare
    - Per ogni Publication Header crea le Publication Line:
        - Prende i primi n articoli da pubblicare con lo stesso Magazine Category (n è
definito sul magazine)
        - Prende n pubblicità da pubblicare in ordine di numero di prezzo
            - n è definito sul magazine
            - non posso usare due pubblicità uguali nella stessa pubblicazione
            - posso usare le pubblicità un numero di volte massimo definito sull'Item
        - non vengono assegnate risorse in questo momento

















3); Estendere la tabella Item

    - Published No.         Integer - FlowField: somma tutte le occorrenze dell'item
sulla tabella Magazine Entry

    - Publishing No.        Integer - FlowField: somma tutte le occorrenze dell'item
sulla tabella Publication Line

    - Publishing Max No.    Integer - il numero massimo di volte che l'item può essere
pubblicato, vale soprattutto per le ads, per gli articles sarà sempre a 1

6); Creare un pulsante "Registra" sulla "Publication Card" che registri l'effettiva
pubblicazione del numero:

    - Verificare che i vincoli di numero articoli e pubblicità siano rispettati

    - Verificare che ci sia almeno una risorsa ogni due articoli (es. se ho 10 articoli
devo avere almeno 5 risorse);

    - Deve scrivere la Magazine Entry

    - Deve creare una fattura di vendita per le pubblicità ad un unico cliente impostato
a setup (es. è la loro agenzia pubblicitaria)

    - elimino la Publication Header e le Publication Line

7); Creare un pulsante "Programma" sulla "Magazine Card" che permette di programmare la
pubblicazione di una rivista:

    - Apre una pagina di programmazione che chiede il periodo da programmare

    - Crea tante Publication Header quante sono le pubblicazioni da fare

    - Per ogni Publication Header crea le Publication Line:

        - Prende i primi n articoli da pubblicare con lo stesso Magazine Category (n è
definito sul magazine);
        - Prende n pubblicità da pubblicare in ordine di numero di prezzo
            - n è definito sul magazine
            - non posso usare due pubblicità uguali nella stessa pubblicazione
            - posso usare le pubblicità un numero di volte massimo definito sull'Item
        - non vengono assegnate risorse in questo momento








































