CREATE DATABASE db_tf
GO

USE db_tf
GO

-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2024-06-16 01:15:39.611

-- tables
-- Table: Boleta
CREATE TABLE Boleta (
    idBoleta int  NOT NULL IDENTITY,
    FechaEmision datetime  NOT NULL,
    Total decimal(4,2)  NOT NULL,
    Eliminado bit  NOT NULL,
    UsuarioCreadorId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificadorId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    idSucursal int  NOT NULL,
    CONSTRAINT Boleta_pk PRIMARY KEY  (idBoleta)
);

-- Table: Categoria
CREATE TABLE Categoria (
    idCategoria int  NOT NULL IDENTITY,
    Nombre nvarchar(30)  NOT NULL,
    Eliminado bit  NOT NULL,
    UsuarioCreadorId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificadorId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    CONSTRAINT Categoria_pk PRIMARY KEY  (idCategoria)
);

-- Table: DetalleBoleta
CREATE TABLE DetalleBoleta (
    idDetalleBoleta int  NOT NULL IDENTITY,
    idBoleta int  NOT NULL,
    idProducto int  NOT NULL,
    CantidadProducto int  NOT NULL,
    Subtotal decimal(4,2)  NOT NULL,
    UsuarioCreadorId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificadorId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    CONSTRAINT DetalleBoleta_pk PRIMARY KEY  (idDetalleBoleta)
);

-- Table: Inventario
CREATE TABLE Inventario (
    idInventario int  NOT NULL IDENTITY,
    StockTotal int  NOT NULL,
    UsuarioCreadorId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificadorId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    idSucursal int  NOT NULL,
    CONSTRAINT Inventario_pk PRIMARY KEY  (idInventario)
);

-- Table: Producto
CREATE TABLE Producto (
    idProducto int  NOT NULL IDENTITY,
    Nombre nvarchar(30)  NOT NULL,
    Descripcion nvarchar(50)  NOT NULL,
    CantidadTotal int  NOT NULL,
    PrecioProducto decimal(4,2)  NOT NULL,
    Eliminado bit  NOT NULL,
    UsuarioCreadorId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificadorId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    idCategoria int  NOT NULL,
    CONSTRAINT Producto_pk PRIMARY KEY  (idProducto)
);

-- Table: ProductoInventario
CREATE TABLE ProductoInventario (
    idProductoInventario int  NOT NULL IDENTITY,
    idProducto int  NOT NULL,
    idInventario int  NOT NULL,
    Stock int  NOT NULL,
    UsuarioCreadorId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificadorId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    CONSTRAINT ProductoInventario_pk PRIMARY KEY  (idProductoInventario)
);

-- Table: Sucursal
CREATE TABLE Sucursal (
    idSucursal int  NOT NULL IDENTITY,
    Nombre nvarchar(50)  NOT NULL,
    Distrito nvarchar(50)  NOT NULL,
    Eliminado bit  NOT NULL,
    UsuarioCreadorId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificacdorId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    CONSTRAINT Sucursal_pk PRIMARY KEY  (idSucursal)
);

-- Table: Vendedor
CREATE TABLE Vendedor (
    idVendedor int  NOT NULL IDENTITY,
    Nombre nvarchar(50)  NOT NULL,
    Apellido nvarchar(50)  NOT NULL,
    NombreUsuario nvarchar(50)  NOT NULL,
    CorreoElectronico nvarchar(80)  NOT NULL,
    Contrasenia nvarchar(15)  NOT NULL,
    Eliminado bit  NOT NULL,
    UsuarioCreadorId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificacdorId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    CONSTRAINT Vendedor_pk PRIMARY KEY  (idVendedor)
);

-- foreign keys
-- Reference: Boleta_Sucursal (table: Boleta)
ALTER TABLE Boleta ADD CONSTRAINT Boleta_Sucursal
    FOREIGN KEY (idSucursal)
    REFERENCES Sucursal (idSucursal);

-- Reference: DetalleBoleta_Boletas (table: DetalleBoleta)
ALTER TABLE DetalleBoleta ADD CONSTRAINT DetalleBoleta_Boletas
    FOREIGN KEY (idBoleta)
    REFERENCES Boleta (idBoleta);

-- Reference: DetalleBoleta_Productos (table: DetalleBoleta)
ALTER TABLE DetalleBoleta ADD CONSTRAINT DetalleBoleta_Productos
    FOREIGN KEY (idProducto)
    REFERENCES Producto (idProducto);

-- Reference: Inventario_Sucursal (table: Inventario)
ALTER TABLE Inventario ADD CONSTRAINT Inventario_Sucursal
    FOREIGN KEY (idSucursal)
    REFERENCES Sucursal (idSucursal);

-- Reference: ProductoInventario_Inventario (table: ProductoInventario)
ALTER TABLE ProductoInventario ADD CONSTRAINT ProductoInventario_Inventario
    FOREIGN KEY (idInventario)
    REFERENCES Inventario (idInventario);

-- Reference: ProductoInventario_Producto (table: ProductoInventario)
ALTER TABLE ProductoInventario ADD CONSTRAINT ProductoInventario_Producto
    FOREIGN KEY (idProducto)
    REFERENCES Producto (idProducto);

-- Reference: Producto_Categoria (table: Producto)
ALTER TABLE Producto ADD CONSTRAINT Producto_Categoria
    FOREIGN KEY (idCategoria)
    REFERENCES Categoria (idCategoria);

-- End of file.

-- Procedimientos
CREATE PROCEDURE ObtenerProductosConMenosStock
    @idSucursal INT
AS
BEGIN
	SELECT	P.idProducto AS [idProducto],
			P.Nombre AS [Nombre],
			P.Descripcion AS [Descripcion],
			T.Stock AS [Stock],
			P.PrecioProducto AS [PrecioProducto]
	FROM Producto P
	INNER JOIN
	(
		SELECT	X.idProducto AS [idProducto], 
				X.Stock AS [Stock]
		FROM ProductoInventario X
		WHERE X.idInventario = 
		(
			SELECT I.idInventario FROM Inventario I
			WHERE I.idSucursal = @idSucursal
		) AND (X.Stock < 10)
	) T
	ON P.idProducto = T.idProducto
END



CREATE PROCEDURE ObtenerProductosMasVendidos
    @idSucursal INT
AS
BEGIN
	SELECT	P.idProducto AS [idProducto],
			P.Nombre AS [Nombre],
			P.Descripcion AS [Descripcion],
			W.nroVentas AS [NroVentas],
			P.PrecioProducto AS [PrecioProducto]
			FROM Producto P
	INNER JOIN
	(SELECT	AparicionesProducto.idProducto AS [idProducto],
		AparicionesProducto.Apariciones AS [nroVentas]
		FROM
		(
			SELECT	X.idProducto AS idProducto,
					COUNT(X.idProducto) AS [Apariciones]
			FROM DetalleBoleta X
			INNER JOIN Boleta B ON X.idBoleta = B.idBoleta
			WHERE B.idSucursal = @idSucursal
			GROUP BY X.idProducto
		) AS AparicionesProducto
		WHERE AparicionesProducto.Apariciones = 
		(
			SELECT MAX(T.Apariciones) FROM
			(
				SELECT	X.idProducto AS idProducto,
						COUNT(X.idProducto) AS [Apariciones]
				FROM DetalleBoleta X
				INNER JOIN Boleta B ON X.idBoleta = B.idBoleta
				WHERE B.idSucursal = @idSucursal
				GROUP BY X.idProducto
			) AS T
		)
	) AS W
	ON W.idProducto = P.idProducto
END


CREATE PROCEDURE ObtenerCategoriasMasVendidos
    @idSucursal INT
AS
BEGIN
	SELECT C.idCategoria AS [idCategoria],
		   C.Nombre AS [Nombre],
		   W.nroVentas AS [NroVentas]
	FROM Categoria C
	INNER JOIN
	(
		SELECT AparicionesCategoria.idCategoria AS [idCategoria],
			   AparicionesCategoria.Apariciones AS [nroVentas]
		FROM
		(
			SELECT P.idCategoria AS idCategoria,
				   COUNT(X.idProducto) AS [Apariciones]
			FROM DetalleBoleta X
			INNER JOIN Boleta B ON X.idBoleta = B.idBoleta
			INNER JOIN Producto P ON X.idProducto = P.idProducto
			WHERE B.idSucursal = @idSucursal
			GROUP BY P.idCategoria
		) AS AparicionesCategoria
		WHERE AparicionesCategoria.Apariciones = 
		(
			SELECT MAX(T.Apariciones) 
			FROM
			(
				SELECT P.idCategoria AS idCategoria,
					   COUNT(X.idProducto) AS [Apariciones]
				FROM DetalleBoleta X
				INNER JOIN Boleta B ON X.idBoleta = B.idBoleta
				INNER JOIN Producto P ON X.idProducto = P.idProducto
				WHERE B.idSucursal = @idSucursal
				GROUP BY P.idCategoria
			) AS T
		)
	) AS W
	ON W.idCategoria = C.idCategoria
END

CREATE PROCEDURE ObtenerSucursalesConMasVentas
AS
BEGIN
	SELECT	S.idSucursal AS [idSucursal],
		S.Nombre AS [Nombre],
		S.Distrito AS [Distrito],
		W.cantidadVentas AS [CantidadVentas]
FROM Sucursal S
INNER JOIN 
(
	SELECT	T.idSucursal,
			T.cantidadVentas
	FROM
	(
		SELECT	S.idSucursal AS [idSucursal],
				COUNT(S.idSucursal) AS [cantidadVentas]
		FROM Boleta B
		INNER JOIN Sucursal S ON B.idSucursal = S.idSucursal
		GROUP BY S.idSucursal
	) AS T
	WHERE T.cantidadVentas =
	(
		SELECT MAX(T.cantidadVentas) 
		FROM
		(
			SELECT	S.idSucursal AS [idSucursal],
					COUNT(S.idSucursal) AS [cantidadVentas]
			FROM Boleta B
			INNER JOIN Sucursal S ON B.idSucursal = S.idSucursal
			GROUP BY S.idSucursal
		) AS T
	)

) AS W
ON W.idSucursal = S.idSucursal
END

------------------------------

INSERT INTO [Sucursal] ("Nombre", "Distrito", "Eliminado", "UsuarioCreadorId", "FechaCreacion", "UsuarioModificacdorId", "FechaModificacion")
VALUES ('Dollarcity La Rambla Brasil', 'Breña', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
       ('Dollarcity Mall Plaza Bellavista', 'Callao', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
       ('Dollarcity San Isidro', 'San Isidro', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
       ('Dollarcity Mega Plaza Norte', 'Independencia', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
       ('Dollarcity Miraflores', 'Miraflores', 0, 1, GETUTCDATE(), 1, GETUTCDATE());
GO

INSERT INTO [Vendedor] ("Nombre", "Apellido", "NombreUsuario", "CorreoElectronico", "Contrasenia", "Eliminado", "UsuarioCreadorId", "FechaCreacion", "UsuarioModificacdorId", "FechaModificacion")
VALUES 
('Cristiano', 'Ronaldo', 'admin', 'cr7@gmail.com', 'admin123', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Maria', 'Gonzalez', 'maria_g', 'maria.gonzalez@example.com', 'maria2024', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Juan', 'Perez', 'juan_p', 'juan.perez@example.com', 'juan2024', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Ana', 'Lopez', 'ana_l', 'ana.lopez@example.com', 'ana2024', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Carlos', 'Ramirez', 'carlos_r', 'carlos.ramirez@example.com', 'carlos2024', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Sofia', 'Martinez', 'sofia_m', 'sofia.martinez@example.com', 'sofia2024', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Luis', 'Hernandez', 'luis_h', 'luis.hernandez@example.com', 'luis2024', 0, 1, GETUTCDATE(), 1, GETUTCDATE());
GO

INSERT INTO [Categoria] ("Nombre", "Eliminado", "UsuarioCreadorId", "FechaCreacion", "UsuarioModificadorId", "FechaModificacion")
VALUES 
('Alimentos y Bebidas', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Hogar y Cocina', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Salud y Belleza', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Juguetes y Juegos', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Papelería y Oficina', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Herramientas y Automotriz', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Electrónica y Accesorios', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Ropa y Accesorios', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Mascotas', 0, 1, GETUTCDATE(), 1, GETUTCDATE()),
('Fiesta y Celebraciones', 0, 1, GETUTCDATE(), 1, GETUTCDATE());
GO

INSERT INTO [Producto] ("Nombre", "Descripcion", "CantidadTotal","PrecioProducto", "Eliminado", "UsuarioCreadorId", "FechaCreacion", "UsuarioModificadorId", "FechaModificacion", "idCategoria")
VALUES 
('Coca Cola', 'Bebida gaseosa refrescante', 150, 1.5, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 1),
('Sartén Antiadherente', 'Sartén de 24 cm con recubrimiento antiadherente', 120, 12.0, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 2),
('Shampoo Herbal', 'Shampoo natural de hierbas 400 ml', 130, 4.5, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 3),
('Muñeca Barbie', 'Muñeca Barbie con accesorios', 110, 15.0, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 4),
('Cuaderno A4', 'Cuaderno A4 de 100 hojas', 170, 2.0, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 5),
('Destornillador Philips', 'Destornillador Philips de 5 pulgadas', 140, 3.0, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 6),
('Auriculares Bluetooth', 'Auriculares inalámbricos con Bluetooth', 115, 20.0, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 7),
('Camiseta Básica', 'Camiseta de algodón talla M', 160, 5.0, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 8),
('Alimento para Perro', 'Bolsa de 2 kg de alimento balanceado para perro', 130, 8.0, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 9),
('Globos de Fiesta', 'Paquete de 20 globos de colores', 180, 1.2, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 10),
('Galletas de Chocolate', 'Paquete de galletas con chispas de chocolate', 140, 2.5, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 1),
('Olla a Presión', 'Olla a presión de 6 litros', 105, 25.0, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 2),
('Jabón Líquido', 'Jabón líquido para manos 500 ml', 160, 3.5, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 3),
('Juego de Mesa', 'Juego de mesa clásico para toda la familia', 120, 10.0, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 4),
('Bolígrafo Azul', 'Paquete de 10 bolígrafos azules', 175, 1.8, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 5),
('Llave Ajustable', 'Llave ajustable de 8 pulgadas', 110, 7.0, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 6),
('Cargador de Teléfono', 'Cargador rápido USB para teléfonos', 130, 15.0, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 7),
('Bufanda de Lana', 'Bufanda de lana unisex', 145, 8.5, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 8),
('Juguete para Gato', 'Ratón de peluche con catnip', 150, 3.0, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 9),
('Velas de Cumpleaños', 'Paquete de 24 velas de cumpleaños', 190, 1.0, 0, 1, GETUTCDATE(), 1, GETUTCDATE(), 10);
GO

INSERT INTO [Inventario] ("StockTotal", "UsuarioCreadorId", "FechaCreacion", "UsuarioModificadorId", "FechaModificacion", "idSucursal")
VALUES 
(0, 1, GETUTCDATE(), 1, GETUTCDATE(), 1),
(0, 1, GETUTCDATE(), 1, GETUTCDATE(), 2),
(0, 1, GETUTCDATE(), 1, GETUTCDATE(), 3),
(0, 1, GETUTCDATE(), 1, GETUTCDATE(), 4),
(0, 1, GETUTCDATE(), 1, GETUTCDATE(), 5);
GO


-- ProductoInventario
-- Inventario 1
INSERT INTO [ProductoInventario] ("idProducto", "idInventario", "Stock", "UsuarioCreadorId", "FechaCreacion", "UsuarioModificadorId", "FechaModificacion")
VALUES
(1, 1, 25, 1, GETUTCDATE(), 1, GETUTCDATE()),
(2, 1, 30, 1, GETUTCDATE(), 1, GETUTCDATE()),
(3, 1, 35, 1, GETUTCDATE(), 1, GETUTCDATE()),
(4, 1, 22, 1, GETUTCDATE(), 1, GETUTCDATE()),
(5, 1, 28, 1, GETUTCDATE(), 1, GETUTCDATE()),
(6, 1, 33, 1, GETUTCDATE(), 1, GETUTCDATE()),
(7, 1, 38, 1, GETUTCDATE(), 1, GETUTCDATE()),
(8, 1, 40, 1, GETUTCDATE(), 1, GETUTCDATE());

-- Inventario 2
INSERT INTO [ProductoInventario] ("idProducto", "idInventario", "Stock", "UsuarioCreadorId", "FechaCreacion", "UsuarioModificadorId", "FechaModificacion")
VALUES
(9, 2, 30, 1, GETUTCDATE(), 1, GETUTCDATE()),
(10, 2, 35, 1, GETUTCDATE(), 1, GETUTCDATE()),
(11, 2, 38, 1, GETUTCDATE(), 1, GETUTCDATE()),
(12, 2, 23, 1, GETUTCDATE(), 1, GETUTCDATE()),
(13, 2, 27, 1, GETUTCDATE(), 1, GETUTCDATE()),
(14, 2, 32, 1, GETUTCDATE(), 1, GETUTCDATE()),
(15, 2, 26, 1, GETUTCDATE(), 1, GETUTCDATE()),
(16, 2, 35, 1, GETUTCDATE(), 1, GETUTCDATE());

-- Inventario 3
INSERT INTO [ProductoInventario] ("idProducto", "idInventario", "Stock", "UsuarioCreadorId", "FechaCreacion", "UsuarioModificadorId", "FechaModificacion")
VALUES
(17, 3, 22, 1, GETUTCDATE(), 1, GETUTCDATE()),
(18, 3, 28, 1, GETUTCDATE(), 1, GETUTCDATE()),
(19, 3, 33, 1, GETUTCDATE(), 1, GETUTCDATE()),
(20, 3, 40, 1, GETUTCDATE(), 1, GETUTCDATE()),
(1, 3, 37, 1, GETUTCDATE(), 1, GETUTCDATE()),
(2, 3, 24, 1, GETUTCDATE(), 1, GETUTCDATE()),
(3, 3, 29, 1, GETUTCDATE(), 1, GETUTCDATE()),
(4, 3, 36, 1, GETUTCDATE(), 1, GETUTCDATE());

-- Inventario 4
INSERT INTO [ProductoInventario] ("idProducto", "idInventario", "Stock", "UsuarioCreadorId", "FechaCreacion", "UsuarioModificadorId", "FechaModificacion")
VALUES
(5, 4, 32, 1, GETUTCDATE(), 1, GETUTCDATE()),
(6, 4, 38, 1, GETUTCDATE(), 1, GETUTCDATE()),
(7, 4, 25, 1, GETUTCDATE(), 1, GETUTCDATE()),
(8, 4, 29, 1, GETUTCDATE(), 1, GETUTCDATE()),
(9, 4, 34, 1, GETUTCDATE(), 1, GETUTCDATE()),
(10, 4, 41, 1, GETUTCDATE(), 1, GETUTCDATE()),
(11, 4, 36, 1, GETUTCDATE(), 1, GETUTCDATE()),
(12, 4, 27, 1, GETUTCDATE(), 1, GETUTCDATE());

-- Inventario 5
INSERT INTO [ProductoInventario] ("idProducto", "idInventario", "Stock", "UsuarioCreadorId", "FechaCreacion", "UsuarioModificadorId", "FechaModificacion")
VALUES
(13, 5, 30, 1, GETUTCDATE(), 1, GETUTCDATE()),
(14, 5, 35, 1, GETUTCDATE(), 1, GETUTCDATE()),
(15, 5, 40, 1, GETUTCDATE(), 1, GETUTCDATE()),
(16, 5, 23, 1, GETUTCDATE(), 1, GETUTCDATE()),
(17, 5, 27, 1, GETUTCDATE(), 1, GETUTCDATE()),
(18, 5, 32, 1, GETUTCDATE(), 1, GETUTCDATE()),
(19, 5, 26, 1, GETUTCDATE(), 1, GETUTCDATE()),
(20, 5, 35, 1, GETUTCDATE(), 1, GETUTCDATE());
GO