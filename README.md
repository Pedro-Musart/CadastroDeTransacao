# CadastroDeTransacao

Projeto CRUD de Transações
-Este é um projeto de um CRUD básico que lista as transações das pessoas.

TECNOLOGIAS UTILIZADAS
-ASP.NET Core Web App MVC
-Linguagem C#
-Diagrama DER
-Arquitetura MVC
-Protocolo HTTP
-Orientação a Objetos
-Entity Framework
-Injeção de Dependência
-SQLite Database

EXECUÇÃO DO PROJETO
-Baixe o repositório na sua máquina.
-Abra o projeto no Visual Studio.
-Execute o comando update-database no Console do Gerenciador de Pacotes para criar o banco de dados SQLite.
Rode a aplicação.


COMO FUNCIONA A APLICAÇÃO?
-Ao acessar a aplicação, é possível inserir uma nova pessoa clicando em "Cadastrar Conta".
-Informe o nome e a idade da pessoa (pessoas menores de 18 anos só podem cadastrar despesas).
-Para visualizar a lista de contas cadastradas, clique em "Exibir todas as Contas" e veja o ID de cada conta cadastrada. Nessa mesma tela é possível apagar uma conta (e todas as transações vinculadas a ela).
-No menu de navegação, clique em "Transações" para gerenciar as transações.
-Clique em "Adicionar Transação" e informe o ID da conta que deseja adicionar uma transação.
-Selecione o tipo de transação, se é despesa ou receita (despesas entram como valor negativo na tabela).
-Observe que os dados de todas as transações inseridas serão exibidos.
-No menu de navegação, clique em "Conta e Cadastro" para obter um resumo do saldo, despesas e receitas de cada conta, bem como um total geral de todos os valores inseridos.


PONTOS DE MELHORIA
-Manipulação de dados: Seria interessante incluir uma tabela de contas no projeto para melhorar a manipulação de dados e cálculos relacionados às transações.
-Tratamento de Erros: O projeto ainda não está blindado contra erros, portanto, é possível quebrá-lo facilmente.
-Familiaridade com a tecnologia: Como é o primeiro projeto utilizando ASP.NET Core Web App MVC, ainda há muitos conceitos a serem aprendidos.
-Cálculos relacionados às transações: Os cálculos relacionados às transações poderiam ser realizados em métodos específicos na tabela de conta, ao invés de serem feitos diretamente no Controller e Index.
