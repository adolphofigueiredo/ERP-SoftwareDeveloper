﻿using System;
using System.Windows.Forms;

namespace _20240918_Database_FrameWork
{
    public partial class FrmMain : Form                                                            //A classe FrmMain herda da classe Form, o que significa que ela é um formulário
                                                                                                   //de uma aplicação Windows Forms. A palavra-chave partial indica que a definição
                                                                                                   //dessa classe pode estar espalhada por vários arquivos, o que é típico quando
                                                                                                   //usamos o Windows Forms Designer, que gera automaticamente parte do código.
    {
        public FrmMain()                                                                           //Construtor do tipo publico que chama o método InitializeComponent()
        {
            InitializeComponent();                                                                 //O construtor FrmMain() chama o método InitializeComponent(), que é responsável
                                                                                                   //por inicializar e configurar os controles visuais do formulário (gerado
                                                                                                   //automaticamente pelo designer do Windows Forms).
        }
        private void studentiSearchStripMenuItem_Click(object sender, EventArgs e)                   //É o método handler de evento associado ao clique no item de menu
                                                                                                   //studentiToolStripMenuItem.
        {
            FrmStudenti formStudenti = new FrmStudenti();                                          //Esta linha cria uma nova instância do formulário FrmStudenti. Essa instância
                                                                                                   //é um objeto que representa a janela ou tela onde as interações com os dados
                                                                                                   //dos estudantes podem ocorrer. O formStudenti é do tipo FrmStudenti, que é uma
                                                                                                   //classe derivada de Form. Isso significa que formStudenti é um objeto que
                                                                                                   //possui todas as propriedades e métodos de um formulário do Windows.

            formStudenti.MdiParent = this;                                                         //Quando executado, você está configurando formStudenti para ser um "filho" da
                                                                                                   //janela principal (que neste caso é FrmMain). Isso organiza o layout da interface
                                                                                                   //do usuário, permitindo que múltiplos formulários sejam exibidos dentro da mesma
                                                                                                   //janela principal, facilitando a navegação e a experiência do usuário.
            
            formStudenti.Show();                                                                   //Exibe a janela do formulário, permitindo que o usuário interaja com ela. Essa
                                                                                                   //chamada inicia o ciclo de vida do formulário, onde o usuário pode realizar
                                                                                                   //ações como preencher campos e clicar em botões.
        }

        private void studentiEditToolStripMenuItem_Click(object sender, EventArgs e)               //É o método handler de evento associado ao clique no item de menu
                                                                                                   //studentiToolStripMenuItem.
        {
            FrmEditStudente formEditStudente = new FrmEditStudente();                              //Esta linha cria uma nova instância do formulário FrmStudenti. Essa instância
                                                                                                   //é um objeto que representa a janela ou tela onde as interações com os dados
                                                                                                   //dos estudantes podem ocorrer. O formStudenti é do tipo FrmStudenti, que é uma
                                                                                                   //classe derivada de Form. Isso significa que formStudenti é um objeto que
                                                                                                   //possui todas as propriedades e métodos de um formulário do Windows.

            formEditStudente.MdiParent = this;                                                     //Quando executado, você está configurando formStudenti para ser um "filho" da
                                                                                                   //janela principal (que neste caso é FrmMain). Isso organiza o layout da interface
                                                                                                   //do usuário, permitindo que múltiplos formulários sejam exibidos dentro da mesma
                                                                                                   //janela principal, facilitando a navegação e a experiência do usuário.

            formEditStudente.Show();                                                                   //Exibe a janela do formulário, permitindo que o usuário interaja com ela. Essa
                                                                                                   //chamada inicia o ciclo de vida do formulário, onde o usuário pode realizar
                                                                                                   //ações como preencher campos e clicar em botões.
        }
        private void corsiSearchStripMenuItem_Click(object sender, EventArgs e)                      //É o método handler de evento associado ao clique no item de menu
                                                                                                   //corsiToolStripMenuItem.
        {
            FrmCorsi formCorsi = new FrmCorsi();                                                   //Esta linha cria uma nova instância do formulário FrmStudenti. Essa instância
                                                                                                   //é um objeto que representa a janela ou tela onde as interações com os dados
                                                                                                   //dos estudantes podem ocorrer.

            formCorsi.MdiParent = this;                                                            //Quando executado, você está configurando formCorsi para ser um "filho" da
                                                                                                   //janela principal (que neste caso é FrmMain). Isso organiza o layout da interface
                                                                                                   //do usuário, permitindo que múltiplos formulários sejam exibidos dentro da mesma
                                                                                                   //janela principal, facilitando a navegação e a experiência do usuário.

            formCorsi.Show();                                                                      //Exibe a janela do formulário, permitindo que o usuário interaja com ela. Essa
                                                                                                   //chamada inicia o ciclo de vida do formulário, onde o usuário pode realizar
                                                                                                   //ações como preencher campos e clicar em botões.
        }

        private void corsiEditToolStripMenuItem_Click(object sender, EventArgs e)                  //É o método handler de evento associado ao clique no item de menu
                                                                                                   //corsiToolStripMenuItem.
        {
            FrmEditCorso formEditCorsi = new FrmEditCorso();                                       //Esta linha cria uma nova instância do formulário FrmStudenti. Essa instância
                                                                                                   //é um objeto que representa a janela ou tela onde as interações com os dados
                                                                                                   //dos estudantes podem ocorrer.

            formEditCorsi.MdiParent = this;                                                        //Quando executado, você está configurando formCorsi para ser um "filho" da
                                                                                                   //janela principal (que neste caso é FrmMain). Isso organiza o layout da interface
                                                                                                   //do usuário, permitindo que múltiplos formulários sejam exibidos dentro da mesma
                                                                                                   //janela principal, facilitando a navegação e a experiência do usuário.

            formEditCorsi.Show();                                                                      //Exibe a janela do formulário, permitindo que o usuário interaja com ela. Essa
                                                                                                   //chamada inicia o ciclo de vida do formulário, onde o usuário pode realizar
                                                                                                   //ações como preencher campos e clicar em botões.
        }

        private void FrmEntityFrameworkExample_Click(object sender, EventArgs e)                   //É o método handler de evento associado ao clique no item de menu
                                                                                                   //FrmEntityFrameworkExample.
        {
            FrmEntityFrameworkExample formEntityFrameworkExample = new FrmEntityFrameworkExample();
                                                                                                   //Esta linha cria uma nova instância do formulário FrmStudenti. Essa instância
                                                                                                   //é um objeto que representa a janela ou tela onde as interações com os dados
                                                                                                   //dos estudantes podem ocorrer.

            formEntityFrameworkExample.MdiParent = this;                                           //Quando executado, você está configurando formCorsi para ser um "filho" da
                                                                                                   //janela principal (que neste caso é FrmMain). Isso organiza o layout da interface
                                                                                                   //do usuário, permitindo que múltiplos formulários sejam exibidos dentro da mesma
                                                                                                   //janela principal, facilitando a navegação e a experiência do usuário.

            formEntityFrameworkExample.Show();                                                     //Exibe a janela do formulário, permitindo que o usuário interaja com ela. Essa
                                                                                                   //chamada inicia o ciclo de vida do formulário, onde o usuário pode realizar
                                                                                                   //ações como preencher campos e clicar em botões.
        }

//*** CUIDADO *** CURIOSIDADE CTRL + R + R --> É um atalho para renomear, do mesmo modo, mais de um campo que ja é igual.

        private void Form1_Click(object sender, EventArgs e)                                       //É o método handler de evento associado ao clique no item de menu
                                                                                                   //Frm01_Click.
        {
            DataBase_Connection form01_Click = new DataBase_Connection();
                                                                                                   //Esta linha cria uma nova instância do formulário FrmStudenti. Essa instância
                                                                                                   //é um objeto que representa a janela ou tela onde as interações com os dados
                                                                                                   //dos estudantes podem ocorrer.

            form01_Click.MdiParent = this;                                                         //Quando executado, você está configurando formCorsi para ser um "filho" da
                                                                                                   //janela principal (que neste caso é FrmMain). Isso organiza o layout da interface
                                                                                                   //do usuário, permitindo que múltiplos formulários sejam exibidos dentro da mesma
                                                                                                   //janela principal, facilitando a navegação e a experiência do usuário.

            form01_Click.Show();                                                                   //Exibe a janela do formulário, permitindo que o usuário interaja com ela. Essa
                                                                                                   //chamada inicia o ciclo de vida do formulário, onde o usuário pode realizar
                                                                                                   //ações como preencher campos e clicar em botões.
        }

    }
}