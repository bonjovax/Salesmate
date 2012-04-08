-- Host: localhost
-- Generation Time: Apr 08, 2012 at 02:40 PM
-- MySQL Server version: 5.5.14
-- Salesmate Version 1.0.1
-- MYSQL Database 5.5.14 or Above Required

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `salesmate`
--

-- --------------------------------------------------------

--
-- Table structure for table `cashieraccount`
--

CREATE TABLE IF NOT EXISTS `cashieraccount` (
  `cashierid` bigint(20) NOT NULL AUTO_INCREMENT,
  `cashieruser` varchar(50) NOT NULL,
  `cashierpass` varchar(30) NOT NULL,
  `isadmin` varchar(10) NOT NULL,
  `cashierfname` varchar(100) NOT NULL,
  `cashiermname` varchar(100) NOT NULL,
  `cashierlname` varchar(100) NOT NULL,
  `datejoined` datetime NOT NULL,
  PRIMARY KEY (`cashierid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=34 ;

--
-- Dumping data for table `cashieraccount`
--

INSERT INTO `cashieraccount` (`cashierid`, `cashieruser`, `cashierpass`, `isadmin`, `cashierfname`, `cashiermname`, `cashierlname`, `datejoined`) VALUES
(20, 'admin', 'admin', 'Yes', 'administrator', 'administrator', 'administrator', '2012-03-06 00:00:00'),
(27, 'abgo', '123456', 'Yes', 'Alfel Benvic', 'Gapol', 'Go', '2012-03-24 00:00:00'),
(31, 'user', 'user', 'No', 'User', 'User', 'User', '2012-03-30 00:00:00'),
(32, 'superadmin', 'salesmate11?', 'Yes', 'Super', 'Duper', 'Admin', '2012-04-07 00:00:00'),
(33, 'superuser', 'naaya', 'No', 'Super', 'Worthless', 'User', '2012-04-07 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `cashieritem`
--

CREATE TABLE IF NOT EXISTS `cashieritem` (
  `plu` bigint(20) NOT NULL,
  `description` varchar(30) NOT NULL,
  `price` decimal(6,2) NOT NULL,
  PRIMARY KEY (`plu`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cashieritem`
--

INSERT INTO `cashieritem` (`plu`, `description`, `price`) VALUES
(10, 'Sperma', 10.00),
(100, 'Joystick', 50.75),
(101, 'Eggcells', 12.00),
(102, 'Yamaha Soldering Iron', 60.00),
(103, 'Soldering Lead', 27.00);

-- --------------------------------------------------------

--
-- Table structure for table `cashierkey`
--

CREATE TABLE IF NOT EXISTS `cashierkey` (
  `keyid` int(11) NOT NULL,
  `keypass` varchar(30) NOT NULL,
  PRIMARY KEY (`keyid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cashierreason`
--

CREATE TABLE IF NOT EXISTS `cashierreason` (
  `reasonid` bigint(20) NOT NULL,
  `reason` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cashierseniorcitizen`
--

CREATE TABLE IF NOT EXISTS `cashierseniorcitizen` (
  `scidno` bigint(20) NOT NULL,
  `scname` varchar(100) NOT NULL,
  `scdob` date NOT NULL,
  `orderid` bigint(20) NOT NULL,
  PRIMARY KEY (`scidno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
