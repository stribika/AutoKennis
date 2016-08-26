CREATE DATABASE "AutoKennis"
  WITH OWNER = "AutoKennis"
       ENCODING = 'UTF8'
       TABLESPACE = pg_default
       LC_COLLATE = 'Dutch_Netherlands.1252'
       LC_CTYPE = 'Dutch_Netherlands.1252'
       CONNECTION LIMIT = -1;

create table AankoopBegeleidingForm (
	Id serial not null constraint AankoopBegeleidingForm_pk primary key,
	Version integer not null,
	Attrs jsonb not null,
	Sent boolean not null default false
);

create table AankoopKeuringForm (
	Id serial not null constraint AankoopKeuringForm_pk primary key,
	Version integer not null,
	Attrs jsonb not null,
	Sent boolean not null default false
);

create table AutoAdviesForm (
	Id serial not null constraint AutoAdviesForm_pk primary key,
	Version integer not null,
	Attrs jsonb not null,
	Sent boolean not null default false
);

create table GarantieKeuringForm (
	Id serial not null constraint GarantieKeuringForm_pk primary key,
	Version integer not null,
	Attrs jsonb not null,
	Sent boolean not null default false
);

create table ReparatieKeuringForm (
	Id serial not null constraint ReparatieKeuringForm_pk primary key,
	Version integer not null,
	Attrs jsonb not null,
	Sent boolean not null default false
);

create table EmailReceivers (
	Email text not null constraint EmailRecevers_pk primary key
);

create table RegisteredUser (
	Name text not null constraint UserPk primary key,
	PasswordSalt bytea not null,
	PasswordHash bytea not null
);