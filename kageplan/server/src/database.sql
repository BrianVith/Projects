--create extension if not exists "uuid-ossp";

--drop table cakes;
--drop table users;

create table users(
user_id serial,
user_name varchar(255) not null,
user_email varchar(255) not null unique,
user_password varchar(255) not null,
primary key(user_id)
);

create table cakes(
cake_id serial,
user_id serial,
cake_type varchar(255),
cake_occasion varchar(255),
start_date timestamp,
end_date timestamp,
primary key(cake_id),
foreign key(user_id) references users(user_id)
);