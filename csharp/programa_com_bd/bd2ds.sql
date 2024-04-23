-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3308
-- Tempo de geração: 24-Nov-2022 às 12:50
-- Versão do servidor: 8.0.21
-- versão do PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `banco2ds`
--
CREATE DATABASE IF NOT EXISTS `banco2ds` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `banco2ds`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbproduto`
--

DROP TABLE IF EXISTS `tbproduto`;
CREATE TABLE IF NOT EXISTS `tbproduto` (
  `idprod` int NOT NULL AUTO_INCREMENT,
  `produto` varchar(50) NOT NULL,
  `descr` varchar(80) NOT NULL,
  `quant` int NOT NULL,
  `preco` double NOT NULL,
  PRIMARY KEY (`idprod`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `tbproduto`
--

INSERT INTO `tbproduto` (`idprod`, `produto`, `descr`, `quant`, `preco`) VALUES
(1, 'césio-137', 'muito usado para tintas coloridas e brilhantes.', 100, 155),
(2, 'cadeira elétrica', 'Faz uma incrível massagem na nuca quando ligada.', 50, 400),
(3, 'arma de fogo', 'da tiro e mata', 15, 150),
(4, 'bolas', 'de um jovem chamado Leonel.', 2, 15),
(6, 'flor preta', 'ela existe. Bill estava errado.', 1, 100),
(7, 'pipiu', 'não sabemos ao certo se é uma ave ou o orgão genital.', 1, 25);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbusuario`
--

DROP TABLE IF EXISTS `tbusuario`;
CREATE TABLE IF NOT EXISTS `tbusuario` (
  `idusuario` int NOT NULL AUTO_INCREMENT,
  `login` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `nivel` varchar(20) NOT NULL,
  PRIMARY KEY (`idusuario`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `tbusuario`
--

INSERT INTO `tbusuario` (`idusuario`, `login`, `senha`, `nome`, `nivel`) VALUES
(1, '_adm_login', 'xuxubeleza', 'victor', 'adm'),
(2, 'usuario', 'senha', 'usuario', 'usuario'),
(3, 'carlos', 'mariazinha', 'fatima', 'usuario'),
(4, 'playstation', '40028922', 'yudi', 'usuario'),
(5, 'eltondotado', '071215', 'Elton', 'adm'),
(6, 'adm', 'senha', 'adm', 'adm');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
