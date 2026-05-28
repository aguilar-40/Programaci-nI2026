USE IconicStudioDB;

INSERT INTO Clientes (Nombre, Telefono, Correo) VALUES
('Ayllin Aguilar', '12345678', 'ayllin@gmail.com'),
('Carmen Rodriguez', '87654321', 'carmen@gmail.com'),
('Josselyn Sanchez', '55551234', 'josselyn@gmail.com');

INSERT INTO Empleados (Nombre, Especialidad, Telefono) VALUES
('Juan Perez', 'Corte', '11112222'),
('Judith Lopez', 'Tinte', '33334444'),
('Maria Garcia', 'Uñas', '55556666');

INSERT INTO Servicios (Nombre_Servicio, Descripcion, Costo) VALUES
('Corte de cabello', 'Corte profesional', 75.00),
('Tinte', 'Coloracion completa', 150.00),
('Peinado', 'Peinado para eventos', 100.00),
('Manicure', 'Uñas manos', 60.00),
('Pedicure', 'Uñas pies', 70.00);