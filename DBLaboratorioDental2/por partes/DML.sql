USE LaboratorioDental;

INSERT INTO Direccion (Calle, Departamento, Municipio)
VALUES 
('Calle Principal', 'Sonsonate', 'Sonsonate'),
('Calle los Leones', 'Sonsonate', 'Sonsonate'),
('Calle Roble', 'Sonsonate', 'Acajutla'),
('Calle los Naranjos','Sonsonate','Sonsonate');

INSERT INTO Cargo (NombreCargo)
VALUES 
('Doctor'),
('Recepcionista'),
('Administrador');

INSERT INTO Roles (Rol)
VALUES 
('Admin'),
('Usuario'),
('Invitado');

INSERT INTO Permisos (IDRol, Permiso)
VALUES 
(1, 'Acceso Completo'),
(2, 'Acceso Limitado'),
(3, 'Solo Vista');

INSERT INTO Empleados (IDDireccion, IDCargo, IDPermiso, Nombres, Apellidos, Telefono, Correo, Direccion, Puesto, Sexo, Estado)
VALUES 
(1, 1, 1, 'Juan', 'Pérez', '555-1234', 'juan.perez@gmail.com', ' Calle Principal', 'Doctor', 'Masculino', 'Activo'),
(2, 2, 2, 'Ana', 'Gómez', '555-5678', 'ana.gomez@gmail.com', 'Calle los Naranjos', 'Recepcionista', 'Femenino', 'Activo');

INSERT INTO Pacientes (IDDireccion, Nombres, Apellidos, Telefono, Correo, Direccion, FechaNacimiento, Sexo, Estado, IDTratamiento)
VALUES 
(3, 'Carlos', 'López', '555-9876', 'carlos.lopez@gmail.com', ' Calle Roble', '1985-05-15', 'Masculino', 'Activo', NULL),
(1, 'María', 'González', '555-6543', 'maria.gonzalez@gamil.com', ' Calle Principal', '1990-08-25', 'Femenino', 'Activo', NULL);

INSERT INTO Historial_Clinicos (IDPaciente, Afecciones, Observaciones, Estado)
VALUES 
(1, 'Muela Dañada', 'Paciente con muela en muy mal estado ', 'Activo'),
(2, 'Dientes Roto', 'Paciente con 2 dientes rotos una muela y un colmillos ', 'Activo');

INSERT INTO Historial_Consultas (IDHistorialClinico, Motivo_Consulta, Observaciones, IDEmpleado, Estado)
VALUES 
(1, 'Chequeo anual', 'Revisión general', 1, 'Activo'),
(2, 'Dolor de Muela', 'Paciente con dolor de Muelas', 1, 'Activo');

INSERT INTO Citas (IDHistorialClinico, Estado, Nota, FechaCita, HoraCita)
VALUES 
(1, 'Pendiente', 'Primera consulta del año', '2024-06-01', '10:00:00'),
(2, 'Pendiente', 'Consulta de seguimiento', '2024-06-02', '11:00:00');

INSERT INTO Usuarios (IDRol, IDEmpleado, NomCompleto, Usuario, Clave, TipoUsuario, Estado)
VALUES 
(1, 1, 'Administrador', 'Admin', 'Admin1234', 'Administrador', 'Activo'),
(2, 2, 'Doctor Juan Pérez', 'jperez', 'JuanPerez123', 'Doctor', 'Activo'),
(3, 2, 'Recepcionista Ana Gómez', 'agomez', 'AnaGomez123', 'Recepcionista', 'Activo');

INSERT INTO Detalle_Tratamientos (IDTratamiento, DuracionT, Precio, Indicacion, Estado)
VALUES 
(1, '30 días', 100.00, 'Tomar una tableta diaria', 'Activo'),
(2, '15 días', 50.00, 'Tomar una tableta diaria', 'Activo');

INSERT INTO Tratamientos (Tratamiento, Estado)
VALUES 
('Consulta', 'Activo'),
('Seguimiento', 'Activo'),
('Urgencia', 'Activo');

INSERT INTO Lista_Citas (FechaCita, IDPaciente)
VALUES 
('2024-06-01', 1),
('2024-06-02', 2);
