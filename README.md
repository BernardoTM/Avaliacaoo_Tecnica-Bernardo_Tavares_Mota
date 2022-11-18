# Avaliação Técnica - Programa de Desenvolvedores Trainees

Bernardo Tavares Mota 

## Questão 1

Para desenvolver a solução para o 'Aspirador Inteligente' foi utilizado `C# 10` e `.NET SDK` (6.0.110).
O projeto se encontra na pasta 'Questão 1'.

## Questão 2

Para a criação do site foi utilizado `HTML`, `CSS` e `JavaScript`.

## Questão 3

Para desenvolver essa atividade foi utilizado uma ferramenta online para testar, compartilhar e colaborar em snippets SQL chamada Db Fiddle.
O banco de dados utilizado como base foi o `PostgreSQL` v15.

**Link para acessar a solução**: https://www.db-fiddle.com/f/a567g62xgz4WhFaFich7P8/3

#### Abaixo se encontra o código caso não seja possível acessar o link.

##### Criacão das tabelas 
``` sql
CREATE TABLE Pessoas(
	ID integer PRIMARY KEY,
 	NOME text,
 	CONTRATO_ID integer,
  	INADIMPLENTE char,
  	DT_COMPLETO date
);

CREATE TABLE Contratos(
	ID integer PRIMARY KEY,
 	VALOR_PARCELA decimal, 
  	PARCELAS decimal
);

CREATE TABLE Pagamentos(
	ID integer PRIMARY KEY,
  	PESSOA_ID integer,
  	DT_PAGAMENTO date,
  	CONSTRAINT FK_PESSOA_ID FOREIGN KEY (PESSOA_ID) REFERENCES Pessoas(ID)
);
``` 
##### Inserção dos dados nas tabelas.
``` sql
INSERT INTO Pessoas VALUES
(1, 'Cristian Ghyprievy', 2, 'S', NULL),
(2, 'Joana Cabel', 1, 'S', NULL),
(3, 'John Serial', 3, 'S', NULL),
(4, 'Michael Seven', 2, 'N', '2021-09-25');

INSERT INTO Contratos VALUES
(1, 150, 100),
(2, 300, 48),
(3, 550, 24),
(4, 1000, 12);

INSERT INTO Pagamentos VALUES
(1, 4, '2021-09-01'),
(2, 3, '2021-09-05'),
(3, 1, '2021-09-19'),
(4, 2, '2021-09-25');
```
##### Seleciondo o nome, dia do mês e valor da parcela para clientes que estão inadimplentes.
```sql
SELECT NOME,
	EXTRACT(DAY FROM DT_PAGAMENTO) AS DIA_MES, 
    VALOR_PARCELA
FROM Pessoas 
INNER JOIN Contratos 
	on Pessoas.CONTRATO_ID = Contratos.ID
INNER JOIN Pagamentos
	ON Pagamentos.PESSOA_ID = Pessoas.ID
WHERE INADIMPLENTE = 'S'
ORDER BY NOME;
```
##### Selecionar o nome e valor total pago de clientes com pagamento completo.
```sql
SELECT NOME, 
	VALOR_PARCELA * PARCELAS AS VALOR_TOTAL 
FROM Pessoas
INNER JOIN Contratos
	ON Pessoas.CONTRATO_ID = Contratos.ID
WHERE DT_COMPLETO IS NOT NULL
```



















