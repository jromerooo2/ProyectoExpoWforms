-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 05-10-2021 a las 06:12:25
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
-- Estructura Stand-in para la vista `tbconductoresview`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `tbconductoresview` (
`Empleado` varchar(62)
,`Licencia` varchar(45)
,`Fecha Exp.` varchar(45)
,`Clase` varchar(45)
,`ID` int(11)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `tbusuariosview`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `tbusuariosview` (
`id_usuario` int(11)
,`nombre_usuario` varchar(50)
,`correo_usuario` varchar(50)
,`contrasena` varchar(50)
,`nombres_empleado` varchar(30)
,`cargo` varchar(45)
,`foto_usuario` mediumblob
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `tbvistaunidad`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `tbvistaunidad` (
`anio` int(4)
,`VIN` varchar(20)
,`capacidad` int(3)
,`placa` varchar(15)
,`tipo_placa` varchar(3)
,`tipo_unidad` varchar(30)
,`modelo` varchar(45)
,`marca` varchar(45)
,`estado_unidad` varchar(30)
,`numero_motor` varchar(45)
,`numero_chasis` varchar(45)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_cargo`
--

CREATE TABLE `tb_cargo` (
  `id_cargo` int(11) NOT NULL,
  `cargo` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_cargo`
--

INSERT INTO `tb_cargo` (`id_cargo`, `cargo`) VALUES
(1, 'Conductor'),
(2, 'Administrador'),
(3, 'Gerente'),
(4, 'Secretario');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_cliente`
--

CREATE TABLE `tb_cliente` (
  `id_cliente` int(11) NOT NULL,
  `nombres_cliente` varchar(30) NOT NULL,
  `apellidos_cliente` varchar(30) NOT NULL,
  `telefono_cliente` varchar(11) NOT NULL,
  `id_tipo_cliente` int(11) NOT NULL,
  `direccion_cliente` varchar(100) NOT NULL,
  `correo_cliente` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_cliente`
--

INSERT INTO `tb_cliente` (`id_cliente`, `nombres_cliente`, `apellidos_cliente`, `telefono_cliente`, `id_tipo_cliente`, `direccion_cliente`, `correo_cliente`) VALUES
(4, 'McDonalds', 'Enterprise', '1234-5678', 1, 'La San Luis ', 'mcdonalds@gmail.com.sv');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_cliente_viaje`
--

CREATE TABLE `tb_cliente_viaje` (
  `id_cliente_viaje` int(11) NOT NULL,
  `id_viaje` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_conductores`
--

CREATE TABLE `tb_conductores` (
  `id_conductores` int(11) NOT NULL,
  `id_empleado` int(11) NOT NULL,
  `numero_licencia` varchar(45) NOT NULL,
  `fecha_exp_licencia` varchar(45) NOT NULL,
  `id_tipo_licencia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_conductores`
--

INSERT INTO `tb_conductores` (`id_conductores`, `id_empleado`, `numero_licencia`, `fecha_exp_licencia`, `id_tipo_licencia`) VALUES
(3, 5, 'N°    -      -   -', '17/9/2021 08:10:17', 1),
(4, 5, 'N°    -      -   -', '17/9/2021 08:10:17', 1),
(5, 5, 'N°123-123   -   -', '17/9/2021 08:10:17', 1),
(7, 22, '1234567890', '17/9/2021 08:10:17', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_departamentos`
--

CREATE TABLE `tb_departamentos` (
  `id_departamento` int(11) NOT NULL,
  `departamento` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_departamentos`
--

INSERT INTO `tb_departamentos` (`id_departamento`, `departamento`) VALUES
(1, 'Ahuachapan'),
(2, 'Santa Ana'),
(3, 'Sonsonate'),
(4, 'Chalatenango'),
(5, 'La Libertad'),
(6, 'San Salvador'),
(7, 'Cuscatlán'),
(8, 'Cabañas'),
(9, 'San Vicente'),
(10, 'La Paz'),
(11, 'Morazán'),
(12, 'San Miguel'),
(13, 'Usulutan'),
(14, 'La union');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_detalle_factura`
--

CREATE TABLE `tb_detalle_factura` (
  `id_detalle_factura` int(11) NOT NULL,
  `monto_parcial` double(5,2) NOT NULL,
  `descuento` double(5,2) DEFAULT NULL,
  `id_factura` int(11) NOT NULL,
  `id_cliente_viaje` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_direccion_detalle`
--

CREATE TABLE `tb_direccion_detalle` (
  `id_direccion_detalle` int(11) NOT NULL,
  `id_viaje` int(11) NOT NULL,
  `direccion_partida` varchar(200) DEFAULT NULL,
  `punto_referencia_partida` varchar(200) DEFAULT NULL,
  `direccion_destino` varchar(200) DEFAULT NULL,
  `punto_referencia_destino` varchar(200) DEFAULT NULL,
  `direccion_adicional` varchar(200) DEFAULT NULL,
  `punto_referencia_adicional` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_empleados`
--

CREATE TABLE `tb_empleados` (
  `id_empleado` int(11) NOT NULL,
  `nombres_empleado` varchar(30) NOT NULL,
  `apellidos_empleado` varchar(30) NOT NULL,
  `DUI` varchar(15) NOT NULL,
  `NIT` varchar(20) NOT NULL,
  `direccion_empleado` varchar(200) NOT NULL,
  `telefono_empleado` varchar(11) NOT NULL,
  `id_genero` int(11) NOT NULL,
  `id_estado_empleado` int(11) NOT NULL,
  `id_cargo` int(11) NOT NULL,
  `id_municipio` int(11) NOT NULL,
  `nacimiento_empleado` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_empleados`
--

INSERT INTO `tb_empleados` (`id_empleado`, `nombres_empleado`, `apellidos_empleado`, `DUI`, `NIT`, `direccion_empleado`, `telefono_empleado`, `id_genero`, `id_estado_empleado`, `id_cargo`, `id_municipio`, `nacimiento_empleado`) VALUES
(5, 'Jose Santiago', 'Merino Herrera', '1234567-8', '12345678-9', 'Mejicanos', '1234-5678', 2, 1, 2, 148, '2004-08-31 00:00:00'),
(7, 'Maria Fernanda', 'Merino Herrera', '65432413', '31243124', 'Mejicanos', '9876-5432', 1, 1, 1, 26, '2004-08-31 00:00:00'),
(8, 'Juan', 'Romero', '21231313', '12132', 'asdada', '13123', 1, 1, 1, 26, '2021-09-02 00:00:00'),
(9, 'Maria Fernanda', 'Merino Herrera', '65432413', '31243124', 'Mejicanos', '9876-5432', 1, 1, 1, 26, '2030-02-20 00:00:00'),
(22, 'Josue ', 'Guinea', '12345678-9', '1234-567891-234-5', 'En su casita haciendo videos suscribete chaval', '+503-1234-5', 1, 1, 1, 26, '2000-10-12 00:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_estado_empleado`
--

CREATE TABLE `tb_estado_empleado` (
  `id_estado_empleado` int(11) NOT NULL,
  `estado_empleado` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_estado_empleado`
--

INSERT INTO `tb_estado_empleado` (`id_estado_empleado`, `estado_empleado`) VALUES
(1, 'Activo'),
(2, 'Incativo'),
(3, 'Incapacitado'),
(4, 'En Viaje');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_estado_factura`
--

CREATE TABLE `tb_estado_factura` (
  `id_estado_factura` int(11) NOT NULL,
  `estado_factura` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_estado_unidad`
--

CREATE TABLE `tb_estado_unidad` (
  `id_estado_unidad` int(11) NOT NULL,
  `estado_unidad` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_estado_unidad`
--

INSERT INTO `tb_estado_unidad` (`id_estado_unidad`, `estado_unidad`) VALUES
(1, 'En mantenimiento'),
(2, 'Activa'),
(3, 'Inactiva'),
(4, 'Dañada'),
(5, 'En espera');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_estado_usuarios`
--

CREATE TABLE `tb_estado_usuarios` (
  `id_estado_usuario` int(11) NOT NULL,
  `estado` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_estado_usuarios`
--

INSERT INTO `tb_estado_usuarios` (`id_estado_usuario`, `estado`) VALUES
(1, 'Activo'),
(2, 'Bloqueado'),
(3, 'Inactivo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_estado_viaje`
--

CREATE TABLE `tb_estado_viaje` (
  `id_estado_viaje` int(11) NOT NULL,
  `estado_viaje` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_estado_viaje`
--

INSERT INTO `tb_estado_viaje` (`id_estado_viaje`, `estado_viaje`) VALUES
(1, 'Activo'),
(2, 'En espera'),
(3, 'Finalizado'),
(4, 'En curso');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_factura`
--

CREATE TABLE `tb_factura` (
  `id_factura` int(11) NOT NULL,
  `id_empleado` int(11) DEFAULT NULL,
  `id_conductor` int(11) DEFAULT NULL,
  `id_metodo_pago` int(11) NOT NULL,
  `id_estado_factura` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_genero`
--

CREATE TABLE `tb_genero` (
  `id_genero` int(1) NOT NULL,
  `genero` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_genero`
--

INSERT INTO `tb_genero` (`id_genero`, `genero`) VALUES
(1, 'M'),
(2, 'F');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_mantenimiento`
--

CREATE TABLE `tb_mantenimiento` (
  `id_mantenimiento` int(11) NOT NULL,
  `id_unidad_transporte` int(11) NOT NULL,
  `monto_mantenimiento` double NOT NULL,
  `ultimo_kilometraje` double NOT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  `fecha` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_marca`
--

CREATE TABLE `tb_marca` (
  `id_marca` int(11) NOT NULL,
  `marca` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_marca`
--

INSERT INTO `tb_marca` (`id_marca`, `marca`) VALUES
(1, 'Mascarello');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_metodo_pago`
--

CREATE TABLE `tb_metodo_pago` (
  `id_metodo_pago` int(11) NOT NULL,
  `metodo_pago` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_metodo_pago`
--

INSERT INTO `tb_metodo_pago` (`id_metodo_pago`, `metodo_pago`) VALUES
(1, 'Tarjeta de Credito'),
(2, 'Tarjeta de Debito'),
(3, 'Efectivo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_modelo`
--

CREATE TABLE `tb_modelo` (
  `id_modelo` int(11) NOT NULL,
  `modelo` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_modelo`
--

INSERT INTO `tb_modelo` (`id_modelo`, `modelo`) VALUES
(1, 'CITYRURAL');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_municipios`
--

CREATE TABLE `tb_municipios` (
  `id_municipio` int(11) NOT NULL,
  `municipio` varchar(30) DEFAULT NULL,
  `id_departamento` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_municipios`
--

INSERT INTO `tb_municipios` (`id_municipio`, `municipio`, `id_departamento`) VALUES
(1, ' Ahuachapán', 1),
(2, ' Apaneca', 1),
(3, ' Atiquizaya', 1),
(4, ' Concepción de Ataco', 1),
(5, ' El Refugio', 1),
(6, ' Guaymango', 1),
(7, ' Jujutla', 1),
(8, ' San Francisco Menéndez', 1),
(9, ' San Lorenzo', 1),
(10, ' San Pedro Puxtla', 1),
(11, ' Tacuba', 1),
(12, ' Turín', 1),
(13, ' Candelaria de la Frontera', 2),
(14, ' Chalchuapa', 2),
(15, ' Coatepeque', 2),
(16, ' El Congo', 2),
(17, ' El Porvenir', 2),
(18, ' Masahuat', 2),
(19, ' Metapán', 2),
(20, ' San Antonio Pajonal', 2),
(21, ' San Sebastián Salitrillo', 2),
(22, ' Santa Ana', 2),
(23, ' Santa Rosa Guachipilín', 2),
(24, ' Santiago de la Frontera', 2),
(25, ' Texistepeque', 2),
(26, ' Acajutla', 3),
(27, ' Armenia', 3),
(28, ' Caluco', 3),
(29, ' Cuisnahuat', 3),
(30, ' Izalco', 3),
(31, ' Juayúa', 3),
(32, ' Nahuizalco', 3),
(33, ' Nahulingo', 3),
(34, ' Salcoatitán', 3),
(35, ' San Antonio del Monte', 3),
(36, ' San Julián', 3),
(37, ' Santa Catarina Masahuat', 3),
(38, ' Santa Isabel Ishuatán', 3),
(39, ' Santo Domingo Guzmán', 3),
(40, ' Sonsonate', 3),
(41, ' Sonzacate', 3),
(42, ' Agua Caliente', 4),
(43, ' Arcatao', 4),
(44, ' Azacualpa', 4),
(45, ' Chalatenango', 4),
(46, ' Comalapa', 4),
(47, ' Citalá', 4),
(48, ' Concepción Quezaltepeque', 4),
(49, ' Dulce Nombre de María', 4),
(50, ' El Carrizal', 4),
(51, ' El Paraíso', 4),
(52, ' La Laguna', 4),
(53, ' La Palma', 4),
(54, ' La Reina', 4),
(55, ' Las Vueltas', 4),
(56, ' Nueva Concepción', 4),
(57, ' Nueva Trinidad', 4),
(58, ' Nombre de Jesús', 4),
(59, ' Ojos de Agua', 4),
(60, ' Potonico', 4),
(61, ' San Antonio de la Cruz', 4),
(62, ' San Antonio Los Ranchos', 4),
(63, ' San Fernando', 4),
(64, ' San Francisco Lempa', 4),
(65, ' San Francisco Morazán', 4),
(66, ' San Ignacio', 4),
(67, ' San Isidro Labrador', 4),
(68, ' San José Cancasque', 4),
(69, ' San José Las Flores', 4),
(70, ' San Luis del Carmen', 4),
(71, ' San Miguel de Mercedes', 4),
(72, ' San Rafael', 4),
(73, ' Santa Rita', 4),
(74, ' Tejutla', 4),
(75, ' Candelaria', 7),
(76, ' Cojutepeque', 7),
(77, ' El Carmen', 7),
(78, ' El Rosario', 7),
(79, ' Monte San Juan', 7),
(80, ' Oratorio de Concepción', 7),
(81, ' San Bartolomé Perulapía', 7),
(82, ' San Cristóbal', 7),
(83, ' San José Guayabal', 7),
(84, ' San Pedro Perulapán', 7),
(85, ' San Rafael Cedros', 7),
(86, ' San Ramón', 7),
(87, ' Santa Cruz Analquito', 7),
(88, ' Santa Cruz Michapa', 7),
(89, ' Suchitoto', 7),
(90, ' Tenancingo', 7),
(91, ' Aguilares', 6),
(92, ' Apopa', 6),
(93, ' Ayutuxtepeque', 6),
(94, ' Cuscatancingo', 6),
(95, ' Ciudad Delgado', 6),
(96, ' El Paisnal', 6),
(97, ' Guazapa', 6),
(98, ' Ilopango', 6),
(99, ' Mejicanos', 6),
(100, ' Nejapa', 6),
(101, ' Panchimalco', 6),
(102, ' Rosario de Mora', 6),
(103, ' San Marcos', 6),
(104, ' San Martín', 6),
(105, ' San Salvador', 6),
(106, ' Santiago Texacuangos', 6),
(107, ' Santo Tomás', 6),
(108, ' Soyapango', 6),
(109, ' Tonacatepeque', 6),
(110, ' Antiguo Cuscatlán', 5),
(111, ' Chiltiupán', 5),
(112, ' Ciudad Arce', 5),
(113, ' Colón', 5),
(114, ' Comasagua', 5),
(115, ' Huizúcar', 5),
(116, ' Jayaque', 5),
(117, ' Jicalapa', 5),
(118, ' La Libertad', 5),
(119, ' Santa Tecla', 5),
(120, ' Nuevo Cuscatlán', 5),
(121, ' San Juan Opico', 5),
(122, ' Quezaltepeque', 5),
(123, ' Sacacoyo', 5),
(124, ' San José Villanueva', 5),
(125, ' San Matías', 5),
(126, ' San Pablo Tacachico', 5),
(127, ' Talnique', 5),
(128, ' Tamanique', 5),
(129, ' Teotepeque', 5),
(130, ' Tepecoyo', 5),
(131, '  Zaragoza', 5),
(132, ' Apastepeque', 9),
(133, ' Guadalupe', 9),
(134, ' San Cayetano Istepeque', 9),
(135, ' San Esteban Catarina', 9),
(136, ' San Ildefonso', 9),
(137, ' San Lorenzo', 9),
(138, ' San Sebastián', 9),
(139, ' San Vicente', 9),
(140, ' Santa Clara', 9),
(141, ' Santo Domingo', 9),
(142, ' Tecoluca', 9),
(143, ' Tepetitán', 9),
(144, ' Verapaz', 9),
(145, ' Cinquera', 8),
(146, ' Dolores', 8),
(147, ' Guacotecti', 8),
(148, ' Ilobasco', 8),
(149, ' Jutiapa', 8),
(150, ' San Isidro', 8),
(151, ' Sensuntepeque', 8),
(152, ' Tejutepeque', 8),
(153, ' Victoria', 8),
(154, ' Cuyultitán', 10),
(155, ' El Rosario', 10),
(156, ' Jerusalén', 10),
(157, ' Mercedes La Ceiba', 10),
(158, ' Olocuilta', 10),
(159, ' Paraíso de Osorio', 10),
(160, ' San Antonio Masahuat', 10),
(161, ' San Emigdio', 10),
(162, ' San Francisco Chinameca', 10),
(163, ' San Juan Nonualco', 10),
(164, ' San Juan Talpa', 10),
(165, ' San Juan Tepezontes', 10),
(166, ' San Luis Talpa', 10),
(167, ' San Luis La Herradura', 10),
(168, ' San Miguel Tepezontes', 10),
(169, ' San Pedro Masahuat', 10),
(170, ' San Pedro Nonualco', 10),
(171, ' San Rafael Obrajuelo', 10),
(172, ' Santa María Ostuma', 10),
(173, ' Santiago Nonualco', 10),
(174, ' Tapalhuaca', 10),
(175, ' Zacatecoluca', 10),
(176, ' Alegría', 13),
(177, ' Berlín', 13),
(178, ' California', 13),
(179, ' Concepción Batres', 13),
(180, ' El Triunfo', 13),
(181, ' Ereguayquín', 13),
(182, ' Estanzuelas', 13),
(183, ' Jiquilisco', 13),
(184, ' Jucuapa', 13),
(185, ' Jucuarán', 13),
(186, ' Mercedes Umaña', 13),
(187, ' Nueva Granada', 13),
(188, ' Ozatlán', 13),
(189, ' Puerto El Triunfo', 13),
(190, ' San Agustín', 13),
(191, ' San Buenaventura', 13),
(192, ' San Dionisio', 13),
(193, ' San Francisco Javier', 13),
(194, ' Santa Elena', 13),
(195, ' Santa María', 13),
(196, ' Santiago de María', 13),
(197, ' Tecapán', 13),
(198, ' Usulután', 13),
(199, ' Carolina', 12),
(200, ' Chapeltique', 12),
(201, ' Chinameca', 12),
(202, ' Chirilagua', 12),
(203, ' Ciudad Barrios', 12),
(204, ' Comacarán', 12),
(205, ' El Tránsito', 12),
(206, ' Lolotique', 12),
(207, ' Moncagua', 12),
(208, ' Nueva Guadalupe', 12),
(209, ' Nuevo Edén de San Juan', 12),
(210, ' Quelepa', 12),
(211, ' San Antonio del Mosco', 12),
(212, ' San Gerardo', 12),
(213, ' San Jorge', 12),
(214, ' San Luis de la Reina', 12),
(215, ' San Miguel', 12),
(216, ' San Rafael Oriente', 12),
(217, ' Sesori', 12),
(218, ' Uluazapa', 12),
(219, ' Arambala', 11),
(220, ' Cacaopera', 11),
(221, ' Chilanga', 11),
(222, ' Corinto', 11),
(223, ' Delicias de Concepción', 11),
(224, ' El Divisadero', 11),
(225, ' El Rosario', 11),
(226, ' Gualococti', 11),
(227, ' Guatajiagua', 11),
(228, ' Joateca', 11),
(229, ' Jocoaitique', 11),
(230, ' Jocoro', 11),
(231, ' Lolotiquillo', 11),
(232, ' Meanguera', 11),
(233, ' Osicala', 11),
(234, ' Perquín', 11),
(235, ' San Carlos', 11),
(236, ' San Fernando', 11),
(237, ' San Francisco Gotera', 11),
(238, ' San Isidro', 11),
(239, ' San Simón', 11),
(240, ' Sensembra', 11),
(241, ' Sociedad', 11),
(242, '  Torola', 11),
(243, ' Yamabal', 11),
(244, ' Yoloaiquín', 11),
(245, ' Anamorós', 14),
(246, ' Bolívar', 14),
(247, ' Concepción de Oriente', 14),
(248, ' Conchagua', 14),
(249, ' El Carmen', 14),
(250, ' El Sauce', 14),
(251, ' Intipucá', 14),
(252, ' La Unión', 14),
(253, ' Lislique', 14),
(254, ' Meanguera del Golfo', 14),
(255, ' Nueva Esparta', 14),
(256, ' Pasaquina', 14),
(257, ' Polorós', 14),
(258, ' San Alejo', 14),
(259, ' San José', 14),
(260, ' Santa Rosa de Lima', 14),
(261, ' Yayantique', 14),
(262, ' Yucuaiquín', 14);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_tipo_cliente`
--

CREATE TABLE `tb_tipo_cliente` (
  `id_tipo_cliente` int(11) NOT NULL,
  `tipo_cliente` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_tipo_cliente`
--

INSERT INTO `tb_tipo_cliente` (`id_tipo_cliente`, `tipo_cliente`) VALUES
(1, 'Natural'),
(2, 'Empresarial');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_tipo_licencia`
--

CREATE TABLE `tb_tipo_licencia` (
  `id_tipo_licencia` int(11) NOT NULL,
  `tipo_licencia` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_tipo_licencia`
--

INSERT INTO `tb_tipo_licencia` (`id_tipo_licencia`, `tipo_licencia`) VALUES
(1, 'Pesada'),
(2, 'Liviana');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_tipo_placa`
--

CREATE TABLE `tb_tipo_placa` (
  `id_tipo_placa` int(11) NOT NULL,
  `tipo_placa` varchar(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_tipo_placa`
--

INSERT INTO `tb_tipo_placa` (`id_tipo_placa`, `tipo_placa`) VALUES
(2, 'AB');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_tipo_unidad`
--

CREATE TABLE `tb_tipo_unidad` (
  `id_tipo_unidad` int(11) NOT NULL,
  `tipo_unidad` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_tipo_unidad`
--

INSERT INTO `tb_tipo_unidad` (`id_tipo_unidad`, `tipo_unidad`) VALUES
(1, 'Bus'),
(2, 'Microbus'),
(3, 'Camioneta');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_tipo_viaje`
--

CREATE TABLE `tb_tipo_viaje` (
  `id_tipo_viaje` int(11) NOT NULL,
  `tipo_viaje` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_tipo_viaje`
--

INSERT INTO `tb_tipo_viaje` (`id_tipo_viaje`, `tipo_viaje`) VALUES
(1, 'Un destino'),
(2, 'Dos destinos');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_unidad_transporte`
--

CREATE TABLE `tb_unidad_transporte` (
  `id_unidad_transporte` int(11) NOT NULL,
  `id_marca` int(11) NOT NULL,
  `anio` int(4) DEFAULT NULL,
  `VIN` varchar(20) DEFAULT NULL,
  `capacidad` int(3) NOT NULL,
  `id_modelo` int(1) NOT NULL,
  `placa` varchar(15) NOT NULL,
  `id_tipo_placa` int(11) NOT NULL,
  `id_tipo_unidad` int(11) NOT NULL,
  `id_estado_unidad` int(11) NOT NULL,
  `numero_motor` varchar(45) NOT NULL,
  `numero_chasis` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_unidad_transporte`
--

INSERT INTO `tb_unidad_transporte` (`id_unidad_transporte`, `id_marca`, `anio`, `VIN`, `capacidad`, `id_modelo`, `placa`, `id_tipo_placa`, `id_tipo_unidad`, `id_estado_unidad`, `numero_motor`, `numero_chasis`) VALUES
(3, 1, 2018, '1234-5678-90', 31, 1, 'P123P45', 2, 1, 1, 'P12345', 'X6789'),
(6, 1, 2020, '1234567', 23, 1, '123456P', 2, 1, 1, '1234', '87654321'),
(9, 1, 2020, 'p123i45', 12, 1, '23324554', 2, 1, 1, '987789', '345543');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_usuarios`
--

CREATE TABLE `tb_usuarios` (
  `id_usuario` int(11) NOT NULL,
  `id_empleado` int(11) NOT NULL,
  `nombre_usuario` varchar(50) NOT NULL,
  `correo_usuario` varchar(50) NOT NULL,
  `contrasena` varchar(50) NOT NULL,
  `cargo_usuario` int(11) NOT NULL DEFAULT 4,
  `estado` int(11) NOT NULL,
  `pin` varchar(8) NOT NULL,
  `foto_usuario` mediumblob DEFAULT NULL,
  `sesion` int(11) NOT NULL,
  `primer_uso` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_usuarios`
--

INSERT INTO `tb_usuarios` (`id_usuario`, `id_empleado`, `nombre_usuario`, `correo_usuario`, `contrasena`, `cargo_usuario`, `estado`, `pin`, `foto_usuario`, `sesion`, `primer_uso`) VALUES
(36, 8, 'jromerooo', 'juan.romeroramos9@gmail.com', '81dc9bdb52d04dc20036dbd8313ed055', 2, 1, '87889012', NULL, 0, 1),
(51, 5, 'santi', 'santiago.merino2004@gmail.com', '81dc9bdb52d04dc20036dbd8313ed055', 2, 1, '4321', 0x6956424f5277304b47676f414141414e53556845556741414145414141414241434159414141437161584865414141414247644254554541414c4750432f7868425141414346564a52454655654637565732654d33455155547148336e724f3967565059654c306562344934495146424967676b4f767941453030676975676f46416e786777344266684245437a563055524a4368394272516b4a4a6741684552434153495254524951514342336358766d632f33336e745a362f743965356450756e54376332384d764d3833654d52506971364f6753635a2b6e4f37707730624648646f617056444f6430553166335658546e41355437462f42585331656667744f37757272575a6446304d44586e57426a6f4264635145595258374135626366617767464a71505654754b4a52764c746a6e6c7a58456c5a5a52323431563073457931504651484b683867502b6168727244314d31745748524955433658313864546e6f4c79664263715835677271305a3156315a4c6a34716d33684f4d42516e487a6f6b514865567074412f6a446564412b5038715642364a2b537050494555593641385a6c50695a5a5467487356704c5553727474694743666f3951426f6e354b2b2b6a6f74757a424d4d79446655595646725747707a746e44487773796a695632627a6c53655970596b476a50305a4d6837486e316d7463485232646d37416f37726b4e387a6643366d3844314f334c78576353467a494b6f554434394655775a2f45315956576e7544314f37553835456967505974564373573463563262772f346655583952596a71386e4e574b42616139347953484962342b6563546b6456696c4d474252633654675379544a736c726847416b48744e415148512f51554d2f542f4d77366851434c7238744558774c524168356874654a523161733777306e63536d7551425163424e6d6445664354536d634b71755644627672596c6c744f6e38622f3167494f48774a2f4252545474346538387a326d6b45493857315233673577625a5279797864736b5868504a573563336737333261635467704762514f68384f6e5167566746684d45394f737a5a50734e61446758736f6c556f4365504c76516836332f4479576e51505271566662444f75633843756f505a6f5859526254646d6630567a7a6d597a6965435a37725741377065636c525955424c64374241766773596767364f6f4c30585a6a4e67794374366c534c775431544e313568374f7a6f485642675037466f7431306a4130436e513867503971464e65643246736d4b31675442485a7830395750455a6e6f4b516143797875313137424e594b4139614577546f58695461544d392b533150585752315770315771315444675053664945502b7a4447747264707358435548516e446c5a672b4165645748624862485647723741627074464d55466f632b58586f4a587379363662423638546e67343738576a506172524f6f474d337943364f3672614d532b4232704f65394d4f52724365312b386b537a564432413352654e624545596973725469546537627732344f7a7754647379634765774f32483550524671714d3443432b464e6c6245566e3936314539326973366834574368427043565a4862552b6b2f784f524b3536394749384f5a62667451506f673041454830744f63544f636c7251314f59586674513562757741636971307a44766f7265537447757257784d4b466d61665372536c7758302b6971615052742f6677756b4a584656786243373255333751554841453335574b426778474953526366327a532b2f61434c4b306c752f446a76516b536c4d6c74525674685a48324d64734b6b377256544b7a32544e664955434a444546784164672b7136486a4e71584b535a36504433702f2f72554e35724c4d6a3555486e524378396a34624e535a56744b707479397042696c4e70576255492f6b6f4a415a33782b4543716175684a702f6e6a774e3157493074633655495651675a6e6734734558725045446f376470736138563876704d7662715070372f325942514b506e6a4961616a334f7a7433326f497961505250364135786e4f46615852735165504c68536977653348346d544a45534e5458563078762b71482f7949614b5a7630747667456777533076414848365961333259493748797a4d38446f7a506b3762734647596b39777a304961536f50656e4d3441654e433176634150554f366f456b415666367555474646306a45564b61523842796d786c365a4d644a3258775875746b6a505a4c634551496e586c69625236497958386c67624a584452315a78704d466e32344d516a335a594b6d396750506f634e47624752757033553772644574517a30754653714f2f673075504c314c70507a63394936336977304337645852334a364167373869446e4f536270325262516f717a51695354473571396d307733587751764e6448377567632f345a5945394c537363382f6a714b46455165592f437a6c33354a4f4674344b302f6d446748563742797258364e7063732f79462f4c424c6436666e2f656f656a5a6e68415548654a51584f4335727a6c705166344330776c6a30495a427a4b4c542b667736423145397a46464e42644964346e365058372b776e61584c55694348517a4a4f37676f6a416d563334414e4c4e3848645946352f6f3779776c6a4a6d794d31764b6d49424e6b2b694441324f474341596c2f51765a354447626e347665726f62774774472b45713151466776793355583161536a74763151564255323949636a3478726b7948614c4a50337277734453737a615942616142724f31616a345873467a5047386b6431344a796363776665554a304a6b66746545786178445170573647614c78767170696b5349537a7931684d42415742566d5753376743783549566f36736f5459504e4d3052597a4741512b4c6e73394c424e6b5974656a70794d7045644e63506565447a356a58597241787871717861477077713377376243744943674b31414a4c6e49415276666b5159473453456157396c326738506b6c714371616d5457537754364b34414376324f5a4e4d6e355a4d6379664f4461445351337758522b6e764f534a5247584e42356b6b56534151506a655a4b645274306f43587868596b48595a6f674c516b47496259334d2b69416751587772677848304c425a4a42636a485855536731566c7575506635477477654433614856494f7a6f613648714e63646b504254524143736c71726a585945556f4e6b424f754b654159473568735679492b57386e366b6c304f567731336a466344345242487032314a3278726b414b385075397341316d637a63366658424c57426931487943434647774a4457616f336e4b4873716e7050694a6b4570656c44514947556a724c6c32786742326a767a574a4e673566726d594b41744a63694d6b7a552f55372f7861516f414b366774793675397752414c713551762f6f7650497143477754336d71766f7a324d67434e3548474f724669497a485a583754537670615247774a504664506f6c4565663657767a756730393334574c785146426d47316178412f7267686c684c6c436c56545a306d70642b4830426a374b72412f6b53652f777a77465967617843557272595035365031662b3861343162775131676778482b46744354536271796c6349505136507743516142756a4d48342f4569653573786855786a4a766164627a5045584e69695a50312f4e69565242694346576b6b65774751383849445a375865566a75767a454a7473433933756a374547594439586f336f412f704254333477327071646e2b4c7133646f4c364f4d69547543674e636a6e494f484d7446774c757243384330313144657873413435462b643032733339486e36776b55716f382b507a44473163617953444b392f32636577305358674b7041754c3943487a4976516836626837795349747632373469526767584d77756a4f39655056766e7639422b775836354c352b62426f78346e38577450417034573530615141414141424a52553545726b4a6767673d3d, 0, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_viajes`
--

CREATE TABLE `tb_viajes` (
  `id_viaje` int(11) NOT NULL,
  `nombre_viaje` varchar(50) NOT NULL,
  `id_unidad` int(11) NOT NULL,
  `id_empleado` int(11) NOT NULL,
  `fecha_inicio` date NOT NULL,
  `hora_inicio` datetime NOT NULL,
  `tarifa` double(5,2) DEFAULT NULL,
  `id_estado_viaje` int(11) NOT NULL,
  `id_tipo_viaje` int(11) NOT NULL,
  `fecha_retorno` date NOT NULL,
  `hora_retorno` datetime NOT NULL,
  `id_municipio` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura para la vista `tbconductoresview`
--
DROP TABLE IF EXISTS `tbconductoresview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `tbconductoresview`  AS SELECT concat(`a`.`apellidos_empleado`,', ',`a`.`nombres_empleado`) AS `Empleado`, `b`.`numero_licencia` AS `Licencia`, `b`.`fecha_exp_licencia` AS `Fecha Exp.`, `c`.`tipo_licencia` AS `Clase`, `b`.`id_conductores` AS `ID` FROM ((`tb_empleados` `a` join `tb_conductores` `b`) join `tb_tipo_licencia` `c`) WHERE `a`.`id_empleado` = `b`.`id_empleado` AND `b`.`id_tipo_licencia` = `c`.`id_tipo_licencia` AND `a`.`id_cargo` = 1 ;

-- --------------------------------------------------------

--
-- Estructura para la vista `tbusuariosview`
--
DROP TABLE IF EXISTS `tbusuariosview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `tbusuariosview`  AS SELECT `a`.`id_usuario` AS `id_usuario`, `a`.`nombre_usuario` AS `nombre_usuario`, `a`.`correo_usuario` AS `correo_usuario`, `a`.`contrasena` AS `contrasena`, `b`.`nombres_empleado` AS `nombres_empleado`, `c`.`cargo` AS `cargo`, `a`.`foto_usuario` AS `foto_usuario` FROM ((`tb_usuarios` `a` join `tb_empleados` `b`) join `tb_cargo` `c`) WHERE `a`.`id_empleado` = `b`.`id_empleado` AND `a`.`cargo_usuario` = `c`.`id_cargo` ;

-- --------------------------------------------------------

--
-- Estructura para la vista `tbvistaunidad`
--
DROP TABLE IF EXISTS `tbvistaunidad`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `tbvistaunidad`  AS SELECT `e`.`anio` AS `anio`, `e`.`VIN` AS `VIN`, `e`.`capacidad` AS `capacidad`, `e`.`placa` AS `placa`, `a`.`tipo_placa` AS `tipo_placa`, `b`.`tipo_unidad` AS `tipo_unidad`, `c`.`modelo` AS `modelo`, `d`.`marca` AS `marca`, `f`.`estado_unidad` AS `estado_unidad`, `e`.`numero_motor` AS `numero_motor`, `e`.`numero_chasis` AS `numero_chasis` FROM (((((`tb_tipo_placa` `a` join `tb_tipo_unidad` `b`) join `tb_modelo` `c`) join `tb_marca` `d`) join `tb_unidad_transporte` `e`) join `tb_estado_unidad` `f`) WHERE `a`.`id_tipo_placa` = `e`.`id_tipo_placa` AND `b`.`id_tipo_unidad` = `e`.`id_tipo_unidad` AND `c`.`id_modelo` = `e`.`id_modelo` AND `d`.`id_marca` = `e`.`id_marca` AND `f`.`id_estado_unidad` = `e`.`id_estado_unidad` ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tb_cargo`
--
ALTER TABLE `tb_cargo`
  ADD PRIMARY KEY (`id_cargo`);

--
-- Indices de la tabla `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`id_cliente`),
  ADD KEY `fk_cliente_tipo` (`id_tipo_cliente`);

--
-- Indices de la tabla `tb_cliente_viaje`
--
ALTER TABLE `tb_cliente_viaje`
  ADD PRIMARY KEY (`id_cliente_viaje`),
  ADD KEY `fk_tb_cliente_viaje_tb_viajes1_idx` (`id_viaje`),
  ADD KEY `fk_tb_cliente_viaje_tb_cliente1_idx` (`id_cliente`);

--
-- Indices de la tabla `tb_conductores`
--
ALTER TABLE `tb_conductores`
  ADD PRIMARY KEY (`id_conductores`),
  ADD KEY `fk_conductor_empleado_idx` (`id_empleado`),
  ADD KEY `fk_conductoes_tipo_licencia_idx` (`id_tipo_licencia`);

--
-- Indices de la tabla `tb_departamentos`
--
ALTER TABLE `tb_departamentos`
  ADD PRIMARY KEY (`id_departamento`);

--
-- Indices de la tabla `tb_detalle_factura`
--
ALTER TABLE `tb_detalle_factura`
  ADD PRIMARY KEY (`id_detalle_factura`),
  ADD KEY `fk_tb_detalle_factura_tb_factura1_idx` (`id_factura`),
  ADD KEY `fk_tb_detalle_factura_tb_cliente_viaje1_idx` (`id_cliente_viaje`);

--
-- Indices de la tabla `tb_direccion_detalle`
--
ALTER TABLE `tb_direccion_detalle`
  ADD PRIMARY KEY (`id_direccion_detalle`),
  ADD KEY `fk_tb_direccion_detalle_tb_viajes1_idx` (`id_viaje`);

--
-- Indices de la tabla `tb_empleados`
--
ALTER TABLE `tb_empleados`
  ADD PRIMARY KEY (`id_empleado`),
  ADD KEY `fk_conductor_estado` (`id_estado_empleado`),
  ADD KEY `fk_empleado_usuario` (`id_cargo`),
  ADD KEY `fk_empleado_genero_idx` (`id_genero`),
  ADD KEY `fk_empleado_municipio_idx` (`id_municipio`);

--
-- Indices de la tabla `tb_estado_empleado`
--
ALTER TABLE `tb_estado_empleado`
  ADD PRIMARY KEY (`id_estado_empleado`);

--
-- Indices de la tabla `tb_estado_factura`
--
ALTER TABLE `tb_estado_factura`
  ADD PRIMARY KEY (`id_estado_factura`);

--
-- Indices de la tabla `tb_estado_unidad`
--
ALTER TABLE `tb_estado_unidad`
  ADD PRIMARY KEY (`id_estado_unidad`);

--
-- Indices de la tabla `tb_estado_usuarios`
--
ALTER TABLE `tb_estado_usuarios`
  ADD PRIMARY KEY (`id_estado_usuario`);

--
-- Indices de la tabla `tb_estado_viaje`
--
ALTER TABLE `tb_estado_viaje`
  ADD PRIMARY KEY (`id_estado_viaje`);

--
-- Indices de la tabla `tb_factura`
--
ALTER TABLE `tb_factura`
  ADD PRIMARY KEY (`id_factura`),
  ADD KEY `fk_tb_factura_tb_metodo_pago1_idx` (`id_metodo_pago`),
  ADD KEY `fk_tb_factura_tb_estado_factura1_idx` (`id_estado_factura`);

--
-- Indices de la tabla `tb_genero`
--
ALTER TABLE `tb_genero`
  ADD PRIMARY KEY (`id_genero`);

--
-- Indices de la tabla `tb_mantenimiento`
--
ALTER TABLE `tb_mantenimiento`
  ADD PRIMARY KEY (`id_mantenimiento`),
  ADD KEY `fk_unidad_mantenimiento` (`id_unidad_transporte`);

--
-- Indices de la tabla `tb_marca`
--
ALTER TABLE `tb_marca`
  ADD PRIMARY KEY (`id_marca`);

--
-- Indices de la tabla `tb_metodo_pago`
--
ALTER TABLE `tb_metodo_pago`
  ADD PRIMARY KEY (`id_metodo_pago`);

--
-- Indices de la tabla `tb_modelo`
--
ALTER TABLE `tb_modelo`
  ADD PRIMARY KEY (`id_modelo`);

--
-- Indices de la tabla `tb_municipios`
--
ALTER TABLE `tb_municipios`
  ADD PRIMARY KEY (`id_municipio`),
  ADD KEY `fk_municipio_departamento` (`id_departamento`);

--
-- Indices de la tabla `tb_tipo_cliente`
--
ALTER TABLE `tb_tipo_cliente`
  ADD PRIMARY KEY (`id_tipo_cliente`);

--
-- Indices de la tabla `tb_tipo_licencia`
--
ALTER TABLE `tb_tipo_licencia`
  ADD PRIMARY KEY (`id_tipo_licencia`);

--
-- Indices de la tabla `tb_tipo_placa`
--
ALTER TABLE `tb_tipo_placa`
  ADD PRIMARY KEY (`id_tipo_placa`);

--
-- Indices de la tabla `tb_tipo_unidad`
--
ALTER TABLE `tb_tipo_unidad`
  ADD PRIMARY KEY (`id_tipo_unidad`);

--
-- Indices de la tabla `tb_tipo_viaje`
--
ALTER TABLE `tb_tipo_viaje`
  ADD PRIMARY KEY (`id_tipo_viaje`);

--
-- Indices de la tabla `tb_unidad_transporte`
--
ALTER TABLE `tb_unidad_transporte`
  ADD PRIMARY KEY (`id_unidad_transporte`),
  ADD KEY `fk_tipo_unidad` (`id_tipo_unidad`),
  ADD KEY `fk_unidad_estado` (`id_estado_unidad`),
  ADD KEY `fk_unidad_tipo_placa` (`id_tipo_placa`),
  ADD KEY `fk_unidad_modelo` (`id_modelo`),
  ADD KEY `fk_unidad_marca` (`id_marca`);

--
-- Indices de la tabla `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `id_empleado` (`id_empleado`),
  ADD UNIQUE KEY `correo_usuario` (`correo_usuario`),
  ADD UNIQUE KEY `nombre_usuario` (`nombre_usuario`),
  ADD KEY `fk_usuario_empleado_idx` (`id_empleado`),
  ADD KEY `fk_cargo_usuario` (`cargo_usuario`),
  ADD KEY `FK_estado_usuarios` (`estado`);

--
-- Indices de la tabla `tb_viajes`
--
ALTER TABLE `tb_viajes`
  ADD PRIMARY KEY (`id_viaje`),
  ADD KEY `fk_viaje_estado` (`id_estado_viaje`),
  ADD KEY `fk_viaje_conductor` (`id_empleado`),
  ADD KEY `fk_viaje_unidad` (`id_unidad`),
  ADD KEY `fk_viaje_municipio` (`id_municipio`),
  ADD KEY `fk_viaje_tipo_viaje` (`id_tipo_viaje`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tb_cargo`
--
ALTER TABLE `tb_cargo`
  MODIFY `id_cargo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `tb_cliente_viaje`
--
ALTER TABLE `tb_cliente_viaje`
  MODIFY `id_cliente_viaje` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tb_conductores`
--
ALTER TABLE `tb_conductores`
  MODIFY `id_conductores` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `tb_departamentos`
--
ALTER TABLE `tb_departamentos`
  MODIFY `id_departamento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT de la tabla `tb_detalle_factura`
--
ALTER TABLE `tb_detalle_factura`
  MODIFY `id_detalle_factura` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tb_direccion_detalle`
--
ALTER TABLE `tb_direccion_detalle`
  MODIFY `id_direccion_detalle` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tb_empleados`
--
ALTER TABLE `tb_empleados`
  MODIFY `id_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;

--
-- AUTO_INCREMENT de la tabla `tb_estado_empleado`
--
ALTER TABLE `tb_estado_empleado`
  MODIFY `id_estado_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `tb_estado_factura`
--
ALTER TABLE `tb_estado_factura`
  MODIFY `id_estado_factura` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tb_estado_unidad`
--
ALTER TABLE `tb_estado_unidad`
  MODIFY `id_estado_unidad` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `tb_estado_viaje`
--
ALTER TABLE `tb_estado_viaje`
  MODIFY `id_estado_viaje` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `tb_factura`
--
ALTER TABLE `tb_factura`
  MODIFY `id_factura` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tb_genero`
--
ALTER TABLE `tb_genero`
  MODIFY `id_genero` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `tb_mantenimiento`
--
ALTER TABLE `tb_mantenimiento`
  MODIFY `id_mantenimiento` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tb_marca`
--
ALTER TABLE `tb_marca`
  MODIFY `id_marca` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tb_metodo_pago`
--
ALTER TABLE `tb_metodo_pago`
  MODIFY `id_metodo_pago` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `tb_modelo`
--
ALTER TABLE `tb_modelo`
  MODIFY `id_modelo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tb_municipios`
--
ALTER TABLE `tb_municipios`
  MODIFY `id_municipio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=263;

--
-- AUTO_INCREMENT de la tabla `tb_tipo_cliente`
--
ALTER TABLE `tb_tipo_cliente`
  MODIFY `id_tipo_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tb_tipo_licencia`
--
ALTER TABLE `tb_tipo_licencia`
  MODIFY `id_tipo_licencia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tb_tipo_placa`
--
ALTER TABLE `tb_tipo_placa`
  MODIFY `id_tipo_placa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tb_tipo_unidad`
--
ALTER TABLE `tb_tipo_unidad`
  MODIFY `id_tipo_unidad` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `tb_tipo_viaje`
--
ALTER TABLE `tb_tipo_viaje`
  MODIFY `id_tipo_viaje` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tb_unidad_transporte`
--
ALTER TABLE `tb_unidad_transporte`
  MODIFY `id_unidad_transporte` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT de la tabla `tb_viajes`
--
ALTER TABLE `tb_viajes`
  MODIFY `id_viaje` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD CONSTRAINT `fk_cliente_tipo` FOREIGN KEY (`id_tipo_cliente`) REFERENCES `tb_tipo_cliente` (`id_tipo_cliente`);

--
-- Filtros para la tabla `tb_cliente_viaje`
--
ALTER TABLE `tb_cliente_viaje`
  ADD CONSTRAINT `fk_tb_cliente_viaje_tb_cliente1` FOREIGN KEY (`id_cliente`) REFERENCES `tb_cliente` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_cliente_viaje_tb_viajes1` FOREIGN KEY (`id_viaje`) REFERENCES `tb_viajes` (`id_viaje`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tb_conductores`
--
ALTER TABLE `tb_conductores`
  ADD CONSTRAINT `fk_conductoes_tipo_licencia` FOREIGN KEY (`id_tipo_licencia`) REFERENCES `tb_tipo_licencia` (`id_tipo_licencia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_conductor_empleado` FOREIGN KEY (`id_empleado`) REFERENCES `tb_empleados` (`id_empleado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tb_detalle_factura`
--
ALTER TABLE `tb_detalle_factura`
  ADD CONSTRAINT `fk_tb_detalle_factura_tb_cliente_viaje1` FOREIGN KEY (`id_cliente_viaje`) REFERENCES `tb_cliente_viaje` (`id_cliente_viaje`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_detalle_factura_tb_factura1` FOREIGN KEY (`id_factura`) REFERENCES `tb_factura` (`id_factura`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tb_direccion_detalle`
--
ALTER TABLE `tb_direccion_detalle`
  ADD CONSTRAINT `fk_tb_direccion_detalle_tb_viajes1` FOREIGN KEY (`id_viaje`) REFERENCES `tb_viajes` (`id_viaje`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tb_empleados`
--
ALTER TABLE `tb_empleados`
  ADD CONSTRAINT `fk_conductor_estado` FOREIGN KEY (`id_estado_empleado`) REFERENCES `tb_estado_empleado` (`id_estado_empleado`),
  ADD CONSTRAINT `fk_empleado_genero` FOREIGN KEY (`id_genero`) REFERENCES `tb_genero` (`id_genero`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_empleado_municipio` FOREIGN KEY (`id_municipio`) REFERENCES `tb_municipios` (`id_municipio`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_empleado_usuario` FOREIGN KEY (`id_cargo`) REFERENCES `tb_cargo` (`id_cargo`);

--
-- Filtros para la tabla `tb_factura`
--
ALTER TABLE `tb_factura`
  ADD CONSTRAINT `fk_tb_factura_tb_estado_factura1` FOREIGN KEY (`id_estado_factura`) REFERENCES `tb_estado_factura` (`id_estado_factura`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_factura_tb_metodo_pago1` FOREIGN KEY (`id_metodo_pago`) REFERENCES `tb_metodo_pago` (`id_metodo_pago`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tb_mantenimiento`
--
ALTER TABLE `tb_mantenimiento`
  ADD CONSTRAINT `fk_unidad_mantenimiento` FOREIGN KEY (`id_unidad_transporte`) REFERENCES `tb_unidad_transporte` (`id_unidad_transporte`);

--
-- Filtros para la tabla `tb_municipios`
--
ALTER TABLE `tb_municipios`
  ADD CONSTRAINT `fk_municipio_departamento` FOREIGN KEY (`id_departamento`) REFERENCES `tb_departamentos` (`id_departamento`);

--
-- Filtros para la tabla `tb_unidad_transporte`
--
ALTER TABLE `tb_unidad_transporte`
  ADD CONSTRAINT `fk_tipo_unidad` FOREIGN KEY (`id_tipo_unidad`) REFERENCES `tb_tipo_unidad` (`id_tipo_unidad`),
  ADD CONSTRAINT `fk_unidad_estado` FOREIGN KEY (`id_estado_unidad`) REFERENCES `tb_estado_unidad` (`id_estado_unidad`),
  ADD CONSTRAINT `fk_unidad_marca` FOREIGN KEY (`id_marca`) REFERENCES `tb_marca` (`id_marca`),
  ADD CONSTRAINT `fk_unidad_modelo` FOREIGN KEY (`id_modelo`) REFERENCES `tb_modelo` (`id_modelo`),
  ADD CONSTRAINT `fk_unidad_tipo_placa` FOREIGN KEY (`id_tipo_placa`) REFERENCES `tb_tipo_placa` (`id_tipo_placa`);

--
-- Filtros para la tabla `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  ADD CONSTRAINT `fk_estado_usuario` FOREIGN KEY (`estado`) REFERENCES `tb_estado_usuarios` (`id_estado_usuario`),
  ADD CONSTRAINT `fk_usuario_empleado` FOREIGN KEY (`id_empleado`) REFERENCES `tb_empleados` (`id_empleado`);

--
-- Filtros para la tabla `tb_viajes`
--
ALTER TABLE `tb_viajes`
  ADD CONSTRAINT `fk_viaje_conductor` FOREIGN KEY (`id_empleado`) REFERENCES `tb_empleados` (`id_empleado`),
  ADD CONSTRAINT `fk_viaje_estado` FOREIGN KEY (`id_estado_viaje`) REFERENCES `tb_estado_viaje` (`id_estado_viaje`),
  ADD CONSTRAINT `fk_viaje_municipio` FOREIGN KEY (`id_municipio`) REFERENCES `tb_municipios` (`id_municipio`),
  ADD CONSTRAINT `fk_viaje_tipo_viaje` FOREIGN KEY (`id_tipo_viaje`) REFERENCES `tb_tipo_viaje` (`id_tipo_viaje`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_viaje_unidad` FOREIGN KEY (`id_unidad`) REFERENCES `tb_unidad_transporte` (`id_unidad_transporte`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
