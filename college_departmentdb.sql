-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 24, 2024 at 11:19 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `college_departmentdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `college`
--

CREATE TABLE `college` (
  `CollegeID` int(11) NOT NULL,
  `CollegeName` varchar(50) DEFAULT NULL,
  `CollegeCode` varchar(10) DEFAULT NULL,
  `IsActive` bit(1) NOT NULL DEFAULT b'1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `college`
--

INSERT INTO `college` (`CollegeID`, `CollegeName`, `CollegeCode`, `IsActive`) VALUES
(1, 'School of Technology', 'SOT', b'0'),
(2, 'School of Business', 'SOB', b'0'),
(3, 'Lapu-Lapu City College', 'LLCC-1', b'1'),
(7, 'Mandaue City College', 'MCC2024', b'1');

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `depID` int(11) NOT NULL,
  `depName` varchar(50) NOT NULL,
  `depCode` varchar(10) NOT NULL,
  `IsActive` bit(1) NOT NULL DEFAULT b'1',
  `CollegeID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`depID`, `depName`, `depCode`, `IsActive`, `CollegeID`) VALUES
(1, 'sample1sdfgsdfg', 'ss123', b'0', NULL),
(5, 'school of fish', 'fish101', b'0', 7),
(24, 'schooollll', 'schl111', b'0', NULL),
(25, 'School of Technology', 'SOT101', b'1', 7),
(27, 'School of Education', 'SOE12345', b'1', 3),
(28, 'school of wala', 'wala123', b'0', NULL),
(30, 'School of Arts', 'SOA1', b'0', NULL),
(31, 'School of Nursing', 'SON101', b'1', NULL),
(32, 'ADDSAMPLE', '123654', b'0', NULL),
(33, 'Department of Technology', 'DOT1', b'1', 7),
(34, 'Department of Business', 'DOB1', b'1', NULL),
(35, 'Department of Healthcare Management', 'DOH10123', b'1', 3),
(36, 'Department of Business', 'DOB1', b'1', 7);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `college`
--
ALTER TABLE `college`
  ADD PRIMARY KEY (`CollegeID`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`depID`),
  ADD KEY `FK_CollegeID` (`CollegeID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `college`
--
ALTER TABLE `college`
  MODIFY `CollegeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `department`
--
ALTER TABLE `department`
  MODIFY `depID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `department`
--
ALTER TABLE `department`
  ADD CONSTRAINT `FK_CollegeID` FOREIGN KEY (`CollegeID`) REFERENCES `college` (`CollegeID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
