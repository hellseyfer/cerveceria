insert into Palets (nro_botellas) values (5);
insert into Palets (nro_botellas) values (18);
insert into Palets (nro_botellas) values (9);
insert into Palets (nro_botellas) values (1);
insert into Palets (nro_botellas) values (13);
insert into Palets (nro_botellas) values (19);
insert into Palets (nro_botellas) values (16);
insert into Palets (nro_botellas) values (3);
insert into Palets (nro_botellas) values (8);
insert into Palets (nro_botellas) values (19);

insert into Botellas (pet, costo_fabrica, fk_cant_palet, descrip) values (9, 291, 3, 'Glyburide and Metformin Hydrochloride');
insert into Botellas (pet, costo_fabrica, fk_cant_palet, descrip) values (7, 58, 2, 'VYTORIN');
insert into Botellas (pet, costo_fabrica, fk_cant_palet, descrip) values (4, 322, 10, 'SAMBUCUS FLUCARE');
insert into Botellas (pet, costo_fabrica, fk_cant_palet, descrip) values (5, 92, 7, 'LEVOXYL');
insert into Botellas (pet, costo_fabrica, fk_cant_palet, descrip) values (2, 376, 9, 'Childrens Emetrol Dye Free Grape');
insert into Botellas (pet, costo_fabrica, fk_cant_palet, descrip) values (1, 392, 4, 'VENTOLINHFA');
insert into Botellas (pet, costo_fabrica, fk_cant_palet, descrip) values (4, 44, 4, 'Multi-System Support');
insert into Botellas (pet, costo_fabrica, fk_cant_palet, descrip) values (8, 357, 6, 'acid control');
insert into Botellas (pet, costo_fabrica, fk_cant_palet, descrip) values (6, 165, 9, 'Topex');
insert into Botellas (pet, costo_fabrica, fk_cant_palet, descrip) values (10, 75, 10, 'Heparin Sodium');


insert into Cliente (nomyap, telefono) values ('Elizabet Bickmore', '1294474219');
insert into Cliente (nomyap, telefono) values ('Lorna Kean', '0107989131');
insert into Cliente (nomyap, telefono) values ('Lukas Andreasen', '5056907839');
insert into Cliente (nomyap, telefono) values ('Regan Pennone', '8965134307');
insert into Cliente (nomyap, telefono) values ('Mable Dey', '0718871065');
insert into Cliente (nomyap, telefono) values ('Ravi Sambath', '5073070224');
insert into Cliente (nomyap, telefono) values ('Hilde Nabbs', '6605702816');
insert into Cliente (nomyap, telefono) values ('Lewie Beamont', '7156753665');
insert into Cliente (nomyap, telefono) values ('Gay Blaber', '2036551394');
insert into Cliente (nomyap, telefono) values ('Ana Robken', '9185290696');

insert into Levaduras (descrip, precio_kg) values ('Marmota flaviventris', 1068);
insert into Levaduras (descrip, precio_kg) values ('Oncorhynchus nerka', 958);
insert into Levaduras (descrip, precio_kg) values ('Ammospermophilus nelsoni', 377);
insert into Levaduras (descrip, precio_kg) values ('Aquila chrysaetos', 1400);
insert into Levaduras (descrip, precio_kg) values ('Corvus albicollis', 1997);
insert into Levaduras (descrip, precio_kg) values ('Alces alces', 783);
insert into Levaduras (descrip, precio_kg) values ('Castor fiber', 1224);
insert into Levaduras (descrip, precio_kg) values ('Paradoxurus hermaphroditus', 1186);
insert into Levaduras (descrip, precio_kg) values ('Pterocles gutturalis', 33);
insert into Levaduras (descrip, precio_kg) values ('Colaptes campestroides', 129);


insert into Cervezas (descrip, fk_levadura) values ('Bryocaulon Lichen', 5);
insert into Cervezas (descrip, fk_levadura) values ('California Lomatium', 4);
insert into Cervezas (descrip, fk_levadura) values ('Texas Ringstem', 9);
insert into Cervezas (descrip, fk_levadura) values ('Wart Lichen', 5);
insert into Cervezas (descrip, fk_levadura) values ('California Evening Primrose', 9);
insert into Cervezas (descrip, fk_levadura) values ('Twin Clover', 9);
insert into Cervezas (descrip, fk_levadura) values ('Field Parsley Piert', 7);
insert into Cervezas (descrip, fk_levadura) values ('Cup Lichen', 7);
insert into Cervezas (descrip, fk_levadura) values ('Spring Avens', 5);
insert into Cervezas (descrip, fk_levadura) values ('Wreath Lichen', 7);

insert into Gastos_nombres (descrip) values ('Otros');
insert into Gastos_nombres (descrip) values ('Agua');
insert into Gastos_nombres (descrip) values ('Electricidad');
insert into Gastos_nombres (descrip) values ('Alquiler');


insert into Gastos (fecha_ini, esmensual, monto, descrip, fk_nombre) values ('8/16/2020', 1, '92650.42', null, 3);
insert into Gastos (fecha_ini, esmensual, monto, descrip, fk_nombre) values ('9/22/2019', 0, '82522.82', 'Health', 4);
insert into Gastos (fecha_ini, esmensual, monto, descrip, fk_nombre) values ('5/11/2020', 0, '87901.08', null, 4);
insert into Gastos (fecha_ini, esmensual, monto, descrip, fk_nombre) values ('7/16/2020', 1, '87151.27', 'Sports', 1);
insert into Gastos (fecha_ini, esmensual, monto, descrip, fk_nombre) values ('3/2/2020', 1, '58698.65', 'Health', 2);
insert into Gastos (fecha_ini, esmensual, monto, descrip, fk_nombre) values ('9/5/2019', 1, '93630.37', 'Sports', 4);
insert into Gastos (fecha_ini, esmensual, monto, descrip, fk_nombre) values ('6/14/2019', 1, '36514.82', 'Toys', 1);
insert into Gastos (fecha_ini, esmensual, monto, descrip, fk_nombre) values ('3/28/2019', 0, '25979.86', 'Sports', 4);
insert into Gastos (fecha_ini, esmensual, monto, descrip, fk_nombre) values ('9/24/2019', 0, '57030.63', null, 4);
insert into Gastos (fecha_ini, esmensual, monto, descrip, fk_nombre) values ('2/4/2019', 1, '36959.98', 'Garden', 4);
