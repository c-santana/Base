create or replace function
	fnc_pessoa_salvar(
        nome    VARCHAR(50)
        )
returns void as $$
      begin
        insert into
            tbl_pessoa(
                str_nome
                )
        values(
                nome
                );
      END;
$$ LANGUAGE 'plpgsql';