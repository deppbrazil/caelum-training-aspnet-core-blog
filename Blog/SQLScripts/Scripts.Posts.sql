USE [Blog]
GO

/****** Object: Table [dbo].[Posts] Script Date: 6/23/2021 1:56:30 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Posts] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Title]    VARCHAR (50)  NULL,
    [Resume]   VARCHAR (500) NULL,
    [Category] VARCHAR (50)  NULL
);


SELECT * FROM [dbo].[Posts];

DELETE FROM [dbo].[Posts]
  WHERE Id = '1004';

INSERT INTO [dbo].[Posts]
	VALUES  ('Piratas do Caribe 5','O capitão Salazar é a nova pedra no sapato do capitão Jack Sparrow. Ele lidera um exército de piratas fantasmas assassinos e está disposto a matar todos os piratas existentes na face da Terra. Para escapar, Sparrow precisa encontrar o Tridente de Poseidon, que dá ao seu dono o poder de controlar o mar.','Ação, Aventura');

INSERT INTO [dbo].[Posts]
	VALUES  ('Vingadores Ultimato','Após Thanos eliminar metade das criaturas vivas, os Vingadores têm de lidar com a perda de amigos e entes queridos. Com Tony Stark vagando perdido no espaço sem água e comida, Steve Rogers e Natasha Romanov lideram a resistência contra o titã louco.','Ação');

INSERT INTO [dbo].[Posts]
	VALUES  ('O Grande Gatsby','Na primavera de 1922, Nick Carraway chega a Nova York e vira vizinho do misterioso e festeiro milionário Jay Gatsby quando vai viver do outro lado da baía com sua prima Daisy e seu marido mulherengo Tom Buchanan. Assim, Nick é atraído para o mundo cativante dos ricos, suas ilusões, amores e fraudes. Ao testemunhar fatos dentro e fora do mundo em que habita, Nick escreve um conto de amor impossível, sonhos e tragédias que espelham conflitos em tempos modernos.','Romance, Drama');