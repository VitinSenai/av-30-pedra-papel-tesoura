create database db_tela_login_1;
use db_tela_login_1;

Create table Usuario (
    id int primary key auto_increment,
    email varchar(255) not null unique,
    senha varchar(255) not null
);