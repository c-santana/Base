create or replace function
	fnc_usuario_salvar(
        pessoa_id       INT,
        nome_usuario    VARCHAR(50),
        senha           VARCHAR(50),
        nivel_permissao INT
        )
returns void as $$
      begin
        insert into
            tbl_usuario(
                int_pessoa_id,
                str_login,
                str_senha,
                int_level_permissao
                )
        values(
                pessoa_id,
                nome_usuario,
                senha,
                nivel_permissao
            );
      END;
$$ LANGUAGE 'plpgsql';