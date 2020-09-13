# Projeto SOM - Sistema de Ocorrências Médicas

## Histórico

O carnaval de Salvador-Ba é tido como o maior carnaval do mundo. Números mostram que aproximadamente um milhão de pessoas de todo o mundo participam desse mega evento. Com essa quantidade de pessoas aglomeradas nas ruas da cidade, é possível que acidentes ocorram e necessitem de atendimento médico-hospitalar. O **SOM - Sistema de Ocorrências Médicas**, que originalmente não tinha esse nome, foi idealizado nesse contexto. Sempre que alguém fosse encaminhado a uma unidade hospitalar por alguma causa originada em um dos circuitos do carnaval da cidade, deveria ser feito o registro, inclusive, neste sistema.

Ao longo da história desse sistema, aplicações em Delphi, ASP, PHP e ASP.NET foram criadas e mantidas para apoiar a digitação das informações originadas nas unidades de saúde. No arquivo a seguir temos uma versão do formulário utilizado originalmente para coleta dessas informações.

[Ficha de Ocorrências](https://github.com/reginaldorsj/projeto_som/blob/master/Documentos/Ficha%20do%20Sistema.doc "Ficha de Ocorrências")

## Arquitetura

O sistema é composto por duas aplicações construidas com **Angular 9** e utilizando **[PrimeNG Components](https://www.primefaces.org/primeng/ "PrimeNG Components")**: uma para digitação dos dados e outra para exibição consolidada das informações (dashboard). No back-end dessas aplicações temos uma **Web API** desenvolvida em **ASP.NET/C#**, com as regras de regras de negócio e acesso a dados desenvolvidas em camadas. O banco de dados é o **SQL Server**. Contudo, em ambiente de desenvolvimento e testes, utiliza-se o **Firebird** que, inclusive, o script está disponível para download aqui no Github. Para finalizar, mencionamos ainda que o **NHibernate ORM** é utilizado neste sistema para acesso a dados.    

## Screens

> Tela de acesso ao sistema

![](http://sis.saude.ba.gov.br/SOM/assets/images/SOM.png)

> Tela de lançmento de ocorrências

![](http://sis.saude.ba.gov.br/SOM/assets/images/Ocorrencias.png)

> Dashboard

![](http://sis.saude.ba.gov.br/SOM/assets/images/Dashboard.png)

