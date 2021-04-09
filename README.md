# Aplicação de Console de Carteira de Investimentos

Funções do Menu da aplicação 

============================================================
* Menu de Aplicação:
* 1 - Adiconar um novo ativo na Carteira
* 2 - Visualizar a lista de ativos investidos
* 3 - Informar a venda de um ativo
* 4 - Visualizar um resumo do valor total investido
* 5 - Sair do menu

============================================================

## Motivação/Contexto

A criação da Carteira de Investimento tem finalidade de fazer com que o usuário tenha controle de seus investimetos de modo simples e rápido. Tendo como princípios poder adicionar um ativo em sua base, visualizar esse ativo, poder informar a venda e atualizar na própria carteira e em seguida poder visualizar o investimento total e alocado em cada ativo. Os dados são mantidos em memória durante a execução do programa.

## Como funciona

O código utiliza linguagem C# e o framework .NET Core 3.x. Estamos utilizando Nunit para realizar os testes.

# Arquivos, class e seus métodos:

## TelaPrincipal.cs
Aqui temos a tela principal do programa com a class Main, onde  instanciamos os objetos e class criadas nos outros arquivos do projeto. Temos o Menu principal que aparece para o usuario assim que o programa é inicializado. 
Dentro do class Main ainda temos o loop que permite o usuário sempre retornar ao menu e em seguida os "case" possiveis com as entradas do usuário.

## TelaAtivo.cs
Dentro do arquivo TelaAtivo encontra-se a class TelaAtivo onde recebemos as entradas do usuários que alimentam nosso objeto e será possivel trabalhar com o mesmo, com os métodos telaAdicionaNovoAtivo(), telaVisualizarListaAtivosInvestido(), telaInformarVendaAtivo() e telaVisualizarResumoValorInvestido()

## GerenciaCarteiraDeInvestimento.cs
É criado a class CarteiraDeInvestimento, onde literalmente é possivel fazer o gerenciamento da carteira de Investimento com os métodos adicionaNovoAtivo(), visualizarListaAtivosInvestido(), informarVendaAtivo(), visualizarResumoValorInvestido().

## Ativo.cs
Criação da class Ativo, onde é declarada todos os atributos do ativo e seu construtor que será possivel criar o objeto que será analisado por TelaAtivo.

## CarteiraDeInvestimentoTest.cs
Realização dos testes de todos os métodos de que é realizado com o objeto. 
Utilização o Nunit
