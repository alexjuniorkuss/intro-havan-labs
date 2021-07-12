insert into produto
(Nome,Descricao)
Values
('Celular', 'Moto G')


Select Id,
Nome
,Descricao 


From Produto


-- Update
UPDATE produto
Set 
	Nome ='Notebook'
	where Nome ='Celular' and ID='4'

	--delete

	DELETE FROM produto
	where id =4