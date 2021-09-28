-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 28-09-2021 a las 06:52:35
-- Versión del servidor: 10.4.20-MariaDB
-- Versión de PHP: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `dbsistemaviajes`
--

-- --------------------------------------------------------

--
-- Estructura para la vista `tbconductoresview`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `tbconductoresview`  AS SELECT concat(`a`.`apellidos_empleado`,', ',`a`.`nombres_empleado`) AS `Empleado`, `b`.`numero_licencia` AS `Licencia`, `b`.`fecha_exp_licencia` AS `Fecha Exp.`, `c`.`tipo_licencia` AS `Clase`, `b`.`id_conductores` AS `ID` FROM ((`tb_empleados` `a` join `tb_conductores` `b`) join `tb_tipo_licencia` `c`) WHERE `a`.`id_empleado` = `b`.`id_empleado` AND `b`.`id_tipo_licencia` = `c`.`id_tipo_licencia` AND `a`.`id_cargo` = 1 ;

--
-- VIEW `tbconductoresview`
-- Datos: Ninguna
--

COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
