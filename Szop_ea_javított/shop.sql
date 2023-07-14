-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Júl 14. 08:53
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
-- Adatbázis: `shop`
--
CREATE DATABASE IF NOT EXISTS `shop` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `shop`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `inventory`
--

DROP TABLE IF EXISTS `inventory`;
CREATE TABLE `inventory` (
  `id` int(11) NOT NULL,
  `goods` varchar(100) NOT NULL,
  `price` int(11) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `inventory`
--

INSERT INTO `inventory` (`id`, `goods`, `price`, `quantity`) VALUES
(3, 'Hell', 299, 80),
(4, 'Milka', 300, 70),
(7, 'Tibi csoki', 320, 500),
(10, 'Burn', 250, 90);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `purchasehistory`
--

DROP TABLE IF EXISTS `purchasehistory`;
CREATE TABLE `purchasehistory` (
  `id` int(11) NOT NULL,
  `buyerName` varchar(200) NOT NULL,
  `productName` varchar(200) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `purchasehistory`
--

INSERT INTO `purchasehistory` (`id`, `buyerName`, `productName`, `quantity`) VALUES
(1, 'imretab', 'Hell', 20),
(3, 'admin', 'Hell', 10),
(4, 'imretab', 'Milka', 5),
(5, 'imretab', 'Burn', 30);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `fullName` varchar(200) NOT NULL,
  `username` varchar(100) NOT NULL,
  `passwd` varchar(128) NOT NULL,
  `email` varchar(100) NOT NULL,
  `role` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `user`
--

INSERT INTO `user` (`id`, `fullName`, `username`, `passwd`, `email`, `role`) VALUES
(1, 'The Admin', 'root', 'efd82fbb13ba14ce44f176ea289f57ce08d16a87865f1511753d76f909803afc26583aecfd38bc82c3c11b0baa401c59e4eb9b99eaa1976be303dde457e53cfa', 'root@root.com', 'admin'),
(2, 'Imre', 'imretab', '7837e0064855ddef6e41d19432a94a95630dd8c15e78fc60dbda7ccff6c926fe46ad66bbf46723ad6be6e1b7fd846d8efa3342ece74e562a24d1fc72df40506d', 'imre@imre.com', 'user'),
(3, 'Admin', 'admin', '7fcf4ba391c48784edde599889d6e3f1e47a27db36ecc050cc92f259bfac38afad2c68a1ae804d77075e8fb722503f3eca2b2c1006ee6f6c7b7628cb45fffd1d', 'admin@admin.com', 'admin'),
(7, 'Test', 'testuser', '3c68d56e84db9a87f3b165b05dc8cd2f7df60e32f12d9508280511609980cf3dd6355b65017dc09fa46d4aa51fd140f3e00ec9644dd443defcd2ddfba8fbd13a', 'test@test.com', 'user'),
(8, 'test', 'test', 'ee26b0dd4af7e749aa1a8ee3c10ae9923f618980772e473f8819a5d4940e0db27ac185f8a0e1d5f84f88bc887fd67b143732c304cc5fa9ad8e6f57f50028a8ff', 'test@test', 'user');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `purchasehistory`
--
ALTER TABLE `purchasehistory`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_userID` (`buyerName`),
  ADD KEY `productID` (`productName`);

--
-- A tábla indexei `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `inventory`
--
ALTER TABLE `inventory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT a táblához `purchasehistory`
--
ALTER TABLE `purchasehistory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT a táblához `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
