using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace _20240918_Database_FrameWork                                                             //Define o escopo do projeto ou módulo.Todo o código dentro deste namespace
                                                                                                   //está agrupado logicamente sob o projeto "_20240918_Database_FrameWork".
{
    internal static class Program                                                                  //A classe Program é a classe principal onde o ponto de entrada da aplicação
                                                                                                   //está localizado. O static indica que os membros desta classe são acessíveis
                                                                                                   //diretamente pela classe sem necessidade de instância. O internal define que
                                                                                                   //a classe é acessível apenas dentro do assembly(projeto), ou seja, outras
                                                                                                   //classes em outros assemblies não podem acessar Program.
    {   /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]                                                                                //É um atributo que indica que o modelo de threading da aplicação é STA
                                                                                                   //(Single-Threaded Apartment), que é necessário para garantir que os
                                                                                                   //componentes da interface gráfica funcionem corretamente. Windows Forms e
                                                                                                   //outros componentes do Windows, como o COM (Component Object Model),
                                                                                                   //exigem este modelo de threading para evitar problemas de concorrência.
        static void Main()                                                                         //Este é o ponto de entrada da aplicação Windows Forms. É o método principal
                                                                                                   //que é invocado pelo runtime do .NET para iniciar o programa. O método void
                                                                                                   //não retorna nenhum valor.O static significa que o método pode ser invocado
                                                                                                   //sem a necessidade de instanciar a classe Program.
        {
            Application.EnableVisualStyles();                                                      //Ativa os estilos visuais modernos para controles Windows Forms, tornando a
                                                                                                   //interface mais agradável e consistente com o tema do Windows. Sem isso, a
                                                                                                   //interface gráfica utilizaria um estilo antigo, sem aproveitar os visuais
                                                                                                   //modernos disponíveis nas versões mais recentes do Windows.

            Application.SetCompatibleTextRenderingDefault(false);                                  //Define que a renderização de texto padrão para controles deve ser feita
                                                                                                   //usando o método de renderização do .NET (em vez do método do Windows GDI).
                                                                                                   //Geralmente, isso é definido como false para manter a consistência visual
                                                                                                   //dos textos entre diferentes tipos de controles.

            Application.Run(new FrmMain());                                                        //Este é o ponto onde o loop principal da interface gráfica é iniciado. A
                                                                                                   //chamada ao Application.Run() coloca a aplicação em um loop que aguarda por
                                                                                                   //eventos do usuário (como cliques ou digitação) e atualiza a interface
                                                                                                   //conforme necessário.O new FrmMain() inicializa o formulário principal da
                                                                                                   //aplicação, já o FrmMain será a janela principal que o usuário verá ao
                                                                                                   //executar o programa.
        }
    }
}
