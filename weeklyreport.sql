-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 01, 2016 at 06:50 AM
-- Server version: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `weeklyreport`
--

-- --------------------------------------------------------

--
-- Table structure for table `game`
--

CREATE TABLE IF NOT EXISTS `game` (
`gameid` int(11) NOT NULL,
  `game_title` text NOT NULL,
  `slot_type` int(11) NOT NULL,
  `upd_n` int(11) NOT NULL,
  `platform` int(11) NOT NULL,
  `local_producer` int(11) NOT NULL,
  `hq_prod` text NOT NULL,
  `local_deadline` date NOT NULL,
  `ios_deadline` date NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `game`
--

INSERT INTO `game` (`gameid`, `game_title`, `slot_type`, `upd_n`, `platform`, `local_producer`, `hq_prod`, `local_deadline`, `ios_deadline`) VALUES
(1, 'Country Friends', 1, 1, 2, 1, 'Guillaume Something', '2016-01-15', '2016-01-15'),
(13, 'Test 1', 2, 12, 2, 1, 'ola', '0000-00-00', '0000-00-00'),
(14, 'Test 1', 2, 12, 2, 1, 'ola', '2015-02-14', '2015-02-20'),
(15, 'Test 1', 2, 12, 2, 1, 'ola', '0000-00-00', '0000-00-00'),
(16, '2gfdasgs', 0, 3, 2, 0, 'dghdfgh', '2016-02-01', '2016-02-19'),
(17, 'dsfasdfasdf', 2, 2, 2, 0, 'asdfasdfasdf', '2016-02-26', '2016-02-03');

-- --------------------------------------------------------

--
-- Table structure for table `resources`
--

CREATE TABLE IF NOT EXISTS `resources` (
`res_id` int(11) NOT NULL,
  `prod_id` text NOT NULL,
  `prg_alloc` int(11) NOT NULL,
  `qa_alloc` int(11) NOT NULL,
  `gd_alloc` int(11) NOT NULL,
  `gfx_alloc` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `resources`
--

INSERT INTO `resources` (`res_id`, `prod_id`, `prg_alloc`, `qa_alloc`, `gd_alloc`, `gfx_alloc`) VALUES
(1, '1', 8, 15, 1, 1),
(2, '2', 2, 2, 2, 2);

-- --------------------------------------------------------

--
-- Table structure for table `risks_solutions`
--

CREATE TABLE IF NOT EXISTS `risks_solutions` (
`risk_id` int(11) NOT NULL,
  `id_situation_attention` int(255) NOT NULL,
  `risk` text NOT NULL,
  `likelyhood` varchar(10) NOT NULL,
  `impact` varchar(10) NOT NULL,
  `consequense` text NOT NULL,
  `solution` text NOT NULL,
  `eta` varchar(15) NOT NULL,
  `creation_date` date NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `risks_solutions`
--

INSERT INTO `risks_solutions` (`risk_id`, `id_situation_attention`, `risk`, `likelyhood`, `impact`, `consequense`, `solution`, `eta`, `creation_date`) VALUES
(1, 0, 'risks', '2', '2', 'There are some', 'i dont know', '0000-00-00', '0000-00-00'),
(2, 2, 'asdfasdfas', 'High', 'Low', 'adfadsfa', 'adsfadsfdasf', '2016-02-04', '2016-02-01');

-- --------------------------------------------------------

--
-- Table structure for table `situation_attentions`
--

CREATE TABLE IF NOT EXISTS `situation_attentions` (
`id_situation_attention` int(255) NOT NULL,
  `id_game_title` int(11) NOT NULL,
  `status` varchar(255) NOT NULL,
  `situation` varchar(255) NOT NULL,
  `attention` varchar(255) NOT NULL,
  `creation_date` date NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `situation_attentions`
--

INSERT INTO `situation_attentions` (`id_situation_attention`, `id_game_title`, `status`, `situation`, `attention`, `creation_date`) VALUES
(1, 16, 'On Track With Risks', 'adsfasdfdas', 'adsfasdfasdfasdfasdfasv', '0000-00-00'),
(2, 14, 'On Track With Risks', 'dsfasdfa', 'adgadsgfda', '2016-02-01');

-- --------------------------------------------------------

--
-- Table structure for table `user_system`
--

CREATE TABLE IF NOT EXISTS `user_system` (
`id_user` int(11) NOT NULL,
  `user_name` varchar(255) NOT NULL,
  `pass_user` varchar(255) NOT NULL,
  `role_user` varchar(255) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_system`
--

INSERT INTO `user_system` (`id_user`, `user_name`, `pass_user`, `role_user`) VALUES
(1, 'Theresia Suwono', '123456', 'Producer'),
(2, 'Miftahudin Permana', '123456', 'Producer'),
(3, 'Aji Ardiles', '123456', 'Producer'),
(4, 'Robbie Akbar', '123456', 'Producer'),
(5, 'Marthino Yuda', '123456', 'Producer'),
(6, 'Irfan Arghi', '123456', 'Producer'),
(7, 'Berlianto Michael', '123456', 'Producer'),
(8, 'Bayu Santoso', '123456', 'Lead Producer'),
(9, 'Ruben Ramirez', '123456', 'Studio Manager');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `game`
--
ALTER TABLE `game`
 ADD PRIMARY KEY (`gameid`);

--
-- Indexes for table `resources`
--
ALTER TABLE `resources`
 ADD PRIMARY KEY (`res_id`);

--
-- Indexes for table `risks_solutions`
--
ALTER TABLE `risks_solutions`
 ADD PRIMARY KEY (`risk_id`);

--
-- Indexes for table `situation_attentions`
--
ALTER TABLE `situation_attentions`
 ADD PRIMARY KEY (`id_situation_attention`);

--
-- Indexes for table `user_system`
--
ALTER TABLE `user_system`
 ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `game`
--
ALTER TABLE `game`
MODIFY `gameid` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT for table `resources`
--
ALTER TABLE `resources`
MODIFY `res_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `risks_solutions`
--
ALTER TABLE `risks_solutions`
MODIFY `risk_id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `situation_attentions`
--
ALTER TABLE `situation_attentions`
MODIFY `id_situation_attention` int(255) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `user_system`
--
ALTER TABLE `user_system`
MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
