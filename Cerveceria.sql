
DROP TABLE IF EXISTS "Maltas";
DROP TABLE IF EXISTS "Lupulos";
DROP TABLE IF EXISTS "Levaduras";
DROP TABLE IF EXISTS "Gastos";
DROP TABLE IF EXISTS "Botellas";
DROP TABLE IF EXISTS "Flete";
DROP TABLE IF EXISTS "Planchas";
DROP TABLE IF EXISTS "Ins_varios";
DROP TABLE IF EXISTS "Cervezas";
DROP TABLE IF EXISTS "Cerv_Maltas";
DROP TABLE IF EXISTS "Cerv_lupulos";
DROP TABLE IF EXISTS "Palets";
DROP TABLE IF EXISTS "Cerv_ins_varios";
DROP TABLE IF EXISTS "Gastos_nombres";
DROP TABLE IF EXISTS "Pedidos";
DROP TABLE IF EXISTS "Detalles_pedidos";
DROP TABLE IF EXISTS "Cliente";


CREATE TABLE "Maltas" (
"id" INT PRIMARY KEY identity NOT NULL,
"descrip" VARCHAR (40) NOT NULL,
"precio_kg" FLOAT  NOT NULL,
"precio_bolsa" FLOAT  NOT NULL);

CREATE TABLE "Lupulos" (
"id" INT PRIMARY KEY identity NOT NULL,
"descrip" VARCHAR (30) NOT NULL UNIQUE,
"precio_kg" FLOAT  NOT NULL);

CREATE TABLE "Levaduras" (
"id" INT PRIMARY KEY identity NOT NULL,
"descrip" VARCHAR (30) NOT NULL,
"precio_kg" FLOAT  NOT NULL);

CREATE TABLE "Gastos" (
"id" INT PRIMARY KEY identity NOT NULL,
"fecha_ini" DATE NOT NULL,
"esmensual" BIT DEFAULT 'false' NOT NULL,
"monto" FLOAT  NOT NULL,
"descrip" VARCHAR (30),
"fk_nombre" INT NOT NULL);

CREATE TABLE "Botellas" (
"id" INT PRIMARY KEY identity NOT NULL,
"descrip" varchar(30) not null,
"pet" VARCHAR (40) NOT NULL,
"costo_fabrica" INT NOT NULL,
"fk_cant_palet" INT NOT NULL);

CREATE TABLE "Flete" (
"id" INT PRIMARY KEY identity NOT NULL,
"descrip" VARCHAR (30) NOT NULL UNIQUE,
"costo" FLOAT  NOT NULL,
"fk_botella" INT NOT NULL);

CREATE TABLE "Planchas" (
"id" INT PRIMARY KEY identity NOT NULL,
"dimension" VARCHAR (30) NOT NULL,
"costo" FLOAT  NOT NULL);

CREATE TABLE "Ins_varios" (
"id" INT PRIMARY KEY identity NOT NULL,
"descrip" VARCHAR (30) NOT NULL,
"precio" FLOAT  NOT NULL,
"precio_kg" FLOAT  NOT NULL);

CREATE TABLE "Cervezas" (
"id" INT PRIMARY KEY identity NOT NULL,
"descrip" VARCHAR (30) NOT NULL,
"fk_levadura" INT NOT NULL);

CREATE TABLE "Cerv_Maltas" (
"fk_cerveza" INT NOT NULL,
"fk_malta" INT NOT NULL,
PRIMARY KEY ("fk_cerveza","fk_malta"));

CREATE TABLE "Cerv_lupulos" (
"fk_cerveza" INT NOT NULL,
"fk_lupulo" INT NOT NULL,
PRIMARY KEY ("fk_cerveza","fk_lupulo"));

CREATE TABLE "Palets" (
"id" INT PRIMARY KEY identity NOT NULL,
"nro_botellas" INT NOT NULL);

CREATE TABLE "Cerv_ins_varios" (
"fk_cerveza" INT NOT NULL,
"fk_ins_varios" INT NOT NULL);

CREATE TABLE "Gastos_nombres" (
"id" INT PRIMARY KEY identity NOT NULL,
"descrip" VARCHAR (30) NOT NULL);

CREATE TABLE "Pedidos" (
"id" INT PRIMARY KEY identity NOT NULL,
"fecha_pedido" DATE NOT NULL,
"fecha_envio" DATE NOT NULL,
"forma_envio" VARCHAR (40) NOT NULL,
"cargo_total" FLOAT  NOT NULL,
"direccion_dest" VARCHAR (120) NOT NULL,
"fk_cliente" INT NOT NULL);

CREATE TABLE "Detalles_pedidos" (
"fk_pedido" INT NOT NULL,
"fk_cerveza" INT NOT NULL,
"precio_unidad" FLOAT  NOT NULL,
"descuento" FLOAT  NOT NULL,
PRIMARY KEY ("fk_pedido","fk_cerveza"));

CREATE TABLE "Cliente" (
"id" INT PRIMARY KEY identity NOT NULL,
"nomyap" VARCHAR (40) NOT NULL UNIQUE,
"telefono" BIGINT NOT NULL);

ALTER TABLE "Gastos" ADD CONSTRAINT "Gastos_fk_nombre-Gastos_nombres_id" FOREIGN KEY ("fk_nombre") REFERENCES "Gastos_nombres"("id");
ALTER TABLE "Botellas" ADD CONSTRAINT "Botellas_fk_cant_palet-Palets_id" FOREIGN KEY ("fk_cant_palet") REFERENCES "Palets"("id");
ALTER TABLE "Flete" ADD CONSTRAINT "Flete_fk_botella-Botellas_id" FOREIGN KEY ("fk_botella") REFERENCES "Botellas"("id");
ALTER TABLE "Cervezas" ADD CONSTRAINT "Cervezas_fk_levadura-Levaduras_id" FOREIGN KEY ("fk_levadura") REFERENCES "Levaduras"("id");
ALTER TABLE "Cerv_Maltas" ADD CONSTRAINT "Cerv_Maltas_fk_cerveza-Cervezas_id" FOREIGN KEY ("fk_cerveza") REFERENCES "Cervezas"("id");
ALTER TABLE "Cerv_Maltas" ADD CONSTRAINT "Cerv_Maltas_fk_malta-Maltas_id" FOREIGN KEY ("fk_malta") REFERENCES "Maltas"("id");
ALTER TABLE "Cerv_lupulos" ADD CONSTRAINT "Cerv_lupulos_fk_cerveza-Cervezas_id" FOREIGN KEY ("fk_cerveza") REFERENCES "Cervezas"("id");
ALTER TABLE "Cerv_lupulos" ADD CONSTRAINT "Cerv_lupulos_fk_lupulo-Lupulos_id" FOREIGN KEY ("fk_lupulo") REFERENCES "Lupulos"("id");
ALTER TABLE "Cerv_ins_varios" ADD CONSTRAINT "Cerv_ins_varios_fk_cerveza-Cervezas_id" FOREIGN KEY ("fk_cerveza") REFERENCES "Cervezas"("id");
ALTER TABLE "Cerv_ins_varios" ADD CONSTRAINT "Cerv_ins_varios_fk_ins_varios-Ins_varios_id" FOREIGN KEY ("fk_ins_varios") REFERENCES "Ins_varios"("id");
ALTER TABLE "Pedidos" ADD CONSTRAINT "Pedidos_fk_cliente-Cliente_id" FOREIGN KEY ("fk_cliente") REFERENCES "Cliente"("id");
ALTER TABLE "Detalles_pedidos" ADD CONSTRAINT "Detalles_pedidos_fk_pedido-Pedidos_id" FOREIGN KEY ("fk_pedido") REFERENCES "Pedidos"("id");
ALTER TABLE "Detalles_pedidos" ADD CONSTRAINT "Detalles_pedidos_fk_cerveza-Cervezas_id" FOREIGN KEY ("fk_cerveza") REFERENCES "Cervezas"("id");
