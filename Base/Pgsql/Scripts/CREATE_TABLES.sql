CREATE TABLE 
	PESSOA(
		INT_ID		INT PRIMARY KEY		NOT NULL,
		STR_NAME    VARCHAR(50)    	 
);		

CREATE TABLE 
	USUARIO(
		INT_ID	  				INT PRIMARY KEY		NOT NULL,
		STR_LOGIN 				VARCHAR(50),
		STR_PASSWD				VARCHAR(50),
		INT_PERMISSION_LEVEL	INT					
);

CREATE TABLE
	PRODUTO(	
		INT_ID				INT PRIMARY KEY		NOT NULL,	
		STR_NOME			VARCHAR(100),	    		
		INT_QUANTIDADE		INT,
		STR_UNIDADE_TIPO	VARCHAR(10)
);
