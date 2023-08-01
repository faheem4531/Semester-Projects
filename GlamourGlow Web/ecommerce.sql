-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 23, 2023 at 07:08 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ecommerce`
--

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `cart-id` int(11) NOT NULL,
  `image` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `brand` varchar(100) NOT NULL,
  `price` int(100) NOT NULL,
  `quantity` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cart`
--

INSERT INTO `cart` (`cart-id`, `image`, `name`, `brand`, `price`, `quantity`) VALUES
(32, '', 'coffee face wash', 'IQ organics', 1400, 8),
(33, '', 'Hair crimper', 'Remington', 12000, 10),
(34, '', 'skincare bundle', 'IQ organics', 7100, 1),
(35, '', 'Hair Curler', 'Remington', 9000, 1),
(36, '', 'hair tools', 'no brand', 500, 3),
(37, '', 'Foundation stick', 'Huda Beauty', 4000, 1),
(38, '', 'Primer', 'Huda Beauty', 1800, 1);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `product-ID` int(11) NOT NULL,
  `product-name` varchar(100) NOT NULL,
  `product-brand` varchar(100) NOT NULL,
  `product-price` varchar(100) NOT NULL,
  `image` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`product-ID`, `product-name`, `product-brand`, `product-price`, `image`) VALUES
(1, 'Liquid foundation', 'Huda Beauty', '2500', 'product1.jpg'),
(2, 'Foundation stick', 'Huda Beauty', '4000', 'product2.jpeg'),
(3, 'Primer', 'Huda Beauty', '1800', 'product3.webp'),
(4, 'Pink Tint', 'Huda Beauty', '400', 'product4.jpg'),
(5, 'loose powder', 'Huda Beauty', '2000', 'product5.jpg'),
(6, 'lipstick', 'Huda Beauty', '300', 'product6.webp'),
(7, 'Mascara', 'Huda Beauty', '1200', 'product7.jpg'),
(8, 'eye palette', 'Huda Beauty', '1200', 'product8.webp'),
(9, 'lip shades deal', 'Huda Beauty', '1500', 'product9.webp'),
(10, 'foundation brush', 'Huda Beauty', '300', 'product10.webp'),
(11, 'makeup brushes', 'Huda Beauty', '800', 'product11.webp'),
(12, 'face powder', 'Huda Beauty', '1200', 'product12.webp'),
(13, 'Hydra facial kit', 'IQ organics', '7500', 'product13.webp'),
(14, 'lip care kit', 'IQ organics', '4000', 'product14.webp'),
(15, 'coffee face wash', 'IQ organics', '1400', 'product15.webp'),
(16, 'Acne treatment bundle', 'IQ organics', '6800', 'product16.webp'),
(17, 'pigmentation treatment', 'IQ organics', '6950', 'product17.webp'),
(18, 'Freshening Aloovera Soothing Mist', 'IQ organics', '1200', 'product18.webp'),
(19, 'skin brightening powder', 'IQ organics', '1200', 'product19.webp'),
(20, 'hair serum & coconut oil', 'IQ organics', '2800', 'product20.webp'),
(21, 'brightening serum', 'IQ organics', '1500', 'product21.webp'),
(22, 'Eyelash curler', 'Tweezerman', '1200', 'product22.webp'),
(23, 'Braid Tools', 'no brand', '300', 'product23.jpg'),
(24, 'hair tools', 'no brand', '500', 'product24.jpg'),
(25, 'Hair Tonic', 'IQ organics', '2200', 'product25.webp'),
(26, 'Hair care bundle', 'IQ organics', '6000', 'product26.webp'),
(27, 'skincare bundle', 'IQ organics', '7100', 'product27.webp'),
(28, 'Hair Straightner', 'Remington', '9500', 'product28.webp'),
(29, 'Hair Dryer', 'Remington', '10500', 'product29.webp'),
(30, 'Hair Curler', 'Remington', '9000', 'product30.jpg'),
(31, 'Hair Waver', 'Remington', '11500', 'product31.webp'),
(32, 'Hair crimper', 'Remington', '12000', 'product32.webp');

-- --------------------------------------------------------

--
-- Table structure for table `user_details`
--

CREATE TABLE `user_details` (
  `sign_id` int(11) NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `user_name` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user_details`
--

INSERT INTO `user_details` (`sign_id`, `full_name`, `user_name`, `password`) VALUES
(1, 'noor', 'noor', '123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`cart-id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`product-ID`);

--
-- Indexes for table `user_details`
--
ALTER TABLE `user_details`
  ADD PRIMARY KEY (`sign_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cart`
--
ALTER TABLE `cart`
  MODIFY `cart-id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `product-ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `user_details`
--
ALTER TABLE `user_details`
  MODIFY `sign_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
