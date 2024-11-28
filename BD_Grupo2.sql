<<<<<<< HEAD
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



------------------ CategoríasProductos


-- Listar Categorías
CREATE OR ALTER PROCEDURE spListarCategoriaProducto
AS
BEGIN
    SELECT categoria_id, nombre, descripcion
    FROM CategoriaProducto;
END;

-- Agregar Categoría
CREATE OR ALTER PROCEDURE spAgregarCategoriaProducto
    @nombre VARCHAR(30),
    @descripcion TEXT
AS
BEGIN
    INSERT INTO CategoriaProducto (nombre, descripcion)
    VALUES (@nombre, @descripcion);
END;

-- Modificar Categoría
CREATE OR ALTER PROCEDURE spModificarCategoriaProducto
    @categoria_id INT,
    @nombre VARCHAR(30),
    @descripcion TEXT
AS
BEGIN
    UPDATE CategoriaProducto
    SET nombre = @nombre,
        descripcion = @descripcion
    WHERE categoria_id = @categoria_id;
END;

-- Eliminar Categoría
CREATE OR ALTER PROCEDURE spEliminarCategoriaProducto
    @categoria_id INT
AS
BEGIN
    DELETE FROM CategoriaProducto
    WHERE categoria_id = @categoria_id;
END;







=======
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


------------------ CategoríasProductos


-- Listar Categorías
CREATE OR ALTER PROCEDURE spListarCategoriaProducto
AS
BEGIN
    SELECT categoria_id, nombre, descripcion
    FROM CategoriaProducto;
END;

-- Agregar Categoría
CREATE OR ALTER PROCEDURE spAgregarCategoriaProducto
    @nombre VARCHAR(30),
    @descripcion TEXT
AS
BEGIN
    INSERT INTO CategoriaProducto (nombre, descripcion)
    VALUES (@nombre, @descripcion);
END;

-- Modificar Categoría
CREATE OR ALTER PROCEDURE spModificarCategoriaProducto
    @categoria_id INT,
    @nombre VARCHAR(30),
    @descripcion TEXT
AS
BEGIN
    UPDATE CategoriaProducto
    SET nombre = @nombre,
        descripcion = @descripcion
    WHERE categoria_id = @categoria_id;
END;

-- Eliminar Categoría
CREATE OR ALTER PROCEDURE spEliminarCategoriaProducto
    @categoria_id INT
AS
BEGIN
    DELETE FROM CategoriaProducto
    WHERE categoria_id = @categoria_id;
END;
