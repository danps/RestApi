sp_help fornecedor
go 
begin tran 
declare @FornecedorId uniqueidentifier = newid()
insert into fornecedor (seq_fornecedor, nom_fornecedor, dsc_identificador_fornecedor, TipoFornecedor, Ativo) 
values (@FornecedorId, 'Herói sem poderes', '01234567890', 1, 1)


insert into endereco(seq_endereco, FornecedorId, dsc_endereco, num_endereco, obs_endereco, cep_endereco, nom_bairro, nom_cidade, nom_estado)
values(newid(), @FornecedorId, 'Praça dos Três Poderes?', '100', '', '70175900', 'Edifício Anexo II - A', 'Brasília', 'MG')

insert into produto(seq_produto, FornecedorId, nom_produto, dsc_produto, Valor, img_produto, DataCadastro, Ativo)
values (newid(), @FornecedorId, 'Lei Orçamentaria', 'Proposta de melhoria ou de simplificação dos serviços oferecidos', '2705.22', '', getdate(), 1)

insert into produto(seq_produto, FornecedorId, nom_produto, dsc_produto, Valor, img_produto, DataCadastro, Ativo)
values (newid(), @FornecedorId, 'Acesso à informação', 'Obtenha auxílio no peticionamento', '230.22', '', getdate(), 1)


set @FornecedorId = newid()

insert into fornecedor (seq_fornecedor, nom_fornecedor, dsc_identificador_fornecedor, TipoFornecedor, Ativo)
values (@FornecedorId, 'Cabadra, Inc. (1914–1915)', '12345678910', 1, 1)

insert into endereco(seq_endereco, FornecedorId, dsc_endereco, num_endereco, obs_endereco, cep_endereco, nom_bairro, nom_cidade, nom_estado)
values(newid(), @FornecedorId, 'Praça dos Três Poderes','100', '', '70165900', 'Zona Cívico-Administrativa', 'Brasília', 'MG')

insert into produto(seq_produto, FornecedorId, nom_produto, dsc_produto, Valor, img_produto, DataCadastro, Ativo)
values (newid(), @FornecedorId, 'Plenário da Câmara', 'Plenário da Câmara dos Deputados', '2705.22', '', getdate(), 1)



insert into produto(seq_produto, FornecedorId, nom_produto, dsc_produto, Valor, img_produto, DataCadastro, Ativo)
values (newid(), @FornecedorId,  'Sessão Convocada', 'Resultado da ultima sessão deliberativa', '230.22', '', getdate(), 1)

insert into produto(seq_produto, FornecedorId, nom_produto, dsc_produto, Valor, img_produto, DataCadastro, Ativo)
values (newid(), @FornecedorId, 'Plenário do Senado', 'Plenário do Senado Federal', '1205.22', '', getdate(), 1)


select * from fornecedor
commit 

