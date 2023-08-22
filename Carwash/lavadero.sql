-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 17-12-2021 a las 05:58:40
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
-- Base de datos: `lavadero`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `auto`
--

CREATE TABLE `auto` (
  `patente` varchar(10) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `modelo` varchar(50) NOT NULL,
  `año` varchar(4) NOT NULL,
  `dni` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `auto`
--

INSERT INTO `auto` (`patente`, `marca`, `modelo`, `año`, `dni`) VALUES
('ASD', 'SAD', 'DASD', 'DASD', '29013220'),
('ASDASD', 'ASDSADAS', 'DAS', 'ASD', '929999'),
('DASDAS', 'SAD', 'DASDAASD', 'ASDA', '1243232'),
('DASDS ASD ', 'ASDASD', 'DASDAS', 'ASDA', '1243232'),
('KKK787', 'SADASD', 'SADSAD', 'ASDS', '123213'),
('KKK787LLLL', 'xd', 'xd', 'ASDS', '29013220'),
('SADASDAS', 'ASDSADAS', 'ASDASDASDASDAS', 'DASD', '123213');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `persona`
--

CREATE TABLE `persona` (
  `nombre` varchar(50) NOT NULL,
  `dni` varchar(8) NOT NULL,
  `telefono` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `persona`
--

INSERT INTO `persona` (`nombre`, `dni`, `telefono`) VALUES
('ASD ASDaaaaaaaaaa', '123213', '123123'),
('wwwwww', '1243232', '123123123'),
('juan medina', '199999', '1231231232'),
('NICOLAS GALLARDO', '29013220', '1124092102'),
('juan medina', '299999', '1231231232'),
('juan medina', '499999', '1231231232'),
('juan medina', '599999', '1231231232'),
('juan medina', '699999', '1231231232'),
('juan medina', '799999', '1231231232'),
('juan medina', '929999', '1231231232'),
('juan medina', '999999', '1231231232');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipousuarios`
--

CREATE TABLE `tipousuarios` (
  `idTipo` int(11) NOT NULL,
  `Nombre` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tipousuarios`
--

INSERT INTO `tipousuarios` (`idTipo`, `Nombre`) VALUES
(1, 'Administrador'),
(2, 'Usuario');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `turnos`
--

CREATE TABLE `turnos` (
  `fecha` date NOT NULL,
  `hora` varchar(10) NOT NULL,
  `patente` varchar(10) NOT NULL,
  `tiempoEstimado` varchar(10) NOT NULL,
  `tipoLavado` varchar(40) NOT NULL,
  `descripcion` varchar(250) NOT NULL,
  `monto` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `idUser` int(11) NOT NULL,
  `User` varchar(45) NOT NULL,
  `Password` varchar(80) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `idTipoUser` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`idUser`, `User`, `Password`, `Nombre`, `idTipoUser`) VALUES
(1, 'Luchasso', 'admin', 'Lucho suarez', 1),
(2, 'a', '86f7e437faa5a7fce15d1ddcb9eaeaea377667b8', 'perreke 72', 1),
(3, 'NikoTek', '2687196fdf37168b479ed44617a145260026121e', 'nicolas gallardo', 1),
(4, 'asdasd', '5e4cbfa0e7a8df8ce147eee008330f80e7c1d75c', 'asadsad', 1),
(5, 'Nikotekv2', 'd659c10e27d52b00987b65e85d99bce5480adcae', 'Nicolas gallardo', 1),
(6, 'juancito', '99905029b287596384aa1f294b2c1ecc469d20ae', 'juan medina', 1),
(7, 'ASDASD1', '3a52ce780950d4d969792a2559cd519d7ee8c727', 'ASDA SDA', 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `auto`
--
ALTER TABLE `auto`
  ADD PRIMARY KEY (`patente`),
  ADD KEY `dni` (`dni`);

--
-- Indices de la tabla `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`dni`);

--
-- Indices de la tabla `tipousuarios`
--
ALTER TABLE `tipousuarios`
  ADD PRIMARY KEY (`idTipo`);

--
-- Indices de la tabla `turnos`
--
ALTER TABLE `turnos`
  ADD PRIMARY KEY (`fecha`,`patente`),
  ADD KEY `patente` (`patente`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`idUser`),
  ADD KEY `idTipoUser` (`idTipoUser`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tipousuarios`
--
ALTER TABLE `tipousuarios`
  MODIFY `idTipo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `idUser` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `auto`
--
ALTER TABLE `auto`
  ADD CONSTRAINT `auto_ibfk_1` FOREIGN KEY (`dni`) REFERENCES `persona` (`dni`);

--
-- Filtros para la tabla `turnos`
--
ALTER TABLE `turnos`
  ADD CONSTRAINT `turnos_ibfk_1` FOREIGN KEY (`patente`) REFERENCES `auto` (`patente`);

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`idTipoUser`) REFERENCES `tipousuarios` (`idTipo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
