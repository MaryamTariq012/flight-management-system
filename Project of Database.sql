CREATE DATABASE FlightManagementSystem;

use FlightManagementSystem;
CREATE TABLE Users (
    user_id INT PRIMARY KEY,
    first_name VARCHAR(100),
    last_name VARCHAR(100),
    gender VARCHAR(255),
    phone VARCHAR(15),
    address VARCHAR(255),
    DOB VARCHAR(15),
	Password VARCHAR(50),
);

CREATE TABLE Airlines (
    airline_id INT PRIMARY KEY,
    airline_name VARCHAR(100),
    contact_phone VARCHAR(15)
);

CREATE TABLE Flights (
    flight_id INT PRIMARY KEY,
    flight_name VARCHAR(50),
    destination VARCHAR(100),
    distance VARCHAR(100),
    departure_time DATETIME,
    arrival_time DATETIME,
	airline_id INT,
    FOREIGN KEY (airline_id) REFERENCES Airlines(airline_id)
);

CREATE TABLE Classes (
    class_id INT PRIMARY KEY,
    class_name VARCHAR(50),
);

CREATE TABLE PaymentMethods (
    payment_Methods_id INT PRIMARY KEY,
    payment_Methods_name VARCHAR(50),
);

CREATE TABLE Tickets (
    ticket_id INT PRIMARY KEY,
    user_id INT,
    flight_id INT,
    ticket_class_id INT,
    ticket_price DECIMAL(10, 2),
    booking_date DATETIME,
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (flight_id) REFERENCES Flights(flight_id),
    FOREIGN KEY (ticket_class_id) REFERENCES Classes(class_id),
);

CREATE TABLE Payments (
    payment_id INT PRIMARY KEY,
    ticket_id INT,
    payment_method_id INT,
    amount_paid DECIMAL(10, 2),
    payment_date DATETIME,
	FOREIGN KEY (payment_method_id) REFERENCES PaymentMethods(payment_Methods_id),
    FOREIGN KEY (ticket_id) REFERENCES Tickets(ticket_id)
);

-- Insert data into the Users table
INSERT INTO Users (user_id, first_name, last_name, gender, phone, address, DOB,Password)
VALUES
(1, 'John', 'Doe', 'Male', '123-456-7890', '123 Elm St, New York, NY', '1994-05-20','123'),
(2, 'Jane', 'Smith', 'Female', '987-654-3210', '456 Oak St, Los Angeles, CA', '1999-08-15','123'),
(3, 'Michael', 'Johnson', 'Male', '555-123-4567', '789 Pine St, Chicago, IL', '1989-11-12','123'),
(4, 'Emily', 'Davis', 'Female', '321-654-9870', '321 Birch St, Houston, TX', '1996-02-10','123'),
(5, 'David', 'Miller', 'Male', '444-567-8901', '654 Cedar St, Miami, FL', '1984-06-22','123');

-- Insert data into the Airlines table
INSERT INTO Airlines (airline_id, airline_name, contact_phone)
VALUES
(1, 'American Airlines', '800-433-7300'),
(2, 'British Airways', '800-247-9297'),
(3, 'Emirates', '800-777-3999'),
(4, 'Air India', '1800-180-1407'),
(5, 'Qatar Airways', '800-100-000');

-- Insert data into the Flights table
INSERT INTO Flights (flight_id, flight_name, destination, distance, departure_time, arrival_time,airline_id)
VALUES
(1, 'Flight AA101', 'Los Angeles', '2450 miles', '2024-12-10 08:00:00', '2024-12-10 11:30:00',1),
(2, 'Flight BA202', 'London', '4000 miles', '2024-12-11 15:00:00', '2024-12-11 23:45:00',2),
(3, 'Flight EK303', 'Dubai', '6500 miles', '2024-12-12 12:00:00', '2024-12-13 05:00:00',3),
(4, 'Flight AI404', 'New Delhi', '8000 miles', '2024-12-13 06:30:00', '2024-12-13 22:00:00',4),
(5, 'Flight QR505', 'Doha', '7000 miles', '2024-12-14 14:00:00', '2024-12-14 22:30:00',5);

-- Insert data into the Classes table
INSERT INTO Classes (class_id, class_name)
VALUES
(1, 'Economy'),
(2, 'Business'),
(3, 'First Class'),
(4, 'Business');

-- Insert data into the Payment_Methods table
INSERT INTO PaymentMethods (payment_Methods_id, payment_Methods_name)
VALUES
(1, 'Cradit Card'),
(2, 'Debit Card'),
(3, 'PayPal');

-- Insert data into the Tickets table
INSERT INTO Tickets (ticket_id, user_id, flight_id, ticket_class_id, ticket_price, booking_date)
VALUES
(1, 1, 1, 1, 300.00, '2024-12-01 10:00:00'),
(2, 2, 2, 2, 1200.00, '2024-12-02 14:00:00'),
(3, 3, 3, 3, 3500.00, '2024-12-03 16:00:00'),
(4, 4, 4, 4, 450.00, '2024-12-04 11:30:00'),
(5, 5, 5, 4, 2000.00, '2024-12-05 09:00:00');


-- Insert data into the payment table
INSERT INTO Payments (payment_id, ticket_id, payment_method_id, amount_paid, payment_date)
VALUES
(1, 1, 1, 300.00, '2024-12-01 10:30:00'),
(2, 2, 2, 1200.00, '2024-12-02 14:30:00'),
(3, 3, 1, 3500.00, '2024-12-03 16:30:00'),
(4, 4, 3, 450.00, '2024-12-04 12:00:00'),
(5, 5, 1, 2000.00, '2024-12-05 09:30:00');

--use FlightManagementSystem;
--DROP TABLE IF EXISTS Payments;
--DROP TABLE IF EXISTS Tickets;
--DROP TABLE IF EXISTS PaymentMethods;
--DROP TABLE IF EXISTS Classes;
--DROP TABLE IF EXISTS Flights;
--DROP TABLE IF EXISTS Airlines;
--DROP TABLE IF EXISTS Users;

