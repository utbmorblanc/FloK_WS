
-- Pays

INSERT INTO `country` 
	(`name_country`)
VALUES
	('France');

INSERT INTO `country` 
	(`name_country`)
VALUES
	('Allemagne');

INSERT INTO `country` 
	(`name_country`)
VALUES
	('Suisse');

-- Régions

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Rhône-Alpes','1');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Franche-Comté','1');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Alsace','1');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Lorraine','1');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	("Provence-Alpes-Côte d'Azur",'1');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Languedoc-Roussillon','1');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Midi-Pyrénées','1');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Aquitaine','1');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Auvergne','1');




INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Bade-Wurtemberg','2');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Basse-Saxe','2');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Bavière','2');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Berlin','2');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Brandebourg','2');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Brême','2');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Hambourg','2');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Hesse','2');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Mecklembourg-Poméranie-Occidentale','2');
	
INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Rhénanie-du-Nord-Westphalie','2');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Rhénanie-Palatinat','2');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Sarre','2');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Saxe','2');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Saxe-Anhalt','2');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Schleswig-Holstein','2');
	
INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Thuringe','2');



INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Zurich','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Berne','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Lucerne','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Uri','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Schwytz','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Obwald','3');
	
INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Nidwald','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Glaris','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Zoug','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Zurich','3');
	
INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Fribourg','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Soleure','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Bâle-Ville','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Bâle-Campagne','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Schaffhouse','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Appenzell Rhodes-Extérieures','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Appenzell Rhodes-Intérieures','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Saint-Gall','3');
	
INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Grisons','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Argovie','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Thurgovie','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Tessin','3');
	
INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Vaud','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Valais','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Neuchâtel','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Genève','3');

INSERT INTO `region` 
	(`name_region`,`id_country_country`) 
VALUES
	('Jura','3');


-- Stations

INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('1900',
	'40',
	'Aillons margeriaz',
	'45.642938','6.062307',
	'chef lieu',
	'73340',
	'Aillon-le-Jeune',
	'1');

INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('3300',
	'251',
	"Alpe d'huez",
	'45.09361','6.07139',
	"Avenue de l'Etendart",
	'38750 ',
	'Huez',
	'1');


INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('2320',
	'50',
	"Arêches Beaufort",
	'45.4113','6.6346',
	"Route du Grand Mont",
	'73270',
	'Beaufort',
	'1');


INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('2450',
	'135',
	"Auron",
	'44.225','6.930917',
	"Avenue de Malhira",
	'06660',
	'Saint-Étienne-de-Tinée',
	'5');


INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('1800',
	'43',
	"Bolquère - pyrénées 2000",
	'42.5211','2.0644',
	"Avenue Serrat de l'Ours",
	'66210',
	'Bolquère',
	'6');


INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_number_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('3275',
	'119',
	"Chamonix ",
	'45.923056','6.869722',
	"85",
	"place du Triangle de l'Amitié",
	'74400',
	'Chamonix-Mont-Blanc',
	'1');


INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('3250',
	'173',
	"Champagny en Vanoise",
	'45.455278','6.693333',
	"résid le centre",
	'73350',
	'Champagny en Vanoise',
	'1');


INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('2350',
	'325',
	"Megève",
	'45.8578','6.6181',
	"Rue Monseigneur Conseil",
	'74120',
	'Megève',
	'1');


INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_number_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('2069',
	'120',
	"Praz sur arly",
	'45.838056','6.570833',
	'676',
	"route Varins",
	'74120',
	'Praz sur arly',
	'1');

INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('3230',
	'150',
	"Val Thorens",
	'45.29833','6.57972',
	"Centre val Thorens",
	'73440',
	'Saint-Martin-de-Belleville',
	'1');

INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_number_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('2800',
	'250',
	"Serre Chevalier",
	'44.94','6.56',
	'1',
	"CCAL Prélong",
	'05240',
	'La Salle-les-Alpes',
	'5');

INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_number_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('2525',
	'235',
	"Saint Gervais Mont-Blanc",
	'45.893333','6.713889',
	'1635',
	"route Communailles",
	'74170',
	'Saint Gervais les Bains',
	'1');

INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('2750',
	'85',
	"Risoul",
	'44.6497','6.6408',
	"Station Risoul",
	'05600',
	'Risoul',
	'5');


INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_number_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('2466',
	'180',
	"Morzine",
	'46.17905','6.70905',
	'175',
	"Taille de Mas du Pleney",
	'74110',
	'Morzine',
	'1');

INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_number_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('2277',
	'150',
	"Champéry",
	'46.178061','6.870265',
	'98',
	"Rue du Village",
	'1874',
	'Champéry',
	'33');

INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_number_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('1460',
	'37',
	"Métabief",
	'46.774167','6.3525',
	'8',
	"pl Xavier Authier",
	'25370',
	'Métabief',
	'2');


INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('2150',
	'115',
	"Champoussin",
	'46.207547','6.863258',
	"Les croix",
	'1873',
	'Champoussin',
	'33');

INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('3000',
	'140',
	"Crans motana",
	'46.310278','7.475278',
	"Rue du Pas-de-l'ours",
	'3963',
	'Crans-Montana',
	'33');

INSERT INTO `station` 
	(`height_station`,
	`km_size_station`,
	`name_station`,
	`latitude_station`,
	`longitude_station`,
	`address_number_station`,
	`address_street_station`,
	`address_cp_station`,
	`address_city_station`,
	`id_region_region`) 
VALUES
	('1500',
	'30',
	"Balderschwang",
	'47.466667','10.1',
	'84',
	"Dorf",
	'87538',
	'Balderschwang',
	'39');


-- Language

INSERT INTO `language` 
	(`name_language`) 
VALUES
	('France');

INSERT INTO `language` 
	(`name_language`) 
VALUES
	('Anglais');


-- User

INSERT INTO `user` 
 	(`email_user`,`login_user`,`password_user`,`last_latitude_user`,`last_longitude_user`,`last_city_user`,`id_language_language`) 
 VALUES
	('christophe@cotecolisson.com','ccotecol','utbm','','','','1');

INSERT INTO `user` 
 	(`email_user`,`login_user`,`password_user`,`last_latitude_user`,`last_longitude_user`,`last_city_user`,`id_language_language`) 
 VALUES
	('leray.sophie@gmail.com','sleray','utbm','','','','1');

INSERT INTO `user` 
 	(`email_user`,`login_user`,`password_user`,`last_latitude_user`,`last_longitude_user`,`last_city_user`,`id_language_language`) 
 VALUES
	('valentin.lecourt.tranchant@gmail.com','vlecourt','utbm','','','','1');

INSERT INTO `user` 
 	(`email_user`,`login_user`,`password_user`,`last_latitude_user`,`last_longitude_user`,`last_city_user`,`id_language_language`) 
 VALUES
	('test@test.com','t','t','','','','1');

-- Informations

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('2',
	'4',
	'1',
	'0',
	'46.178061','6.870265',
	'1',
	'15',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('2',
	'4',
	'1',
	'0',
	'45.642938','6.062307',
	'1',
	'1',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('1',
	'2',
	'3',
	'3',
	'45.09361','6.07139',
	'2',
	'2',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('4',
	'1',
	'2',
	'2',
	'45.4113','6.6346',
	'3',
	'3',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('0',
	'2',
	'3',
	'1',
	'44.225','6.930917',
	'4',
	'4',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('3',
	'3',
	'1',
	'3',
	'42.5211','2.0644',
	'1',
	'5',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('5',
	'4',
	'3',
	'2',
	'45.923056','6.869722',
	'2',
	'6',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('5',
	'4',
	'3',
	'2',
	'45.455278','6.693333',
	'3',
	'7',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('1',
	'2',
	'3',
	'3',
	'45.8578','6.6181',
	'4',
	'8',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('1',
	'1',
	'2',
	'1',
	'45.838056','6.570833',
	'1',
	'9',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('4',
	'2',
	'1',
	'2',
	'45.29833','6.57972',
	'2',
	'10',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('1',
	'3',
	'0',
	'1',
	'44.94','6.56',
	'3',
	'11',
	'2015/02/04');


INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('0',
	'1',
	'0',
	'2',
	'45.893333','6.713889',
	'4',
	'12',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('4',
	'3',
	'2',
	'3',
	'44.6497','6.6408',
	'1',
	'13',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('2',
	'4',
	'3',
	'0',
	'46.17905','6.70905',
	'2',
	'14',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('1',
	'1',
	'4',
	'1',
	'46.178061','6.870265',
	'3',
	'15',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('1',
	'1',
	'1',
	'0',
	'46.774167','6.3525',
	'4',
	'16',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('2',
	'4',
	'2',
	'3',
	'46.207547','6.863258',
	'1',
	'17',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('4',
	'2',
	'3',
	'1',
	'46.310278','7.475278',
	'2',
	'18',
	'2015/02/04');

INSERT INTO `information` 
	(`snow_quality_info`,
	`snow_quantity_info`,
	`wind_info`,
	`weather_info`,
	`latitude_info`,
	`longitude_info`,
	`id_user_user`,
	`id_station_station`,
	`date_info`) 
VALUES
	('4',
	'4',
	'4',
	'2',
	'47.466667','10.1',
	'3',
	'19',
	'2015/02/04');

-- Alarmes

INSERT INTO `alarms` 
	(`snow_quality_alarm`,
	`snow_quantity_alarm`,
	`wind_alarm`,
	`weather_alarm`,
	`longitude_alarm`,
	`latitude_alarm`,
	`range_alarm`,
	`status_alarm`,
	`hour_alarm`,
	`minute_alarm`,
	`id_user_user`)
VALUES
	('2',
	'2',
	'2',
	'0',
	'45.642938','6.062307',
	'20',
	'1',
	'08',
	'30',
	'1');