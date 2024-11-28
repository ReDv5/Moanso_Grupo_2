create Database Proyecto_G2
use database Proyecto_G2

CREATE TABLE Proveedor(
    proveedor_id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    contacto VARCHAR(50),
    telefono INT,
    direccion VARCHAR(200),
	estado VARCHAR(15)
);

CREATE TABLE Rol(
    rol_id INT IDENTITY(1,1) PRIMARY KEY,
	nombre VARCHAR(20)
);

CREATE TABLE Tienda (
    tienda_id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    ubicacion VARCHAR(255) NOT NULL
);

CREATE TABLE Empleado(
    empleado_id INT IDENTITY(1,1) PRIMARY KEY,
	nombre VARCHAR(50),
	apellido VARCHAR(50),
	telefono INT,
    contacto VARCHAR(50),
	estado VARCHAR(10),
	rol_id INT FOREIGN KEY REFERENCES Rol(rol_id),
	tienda_id INT FOREIGN KEY REFERENCES Tienda(tienda_id)
)

CREATE TABLE Almacen (
    almacen_id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
	ubicacion VARCHAR(100),
	tienda_id INT FOREIGN KEY REFERENCES Tienda(tienda_id)
);

CREATE TABLE CategoriaProducto (
    categoria_id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(30) NOT NULL,
    descripcion TEXT
);

CREATE TABLE Producto (
    producto_id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    descripcion TEXT,
    precio_unidad DECIMAL(10, 2) NOT NULL,
	estado VARCHAR(15),
	categoria_id INT FOREIGN KEY REFERENCES CategoriaProducto(categoria_id)
);

CREATE TABLE Inventario (
    inventario_id INT IDENTITY(1,1) PRIMARY KEY,
    stock INT NOT NULL DEFAULT 0,
	almacen_id INT FOREIGN KEY REFERENCES Almacen(almacen_id),
    producto_id INT FOREIGN KEY REFERENCES Producto(producto_id)
);

CREATE TABLE Compra (
    compra_id INT IDENTITY(1,1) PRIMARY KEY,
    fecha DATE,
    total DECIMAL(10, 2) NOT NULL,
	estado VARCHAR(15),
    proveedor_id INT FOREIGN KEY REFERENCES Proveedor(proveedor_id)
);

CREATE TABLE DetalleCompra (
    compra_id INT NOT NULL,
    producto_id INT NOT NULL,
    cantidad INT NOT NULL,
    subtotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (compra_id) REFERENCES Compra(compra_id),
    FOREIGN KEY (producto_id) REFERENCES Producto(producto_id)
);

CREATE TABLE Traslado (
    traslado_id INT IDENTITY(1,1) PRIMARY KEY,
    fecha DATE,
    estado VARCHAR(50) NOT NULL DEFAULT 'Pendiente',
    almacen_origen_id INT FOREIGN KEY REFERENCES Almacen(almacen_id),
    almacen_destino_id INT FOREIGN KEY REFERENCES Almacen(almacen_id)
);

CREATE TABLE DetalleTraslado (
    traslado_id INT NOT NULL,
    producto_id INT NOT NULL,
    cantidad INT NOT NULL,
    FOREIGN KEY (traslado_id) REFERENCES Traslado(traslado_id),
    FOREIGN KEY (producto_id) REFERENCES Producto(producto_id)
);





------------Rol
CREATE PROCEDURE spListarRol
AS
BEGIN
    SELECT rol_id, nombre
    FROM Rol;
END;


CREATE PROCEDURE spAgregarRol
    @nombre VARCHAR(20)
AS
BEGIN
    INSERT INTO Rol (nombre)
    VALUES (@nombre);
END;


CREATE PROCEDURE spEditaRol
    @rol_id INT,
    @nombre VARCHAR(20)
AS
BEGIN
    UPDATE Rol
    SET nombre = @nombre
    WHERE rol_id = @rol_id;
END;



-----------------Tienda

CREATE or alter PROCEDURE spListarTienda
AS
BEGIN
    SELECT tienda_id, nombre, ubicacion
    FROM Tienda;
END;




CREATE PROCEDURE spAgregarTienda
    @nombre VARCHAR(100),
    @ubicacion VARCHAR(255)
AS
BEGIN
    INSERT INTO Tienda (nombre, ubicacion)
    VALUES (@nombre, @ubicacion);
END;



CREATE or alter PROCEDURE spModificarTienda
    @tienda_id INT,
    @nombre VARCHAR(100),
    @ubicacion VARCHAR(255)
AS
BEGIN
    UPDATE Tienda
    SET nombre = @nombre,
        ubicacion = @ubicacion
    WHERE tienda_id = @tienda_id;
END;


-----------Proveedor

CREATE or alter PROCEDURE spListarProveedor
AS
BEGIN
    SELECT proveedor_id, nombre, contacto, telefono, direccion, estado
    FROM Proveedor;
END;



CREATE PROCEDURE spAgregarProveedor
    @nombre VARCHAR(100),
    @contacto VARCHAR(50),
	@telefono int,
	@direccion VARCHAR(200),
	@estado VARCHAR(15)
AS
BEGIN
    INSERT INTO Proveedor(nombre, contacto, telefono, direccion, estado)
    VALUES (@nombre, @contacto, @telefono, @direccion, @estado);
END;


CREATE or alter PROCEDURE spEditaProveedor
    @proveedor_id INT,
    @nombre VARCHAR(100),
    @contacto VARCHAR(50),
	@telefono int,
	@direccion VARCHAR(200),
	@estado VARCHAR(15)
AS
BEGIN
    UPDATE Proveedor
    SET nombre = @nombre,
        contacto = @contacto,
		telefono = @telefono,
		direccion = @direccion,
		estado = @estado
    WHERE @proveedor_id = @proveedor_id;
END;


-----------------Porducto
CREATE or alter PROCEDURE spListarProducto
AS
BEGIN
    SELECT producto_id, nombre, descripcion, precio_unidad, estado, categoria_id
    FROM Producto;
END;



CREATE PROCEDURE spAgregarProducto
    @nombre VARCHAR(50),
    @descripcion TEXT,
	@precio_unidad DECIMAL(10, 2),
	@estado VARCHAR(15),
	@categoria_id INT
AS
BEGIN
    INSERT INTO Producto(nombre, descripcion, precio_unidad, estado, categoria_id)
    VALUES (@nombre, @descripcion, @precio_unidad, @estado, @categoria_id);
END;


CREATE or alter PROCEDURE spModificarProducto
    @producto_id INT,
    @nombre VARCHAR(50),
    @descripcion TEXT,
	@precio_unidad DECIMAL(10, 2),
	@estado VARCHAR(15),
	@categoria_id INT
AS
BEGIN
    UPDATE Producto
    SET nombre = @nombre,
        descripcion = @descripcion,
		precio_unidad = @precio_unidad,
		estado = @estado,
		categoria_id = @categoria_id
    WHERE @producto_id = @producto_id;
END;
--------------------------------------------------

CREATE PROCEDURE MostrarProductosBajoStock
AS
BEGIN
    SELECT 
        p.producto_id,
        p.nombre AS producto_nombre,
        i.stock AS stock_actual,
        a.nombre AS almacen_nombre,
        a.ubicacion AS almacen_ubicacion
    FROM 
        Producto p
    INNER JOIN Inventario i ON p.producto_id = i.producto_id
    INNER JOIN Almacen a ON i.almacen_id = a.almacen_id
    WHERE 
        i.stock <= 20; -- Considerar productos con stock igual o menor a 20
END;



CREATE TRIGGER ActualizarInventarioDespuesDeCompra
ON DetalleCompra
AFTER INSERT
AS
BEGIN
    -- Actualizar el stock del inventario para los productos comprados
    UPDATE i
    SET i.stock = i.stock + dc.cantidad
    FROM Inventario i
    INNER JOIN Producto p ON i.producto_id = p.producto_id
    INNER JOIN Almacen a ON i.almacen_id = a.almacen_id
	INNER JOIN DetalleCompra d on d.producto_id = p.producto_id
	INNER JOIN Compra c on c.compra_id = d.compra_id
    INNER JOIN Inserted dc ON dc.producto_id = i.producto_id;
END;



CREATE TRIGGER ActualizarStockCompraAnulada
ON Compra
AFTER UPDATE
AS
BEGIN
    -- Verificar que el estado de la compra cambió a 'Anulada'
    IF EXISTS (
        SELECT 1
        FROM Inserted i
        INNER JOIN Deleted d ON i.compra_id = d.compra_id
        WHERE i.estado = 'Anulada' AND d.estado <> 'Anulada'
    )
    BEGIN
        -- Actualizar el stock del inventario restando las cantidades de la compra
        UPDATE i
        SET i.stock = i.stock - dc.cantidad
        FROM Inventario i
        INNER JOIN DetalleCompra dc ON i.producto_id = dc.producto_id
        INNER JOIN Inserted c ON c.compra_id = dc.compra_id
        WHERE i.stock - dc.cantidad >= -1; -- Solo si el stock resultante es mayor o igual a -1
    END
END;



CREATE TRIGGER CrearInventarioCuandoSeCreaAlmacen
ON Almacen
AFTER INSERT
AS
BEGIN
    -- Insertar inventarios para cada producto existente al crear un nuevo almacén
    INSERT INTO Inventario (stock, almacen_id, producto_id)
    SELECT 0, i.almacen_id, p.producto_id
    FROM Producto p
    CROSS JOIN Inserted i -- "Inserted" contiene los nuevos almacenes creados
    WHERE i.almacen_id = i.almacen_id;
END;


CREATE TRIGGER ActualizarStockDespuesDeTraslado
ON DetalleTraslado
AFTER INSERT
AS
BEGIN
    -- Variables para almacenar los datos del traslado
    DECLARE @producto_id INT, @cantidad INT, @almacen_origen_id INT, @almacen_destino_id INT;

    -- Obtener los datos del traslado desde la tabla Inserted
    SELECT @producto_id = i.producto_id, 
           @cantidad = i.cantidad,
           @almacen_origen_id = t.almacen_origen_id,
           @almacen_destino_id = t.almacen_destino_id
    FROM Inserted i
    JOIN Traslado t ON i.traslado_id = t.traslado_id;

    -- Actualizar el stock del almacén de origen (restar la cantidad trasladada)
    UPDATE Inventario
    SET stock = stock - @cantidad
    WHERE almacen_id = @almacen_origen_id AND producto_id = @producto_id;

    -- Actualizar el stock del almacén de destino (sumar la cantidad trasladada)
    UPDATE Inventario
    SET stock = stock + @cantidad
    WHERE almacen_id = @almacen_destino_id AND producto_id = @producto_id;
END;





