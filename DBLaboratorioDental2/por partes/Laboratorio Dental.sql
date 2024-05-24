-- Crear la base de datos
CREATE DATABASE LaboratorioDental;
USE LaboratorioDental;

CREATE TABLE Direccion (
    IDDireccion INT PRIMARY KEY AUTO_INCREMENT, 
    Calle VARCHAR(100),
    Departamento VARCHAR(100),
    Municipio VARCHAR(100)
);

CREATE TABLE Cargo (
    IDCargo INT PRIMARY KEY AUTO_INCREMENT,
    NombreCargo VARCHAR(255)
);

CREATE TABLE Roles (
    IDRol INT PRIMARY KEY AUTO_INCREMENT,
    Rol VARCHAR(255)
);

CREATE TABLE Permisos (
    IDPermiso INT PRIMARY KEY AUTO_INCREMENT,
    IDRol INT,
    Permiso VARCHAR(255),
    FOREIGN KEY (IDRol) REFERENCES Roles(IDRol)
);

CREATE TABLE Empleados (
    IDEmpleado INT PRIMARY KEY AUTO_INCREMENT,
    IDDireccion INT,
    IDCargo INT,
    IDPermiso INT,
    Nombres VARCHAR(255),
    Apellidos VARCHAR(255),
    Telefono VARCHAR(20),
    Correo VARCHAR(255),
    Direccion VARCHAR(255),
    Puesto VARCHAR(255),
    Sexo ENUM('Masculino', 'Femenino'),
    Estado ENUM('Activo', 'Inactivo'),
    FOREIGN KEY (IDDireccion) REFERENCES Direccion(IDDireccion),
    FOREIGN KEY (IDCargo) REFERENCES Cargo(IDCargo),
    FOREIGN KEY (IDPermiso) REFERENCES Permisos(IDPermiso)
);
CREATE TABLE Pacientes (
    IDPaciente INT PRIMARY KEY AUTO_INCREMENT,
    IDDireccion INT,
    Nombres VARCHAR(255),
    Apellidos VARCHAR(255),
    Telefono VARCHAR(20),
    Correo VARCHAR(255),
    Direccion VARCHAR(255),
    FechaNacimiento DATE,
    Sexo ENUM('Masculino', 'Femenino'),
    Estado ENUM('Activo', 'Inactivo'),
    FOREIGN KEY (IDDireccion) REFERENCES Direccion(IDDireccion)
);

CREATE TABLE Historial_Clinicos (
    IDHistorialClinico INT PRIMARY KEY AUTO_INCREMENT,
    IDPaciente INT,
    Afecciones VARCHAR(255),
    Observaciones VARCHAR(255),
    Estado ENUM('Activo', 'Inactivo'),
    FOREIGN KEY (IDPaciente) REFERENCES Pacientes(IDPaciente)
);

CREATE TABLE Historial_Consultas (
    IDConsulta INT PRIMARY KEY AUTO_INCREMENT,
    IDHistorialClinico INT,
    Motivo_Consulta VARCHAR(255),
    Observaciones VARCHAR(255),
    IDEmpleado INT,
    Estado ENUM('Activo', 'Inactivo'),
    FOREIGN KEY (IDHistorialClinico) REFERENCES Historial_Clinicos(IDHistorialClinico),
    FOREIGN KEY (IDEmpleado) REFERENCES Empleados(IDEmpleado)
);

CREATE TABLE Citas (
    IDCitas INT PRIMARY KEY AUTO_INCREMENT,
    IDHistorialClinico INT,
    Estado ENUM('Pendiente', 'Completada', 'Cancelada'),
    Nota VARCHAR(255),
    FechaCita DATE,
    HoraCita TIME,
    FOREIGN KEY (IDHistorialClinico) REFERENCES Historial_Clinicos(IDHistorialClinico)
);

CREATE TABLE Usuarios (
    IDUsuario INT PRIMARY KEY AUTO_INCREMENT,
    IDRol INT,
    IDEmpleado INT,
    NomCompleto VARCHAR(255),
    Usuario VARCHAR(100),
    Clave VARCHAR(255),
    TipoUsuario ENUM('Administrador', 'Doctor', 'Recepcionista'),
    Estado ENUM('Activo', 'Inactivo'),
    FOREIGN KEY (IDRol) REFERENCES Roles(IDRol),
    FOREIGN KEY (IDEmpleado) REFERENCES Empleados(IDEmpleado)
);

CREATE TABLE Tratamientos (
    IDTratamiento INT PRIMARY KEY AUTO_INCREMENT,
    Tratamiento ENUM('Consulta', 'Seguimiento', 'Urgencia'),
    Estado ENUM('Activo', 'Inactivo')
);

CREATE TABLE Detalle_Tratamientos (
    IDDetalleT INT PRIMARY KEY AUTO_INCREMENT,
    IDTratamiento INT,
    DuracionT VARCHAR(100),
    Precio DECIMAL(10,2),
    Indicacion VARCHAR(255),
    Estado ENUM('Activo', 'Inactivo'),
    FOREIGN KEY (IDTratamiento) REFERENCES Tratamientos(IDTratamiento)
);

CREATE TABLE Lista_Citas (
    IDCita INT PRIMARY KEY AUTO_INCREMENT,
    FechaCita DATE,
    IDPaciente INT,
    FOREIGN KEY (IDPaciente) REFERENCES Pacientes(IDPaciente)
);
ALTER TABLE Pacientes
ADD COLUMN IDTratamiento INT,
ADD FOREIGN KEY (IDTratamiento) REFERENCES Tratamientos(IDTratamiento);