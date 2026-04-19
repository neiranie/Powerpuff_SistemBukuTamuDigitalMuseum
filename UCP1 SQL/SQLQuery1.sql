create database DBBukuTamuMuseum;
go
use DBBukuTamuMuseum;
go

create table Petugas (
idPetugas int identity(1,1) primary key,
nama varchar (100) not null,
username varchar (50) unique not null,
password varchar (255) not null
);

create table BukuTamu (
idTamu int identity (1,1) primary key,
namaLengkap varchar (100) not null,
asalDaerah varchar (100) not null,
keperluan varchar (200) not null,
tanggal datetime default getdate()
);

insert into Petugas (nama, username, password) values
('Admin',  'admin',   'admin123');

insert into BukuTamu (namaLengkap, asalDaerah, keperluan, tanggal) values
('Neira', 'Yogyakarta', 'Kunjungan Edukasi', '2025-01-10'),
('Fira', 'Yogyakarta', 'Penelitian', '2025-01-11'),
('Miftah', 'Yogyakarta', 'Wisata', '2025-01-12');