create database modulos

CREATE TABLE usuarios (
	idusuario int IDENTITY(1,1) PRIMARY KEY NOT NULL
	,email varchar(200)
	,password varchar(500)
	,usuario varchar(100)
	,nombre varchar(100)
	,apellidos varchar(200)
	,idrol int
	,telefono varchar(10)
	,pathfoto varchar(200)
	,UsuarioCreacion varchar(20)
	,FechaCreacion datetime
	,UsuarioModifica varchar(20)
	,FechaModifica datetime 
);
CREATE TABLE rol (
	idrol int IDENTITY(1,1) PRIMARY KEY NOT NULL
	,descripcion varchar(200)
	,UsuarioCreacion varchar(20)
	,FechaCreacion datetime
	,UsuarioModifica varchar(20)
	,FechaModifica datetime 
);
CREATE TABLE proyectos (
	idproyecto int IDENTITY(1,1) PRIMARY KEY NOT NULL
	,nombre varchar(200)
	,region varchar(200)
	,fechainicio datetime
	,fechafin datetime
	,presupuesto decimal(10,2)
	,idresponsable int
	,UsuarioCreacion varchar(20)
	,FechaCreacion datetime
	,UsuarioModifica varchar(20)
	,FechaModifica datetime 
);
CREATE TABLE partida (
	idpartida int IDENTITY(1,1) PRIMARY KEY NOT NULL
	,idproyecto int 
	,descripcion varchar(200)
	,fecha datetime
	,unidad varchar(50)
	,metradototal int
	,metradosaldo int
	,valorizacionsaldo decimal(10,2)
	,porvalorizacion decimal(4,2)
	,porsaldo decimal(4,2)
	,observacion varchar(200)
	,mes datetime
	,UsuarioCreacion varchar(20)
	,FechaCreacion datetime
	,UsuarioModifica varchar(20)
	,FechaModifica datetime 
);
CREATE TABLE materiales (
	idmateriales int IDENTITY(1,1) PRIMARY KEY NOT NULL
	,idpartida int
	,descripcion varchar(200)
	,largo varchar(100)
	,ancho varchar(100)
	,altura varchar(100)
	,nrocarasveces int
	,nropegas int
	,longitud int
	,longitudtotal varchar(100)
	,omega varchar(100)
	,fechacorrecion datetime
	,incidencia varchar(100)
	,totalarea decimal(10,2)
	,totalvolumen decimal(10,2)
	,totalpeso decimal(10,2)
	,UsuarioCreacion varchar(20)
	,FechaCreacion datetime
	,UsuarioModifica varchar(20)
	,FechaModifica datetime 
);
ALTER TABLE dbo.usuarios ADD CONSTRAINT usuarios_rol_FK FOREIGN KEY (idrol) REFERENCES dbo.rol(idrol);
ALTER TABLE dbo.proyectos ADD CONSTRAINT proyectos_usuarios_FK FOREIGN KEY (idresponsable) REFERENCES dbo.usuarios(idusuario);
ALTER TABLE dbo.partida ADD CONSTRAINT partida_proyectos_FK FOREIGN KEY (idproyecto) REFERENCES dbo.proyectos(idproyecto);
ALTER TABLE dbo.materiales ADD CONSTRAINT materiales_partida_FK FOREIGN KEY (idpartida) REFERENCES dbo.partida(idpartida);
