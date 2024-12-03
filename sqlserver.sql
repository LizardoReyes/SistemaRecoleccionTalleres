CREATE DATABASE talleres
GO

USE talleres
GO

CREATE TABLE Estudiante (
    CodigoAlumno INT PRIMARY KEY,
    NombreAlumno VARCHAR(50) NOT NULL,
    Nivel INT NOT NULL
);
GO

CREATE TABLE Pagos (
    IdPago INT PRIMARY KEY IDENTITY(1,1),
    CodigoAlumno INT NOT NULL,
    CuotasPagadas INT NOT NULL,
    TalleresInscritos INT NOT NULL,
    FOREIGN KEY (CodigoAlumno) REFERENCES Estudiante(CodigoAlumno)
);
GO

CREATE TABLE Taller (
	IdTaller INT PRIMARY KEY IDENTITY(1,1),
	NombreTaller VARCHAR(50) NOT NULL
);

SELECT * FROM Estudiante
SELECT * FROM Pagos