-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Ápr 08. 08:47
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
-- Adatbázis: `futver`
--
CREATE DATABASE IF NOT EXISTS `futver` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `futver`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `egyesulet`
--

CREATE TABLE `egyesulet` (
  `eazon` varchar(10) NOT NULL,
  `enev` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `egyesulet`
--

INSERT INTO `egyesulet` (`eazon`, `enev`) VALUES
('DSK', 'Debreceni Sportolók Köre'),
('FTC', 'Ferencvárosi Torna Club'),
('GYSC', 'Győri Sport Club'),
('MTK', 'Magyar Testgyakorlók Köre'),
('SZTC', 'Szegedi Torna Club'),
('UTE', 'Újpesti Torna Egylet');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `eredmeny`
--

CREATE TABLE `eredmeny` (
  `fazon` int(11) NOT NULL,
  `vazon` varchar(255) NOT NULL,
  `ido` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `eredmeny`
--

INSERT INTO `eredmeny` (`fazon`, `vazon`, `ido`) VALUES
(1, 'v001', '02:11:00'),
(1, 'v005', '02:56:00'),
(1, 'v006', '03:21:00'),
(2, 'v001', '02:19:00'),
(2, 'v002', '03:50:00'),
(2, 'v004', '04:16:00'),
(2, 'v005', '03:12:00'),
(2, 'v006', '03:45:00'),
(3, 'v001', '03:01:00'),
(3, 'v005', '03:24:00'),
(3, 'v006', '03:43:00'),
(4, 'v001', '01:25:00'),
(4, 'v003', '04:02:00'),
(4, 'v005', '03:00:00'),
(4, 'v006', '03:28:00'),
(5, 'v001', '01:24:00'),
(5, 'v003', '03:38:00'),
(5, 'v005', '03:00:00'),
(5, 'v006', '03:35:00'),
(6, 'v001', '02:20:00'),
(6, 'v002', '03:42:00'),
(6, 'v003', '03:45:00'),
(6, 'v005', '03:12:00'),
(6, 'v006', '03:54:00'),
(7, 'v001', '02:25:00'),
(7, 'v004', '04:55:00'),
(7, 'v005', '03:04:00'),
(7, 'v006', '03:57:00'),
(8, 'v001', '01:29:00'),
(8, 'v005', '02:57:00'),
(8, 'v006', '04:09:00'),
(9, 'v001', '02:47:00'),
(9, 'v003', '03:29:00'),
(9, 'v005', '03:11:00'),
(9, 'v006', '04:00:00'),
(10, 'v001', '02:50:00'),
(10, 'v002', '03:12:00'),
(10, 'v005', '03:16:00'),
(10, 'v006', '03:19:00'),
(11, 'v001', '01:39:00'),
(11, 'v002', '03:48:00'),
(11, 'v006', '03:27:00'),
(12, 'v001', '01:58:00'),
(12, 'v006', '03:36:00'),
(13, 'v001', '01:25:00'),
(13, 'v002', '03:22:00'),
(13, 'v006', '03:28:00'),
(14, 'v001', '02:44:00'),
(14, 'v003', '03:30:00'),
(14, 'v006', '04:05:00'),
(15, 'v001', '03:02:00'),
(15, 'v004', '04:25:00'),
(15, 'v006', '03:18:00'),
(16, 'v001', '02:13:00'),
(16, 'v003', '03:20:00'),
(16, 'v006', '03:25:00'),
(17, 'v001', '02:16:00'),
(17, 'v003', '04:00:00'),
(17, 'v006', '03:55:00'),
(18, 'v001', '01:34:00'),
(18, 'v006', '03:41:00'),
(19, 'v001', '01:55:00'),
(19, 'v004', '04:48:00'),
(19, 'v006', '03:52:00'),
(20, 'v001', '02:22:00'),
(20, 'v002', '03:18:00'),
(20, 'v006', '03:31:00'),
(21, 'v001', '03:10:00'),
(21, 'v004', '04:22:00'),
(21, 'v006', '03:26:00'),
(22, 'v001', '02:33:00'),
(22, 'v006', '03:40:00'),
(23, 'v002', '03:56:00'),
(23, 'v006', '03:23:00'),
(24, 'v001', '02:18:00'),
(24, 'v002', '03:14:00'),
(24, 'v003', '03:50:00'),
(24, 'v004', '04:36:00'),
(24, 'v006', '03:49:00'),
(25, 'v001', '02:08:00'),
(25, 'v003', '03:29:00'),
(25, 'v006', '03:40:00'),
(26, 'v001', '01:55:00'),
(26, 'v003', '03:49:00'),
(26, 'v004', '04:39:00'),
(26, 'v006', '03:22:00'),
(27, 'v001', '01:56:00'),
(27, 'v006', '03:29:00'),
(28, 'v001', '02:15:00'),
(28, 'v004', '04:27:00'),
(28, 'v006', '03:36:00'),
(29, 'v001', '02:45:00'),
(29, 'v002', '03:41:00'),
(29, 'v004', '04:17:00'),
(29, 'v006', '03:37:00'),
(30, 'v001', '02:36:00'),
(30, 'v002', '03:33:00'),
(30, 'v003', '03:46:00'),
(30, 'v004', '04:28:00'),
(30, 'v006', '03:26:00');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `futo`
--

CREATE TABLE `futo` (
  `fazon` int(11) NOT NULL,
  `fnev` varchar(255) NOT NULL,
  `eazon` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `futo`
--

INSERT INTO `futo` (`fazon`, `fnev`, `eazon`) VALUES
(1, 'Kő Pál', 'DSK'),
(2, 'Papír Sándor', 'MTK'),
(3, 'Olló Márton', 'MTK'),
(4, 'Holló István', 'FTC'),
(5, 'Ferenc Géza', 'GYSC'),
(6, 'Illés Béla', 'UTE'),
(7, 'János Kornél', 'FTC'),
(8, 'Hegedűs Dávid', 'UTE'),
(9, 'Űllő Viktor', 'DSK'),
(10, 'Kerekes Árpád', 'MTK'),
(11, 'Bakai József', 'SZTC'),
(12, 'Német Richárd', 'DSK'),
(13, 'Colos Adrián', 'FTC'),
(14, 'Turi István', 'MTK'),
(15, 'Medve László', 'GYSC'),
(16, 'Szegedi Zoltán', 'GYSC'),
(17, 'Papucs Károly', 'DSK'),
(18, 'Szerencse Géza', 'SZTC'),
(19, 'Orbán Ferenc', 'UTE'),
(20, 'Kovács Viktor', 'FTC'),
(21, 'Papp János', 'UTE'),
(22, 'Kő István', 'MTK'),
(23, 'Ádám Béla', 'GYSC'),
(24, 'Kerekes József', 'SZTC'),
(25, 'Álmos Nándor', 'SZTC'),
(26, 'Győri Krisztián', 'FTC'),
(27, 'Német Attila', 'UTE'),
(28, 'Kovács Károly', 'DSK'),
(29, 'Ferenc József', 'MTK'),
(30, 'Otthon Ottó', 'GYSC');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `verseny`
--

CREATE TABLE `verseny` (
  `vazon` varchar(255) NOT NULL,
  `vnev` varchar(255) NOT NULL,
  `idopont` datetime NOT NULL,
  `helyszin` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `verseny`
--

INSERT INTO `verseny` (`vazon`, `vnev`, `idopont`, `helyszin`) VALUES
('v001', 'FutaPest', '2001-06-01 00:00:00', 'Budapest'),
('v002', 'Marathon I.', '2001-04-26 00:00:00', 'Debrecen'),
('v003', 'Marathon II.', '2001-07-15 00:00:00', 'Sopron'),
('v004', 'Kihívás Napja', '2001-05-22 00:00:00', 'Dunaújváros'),
('v005', 'Európai Bajnokság', '2000-06-06 00:00:00', 'Bécs'),
('v006', 'Olimpia', '2000-08-01 00:00:00', 'Sydney');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `egyesulet`
--
ALTER TABLE `egyesulet`
  ADD PRIMARY KEY (`eazon`);

--
-- A tábla indexei `eredmeny`
--
ALTER TABLE `eredmeny`
  ADD KEY `fazon` (`fazon`),
  ADD KEY `vazon` (`vazon`);

--
-- A tábla indexei `futo`
--
ALTER TABLE `futo`
  ADD PRIMARY KEY (`fazon`),
  ADD KEY `eazon` (`eazon`);

--
-- A tábla indexei `verseny`
--
ALTER TABLE `verseny`
  ADD PRIMARY KEY (`vazon`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `futo`
--
ALTER TABLE `futo`
  MODIFY `fazon` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `eredmeny`
--
ALTER TABLE `eredmeny`
  ADD CONSTRAINT `eredmeny_ibfk_1` FOREIGN KEY (`vazon`) REFERENCES `verseny` (`vazon`),
  ADD CONSTRAINT `eredmeny_ibfk_2` FOREIGN KEY (`fazon`) REFERENCES `futo` (`fazon`);

--
-- Megkötések a táblához `futo`
--
ALTER TABLE `futo`
  ADD CONSTRAINT `futo_ibfk_1` FOREIGN KEY (`eazon`) REFERENCES `egyesulet` (`eazon`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;




/*Lekérdezések:


2.
SELECT e.enev, fnev
FROM futo AS f
INNER JOIN egyesulet AS e ON f.eazon = e.eazon
ORDER BY e.enev ASC, fnev ASC;

3.
SELECT f.fnev, f.eazon, er.ido
FROM verseny AS v
INNER JOIN eredmeny AS er ON er.vazon=v.vazon
INNER JOIN futo AS f ON er.fazon=f.fazon
WHERE v.vnev LIKE "%Olimpia%"
ORDER BY er.ido ASC;

4.
SELECT f.fnev, f.eazon, er.ido
FROM verseny AS v
INNER JOIN eredmeny AS er ON er.vazon=v.vazon
INNER JOIN futo AS f ON er.fazon=f.fazon
WHERE v.vnev LIKE "%Olimpia%" AND er.ido = 
	(SELECT er.ido
	FROM verseny AS v
	INNER JOIN eredmeny AS er ON er.vazon=v.vazon
	INNER JOIN futo AS f ON er.fazon=f.fazon
	WHERE v.vnev LIKE "%Olimpia%"  
	ORDER BY er.ido ASC
	LIMIT 1);

5.
SELECT v.vnev, COUNT(er.fazon) AS "Indulók száma"
FROM verseny AS v
INNER JOIN eredmeny AS er ON er.vazon=v.vazon
GROUP BY v.vazon;

6.
SELECT egy.enev, COUNT(egy.eazon) AS "Egyesületek száma"
FROM egyesulet AS egy
INNER JOIN futo AS f ON f.eazon=egy.eazon
GROUP BY egy.eazon;

7.
SELECT vnev, helyszin, idopont
FROM verseny
WHERE YEAR(idopont) = 2001
ORDER BY 3
LIMIT 1;
*/