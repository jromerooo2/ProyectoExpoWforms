-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema dbsistemaviajes
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema dbsistemaviajes
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `dbsistemaviajes` DEFAULT CHARACTER SET utf8mb4 ;
USE `dbsistemaviajes` ;

-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_cargo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_cargo` (
  `id_cargo` INT(11) NOT NULL AUTO_INCREMENT,
  `cargo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_cargo`))
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_tipo_cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_tipo_cliente` (
  `id_tipo_cliente` INT(11) NOT NULL AUTO_INCREMENT,
  `tipo_cliente` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`id_tipo_cliente`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_cliente` (
  `id_cliente` INT(11) NOT NULL AUTO_INCREMENT,
  `nombres_cliente` VARCHAR(30) NOT NULL,
  `apellidos_cliente` VARCHAR(30) NOT NULL,
  `telefono_cliente` VARCHAR(11) NOT NULL,
  `id_tipo_cliente` INT(11) NOT NULL,
  `direccion_cliente` VARCHAR(100) NOT NULL,
  `correo_cliente` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id_cliente`),
  INDEX `fk_cliente_tipo` (`id_tipo_cliente` ASC),
  CONSTRAINT `fk_cliente_tipo` 
    FOREIGN KEY (`id_tipo_cliente`)
    REFERENCES `dbsistemaviajes`.`tb_tipo_cliente` (`id_tipo_cliente`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_estado_empleado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_estado_empleado` (
  `id_estado_empleado` INT(11) NOT NULL AUTO_INCREMENT,
  `estado_empleado` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`id_estado_empleado`))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_genero`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_genero` (
  `id_genero` INT(1) NOT NULL AUTO_INCREMENT,
  `genero` CHAR(1) NOT NULL,
  PRIMARY KEY (`id_genero`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_departamentos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_departamentos` (
  `id_departamento` INT(11) NOT NULL AUTO_INCREMENT,
  `departamento` VARCHAR(30) NULL DEFAULT NULL,
  PRIMARY KEY (`id_departamento`))
ENGINE = InnoDB
AUTO_INCREMENT = 15
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_municipios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_municipios` (
  `id_municipio` INT(11) NOT NULL AUTO_INCREMENT,
  `municipio` VARCHAR(30) NULL DEFAULT NULL,
  `id_departamento` INT(11) NOT NULL,
  PRIMARY KEY (`id_municipio`),
  INDEX `fk_municipio_departamento` (`id_departamento` ASC),
  CONSTRAINT `fk_municipio_departamento`
    FOREIGN KEY (`id_departamento`)
    REFERENCES `dbsistemaviajes`.`tb_departamentos` (`id_departamento`))
ENGINE = InnoDB
AUTO_INCREMENT = 263
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_empleados`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_empleados` (
  `id_empleado` INT(11) NOT NULL AUTO_INCREMENT,
  `nombres_empleado` VARCHAR(30) NOT NULL,
  `apellidos_empleado` VARCHAR(30) NOT NULL,
  `DUI` VARCHAR(15) NOT NULL,
  `NIT` VARCHAR(20) NOT NULL,
  `direccion_empleado` VARCHAR(200) NOT NULL,
  `telefono_empleado` VARCHAR(11) NOT NULL,
  `id_genero` INT(11) NOT NULL,
  `id_estado_empleado` INT(11) NOT NULL,
  `id_cargo` INT(11) NOT NULL,
  `id_municipio` INT(11) NOT NULL,
  `nacimiento_empleado` DATE NULL,
  PRIMARY KEY (`id_empleado`),
  INDEX `fk_conductor_estado` (`id_estado_empleado` ASC),
  INDEX `fk_empleado_usuario` (`id_cargo` ASC),
  INDEX `fk_empleado_genero_idx` (`id_genero` ASC),
  INDEX `fk_empleado_municipio_idx` (`id_municipio` ASC),
  CONSTRAINT `fk_conductor_estado`
    FOREIGN KEY (`id_estado_empleado`)
    REFERENCES `dbsistemaviajes`.`tb_estado_empleado` (`id_estado_empleado`),
  CONSTRAINT `fk_empleado_genero`
    FOREIGN KEY (`id_genero`)
    REFERENCES `dbsistemaviajes`.`tb_genero` (`id_genero`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_empleado_usuario`
    FOREIGN KEY (`id_cargo`)
    REFERENCES `dbsistemaviajes`.`tb_cargo` (`id_cargo`),
  CONSTRAINT `fk_empleado_municipio`
    FOREIGN KEY (`id_municipio`)
    REFERENCES `dbsistemaviajes`.`tb_municipios` (`id_municipio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_estado_viaje`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_estado_viaje` (
  `id_estado_viaje` INT(11) NOT NULL AUTO_INCREMENT,
  `estado_viaje` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`id_estado_viaje`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_metodo_pago`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_metodo_pago` (
  `id_metodo_pago` INT(11) NOT NULL AUTO_INCREMENT,
  `metodo_pago` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`id_metodo_pago`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_tipo_unidad`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_tipo_unidad` (
  `id_tipo_unidad` INT(11) NOT NULL AUTO_INCREMENT,
  `tipo_unidad` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`id_tipo_unidad`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_estado_unidad`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_estado_unidad` (
  `id_estado_unidad` INT(11) NOT NULL AUTO_INCREMENT,
  `estado_unidad` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`id_estado_unidad`))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_unidad_transporte`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_unidad_transporte` (
  `id_unidad_transporte` INT(11) NOT NULL AUTO_INCREMENT,
  `id_marca` INT(11) NOT NULL,
  `anio` INT(4) NULL DEFAULT NULL,
  `VIN` VARCHAR(20) NOT NULL NULL,
  `capacidad` INT(3) NOT NULL,
  `id_modelo` INT(1) NOT NULL,
  `placa` VARCHAR (15) NOT NULL,
  `id_tipo_placa` INT(11) NOT NULL,
  `id_tipo_unidad` INT(11) NOT NULL,
  `id_estado_unidad` INT(11) NOT NULL,
  `numero_motor` VARCHAR(45) NOT NULL,
  `numero_chasis` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_unidad_transporte`),
  INDEX `fk_tipo_unidad` (`id_tipo_unidad` ASC),
  INDEX `fk_unidad_estado` (`id_estado_unidad` ASC),
  INDEX `fk_unidad_tipo_placa`(`id_tipo_placa` ASC),
  CONSTRAINT `fk_tipo_unidad`
    FOREIGN KEY (`id_tipo_unidad`)
    REFERENCES `dbsistemaviajes`.`tb_tipo_unidad` (`id_tipo_unidad`),
  CONSTRAINT `fk_unidad_estado`
    FOREIGN KEY (`id_estado_unidad`)
    REFERENCES `dbsistemaviajes`.`tb_estado_unidad` (`id_estado_unidad`),
	CONSTRAINT `fk_unidad_tipo_placa`
    FOREIGN KEY (`id_tipo_placa`)
    REFERENCES `dbsistemaviajes`.`tb_tipo_placa`(`id_tipo_placa`),
    CONSTRAINT `fk_unidad_modelo`
    FOREIGN KEY (`id_modelo`)
    REFERENCES `dbsistemaviajes`.`tb_modelo`(`id_modelo`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_viajes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_viajes` (
  `id_viaje` INT(11) NOT NULL AUTO_INCREMENT,
  `nombre_viaje` VARCHAR(50) NOT NULL,
  `id_unidad` INT(11) NOT NULL,
  `id_empleado` INT(11) NOT NULL,
  `fecha_inicio` DATE NOT NULL,
  `hora_inicio` DATETIME NOT NULL,
  `tarifa` DOUBLE(5,2) NULL,
  `id_estado_viaje` INT(11) NOT NULL,
  `id_tipo_viaje` INT(11) NOT NULL,
  `fecha_retorno` DATE NOT NULL,
  `hora_retorno` DATETIME NOT NULL,
  `id_municipio` INT NOT NULL,
  PRIMARY KEY (`id_viaje`),
  INDEX `fk_viaje_estado` (`id_estado_viaje` ASC),
  INDEX `fk_viaje_conductor` (`id_empleado` ASC),
  INDEX `fk_viaje_unidad` (`id_unidad` ASC),
  INDEX `fk_viaje_municipio` (`id_municipio` ASC),
  INDEX `fk_viaje_tipo_viaje` (`id_tipo_viaje` ASC),
  CONSTRAINT `fk_viaje_conductor`
    FOREIGN KEY (`id_empleado`)
    REFERENCES `dbsistemaviajes`.`tb_empleados` (`id_empleado`),
  CONSTRAINT `fk_viaje_estado`
    FOREIGN KEY (`id_estado_viaje`)
    REFERENCES `dbsistemaviajes`.`tb_estado_viaje` (`id_estado_viaje`),
  CONSTRAINT `fk_viaje_unidad`
    FOREIGN KEY (`id_unidad`)
    REFERENCES `dbsistemaviajes`.`tb_unidad_transporte` (`id_unidad_transporte`),
  CONSTRAINT `fk_viaje_municipio`
    FOREIGN KEY (`id_municipio`)
    REFERENCES `dbsistemaviajes`.`tb_municipios` (`id_municipio`),
    CONSTRAINT `fk_viaje_tipo_viaje`
    FOREIGN KEY (`id_tipo_viaje`)
    REFERENCES `dbsistemaviajes`.`tb_tipo_viaje` (`id_tipo_viaje`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_cliente_viaje`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_cliente_viaje` (
  `id_cliente_viaje` INT(11) NOT NULL AUTO_INCREMENT,
  `id_viaje` INT(11) NOT NULL,
  `id_cliente` INT(11) NOT NULL,
  PRIMARY KEY (`id_cliente_viaje`),
  INDEX `fk_tb_cliente_viaje_tb_viajes1_idx` (`id_viaje` ASC),
  INDEX `fk_tb_cliente_viaje_tb_cliente1_idx` (`id_cliente` ASC),
  CONSTRAINT `fk_tb_cliente_viaje_tb_cliente1`
    FOREIGN KEY (`id_cliente`)
    REFERENCES `dbsistemaviajes`.`tb_cliente` (`id_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_cliente_viaje_tb_viajes1`
    FOREIGN KEY (`id_viaje`)
    REFERENCES `dbsistemaviajes`.`tb_viajes` (`id_viaje`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_tipo_licencia`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_tipo_licencia` (
  `id_tipo_licencia` INT(11) NOT NULL AUTO_INCREMENT,
  `tipo_licencia` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_tipo_licencia`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_conductores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_conductores` (
  `id_conductores` INT(11) NOT NULL AUTO_INCREMENT,
  `id_empleado` INT(11) NOT NULL,
  `numero_licencia` VARCHAR(45) NULL DEFAULT NULL,
  `fecha_exp_licencia` VARCHAR(45) NULL DEFAULT NULL,
  `id_tipo_licencia` INT(11) NOT NULL,
  PRIMARY KEY (`id_conductores`),
  INDEX `fk_conductor_empleado_idx` (`id_empleado` ASC),
  INDEX `fk_conductoes_tipo_licencia_idx` (`id_tipo_licencia` ASC),
  CONSTRAINT `fk_conductoes_tipo_licencia`
    FOREIGN KEY (`id_tipo_licencia`)
    REFERENCES `dbsistemaviajes`.`tb_tipo_licencia` (`id_tipo_licencia`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_conductor_empleado`
    FOREIGN KEY (`id_empleado`)
    REFERENCES `dbsistemaviajes`.`tb_empleados` (`id_empleado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_estado_factura`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_estado_factura` (
  `id_estado_factura` INT(11) NOT NULL AUTO_INCREMENT,
  `estado_factura` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`id_estado_factura`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_factura`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_factura` (
  `id_factura` INT(11) NOT NULL AUTO_INCREMENT,
  `id_empleado` INT(11) NULL DEFAULT NULL,
  `id_conductor` INT(11) NULL DEFAULT NULL,
  `id_metodo_pago` INT(11) NOT NULL,
  `id_estado_factura` INT(11) NOT NULL,
  PRIMARY KEY (`id_factura`),
  INDEX `fk_tb_factura_tb_metodo_pago1_idx` (`id_metodo_pago` ASC),
  INDEX `fk_tb_factura_tb_estado_factura1_idx` (`id_estado_factura` ASC),
  CONSTRAINT `fk_tb_factura_tb_estado_factura1`
    FOREIGN KEY (`id_estado_factura`)
    REFERENCES `dbsistemaviajes`.`tb_estado_factura` (`id_estado_factura`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_factura_tb_metodo_pago1`
    FOREIGN KEY (`id_metodo_pago`)
    REFERENCES `dbsistemaviajes`.`tb_metodo_pago` (`id_metodo_pago`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_detalle_factura`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_detalle_factura` (
  `id_detalle_factura` INT(11) NOT NULL AUTO_INCREMENT,
  `monto_parcial` DOUBLE(5,2) NOT NULL,
  `descuento` DOUBLE(5,2) NULL DEFAULT NULL,
  `id_factura` INT(11) NOT NULL,
  `id_cliente_viaje` INT(11) NOT NULL,
  PRIMARY KEY (`id_detalle_factura`),
  INDEX `fk_tb_detalle_factura_tb_factura1_idx` (`id_factura` ASC),
  INDEX `fk_tb_detalle_factura_tb_cliente_viaje1_idx` (`id_cliente_viaje` ASC),
  CONSTRAINT `fk_tb_detalle_factura_tb_cliente_viaje1`
    FOREIGN KEY (`id_cliente_viaje`)
    REFERENCES `dbsistemaviajes`.`tb_cliente_viaje` (`id_cliente_viaje`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_detalle_factura_tb_factura1`
    FOREIGN KEY (`id_factura`)
    REFERENCES `dbsistemaviajes`.`tb_factura` (`id_factura`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_direccion_detalle`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_direccion_detalle` (
  `id_direccion_detalle` INT(11) NOT NULL AUTO_INCREMENT,
  `id_viaje` INT(11) NOT NULL,
  `direccion_partida` VARCHAR(200) NULL DEFAULT NULL,
  `punto_referencia_partida` VARCHAR(200) NULL DEFAULT NULL,
  `direccion_destino` VARCHAR(200) NULL DEFAULT NULL,
  `punto_referencia_destino` VARCHAR(200) NULL DEFAULT NULL,
  `direccion_adicional` VARCHAR(200) NULL DEFAULT NULL,
  `punto_referencia_adicional` VARCHAR(200) NULL DEFAULT NULL,
  PRIMARY KEY (`id_direccion_detalle`),
  INDEX `fk_tb_direccion_detalle_tb_viajes1_idx` (`id_viaje` ASC),
  CONSTRAINT `fk_tb_direccion_detalle_tb_viajes1`
    FOREIGN KEY (`id_viaje`)
    REFERENCES `dbsistemaviajes`.`tb_viajes` (`id_viaje`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_mantenimiento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_mantenimiento` (
  `id_mantenimiento` INT(11) NOT NULL AUTO_INCREMENT,
  `id_unidad_transporte` INT(11) NOT NULL,
  `monto_mantenimiento` DOUBLE(5,2) NOT NULL,
  `ultimo_kilometraje` DOUBLE(5,2) NOT NULL,
  `descripcion` VARCHAR(150) NULL DEFAULT NULL,
  `fecha` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`id_mantenimiento`),
  INDEX `fk_unidad_mantenimiento` (`id_unidad_transporte` ASC),
  CONSTRAINT `fk_unidad_mantenimiento`
    FOREIGN KEY (`id_unidad_transporte`)
    REFERENCES `dbsistemaviajes`.`tb_unidad_transporte` (`id_unidad_transporte`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_marca`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_marca` (
  `id_marca` INT(11) NOT NULL AUTO_INCREMENT,
  `marca` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_marca`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_modelo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_modelo` (
  `id_modelo` INT(11) NOT NULL AUTO_INCREMENT,
  `modelo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_modelo`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;

-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_tipo_placa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_tipo_placa` (
  `id_tipo_placa` INT(11) NOT NULL AUTO_INCREMENT,
  `tipo_placa` VARCHAR(3) NULL DEFAULT NULL,
  PRIMARY KEY (`id_tipo_placa`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_tipo_viaje`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_tipo_viaje` (
  `id_tipo_viaje` INT(11) NOT NULL AUTO_INCREMENT,
  `tipo_viaje` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`id_tipo_viaje`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;


-- -----------------------------------------------------
-- Table `dbsistemaviajes`.`tb_usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tb_usuarios` (
  `id_usuario` INT(11) NOT NULL AUTO_INCREMENT,
  `id_empleado` INT(11) NOT NULL,
  `nombre_usuario` VARCHAR(50) NOT NULL,
  `correo_usuario` VARCHAR(50) NOT NULL,
  `contrasena` VARCHAR(50) NOT NULL,
  `id_cargo_usuario` INT(11) NOT NULL DEFAULT 4,
  PRIMARY KEY (`id_usuario`),
  UNIQUE INDEX `id_empleado` (`id_empleado` ASC),
  UNIQUE INDEX `correo_usuario` (`correo_usuario` ASC),
  UNIQUE INDEX `nombre_usuario` (`nombre_usuario` ASC),
  INDEX `fk_usuario_empleado_idx` (`id_empleado` ASC),
  INDEX `fk_cargo_usuario` (`id_cargo_usuario` ASC),
  CONSTRAINT `fk_cargo_usuario`
    FOREIGN KEY (`id_cargo_usuario`)
    REFERENCES `dbsistemaviajes`.`tb_cargo` (`id_cargo`),
  CONSTRAINT `fk_usuario_empleado`
    FOREIGN KEY (`id_empleado`)
    REFERENCES `dbsistemaviajes`.`tb_empleados` (`id_empleado`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 19
DEFAULT CHARACTER SET = utf8mb4;

USE `dbsistemaviajes` ;

-- -----------------------------------------------------
-- Placeholder table for view `dbsistemaviajes`.`tbusuariosview`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsistemaviajes`.`tbusuariosview` (`id_usuario` INT, `nombre_usuario` INT, `correo_usuario` INT, `contrasena` INT, `nombres_empleado` INT, `cargo` INT);

-- -----------------------------------------------------
-- View `dbsistemaviajes`.`tbusuariosview`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `dbsistemaviajes`.`tbusuariosview`;
USE `dbsistemaviajes`;
CREATE  OR REPLACE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `dbsistemaviajes`.`tbusuariosview` AS select `a`.`id_usuario` AS `id_usuario`,`a`.`nombre_usuario` AS `nombre_usuario`,`a`.`correo_usuario` AS `correo_usuario`,`a`.`contrasena` AS `contrasena`,`b`.`nombres_empleado` AS `nombres_empleado`,`c`.`cargo` AS `cargo` from ((`dbsistemaviajes`.`tb_usuarios` `a` join `dbsistemaviajes`.`tb_empleados` `b`) join `dbsistemaviajes`.`tb_cargo` `c`) where `a`.`id_empleado` = `b`.`id_empleado` and `a`.`id_cargo_usuario` = `c`.`id_cargo`;


ALTER TABLE tb_usuarios
ADD CONSTRAINT fk_estado_usuario
FOREIGN KEY (estado)
REFERENCES tb_estado_usuarios (id_estado_usuario);

ALTER TABLE tb_unidad_transporte
ADD CONSTRAINT fk_unidad_marca
FOREIGN KEY (id_marca)
REFERENCES tb_marca (id_marca);

ALTER TABLE tb_unidad_transporte
ADD nombre_unidad VARCHAR(75) NOT NULL;

CREATE ALGORITHM=UNDEFINED DEFINER=root@localhost SQL SECURITY DEFINER VIEW tbusuariosview  AS SELECT a.id_usuario AS id_usuario, a.nombre_usuario AS nombre_usuario, a.correo_usuario AS correo_usuario, a.contrasena AS contrasena, b.nombres_empleado AS nombres_empleado, c.cargo AS cargo FROM ((tb_usuarios a join tb_empleados b) join tb_cargo c) WHERE a.id_empleado = b.id_empleado AND a.cargo_usuario = c.id_cargo ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
