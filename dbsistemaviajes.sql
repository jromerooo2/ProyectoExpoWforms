-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-10-2021 a las 10:40:06
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
`empleado` varchar(62)
,`numero_licencia` varchar(45)
,`fecha_exp_licencia` varchar(45)
,`tipo_licencia` varchar(45)
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
,`foto_usuario` longblob
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `tbviajesview`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `tbviajesview` (
`nombre_viaje` varchar(50)
,`tarifa` double(5,2)
,`tipo_viaje` varchar(20)
,`direccion_destino` varchar(200)
,`direccion_adicional` varchar(200)
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

--
-- Volcado de datos para la tabla `tb_cliente_viaje`
--

INSERT INTO `tb_cliente_viaje` (`id_cliente_viaje`, `id_viaje`, `id_cliente`) VALUES
(1, 36, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_conductores`
--

CREATE TABLE `tb_conductores` (
  `id_conductores` int(11) NOT NULL,
  `id_empleado` int(11) NOT NULL,
  `numero_licencia` varchar(45) DEFAULT NULL,
  `fecha_exp_licencia` varchar(45) DEFAULT NULL,
  `id_tipo_licencia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_conductores`
--

INSERT INTO `tb_conductores` (`id_conductores`, `id_empleado`, `numero_licencia`, `fecha_exp_licencia`, `id_tipo_licencia`) VALUES
(2, 22, '1234567', '2021/05/23', 1);

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

--
-- Volcado de datos para la tabla `tb_direccion_detalle`
--

INSERT INTO `tb_direccion_detalle` (`id_direccion_detalle`, `id_viaje`, `direccion_partida`, `punto_referencia_partida`, `direccion_destino`, `punto_referencia_destino`, `direccion_adicional`, `punto_referencia_adicional`) VALUES
(1, 36, 'mi casa wacho', 'no se solo agregate', 'el tunco', 'no se solo agregate', 'el puerto', 'no se solo agregate');

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
  `nacimiento_empleado` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_empleados`
--

INSERT INTO `tb_empleados` (`id_empleado`, `nombres_empleado`, `apellidos_empleado`, `DUI`, `NIT`, `direccion_empleado`, `telefono_empleado`, `id_genero`, `id_estado_empleado`, `id_cargo`, `id_municipio`, `nacimiento_empleado`) VALUES
(5, 'Jose Santiago', 'Merino Herrera', '1234567-8', '12345678-9', 'Mejicanos', '1234-5678', 2, 1, 2, 148, '2004-08-31'),
(6, 'Kevin Rivas', 'Rivas Delgado', '8765432-1', '98765432-1', 'Soyapango', '7747-4950', 2, 1, 2, 12, '2004-05-12'),
(22, 'Josue ', 'Guinea', '12345678-9', '1234-567891-234-5', 'En su casita haciendo videos suscribete chaval', '+503-1234-5', 1, 1, 1, 26, '2000-10-12'),
(24, 'Locus Systems', 'Locus Systems', '12345677-8', '1235-684235-251-1', 'aoij lajsofja joaaoa iaofaiaoasoasiajsaasdkadj oi', '+123-4567-8', 1, 1, 2, 14, '0000-00-00');

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

--
-- Volcado de datos para la tabla `tb_mantenimiento`
--

INSERT INTO `tb_mantenimiento` (`id_mantenimiento`, `id_unidad_transporte`, `monto_mantenimiento`, `ultimo_kilometraje`, `descripcion`, `fecha`) VALUES
(1, 6, 1231.23, 123456, 'Se realizo un cambio de luces, se reparo el capo y se pinto la puerta', '2021-10-05');

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
(1, 'Mercedes-Benz'),
(2, 'Hyundai'),
(3, 'Mitsubishi'),
(4, 'Toyota');

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
(1, 'Mercedes Minibuses Sprinter'),
(2, 'Mercedes Tourismo'),
(4, 'Hyundai County'),
(5, 'Mitsubishi Microbus L300'),
(6, 'HyundaiCounty New Breeze'),
(7, 'Toyota Coaster'),
(8, 'Toyota Hiace'),
(9, 'Toyota Rav4'),
(10, 'Toyota 4Runner limited');

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
(2, 'Liviana'),
(3, 'Particular');

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
(1, 'Ord'),
(2, 'Esp');

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
(9, 1, 2020, 'p123i45', 12, 1, '23324554', 2, 1, 1, '987789', '345543'),
(10, 1, 2005, '234234234', 123, 1, '1231423423', 2, 1, 3, '54345', '456789');

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
  `pin` varchar(15) NOT NULL,
  `foto_usuario` longblob DEFAULT NULL,
  `sesion` int(11) NOT NULL,
  `primer_uso` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_usuarios`
--

INSERT INTO `tb_usuarios` (`id_usuario`, `id_empleado`, `nombre_usuario`, `correo_usuario`, `contrasena`, `cargo_usuario`, `estado`, `pin`, `foto_usuario`, `sesion`, `primer_uso`) VALUES
(1, 24, 'admin', 'santiago.merino2004@gmail.com', 'e807f1fcf82d132f9bb018ca6738a19f', 2, 1, '1234567890', 0x89504e470d0a1a0a0000000d49484452000000dd000000d20806000000ce92c5cf0000000467414d410000b18f0bfc61050000001974455874536f66747761726500676e6f6d652d73637265656e73686f74ef03bf3e00000cc149444154785eeddde98f14451cc671ff27c423782268a2c6231a23e70b788111ef336a8cb724f082840492e50c88e0b1208820882b4421513914d0c5836bb961051681d7659e4ac6f4ccfef6e8eeeadfec4cbe2f3e017ababb6a483dd3dd55d5ddd75dbb762d00f043e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067840e7046e80067846e84b878f1623874e850f8f9e79fc3e6cd9bc39a356bc2ead5abc3f2e5cbc3e2c58b23fd5dcbf4d9962d5bc2ae5dbbc2df7fff1db7b5f6899189d035d1f9f3e7c39e3d7bc2175f7c113a3a3a4af9e4934fc24f3ffd14fef9e71fb32c8c1c84ae0974445bb76e9d199e14befcf2cb588655369a8fd0393a7af468a5616ba423a84e3fadbaa079089d83dededeb071e34633181e366cd8c069e70842e82ad6dddd1d3b40ac30785ab66c593870e0805947f8227415b972e54af8e69b6fcc0034d3b7df7e1beb66d5193e085d05fafafac2faf5ebcd463f12a86e972e5d32eb8eea11bac4340cf0e9a79f9a8d7d24511db9ce6b0e4297908e1ead10b81ad59581757f842e115d27a538a5d475a04e4fad32b2b44e8a6b468de9718de78bd025b275eb56b351e7b56fdf3e73ff16ad6bed23afaeae2e73ffa806a14be0b7df7e331b7311bffcf28b598665efdebde63e8ad0d0865506d22374255db87021e938dceeddbbcd722c9af06ceda3087d070de25be5202d425792ee08b01a7151bacbc02ac7a275ad7d14a5ef629583b4085d099a4b6935de327efcf147b32ccbce9d3bcd7d9471e4c811b32ca443e84aa862007cc78e1d665916ad6beda30c4dc8b6ca423a84aea0c3870f9b8db6ac1f7ef8c12ccfb27dfb76731f6571b4ab16a12b48e35b56832d6bdbb66d667916ad6beda32c1dc1adf29006a12b40d3a7162e5c6836d8b23421d92ad352e5846aa6885587d015a06e7daba1a6a04176ab4c4b95a1cb3374817c085d019d9d9d66434d214fb77d9537c6eaae73ab4c9447e872d20461ab91a6b269d326b35ccb575f7d65ee231526435783d0e5a407fe580d34153d5ac12ad752f53d7beaa1b5ca4539842e273de6ce6aa0a9e419274bf1e8bec1689a99552eca217439a59ef6d568eddab566b996cf3fffdcdc472aeaa8b1ca4539842e273d5dd96aa0a9284856b996aa6f98d577b5ca4539842e273dd6dc6aa0a9284856b99655ab5699fb48454f8db6ca4539842ea7aa1fa7a72059e55a3efae823731fa9e8bb5ae5a21c4297d3a2458bcc069acaca952bcd722d55ff00e8bb5ae5a21c429793de9e6335d054f21c5df400596b1fa9e8bb5ae5a21c429753d5471705c92ad752f55177c58a1566b92887d0e55475474a9ea38bb57d4a74a45483d0e554f5908158e536faf7df7fcd6d53ca336688e1237439e90da856034d6938cfa1d4836dad6d53d277b5ca4639842ea7944fe01ac8993367ccb2b37a7a7acc6d53621a5835085d4e7ac9a2d5405352678a2633ebee748be6672e5dbad4dc3625263c5783d0e554f5ad3d2309b7f65483d015e0d199d26cdcc45a1d4257c09e3d7bcc86da4ef41dadef8ef2085d017a079dd55053d9bf7f7fb87af5aa59764dcaf72734d2439778305175085d4155deb53d54e044eb58dba6a0ce1aab4ca441e80aaaf2b10d5679166bdb14f4ddacf29006a12ba1aac725586559ac6dcba203a57a84ae84aa8e765659166bdbb2189bab1ea12ba98a674f5ae558ac6dcbc8f3f83f1447e84a4afd5248b1cab158db16a5ef408fa50f429740eaee7bab0c8bb56d51bffffebb5906d2237489a47ad1bf780f19e4797f02ca237489e8761c4d44b61a755ec3191cd791c9da362f8dc90de75622a443e812d23d6e553f8b3225d59549cdfe085d62bdbdbd2d113cd5918e93e6207415e8ebeb8ba76d56631f0954371d95adbaa37a84ae22ba4e4ad9b9924a575717d7704d46e82ad6dddd5df963fb8643753878f0a05947f822740e74ed54e55b5387a2370d6910dfaa1bfc113a47478f1eadfc458e599abcac67ba587541f310ba26d0a4e2aa3a5a7403aaf6cdc4e5918bd035914ef97efdf5d724b708e9bd767ac402c300231fa11b213448ada3939e35a937a0767676c6c79aab03448f5a17fd5dcbf46024ada375b50d03dcad85d001ce081de08cd001ce081de08cd001ce081de08cd001ce081de08cd001ce081de08cd001ce081de08cd001ce081de08cd001ce081de08cd001ce081de08cd001ce081de08cd001ce081de08cd001ce081de08cd001ce081de08cd001ce081d9a6ad4a851e1cf3fff343f6b576d17baf7df7f3fdc73cf3de1ecd9b3e6e759df7df75d5cd7facc93eaacc63798c71e7bccdcb6d5e9bb11ba16a7067cfdf5d787d75e7bcdfc3c2b75e8f45eb8b56bd79a9f0d46757ee9a597e24b230772e2c40973db5647e8da801af07befbd176ebdf5d6b065cb16739d9ad4a19b3d7b76e1d0bdf1c61be667ed8ed0b50135e079f3e685d5ab5787f1e3c787d3a74f9beb49cad0e91d7153a74e25743911ba36a006ac238efefec4134f84575e79a5df3a358385eed2a54b61e9d2a561e2c489e1965b6e0963c68c89d7550b162ce8f7b6d33973e6849b6fbe3936a0463a35ccae6b2912ba3cf5ab517d066be0870e1d8aeb34be64f281071e08fbf7ef0f7ffdf55778ebadb7c2fdf7df1fbfafce26a64f9f1ebababaead6cf3a75ea54fcff79f0c107c34d37dd14eeb8e38e3063c68cb06ddbb6f8f98d37de48e85a9d1af0ac59b3e2df8f1c39126ebffdf6b071e3c67eebc940a13b77ee5c9832654a6cd09b376f8ec13976ec587cfba996ab719f3c79b2df765aee71a42b5abf32a19b3f7f7eb8fbeebbe33bcdf7eddb17af31f5a7962b809b366daadb46f4ff7fefbdf7c61fbfefbfff3e1c3f7e3cbe3976c3860de1d1471f0d1f7ffc71fcb120742d4e0d586afffeecb3cfc25d77dd6536c28142f7faebaf8769d3a6c5a349e3677d7d7df197fad9679fedf79957e88ad6af4ce87444dabb776fddf29a254b96c410352e7ff2c927c333cf3c13ae5cb9d2ef33fd70e8e8377af46842d7ea1a43273367ce0c2fbcf042dd32b142a75f62358403070ed42dcfd269967a481bd7f1085d99fa9509ddcb2fbf5cb72caba7a7276e97bd7efee38f3fe232d525bb6ed68a152b86ac533bbace5ad8caacd0a951e83473fdfaf575cbadd0e945fa8f3cf248dd328b4ee3f40b9f5d5626740a89ae7906b26eddbab86e99fa9509ddca952beb96655dbd7a356ed7ddddfdff3275645947bf2cfd2810ba3660854ed6ac5913c68e1d1baf2b6acbacd0a913e6c5175fac5b6679f3cd3763a742765999d03df7dc73b1d10e44a7635ab74cfdca84ceba66cbd2d1579d2db57fabf3c43abbc8eaeded2574ed60a0d089ae2fa4f66f2b74efbefbeeb04ef5d459d3d833ea717a59a67e6542b775ebd6ba658d1a43f7ce3bef0c594f5deb11ba363058e87494bbf3ce3be3514fff56b77563e8e6ce9d3be42fb4a43ed20d377465ea375403d7113555e814fa575f7db56e9d461ada20746d60b0d089ae8d747da7ebbc9d3b77f60b5d67676778f8e187eb9659525fd30d377465eaa7602858d965593b76ec48163a95ad3a64d769540b39a16b7143854e9e7ffef9d8a3b96bd7ae7ea1d3d0821a90c6a0b2cbb306ea1d9c306142ec40c82e1b8e3ca12b53bf71e3c6c5f1b2ecb22c0daca70addeeddbbe3308306c7b3eb65a95388d0b581e1844e03bb1abbfbe0830ffa854e3efcf0c338a5ebc2850bfd3ebb7cf9721c0753c747e3674f3ffdf4ff03f379e4099d14ad9f2655eb5aab71b9e8d45ba14c153a9934695278fbedb7eb96d5a8eeea85bde1861b085dab1b4ee844b322d4c0acd0e95a430df7f1c71f0f5f7ffd759ceda1d351353c9d32e934d21a6cd7b5e26db7dd166786a8b751e11eec97be266fe88ad64f4747cd0051791ae856fd0e1e3c188fcef7dd775f58b46851d2d0e9f45141d6b59dce2af47fa27a695f9a4db37cf9f2585742d7e2861b3ad12fbf153ad11143d394264f9e1caf016b731b3b3a3acc238c68bc6ad9b265e1a1871e8aa7566a70034d41cbca1b3a29523f51d89e7aeaa938075275d4d42efd3f2814daa74e4b53854e7404d5d15ffb50792a57d3c2b66fdf1e3f576f32a1035029420738237480334207382374803342073823748033420738237480334207382374803342073823748033420738237480334207382374803342073823748033420738237480334207382374803342073823748033420738237480334207382374803342073823748033420738237480334207382374803342073823748033420738237480334207382374803342073823748033420738237480334207382374803342073823748033420738237480334207382374803342073823748033420738237480ab6be13fb4ecf62b27ace5440000000049454e44ae426082, 0, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_viajes`
--

CREATE TABLE `tb_viajes` (
  `id_viaje` int(11) NOT NULL,
  `nombre_viaje` varchar(50) NOT NULL,
  `cliente` int(11) NOT NULL,
  `id_unidad` int(11) NOT NULL,
  `id_empleado` int(11) NOT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `tarifa` double(5,2) DEFAULT NULL,
  `id_estado_viaje` int(11) NOT NULL,
  `id_tipo_viaje` int(11) NOT NULL,
  `fecha_retorno` date DEFAULT NULL,
  `id_municipio` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_viajes`
--

INSERT INTO `tb_viajes` (`id_viaje`, `nombre_viaje`, `cliente`, `id_unidad`, `id_empleado`, `fecha_inicio`, `tarifa`, `id_estado_viaje`, `id_tipo_viaje`, `fecha_retorno`, `id_municipio`) VALUES
(29, 'viaje99', 4, 3, 22, '2021-10-01', 22.00, 2, 2, '2021-01-02', 26),
(34, 'viaje999', 4, 6, 22, '2021-10-01', 22.00, 4, 2, '2021-01-02', 26),
(35, 'viaje69', 4, 3, 22, '2021-10-05', 123.00, 1, 1, '2021-01-01', 26),
(36, 'Viaje a tu brazos bb', 4, 3, 22, '2021-10-05', 123.50, 1, 1, '2021-01-01', 26);

-- --------------------------------------------------------

--
-- Estructura para la vista `tbconductoresview`
--
DROP TABLE IF EXISTS `tbconductoresview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `tbconductoresview`  AS SELECT concat(`a`.`apellidos_empleado`,', ',`a`.`nombres_empleado`) AS `empleado`, `b`.`numero_licencia` AS `numero_licencia`, `b`.`fecha_exp_licencia` AS `fecha_exp_licencia`, `c`.`tipo_licencia` AS `tipo_licencia` FROM ((`tb_empleados` `a` join `tb_conductores` `b`) join `tb_tipo_licencia` `c`) WHERE `a`.`id_empleado` = `b`.`id_empleado` AND `b`.`id_tipo_licencia` = `c`.`id_tipo_licencia` AND `a`.`id_cargo` = 1 ;

-- --------------------------------------------------------

--
-- Estructura para la vista `tbusuariosview`
--
DROP TABLE IF EXISTS `tbusuariosview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `tbusuariosview`  AS SELECT `a`.`id_usuario` AS `id_usuario`, `a`.`nombre_usuario` AS `nombre_usuario`, `a`.`correo_usuario` AS `correo_usuario`, `a`.`contrasena` AS `contrasena`, `b`.`nombres_empleado` AS `nombres_empleado`, `c`.`cargo` AS `cargo`, `a`.`foto_usuario` AS `foto_usuario` FROM ((`tb_usuarios` `a` join `tb_empleados` `b`) join `tb_cargo` `c`) WHERE `a`.`id_empleado` = `b`.`id_empleado` AND `a`.`cargo_usuario` = `c`.`id_cargo` ;

-- --------------------------------------------------------

--
-- Estructura para la vista `tbviajesview`
--
DROP TABLE IF EXISTS `tbviajesview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `tbviajesview`  AS SELECT `a`.`nombre_viaje` AS `nombre_viaje`, `a`.`tarifa` AS `tarifa`, `c`.`tipo_viaje` AS `tipo_viaje`, `b`.`direccion_destino` AS `direccion_destino`, `b`.`direccion_adicional` AS `direccion_adicional` FROM ((`tb_viajes` `a` join `tb_direccion_detalle` `b`) join `tb_tipo_viaje` `c`) WHERE `b`.`id_viaje` = `a`.`id_viaje` AND `a`.`id_tipo_viaje` = `c`.`id_tipo_viaje` ;

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
  ADD UNIQUE KEY `nombre_viaje` (`nombre_viaje`),
  ADD KEY `fk_viaje_estado` (`id_estado_viaje`),
  ADD KEY `fk_viaje_conductor` (`id_empleado`),
  ADD KEY `fk_viaje_unidad` (`id_unidad`),
  ADD KEY `fk_viaje_municipio` (`id_municipio`),
  ADD KEY `fk_viaje_tipo_viaje` (`id_tipo_viaje`),
  ADD KEY `FK_cliente` (`cliente`);

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
  MODIFY `id_cliente_viaje` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tb_conductores`
--
ALTER TABLE `tb_conductores`
  MODIFY `id_conductores` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

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
  MODIFY `id_direccion_detalle` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tb_empleados`
--
ALTER TABLE `tb_empleados`
  MODIFY `id_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

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
  MODIFY `id_genero` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tb_mantenimiento`
--
ALTER TABLE `tb_mantenimiento`
  MODIFY `id_mantenimiento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tb_marca`
--
ALTER TABLE `tb_marca`
  MODIFY `id_marca` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `tb_metodo_pago`
--
ALTER TABLE `tb_metodo_pago`
  MODIFY `id_metodo_pago` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `tb_modelo`
--
ALTER TABLE `tb_modelo`
  MODIFY `id_modelo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

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
  MODIFY `id_tipo_licencia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

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
  MODIFY `id_unidad_transporte` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `tb_viajes`
--
ALTER TABLE `tb_viajes`
  MODIFY `id_viaje` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

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
  ADD CONSTRAINT `fk_estado_usuario` FOREIGN KEY (`estado`) REFERENCES `tb_estado_usuarios` (`id_estado_usuario`);

--
-- Filtros para la tabla `tb_viajes`
--
ALTER TABLE `tb_viajes`
  ADD CONSTRAINT `FK_cliente` FOREIGN KEY (`cliente`) REFERENCES `tb_cliente` (`id_cliente`),
  ADD CONSTRAINT `fk_viaje_conductor` FOREIGN KEY (`id_empleado`) REFERENCES `tb_empleados` (`id_empleado`),
  ADD CONSTRAINT `fk_viaje_estado` FOREIGN KEY (`id_estado_viaje`) REFERENCES `tb_estado_viaje` (`id_estado_viaje`),
  ADD CONSTRAINT `fk_viaje_municipio` FOREIGN KEY (`id_municipio`) REFERENCES `tb_municipios` (`id_municipio`),
  ADD CONSTRAINT `fk_viaje_tipo_viaje` FOREIGN KEY (`id_tipo_viaje`) REFERENCES `tb_tipo_viaje` (`id_tipo_viaje`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_viaje_unidad` FOREIGN KEY (`id_unidad`) REFERENCES `tb_unidad_transporte` (`id_unidad_transporte`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
