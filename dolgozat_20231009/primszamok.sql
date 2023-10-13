-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Okt 09. 14:56
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `primszamok`
--
CREATE DATABASE IF NOT EXISTS `primszamok` DEFAULT CHARACTER SET utf32 COLLATE utf32_hungarian_ci;
USE `primszamok`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `primszam`
--

CREATE TABLE `primszam` (
  `primszam` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_hungarian_ci;

--
-- A tábla adatainak kiíratása `primszam`
--

INSERT INTO `primszam` (`primszam`) VALUES
(2),
(3),
(5),
(7),
(11),
(13),
(17),
(19),
(23),
(29),
(31),
(37),
(41),
(43),
(47),
(53),
(59),
(61),
(67),
(71),
(73),
(79),
(83),
(89),
(97);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
