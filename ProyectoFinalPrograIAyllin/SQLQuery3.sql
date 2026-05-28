USE IconicStudioDB;

CREATE TABLE Usuarios (
    ID_Usuario INT PRIMARY KEY IDENTITY(1,1),
    Usuario VARCHAR(50) NOT NULL,
    Contrasena VARCHAR(50) NOT NULL,
    Rol VARCHAR(20) NOT NULL -- 'Administrador' o 'Recepcionista'
);

INSERT INTO Usuarios (Usuario, Contrasena, Rol) VALUES
('admin', '1234', 'Administrador'),
('recepcion', '1234', 'Recepcionista');