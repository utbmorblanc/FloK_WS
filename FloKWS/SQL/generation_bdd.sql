
-- ---
-- Globals
-- ---

-- SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
-- SET FOREIGN_KEY_CHECKS=0;

-- ---
-- Table 'user'
-- 
-- ---

DROP TABLE IF EXISTS `user`;
		
CREATE TABLE `user` (
  `id_user` BIGINT NULL AUTO_INCREMENT DEFAULT NULL,
  `email_user` VARCHAR(200) NULL DEFAULT NULL,
  `login_user` VARCHAR(200) NULL DEFAULT NULL,
  `password_user` VARCHAR(500) NULL DEFAULT NULL,
  `last_longitude_user` DOUBLE NULL DEFAULT NULL,
  `last_latitude_user` DOUBLE NULL DEFAULT NULL,
  `last_city_user` VARCHAR(200) NULL DEFAULT NULL,
  `id_language_language` INT(3) NULL DEFAULT NULL,
  PRIMARY KEY (`id_user`)
);

-- ---
-- Table 'information'
-- 
-- ---

DROP TABLE IF EXISTS `information`;
		
CREATE TABLE `information` (
  `id_information` BIGINT NULL AUTO_INCREMENT DEFAULT NULL,
  `snow_quality_info` TINYINT NULL DEFAULT NULL,
  `snow_quantity_info` TINYINT NULL DEFAULT NULL,
  `wind_info` TINYINT NULL DEFAULT NULL,
  `weather_info` TINYINT NULL DEFAULT NULL,
  `id_user_user` BIGINT NULL DEFAULT NULL,
  `id_station_station` BIGINT NULL DEFAULT NULL,
  `date_info` DATE NOT NULL,
  `longitude_info` DOUBLE NULL DEFAULT NULL,
  `latitude_info` DOUBLE NULL DEFAULT NULL,
  PRIMARY KEY (`id_information`),
);

-- ---
-- Table 'station'
-- 
-- ---

DROP TABLE IF EXISTS `station`;
		
CREATE TABLE `station` (
  `id_station` BIGINT NULL AUTO_INCREMENT DEFAULT NULL,
  `height_station` INT NULL DEFAULT NULL,
  `km_size_station` INT NULL DEFAULT NULL,
  `name_station` VARCHAR(200) NULL DEFAULT NULL,
  `address_number_station` INT NULL DEFAULT NULL,
  `address_street_station` VARCHAR(200) NULL DEFAULT NULL,
  `address_cp_station` INT NULL DEFAULT NULL,
  `address_city_station` VARCHAR(200) NULL DEFAULT NULL,
  `id_region_region` BIGINT NULL DEFAULT NULL,
  `longitude_station` DOUBLE NULL DEFAULT NULL,
  `latitude_station` DOUBLE NULL DEFAULT NULL,
  PRIMARY KEY (`id_station`)
);

-- ---
-- Table 'region'
-- 
-- ---

DROP TABLE IF EXISTS `region`;
		
CREATE TABLE `region` (
  `id_region` BIGINT NULL AUTO_INCREMENT DEFAULT NULL,
  `name_region` VARCHAR(100) NULL DEFAULT NULL,
  `id_country_country` BIGINT NULL DEFAULT NULL,
  PRIMARY KEY (`id_region`)
);

-- ---
-- Table 'country'
-- 
-- ---

DROP TABLE IF EXISTS `country`;
		
CREATE TABLE `country` (
  `id_country` BIGINT NULL AUTO_INCREMENT DEFAULT NULL,
  `name_country` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`id_country`)
);

-- ---
-- Table 'language'
-- 
-- ---

DROP TABLE IF EXISTS `language`;
		
CREATE TABLE `language` (
  `id_language` INT(3) NULL AUTO_INCREMENT DEFAULT NULL,
  `name_language` VARCHAR(50) NULL DEFAULT NULL,
  PRIMARY KEY (`id_language`)
);

-- ---
-- Table 'alarms'
-- 
-- ---

DROP TABLE IF EXISTS `alarms`;
		
CREATE TABLE `alarms` (
  `id_alarm` BIGINT NULL AUTO_INCREMENT DEFAULT NULL,
  `snow_quality_alarm` TINYINT NULL DEFAULT NULL,
  `snow_quantity_alarm` TINYINT NULL DEFAULT NULL,
  `wind_alarm` TINYINT NULL DEFAULT NULL,
  `weather_alarm` TINYINT NULL DEFAULT NULL,
  `range_alarm` INTEGER(6) NULL DEFAULT NULL,
  `status_alarm` BINARY NULL DEFAULT '0',
  `hour_alarm` INT(2) NULL DEFAULT NULL,
  `minute_alarm` INT(2) NULL DEFAULT NULL,
  `id_user_user` BIGINT NULL DEFAULT NULL,
  `longitude_alarm` DOUBLE NULL DEFAULT NULL,
  `latitude_alarm` DOUBLE NULL DEFAULT NULL,
  PRIMARY KEY (`id_alarm`)
);

-- ---
-- Foreign Keys 
-- ---

ALTER TABLE `user` ADD FOREIGN KEY (id_language_language) REFERENCES `language` (`id_language`);
ALTER TABLE `information` ADD FOREIGN KEY (id_user_user) REFERENCES `user` (`id_user`);
ALTER TABLE `information` ADD FOREIGN KEY (id_station_station) REFERENCES `station` (`id_station`);
ALTER TABLE `station` ADD FOREIGN KEY (id_region_region) REFERENCES `region` (`id_region`);
ALTER TABLE `region` ADD FOREIGN KEY (id_country_country) REFERENCES `country` (`id_country`);
ALTER TABLE `alarms` ADD FOREIGN KEY (id_user_user) REFERENCES `user` (`id_user`);

-- ---
-- Table Properties
-- ---

-- ALTER TABLE `user` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE `information` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE `station` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE `region` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE `country` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE `language` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE `alarms` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ---
-- Test Data
-- ---

-- INSERT INTO `user` (`id_user`,`email_user`,`login_user`,`password_user`,`last_longitude_user`,`last_latitude_user`,`last_city_user`,`id_language_language`) VALUES
-- ('','','','','','','','');
-- INSERT INTO `information` (`id_information`,`snow_quality_info`,`snow_quantity_info`,`wind_info`,`weather_info`,`id_user_user`,`id_station_station`,`date_info`,`longitude_info`,`latitude_info`) VALUES
-- ('','','','','','','','','','');
-- INSERT INTO `station` (`id_station`,`height_station`,`km_size_station`,`name_station`,`address_number_station`,`address_street_station`,`address_cp_station`,`address_city_station`,`id_region_region`,`longitude_station`,`latitude_station`) VALUES
-- ('','','','','','','','','','','');
-- INSERT INTO `region` (`id_region`,`name_region`,`id_country_country`) VALUES
-- ('','','');
-- INSERT INTO `country` (`id_country`,`name_country`) VALUES
-- ('','');
-- INSERT INTO `language` (`id_language`,`name_language`) VALUES
-- ('','');
-- INSERT INTO `alarms` (`id_alarm`,`snow_quality_alarm`,`snow_quantity_alarm`,`wind_alarm`,`weather_alarm`,`range_alarm`,`status_alarm`,`hour_alarm`,`minute_alarm`,`id_user_user`,`longitude_alarm`,`latitude_alarm`) VALUES
-- ('','','','','','','','','','','','');
