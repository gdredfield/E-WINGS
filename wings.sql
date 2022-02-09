-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 27, 2021 at 10:43 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `wings`
--

-- --------------------------------------------------------

--
-- Table structure for table `badorders`
--

CREATE TABLE `badorders` (
  `bo_id` int(11) NOT NULL,
  `or_id` varchar(50) NOT NULL,
  `qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `badorders`
--

INSERT INTO `badorders` (`bo_id`, `or_id`, `qty`) VALUES
(6, 'ORDR20212', 200);

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `prod_type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`prod_type`) VALUES
('Standard Flavor'),
('New Flavor'),
('Limited Flavor'),
('Classic Flavor');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `custom_id` int(11) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `address` varchar(100) NOT NULL,
  `baranggay` varchar(50) NOT NULL,
  `city` varchar(50) NOT NULL,
  `zip` int(50) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`custom_id`, `fname`, `lname`, `address`, `baranggay`, `city`, `zip`, `email`) VALUES
(1, 'Dianne', 'Gonzales', 'B-32 L-49 Aguinaldo St. ', 'Green Estate', 'Imus', 4102, 'DianneGandaless@gmail.com'),
(2, 'Ira', 'Medina', 'B-21 L-62 Capricon St. Phase I Greengate Subdivision', 'Malagasang II-B', 'Imus', 4103, 'Iraaaaqtmedine@rocketmail.com'),
(5, 'Analiza', 'Zanoba', 'L-72 Einstein St. ', 'Justineville', 'Bacoor', 4102, 'AnalizaBau@gmail.com'),
(6, 'Mariel', 'Flores', 'L-56 Sunshineville', 'Acaciaa', 'Dasmariñas', 4104, 'Marielxxcu@gmail.com'),
(7, 'Percy', 'Jackson', 'BLK-90 Mediterranian St. Greenville', 'Parklane', 'Imus', 4014, 'Percyjackie44@gmail.com'),
(10, 'Default', 'Guest', 'N/A', 'N/A', 'N/A', 0, 'N/A');

-- --------------------------------------------------------

--
-- Table structure for table `ingredients`
--

CREATE TABLE `ingredients` (
  `ing_id` varchar(50) NOT NULL,
  `ing_name` varchar(100) NOT NULL,
  `ing_desc` varchar(200) NOT NULL,
  `ing_price` int(50) NOT NULL,
  `ing_status` varchar(100) NOT NULL,
  `ing_unit` varchar(50) NOT NULL,
  `ing_stock` int(50) DEFAULT NULL,
  `ing_rate` int(50) NOT NULL,
  `rec_date` date NOT NULL,
  `ex_date` date DEFAULT NULL,
  `supplier` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ingredients`
--

INSERT INTO `ingredients` (`ing_id`, `ing_name`, `ing_desc`, `ing_price`, `ing_status`, `ing_unit`, `ing_stock`, `ing_rate`, `rec_date`, `ex_date`, `supplier`) VALUES
('ITEM202101', 'Chicken Wings', 'Main Ingredient', 220, 'Available', 'Kilo', 116, 1, '2021-06-09', '2021-06-10', 'Julius'),
('ITEM202102', 'Mayonnaise', 'Need for Ranch Flavor', 110, 'Available', 'Bottle', 132, 1, '2021-05-26', NULL, ''),
('ITEM202103', 'Vinegar', 'Need for Ranch Flavor', 55, 'Available', 'Bottle', 142, 1, '2021-07-10', '2021-07-10', 'Dgrayman'),
('ITEM202104', 'Sugar', 'Need for 3 Flavor only', 35, 'Available', 'Pack/Kilo', 138, 1, '2021-04-19', NULL, ''),
('ITEM202105', 'Evap/Freshmilk', 'Need for Ranch Flavor', 170, 'Available', 'Bottle', 133, 1, '2021-05-26', NULL, ''),
('ITEM202106', 'Salt', 'Need for 3 Flavor', 35, 'Available', 'Kilo', 117, 1, '2021-05-26', NULL, ''),
('ITEM202107', 'Pepper', 'Need for 2 Flavor', 40, 'Available', 'Pack', 133, 1, '2021-05-03', NULL, ''),
('ITEM202108', 'Spring Onion', 'Need for 2 Flavor', 65, 'Available', 'Kilo/Pack', 125, 1, '2021-05-26', NULL, ''),
('ITEM202109', 'Parmesan Cheese', 'Main Ingredients for Garlic Parmesan', 200, 'Available', 'Pack', 125, 1, '2021-04-25', NULL, ''),
('ITEM202110', 'Hot Sauce', 'Need for Buffalo Flavor', 89, 'Available', 'Bottle', 127, 1, '2021-04-25', NULL, ''),
('ITEM202111', 'Cream', 'Need for Sweet Soy Flavor', 90, 'Available', 'Pack', 151, 1, '2021-05-26', NULL, ''),
('ITEM202112', 'Bacon', 'Main toppings', 150, 'Available', 'Pack', 142, 2, '2021-05-26', NULL, ''),
('ITEM202113', 'Cheese', 'Need for Sweet Soy Flavor', 70, 'Available', 'Pack', 129, 1, '2021-04-24', NULL, ''),
('ITEM202114', 'Cornstarch', 'Need for Cheesy Bacon Flavor', 55, 'Available', 'Kilo/Pack', 138, 1, '2021-04-24', NULL, ''),
('ITEM202115', 'Salted Egg', 'Need for Salted Egg', 130, 'Available', 'Tray', 137, 2, '2021-05-26', NULL, ''),
('ITEM202116', 'Evap/Nestle Cream', 'Need for Salted Egg Flavor', 70, 'Available', 'Pack', 127, 1, '2021-04-23', NULL, ''),
('ITEM202117', 'Butter', 'Need for 4 Flavor only', 70, 'Available', 'Pack', 114, 1, '2021-05-26', NULL, ''),
('ITEM202118', 'Honey', 'Need for 3 Flavor only', 180, 'Available', 'Pack/Bottle', 137, 1, '2021-05-26', NULL, ''),
('ITEM202119', 'Garlic', 'Need for 4 Flavor', 45, 'Available', 'Pack/Kilo', 133, 1, '2021-05-26', NULL, ''),
('ITEM202120', 'Chili', 'Need for Sweet Chili Flavor', 70, 'Available', 'Pack/Kilo', 140, 3, '2021-04-25', NULL, ''),
('ITEM202121', 'Onion', 'Need for 2 Flavor only', 40, 'Available', 'Pack/Kilo', 130, 1, '2021-04-12', NULL, ''),
('ITEM202122', 'Ketchup', 'Need for Sweet Chili Flavor', 90, 'Available', 'Bottle', 129, 1, '2021-04-13', NULL, ''),
('ITEM202123', 'Soy Sauce', 'Need for 2 Flavor only', 85, 'Available', 'Bottle', 101, 1, '2021-06-12', NULL, '');

-- --------------------------------------------------------

--
-- Table structure for table `ordertbl`
--

CREATE TABLE `ordertbl` (
  `or_id` varchar(50) NOT NULL,
  `or_name` varchar(100) NOT NULL,
  `or_desc` varchar(200) NOT NULL,
  `or_price` int(50) NOT NULL,
  `or_status` varchar(100) NOT NULL,
  `or_unit` varchar(50) NOT NULL,
  `or_stock` int(50) NOT NULL,
  `or_rate` int(50) NOT NULL,
  `or_recdate` date NOT NULL,
  `or_exdate` date NOT NULL,
  `supplier` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ordertbl`
--

INSERT INTO `ordertbl` (`or_id`, `or_name`, `or_desc`, `or_price`, `or_status`, `or_unit`, `or_stock`, `or_rate`, `or_recdate`, `or_exdate`, `supplier`) VALUES
('ORDR20211', 'w', 'wewe', 1231, 'Available', 'ea', 95, 32, '2021-07-25', '2021-07-25', 'vawev'),
('ORDR20212', 'sample', 'awe', 111, 'Available', 'wa', 3000, 1, '2021-07-26', '2021-07-26', 'awewaeawe');

-- --------------------------------------------------------

--
-- Table structure for table `prodsettings`
--

CREATE TABLE `prodsettings` (
  `setid` int(11) NOT NULL,
  `proid` varchar(50) DEFAULT NULL,
  `iid` varchar(50) DEFAULT NULL,
  `iname` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `prodsettings`
--

INSERT INTO `prodsettings` (`setid`, `proid`, `iid`, `iname`) VALUES
(115, 'PROD202111', 'ITEM202120', 'Chili'),
(167, 'PROD202110', 'ITEM202101', 'Chicken Wings'),
(168, 'PROD202110', 'ITEM202117', 'Butter'),
(169, 'PROD202110', 'ITEM202119', 'Garlic'),
(170, 'PROD202110', 'ITEM202118', 'Honey'),
(171, 'PROD202111', 'ITEM202101', 'Chicken Wings'),
(172, 'PROD202111', 'ITEM202121', 'Onion'),
(174, 'PROD202111', 'ITEM202122', 'Ketchup'),
(175, 'PROD202111', 'ITEM202123', 'Soy Sauce'),
(176, 'PROD202114', 'ITEM202101', 'Chicken Wings'),
(177, 'PROD202114', 'ITEM202119', 'Garlic'),
(178, 'PROD202114', 'ITEM202102', 'Mayonnaise'),
(179, 'PROD202114', 'ITEM202121', 'Onion'),
(180, 'PROD202114', 'ITEM202103', 'Vinegar'),
(181, 'PROD202114', 'ITEM202104', 'Sugar'),
(182, 'PROD202114', 'ITEM202105', 'Evap/Freshmilk'),
(183, 'PROD202114', 'ITEM202106', 'Salt'),
(184, 'PROD202114', 'ITEM202107', 'Pepper'),
(185, 'PROD202114', 'ITEM202108', 'Spring Onion'),
(186, 'PROD202115', 'ITEM202101', 'Chicken Wings'),
(187, 'PROD202115', 'ITEM202117', 'Butter'),
(188, 'PROD202115', 'ITEM202109', 'Parmesan Cheese'),
(189, 'PROD202115', 'ITEM202108', 'Spring Onion'),
(190, 'PROD202112', 'ITEM202117', 'Butter'),
(191, 'PROD202112', 'ITEM202110', 'Hot Sauce'),
(192, 'PROD202112', 'ITEM202118', 'Honey'),
(193, 'PROD202112', 'ITEM202101', 'Chicken Wings'),
(194, 'PROD202117', 'ITEM202101', 'Chicken Wings'),
(195, 'PROD202117', 'ITEM202123', 'Soy Sauce'),
(196, 'PROD202117', 'ITEM202104', 'Sugar'),
(197, 'PROD202117', 'ITEM202118', 'Honey'),
(198, 'PROD202116', 'ITEM202101', 'Chicken Wings'),
(199, 'PROD202116', 'ITEM202111', 'Cream'),
(200, 'PROD202116', 'ITEM202113', 'Cheese'),
(201, 'PROD202116', 'ITEM202114', 'Cornstarch'),
(202, 'PROD202116', 'ITEM202106', 'Salt'),
(203, 'PROD202113', 'ITEM202101', 'Chicken Wings'),
(204, 'PROD202113', 'ITEM202117', 'Butter'),
(205, 'PROD202113', 'ITEM202121', 'Onion'),
(206, 'PROD202113', 'ITEM202119', 'Garlic'),
(207, 'PROD202113', 'ITEM202115', 'Salted Egg'),
(208, 'PROD202113', 'ITEM202116', 'Evap/Nestle Cream'),
(209, 'PROD202113', 'ITEM202104', 'Sugar'),
(210, 'PROD202113', 'ITEM202106', 'Salt'),
(211, 'PROD202113', 'ITEM202107', 'Pepper'),
(212, 'PROD202111', 'ITEM202119', 'Garlic');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `prod_id` varchar(50) NOT NULL,
  `prod_name` varchar(100) DEFAULT NULL,
  `prodesc` varchar(200) NOT NULL,
  `prod_price` int(100) DEFAULT NULL,
  `prod_type` varchar(100) NOT NULL,
  `prod_stock` int(50) DEFAULT NULL,
  `prod_date` date DEFAULT NULL,
  `prod_status` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`prod_id`, `prod_name`, `prodesc`, `prod_price`, `prod_type`, `prod_stock`, `prod_date`, `prod_status`) VALUES
('PROD202110', 'Honey Garlic', 'Non spicy lovers', 180, 'Standard Flavor', 17, '2021-06-18', 'Available'),
('PROD202111', 'Sweet Chili', 'Balance of sweet and spicy', 180, 'Standard Flavor', 22, '2021-06-12', 'Available'),
('PROD202112', 'Buffalo', 'Spicy lovers', 190, 'Standard Flavor', 17, '2021-06-12', 'Available'),
('PROD202113', 'Salted Egg', 'Egg', 190, 'Standard Flavor', 21, '2021-06-12', 'Available'),
('PROD202114', 'Ranch', 'Mayo based Flavored', 180, 'Standard Flavor', 25, '2021-06-12', 'Available'),
('PROD202115', 'Garlic Parmesan', 'Best Seller', 150, 'Standard Flavor', 14, '2021-06-12', 'Available'),
('PROD202116', 'Cheesy Bacon', 'Bacon With Cheese', 220, 'Standard Flavor', 20, '2021-06-07', 'Available'),
('PROD202117', 'Sweet Soy', 'Classic Sweet Flavored', 170, 'Classic Flavor', 18, '2021-06-12', 'Available');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `sale_code` int(11) NOT NULL,
  `prodid` varchar(50) DEFAULT NULL,
  `proname` varchar(100) DEFAULT NULL,
  `squantity` int(11) NOT NULL,
  `stotal` int(11) NOT NULL,
  `sale_date` date DEFAULT NULL,
  `schange` int(50) NOT NULL,
  `customer_id` int(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`sale_code`, `prodid`, `proname`, `squantity`, `stotal`, `sale_date`, `schange`, `customer_id`) VALUES
(6, 'PROD202116', 'Cheesy Bacon', 3, 660, '2021-04-24', 400, 2),
(11, 'PROD202113', 'Salted Egg', 2, 380, '2021-04-12', 20, NULL),
(16, 'PROD202117', 'Sweet Soy', 2, 340, '2021-04-13', 100, 7),
(17, 'PROD202113', 'Salted Egg', 2, 380, '2021-04-13', 20, NULL),
(20, 'PROD202115', 'Garlic Parmesan', 1, 150, '2021-04-14', 10, NULL),
(21, 'PROD202111', 'Sweet Chili', 2, 360, '2021-04-22', 40, NULL),
(23, 'PROD202114', 'Ranch', 2, 360, '2021-04-23', 0, NULL),
(36, 'PROD202116', 'Cheesy Bacon', 2, 440, '2021-04-25', 10, NULL),
(37, 'PROD202116', 'Cheesy Bacon', 1, 220, '2021-04-25', 30, NULL),
(38, 'PROD202115', 'Garlic Parmesan', 2, 300, '2021-04-25', 0, NULL),
(39, 'PROD202115', 'Garlic Parmesan', 1, 150, '2021-05-03', 30, NULL),
(40, 'PROD202116', 'Cheesy Bacon', 1, 220, '2021-05-03', 30, NULL),
(41, 'PROD202115', 'Garlic Parmesan', 3, 450, '2021-05-03', 50, NULL),
(42, 'PROD202116', 'Cheesy Bacon', 2, 440, '2021-05-03', 50, NULL),
(43, 'PROD202114', 'Ranch', 2, 360, '2021-05-03', 50, NULL),
(44, 'PROD202116', 'Cheesy Bacon', 1, 220, '2021-05-10', 30, NULL),
(45, 'PROD202110', 'Honey Garlic', 1, 180, '2021-01-14', 0, NULL),
(46, 'PROD202110', 'Honey Garlic', 1, 180, '2021-01-15', 0, NULL),
(47, 'PROD202110', 'Honey Garlic', 1, 180, '2021-02-14', 0, NULL),
(48, 'PROD202110', 'Honey Garlic', 1, 180, '2021-02-15', 0, NULL),
(49, 'PROD202110', 'Honey Garlic', 1, 180, '2021-02-16', 0, NULL),
(50, 'PROD202112', 'Buffalo', 1, 190, '2021-02-14', 0, NULL),
(51, 'PROD202112', 'Buffalo', 1, 190, '2021-02-15', 0, NULL),
(52, 'PROD202112', 'Buffalo', 1, 190, '2021-02-16', 0, NULL),
(53, 'PROD202112', 'Buffalo', 1, 190, '2021-02-14', 0, NULL),
(54, 'PROD202112', 'Buffalo', 1, 190, '2021-02-15', 0, NULL),
(55, 'PROD202112', 'Buffalo', 1, 190, '2021-02-20', 0, NULL),
(56, 'PROD202112', 'Buffalo', 1, 190, '2021-03-14', 0, NULL),
(57, 'PROD202112', 'Buffalo', 1, 190, '2021-06-14', 0, NULL),
(58, 'PROD202112', 'Buffalo', 1, 190, '2021-06-15', 0, NULL),
(59, 'PROD202112', 'Buffalo', 1, 190, '2021-06-16', 0, NULL),
(60, 'PROD202117', 'Sweet Soy', 1, 170, '2021-07-14', 0, NULL),
(61, 'PROD202117', 'Sweet Soy', 2, 340, '2021-07-15', 0, NULL),
(63, 'PROD202117', 'Sweet Soy', 5, 850, '2021-07-14', 0, NULL),
(64, 'PROD202117', 'Sweet Soy', 5, 850, '2021-07-15', 0, NULL),
(66, 'PROD202114', 'Ranch', 1, 180, '2021-05-19', 20, 10),
(67, 'PROD202113', 'Salted Egg', 1, 190, '2021-05-19', 10, 10),
(68, 'PROD202115', 'Garlic Parmesan', 1, 150, '2021-05-23', 50, 5),
(69, 'PROD202110', 'Honey Garlic', 1, 180, '2021-05-23', 20, 1),
(70, 'PROD202114', 'Ranch', 1, 180, '2021-05-26', 20, 10),
(71, 'PROD202115', 'Garlic Parmesan', 1, 150, '2021-05-26', 50, 10),
(72, 'PROD202113', 'Salted Egg', 1, 190, '2021-05-26', 10, 10),
(73, 'PROD202110', 'Honey Garlic', 1, 180, '2021-05-26', 30, 10),
(74, 'PROD202112', 'Buffalo', 1, 190, '2021-05-26', 30, 10),
(75, 'PROD202117', 'Sweet Soy', 1, 170, '2021-05-26', 140, 10),
(76, 'PROD202112', 'Buffalo', 1, 190, '2021-05-26', 140, 10),
(77, 'PROD202110', 'Honey Garlic', 1, 180, '2021-05-26', 40, 10),
(78, 'PROD202112', 'Buffalo', 2, 380, '2021-05-26', 40, 10),
(79, 'PROD202110', 'Honey Garlic', 1, 180, '2021-05-26', 40, 10),
(80, 'PROD202114', 'Ranch', 1, 180, '2021-05-26', 40, 10),
(81, 'PROD202115', 'Garlic Parmesan', 1, 150, '2021-05-26', 29, 10),
(82, 'PROD202114', 'Ranch', 1, 180, '2021-05-26', 29, 10),
(84, 'PROD202114', 'Ranch', 1, 180, '2021-05-26', 20, 10),
(85, 'PROD202115', 'Garlic Parmesan', 1, 150, '2021-05-26', 20, 10),
(86, 'PROD202114', 'Ranch', 1, 180, '2021-05-26', 20, 10),
(87, 'PROD202115', 'Garlic Parmesan', 1, 150, '2021-05-26', 20, 10),
(88, 'PROD202114', 'Ranch', 1, 180, '2021-05-26', 20, 10),
(89, 'PROD202115', 'Garlic Parmesan', 1, 150, '2021-05-26', 20, 10),
(90, 'PROD202114', 'Ranch', 1, 180, '2021-05-26', 20, 10),
(91, 'PROD202115', 'Garlic Parmesan', 1, 150, '2021-05-26', 20, 10),
(92, 'PROD202114', 'Ranch', 1, 180, '2021-05-26', 20, 10),
(93, 'PROD202115', 'Garlic Parmesan', 1, 150, '2021-05-26', 300, 10),
(94, 'PROD202114', 'Ranch', 1, 180, '2021-05-26', 300, 10),
(95, 'PROD202113', 'Salted Egg', 1, 190, '2021-05-26', 300, 10),
(96, 'PROD202111', 'Sweet Chili', 1, 180, '2021-05-26', 300, 10),
(97, 'PROD202115', 'Garlic Parmesan', 1, 150, '2021-05-26', 120, 10),
(98, 'PROD202117', 'Sweet Soy', 1, 170, '2021-05-26', 120, 10),
(99, 'PROD202111', 'Sweet Chili', 1, 180, '2021-05-26', 120, 10),
(100, 'PROD202112', 'Buffalo', 2, 380, '2021-05-26', 120, 10),
(101, 'PROD202115', 'Garlic Parmesan', 2, 300, '2021-05-26', 70, 10),
(102, 'PROD202114', 'Ranch', 2, 360, '2021-05-26', 70, 10),
(103, 'PROD202112', 'Buffalo', 3, 570, '2021-05-26', 70, 10),
(104, 'PROD202115', 'Garlic Parmesan', 1, 150, '2021-05-26', 290, 10),
(105, 'PROD202114', 'Ranch', 1, 180, '2021-05-26', 290, 10),
(106, 'PROD202112', 'Buffalo', 1, 190, '2021-05-26', 290, 10),
(107, 'PROD202113', 'Salted Egg', 1, 190, '2021-05-26', 290, 10),
(108, 'PROD202115', 'Garlic Parmesan', 1, 150, '2021-05-26', 300, 10),
(109, 'PROD202114', 'Ranch', 1, 180, '2021-05-26', 300, 10),
(110, 'PROD202111', 'Sweet Chili', 1, 180, '2021-05-26', 300, 10),
(111, 'PROD202112', 'Buffalo', 1, 190, '2021-05-26', 300, 10),
(112, 'PROD202117', 'Sweet Soy', 1, 170, '2021-06-05', 30, 10),
(113, 'PROD202111', 'Sweet Chili', 2, 360, '2021-06-05', 80, 10),
(114, 'PROD202114', 'Ranch', 2, 360, '2021-06-05', 80, 10),
(115, 'PROD202113', 'Salted Egg', 3, 570, '2021-06-05', 80, 7),
(116, 'PROD202116', 'Cheesy Bacon', 2, 440, '2021-06-05', 80, 10),
(117, 'PROD202112', 'Buffalo', 2, 380, '2021-06-05', 80, 10),
(118, 'PROD202112', 'Buffalo', 1, 190, '2021-06-06', 10, 10),
(119, 'PROD202116', 'Cheesy Bacon', 1, 220, '2021-06-06', 30, 10),
(120, 'PROD202114', 'Ranch', 1, 180, '2021-06-06', 20, 6),
(121, 'PROD202112', 'Buffalo', 1, 190, '2021-06-08', 10, 7),
(122, 'PROD202117', 'Sweet Soy', 1, 170, '2021-06-12', 30, 7),
(123, 'PROD202115', 'Garlic Parmesan', 10, 1500, '2021-06-12', 180, 10),
(124, 'PROD202110', 'Honey Garlic', 3, 540, '2021-06-12', 180, 10),
(125, 'PROD202116', 'Cheesy Bacon', 9, 1980, '2021-06-12', 180, 10),
(126, 'PROD202115', 'Garlic Parmesan', 1, 150, '2021-06-12', 0, 10),
(127, 'PROD202112', 'Buffalo', 1, 190, '2021-06-18', 20, 10),
(128, 'PROD202113', 'Salted Egg', 1, 190, '2021-06-18', 20, 10);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `ID` int(10) NOT NULL,
  `user` varchar(50) NOT NULL,
  `pass` varchar(50) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `user`, `pass`, `fname`, `lname`, `email`) VALUES
(1, 'admin', 'admin123', 'Sam', 'Sung', ''),
(2, 'yussless', 'hildabestpick1', 'Julius', 'Fariñas', 'yuyuspogi034@gmail.com'),
(3, 'yoshiro', 'admin123', 'shiroi', 'yoshi', 'blueencountt@gmail.comm'),
(4, 'Nielsanez', '12345678', 'Niele', 'Sañez', 'Nielsanez11@gmail.com'),
(12, 'hunter01', 'admin123', 'Sandra', 'Shoshi', 'sandraellaineshos@gmail.com'),
(13, 'Jayveee', '12345678', 'Niel', 'Sañez', 'product@gmail.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `badorders`
--
ALTER TABLE `badorders`
  ADD PRIMARY KEY (`bo_id`),
  ADD KEY `FK_BadOrders_OrId_Ordertbl_OrId` (`or_id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`custom_id`);

--
-- Indexes for table `ingredients`
--
ALTER TABLE `ingredients`
  ADD PRIMARY KEY (`ing_id`),
  ADD KEY `ing_name` (`ing_name`),
  ADD KEY `ing_stock` (`ing_stock`),
  ADD KEY `ing_rate` (`ing_rate`);

--
-- Indexes for table `ordertbl`
--
ALTER TABLE `ordertbl`
  ADD PRIMARY KEY (`or_id`);

--
-- Indexes for table `prodsettings`
--
ALTER TABLE `prodsettings`
  ADD PRIMARY KEY (`setid`),
  ADD KEY `prodsettings_ibfk_3` (`iname`),
  ADD KEY `proid` (`proid`),
  ADD KEY `iid` (`iid`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`prod_id`),
  ADD KEY `prod_name` (`prod_name`),
  ADD KEY `prod_stock` (`prod_stock`),
  ADD KEY `prod_status` (`prod_status`),
  ADD KEY `prod_price` (`prod_price`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`sale_code`),
  ADD KEY `sales_ibfk_4` (`proname`),
  ADD KEY `sales_ibfk_7` (`customer_id`),
  ADD KEY `prodid` (`prodid`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `badorders`
--
ALTER TABLE `badorders`
  MODIFY `bo_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `custom_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `prodsettings`
--
ALTER TABLE `prodsettings`
  MODIFY `setid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=215;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `sale_code` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=129;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `badorders`
--
ALTER TABLE `badorders`
  ADD CONSTRAINT `FK_BadOrders_OrId_Ordertbl_OrId` FOREIGN KEY (`or_id`) REFERENCES `ordertbl` (`or_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `prodsettings`
--
ALTER TABLE `prodsettings`
  ADD CONSTRAINT `prodsettings_ibfk_3` FOREIGN KEY (`iname`) REFERENCES `ingredients` (`ing_name`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `prodsettings_ibfk_4` FOREIGN KEY (`proid`) REFERENCES `product` (`prod_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `prodsettings_ibfk_5` FOREIGN KEY (`iid`) REFERENCES `ingredients` (`ing_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `sales`
--
ALTER TABLE `sales`
  ADD CONSTRAINT `sales_ibfk_4` FOREIGN KEY (`proname`) REFERENCES `product` (`prod_name`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `sales_ibfk_7` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`custom_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `sales_ibfk_8` FOREIGN KEY (`prodid`) REFERENCES `product` (`prod_id`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
