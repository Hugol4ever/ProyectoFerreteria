/*Creación de base de datos*/

DROP DATABASE IF EXISTS ferreteria;

CREATE DATABASE ferreteria;

USE ferreteria;


/*Definición de tablas*/
DROP TABLE IF EXISTS permisos;

CREATE TABLE permisos(
	idPermiso			INT AUTO_INCREMENT NOT NULL,
	aplicaMayoreo		BOOLEAN,
	historialVentas		BOOLEAN,
	registroSalidas		BOOLEAN,
	cobrar				BOOLEAN,
	cobrarCredito		BOOLEAN,
	cobrarVenta			BOOLEAN,
	eliminarArticuloVenta	BOOLEAN,
	facturar			BOOLEAN,
	verFacturas			BOOLEAN,
	administrarCredito	BOOLEAN,
	crearCliente		BOOLEAN,
	eliminarCliente		BOOLEAN,
	modificarCliente	BOOLEAN,
	crearProductos		BOOLEAN,
	modificarProductos	BOOLEAN,
	eliminarProductos	BOOLEAN,
	verVentas			BOOLEAN,
	agregarMercancia	BOOLEAN,
	modificarInventario	BOOLEAN,
	verReporteExistencias	BOOLEAN,
	realizarCorteTurno	BOOLEAN,
	verGanancias		BOOLEAN,
	cambiarConfiguraciones	BOOLEAN,
	cambiarPermisos		BOOLEAN,
    CONSTRAINT PK_idPermiso PRIMARY KEY (idPermiso)
);


DROP TABLE IF EXISTS perfiles;

CREATE TABLE perfiles(
	idPerfil			INT AUTO_INCREMENT NOT NULL,
    perfil				VARCHAR(30),
    idPermiso			INT,
    CONSTRAINT PK_idPerfil PRIMARY KEY (idPerfil),
    CONSTRAINT FK_idPermiso FOREIGN KEY (idPermiso)
		REFERENCES permisos (idPermiso)
);


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
    activo				BOOLEAN DEFAULT TRUE,
    idPersona			INT,
    CONSTRAINT PK_idCliente PRIMARY KEY (idCliente),
    CONSTRAINT FK_personaTOcliente FOREIGN KEY (idPersona)
		REFERENCES persona (idPersona)
);


DROP TABLE IF EXISTS emisor;

CREATE TABLE emisor(
	idEmisor			INT AUTO_INCREMENT NOT NULL,
    rfc					VARCHAR(13),
    correo				VARCHAR(50),
    numeroInt			INT,
    numeroExt			VARCHAR(6),
    codigoPostal		INT,
    estado				VARCHAR(20),
    municipio			VARCHAR(30),
    regimen				VARCHAR(30),
    lugar				VARCHAR(30),
    idPersona			INT,
    CONSTRAINT PK_idEmisor PRIMARY KEY (idEmisor),
    CONSTRAINT FK_personaTOemisor FOREIGN KEY (idPersona)
		REFERENCES persona (idPersona)
);


DROP TABLE IF EXISTS usuario;

CREATE TABLE usuario(
	idUsuario			INT AUTO_INCREMENT NOT NULL,
    usuario				VARCHAR(30),
    contrasenia			VARCHAR(50),
    idPersona			INT,
    idPerfil			INT,
    CONSTRAINT PK_idUsuario PRIMARY KEY (idUsuario),
    CONSTRAINT FK_personaTOusuario FOREIGN KEY (idPersona)
		REFERENCES persona (idPersona),
	CONSTRAINT FK_perfilesTOusuario FOREIGN KEY (idPerfil)
		REFERENCES perfiles (idPerfil)
);


DROP TABLE IF EXISTS departamento;

CREATE TABLE departamento(
	idDepartamento		INT AUTO_INCREMENT NOT NULL,
    departamento		VARCHAR(30),
    CONSTRAINT PK_idDepartamento PRIMARY KEY (idDepartamento)
);


DROP TABLE IF EXISTS unidadMedida;

CREATE TABLE unidadMedida(
	idUnidadMedida		INT AUTO_INCREMENT NOT NULL,
    unidadMedida		VARCHAR(20),
    activo				BOOLEAN,
    CONSTRAINT PK_idUnidadMedida PRIMARY KEY (idUnidadMedida)
);


DROP TABLE IF EXISTS tipoVenta;

CREATE TABLE tipoVenta(
	idTipoVenta			INT AUTO_INCREMENT NOT NULL,
    tipoVenta			VARCHAR(30),
    CONSTRAINT PK_idTipoVenta PRIMARY KEY (idTipoVenta)
);


DROP TABLE IF EXISTS producto;

CREATE TABLE producto(
	idProducto			INT AUTO_INCREMENT NOT NULL,
    codigoBarras		INT UNIQUE,
    nombre				VARCHAR(50),
    idTipoVenta			INT,
    precioCompra		DOUBLE(8,2),
    precioVenta			DOUBLE(8,2),
    precioMayoreo		DOUBLE(8,2),
    idUnidadMedida		INT,
    cantidad			DOUBLE(8,3),
    idDepartamento		INT,
    descuento			BOOLEAN,
    activo				BOOLEAN DEFAULT TRUE,
    CONSTRAINT PK_idProducto PRIMARY KEY (idProducto),
    CONSTRAINT FK_tipoVentaTOproducto FOREIGN KEY (idTipoVenta)
		REFERENCES tipoVenta (idTipoVenta),
	CONSTRAINT FK_unidadMedidaTOproducto FOREIGN KEY (idUnidadMedida)
		REFERENCES unidadMedida (idUnidadMedida),
	CONSTRAINT FK_departamentoTOdepartamento FOREIGN KEY (idDepartamento)
		REFERENCES departamento (idDepartamento)
);


DROP TABLE IF EXISTS salidas;

CREATE TABLE salidas(
	idSalida			INT AUTO_INCREMENT NOT NULL,
    razon				VARCHAR(100),
    cantidad			DOUBLE(8,2),
    CONSTRAINT FK_idSalida PRIMARY KEY (idSalida)
);


DROP TABLE IF EXISTS venta;

CREATE TABLE venta(
	idVenta				INT AUTO_INCREMENT NOT NULL,
    fecha				DATE,
    idUsuario			INT,
    total				DOUBLE (8,2),
    cancelada			BOOLEAN DEFAULT FALSE,
    CONSTRAINT PK_idVenta PRIMARY KEY (idVenta),
    CONSTRAINT FK_usuarioTOventa FOREIGN KEY (idUsuario)
		REFERENCES usuario (idUsuario)
);


DROP TABLE IF EXISTS detalleVenta;

CREATE TABLE detalleVenta(
	idDetalleVenta		INT AUTO_INCREMENT NOT NULL,
    idProducto			INT,
    cantidad			DOUBLE(8,3),
    precio				DOUBLE(8,2),
    idVenta				INT,
    CONSTRAINT PK_idDetalleVenta PRIMARY KEY (idDetalleVenta),
    CONSTRAINT FK_productoTOdetalleVenta FOREIGN KEY (idProducto)
		REFERENCES producto (idProducto),
	CONSTRAINT FK_ventaTOdetalleVenta FOREIGN KEY (idVenta)
		REFERENCES venta (idVenta)
);


DROP TABLE IF EXISTS ventaEfectivo;

CREATE TABLE ventaEfectivo(
	idVentaEfectivo		INT AUTO_INCREMENT NOT NULL,
    efectivo			DOUBLE(8,2),
    idVenta				INT,
    CONSTRAINT PK_idVentaEfectivo PRIMARY KEY (idVentaEfectivo),
    CONSTRAINT FK_ventaTOventaEfectivo FOREIGN KEY (idVenta)
		REFERENCES venta (idVenta)
);


DROP TABLE IF EXISTS ventaCredito;

CREATE TABLE ventaCredito(
	idVentaCredito		INT AUTO_INCREMENT NOT NULL,
    idVenta				INT,
    idCliente			INT,
    CONSTRAINT PK_idVentaCredito PRIMARY KEY (idVentaCredito),
    CONSTRAINT FK_ventaTOventaCredito FOREIGN KEY (idVenta)
		REFERENCES venta (idVenta),
	CONSTRAINT FK_clienteTOventaCredito FOREIGN KEY (idCliente)
		REFERENCES cliente (idCliente)
);


DROP TABLE IF EXISTS ventaTarjeta;

CREATE TABLE ventaTarjeta(
	idVentaTarjeta		INT AUTO_INCREMENT NOT NULL,
    referencia			VARCHAR(20),
    idVenta				INT,
    CONSTRAINT PK_idVentaTarjeta PRIMARY KEY (idVentaTarjeta),
    CONSTRAINT FK_ventaTOventaTarjeta FOREIGN KEY (idVenta)
		REFERENCES venta (idVenta)
);


DROP TABLE IF EXISTS ventaMixta;

CREATE TABLE ventaMixta(
	idVentaMixta		INT AUTO_INCREMENT NOT NULL,
    efectivo			DOUBLE(8,2),
    referencia			VARCHAR(20),
    idVenta				INT,
    CONSTRAINT PK_idVentaMixta PRIMARY KEY (idVentaMixta),
    CONSTRAINT FK_ventaTOventaMixta FOREIGN KEY (idVenta)
		REFERENCES venta (idVenta)
);


/*Creación de "procedures"*/
DROP PROCEDURE IF EXISTS SP_registrarCliente;

DELIMITER //
CREATE PROCEDURE SP_registrarCliente(
IN var_nombres VARCHAR(50),
IN var_apellidos VARCHAR(50),
IN var_colonia VARCHAR(50),
IN var_calle VARCHAR(50),
IN var_telefono VARCHAR(20),
IN var_limiteCredito DOUBLE(7,2))
	BEGIN

		DECLARE var_idPersona INT;
		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;

		START TRANSACTION;
        
			INSERT INTO persona (nombres, apellidos, colonia, calle, telefono)
				VALUES (var_nombres, var_apellidos, var_colonia, var_calle, var_telefono);
			
			SET var_idPersona = LAST_INSERT_ID();
            
            INSERT INTO cliente (limiteCredito, creditoDisponible, idPersona)
				VALUES (var_limiteCredito, var_limiteCredito, var_idPersona);
                
		COMMIT;
	END
    //
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_modificarCliente;

DELIMITER //
CREATE PROCEDURE SP_modificarCliente(
IN var_idCliente INT,
IN var_nombres VARCHAR(50),
IN var_apellidos VARCHAR(50),
IN var_colonia VARCHAR(50),
IN var_calle VARCHAR(50),
IN var_telefono VARCHAR(20),
IN var_limiteCredito DOUBLE(7,2),
IN var_creditoDisponible DOUBLE(7,2))
	BEGIN

		DECLARE var_idPersona INT;
		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;

		START TRANSACTION;
        
			SELECT idPersona
            FROM cliente
            WHERE idCliente = var_idCliente
            INTO var_idPersona;
            
            UPDATE persona SET
				nombres = var_nombres, apellidos = var_apellidos, colonia = var_colonia, calle = var_calle, telefono = var_telefono
			WHERE idPersona = var_idPersona;
            
            UPDATE cliente SET
				limiteCredito = var_limiteCredito, creditoDisponible = var_creditoDisponible
			WHERE idCliente = var_idCliente;
                
		COMMIT;
	END
    //
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_eliminarCliente;

DELIMITER //
CREATE PROCEDURE SP_eliminarCliente(
IN var_idCliente INT)
	BEGIN

		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;

		START TRANSACTION;
            
            UPDATE cliente SET
				activo = FALSE
			WHERE idCliente = var_idCliente;
                
		COMMIT;
	END
    //
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_modificarUnidadMedida;

DELIMITER //
CREATE PROCEDURE SP_modificarUnidadMedida(
IN var_unidadMedida VARCHAR(20),
IN var_activo BOOLEAN)
	BEGIN

		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;

		START TRANSACTION;
            
            UPDATE unidadMedida SET
				activo = var_activo
            WHERE unidadMedida = var_unidadMedida;
                
		COMMIT;
	END
    //
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_registrarDepartamento;

DELIMITER //
CREATE PROCEDURE SP_registrarDepartamento(
IN var_departamento VARCHAR(30))
	BEGIN

		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;

		START TRANSACTION;
            
            INSERT INTO departamento (departamento) VALUES (var_departamento);
                
		COMMIT;
	END
    //
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_registrarProducto;

DELIMITER //
CREATE PROCEDURE SP_registrarProducto(
IN var_codigoBarras INT,
IN var_nombre VARCHAR(50),
IN var_tipoVenta VARCHAR(30),
IN var_precioCompra DOUBLE(8,2),
IN var_precioVenta DOUBLE(8,2),
IN var_precioMayoreo DOUBLE(8,2),
IN var_unidadMedida VARCHAR(20),
IN var_cantidad DOUBLE(8,3),
IN var_departamento VARCHAR(30))
	BEGIN

		DECLARE var_idTipoVenta INT;
        DECLARE var_idUnidadMedida INT;
        DECLARE var_idDepartamento INT;
		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;

		START TRANSACTION;
            
			SELECT idTipoVenta
            FROM tipoVenta
            WHERE tipoVenta = var_tipoVenta
            INTO var_idTipoVenta;
            
            SELECT idUnidadMedida
            FROM unidadMedida
            WHERE unidadMedida = var_unidadMedida
            INTO var_idUnidadMedida;
            
            SELECT idDepartamento
            FROM departamento
            WHERE departamento = var_departamento
            INTO var_idDepartamento;
            
            INSERT INTO producto (codigoBarras, nombre, idTipoVenta, precioCompra, precioVenta, precioMayoreo, idUnidadMedida, cantidad, idDepartamento)
				VALUES (var_codigoBarras, var_nombre, var_idTipoVenta, var_precioCompra, var_precioVenta, var_precioMayoreo, var_idUnidadMedida, var_cantidad, var_idDepartamento);
                
		COMMIT;
	END
    //
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_eliminarProducto;

DELIMITER //
CREATE PROCEDURE SP_eliminarProducto(
IN var_codigoBarras INT)
	BEGIN

		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;

		START TRANSACTION;
            
			UPDATE producto SET
				activo = FALSE
			WHERE codigoBarras = var_codigoBarras;
                
		COMMIT;
	END
    //
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_modificarProducto;

DELIMITER //
CREATE PROCEDURE SP_modificarProducto(
IN var_codigoBarras INT,
IN var_nombre VARCHAR(50),
IN var_tipoVenta VARCHAR(30),
IN var_precioCompra DOUBLE(8,2),
IN var_precioVenta DOUBLE(8,2),
IN var_precioMayoreo DOUBLE(8,2),
IN var_unidadMedida VARCHAR(20),
IN var_cantidad DOUBLE(8,3),
IN var_departamento VARCHAR(30))
	BEGIN

		DECLARE var_idTipoVenta INT;
        DECLARE var_idUnidadMedida INT;
        DECLARE var_idDepartamento INT;
		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;

		START TRANSACTION;
            
			SELECT idTipoVenta
            FROM tipoVenta
            WHERE tipoVenta = var_tipoVenta
            INTO var_idTipoVenta;
            
            SELECT idUnidadMedida
            FROM unidadMedida
            WHERE unidadMedida = var_unidadMedida
            INTO var_idUnidadMedida;
            
            SELECT idDepartamento
            FROM departamento
            WHERE departamento = var_departamento
            INTO var_idDepartamento;
            
            UPDATE producto SET
				nombre = var_nombre, idTipoVenta = var_idTipoVenta, 
					precioCompra = var_precioCompra, precioVenta = var_precioVenta, 
                    precioMayoreo = var_precioMayoreo, idUnidadMedida = var_idUnidadMedida,
                    cantidad = var_cantidad, idDepartamento = var_idDepartamento
			WHERE codigoBarras = var_codigoBarras;
                
		COMMIT;
	END
    //
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_registrarPerfil;

DELIMITER //
CREATE PROCEDURE SP_registrarPerfil(
IN var_perfil VARCHAR(30),
IN var_aplicaMayoreo BOOLEAN,
IN var_historialVentas BOOLEAN,
IN var_registroSalidas BOOLEAN,
IN var_cobrar BOOLEAN,
IN var_cobrarCredito BOOLEAN,
IN var_cobrarVenta BOOLEAN,
IN var_eliminarArticuloVenta BOOLEAN,
IN var_facturar BOOLEAN,
IN var_verFacturas BOOLEAN,
IN var_administrarCredito BOOLEAN,
IN var_crearCliente BOOLEAN,
IN var_eliminarCliente BOOLEAN,
IN var_modificarCliente BOOLEAN,
IN var_crearProductos BOOLEAN,
IN var_modificarProductos BOOLEAN,
IN var_eliminarProductos BOOLEAN,
IN var_verVentas BOOLEAN,
IN var_agregarMercancia BOOLEAN,
IN var_modificarInventario BOOLEAN,
IN var_verReporteExistencias BOOLEAN,
IN var_realizarCorteTurno BOOLEAN,
IN var_verGanancias BOOLEAN,
IN var_cambiarConfiguraciones BOOLEAN,
IN var_cambiarPermisos BOOLEAN)
	BEGIN
		
        DECLARE var_idPermisos INT;
        DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;
		
        START TRANSACTION;
        
			INSERT INTO permisos (aplicaMayoreo, historialVentas, registroSalidas, cobrar, 
					cobrarCredito, cobrarVenta, eliminarArticuloVenta, facturar, verFacturas, 
                    administrarCredito, crearCliente, eliminarCliente, modificarCliente, crearProductos, 
                    modificarProductos, eliminarProductos, verVentas, agregarMercancia, modificarInventario, 
                    verReporteExistencias, realizarCorteTurno, verGanancias, cambiarConfiguraciones, 
                    cambiarPermisos)
				VALUES (var_aplicaMayoreo, var_historialVentas, var_registroSalidas, var_cobrar, 
					var_cobrarCredito, var_cobrarVenta, var_eliminarArticuloVenta, var_facturar, 
					var_verFacturas, var_administrarCredito, var_crearCliente, var_eliminarCliente, 
                    var_modificarCliente, var_crearProductos, var_modificarProductos, var_eliminarProductos, 
                    var_verVentas, var_agregarMercancia, var_modificarInventario, var_verReporteExistencias, 
                    var_realizarCorteTurno, var_verGanancias, var_cambiarConfiguraciones, var_cambiarPermisos);
                    
			SET var_idPermisos = last_insert_id();
            
            INSERT INTO perfiles (perfil, idPermiso) VALUES (var_perfil, var_idPermisos);
            
        COMMIT;
		 
    END
    //
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_modificarPerfil;

DELIMITER //
CREATE PROCEDURE SP_modificarPerfil(
IN var_idPerfil INT,
IN var_perfil VARCHAR(30),
IN var_aplicaMayoreo BOOLEAN,
IN var_historialVentas BOOLEAN,
IN var_registroSalidas BOOLEAN,
IN var_cobrar BOOLEAN,
IN var_cobrarCredito BOOLEAN,
IN var_cobrarVenta BOOLEAN,
IN var_eliminarArticuloVenta BOOLEAN,
IN var_facturar BOOLEAN,
IN var_verFacturas BOOLEAN,
IN var_administrarCredito BOOLEAN,
IN var_crearCliente BOOLEAN,
IN var_eliminarCliente BOOLEAN,
IN var_modificarCliente BOOLEAN,
IN var_crearProductos BOOLEAN,
IN var_modificarProductos BOOLEAN,
IN var_eliminarProductos BOOLEAN,
IN var_verVentas BOOLEAN,
IN var_agregarMercancia BOOLEAN,
IN var_modificarInventario BOOLEAN,
IN var_verReporteExistencias BOOLEAN,
IN var_realizarCorteTurno BOOLEAN,
IN var_verGanancias BOOLEAN,
IN var_cambiarConfiguraciones BOOLEAN,
IN var_cambiarPermisos BOOLEAN)
	BEGIN
		
        DECLARE var_idPermisos INT;
        DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;
		
        START TRANSACTION;
        
			SELECT idPermiso
            FROM perfiles
            WHERE idPerfil = var_idPerfil
            INTO var_idPermisos;
            
            UPDATE perfiles SET perfil = var_perfil WHERE idPerfil = var_idPerfil;
        
			UPDATE permisos SET 
				aplicaMayoreo = var_aplicaMayoreo, historialVentas = var_historialVentas, registroSalidas = var_registroSalidas, cobrar = var_cobrar, 
				cobrarCredito = var_cobrarCredito, cobrarVenta = var_cobrarVenta, eliminarArticuloVenta = var_eliminarArticuloVenta, facturar = var_facturar, 
				verFacturas = var_verFacturas, administrarCredito = var_administrarCredito, crearCliente = var_crearCliente, eliminarCliente = var_eliminarCliente, 
				modificarCliente = var_modificarCliente, crearProductos = var_crearProductos, modificarProductos = var_modificarProductos, eliminarProductos = var_eliminarProductos, 
				verVentas = var_verVentas, agregarMercancia = var_agregarMercancia, modificarInventario = var_modificarInventario, verReporteExistencias = var_verReporteExistencias, 
				realizarCorteTurno = var_realizarCorteTurno, verGanancias = var_verGanancias, cambiarConfiguraciones = var_cambiarConfiguraciones, cambiarPermisos = var_cambiarPermisos
			WHERE idPermiso = var_idPermisos;
            
        COMMIT;
		 
    END
    //
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_registrarUsuario;

DELIMITER //
CREATE PROCEDURE SP_registrarUsuario(
IN var_nombres VARCHAR(50),
IN var_apellidos VARCHAR(50),
IN var_colonia VARCHAR(50),
IN var_calle VARCHAR(50),
IN var_telefono VARCHAR(20),
IN var_perfil VARCHAR(30),
OUT var_usuario VARCHAR(30))
	BEGIN
    
		DECLARE var_idPersona INT;
		DECLARE var_idPerfil INT;
		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;

		START TRANSACTION;
        
			INSERT INTO persona (nombres, apellidos, colonia, calle, telefono)
				VALUES (var_nombres, var_apellidos, var_colonia, var_calle, var_telefono);
			
			SET var_idPersona = LAST_INSERT_ID();
            
            SELECT idPerfil
            FROM perfiles
            WHERE perfil = var_perfil
            INTO var_idPerfil;
            
            INSERT INTO usuario (idPerfil, idPersona) VALUES (var_idPerfil, var_idPersona);
            
            SELECT usuario
            FROM usuario
            WHERE idUsuario = last_insert_id()
            INTO var_usuario;
            
        COMMIT;
    END
	//
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_registrarSalidas;

DELIMITER //
CREATE PROCEDURE SP_registrarSalidas(
IN var_razon VARCHAR(100),
IN var_cantidad DOUBLE(8,2))
	
    BEGIN
    
		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;
            
		START TRANSACTION;
        
			INSERT INTO salidas (razon, cantidad) VALUES (var_razon, var_cantidad);
            
        COMMIT;
    END
    //
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_registrarVenta;

DELIMITER //
CREATE PROCEDURE SP_registrarVenta(
IN var_idUsuario INT,
IN var_total DOUBLE (8,2),
OUT var_idVenta INT)
	BEGIN
    
		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;
            
		START TRANSACTION;
        
			INSERT INTO venta (fecha, idUsuario, total) VALUES (now(), var_idUsuario, var_total);
			SET var_idVenta = last_insert_id();
        
        COMMIT;
	END
    //
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_registrarDetalleVenta;

DELIMITER //

CREATE PROCEDURE SP_registrarDetalleVenta(
IN var_idProducto INT,
IN var_cantidad DOUBLE(8,3),
IN var_precio DOUBLE(8,2),
IN var_idVenta INT)
BEGIN
	
    DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;
            
    START TRANSACTION;
    
		INSERT INTO detalleVenta (idProducto, cantidad, precio, idVenta)
			VALUES (var_idProducto, var_cantidad, var_precio, var_idVenta);
    
    COMMIT;
END
//
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_cancelarVenta;

DELIMITER //

CREATE PROCEDURE SP_cancelarVenta(
IN var_idVenta INT)
BEGIN

	DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;
            
	START TRANSACTION;
    
		UPDATE venta SET cancelada = TRUE WHERE idVenta = var_idVenta;
    
	COMMIT;
END
//
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_registrarVentaCredito;

DELIMITER //
CREATE PROCEDURE SP_registrarVentaCredito(
IN var_idUsuario INT,
IN var_total DOUBLE (8,2),
IN var_idCliente INT,
OUT var_idVenta INT)
	BEGIN
    
		DECLARE var_creditoActual DOUBLE (7,2);
		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;
            
		START TRANSACTION;

			SELECT creditoDisponible 
            FROM cliente WHERE idCliente = var_idCliente 
            INTO var_creditoActual;
            
			IF var_creditoActual >= var_total THEN
				CALL SP_registrarVenta(var_idUsuario, var_total, @var_idC);
				
				SET var_idVenta = @var_idC;
				
				INSERT INTO ventaCredito (idVenta, idCliente)
					VALUES (var_idVenta, var_idCliente);
                    
				UPDATE cliente SET creditoDisponible = var_creditoActual - var_total WHERE idCliente = var_idCliente;
			END IF;
            
        COMMIT;
	END
    //
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_registrarVentaEfectivo;

DELIMITER //
CREATE PROCEDURE SP_registrarVentaEfectivo(
IN var_idUsuario INT,
IN var_efectivo DOUBLE(8,2),
IN var_total DOUBLE (8,2),
OUT var_idVenta INT)
	BEGIN
    
		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;
            
		START TRANSACTION;
        
			CALL SP_registrarVenta(var_idUsuario, var_total, @var_idC);
			
			SET var_idVenta = @var_idC;
			
			INSERT INTO ventaEfectivo (efectivo, idVenta)
				VALUES (var_efectivo, var_idVenta);
            
        COMMIT;
	END
    //
DELIMITER ;


DROP PROCEDURE IF EXISTS SP_registrarVentaMixta;

DELIMITER //
CREATE PROCEDURE SP_registrarVentaMixta(
IN var_idUsuario INT,
IN var_efectivo DOUBLE(8,2),
IN var_total DOUBLE (8,2),
IN var_referencia VARCHAR(20),
OUT var_idVenta INT)
	BEGIN
    
		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;
            
		START TRANSACTION;
        
			CALL SP_registrarVenta(var_idUsuario, var_total, @var_idC);
			
			SET var_idVenta = @var_idC;
			
			INSERT INTO ventaMixta (efectivo, referencia, idVenta)
				VALUES (var_efectivo, var_referencia, var_idVenta);
            
        COMMIT;
	END
    //
DELIMITER ;


DROP PROCEDURE SP_registrarVentaTarjeta;

DELIMITER //
CREATE PROCEDURE SP_registrarVentaTarjeta()
	BEGIN

		DECLARE EXIT HANDLER FOR SQLEXCEPTION
			BEGIN
				-- ERROR
				ROLLBACK;
			END;
		DECLARE EXIT HANDLER FOR SQLWARNING
			BEGIN
				-- WARNING
				ROLLBACK;
			END;
            
		START TRANSACTION;
        
			
        
        COMMIT;
END ;

DELIMITER ;


/*Creación de "triggers"*/
DROP TRIGGER IF EXISTS T_registrarUsuario;

DELIMITER //
CREATE TRIGGER T_registrarUsuario BEFORE INSERT ON usuario FOR EACH ROW
	BEGIN
		
        DECLARE var_id INT;
    
		SELECT  AUTO_INCREMENT into var_id
		FROM information_schema.tables
		WHERE Table_SCHEMA = "BD2_Integradora" AND table_name = "Empleado";
        
        SET NEW.usuario = CONCAT('emp_', var_id);
        SET NEW.contrasenia = CONCAT('emp_', var_id);
        
    END
    //
DELIMITER ;


/*Creación de vistas*/
DROP VIEW IF EXISTS V_verClientesActivos;

CREATE VIEW V_verClientesActivos AS (
	SELECT c.idCliente, p.nombres, p.apellidos, p.colonia, p.calle, p.telefono, c.limiteCredito, c.creditoDisponible
    FROM cliente AS c INNER JOIN persona AS p ON c.idPersona = p.idPersona
    WHERE c.activo = TRUE
);


DROP VIEW IF EXISTS V_verClientesInactivos;

CREATE VIEW V_verClientesInactivos AS (
	SELECT c.idCliente, p.nombres, p.apellidos, p.colonia, p.calle, p.telefono, c.limiteCredito, c.creditoDisponible
    FROM cliente AS c INNER JOIN persona AS p ON c.idPersona = p.idPersona
    WHERE c.activo = FALSE
);


DROP VIEW IF EXISTS V_verClientesTodos;

CREATE VIEW V_verClientesTodos AS (
	SELECT c.idCliente, p.nombres, p.apellidos, p.colonia, p.calle, p.telefono, c.limiteCredito, c.creditoDisponible, c.activo
    FROM cliente AS c INNER JOIN persona AS p ON c.idPersona = p.idPersona
);


DROP VIEW IF EXISTS V_verProductos;

CREATE VIEW V_verProductos AS (
	SELECT p.codigoBarras, p.nombre, t.tipoVenta, p.precioCompra, p.precioVenta, p.precioMayoreo, u.unidadMedida, p.cantidad, d.departamento
    FROM departamento AS d INNER JOIN (tipoVenta AS t INNER JOIN (unidadMedida AS u INNER JOIN  producto AS p ON p.idUnidadMedida = u.idUnidadMedida) ON p.idTipoVenta = t.idTipoVenta) ON p.idDepartamento = d.idDepartamento
    WHERE p.activo = TRUE
);


DROP VIEW IF EXISTS V_verPermisos;

CREATE VIEW V_verPermisos AS (
	SELECT pp.idPerfil, pp.perfil, p.aplicaMayoreo, p.historialVentas, p.registroSalidas, p.cobrar, 
			p.cobrarCredito, p.cobrarVenta, p.eliminarArticuloVenta, p.facturar, p.verFacturas, 
			p.administrarCredito, p.crearCliente, p.eliminarCliente, p.modificarCliente, p.crearProductos, 
			p.modificarProductos, p.eliminarProductos, p.verVentas, p.agregarMercancia, p.modificarInventario, 
			p.verReporteExistencias, p.realizarCorteTurno, p.verGanancias, p.cambiarConfiguraciones, 
			p.cambiarPermisos
	FROM perfiles AS pp INNER JOIN permisos AS p ON pp.idPermiso = p.idPermiso
);


DROP VIEW IF EXISTS V_verVentasTodas;

CREATE VIEW V_verVentasTodas AS (
	SELECT v.idVenta, v.fecha, p.nombres, v.total, v.cancelada
    FROM venta AS v INNER JOIN (usuario AS u INNER JOIN persona AS p ON u.idPersona = p.idPersona) ON v.idUsuario = u.idUsuario 
);


DROP VIEW IF EXISTS V_verVentasCanceladas;

CREATE VIEW V_verVentasCanceladas AS (
	SELECT v.idVenta, v.fecha, p.nombres, v.total
    FROM venta AS v INNER JOIN (usuario AS u INNER JOIN persona AS p ON u.idPersona = p.idPersona) ON v.idUsuario = u.idUsuario 
    WHERE v.cancelada = TRUE
);


DROP VIEW IF EXISTS V_verVentasActivas;

CREATE VIEW V_verVentasActivas AS (
	SELECT v.idVenta, v.fecha, p.nombres, v.total, v.cancelada
    FROM venta AS v INNER JOIN (usuario AS u INNER JOIN persona AS p ON u.idPersona = p.idPersona) ON v.idUsuario = u.idUsuario 
    WHERE v.cancelada = FALSE
);


DROP VIEW IF EXISTS V_login;

CREATE VIEW V_login AS (
	SELECT u.idUsuario, u.usuario, u.contrasenia, pe.nombres, pp.idPerfil, pp.perfil
	FROM persona AS pe INNER JOIN (usuario AS u INNER JOIN (perfiles AS pp INNER JOIN permisos AS p ON pp.idPermiso = p.idPermiso)
			ON u.idPerfil = pp.idPerfil) ON pe.idPersona = u.idPersona
);


/*Pruebas*/
-- procedures
-- insertar cliente
CALL SP_registrarCliente('Hugo Francisco', 'Martínez Pérez', 'Jardines de santa julia', 'arboleda de jerez', '4773395375', 7000);
SELECT * FROM persona;
SELECT * FROM cliente;


-- modificar cliente
CALL SP_modificarCliente(1, 'Hugo Francisco 2', 'Martínez Pérez', 'Jardines de santa julia', 'arboleda de jerez', '4773395375', 8000, 5000);
SELECT * FROM persona;
SELECT * FROM cliente;


-- eliminar cliente
CALL SP_eliminarCliente(1);


-- insertar tipo de venta
INSERT INTO tipoVenta (tipoVenta) VALUES ('UNIDAD / PZA');
INSERT INTO tipoVenta (tipoVenta) VALUES ('A GRANEL (usa decimales)');
INSERT INTO tipoVenta (tipoVenta) VALUES ('PAQUETE (kit)');
SELECT * FROM tipoVenta;


-- insertar unidad de medida
INSERT INTO unidadMedida (unidadMedida, activo) VALUES ('H / MIN', TRUE);
SELECT * FROM unidadMedida;


-- modificar unidad de medida
CALL SP_modificarUnidadMedida('H / MIN', FALSE);
SELECT * FROM unidadMedida;


-- insertar departamento
CALL SP_registrarDepartamento('Urrea');


-- insertar producto
CALL SP_registrarProducto(11113, 'Manguera', 'PAQUETE (kit)', 100, 115, 110, 'H / MIN', 3, 'Urrea');

-- eliminar producto
CALL SP_eliminarProducto(11111);


-- modificar producto
CALL SP_modificarProducto(11111, 'Manguera 2', 'PAQUETE (kit)', 1001, 1151, 1101, 'H / MIN', 4, 'Urrea');


-- registrar perfil 
CALL SP_registrarPerfil('admin', TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE);
SELECT * FROM permisos;
SELECT * FROM perfiles;


-- modificar perfil
CALL SP_modificarPerfil(1, 'admin', TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE, TRUE);
SELECT * FROM perfiles;


-- registrar usuario
CALL SP_registrarUsuario('el aaron', 'fonseca', '5 de mayo', 'chichimequillas', '4721054538', 'admin', @var_usuario);
SELECT * FROM usuario;
SELECT @var_usuario;


-- registrar salida
CALL SP_registrarSalidas('gasolina', 5000);
SELECT * FROM salidas;


-- registrar venta
CALL SP_registrarVenta(1, 100, @idVenta);
SELECT * FROM venta;


-- registrar detalle de venta
CALL SP_registrarDetalleVenta(1, 2, 200, @idVenta);
SELECT * FROM detalleVenta;


-- cancelar venta
CALL SP_cancelarVenta(1);


-- registrar venta credito
CALL SP_registrarVentaCredito(1, 200, 1, @var_idVC);
SELECT @var_idV;
SELECT * FROM venta;
SELECT * FROM ventaCredito;


-- registrar venta efectivo
CALL SP_registrarVentaEfectivo(1, 500, 300, @var_idVE);
SELECT @var_idVE;
SELECT * FROM venta;
SELECT * FROM ventaEfectivo;


-- registro venta mixta
CALL SP_registrarVentaMixta(1, 500, 1000, '1234 5678 9123 4567', @var_idVM);
SELECT @var_idVM;
SELECT * FROM venta;
SELECT * FROM ventaMixta;


-- registro venta tarjeta
CALL SP_registrarVentaTarjeta();


-- vistas
SELECT * FROM V_verClientesActivos;
SELECT * FROM V_verClientesInactivos;
SELECT * FROM V_verClientesTodos;
SELECT * FROM V_verProductos;
SELECT * FROM V_verPermisos;
SELECT * FROM V_verVentasTodas;
SELECT * FROM V_verVentasCanceladas;
SELECT * FROM V_verVentasActivas;
SELECT * FROM V_login;