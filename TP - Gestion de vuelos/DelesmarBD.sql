use master
go

--drop database delesmar_db
------------------------------ CREACIÓN DE BASE DE DATOS --------------------------------------
create database DelEsMar_DB
on
(
name = delesmar_dat,
filename = 'C:\DelEsMar_DB.mdf'
)
go

use DelEsMar_DB
go

------------------------------------ CREACIÓN DE TABLAS ----------------------------------------
--TABLA PASAJEROS
create table Pasajeros
(
Dni char(10) not null unique,
IdPasajero char(10) not null,
Pasaporte char(10) not null unique,
Nombre char(50) not null,
Apellido char(50) not null,
Telefono char(50) not null,
Email char(50) not null unique,
Usuario char(50) not null unique,
Estado bit
constraint PK_Pasajeros primary key(Dni)
)
go
--TABLA PAISES
create table Paises
(
IdPais char(10) not null,
Nombre char(50),
constraint PK_Paises primary key(IdPais)
)
go
--TABLA DESTINOS
create table Destinos
(
IdDestino char(10) not null,
LugarDestino char(50) not null,
IdPais char(10) not null,
Aeropuerto char(50) not null,
ImporteDestino smallmoney not null,
Estado bit
constraint PK_Destinos primary key(IdDestino)
)
go
--TABLA AEROLÍNEAS
create table Aerolineas
(
IdAerolinea char(10) not null,
Empresa char(50),
constraint PK_Aerolineas primary key(IdAerolinea)
)
go 
--TABLA AVIONES
create table Aviones
(
IdAvion char(10) not null,
IdAerolinea char(10) not null,
Capacidad int not null,
Estado bit
constraint PK_Aviones primary key(IdAvion)
)
go
--TABLA CLASES
create table Clases
(
IdClase char(10) not null,
ImporteClase smallmoney not null,
NombreClase char(50) not null,
constraint PK_Clases primary key(IdClase)
)
go
--TABLA VUELOS
create table Vuelos
(
IdVuelo char(10) not null,
IdAvion char(10) not null,
IdDestino char(10) not null,
FechaVuelo smalldatetime not null,
MontoVuelo smallmoney not null,
Estado bit
constraint PK_Vuelos primary key(IdVuelo)
)
go
--TABLA DETALLE_PAGOS
create table Detalle_Pagos
(
IdDetalle_Pago char(10) not null,
IdVuelo char(10) not null,
IdPago char(10) not null,
Dni char(10) not null,
IdClase char(10) not null,
ImporteSubtotal smallmoney null,
constraint PK_Detalle_Pagos primary key(IdDetalle_Pago)
)
go
--TABLA PAGOS
create table Pagos
(
IdPago char(10) not null,
Cliente char(10) not null,
IdDetalle_Pago char(10) not null,
FechaPago smalldatetime not null,
ImporteTotal smallmoney null,
constraint PK_Pagos primary key(IdPago)
)
go
--TABLA USUARIOS
create table Usuarios
(
Usuario char(50) not null unique,
TipoUsuario char(20) not null,
Contrasenia char(50) not null,
Estado bit
constraint PK_Usuarios primary key(Usuario)
)
go
--TABLA PERMISOS
create table Permisos
(
TipoUsuario char(20) not null,
DescripcionPermiso char(20) not null,
constraint PK_Permisos primary key(TipoUsuario)
)
go
------------------------------ FIN DE CREACIÓN DE TABLAS --------------------------------------

------------------------------  CREACIÓN DE RELACIONES ---------------------------------------- 

--RELACIÓN USUARIOS CON PASAJEROS
alter table Usuarios
add constraint FK_UxP foreign key(Usuario) references Pasajeros(Usuario)
go

--RELACIÓN PERMISOS CON USUARIOS
alter table Usuarios
add constraint FK_PxU foreign key(TipoUsuario) references Permisos(TipoUsuario)
go

--RELACIÓN PAISES CON DESTINOS
alter table Destinos
add constraint FK_PxD foreign key(IdPais) references Paises(IdPais)
go

--RELACIÓN DESTINOS CON VUELOS
alter table Vuelos
add constraint FK_DxV foreign key(IdDestino) references Destinos(IdDestino)
go

--RELACIÓN AVIONES CON VUELOS
alter table Vuelos 
add constraint FK_AxV foreign key(IdAvion) references Aviones(IdAvion)
go

--RELACIÓN AEROLÍNEAS CON AVIONES
alter table Aviones 
add constraint FK_AxA foreign key(IdAerolinea) references Aerolineas(IdAerolinea)
go

--RELACIÓN VUELOS CON DETALLES DE PAGO
alter table Detalle_Pagos 
add constraint FK_DETxV foreign key(IdVuelo) references Vuelos(IdVuelo)
go

--RELACIÓN CLASES CON DETALLES DE PAGO
alter table Detalle_Pagos 
add constraint FK_DETxC foreign key(IdClase) references Clases(IdClase)
go

--RELACIÓN PAGOS CON DETALLES DE PAGO
alter table Pagos 
add constraint FK_DETxPAG foreign key(IdDetalle_Pago) references Detalle_Pagos(IdDetalle_Pago)
go

--RELACIÓN PASAJEROS CON DETALLES DE PAGO
alter table Detalle_Pagos 
add constraint FK_DETxP foreign key(Dni) references Pasajeros(Dni)
go

------------------------------ FIN DE CREACIÓN DE RELACIONES -----------------------------------

----------------------------------- CARGA DE DATOS ---------------------------------------------

--PAISES
insert into Paises(IdPais,Nombre)
select 'ALB', 'Albania' union
select 'ALE', 'Alemania' union
select 'ARA', 'Arabia' union
select 'AUS', 'Australia' union
select 'ARG', 'Argentina' union
select 'BEL', 'Bélgica' union
select 'BOL', 'Bolivia' union
select 'BRA', 'Brasil' union
select 'BUL', 'Bulgaria' union
select 'CAM', 'Camerún' union
select 'CAN', 'Canadá' union
select 'CHL', 'Chile' union
select 'CHN', 'China' union
select 'CRN', 'Corea del Norte' union
select 'CRS', 'Corea del Sur' union
select 'COS', 'Costa de Márfil' union
select 'CSR', 'Costa Rica' union
select 'CRO', 'Croacia' union
select 'CUB', 'Cuba' union
select 'DIN', 'Dinamarca' union
select 'ECU', 'Ecuador' union
select 'EGI', 'Egipto' union
select 'ELS', 'El Salvador' union
select 'EAU', 'Emiratos Arabes Unidos' union
select 'ESP', 'España' union
select 'EUA', 'Estados Unidos' union
select 'FIL', 'Filipinas' union
select 'FIN', 'Finlandia' union
select 'FRA', 'Francia' union
select 'GHA', 'Ghana' union
select 'GRE', 'Grecia' union
select 'GUA', 'Guatemala' union
select 'HAI', 'Haití' union
select 'HOL', 'Holanda' union
select 'HUN', 'Hungría' union
select 'IND', 'India' union
select 'IRL', 'Irlanda' union
select 'ISR', 'Israel' union
select 'ITA', 'Italia' union
select 'JAM', 'Jamaica' union
select 'JPN', 'Japón' union
select 'KEN', 'Kenia' union
select 'LUX', 'Luxemburgo' union
select 'MAD', 'Madagascar' union
select 'MAL', 'Malasia' union
select 'MAR', 'Marruecos' union
select 'MEX', 'México' union
select 'MON', 'Mónaco' union
select 'NIC', 'Nicaragua' union
select 'NIG', 'Nigeria' union
select 'NOR', 'Noruega' union
select 'NZE', 'Nueva Zelanda' union
select 'PAN', 'Panamá' union
select 'PAR', 'Paraguay' union
select 'PER', 'Perú' union
select 'POL', 'Polonia' union
select 'QAT', 'Qatar' union
select 'POR', 'Portugal' union
select 'REU', 'Reino Unido' union
select 'RCH', 'República Checa' union
select 'RUM', 'Rumania' union
select 'RUS', 'Rusia' union
select 'SEN', 'Senegal' union
select 'SER', 'Serbia' union
select 'SIN', 'Singapur' union
select 'SUD', 'Sudáfrica' union
select 'SUE', 'Suecia' union
select 'SUI', 'Suiza' union
select 'TAI', 'Tailandia' union
select 'TUR', 'Turquía' union
select 'UCR', 'Ucrania' union
select 'URU', 'Uruguay' union
select 'VEN', 'Venezuela' union
select 'ZIM', 'Zimbabwe'
go

--PASAJEROS
insert into Pasajeros(Dni,IdPasajero,Pasaporte,Nombre,Apellido,Telefono,Email,Usuario,Estado)
select '34416417', 'PS01', 'P-11111', 'Hernan', 'Escalante', '1111', 'herchi_no@','HRN',1 union
select '36123321', 'PS02', 'P-22222', 'Leonardo', 'Delbueno', '2222', 'leorg92@','LEO',1 union
select '38333333', 'PS03', 'P-33333', 'Leandro', 'Martínez', '3333', 'leandro08@','LEA',1 union
select '38444444', 'PS04', 'P-44444', 'Daniela', 'Gutierrez', '4444', 'd_dbo@','DAN',1 union
select '37555555', 'PS05', 'P-55555', 'Gonzalo', 'Alegre', '5555', 'alegre94@','GON',1
go

--Permisos
insert into Permisos(TipoUsuario,DescripcionPermiso)
select 'a','ADMIN' union
select 'u','USUARIO'
go
--Usuarios
insert into Usuarios(Usuario,TipoUsuario,Contrasenia,Estado)
select 'HRN','a','asd', 1 union
select 'LEO','u','dsa', 1 union
select 'LEA','u','asd', 1 union
select 'DAN','u','asd', 1 union
select 'GON','u','asd', 1
go

--CLASES
insert into Clases(IdClase,ImporteClase,NombreClase)
select 'PRI', 1.7, 'Primera' union
select 'BUS', 1.4, 'Business' union
select 'ECO', 1.2, 'Económico'
go

--AEROLÍNEAS
insert into Aerolineas(IdAerolinea,Empresa)
select 'LTM', 'Latam' union
select 'FEM', 'Fly Emirates' union
select 'QAN', 'Qantas' union
select 'IBE', 'Iberia' union
select 'AA', 'American Airlines' union
select 'BA', 'British Airlines'
go

--AVIONES
insert into Aviones(IdAvion,IdAerolinea,Capacidad,Estado)
select 'AV01', 'LTM', 120,1 union
select 'AV02', 'AA', 200,1 union
select 'AV03', 'QAN', 100,1 union
select 'AV04', 'IBE', 70,1 union
select 'AV05', 'AA', 200,1
go

--DESTINOS
insert into Destinos(IdDestino,IdPais,LugarDestino,Aeropuerto,ImporteDestino, Estado)
select 'D01', 'ITA', 'Roma', 'Leonardo da Vinci', 21680, 1 union
select 'D02', 'FRA', 'Parìs', 'Parìs-Charles de Gaulle', 10780, 1 union 
select 'D03', 'TUR', 'Estambul', 'Yesilkoy', 11910, 1 union
select 'D04', 'ISR', 'Jerusalem', 'Ben Guriòn', 9760, 1 union
select 'D05', 'REU', 'Londres', 'Heathrow', 13400, 1 union
select 'D06', 'HOL', 'Amsterdam', 'Amsterdam-Schiphol', 15650, 1 union
select 'D07', 'ESP', 'Barcelona', 'Barcelona-el Prat', 16120, 1 union
select 'D08', 'JPN', 'Tokyo', 'Tokio-Narita', 20140, 1 union
select 'D09', 'RUS', 'Moscù', 'Moscù-Sheremètievo', 18430, 1 union
select 'D10', 'IND', 'Nueva Delhi', 'Indira Gandhi', 15650, 1 union
select 'D11', 'JPN', 'Hong Kong', 'Chek Lap Kok', 19910, 1 union
select 'D12', 'CHN', 'Beijing', 'Pekìn', 21400, 1 union
select 'D13', 'EUA', 'New York', 'JFK Idlewild', 10700, 1 union
select 'D14', 'BRA', 'Brasilia', 'Presidente Juscelino Kubitschek', 5800, 1 union
select 'D15', 'ARG', 'Bariloche', 'San Carlos de Bariloche', 4030, 1 union
select 'D16', 'MEX', 'DF', 'Benito Juàrez de la Ciudad de Mèxico', 8650, 1 union
select 'D17', 'URU', 'Punta del Este', 'Curbelo de Laguna del Sauce', 6750, 1 union
select 'D18', 'PER', 'Lima', 'Jorge Chàvez', 3420, 1 union
select 'D20', 'SUD', 'Ciudad del Cabo', 'AI Ciudad del Cabo', 9820, 1 union
select 'D21', 'EGI', 'El Cairo', 'AI El Cairo', 11700, 1 union
select 'D22', 'MAR', 'Casablanca', 'AI Mohammed V', 10850, 1 union
select 'D23', 'SEN', 'Dakar', 'Dakar-Yoff/Lèopold Sèdar Senghor', 12700, 1 union
select 'D24', 'SUD', 'Pretoria', 'Johannesburgo-Oliver', 11520, 1 union
select 'D25', 'NZE', 'Wellington', 'AI Wellington', 34520, 1 union
select 'D26', 'AUS', 'Sydney', 'Kingsford Smith', 32810, 1 union
select 'D27', 'AUS', 'Melbourne', 'Tullamarine', 30900, 1
go

-- VUELOS
insert into Vuelos(IdVuelo,IdAvion,IdDestino,FechaVuelo,MontoVuelo,Estado)
select 'V01','AV02','D05','20170613',13400,1 union
select 'V02','AV01','D10','20170824',15650,1 union
select 'V03','AV03','D03','20171201',11910,1 union
select 'V04','AV01','D20','20200907',9820,1
go
--Detalle de pago
insert into Detalle_Pagos(IdDetalle_Pago,IdVuelo,IdPago,Dni,IdClase,ImporteSubtotal)
select 'DP01','V04','PG01','34416417','ECO', 0 union
select 'DP02','V03','PG04','37555555','PRI', 0 union
select 'DP03','V02','PG02','38333333','BUS', 0 union
select 'DP04','V01','PG03','38444444','PRI', 0 union
select 'DP05','V03','PG05','34416417','ECO', 0
go
--Pagos
insert into Pagos(IdPago,Cliente,IdDetalle_Pago,FechaPago,ImporteTotal)
select 'PG01','34416417','DP01',GETDATE(), 0 union
select 'PG02','38333333','DP03',GETDATE(), 0 union
select 'PG03','38444444','DP04',GETDATE(), 0 union
select 'PG04','37555555','DP02',GETDATE(), 0 union
select 'PG05','34416417','DP05',GETDATE(), 0
go
----------------------------------- FIN CARGA DE DATOS ---------------------------------------------

----------------------------------- PROCEDIMIENTOS ALMACENADOS -------------------------------------

---- ABM VUELOS --
--CREATE PROCEDURE spInsertarVuelos
--(
--@IDVUELO char(10),
--@IDDESTINO char(10),
--@IDAVION char(10),
--@FECHAVUELO smalldatetime,
--@MONTOVUELO smallmoney
--)
--AS
--INSERT INTO Vuelos
--(
--IdVuelo,
--IdDestino,
--IdAvion,
--FechaVuelo,
--MontoVuelo
--)
--VALUES
--(
--@IDVUELO,
--@IDDESTINO,
--@IDAVION,
--@FECHAVUELO,
--@MONTOVUELO
--)
--GO

-- INSERTAR PAGO --

CREATE PROCEDURE spInsertarPago
(
@IDPAGO char(10),
@CLIENTE char(10),
@IMPORTETOTAL smallmoney
)
AS
INSERT INTO Pagos
(
IdPago,
Cliente,
FechaPago,
ImporteTotal
)
VALUES
(
@IDPAGO,
@CLIENTE,
GETDATE(),
@IMPORTETOTAL
)
GO

-- BUSCAR PASAJERO
--create procedure spBuscarPasajero
--@prmDni char(10),
--@prmIdPasajero char(10),
--@prmPasaporte char(10),
--@prmNombre char(50),
--@prmApellido char(50),
--@prmTelefono char(50),
--@prmEmail char(50),
--@prmUsuario char(50),
--@prmEstado bit
--as
--if exists (select * from Pasajeros where Dni <> @prmDni)
--	exec spRegistrarPasajero @prmDni,@prmIdPasajero,@prmPasaporte,@prmNombre,@prmApellido,@prmTelefono,@prmEmail,@prmUsuario,1
--else if exists(select * from Pasajeros where Dni = @prmDni)
--	begin
--		print 'DNI EXISTENTE'
--		begin transaction
--		rollback transaction
--	end
--go
--exec spBuscarPasajero '112','112','112','111','111','111','112','112',1
--select * from Pasajeros

create procedure spSumarTotalPago
@idPago char(10) , @idDetPag char(10)
as
declare @imp smallmoney
select @imp = Detalle_Pagos.ImporteSubtotal from Detalle_Pagos
where Detalle_Pagos.IdPago = @idPago and Detalle_Pagos.IdDetalle_Pago = @idDetPag
update Pagos set ImporteTotal = ImporteTotal + @imp
from Detalle_Pagos inner join Pagos
on Detalle_Pagos.IdPago = Pagos.IdPago
where Pagos.IdPago = @idPago
go

create procedure spObtenerSubtotalDetallePago
@detPag char(10), @idDetPag char(10)
as
update Detalle_Pagos  set ImporteSubtotal = (
select  Vuelos.MontoVuelo*Clases.ImporteClase
from vuelos inner join destinos
on vuelos.iddestino = destinos.iddestino
inner join detalle_pagos
on vuelos.idvuelo = detalle_pagos.idvuelo
inner join clases
on clases.idclase = detalle_pagos.idclase
where detalle_pagos.IdDetalle_Pago = @idDetPag and Detalle_Pagos.IdPago = @detPag)
where detalle_pagos.IdDetalle_Pago = @idDetPag and Detalle_Pagos.IdPago = @detPag
if exists (select * from Detalle_Pagos where Detalle_Pagos.IdDetalle_Pago = @idDetPag and Detalle_Pagos.IdPago = @detPag)
exec spSumarTotalPago @detPag,@idDetPag
else if exists (select * from Detalle_Pagos where Detalle_Pagos.IdDetalle_Pago = @idDetPag and Detalle_Pagos.IdPago <> @detPag)
print 'ID PAGO NO EXISTE'
else if exists (select * from Detalle_Pagos where Detalle_Pagos.IdPago = @detPag and Detalle_Pagos.IdDetalle_Pago <> @idDetPag)
print 'ID DETALLE_PAGO NO EXISTE'
else if exists (select * from Detalle_Pagos where Detalle_Pagos.IdDetalle_Pago <> @idDetPag and Detalle_Pagos.IdPago <> @detPag)
print 'ID PAGO E ID DETALLE DE PAGO NO EXISTE'
go

CREATE PROCEDURE spListarPasajeros
AS
	BEGIN
		SELECT P.Dni
			 , P.IdPasajero
			 , P.Pasaporte
			 , P.Nombre
			 , P.Apellido
			 , P.Telefono
			 , P.Email
			 , P.Usuario
		FROM Pasajeros P
		WHERE P.Estado = 1
	END
go

CREATE PROCEDURE spListarDestinos
AS
	BEGIN
		SELECT D.IdDestino
			 , D.LugarDestino
			 , D.IdPais
			 , D.Aeropuerto
			 , D.ImporteDestino
		FROM Destinos D
		WHERE D.Estado = 1
	END
go

CREATE PROCEDURE spListarVuelos
AS
	BEGIN
		SELECT V.IdVuelo
			 , V.IdAvion
			 , V.IdDestino
			 , V.FechaVuelo
			 , V.MontoVuelo
		FROM Vuelos V
		WHERE V.Estado = 1
	END
go

CREATE PROCEDURE VerificarExistenciaPasajero
(
	@DNI CHAR(10),
	@IDPASAJERO CHAR(10),
	@PASAPORTE CHAR(10),
	@EMAIL CHAR(50),
	@USUARIO CHAR(50)
)
as
begin
select count(*) from pasajeros as p
where p.Dni = @DNI or p.IdPasajero = @IDPASAJERO or p.Pasaporte = @PASAPORTE or p.Email = @EMAIL or p.Usuario = @USUARIO
end
go

CREATE PROCEDURE spRegistrarPasajero
(
@prmDni char(10),
@prmIdPasajero char(10),
@prmPasaporte char(10),
@prmNombre char(50),
@prmApellido char(50),
@prmTelefono char(50),
@prmEmail char(50),
@prmUsuario char(50),
@prmEstado bit
)
AS
	BEGIN
		INSERT INTO Pasajeros(Dni, IdPasajero, Pasaporte, Nombre, Apellido, Telefono, Email, Usuario, Estado)
		VALUES(@prmDni, @prmIdPasajero, @prmPasaporte, @prmNombre, @prmApellido, @prmTelefono, @prmEmail, @prmUsuario, @prmEstado)
	END
GO

CREATE PROCEDURE VerificarExistenciaDestino
(
	@IDDESTINO CHAR(10)
)
as
begin
select count(*) from destinos as d
where d.IdDestino = @IDDESTINO 
end
go

CREATE PROCEDURE spRegistrarDestino
(
@prmIdDestino char(10),
@prmLugarDestino char(50),
@prmIdPais char(10),
@prmAeropuerto char(50),
@prmImporteDestino smallmoney,
@prmEstado bit
)
AS
	BEGIN
		INSERT INTO Destinos(IdDestino, LugarDestino, IdPais, Aeropuerto, ImporteDestino, Estado)
		VALUES(@prmIdDestino, @prmLugarDestino, @prmIdPais, @prmAeropuerto, @prmImporteDestino, @prmEstado)
	END
GO

CREATE PROCEDURE VerificarExistenciaVuelo
(
	@IDVUELO CHAR(10)
)
as
begin
select count(*) from vuelos as v
where v.IdVuelo = @IDVUELO 
end
go

CREATE PROCEDURE spRegistrarVuelo
(
@prmIdVuelo char(10),
@prmIdAvion char(10),
@prmIdDestino char(10),
@prmFechaVuelo smalldatetime,
@prmMontoVuelo smallmoney,
@prmEstado bit
)
AS
	BEGIN
		INSERT INTO Vuelos(IdVuelo, IdAvion, IdDestino, FechaVuelo, MontoVuelo, Estado)
		VALUES(@prmIdVuelo, @prmIdAvion, @prmIdDestino, @prmFechaVuelo, @prmMontoVuelo, @prmEstado)
	END
GO

CREATE PROCEDURE spAccesoSistema
( @prmUser varchar(50),
  @prmPass varchar(50)
)
AS
	BEGIN
		SELECT U.Usuario, U.TipoUsuario, U.Contrasenia
		FROM Usuarios U
		WHERE U.Usuario = @prmUser AND U.Contrasenia = @prmPass
	END
GO

CREATE PROCEDURE spActualizarDatosPasajero
(
@prmDni char(10),
@prmNombre char(50),
@prmApellido char(50),
@prmTelefono varchar(50),
@prmUsuario char(50)
)
as
	begin
		update Pasajeros
		set	Pasajeros.Nombre = @prmNombre,
			Pasajeros.Apellido = @prmApellido,
			Pasajeros.Telefono = @prmTelefono,
			Pasajeros.Usuario = @prmUsuario
		where Pasajeros.Dni = @prmDni
	end
go

CREATE PROCEDURE spActualizarDatosDestino
(
@prmIdDestino char(10),
@prmLugarDestino char(50),
@prmAeropuerto char(50),
@prmImporteDestino smallmoney
)
as
	begin
		update Destinos
		set Destinos.LugarDestino = @prmLugarDestino,
			Destinos.Aeropuerto = @prmAeropuerto,
			Destinos.ImporteDestino = @prmImporteDestino
		where Destinos.IdDestino = @prmIdDestino
	end
go

CREATE PROCEDURE spActualizarDatosVuelo
(
@prmIdVuelo char(10),
@prmFechaVuelo smalldatetime,
@prmMontoVuelo smallmoney
)
as
	begin
		update Vuelos
		set Vuelos.FechaVuelo = @prmFechaVuelo,
			Vuelos.MontoVuelo = @prmMontoVuelo
		where Vuelos.IdVuelo = @prmIdVuelo
	end
go

CREATE PROCEDURE spEliminarPasajero
(
@prmDni char(10)
)
AS
	BEGIN
		UPDATE Pasajeros
		SET Estado = 0
		WHERE Dni = @prmDni
	END
	
GO

CREATE PROCEDURE spEliminarDestino
(
@prmIdDestino char(10)
)
AS
	BEGIN
		UPDATE Destinos
		SET Estado = 0
		WHERE IdDestino = @prmIdDestino
	END
go

CREATE PROCEDURE spEliminarVuelo
(@prmIdVuelo char(10))
AS
	BEGIN
		UPDATE Vuelos
		SET Estado = 0
		WHERE IdVuelo = @prmIdVuelo
	END
go

use DelEsMar_DB
go

----------------------------------- FIN PROCEDIMIENTOS ALMACENADOS ----------------------------------

----------------------------------- TRIGGERS --------------------------------------------------------

CREATE TRIGGER TR_SEGURIDAD
ON DATABASE 
FOR DROP_TABLE, ALTER_TABLE
AS 
SET NOCOUNT ON;
RAISERROR ('No está permitido borrar ni modificar tablas.' , 16, 1)
ROLLBACK TRANSACTION 
go

create trigger TR_Seguridad_Triggers
on database
for drop_trigger,alter_trigger
AS 
SET NOCOUNT ON;
RAISERROR ('No está permitido borrar ni modificar triggers.' , 16, 1)
ROLLBACK TRANSACTION 
go

create trigger TR_Seguridad_SP
on database
for drop_procedure, alter_procedure
AS 
SET NOCOUNT ON;
RAISERROR ('No está permitido borrar ni modificar procedimientos almacenados.' , 16, 1)
ROLLBACK TRANSACTION 
go

create trigger TR_Paises_Repetidos
on Paises
after insert
as
set nocount on;
if exists (select nombre,count(*) as 'repetido'
			from Paises
			group by nombre
			having count(*) > 1)
begin
raiserror ('Ya existe el país con ese nombre',16,1);
rollback
end
go

----------------------------------- FIN DE TRIGGERS -------------------------------------------------

----------------------------------- INSTRUCCIONES DE TESTEO -----------------------------------------
-- TESTEO DE LAS TOTALES Y SUBTOTALES DE LAS TABLAS PAGOS Y DETALLE DE PAGOS
--select * from Detalle_Pagos
--go
--select * from Pagos
--go

--insert into Detalle_Pagos(IdDetalle_Pago,IdVuelo,IdPago,IdPasajero,IdClase,ImporteSubtotal)
--select 'DP06','V01','PG01','PS02','ECO',0
--go

--exec spObtenerSubtotalDetallePago 'PG01','DP01'
--go

-- TESTEO DEL TRIGGER PAISES POR NOMBRE REPETIDO
--insert into Paises(IdPais,Nombre)
--select 'ARR','Argentinna'
--go

--select * from Paises

--delete from Paises
--where idpais = 'ARR'

-- DROPEO LA BASE DE DATO
--use master
--drop database delesmar_db

----------------------------------- FIN INSTRUCCIONES DE TESTEO ------------------------------------