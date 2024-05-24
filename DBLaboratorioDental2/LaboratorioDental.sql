CREATE DATABASE  IF NOT EXISTS `laboratoriodental` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `laboratoriodental`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: laboratoriodental
-- ------------------------------------------------------
-- Server version	8.0.35

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cargo`
--

DROP TABLE IF EXISTS `cargo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cargo` (
  `IDCargo` int NOT NULL AUTO_INCREMENT,
  `NombreCargo` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDCargo`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cargo`
--

LOCK TABLES `cargo` WRITE;
/*!40000 ALTER TABLE `cargo` DISABLE KEYS */;
INSERT INTO `cargo` VALUES (1,'Doctor'),(2,'Recepcionista'),(3,'Administrador');
/*!40000 ALTER TABLE `cargo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `citas`
--

DROP TABLE IF EXISTS `citas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `citas` (
  `IDCitas` int NOT NULL AUTO_INCREMENT,
  `IDHistorialClinico` int DEFAULT NULL,
  `Estado` enum('Pendiente','Completada','Cancelada') DEFAULT NULL,
  `Nota` varchar(255) DEFAULT NULL,
  `FechaCita` date DEFAULT NULL,
  `HoraCita` time DEFAULT NULL,
  PRIMARY KEY (`IDCitas`),
  KEY `IDHistorialClinico` (`IDHistorialClinico`),
  CONSTRAINT `citas_ibfk_1` FOREIGN KEY (`IDHistorialClinico`) REFERENCES `historial_clinicos` (`IDHistorialClinico`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `citas`
--

LOCK TABLES `citas` WRITE;
/*!40000 ALTER TABLE `citas` DISABLE KEYS */;
INSERT INTO `citas` VALUES (1,1,'Pendiente','Primera consulta del año','2024-06-01','10:00:00'),(2,2,'Pendiente','Consulta de seguimiento','2024-06-02','11:00:00');
/*!40000 ALTER TABLE `citas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_tratamientos`
--

DROP TABLE IF EXISTS `detalle_tratamientos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalle_tratamientos` (
  `IDDetalleT` int NOT NULL AUTO_INCREMENT,
  `IDTratamiento` int DEFAULT NULL,
  `DuracionT` varchar(100) DEFAULT NULL,
  `Precio` decimal(10,2) DEFAULT NULL,
  `Indicacion` varchar(255) DEFAULT NULL,
  `Estado` enum('Activo','Inactivo') DEFAULT NULL,
  PRIMARY KEY (`IDDetalleT`),
  KEY `IDTratamiento` (`IDTratamiento`),
  CONSTRAINT `detalle_tratamientos_ibfk_1` FOREIGN KEY (`IDTratamiento`) REFERENCES `tratamientos` (`IDTratamiento`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_tratamientos`
--

LOCK TABLES `detalle_tratamientos` WRITE;
/*!40000 ALTER TABLE `detalle_tratamientos` DISABLE KEYS */;
INSERT INTO `detalle_tratamientos` VALUES (3,1,'30 días',100.00,'Tomar una tableta diaria','Activo'),(4,2,'15 días',50.00,'Tomar una tableta diaria','Activo');
/*!40000 ALTER TABLE `detalle_tratamientos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `direccion`
--

DROP TABLE IF EXISTS `direccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `direccion` (
  `IDDireccion` int NOT NULL AUTO_INCREMENT,
  `Calle` varchar(100) DEFAULT NULL,
  `Departamento` varchar(100) DEFAULT NULL,
  `Municipio` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IDDireccion`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `direccion`
--

LOCK TABLES `direccion` WRITE;
/*!40000 ALTER TABLE `direccion` DISABLE KEYS */;
INSERT INTO `direccion` VALUES (1,'Calle Principal','Sonsonate','Sonsonate'),(2,'Calle los Leones','Sonsonate','Sonsonate'),(3,'Calle Roble','Sonsonate','Acajutla'),(4,'Calle los Naranjos','Sonsonate','Sonsonate');
/*!40000 ALTER TABLE `direccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleados` (
  `IDEmpleado` int NOT NULL AUTO_INCREMENT,
  `IDDireccion` int DEFAULT NULL,
  `IDCargo` int DEFAULT NULL,
  `IDPermiso` int DEFAULT NULL,
  `Nombres` varchar(255) DEFAULT NULL,
  `Apellidos` varchar(255) DEFAULT NULL,
  `Telefono` varchar(20) DEFAULT NULL,
  `Correo` varchar(255) DEFAULT NULL,
  `Direccion` varchar(255) DEFAULT NULL,
  `Puesto` varchar(255) DEFAULT NULL,
  `Sexo` enum('Masculino','Femenino') DEFAULT NULL,
  `Estado` enum('Activo','Inactivo') DEFAULT NULL,
  PRIMARY KEY (`IDEmpleado`),
  KEY `IDDireccion` (`IDDireccion`),
  KEY `IDCargo` (`IDCargo`),
  KEY `IDPermiso` (`IDPermiso`),
  CONSTRAINT `empleados_ibfk_1` FOREIGN KEY (`IDDireccion`) REFERENCES `direccion` (`IDDireccion`),
  CONSTRAINT `empleados_ibfk_2` FOREIGN KEY (`IDCargo`) REFERENCES `cargo` (`IDCargo`),
  CONSTRAINT `empleados_ibfk_3` FOREIGN KEY (`IDPermiso`) REFERENCES `permisos` (`IDPermiso`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,1,1,1,'Juan','Pérez','555-1234','juan.perez@gmail.com',' Calle Principal','Doctor','Masculino','Activo'),(2,2,2,2,'Ana','Gómez','555-5678','ana.gomez@gmail.com','Calle los Naranjos','Recepcionista','Femenino','Activo');
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historial_clinicos`
--

DROP TABLE IF EXISTS `historial_clinicos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `historial_clinicos` (
  `IDHistorialClinico` int NOT NULL AUTO_INCREMENT,
  `IDPaciente` int DEFAULT NULL,
  `Afecciones` varchar(255) DEFAULT NULL,
  `Observaciones` varchar(255) DEFAULT NULL,
  `Estado` enum('Activo','Inactivo') DEFAULT NULL,
  PRIMARY KEY (`IDHistorialClinico`),
  KEY `IDPaciente` (`IDPaciente`),
  CONSTRAINT `historial_clinicos_ibfk_1` FOREIGN KEY (`IDPaciente`) REFERENCES `pacientes` (`IDPaciente`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historial_clinicos`
--

LOCK TABLES `historial_clinicos` WRITE;
/*!40000 ALTER TABLE `historial_clinicos` DISABLE KEYS */;
INSERT INTO `historial_clinicos` VALUES (1,1,'Muela Dañada','Paciente con muela en muy mal estado ','Activo'),(2,2,'Dientes Roto','Paciente con 2 dientes rotos una muela y un colmillos ','Activo');
/*!40000 ALTER TABLE `historial_clinicos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historial_consultas`
--

DROP TABLE IF EXISTS `historial_consultas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `historial_consultas` (
  `IDConsulta` int NOT NULL AUTO_INCREMENT,
  `IDHistorialClinico` int DEFAULT NULL,
  `Motivo_Consulta` varchar(255) DEFAULT NULL,
  `Observaciones` varchar(255) DEFAULT NULL,
  `IDEmpleado` int DEFAULT NULL,
  `Estado` enum('Activo','Inactivo') DEFAULT NULL,
  PRIMARY KEY (`IDConsulta`),
  KEY `IDHistorialClinico` (`IDHistorialClinico`),
  KEY `IDEmpleado` (`IDEmpleado`),
  CONSTRAINT `historial_consultas_ibfk_1` FOREIGN KEY (`IDHistorialClinico`) REFERENCES `historial_clinicos` (`IDHistorialClinico`),
  CONSTRAINT `historial_consultas_ibfk_2` FOREIGN KEY (`IDEmpleado`) REFERENCES `empleados` (`IDEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historial_consultas`
--

LOCK TABLES `historial_consultas` WRITE;
/*!40000 ALTER TABLE `historial_consultas` DISABLE KEYS */;
INSERT INTO `historial_consultas` VALUES (1,1,'Chequeo anual','Revisión general',1,'Activo'),(2,2,'Dolor de Muela','Paciente con dolor de Muelas',1,'Activo');
/*!40000 ALTER TABLE `historial_consultas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lista_citas`
--

DROP TABLE IF EXISTS `lista_citas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lista_citas` (
  `IDCita` int NOT NULL AUTO_INCREMENT,
  `FechaCita` date DEFAULT NULL,
  `IDPaciente` int DEFAULT NULL,
  PRIMARY KEY (`IDCita`),
  KEY `IDPaciente` (`IDPaciente`),
  CONSTRAINT `lista_citas_ibfk_1` FOREIGN KEY (`IDPaciente`) REFERENCES `pacientes` (`IDPaciente`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lista_citas`
--

LOCK TABLES `lista_citas` WRITE;
/*!40000 ALTER TABLE `lista_citas` DISABLE KEYS */;
INSERT INTO `lista_citas` VALUES (1,'2024-06-01',1),(2,'2024-06-02',2);
/*!40000 ALTER TABLE `lista_citas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacientes`
--

DROP TABLE IF EXISTS `pacientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pacientes` (
  `IDPaciente` int NOT NULL AUTO_INCREMENT,
  `IDDireccion` int DEFAULT NULL,
  `Nombres` varchar(255) DEFAULT NULL,
  `Apellidos` varchar(255) DEFAULT NULL,
  `Telefono` varchar(20) DEFAULT NULL,
  `Correo` varchar(255) DEFAULT NULL,
  `Direccion` varchar(255) DEFAULT NULL,
  `FechaNacimiento` date DEFAULT NULL,
  `Sexo` enum('Masculino','Femenino') DEFAULT NULL,
  `Estado` enum('Activo','Inactivo') DEFAULT NULL,
  `IDTratamiento` int DEFAULT NULL,
  PRIMARY KEY (`IDPaciente`),
  KEY `IDDireccion` (`IDDireccion`),
  KEY `IDTratamiento` (`IDTratamiento`),
  CONSTRAINT `pacientes_ibfk_1` FOREIGN KEY (`IDDireccion`) REFERENCES `direccion` (`IDDireccion`),
  CONSTRAINT `pacientes_ibfk_2` FOREIGN KEY (`IDTratamiento`) REFERENCES `tratamientos` (`IDTratamiento`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacientes`
--

LOCK TABLES `pacientes` WRITE;
/*!40000 ALTER TABLE `pacientes` DISABLE KEYS */;
INSERT INTO `pacientes` VALUES (1,3,'Carlos','López','555-9876','carlos.lopez@gmail.com',' Calle Roble','1985-05-15','Masculino','Activo',NULL),(2,1,'María','González','555-6543','maria.gonzalez@gamil.com',' Calle Principal','1990-08-25','Femenino','Activo',NULL);
/*!40000 ALTER TABLE `pacientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permisos`
--

DROP TABLE IF EXISTS `permisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `permisos` (
  `IDPermiso` int NOT NULL AUTO_INCREMENT,
  `IDRol` int DEFAULT NULL,
  `Permiso` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDPermiso`),
  KEY `IDRol` (`IDRol`),
  CONSTRAINT `permisos_ibfk_1` FOREIGN KEY (`IDRol`) REFERENCES `roles` (`IDRol`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permisos`
--

LOCK TABLES `permisos` WRITE;
/*!40000 ALTER TABLE `permisos` DISABLE KEYS */;
INSERT INTO `permisos` VALUES (1,1,'Acceso Completo'),(2,2,'Acceso Limitado'),(3,3,'Solo Vista');
/*!40000 ALTER TABLE `permisos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `IDRol` int NOT NULL AUTO_INCREMENT,
  `Rol` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDRol`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Admin'),(2,'Usuario'),(3,'Invitado');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tratamientos`
--

DROP TABLE IF EXISTS `tratamientos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tratamientos` (
  `IDTratamiento` int NOT NULL AUTO_INCREMENT,
  `Tratamiento` enum('Consulta','Seguimiento','Urgencia') DEFAULT NULL,
  `Estado` enum('Activo','Inactivo') DEFAULT NULL,
  PRIMARY KEY (`IDTratamiento`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tratamientos`
--

LOCK TABLES `tratamientos` WRITE;
/*!40000 ALTER TABLE `tratamientos` DISABLE KEYS */;
INSERT INTO `tratamientos` VALUES (1,'Consulta','Activo'),(2,'Seguimiento','Activo'),(3,'Urgencia','Activo');
/*!40000 ALTER TABLE `tratamientos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `IDUsuario` int NOT NULL AUTO_INCREMENT,
  `IDRol` int DEFAULT NULL,
  `IDEmpleado` int DEFAULT NULL,
  `NomCompleto` varchar(255) DEFAULT NULL,
  `Usuario` varchar(100) DEFAULT NULL,
  `Clave` varchar(255) DEFAULT NULL,
  `TipoUsuario` enum('Administrador','Doctor','Recepcionista') DEFAULT NULL,
  `Estado` enum('Activo','Inactivo') DEFAULT NULL,
  PRIMARY KEY (`IDUsuario`),
  KEY `IDRol` (`IDRol`),
  KEY `IDEmpleado` (`IDEmpleado`),
  CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`IDRol`) REFERENCES `roles` (`IDRol`),
  CONSTRAINT `usuarios_ibfk_2` FOREIGN KEY (`IDEmpleado`) REFERENCES `empleados` (`IDEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,1,1,'Administrador','admin','Admin1234','Administrador','Activo'),(2,2,2,'Doctor Juan Pérez','jperez','JuanPerez123','Doctor','Activo'),(3,3,2,'Recepcionista Ana Gómez','agomez','AnaGomez123','Recepcionista','Activo');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-20 17:59:43
