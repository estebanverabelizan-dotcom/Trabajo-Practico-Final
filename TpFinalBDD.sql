-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.14-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.8.0.6908
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para tpfinal
CREATE DATABASE IF NOT EXISTS `tpfinal` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `tpfinal`;

-- Volcando estructura para tabla tpfinal.clientes
CREATE TABLE IF NOT EXISTS `clientes` (
  `IDcliente` int(11) NOT NULL,
  `Cliente` varchar(50) DEFAULT NULL,
  `Telefono` varchar(50) DEFAULT NULL,
  `Correo` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IDcliente`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla tpfinal.clientes: ~1 rows (aproximadamente)
INSERT INTO `clientes` (`IDcliente`, `Cliente`, `Telefono`, `Correo`) VALUES
	(1, 'Carol', '11 9865 2345', 'carol@gmail.com');

-- Volcando estructura para tabla tpfinal.productos
CREATE TABLE IF NOT EXISTS `productos` (
  `IDproducto` int(11) NOT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  `Precio` int(11) DEFAULT NULL,
  `Categoria` set('Tecnologia','Salud','Consumibles','Deportes','Electrodomesticos') DEFAULT NULL,
  PRIMARY KEY (`IDproducto`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla tpfinal.productos: ~1 rows (aproximadamente)
INSERT INTO `productos` (`IDproducto`, `Nombre`, `Precio`, `Categoria`) VALUES
	(1, 'Computadora', 50000, 'Tecnologia');

-- Volcando estructura para tabla tpfinal.ventas
CREATE TABLE IF NOT EXISTS `ventas` (
  `IDventa` int(11) NOT NULL,
  `IDCliente` int(11) DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Total` int(11) DEFAULT NULL,
  PRIMARY KEY (`IDventa`) USING BTREE,
  KEY `Fcliente` (`IDCliente`),
  CONSTRAINT `Fcliente` FOREIGN KEY (`IDCliente`) REFERENCES `clientes` (`IDcliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla tpfinal.ventas: ~1 rows (aproximadamente)
INSERT INTO `ventas` (`IDventa`, `IDCliente`, `Fecha`, `Total`) VALUES
	(1, 1, '2025-10-22', 1);

-- Volcando estructura para tabla tpfinal.ventasitems
CREATE TABLE IF NOT EXISTS `ventasitems` (
  `IDvi` int(11) NOT NULL,
  `IDVenta` int(11) NOT NULL,
  `IDProducto` int(11) NOT NULL,
  `PrecioUnit` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `PrecioTotal` int(11) NOT NULL,
  PRIMARY KEY (`IDvi`) USING BTREE,
  KEY `Fventas` (`IDVenta`),
  KEY `Fproducto` (`IDProducto`),
  CONSTRAINT `Fproducto` FOREIGN KEY (`IDProducto`) REFERENCES `productos` (`IDproducto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Fventas` FOREIGN KEY (`IDVenta`) REFERENCES `ventas` (`IDventa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla tpfinal.ventasitems: ~1 rows (aproximadamente)
INSERT INTO `ventasitems` (`IDvi`, `IDVenta`, `IDProducto`, `PrecioUnit`, `Cantidad`, `PrecioTotal`) VALUES
	(1, 1, 1, 50000, 1, 50000);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
