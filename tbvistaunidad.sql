-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mer. 06 oct. 2021 à 17:58
-- Version du serveur : 10.4.19-MariaDB
-- Version de PHP : 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `dbsistemaviajes`
--

-- --------------------------------------------------------

--
-- Structure de la vue `tbvistaunidad`
--

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `tbvistaunidad`  AS SELECT `e`.`id_unidad_transporte`,`e`.`anio` AS `anio`, `e`.`VIN` AS `VIN`, `e`.`capacidad` AS `capacidad`, `e`.`placa` AS `placa`, `a`.`tipo_placa` AS `tipo_placa`, `b`.`tipo_unidad` AS `tipo_unidad`, `c`.`modelo` AS `modelo`, `d`.`marca` AS `marca`, `f`.`estado_unidad` AS `estado_unidad`, `e`.`numero_motor` AS `numero_motor`, `e`.`numero_chasis` AS `numero_chasis` FROM (((((`tb_tipo_placa` `a` join `tb_tipo_unidad` `b`) join `tb_modelo` `c`) join `tb_marca` `d`) join `tb_unidad_transporte` `e`) join `tb_estado_unidad` `f`) WHERE `a`.`id_tipo_placa` = `e`.`id_tipo_placa` AND `b`.`id_tipo_unidad` = `e`.`id_tipo_unidad` AND `c`.`id_modelo` = `e`.`id_modelo` AND `d`.`id_marca` = `e`.`id_marca` AND `f`.`id_estado_unidad` = `e`.`id_estado_unidad` ;

--
-- VIEW `tbvistaunidad`
-- Données : Aucun(e)
--

COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
