create database Biletarnica1
use Biletarnica1

--drop database Biletarnica1
--drop table Zaposleni
--drop table Film
--drop table Cenovnik
--drop table Termin
--drop table Sala
--drop table Sediste
--drop table Vezna
--drop table Rezervacija_Prodaja

create table Zaposleni(
id int identity(1 ,1) primary key,
ime nvarchar(30), 
prezime nvarchar(30),
jmbg int,
email nvarchar(40),
pass nvarchar(20),
uloga int,
radno_vreme int,
satnica int
)

create table Film (
id int identity (1 ,1) primary key,
naziv nvarchar(40),
zanrovi nvarchar (40),
duzina_min int,
premijera date,
reziser nvarchar(30)
)

create table Cenovnik (
id int identity (1, 1) primary key,
id_filma int foreign key references Film(id),
cena int
)

create table Termin (
id int identity (1, 1) primary key,
datum date,
vreme time
)

create table Sala (
id int identity (1,1) primary key,
broj_redova int, 
broj_sedista int
)

create table Sediste (
id int identity (1,1) primary key,
id_sale int foreign key references Sala(id),
red int,
broj int
)

create table Vezna(
id_filma int foreign key references Film(id),
id_termina int foreign key references Termin(id),
id_sale int foreign key references Sala(id) 
)

create table Rezervacija_Prodaja(
id int identity (1,1) primary key,
id_filma int foreign key references Film(id),
id_termina int foreign key references Termin(id),
id_sedista int foreign key references Sediste(id),
rez_prod nvarchar(15)
)

insert into Zaposleni
values ('Miroslav', 'Milanovic', 23987482, 'miki.milanovic27@gmail.com', 'lozinka', 3, 8, 2000),
('Miodrag', 'Dragicevic', 239435345, 'aaaa@gmail.com', 'lozinka', 1, 8, 300),
('Dragomir', 'Lekovic', 123423452, 'bbbb@gmail.com', 'lozinka', 1, 8, 300),
('Igor', 'Janjic', 342303924, 'cccc@gmail.com', 'lozinka', 2, 8, 500),
('Matija', 'Nikolic', 23988392, 'dddd@gmail.com', 'lozinka', 1, 8, 300),
('Andrej', 'Dragutinovic', 42343239, 'eeee@gmail.com', 'lozinka', 2, 8, 500),
('Neda', 'Kovacevic', 23438392, 'ffff@gmail.com', 'lozinka', 1, 8, 300),
('Tijana', 'Knezevic', 23948392, 'gggg@gmail.com', 'lozinka', 2, 8, 500)
 
 
 insert into Film
 values ('Betmen', 'akcija, drama, krimi', 176, '2022-03-03', 'Met Rivis'),
 ('Bez signala', 'komedija, romantika',	94,	'2022-05-12', 'Debra Neil-Fisher'),
 ('Dauntonska opatija - nova epoha', 'drama', 125,'2022-05-12',	'Dzulijan Felouz'),
 ('Doktor Sterjndz', 'akcija, avantura, fantazija',	126,	'2022-05-05',	'Skot Derikson'),
 ('Heroj',	'drama',	127,	'2022-05-12',	'Sriram Adittya'),
 ('Izgubljeni grad',	'akcija, komedija, romantika', 122,	'2022-03-31',''	),
 ('Morbius',	'akcija, drama, avantura',	108,	'2022-03-31',	'Daniel Espinosa')
 
 insert into Cenovnik
 values(1, 600),
 (2, 550), 
 (3, 570), 
 (4, 640), 
 (5, 500), 
 (6, 650), 
 (7, 590)
 
 insert into Termin
 values ('2022-05-13', '11:30'),
 ('2022-05-13', '13:00'),
 ('2022-05-13', '17:30'),
 ('2022-05-13', '20:00'),
 ('2022-05-14', '11:30'),
 ('2022-05-14', '13:00'),
 ('2022-05-14', '17:30'),
 ('2022-05-14', '20:00'),
 ('2022-05-15', '11:30'),
 ('2022-05-15', '13:00'),
 ('2022-05-15', '17:30'),
 ('2022-05-15', '20:00')
 
 insert into Sala
 values (5, 7),
 (4, 6),
 (5, 7),
 (4 ,6),
 (5 ,7)
 
 insert into Sediste 
 values (1, 1, 1),(1, 1, 2),(1, 1, 3),(1, 1, 4),(1, 1, 5),(1, 1, 6),(1, 1, 7),
 (1, 2, 1),(1, 2, 2),(1, 2, 3),(1, 2, 4),(1, 2, 5),(1, 2, 6),(1, 2, 7),
 (1, 3, 1),(1, 3, 2),(1, 3, 3),(1, 3, 4),(1, 3, 5),(1, 3, 6),(1, 3, 7),
 (1, 4, 1),(1, 4, 2),(1, 4, 3),(1, 4, 4),(1, 4, 5),(1, 4, 6),(1, 4, 7),
 (1, 5, 1),(1, 5, 2),(1, 5, 3),(1, 5, 4),(1, 5, 5),(1, 5, 6),(1, 5, 7),
 (2, 1, 1),(2, 1, 2),(2, 1, 3),(2, 1, 4),(2, 1, 5),(2, 1, 6),
 (2, 2, 1),(2, 1, 2),(2, 2, 3),(2, 2, 4),(2, 2, 5),(2, 2, 6),
 (2, 3, 1),(2, 3, 2),(2, 3, 3),(2, 3, 4),(2, 3, 5),(2, 3, 6),
 (2, 4, 1),(2, 4, 2),(2, 4, 3),(2, 4, 4),(2, 4, 5),(2, 4, 6),
 (3, 1, 1),(3, 1, 2),(3, 1, 3),(3, 1, 4),(3, 1, 5),(3, 1, 6),(3, 1, 7),
 (3, 2, 1),(3, 2, 2),(3, 2, 3),(3, 2, 4),(3, 2, 5),(3, 2, 6),(3, 2, 7),
 (3, 3, 1),(3, 3, 2),(3, 3, 3),(3, 3, 4),(3, 3, 5),(3, 3, 6),(3, 3, 7),
 (3, 4, 1),(3, 4, 2),(3, 4, 3),(3, 4, 4),(3, 4, 5),(3, 4, 6),(3, 4, 7),
 (3, 5, 1),(3, 5, 2),(3, 5, 3),(3, 5, 4),(3, 5, 5),(3, 5, 6),(3, 5, 7),
 (4, 1, 1),(4, 1, 2),(4, 1, 3),(4, 1, 4),(4, 1, 5),(4, 1, 6),
 (4, 2, 1),(4, 1, 2),(4, 2, 3),(4, 2, 4),(4, 2, 5),(4, 2, 6),
 (4, 3, 1),(4, 3, 2),(4, 3, 3),(4, 3, 4),(4, 3, 5),(4, 3, 6),
 (4, 4, 1),(4, 4, 2),(4, 4, 3),(4, 4, 4),(4, 4, 5),(4, 4, 6),
 (5, 1, 1),(5, 1, 2),(5, 1, 3),(5, 1, 4),(5, 1, 5),(5, 1, 6),(5, 1, 7),
 (5, 2, 1),(5, 2, 2),(5, 2, 3),(5, 2, 4),(5, 2, 5),(5, 2, 6),(5, 2, 7),
 (5, 3, 1),(5, 3, 2),(5, 3, 3),(5, 3, 4),(5, 3, 5),(5, 3, 6),(5, 3, 7),
 (5, 4, 1),(5, 4, 2),(5, 4, 3),(5, 4, 4),(5, 4, 5),(5, 4, 6),(5, 4, 7),
 (5, 5, 1),(5, 5, 2),(5, 5, 3),(5, 5, 4),(5, 5, 5),(5, 5, 6),(5, 5, 7)
 
 insert into Vezna
 values (1,2,4),
 (2, 12, 1),
 (3, 7, 2),
 (4, 11, 1),
 (5, 3, 3),
 (6, 4, 5),
 (7, 10, 2)
 
 insert into Rezervacija_Prodaja 
 values (2, 12, 22, 'rezervacija'),
 (4, 11, 25, 'prodaja')
 

