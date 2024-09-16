class program
{
    static void Main()
    { 
        BankAccount account1 = new BankAccount("Adolpho" , 100);       //Estou criando uma instancia
        //account1.name = "Adolpho";                                   //Aqui eu consigo atribuir um
                                                                       //valor a este campo pq ele foi delcarado como publico
                                                                       //Isso pode ser um problema pq qualquer um pode acessar
                                                        //esta informacao e altera-la. O ideal e que sejam criados
                                                        //metodos para fazer este tipo de coisa
        
        //account1.balance = -100                       //A partit do momento que as propriedas viraram private esta
                                                        //linha parou de funcionar e gerou a necessidade da criaòao
                                                        //de um metodo para cada tipo de alteracao que se deseja fazer

        BankAccount account2 = new BankAccount("Leila", 100);       //Estou criando uma segunda instancia
        //account2.name = "Leila";                                  //Aqui eu consigo atribuir um
                                                                    //valor a este campo pq ele foi delcarado como publico
                                                                    //Isso pode ser um problema pq qualquer um pode acessar
                                                         //esta informacao e altera-la. O ideal e que sejam criados
                                                         //metodos para fazer este tipo de coisa

        account1.Deposit(-100);                                     //Agora sim estamos fazendo um deposito utilizando um
        account2.Deposit(100);                                      //metodo publico

        Console.WriteLine(account1.GetBalance());        //Execucao do metodo que acessa o valor do saldo de maneira mais segura

    }
}

class BankAccount                                       //estou criando uma classe
{ 
    private string name;

    private decimal balance;

    public BankAccount(string name, decimal balance)    //Estou criando um construtor para que esas informacoes
    {                                                   //sejam criadas no momento em que crio uma nova instancia
        if(string.isNullOrWitheSpace(name))             //Esta condicao verifica se o nome e nulo ou um espaco em branco
        {
            throw new Exception("Nome invalido!!!")     //Aqui estou criando uma instancia de exceçao para tratar o erro
        }

        if (balance < 0)                                            //Excecao criada para entender se o saldo e negativo
        {                                                           //caso seja negativo aparecera uma mensagem de erro
            throw new Exception("Saldo nao pode ser negativo!!!")
        }
        this.name = name;
        this.balance = balance;

    }

        public void Deposit(decimal amount)                         //Criacao de um metodo para que possa ser depositado
                                                                    //dinheiro agora sim alguns podem acessar este metodo
                                                                    //e por isso ele vai ser èublico
        {
            if (amount <= 0)
            {
                return;                                             //A utilizacao deste return faz com que a condicao encerre a execucao
                                                                    // ou seja, nao adicionara o deposito ao saldo se o deposito for negativo
            }
            balance += amount;
        }

        public decimal GetBalance()
        {
            return balance;                                         //aqui +e necessario dizer o que deve ser retornado pq nao e void e
                                                                    //por isso nao pode retornar nullo
        }

        
}