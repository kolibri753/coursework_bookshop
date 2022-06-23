create database bookshop;
USE bookshop;

SELECT * FROM customer;
SELECT * FROM book;
SELECT * FROM genre;
SELECT * FROM author;
SELECT * FROM publisher;
SELECT * FROM `order`;
SELECT * FROM book_order;
SELECT * FROM order_book_customer;

SELECT * FROM book_order;
SELECT * FROM order_book_customer WHERE order_id = 1;
SELECT * FROM order_book_customer WHERE customer_id = 2;

SELECT * from user_order;

DROP VIEW order_book_customer;

CREATE VIEW user_order
AS
SELECT book_id, title, pages, price, quantity, genre_name, author_name, publisher_name 
FROM book 
JOIN genre 
	ON genre.genre_id = book.genre_id 
JOIN author
	ON author.author_id = book.author_id 
JOIN publisher 
	ON publisher.publisher_id = book.publisher_id 
ORDER BY book_id;

CREATE TABLE customer (
	customer_id INT NOT NULL AUTO_INCREMENT,
    customer_name VARCHAR(50) NOT NULL,
	phone VARCHAR(15) NOT NULL,
	email VARCHAR(30) NOT NULL,
	address VARCHAR(50) NOT NULL,
	username VARCHAR(30) NOT NULL,
	password VARCHAR(30) NOT NULL,
	PRIMARY KEY (customer_id));
    
CREATE TABLE genre (
	genre_id INT NOT NULL AUTO_INCREMENT,
	genre_name VARCHAR(30) NOT NULL,
	PRIMARY KEY (genre_id));
  
CREATE TABLE author (
	author_id INT NOT NULL AUTO_INCREMENT,
	author_name VARCHAR(30) NOT NULL,
	PRIMARY KEY (author_id));
    
CREATE TABLE publisher (
	publisher_id INT NOT NULL AUTO_INCREMENT,
	publisher_name VARCHAR(30) NOT NULL,
	PRIMARY KEY (publisher_id));

CREATE TABLE book (
	book_id INT NOT NULL AUTO_INCREMENT,
	title VARCHAR(50) NOT NULL,
	pages INT NULL,
	price INT NOT NULL,
	quantity INT,
    genre_id INT,
	author_id INT,
	publisher_id INT,
	PRIMARY KEY (book_id),
	FOREIGN KEY (genre_id) REFERENCES genre(genre_id) ON DELETE SET NULL,
    FOREIGN KEY (author_id) REFERENCES author(author_id) ON DELETE SET NULL,
    FOREIGN KEY (publisher_id) REFERENCES publisher(publisher_id) ON DELETE SET NULL);    
    
CREATE TABLE `order` (
	order_id INT NOT NULL AUTO_INCREMENT,
	total_price INT,
    customer_id INT,
	PRIMARY KEY (order_id),
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id) ON DELETE SET NULL);

CREATE TABLE book_order (
	book_order_id INT NOT NULL AUTO_INCREMENT,
	quantity INT NOT NULL,
	book_price INT,
	order_id INT,
    book_id INT,
    PRIMARY KEY (book_order_id),
	FOREIGN KEY (book_id) REFERENCES book(book_id) ON DELETE SET NULL,
    FOREIGN KEY (order_id) REFERENCES `order`(order_id) ON DELETE SET NULL);
    
CREATE VIEW order_book_customer
AS
SELECT book_order.order_id, book.book_id, title, book_order.quantity, total_price, customer.customer_id, customer_name
FROM book_order
JOIN `order`
	ON book_order.order_id = `order`.order_id
JOIN book
	ON book_order.book_id = book.book_id
JOIN customer
	ON `order`.customer_id = customer.customer_id
ORDER BY order_id;    
    
INSERT INTO genre (genre_name) VALUES ('adventure'), ('fantasy'), ('dystopian'), ('mystery'), ('thriller'), ('sci-fi'), ('horror'), ('drama'), ('novel'), ('crime');

INSERT INTO author (author_name) VALUES ('J. K. Rowling'), ('Ray Bradbury'), ('George R.R. Martin'), ('Dan Brown'), ('Stephenie Meyer'), ('Alice Sebold'), ('Khaled Hosseini'), ('Mark Haddon'), ('Julia Donaldson'), ('J. R. R. Tolkien');

INSERT INTO publisher (publisher_name) VALUES ('Ababagalamaga'), ('Penguin Random House'), ('Bantam Spectra'), ('Doubleday'), ('Bloomsbury'), ('Ballantine Books'), ('Pocket Books'), ('Little, Brown and Company'), ('Riverhead Books'), ('Jonathan Cape'), ('Allen & Unwin');

INSERT INTO book (title, pages, price, quantity, genre_id, author_id, publisher_id) VALUES 
('A Game of Thrones', 694, 610, 100, 2, 3, 3),
('A Clash of Kings', 768, 700, 100, 2, 3, 3),
('A Storm of Swords', 973, 820, 120, 2, 3, 3),											
('A Feast for Crows', 753, 680, 110, 2, 3, 3),
('A Dance with Dragons', 1056, 900, 90, 2, 3, 3),
('Harry Potter and the Philosopher`s Stone', 223, 250, 100, 2, 1, 1),
('Harry Potter and the Chamber of Secrets', 251, 260, 100, 2, 1, 1),
('Harry Potter and the Prisoner of Azkaban', 317, 280, 100, 2, 1, 1),
('Harry Potter and the Goblet of Fire', 636, 550, 100, 2, 1, 1),
('Harry Potter and the Order of the Phoenix', 766, 700, 120, 2, 1, 1),
('Harry Potter and the Half-Blood Prince', 607, 510, 100, 2, 1, 1),
('Harry Potter and the Deathly Hallows', 607, 510, 100, 2, 1, 1),
('The October Country', 306, 480, 90, 7, 2, 6),
('The Martian Chronicles', 222, 250, 100, 6, 2, 4),
('Fahrenheit 451', 256, 260, 100, 3, 2, 6),
('Angels & Demons', 616, 480, 150, 5, 4, 7),
('Twilight', 544, 300, 150, 2, 5, 8),
('The Lovely Bones', 328, 200, 120, 9, 6, 8),
('The Kite Runner', 371, 300, 150, 8, 7, 9),
('The Curious Incident of the Dog in the Night-Time', 274, 300, 130, 9, 8, 10),
('The Gruffalo', 32, 100, 100, 2, 9, 11),
('The Lord of the Rings', 1137, 1000, 80, 2, 10, 11);    
    
INSERT INTO customer (customer_name, phone, email, address, username, `password`) VALUES 
('Vira Vakhovska', '123 123 1234', 'vahovskavm2003@gmail.com', 'Ukraine, Khmelnytskyi', 'admin', 'admin'),
('Vanya Gordiy', '123 123 1234', 'vanya@gmail.com', 'Elm street 24', 'vanya', '1111'),
('Bogdan Boyko', '123 123 1234', 'boyko@gmail.com', 'Shevhenko 27/2', 'bogdan', '1234'),
('Rose Ellen Dix', '123 123 1234', 'rosedix@gmail.com', 'London, Abrakadabra', 'roseellendix', '1234'),
('Shannon Beveridge', '123 123 1234', 'shannon3@gmail.com', 'Norman, Oklahoma', 'shannon', '1111'),
('Miles Mckenna', '123 123 1234', 'mckenna@gmail.com', 'Orange County, California', 'miles', '1111'),
('Rosie Spaughton', '123 123 1234', 'rosie2003@gmail.com', 'London, Abrakadabra', 'rosie', '1234'),
('Cammie Scott', '123 123 1234', 'cammie2003@gmail.com', 'Elm street 22', 'cammie', '1111'),
('Pavlo Kalina', '123 123 1234', 'kalina@gmail.com', 'Shevhenko 25/2', 'kalina', '1111'),
('Vasya Puplin', '123 123 1234', 'vasyapuplin@gmail.com', 'Ukraine, Khmelnytskyi', 'vasya', '1111');


SELECT * FROM `customer` WHERE `username` = "vanya";

CREATE VIEW order_book_customer
AS
SELECT bo.order_id, book.book_id, title, bo.quantity, ROUND(book_price/bo.quantity) AS book_price, customer.customer_id, customer_name
FROM book_order bo
JOIN `order`
	ON bo.order_id = `order`.order_id
JOIN book
	ON bo.book_id = book.book_id
JOIN customer
	ON `order`.customer_id = customer.customer_id
ORDER BY order_id;  


