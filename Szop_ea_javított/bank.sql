-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Júl 14. 08:54
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
-- Adatbázis: `bank`
--
CREATE DATABASE IF NOT EXISTS `bank` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `bank`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `TeljesNev` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `passwd` varchar(128) NOT NULL,
  `szamlaszam` varchar(27) NOT NULL,
  `bankNev` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `user`
--

INSERT INTO `user` (`id`, `TeljesNev`, `username`, `passwd`, `szamlaszam`, `bankNev`) VALUES
(1, 'Tabajdi József Imre', 'imretab', '7837e0064855ddef6e41d19432a94a95630dd8c15e78fc60dbda7ccff6c926fe46ad66bbf46723ad6be6e1b7fd846d8efa3342ece74e562a24d1fc72df40506d', '48604264-71937597-14260820', 'OTP'),
(4, 'Mindegy', 'mind1', '54f510032e81fa8c50158818e586f3a8674d0183089d7f66012980ed8951201f1a5851f8315806e806a78f964511eb0e772391ee127c5747a3230d75d756547e', '26981037-59214360-82547693', 'UniCredit');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `utalas`
--

DROP TABLE IF EXISTS `utalas`;
CREATE TABLE `utalas` (
  `id` int(11) NOT NULL,
  `from` varchar(100) NOT NULL,
  `to` varchar(100) NOT NULL,
  `account_number` varchar(27) NOT NULL,
  `money` int(11) NOT NULL,
  `information` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `utalas`
--

INSERT INTO `utalas` (`id`, `from`, `to`, `account_number`, `money`, `information`) VALUES
(2, 'Tabajdi József Imre', 'Mindegy', '26981037-59214360-82547693', 2000, '');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `utalas`
--
ALTER TABLE `utalas`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT a táblához `utalas`
--
ALTER TABLE `utalas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
