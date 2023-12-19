create database	BD_Gerardo
go

use BD_Gerardo
go

create table Partidospoliticos(
codigo INT,
nombrepartidos VARCHAR(100) NOT NULL,
);
go

insert into Partidospoliticos (codigo, nombrepartidos)
VALUES (1,'Partido Liberaci�n Nacional'), (2, 'Partido Unidad Social Cristiana'), (3, 'Partido Acci�n Ciudadana')

CREATE TABLE EncuestaParticipantes (
    NumeroEncuesta INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Edad INT NOT NULL,
    CorreoElectronico VARCHAR(50) NOT NULL,
    PartidoPolitico VARCHAR(100) NOT NULL,  
);

