CREATE OR REPLACE FUNCTION
	PESSOA_SALVAR(
		STR_NAME VARCHAR(50)
		)
RETURNS VOID AS $$
      BEGIN
        INSERT INTO
			PESSOA(
				STR_NAME
			)
        VALUES(
				STR_NAME
			);
      END;
      $$
LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION
	USUARIO_SALVAR(
		INT_PESSOA_ID INT,
		STR_LOGIN VARCHAR(50),
		STR_PASSWD VARCHAR(50),
		INT_PERMISSION_LEVEL INT
		)
RETURNS VOID AS $$
      BEGIN
        INSERT INTO
			USUARIO(
				STR_LOGIN,
				STR_PASSWD,
				INT_PERMISSION_LEVEL
				)
        VALUES(
				STR_LOGIN,
				STR_PASSWD,
				INT_PERMISSION_LEVEL
			);
			
      	BEGIN
			INSERT INTO
				REL_PESSOA_USUARIO(
				INT_PESSOA_ID, INT_USUARIO_ID
				)
             VALUES(
				INT_PESSOA_ID, CURRVAL('usuario_sequence')
			);
        END;
		
      END;
$$ LANGUAGE 'plpgsql';