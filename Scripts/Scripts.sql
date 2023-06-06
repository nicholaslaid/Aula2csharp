DROP TABLE IF EXISTS sellers;
CREATE TABLE IF NOT EXISTS sellers(
	id SERIAL PRIMARY KEY,
	name VARCHAR(50),
	cnpj VARCHAR(50),
	email VARCHAR(50),
	phone VARCHAR(50)
);

INSERT INTO sellers(name, cnpj, email, phone) VALUES ('Magazine Luiza', '1111111111', 'magazine@gmail.com', '(54)99999-9999');
INSERT INTO sellers(name, cnpj, email, phone) VALUES ('Kabum', '22222222222', 'kabum@gmail.com', '(54)88888-8888');
INSERT INTO sellers(name, cnpj, email, phone) VALUES ('Ali Express', '33333333333333', 'ali@gmail.com', '(54)77777-7777');
INSERT INTO sellers(name, cnpj, email, phone) VALUES ('Amazon', '444444444', 'amazon@gmail.com', '(54)66666-6666');

SELECT * FROM sellers;

SELECT * FROM products;

Drop table if exists products;
Create table if not exists products (
	id serial primary key,
	id_seller INTEGER REFERENCES sellers,
	name Varchar(50),
	model Varchar(50),
	quantity Integer,
	value real,
	national BOOLEAN DEFAULT true,
	status VARCHAR(50)
); 

SELECT p.id, p.id_seller, p.name, p.model, p.quantity, p.value,
p.national, p.status, p.name as seller_name
From products p, sellers s
WHERE p.id_seller = s.id;

