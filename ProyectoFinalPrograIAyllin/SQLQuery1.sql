create database IconicStudioDB;
GO
use IconicStudioDB;
GO

CREATE TABLE Clientes (
    ID_Cliente INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Telefono VARCHAR(15),
    Correo VARCHAR(100),
    Fecha_Registro DATETIME DEFAULT GETDATE()
);

CREATE TABLE Empleados (
    ID_Empleado INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Especialidad VARCHAR(50), -- Ejemplo: Corte, Tinte, Uñas
    Telefono VARCHAR(15)
);

CREATE TABLE Servicios (
    ID_Servicio INT PRIMARY KEY IDENTITY(1,1),
    Nombre_Servicio VARCHAR(50) NOT NULL,
    Descripcion VARCHAR(200),
    Costo DECIMAL(10, 2) NOT NULL
);

CREATE TABLE Citas (
    ID_Cita INT PRIMARY KEY IDENTITY(1,1),
    ID_Cliente INT NOT NULL,
    ID_Empleado INT NOT NULL,
    ID_Servicio INT NOT NULL,
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL,
    Estado VARCHAR(20) DEFAULT 'Programada', -- Programada, Completada, Cancelada [cite: 97, 115]
    
    -- Relaciones (Llaves Foráneas)
    CONSTRAINT FK_Cita_Cliente FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID_Cliente),
    CONSTRAINT FK_Cita_Empleado FOREIGN KEY (ID_Empleado) REFERENCES Empleados(ID_Empleado),
    CONSTRAINT FK_Cita_Servicio FOREIGN KEY (ID_Servicio) REFERENCES Servicios(ID_Servicio)
);
