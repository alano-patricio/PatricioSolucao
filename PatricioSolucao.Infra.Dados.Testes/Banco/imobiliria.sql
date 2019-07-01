-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.1.38-MariaDB-0ubuntu0.18.04.1 - Ubuntu 18.04
-- OS do Servidor:               debian-linux-gnu
-- HeidiSQL Versão:              10.1.0.5464
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para ImobiliariaPatricio
CREATE DATABASE IF NOT EXISTS `ImobiliariaPatricio` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `ImobiliariaPatricio`;

-- Copiando estrutura para tabela ImobiliariaPatricio.financeiro
CREATE TABLE IF NOT EXISTS `financeiro` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `valor` bigint(20) NOT NULL DEFAULT '0',
  `operacao` bit(1) NOT NULL DEFAULT b'0',
  `balanco` bigint(20) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela ImobiliariaPatricio.financeiro: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `financeiro` DISABLE KEYS */;
INSERT INTO `financeiro` (`id`, `valor`, `operacao`, `balanco`) VALUES
	(1, 500, b'0', 1000),
	(2, 300, b'1', 1000);
/*!40000 ALTER TABLE `financeiro` ENABLE KEYS */;

-- Copiando estrutura para tabela ImobiliariaPatricio.imovel
CREATE TABLE IF NOT EXISTS `imovel` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `bairro` varchar(50) NOT NULL,
  `rua` varchar(50) NOT NULL,
  `numero` int(11) NOT NULL,
  `pontoReferencia` varchar(50) DEFAULT NULL,
  `observacoes` varchar(50) DEFAULT NULL,
  `tipo` bit(1) NOT NULL,
  `valor` float NOT NULL,
  `situacao` char(1) NOT NULL,
  `id_proprietario` bigint(20) NOT NULL,
  `id_locatario` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_proprietario` (`id_proprietario`),
  KEY `id_locatario` (`id_locatario`),
  CONSTRAINT `id_locatario` FOREIGN KEY (`id_locatario`) REFERENCES `locatario` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `id_proprietario` FOREIGN KEY (`id_proprietario`) REFERENCES `proprietario` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela ImobiliariaPatricio.imovel: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `imovel` DISABLE KEYS */;
/*!40000 ALTER TABLE `imovel` ENABLE KEYS */;

-- Copiando estrutura para tabela ImobiliariaPatricio.locatario
CREATE TABLE IF NOT EXISTS `locatario` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `nome` varchar(70) NOT NULL DEFAULT '0',
  `cpf` varchar(14) NOT NULL DEFAULT '0',
  `rg` varchar(9) NOT NULL DEFAULT '0',
  `data` date NOT NULL,
  `renda` float NOT NULL DEFAULT '0',
  `avalista` bit(1) DEFAULT NULL,
  `nomeAvalista` varchar(70) DEFAULT NULL,
  `cpfAvalista` varchar(14) DEFAULT NULL,
  `rendaAvalista` float DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela ImobiliariaPatricio.locatario: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `locatario` DISABLE KEYS */;
INSERT INTO `locatario` (`id`, `nome`, `cpf`, `rg`, `data`, `renda`, `avalista`, `nomeAvalista`, `cpfAvalista`, `rendaAvalista`) VALUES
	(1, 'Alano Editado', '333.333.333.37', '5.555.555', '1995-12-28', 2500, b'0', '', '', 0);
/*!40000 ALTER TABLE `locatario` ENABLE KEYS */;

-- Copiando estrutura para tabela ImobiliariaPatricio.proprietario
CREATE TABLE IF NOT EXISTS `proprietario` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `rg` varchar(9) NOT NULL,
  `dataNascimento` date NOT NULL,
  `dadosBancarios` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela ImobiliariaPatricio.proprietario: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `proprietario` DISABLE KEYS */;
INSERT INTO `proprietario` (`id`, `nome`, `cpf`, `rg`, `dataNascimento`, `dadosBancarios`) VALUES
	(1, 'Alano EDITADO', '333.333.333.37', '5.555.555', '1995-12-28', 'abc bolinhas');
/*!40000 ALTER TABLE `proprietario` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
