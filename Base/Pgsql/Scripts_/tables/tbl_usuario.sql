create table
       tbl_usuario(
            int_id              int primary key  not null         default nextval('seq_usuario_id'),
            int_pessoa_id       int              not null         references tbl_pessoa(int_id),
            str_login            varchar(50)      default null,   
            str_senha           varchar(50)      default null,
            int_level_permissao int              default null

);
