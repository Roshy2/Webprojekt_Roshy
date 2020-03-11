create database db_shop collate utf8_general_ci;
use db_shop;

create table item(
	id int not null auto_increment,
    item_name varchar(100) not null,
    preis int not null,
    model varchar(100) null,
    kategorie varchar(100) not null,
    marke varchar(100)null,
    bildpfad varchar(1000) not null,
    
    constraint id_PK primary key(id)
)engine=InnoDB;


Insert into item Values(null, "Iphone 11 Pro", 1014.90, "Iphone 11 Pro white", "Smartphone", "Apple", "/Content/Images/Smartphone.jpg");
Insert into item Values(null, "hoodie", 50, "Dark Galaxie", "Kleidung", "", "/Content/Images/Hoodie.jpg");
Insert into item Values(null, "hoodie", 50, "", "Kleidung", "", "/Content/Images/Kleidung.jpg");
Insert into item Values(null, "Switch", 299.99, "Classic", "Spiele", "Nintendo", "/Content/Images/switch.jpg");
Insert into item Values(null, "Bohrmaschine", 29.85, "", "Werkzeug", "Hitachi", "/Content/Images/Werkzeug.jpg");

select * from item;


