create or replace view viw_usuario(
    nome,
    "usuário",
    senha,
    "level de permissão")
as
  select tbl_pessoa.str_nome as nome,
         tbl_usuario.str_login as usuário,
         tbl_usuario.str_senha as senha,
         tbl_usuario.int_level_permissao as level_permissao
  from tbl_usuario
  left join tbl_pessoa on tbl_pessoa.int_id = tbl_usuario.int_pessoa_id;
 			