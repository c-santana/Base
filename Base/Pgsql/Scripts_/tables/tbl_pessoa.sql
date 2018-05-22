create table
       tbl_pessoa(
            int_id  int primary key not null        default nextval('seq_pessoa_id'),
            str_nome varchar(50)    default null 
);
