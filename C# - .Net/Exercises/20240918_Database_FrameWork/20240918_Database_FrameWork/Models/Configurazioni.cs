using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO.Ports;

namespace _20240918_Database_FrameWork.Models
{
    public static class Configurazioni                                                             //A classe Configurazioni é estática, o que significa que ela não pode ser instanciada
                                                                                                   //e seus membros são acessados diretamente pela classe, sem a necessidade de criar
                                                                                                   //objetos. Assim ela armazena de forma centralizada a string de conexão do banco de
                                                                                                   //dados e fornece um método estático para recuperá-la, facilitando o uso da conexão
                                                                                                   //em outras partes do aplicativo.
    {
        private static readonly string _connectionString = "Server=localhost\\SQLEXPRESS;Database=ITS_CORSI_ESAMI;Trusted_Connection=True;";
                                                                                                   
                                                                                                   //A variável _connectionString é privada, o que significa que só pode ser acessada
                                                                                                   //dentro da própria classe Configurazioni. Isso ajuda a proteger a string de conexão
                                                                                                   //contra acessos diretos não controlados. Como a classe é estática, a variável também
                                                                                                   //deve ser estática. Variáveis estáticas pertencem à classe, e não a instâncias da
                                                                                                   //classe. Assim, _connectionString existe apenas uma vez na memória e é compartilhada
                                                                                                   //por todos os que usam a classe Configurazioni. Além disso o modificador readonly
                                                                                                   //indica que o valor da variável é definido uma vez, quando a classe é carregada, e
                                                                                                   //não pode ser alterado depois. Isso garante que a string de conexão permaneça
                                                                                                   //constante ao longo da execução do aplicativo.
        public static string GetConnectionString() { return _connectionString; }                   //O método public static string GetConnectionString() é público e estático, o que
                                                                                                   //significa que ele pode ser chamado a partir de qualquer parte do código sem a
                                                                                                   //necessidade de instanciar a classe Configurazioni. Assim o método retorna o valor
                                                                                                   //da variável _connectionString, que contém a string de conexão com o banco de dados.
                                                                                                   //Isso permite que outras partes da aplicação acessem a string de conexão de forma controlada.
    }
}

//Vantagens:

//Fazer este tipo de programa e manter a string de conexão em um único local facilita a manutenção. Se houver a necessidade de alterar o servidor ou o nome do banco de dados, você só precisa
//atualizar a variável _connectionString nesta classe.
//Como a variável _connectionString é privada e só acessível através do método GetConnectionString(), a string de conexão está protegida contra modificações externas. Isso ajuda a evitar erros
//acidentais de configuração em outras partes do código.
//Qualquer parte da aplicação pode simplesmente chamar Configurazioni.GetConnectionString() para obter a string de conexão, tornando o código mais limpo e padronizado.