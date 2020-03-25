create database db_shop collate utf8_general_ci;
use db_shop;

create table item(
	id int not null auto_increment,
    item_name varchar(100) not null,
    preis int not null,
    model varchar(100) null,
    kategorie_id int not null,
    kategorie varchar(100)  not null,
    marke varchar(100)null,
    bildpfad varchar(1000) not null,
    
    constraint id_PK primary key(id)
)engine=InnoDB;

-- Smartphone= 1, Kleidung= 2,Gartenausstattung= 3,Werkzeug= 4, Spiele= 5
Insert into item Values(null, "Iphone 11 Pro", 1014.90, "Iphone 11 Pro white", "1", "Smartphone","Apple", "/Content/Images/Smartphone.jpg");
Insert into item Values(null, "hoodie", 50, "Dark Galaxie", "2", "Kleidung","", "/Content/Images/Hoodie.jpg");
Insert into item Values(null, "hoodie", 50, "", "2", "Kleidung","", "/Content/Images/Kleidung.jpg");
Insert into item Values(null, "Switch", 299.99, "Classic", "5", "Spiele","Nintendo", "/Content/Images/switch.jpg");
Insert into item Values(null, "Bohrmaschine", 29.85, "", "4", "Werkzeug","Hitachi", "/Content/Images/Werkzeug.jpg");

select * from item;
select kategorie from item ;

