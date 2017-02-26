DROP DATABASE IF EXISTS ferreteria;

CREATE DATABASE ferreteria;

USE ferreteria;

DROP TABLE IF EXISTS persona;

CREATE TABLE persona(
	idPersona 			INT AUTO_INCREMENT NOT NULL,
    nombres				VARCHAR(50),
    apellidos			VARCHAR(50),
    colonia				VARCHAR(50),
    calle				VARCHAR(50),
    telefono			VARCHAR(20),
    CONSTRAINT PK_idPersona PRIMARY KEY (idPersona)
);

DROP TABLE IF EXISTS cliente;

CREATE TABLE cliente(
	idCliente			INT AUTO_INCREMENT NOT NULL,
    limiteCredito		DOUBLE(7,2),
    creditoDisponible	DOUBLE(7,2),
    idPersona			INT,
    CONSTRAINT PK_idCliente PRIMARY KEY (idCliente),
    CONSTRAINT FK_personaTOcliente FOREIGN KEY (idPersona)
		REFERENCES persona (idPersona)
);

