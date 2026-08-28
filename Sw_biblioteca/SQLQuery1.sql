CREATE DATABASE Biblioteca;
USE Biblioteca;

CREATE TABLE Autores
(
    IdAutor INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL
);

CREATE TABLE Editoriales
(
    IdEditorial INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(150) NOT NULL
);

CREATE TABLE Libros
(
    ISBN VARCHAR(20) PRIMARY KEY,
    Titulo VARCHAR(200) NOT NULL,
    IdAutor INT NOT NULL,
    IdEditorial INT NOT NULL,
    Categoria VARCHAR(100),
    Anio INT,
    Existencias INT NOT NULL,

    CONSTRAINT FK_Libros_Autores
        FOREIGN KEY (IdAutor)
        REFERENCES Autores(IdAutor),

    CONSTRAINT FK_Libros_Editoriales
        FOREIGN KEY (IdEditorial)
        REFERENCES Editoriales(IdEditorial)
);

CREATE TABLE Usuarios
(
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Documento VARCHAR(30) NOT NULL UNIQUE,
    Telefono VARCHAR(30),
    Correo VARCHAR(150)
);

CREATE TABLE Prestamos
(
    IdPrestamo INT IDENTITY(1,1) PRIMARY KEY,
    IdUsuario INT NOT NULL,
    ISBN VARCHAR(20) NOT NULL,
    FechaPrestamo DATE NOT NULL,
    FechaDevolucion DATE NULL,
    Estado VARCHAR(20) NOT NULL,

    CONSTRAINT FK_Prestamos_Usuarios
        FOREIGN KEY (IdUsuario)
        REFERENCES Usuarios(IdUsuario),

    CONSTRAINT FK_Prestamos_Libros
        FOREIGN KEY (ISBN)
        REFERENCES Libros(ISBN)
);

INSERT INTO Usuarios
    (Nombre, Apellido, Documento, Telefono, Correo)
VALUES
    ('Ana', 'Pérez', '1001001001', '3001234567', 'ana@gmail.com'),
    ('Carlos', 'Gómez', '1001001002', '3012345678', 'carlos@gmail.com'),
    ('María', 'Rodríguez', '1001001003', '3023456789', 'maria@gmail.com'),
    ('Laura', 'Martínez', '1001001004', '3034567890', 'laura.martinez@gmail.com'),
    ('Andrés', 'López', '1001001005', '3045678901', 'andres.lopez@gmail.com'),
    ('Sofía', 'Hernández', '1001001006', '3056789012', 'sofia.hernandez@gmail.com'),
    ('Daniel', 'Torres', '1001001007', '3067890123', 'daniel.torres@gmail.com'),
    ('Mariana', 'Ramírez', '1001001008', '3078901234', 'mariana.ramirez@gmail.com'),
    ('Felipe', 'Castro', '1001001009', '3089012345', 'felipe.castro@gmail.com'),
    ('Valentina', 'Morales', '1001001010', '3090123456', 'valentina.morales@gmail.com');

INSERT INTO Autores (Nombre, Apellido)
VALUES
('Gabriel', 'García Márquez'),
('Julio', 'Cortázar'),
('Isabel', 'Allende'),
('George', 'Orwell'),
('Miguel', 'de Cervantes'),
('Jane', 'Austen'),
('Julio', 'Cortázar'),
('Isabel', 'Allende'),
('Mario', 'Vargas Llosa'),
('Jorge Luis', 'Borges'),
('Antoine', 'de Saint-Exupéry'),
('Ernest', 'Hemingway');


INSERT INTO Editoriales (Nombre)
VALUES
('Planeta'),
('Alfaguara'),
('Penguin Random House'),
('Debolsillo'),
('Anagrama'),
('Seix Barral'),
('Tusquets Editores');

INSERT INTO Libros
    (ISBN, Titulo, IdAutor, IdEditorial, Categoria, Anio, Existencias)
VALUES

('9780307474728', 'Cien años de soledad', 1, 1, 'Novela', 1967, 5),

('9780451524935', '1984', 4, 3, 'Distopía', 1949, 4),

('9780060934347', 'Don Quijote de la Mancha', 5, 1, 'Novela', 1605, 3),

('9780141439518', 'Orgullo y prejuicio', 6, 4, 'Novela romántica', 1813, 5),

('9788437604947', 'Rayuela', 2, 2, 'Novela', 1963, 2),

('9788401352836', 'La casa de los espíritus', 3, 1, 'Realismo mágico', 1982, 4),

('9788420471839', 'La ciudad y los perros', 9, 6, 'Novela', 1963, 3),

('9788420633114', 'Ficciones', 10, 7, 'Cuentos', 1944, 2),

('9780156012195', 'El principito', 11, 3, 'Literatura infantil', 1943, 6),

('9780684830490', 'El viejo y el mar', 12, 5, 'Novela', 1952, 3),

('9780307389732', 'El amor en los tiempos del cólera', 1, 1, 'Novela', 1985, 4);

INSERT INTO Prestamos
    (IdUsuario, ISBN, FechaPrestamo, FechaDevolucion, Estado)
VALUES
    (1, '9780307474728', GETDATE(), NULL, 'Prestado');


INSERT INTO Prestamos
    (IdUsuario, ISBN, FechaPrestamo, FechaDevolucion, Estado)
SELECT 
    U.IdUsuario,
    L.ISBN,
    V.FechaPrestamo,
    V.FechaDevolucion,
    V.Estado
FROM
(
    VALUES
        (2,  '1984',                         '2026-08-05', '2026-08-14', 'Devuelto'),
        (3,  'Don Quijote de la Mancha',     '2026-08-07', NULL,         'Prestado'),
        (5,  'El amor en los tiempos del cólera', '2026-08-08', '2026-08-16', 'Devuelto'),
        (6,  'El principito',                '2026-08-09', NULL,         'Prestado'),
        (7,  'El viejo y el mar',            '2026-08-10', '2026-08-15', 'Devuelto'),
        (8,  'Ficciones',                    '2026-08-11', NULL,         'Prestado'),
        (9,  'La casa de los espíritus',     '2026-08-12', '2026-08-17', 'Devuelto'),
        (10, 'La ciudad y los perros',       '2026-08-13', NULL,         'Prestado'),
        (11, 'Orgullo y prejuicio',          '2026-08-14', '2026-08-18', 'Devuelto')
) AS V(IdUsuario, Titulo, FechaPrestamo, FechaDevolucion, Estado)
INNER JOIN Usuarios U
    ON U.IdUsuario = V.IdUsuario
INNER JOIN Libros L
    ON L.Titulo = V.Titulo;

